// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using NuGet.Common;
using NuGet.Configuration;
using NuGet.Packaging;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using NuGet.Versioning;

namespace SbrpUtilities;

public record PackageVersionMetadata(
    int? Revision,
    string? FileVersion,
    string? AssemblyVersion,
    string? InformationalVersion);

/// <summary>
/// Describes one NuGet package referenced by a <c>FileVersionValidationPackage</c> item
/// in an external package <c>.proj</c> file. Encapsulates which MSBuild property names hold
/// the corresponding version override values, and which property in <c>eng/Versions.props</c>
/// holds the package's release version.
///
/// The three aspect property names (FileVersionRevision / AssemblyVersionOverride /
/// InformationalVersionOverride) are nullable: a null value means the item does not opt in to
/// validating or auto-updating that aspect. A non-null value names a property that MUST exist
/// in the .proj — missing is an error. This forces every .proj to declare its bindings
/// explicitly, eliminating the multi-item collision class.
/// </summary>
/// <param name="PackageId">The NuGet package ID.</param>
/// <param name="FileVersionRevisionPropertyName">The MSBuild property name holding the
/// FileVersion 4th component, or null if this item does not bind to a FileVersion revision.</param>
/// <param name="AssemblyVersionOverridePropertyName">The MSBuild property name holding the
/// AssemblyVersion override, or null if this item does not bind to an AssemblyVersion override.</param>
/// <param name="InformationalVersionOverridePropertyName">The MSBuild property name holding the
/// InformationalVersion override, or null if this item does not bind to an InformationalVersion
/// override.</param>
/// <param name="ReleaseVersionPropertyName">If set, names the exact property in <c>eng/Versions.props</c>
/// to look up the release version. If null, the release version is auto-derived from the .proj filename
/// as a convenience for single-package projects (the common case).</param>
public record ValidationPackageItem(
    string PackageId,
    string? FileVersionRevisionPropertyName,
    string? AssemblyVersionOverridePropertyName,
    string? InformationalVersionOverridePropertyName,
    string? ReleaseVersionPropertyName);

public static class CommonUtilities
{

    /// <summary>
    /// Finds the release version for a component in eng/Versions.props by matching
    /// the normalized (hyphen-stripped, case-insensitive) component name against
    /// properties ending in "ReleaseVersion".
    /// </summary>
    public static string? FindReleaseVersion(string versionsPropsPath, string componentName)
    {
        XDocument versionsProps = XDocument.Load(versionsPropsPath);
        string normalizedName = componentName.Replace("-", "", StringComparison.Ordinal).ToLowerInvariant();

        return versionsProps
            .Descendants()
            .FirstOrDefault(e => e.Name.LocalName.EndsWith("ReleaseVersion", StringComparison.Ordinal)
                && e.Name.LocalName.Replace("ReleaseVersion", "", StringComparison.Ordinal)
                    .Equals(normalizedName, StringComparison.OrdinalIgnoreCase))
            ?.Value;
    }

    /// <summary>
    /// Finds a release version in eng/Versions.props by exact property name match.
    /// Used when a <c>FileVersionValidationPackage</c> item explicitly names a
    /// <c>ReleaseVersionProperty</c>.
    /// </summary>
    public static string? FindReleaseVersionByPropertyName(string versionsPropsPath, string propertyName)
    {
        XDocument versionsProps = XDocument.Load(versionsPropsPath);
        return versionsProps
            .Descendants()
            .FirstOrDefault(e => e.Name.LocalName.Equals(propertyName, StringComparison.Ordinal))
            ?.Value;
    }

    /// <summary>
    /// Parses the <c>FileVersionValidationPackage</c> items from an external package
    /// <c>.proj</c> file.
    /// </summary>
    /// <param name="doc">Parsed .proj XML.</param>
    /// <param name="projFileName">File name of the .proj (for error messages).</param>
    /// <returns>An ordered list of validation items, empty if the project declares none.</returns>
    /// <exception cref="InvalidOperationException">If an item is missing its <c>Include</c> attribute.</exception>
    public static IReadOnlyList<ValidationPackageItem> ParseValidationPackageItems(
        XDocument doc, string projFileName)
    {
        if (doc.Root is null)
        {
            return Array.Empty<ValidationPackageItem>();
        }

        List<ValidationPackageItem> results = new();
        foreach (XElement item in doc.Root.Elements("ItemGroup").Elements("FileVersionValidationPackage"))
        {
            string? packageId = item.Attribute("Include")?.Value;
            if (string.IsNullOrWhiteSpace(packageId))
            {
                throw new InvalidOperationException(
                    $"{projFileName}: <FileVersionValidationPackage> item is missing a non-empty Include attribute.");
            }

            results.Add(new ValidationPackageItem(
                packageId,
                ReadOptionalMetadata(item, "FileVersionRevisionProperty"),
                ReadOptionalMetadata(item, "AssemblyVersionOverrideProperty"),
                ReadOptionalMetadata(item, "InformationalVersionOverrideProperty"),
                ReadOptionalMetadata(item, "ReleaseVersionProperty")));
        }

        return results;
    }

    private static string? ReadOptionalMetadata(XElement item, string metadataName)
    {
        string? value = item.Element(metadataName)?.Value;
        return string.IsNullOrWhiteSpace(value) ? null : value;
    }

    /// <summary>
    /// Reads a property value from any top-level <c>PropertyGroup</c> by exact name.
    /// </summary>
    public static string? ReadPropertyValue(XDocument doc, string propertyName)
    {
        return doc.Root?
            .Elements("PropertyGroup")
            .Elements(propertyName)
            .FirstOrDefault()
            ?.Value;
    }

    /// <summary>
    /// Downloads a NuGet package from the sources configured in the NuGet.config
    /// found at <paramref name="settingsRoot"/>. Returns the package stream, or null
    /// if the package was not found in any source.
    /// </summary>
    public static async Task<MemoryStream?> DownloadPackageAsync(
        string settingsRoot, string packageId, string version, CancellationToken cancellationToken = default)
    {
        ISettings settings = Settings.LoadDefaultSettings(settingsRoot);
        PackageSourceProvider sourceProvider = new(settings);
        IEnumerable<PackageSource> sources = sourceProvider.LoadPackageSources().Where(s => s.IsEnabled);
        var providers = Repository.Provider.GetCoreV3();
        NuGetVersion nugetVersion = new(version);

        using SourceCacheContext cacheContext = new();

        foreach (PackageSource source in sources)
        {
            SourceRepository repository = new(source, providers);
            MemoryStream stream = new();
            try
            {
                FindPackageByIdResource resource = await repository.GetResourceAsync<FindPackageByIdResource>(cancellationToken);
                if (await resource.CopyNupkgToStreamAsync(
                    packageId, nugetVersion, stream, cacheContext, NullLogger.Instance, cancellationToken))
                {
                    stream.Position = 0;
                    return stream;
                }
            }
            catch
            {
            }

            stream.Dispose();
        }

        return null;
    }

    /// <summary>
    /// Downloads a NuGet package and returns version metadata from its first DLL.
    /// Combines <see cref="DownloadPackageAsync"/> with DLL extraction and version reading.
    /// Returns null values if the package could not be downloaded or contains no DLL.
    /// </summary>
    public static async Task<PackageVersionMetadata> GetPackageVersionMetadataAsync(
        string settingsRoot, string packageId, string version, CancellationToken cancellationToken = default)
    {
        using MemoryStream? packageStream = await DownloadPackageAsync(settingsRoot, packageId, version, cancellationToken);
        if (packageStream is null)
        {
            return new(null, null, null, null);
        }

        using PackageArchiveReader packageReader = new(packageStream);
        string? dllItem = packageReader.GetLibItems()
            .SelectMany(group => group.Items)
            .FirstOrDefault(item => item.EndsWith(".dll", StringComparison.OrdinalIgnoreCase));

        if (dllItem is null)
        {
            return new(null, null, null, null);
        }

        string tempDll = Path.Combine(Path.GetTempPath(), $"sbrp-{Guid.NewGuid():N}.dll");
        try
        {
            using (Stream dllStream = packageReader.GetStream(dllItem))
            using (FileStream fs = File.Create(tempDll))
            {
                dllStream.CopyTo(fs);
            }

            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(tempDll);
            string? assemblyVersion = AssemblyName.GetAssemblyName(tempDll).Version?.ToString();
            return new(versionInfo.FilePrivatePart, versionInfo.FileVersion, assemblyVersion, versionInfo.ProductVersion);
        }
        finally
        {
            try
            {
                File.Delete(tempDll);
            }
            catch
            {
            }
        }
    }
}
