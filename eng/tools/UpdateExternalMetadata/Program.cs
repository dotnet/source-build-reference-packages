// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Build.Evaluation;
using SbrpUtilities;
using static SbrpUtilities.CommonUtilities;

if (args.Length < 1)
{
    Console.Error.WriteLine("Usage: UpdateExternalMetadata <component-name>");
    Console.Error.WriteLine("Example: UpdateExternalMetadata azure-activedirectory-identitymodel-extensions-for-dotnet");
    return 1;
}

string componentName = args[0];

// Find repo root
string repoRoot = RunGit("rev-parse --show-toplevel").Trim();
string projFile = Path.Combine(repoRoot, "src", "externalPackages", "projects", $"{componentName}.proj");
string submoduleDir = Path.Combine(repoRoot, "src", "externalPackages", "src", componentName);

if (!File.Exists(projFile))
{
    Console.Error.WriteLine($"Error: Project file not found: {projFile}");
    return 1;
}

if (!Directory.Exists(submoduleDir))
{
    Console.Error.WriteLine($"Error: Submodule directory not found: {submoduleDir}");
    return 1;
}

// Two views of the .proj coexist:
//   (1) MSBuild evaluation — authoritative for which validation items exist, which property
//       names they bind to (including ItemDefinitionGroup defaults), and the evaluated
//       property values.
//   (2) XDocument + line-buffer — used solely for surgical in-place updates that preserve
//       formatting exactly. MSBuild's XML round-tripping reflows the file in ways we do
//       not want (XML decl, attribute layout, whitespace), so writes go through the
//       line buffer instead.
Project project = LoadValidationProject(projFile);

string projContent = File.ReadAllText(projFile);
string newline = projContent.Contains("\r\n") ? "\r\n" : "\n";
List<string> lines = new(projContent.Split(new[] { newline }, StringSplitOptions.None));
XDocument projDoc = XDocument.Parse(projContent, LoadOptions.PreserveWhitespace | LoadOptions.SetLineInfo);

// --- 1. Update SourceRevisionId ---
string commitHash = RunGit($"-C \"{submoduleDir}\" rev-parse HEAD").Trim();

XElement? sourceRevisionIdEl = FindPropertyElement(projDoc, "SourceRevisionId");

if (sourceRevisionIdEl is not null)
{
    string oldValue = sourceRevisionIdEl.Value;
    UpdatePropertyLine(lines, sourceRevisionIdEl, "SourceRevisionId", commitHash);
    Console.WriteLine($"Updated SourceRevisionId: {oldValue} -> {commitHash}");
}
else
{
    Console.WriteLine("No SourceRevisionId property found - skipping.");
}

// --- 2. Update package-derived version metadata for each <FileVersionValidationPackage> item ---
IReadOnlyList<ValidationPackageItem> validationItems = ParseValidationPackageItems(project);

if (validationItems.Count == 0)
{
    Console.WriteLine("No <FileVersionValidationPackage> items configured - skipping metadata update.");
    File.WriteAllText(projFile, string.Join(newline, lines));
    Console.WriteLine($"Saved changes to {componentName}.proj");
    return 0;
}

string versionsPropsPath = Path.Combine(repoRoot, "eng", "Versions.props");
Project versionsProject = LoadVersionsProps(versionsPropsPath);

// Cache downloads across items so multiple items sharing the same package id+version
// (a legitimate scenario, e.g. when one package contributes several aspects) don't re-fetch.
Dictionary<string, PackageVersionMetadata> metadataCache = new();

foreach (ValidationPackageItem item in validationItems)
{
    string? releaseVersion = item.ReleaseVersionPropertyName is not null
        ? FindReleaseVersionByPropertyName(versionsProject, item.ReleaseVersionPropertyName)
        : FindReleaseVersion(versionsProject, componentName);

    if (string.IsNullOrEmpty(releaseVersion))
    {
        Console.Error.WriteLine($"Error: Could not find release version for '{item.PackageId}' " +
            $"({(item.ReleaseVersionPropertyName is null ? "auto-derived" : $"property '{item.ReleaseVersionPropertyName}'")}).");
        return 1;
    }

    AspectUpdate? revUpdate = ResolveAspect(item.PackageId, item.FileVersionRevision, projDoc, "FileVersionRevisionProperty");
    AspectUpdate? avoUpdate = ResolveAspect(item.PackageId, item.AssemblyVersionOverride, projDoc, "AssemblyVersionOverrideProperty");
    AspectUpdate? ivoUpdate = ResolveAspect(item.PackageId, item.InformationalVersionOverride, projDoc, "InformationalVersionOverrideProperty");

    if (revUpdate is null && avoUpdate is null && ivoUpdate is null)
    {
        Console.WriteLine($"No override properties to update for {item.PackageId} - skipping.");
        continue;
    }

    string cacheKey = $"{item.PackageId}|{releaseVersion}";
    if (!metadataCache.TryGetValue(cacheKey, out PackageVersionMetadata? versionMetadata))
    {
        Console.WriteLine($"Downloading {item.PackageId} {releaseVersion}...");
        versionMetadata = await GetPackageVersionMetadataAsync(repoRoot, item.PackageId, releaseVersion);
        metadataCache[cacheKey] = versionMetadata;
    }

    if (revUpdate is { } rev)
    {
        if (versionMetadata.Revision is null)
        {
            Console.Error.WriteLine($"Error: Unable to get FileVersion from {item.PackageId} {releaseVersion}.");
            return 1;
        }

        string revisionStr = versionMetadata.Revision.Value.ToString();
        string oldValue = rev.Element.Value;
        UpdatePropertyLine(lines, rev.Element, rev.PropertyName, revisionStr);
        Console.WriteLine($"Updated {rev.PropertyName}: {oldValue} -> {revisionStr} " +
            $"(from {item.PackageId} {releaseVersion}, FileVersion: {versionMetadata.FileVersion})");
    }

    if (avoUpdate is { } avo)
    {
        if (string.IsNullOrEmpty(versionMetadata.AssemblyVersion))
        {
            Console.Error.WriteLine($"Error: Unable to get AssemblyVersion from {item.PackageId} {releaseVersion}.");
            return 1;
        }

        string oldValue = avo.Element.Value;
        UpdatePropertyLine(lines, avo.Element, avo.PropertyName, versionMetadata.AssemblyVersion);
        Console.WriteLine($"Updated {avo.PropertyName}: {oldValue} -> {versionMetadata.AssemblyVersion} " +
            $"(from {item.PackageId} {releaseVersion})");
    }

    if (ivoUpdate is { } ivo)
    {
        if (string.IsNullOrEmpty(versionMetadata.InformationalVersion))
        {
            Console.Error.WriteLine($"Error: Unable to get InformationalVersion from {item.PackageId} {releaseVersion}.");
            return 1;
        }

        string oldValue = ivo.Element.Value;
        UpdatePropertyLine(lines, ivo.Element, ivo.PropertyName, versionMetadata.InformationalVersion);
        Console.WriteLine($"Updated {ivo.PropertyName}: {oldValue} -> {versionMetadata.InformationalVersion} " +
            $"(from {item.PackageId} {releaseVersion})");
    }
}

File.WriteAllText(projFile, string.Join(newline, lines));
Console.WriteLine($"Saved changes to {componentName}.proj");
return 0;

// --- Helper methods ---

static string RunGit(string arguments)
{
    using Process process = new()
    {
        StartInfo = new ProcessStartInfo
        {
            FileName = "git",
            Arguments = arguments,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        }
    };

    process.Start();
    string output = process.StandardOutput.ReadToEnd();
    process.WaitForExit();

    if (process.ExitCode != 0)
    {
        string error = process.StandardError.ReadToEnd();
        throw new InvalidOperationException($"git {arguments} failed (exit {process.ExitCode}): {error}");
    }

    return output;
}

// Looks up the XElement for an aspect's target property. Returns null when the binding is
// null (item is not configured for this aspect) or when the binding came from an
// ItemDefinitionGroup default and the named property is not actually present in the .proj
// (defaulted bindings are "validate if present"). Throws when the binding was explicit on
// the item itself and the named property is missing — that always signals a configuration
// error.
static AspectUpdate? ResolveAspect(string packageId, AspectBinding? binding, XDocument doc, string metadataName)
{
    if (binding is null)
    {
        return null;
    }

    XElement? element = FindPropertyElement(doc, binding.PropertyName);
    if (element is null)
    {
        if (binding.IsExplicit)
        {
            throw new InvalidOperationException(
                $"<FileVersionValidationPackage Include=\"{packageId}\"> {metadataName} names " +
                $"property '{binding.PropertyName}' but no such property is defined in the .proj.");
        }

        return null;
    }

    return new AspectUpdate(binding.PropertyName, element);
}

static XElement? FindPropertyElement(XDocument doc, string propertyName) =>
    doc.Root?
        .Elements("PropertyGroup")
        .Elements(propertyName)
        .FirstOrDefault();

// Surgically updates the on-disk line containing a property element to a new value.
// Locates the line via the XElement's IXmlLineInfo, then runs a narrow regex on that
// single line. Comments and other PropertyGroups on different lines are not at risk
// because (a) XDocument navigation already filtered out comments, and (b) the regex
// is scoped to one line. Properties that span multiple lines (rare in .proj files)
// surface as an InvalidOperationException rather than silently no-op.
static void UpdatePropertyLine(List<string> lines, XElement element, string elementName, string newValue)
{
    IXmlLineInfo info = element;
    int lineIndex = info.LineNumber - 1;
    if (lineIndex < 0 || lineIndex >= lines.Count)
    {
        throw new InvalidOperationException(
            $"<{elementName}> line {info.LineNumber} is out of range (file has {lines.Count} lines).");
    }

    string originalLine = lines[lineIndex];
    string escapedName = Regex.Escape(elementName);
    string pattern = $"<{escapedName}>[^<]*</{escapedName}>";
    string replacement = $"<{elementName}>{new XText(newValue)}</{elementName}>";

    // Use Match.Success rather than string equality to detect "didn't match":
    // a no-op replacement (newValue == oldValue) leaves the line bytewise identical
    // and must not be treated as a failure.
    if (!Regex.IsMatch(originalLine, pattern))
    {
        throw new InvalidOperationException(
            $"Could not update <{elementName}> on line {info.LineNumber}: no inline " +
            $"<{elementName}>...</{elementName}> match found. Line content: [{originalLine}]. " +
            $"The property may span multiple lines.");
    }

    lines[lineIndex] = Regex.Replace(originalLine, pattern, replacement);
}

internal record AspectUpdate(string PropertyName, XElement Element);
