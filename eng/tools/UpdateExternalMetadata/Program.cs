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

// Load file as both XDocument (for navigation + line info) and as a mutable line buffer
// (for surgical in-place edits that preserve original formatting). The XDocument is
// authoritative for "does this element exist and where" — comments are naturally excluded
// from XElement traversal, fixing the latent regex-matches-inside-comments bug. The line
// buffer is authoritative for the on-disk bytes we write back.
string projContent = File.ReadAllText(projFile);
string newline = projContent.Contains("\r\n") ? "\r\n" : "\n";
List<string> lines = new(projContent.Split(new[] { newline }, StringSplitOptions.None));
XDocument projDoc = XDocument.Parse(projContent, LoadOptions.PreserveWhitespace | LoadOptions.SetLineInfo);

// --- 1. Update SourceRevisionId ---
string commitHash = RunGit($"-C \"{submoduleDir}\" rev-parse HEAD").Trim();

XElement? sourceRevisionIdEl = projDoc.Root?
    .Elements("PropertyGroup")
    .Elements("SourceRevisionId")
    .FirstOrDefault();

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
IReadOnlyList<ValidationPackageItem> validationItems = ParseValidationPackageItems(projDoc, Path.GetFileName(projFile));

if (validationItems.Count == 0)
{
    Console.WriteLine("No <FileVersionValidationPackage> items configured - skipping metadata update.");
    File.WriteAllText(projFile, string.Join(newline, lines));
    Console.WriteLine($"Saved changes to {componentName}.proj");
    return 0;
}

string versionsPropsPath = Path.Combine(repoRoot, "eng", "Versions.props");

// Cache downloads across items so multiple items sharing the same package id+version
// (a legitimate scenario, e.g. when one package contributes several aspects) don't re-fetch.
Dictionary<string, PackageVersionMetadata> metadataCache = new();

foreach (ValidationPackageItem item in validationItems)
{
    string? releaseVersion = item.ReleaseVersionPropertyName is not null
        ? FindReleaseVersionByPropertyName(versionsPropsPath, item.ReleaseVersionPropertyName)
        : FindReleaseVersion(versionsPropsPath, componentName);

    if (string.IsNullOrEmpty(releaseVersion))
    {
        Console.Error.WriteLine($"Error: Could not find release version for '{item.PackageId}' " +
            $"({(item.ReleaseVersionPropertyName is null ? "auto-derived" : $"property '{item.ReleaseVersionPropertyName}'")}).");
        return 1;
    }

    XElement? revisionEl = item.FileVersionRevisionPropertyName is not null
        ? FindPropertyElement(projDoc, item.FileVersionRevisionPropertyName)
        : null;
    XElement? assemblyVersionEl = item.AssemblyVersionOverridePropertyName is not null
        ? FindPropertyElement(projDoc, item.AssemblyVersionOverridePropertyName)
        : null;
    XElement? informationalVersionEl = item.InformationalVersionOverridePropertyName is not null
        ? FindPropertyElement(projDoc, item.InformationalVersionOverridePropertyName)
        : null;

    bool requireRevision = item.FileVersionRevisionPropertyName is not null && revisionEl is null;
    bool requireAvo = item.AssemblyVersionOverridePropertyName is not null && assemblyVersionEl is null;
    bool requireIvo = item.InformationalVersionOverridePropertyName is not null && informationalVersionEl is null;

    if (requireRevision || requireAvo || requireIvo)
    {
        List<string> missing = new();
        if (requireRevision) missing.Add(item.FileVersionRevisionPropertyName!);
        if (requireAvo) missing.Add(item.AssemblyVersionOverridePropertyName!);
        if (requireIvo) missing.Add(item.InformationalVersionOverridePropertyName!);
        Console.Error.WriteLine(
            $"Error: <FileVersionValidationPackage Include=\"{item.PackageId}\"> references undefined properties: " +
            string.Join(", ", missing) + ".");
        return 1;
    }

    if (revisionEl is null && assemblyVersionEl is null && informationalVersionEl is null)
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

    if (revisionEl is not null)
    {
        if (versionMetadata.Revision is null)
        {
            Console.Error.WriteLine($"Error: Unable to get FileVersion from {item.PackageId} {releaseVersion}.");
            return 1;
        }

        string revisionStr = versionMetadata.Revision.Value.ToString();
        string oldValue = revisionEl.Value;
        UpdatePropertyLine(lines, revisionEl, item.FileVersionRevisionPropertyName!, revisionStr);
        Console.WriteLine($"Updated {item.FileVersionRevisionPropertyName}: {oldValue} -> {revisionStr} " +
            $"(from {item.PackageId} {releaseVersion}, FileVersion: {versionMetadata.FileVersion})");
    }

    if (assemblyVersionEl is not null)
    {
        if (string.IsNullOrEmpty(versionMetadata.AssemblyVersion))
        {
            Console.Error.WriteLine($"Error: Unable to get AssemblyVersion from {item.PackageId} {releaseVersion}.");
            return 1;
        }

        string oldValue = assemblyVersionEl.Value;
        UpdatePropertyLine(lines, assemblyVersionEl, item.AssemblyVersionOverridePropertyName!, versionMetadata.AssemblyVersion);
        Console.WriteLine($"Updated {item.AssemblyVersionOverridePropertyName}: {oldValue} -> {versionMetadata.AssemblyVersion} " +
            $"(from {item.PackageId} {releaseVersion})");
    }

    if (informationalVersionEl is not null)
    {
        if (string.IsNullOrEmpty(versionMetadata.InformationalVersion))
        {
            Console.Error.WriteLine($"Error: Unable to get InformationalVersion from {item.PackageId} {releaseVersion}.");
            return 1;
        }

        string oldValue = informationalVersionEl.Value;
        UpdatePropertyLine(lines, informationalVersionEl, item.InformationalVersionOverridePropertyName!, versionMetadata.InformationalVersion);
        Console.WriteLine($"Updated {item.InformationalVersionOverridePropertyName}: {oldValue} -> {versionMetadata.InformationalVersion} " +
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
