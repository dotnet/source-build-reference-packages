// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AllowPartiallyTrustedCallers]
[assembly: ReferenceAssembly]
[assembly: AssemblyTitle("NuGet.Packaging")]
[assembly: AssemblyDescription("NuGet.Packaging")]
[assembly: AssemblyDefaultAlias("NuGet.Packaging")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("5.1.0.6013")]
[assembly: AssemblyInformationalVersion("5.1.0.6013 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("5.1.0.5")]




namespace NuGet.Client
{
    public partial class ManagedCodeConventions
    {
        public ManagedCodeConventions(NuGet.RuntimeModel.RuntimeGraph runtimeGraph) { }
        public NuGet.Client.ManagedCodeConventions.ManagedCodeCriteria Criteria { get { throw null; } }
        public NuGet.Client.ManagedCodeConventions.ManagedCodePatterns Patterns { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, NuGet.ContentModel.ContentPropertyDefinition> Properties { get { throw null; } }
        public partial class ManagedCodeCriteria
        {
            internal ManagedCodeCriteria() { }
            public NuGet.ContentModel.SelectionCriteria ForFramework(NuGet.Frameworks.NuGetFramework framework) { throw null; }
            public NuGet.ContentModel.SelectionCriteria ForFrameworkAndRuntime(NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier) { throw null; }
            public NuGet.ContentModel.SelectionCriteria ForRuntime(string runtimeIdentifier) { throw null; }
        }
        public partial class ManagedCodePatterns
        {
            internal ManagedCodePatterns() { }
            public NuGet.ContentModel.PatternSet AnyTargettedFile { get { throw null; } }
            public NuGet.ContentModel.PatternSet CompileLibAssemblies { get { throw null; } }
            public NuGet.ContentModel.PatternSet CompileRefAssemblies { get { throw null; } }
            public NuGet.ContentModel.PatternSet ContentFiles { get { throw null; } }
            public NuGet.ContentModel.PatternSet EmbedAssemblies { get { throw null; } }
            public NuGet.ContentModel.PatternSet MSBuildFiles { get { throw null; } }
            public NuGet.ContentModel.PatternSet MSBuildMultiTargetingFiles { get { throw null; } }
            public NuGet.ContentModel.PatternSet MSBuildTransitiveFiles { get { throw null; } }
            public NuGet.ContentModel.PatternSet NativeLibraries { get { throw null; } }
            public NuGet.ContentModel.PatternSet ResourceAssemblies { get { throw null; } }
            public NuGet.ContentModel.PatternSet RuntimeAssemblies { get { throw null; } }
            public NuGet.ContentModel.PatternSet ToolsAssemblies { get { throw null; } }
        }
        public static partial class PropertyNames
        {
            public static readonly string AnyValue;
            public static readonly string CodeLanguage;
            public static readonly string Locale;
            public static readonly string ManagedAssembly;
            public static readonly string MSBuild;
            public static readonly string RuntimeIdentifier;
            public static readonly string SatelliteAssembly;
            public static readonly string TargetFrameworkMoniker;
        }
    }
}
namespace NuGet.ContentModel
{
    public partial class Asset
    {
        public Asset() { }
        public string Link { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    public partial class ContentItem
    {
        public ContentItem() { }
        public string Path { get { throw null; } set { } }
        public System.Collections.Generic.Dictionary<string, object> Properties { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class ContentItemCollection
    {
        public ContentItemCollection() { }
        public bool HasContract { get { throw null; } }
        public NuGet.ContentModel.ContentItemGroup FindBestItemGroup(NuGet.ContentModel.SelectionCriteria criteria, params NuGet.ContentModel.PatternSet[] definitions) { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.ContentModel.ContentItemGroup> FindItemGroups(NuGet.ContentModel.PatternSet definition) { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.ContentModel.ContentItem> FindItems(NuGet.ContentModel.PatternSet definition) { throw null; }
        public bool HasItemGroup(NuGet.ContentModel.SelectionCriteria criteria, params NuGet.ContentModel.PatternSet[] definitions) { throw null; }
        public void Load(System.Collections.Generic.IEnumerable<string> paths) { }
    }
    public partial class ContentItemGroup
    {
        public ContentItemGroup() { }
        public System.Collections.Generic.IList<NuGet.ContentModel.ContentItem> Items { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, object> Properties { get { throw null; } }
    }
    public partial class ContentPropertyDefinition
    {
        public ContentPropertyDefinition(string name) { }
        public ContentPropertyDefinition(string name, System.Collections.Generic.IEnumerable<string> fileExtensions) { }
        public ContentPropertyDefinition(string name, System.Collections.Generic.IEnumerable<string> fileExtensions, bool allowSubfolders) { }
        public ContentPropertyDefinition(string name, System.Func<object, object, bool> compatibilityTest) { }
        public ContentPropertyDefinition(string name, System.Func<string, NuGet.ContentModel.PatternTable, object> parser) { }
        public ContentPropertyDefinition(string name, System.Func<string, NuGet.ContentModel.PatternTable, object> parser, System.Collections.Generic.IEnumerable<string> fileExtensions) { }
        public ContentPropertyDefinition(string name, System.Func<string, NuGet.ContentModel.PatternTable, object> parser, System.Collections.Generic.IEnumerable<string> fileExtensions, bool allowSubfolders) { }
        public ContentPropertyDefinition(string name, System.Func<string, NuGet.ContentModel.PatternTable, object> parser, System.Func<object, object, bool> compatibilityTest) { }
        public ContentPropertyDefinition(string name, System.Func<string, NuGet.ContentModel.PatternTable, object> parser, System.Func<object, object, bool> compatibilityTest, System.Func<object, object, object, int> compareTest) { }
        public ContentPropertyDefinition(string name, System.Func<string, NuGet.ContentModel.PatternTable, object> parser, System.Func<object, object, bool> compatibilityTest, System.Func<object, object, object, int> compareTest, System.Collections.Generic.IEnumerable<string> fileExtensions, bool allowSubfolders) { }
        public System.Func<object, object, object, int> CompareTest { get { throw null; } }
        public System.Func<object, object, bool> CompatibilityTest { get { throw null; } }
        public bool FileExtensionAllowSubFolders { get { throw null; } }
        public System.Collections.Generic.List<string> FileExtensions { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Func<string, NuGet.ContentModel.PatternTable, object> Parser { get { throw null; } }
        public virtual int Compare(object criteriaValue, object candidateValue1, object candidateValue2) { throw null; }
        public virtual bool IsCriteriaSatisfied(object critieriaValue, object candidateValue) { throw null; }
        public virtual bool TryLookup(string name, NuGet.ContentModel.PatternTable table, out object value) { throw null; }
    }
    public partial class PatternDefinition
    {
        public PatternDefinition(string pattern) { }
        public PatternDefinition(string pattern, NuGet.ContentModel.PatternTable table) { }
        public PatternDefinition(string pattern, NuGet.ContentModel.PatternTable table, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> defaults) { }
        public System.Collections.Generic.IReadOnlyDictionary<string, object> Defaults { get { throw null; } }
        public string Pattern { get { throw null; } }
        public NuGet.ContentModel.PatternTable Table { get { throw null; } }
        public static implicit operator NuGet.ContentModel.PatternDefinition (string pattern) { throw null; }
    }
    public partial class PatternSet
    {
        public PatternSet(System.Collections.Generic.IReadOnlyDictionary<string, NuGet.ContentModel.ContentPropertyDefinition> properties, System.Collections.Generic.IEnumerable<NuGet.ContentModel.PatternDefinition> groupPatterns, System.Collections.Generic.IEnumerable<NuGet.ContentModel.PatternDefinition> pathPatterns) { }
        public System.Collections.Generic.IEnumerable<NuGet.ContentModel.PatternDefinition> GroupPatterns { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.ContentModel.PatternDefinition> PathPatterns { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, NuGet.ContentModel.ContentPropertyDefinition> PropertyDefinitions { get { throw null; } set { } }
    }
    public partial class PatternTable
    {
        public PatternTable() { }
        public PatternTable(System.Collections.Generic.IEnumerable<NuGet.ContentModel.PatternTableEntry> entries) { }
        public bool TryLookup(string propertyName, string name, out object value) { throw null; }
    }
    public partial class PatternTableEntry
    {
        public PatternTableEntry(string propertyName, string name, object value) { }
        public string Name { get { throw null; } }
        public string PropertyName { get { throw null; } }
        public object Value { get { throw null; } }
    }
    public partial class SelectionCriteria
    {
        public SelectionCriteria() { }
        public System.Collections.Generic.IList<NuGet.ContentModel.SelectionCriteriaEntry> Entries { get { throw null; } set { } }
    }
    public partial class SelectionCriteriaBuilder
    {
        public SelectionCriteriaBuilder(System.Collections.Generic.IReadOnlyDictionary<string, NuGet.ContentModel.ContentPropertyDefinition> properties) { }
        public virtual NuGet.ContentModel.SelectionCriteriaEntryBuilder Add { get { throw null; } }
        public virtual NuGet.ContentModel.SelectionCriteria Criteria { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, NuGet.ContentModel.ContentPropertyDefinition> Properties { get { throw null; } }
    }
    public partial class SelectionCriteriaEntry
    {
        public SelectionCriteriaEntry() { }
        public System.Collections.Generic.IDictionary<string, object> Properties { get { throw null; } set { } }
    }
    public partial class SelectionCriteriaEntryBuilder : NuGet.ContentModel.SelectionCriteriaBuilder
    {
        internal SelectionCriteriaEntryBuilder() : base (default(System.Collections.Generic.IReadOnlyDictionary<string, NuGet.ContentModel.ContentPropertyDefinition>)) { }
        public override NuGet.ContentModel.SelectionCriteriaEntryBuilder Add { get { throw null; } }
        public NuGet.ContentModel.SelectionCriteriaBuilder Builder { get { throw null; } }
        public override NuGet.ContentModel.SelectionCriteria Criteria { get { throw null; } }
        public NuGet.ContentModel.SelectionCriteriaEntry Entry { get { throw null; } }
        public NuGet.ContentModel.SelectionCriteriaEntryBuilder this[string key, object value] { get { throw null; } }
        public NuGet.ContentModel.SelectionCriteriaEntryBuilder this[string key, string value] { get { throw null; } }
    }
}
namespace NuGet.ContentModel.Infrastructure
{
    public partial class PatternExpression
    {
        public PatternExpression(NuGet.ContentModel.PatternDefinition pattern) { }
        public NuGet.ContentModel.ContentItem Match(string path, System.Collections.Generic.IReadOnlyDictionary<string, NuGet.ContentModel.ContentPropertyDefinition> propertyDefinitions) { throw null; }
    }
}
namespace NuGet.Packaging
{
    public static partial class CollectionExtensions
    {
        public static void AddRange<T>(this System.Collections.Generic.ICollection<T> collection, System.Collections.Generic.IEnumerable<T> items) { }
    }
    public enum ExtractionSource
    {
        DownloadResource = 1,
        NuGetFolderProject = 2,
        RestoreCommand = 0,
    }
    public partial class FallbackPackagePathInfo
    {
        public FallbackPackagePathInfo(string id, NuGet.Versioning.NuGetVersion version, NuGet.Packaging.VersionFolderPathResolver resolver) { }
        public string Id { get { throw null; } }
        public NuGet.Packaging.VersionFolderPathResolver PathResolver { get { throw null; } }
        public NuGet.Versioning.NuGetVersion Version { get { throw null; } }
    }
    public partial class FallbackPackagePathResolver
    {
        public FallbackPackagePathResolver(NuGet.Common.INuGetPathContext pathContext) { }
        public FallbackPackagePathResolver(string userPackageFolder, System.Collections.Generic.IEnumerable<string> fallbackPackageFolders) { }
        public string GetPackageDirectory(string packageId, NuGet.Versioning.NuGetVersion version) { throw null; }
        public string GetPackageDirectory(string packageId, string version) { throw null; }
        public NuGet.Packaging.FallbackPackagePathInfo GetPackageInfo(string packageId, NuGet.Versioning.NuGetVersion version) { throw null; }
    }
    public partial class FrameworkAssemblyReference
    {
        public FrameworkAssemblyReference(string assemblyName, System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> supportedFrameworks) { }
        public string AssemblyName { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> SupportedFrameworks { get { throw null; } }
    }
    public static partial class FrameworkNameUtility
    {
        public static System.Runtime.Versioning.FrameworkName ParseFrameworkFolderName(string path, bool strictParsing, out string effectivePath) { throw null; }
        public static System.Runtime.Versioning.FrameworkName ParseFrameworkNameFromFilePath(string filePath, out string effectivePath) { throw null; }
    }
    public partial class FrameworkReference : System.Collections.Generic.IComparer<NuGet.Packaging.FrameworkReference>, System.IComparable<NuGet.Packaging.FrameworkReference>, System.IEquatable<NuGet.Packaging.FrameworkReference>
    {
        public static System.StringComparer FrameworkReferenceNameComparer;
        public FrameworkReference(string name) { }
        public string Name { get { throw null; } }
        public int Compare(NuGet.Packaging.FrameworkReference x, NuGet.Packaging.FrameworkReference y) { throw null; }
        public int CompareTo(NuGet.Packaging.FrameworkReference other) { throw null; }
        public bool Equals(NuGet.Packaging.FrameworkReference other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class FrameworkReferenceGroup : NuGet.Frameworks.IFrameworkSpecific, System.IEquatable<NuGet.Packaging.FrameworkReferenceGroup>
    {
        public FrameworkReferenceGroup(NuGet.Frameworks.NuGetFramework targetFramework, System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkReference> frameworkReferences) { }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkReference> FrameworkReferences { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework TargetFramework { get { throw null; } }
        public bool Equals(NuGet.Packaging.FrameworkReferenceGroup other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public static partial class FrameworksExtensions
    {
        public static string GetFrameworkString(this NuGet.Frameworks.NuGetFramework self) { throw null; }
    }
    public partial class FrameworkSpecificGroup : NuGet.Frameworks.IFrameworkSpecific, System.IEquatable<NuGet.Packaging.FrameworkSpecificGroup>
    {
        public FrameworkSpecificGroup(NuGet.Frameworks.NuGetFramework targetFramework, System.Collections.Generic.IEnumerable<string> items) { }
        public bool HasEmptyFolder { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> Items { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework TargetFramework { get { throw null; } }
        public bool Equals(NuGet.Packaging.FrameworkSpecificGroup other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial interface IAsyncPackageContentReader
    {
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetBuildItemsAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetContentItemsAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetFrameworkItemsAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetLibItemsAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup>> GetPackageDependenciesAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetReferenceItemsAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetToolItemsAsync(System.Threading.CancellationToken cancellationToken);
    }
    public partial interface IHashFunction : System.IDisposable
    {
        string GetHash();
        void Update(byte[] data, int offset, int count);
    }
    public partial interface INuspecReader : NuGet.Packaging.Core.INuspecCoreReader
    {
        System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> GetDependencyGroups();
        System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetFrameworkReferenceGroups();
        string GetLanguage();
        System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetReferenceGroups();
    }
    public partial interface IPackageContentReader
    {
        System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetBuildItems();
        System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetContentItems();
        System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetFrameworkItems();
        System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetLibItems();
        System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> GetPackageDependencies();
        System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetReferenceItems();
        System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetToolItems();
    }
    public partial interface IPackageDownloader : System.IDisposable
    {
        NuGet.Packaging.IAsyncPackageContentReader ContentReader { get; }
        NuGet.Packaging.Core.IAsyncPackageCoreReader CoreReader { get; }
        NuGet.Packaging.Signing.ISignedPackageReader SignedPackageReader { get; }
        string Source { get; }
        System.Threading.Tasks.Task<bool> CopyNupkgFileToAsync(string destinationFilePath, System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<string> GetPackageHashAsync(string hashAlgorithm, System.Threading.CancellationToken cancellationToken);
        void SetExceptionHandler(System.Func<System.Exception, System.Threading.Tasks.Task<bool>> handleExceptionAsync);
        void SetThrottle(System.Threading.SemaphoreSlim throttle);
    }
    public partial interface IPackageFile
    {
        string EffectivePath { get; }
        System.DateTimeOffset LastWriteTime { get; }
        string Path { get; }
        System.Runtime.Versioning.FrameworkName TargetFramework { get; }
        System.IO.Stream GetStream();
    }
    public partial interface IPackageMetadata
    {
        System.Collections.Generic.IEnumerable<string> Authors { get; }
        System.Collections.Generic.IEnumerable<NuGet.Packaging.ManifestContentFiles> ContentFiles { get; }
        string Copyright { get; }
        System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> DependencyGroups { get; }
        string Description { get; }
        bool DevelopmentDependency { get; }
        System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkReferenceGroup> FrameworkReferenceGroups { get; }
        System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkAssemblyReference> FrameworkReferences { get; }
        System.Uri IconUrl { get; }
        string Id { get; }
        string Language { get; }
        NuGet.Packaging.LicenseMetadata LicenseMetadata { get; }
        System.Uri LicenseUrl { get; }
        System.Version MinClientVersion { get; }
        System.Collections.Generic.IEnumerable<string> Owners { get; }
        System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageReferenceSet> PackageAssemblyReferences { get; }
        System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageType> PackageTypes { get; }
        System.Uri ProjectUrl { get; }
        string ReleaseNotes { get; }
        NuGet.Packaging.Core.RepositoryMetadata Repository { get; }
        bool RequireLicenseAcceptance { get; }
        bool Serviceable { get; }
        string Summary { get; }
        string Tags { get; }
        string Title { get; }
        NuGet.Versioning.NuGetVersion Version { get; }
    }
    public partial interface IPackageResolver
    {
        System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageIdentity> Resolve(System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageIdentity> targets, System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependencyInfo> availablePackages, System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageReference> installedPackages, System.Threading.CancellationToken token);
        System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageIdentity> Resolve(System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageIdentity> targets, System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependencyInfo> availablePackages, System.Threading.CancellationToken token);
        System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageIdentity> Resolve(System.Collections.Generic.IEnumerable<string> targets, System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependencyInfo> availablePackages, System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageReference> installedPackages, System.Threading.CancellationToken token);
        System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageIdentity> Resolve(System.Collections.Generic.IEnumerable<string> targets, System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependencyInfo> availablePackages, System.Threading.CancellationToken token);
    }
    public partial class LicenseMetadata : System.IEquatable<NuGet.Packaging.LicenseMetadata>
    {
        public static readonly System.Version CurrentVersion;
        public static readonly System.Version EmptyVersion;
        public static readonly System.Uri LicenseFileDeprecationUrl;
        public static readonly string LicenseServiceLinkTemplate;
        public LicenseMetadata(NuGet.Packaging.LicenseType type, string license, NuGet.Packaging.Licenses.NuGetLicenseExpression expression, System.Collections.Generic.IReadOnlyList<string> warningsAndErrors, System.Version version) { }
        public string License { get { throw null; } }
        public NuGet.Packaging.Licenses.NuGetLicenseExpression LicenseExpression { get { throw null; } }
        public System.Uri LicenseUrl { get { throw null; } }
        public NuGet.Packaging.LicenseType Type { get { throw null; } }
        public System.Version Version { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> WarningsAndErrors { get { throw null; } }
        public bool Equals(NuGet.Packaging.LicenseMetadata other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public enum LicenseType
    {
        Expression = 1,
        File = 0,
    }
    public sealed partial class LocalPackageArchiveDownloader : NuGet.Packaging.IPackageDownloader, System.IDisposable
    {
        public LocalPackageArchiveDownloader(string source, string packageFilePath, NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Common.ILogger logger) { }
        public NuGet.Packaging.IAsyncPackageContentReader ContentReader { get { throw null; } }
        public NuGet.Packaging.Core.IAsyncPackageCoreReader CoreReader { get { throw null; } }
        public NuGet.Packaging.Signing.ISignedPackageReader SignedPackageReader { get { throw null; } }
        public string Source { get { throw null; } }
        public System.Threading.Tasks.Task<bool> CopyNupkgFileToAsync(string destinationFilePath, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void Dispose() { }
        public System.Threading.Tasks.Task<string> GetPackageHashAsync(string hashAlgorithm, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void SetExceptionHandler(System.Func<System.Exception, System.Threading.Tasks.Task<bool>> handleExceptionAsync) { }
        public void SetThrottle(System.Threading.SemaphoreSlim throttle) { }
    }
    public partial class Manifest
    {
        public Manifest(NuGet.Packaging.ManifestMetadata metadata) { }
        public Manifest(NuGet.Packaging.ManifestMetadata metadata, System.Collections.Generic.ICollection<NuGet.Packaging.ManifestFile> files) { }
        public System.Collections.Generic.ICollection<NuGet.Packaging.ManifestFile> Files { get { throw null; } }
        public bool HasFilesNode { get { throw null; } }
        public NuGet.Packaging.ManifestMetadata Metadata { get { throw null; } }
        public static NuGet.Packaging.Manifest Create(NuGet.Packaging.IPackageMetadata metadata) { throw null; }
        public static NuGet.Packaging.Manifest ReadFrom(System.IO.Stream stream, bool validateSchema) { throw null; }
        public static NuGet.Packaging.Manifest ReadFrom(System.IO.Stream stream, System.Func<string, string> propertyProvider, bool validateSchema) { throw null; }
        public void Save(System.IO.Stream stream) { }
        public void Save(System.IO.Stream stream, int minimumManifestVersion) { }
        public static void Validate(NuGet.Packaging.Manifest manifest) { }
    }
    public partial class ManifestContentFiles
    {
        public ManifestContentFiles() { }
        public string BuildAction { get { throw null; } set { } }
        public string CopyToOutput { get { throw null; } set { } }
        public string Exclude { get { throw null; } set { } }
        public string Flatten { get { throw null; } set { } }
        public string Include { get { throw null; } set { } }
    }
    public partial class ManifestFile
    {
        public ManifestFile() { }
        public string Exclude { get { throw null; } set { } }
        public string Source { get { throw null; } set { } }
        public string Target { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> Validate() { throw null; }
    }
    public partial class ManifestMetadata : NuGet.Packaging.IPackageMetadata
    {
        public ManifestMetadata() { }
        public ManifestMetadata(NuGet.Packaging.IPackageMetadata copy) { }
        public System.Collections.Generic.IEnumerable<string> Authors { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.ManifestContentFiles> ContentFiles { get { throw null; } set { } }
        public string Copyright { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> DependencyGroups { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public bool DevelopmentDependency { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkReferenceGroup> FrameworkReferenceGroups { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkAssemblyReference> FrameworkReferences { get { throw null; } set { } }
        public System.Uri IconUrl { get { throw null; } }
        public string Id { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public NuGet.Packaging.LicenseMetadata LicenseMetadata { get { throw null; } set { } }
        public System.Uri LicenseUrl { get { throw null; } }
        public System.Version MinClientVersion { get { throw null; } }
        public string MinClientVersionString { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> Owners { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageReferenceSet> PackageAssemblyReferences { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageType> PackageTypes { get { throw null; } set { } }
        public System.Uri ProjectUrl { get { throw null; } }
        public string ReleaseNotes { get { throw null; } set { } }
        public NuGet.Packaging.Core.RepositoryMetadata Repository { get { throw null; } set { } }
        public bool RequireLicenseAcceptance { get { throw null; } set { } }
        public bool Serviceable { get { throw null; } set { } }
        public string Summary { get { throw null; } set { } }
        public string Tags { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        public NuGet.Versioning.NuGetVersion Version { get { throw null; } set { } }
        public void SetIconUrl(string iconUrl) { }
        public void SetLicenseUrl(string licenseUrl) { }
        public void SetProjectUrl(string projectUrl) { }
        public System.Collections.Generic.IEnumerable<string> Validate() { throw null; }
    }
    public static partial class ManifestSchemaUtility
    {
        public static string GetSchemaNamespace(int version) { throw null; }
        public static int GetVersionFromNamespace(string @namespace) { throw null; }
        public static bool IsKnownSchema(string schemaNamespace) { throw null; }
    }
    public static partial class ManifestVersionUtility
    {
        public const int DefaultVersion = 1;
        public const int SemverVersion = 3;
        public const int TargetFrameworkSupportForDependencyContentsAndToolsVersion = 4;
        public const int TargetFrameworkSupportForReferencesVersion = 5;
        public const int XdtTransformationVersion = 6;
        public static int GetManifestVersion(NuGet.Packaging.ManifestMetadata metadata) { throw null; }
    }
    public partial class MinClientVersionException : NuGet.Packaging.Core.PackagingException, NuGet.Common.ILogMessageException
    {
        public MinClientVersionException(string message) : base (default(string)) { }
        public override NuGet.Common.ILogMessage AsLogMessage() { throw null; }
    }
    public static partial class MinClientVersionUtility
    {
        public static NuGet.Versioning.NuGetVersion GetNuGetClientVersion() { throw null; }
        public static bool IsMinClientVersionCompatible(NuGet.Packaging.Core.NuspecCoreReaderBase nuspecReader) { throw null; }
        public static bool IsMinClientVersionCompatible(NuGet.Versioning.NuGetVersion packageMinClientVersion) { throw null; }
        public static void VerifyMinClientVersion(NuGet.Packaging.Core.NuspecCoreReaderBase nuspecReader) { }
    }
    public partial class NupkgMetadataFile : System.IEquatable<NuGet.Packaging.NupkgMetadataFile>
    {
        public NupkgMetadataFile() { }
        public string ContentHash { get { throw null; } set { } }
        public int Version { get { throw null; } set { } }
        public bool Equals(NuGet.Packaging.NupkgMetadataFile other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class NupkgMetadataFileFormat
    {
        public static readonly int Version;
        public NupkgMetadataFileFormat() { }
        public static NuGet.Packaging.NupkgMetadataFile Read(System.IO.Stream stream, NuGet.Common.ILogger log, string path) { throw null; }
        public static NuGet.Packaging.NupkgMetadataFile Read(System.IO.TextReader reader, NuGet.Common.ILogger log, string path) { throw null; }
        public static NuGet.Packaging.NupkgMetadataFile Read(string filePath) { throw null; }
        public static NuGet.Packaging.NupkgMetadataFile Read(string filePath, NuGet.Common.ILogger log) { throw null; }
        public static void Write(System.IO.Stream stream, NuGet.Packaging.NupkgMetadataFile hashFile) { }
        public static void Write(System.IO.TextWriter textWriter, NuGet.Packaging.NupkgMetadataFile hashFile) { }
        public static void Write(string filePath, NuGet.Packaging.NupkgMetadataFile hashFile) { }
    }
    public partial class NuspecReader : NuGet.Packaging.Core.NuspecCoreReaderBase
    {
        public NuspecReader(System.IO.Stream stream) : base (default(string)) { }
        public NuspecReader(System.IO.Stream stream, NuGet.Frameworks.IFrameworkNameProvider frameworkProvider, bool leaveStreamOpen) : base (default(string)) { }
        public NuspecReader(string path) : base (default(string)) { }
        public NuspecReader(string path, NuGet.Frameworks.IFrameworkNameProvider frameworkProvider) : base (default(string)) { }
        public NuspecReader(System.Xml.Linq.XDocument xml) : base (default(string)) { }
        public NuspecReader(System.Xml.Linq.XDocument xml, NuGet.Frameworks.IFrameworkNameProvider frameworkProvider) : base (default(string)) { }
        public string GetAuthors() { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.ContentFilesEntry> GetContentFiles() { throw null; }
        public string GetCopyright() { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> GetDependencyGroups() { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> GetDependencyGroups(bool useStrictVersionCheck) { throw null; }
        public string GetDescription() { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetFrameworkAssemblyGroups() { throw null; }
        [System.ObsoleteAttribute("GetFrameworkReferenceGroups() is deprecated. Please use GetFrameworkAssemblyGroups() instead.")]
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetFrameworkReferenceGroups() { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkReferenceGroup> GetFrameworkRefGroups() { throw null; }
        public string GetIconUrl() { throw null; }
        public string GetLanguage() { throw null; }
        public NuGet.Packaging.LicenseMetadata GetLicenseMetadata() { throw null; }
        public string GetLicenseUrl() { throw null; }
        public string GetOwners() { throw null; }
        public string GetProjectUrl() { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetReferenceGroups() { throw null; }
        public string GetReleaseNotes() { throw null; }
        public NuGet.Packaging.Core.RepositoryMetadata GetRepositoryMetadata() { throw null; }
        public bool GetRequireLicenseAcceptance() { throw null; }
        public string GetSummary() { throw null; }
        public string GetTags() { throw null; }
        public string GetTitle() { throw null; }
    }
    public partial class PackageArchiveReader : NuGet.Packaging.PackageReaderBase
    {
        public PackageArchiveReader(System.IO.Compression.ZipArchive zipArchive) : base (default(NuGet.Frameworks.IFrameworkNameProvider)) { }
        public PackageArchiveReader(System.IO.Compression.ZipArchive zipArchive, NuGet.Frameworks.IFrameworkNameProvider frameworkProvider, NuGet.Frameworks.IFrameworkCompatibilityProvider compatibilityProvider) : base (default(NuGet.Frameworks.IFrameworkNameProvider)) { }
        public PackageArchiveReader(System.IO.Stream stream) : base (default(NuGet.Frameworks.IFrameworkNameProvider)) { }
        public PackageArchiveReader(System.IO.Stream stream, NuGet.Frameworks.IFrameworkNameProvider frameworkProvider, NuGet.Frameworks.IFrameworkCompatibilityProvider compatibilityProvider) : base (default(NuGet.Frameworks.IFrameworkNameProvider)) { }
        public PackageArchiveReader(System.IO.Stream stream, bool leaveStreamOpen) : base (default(NuGet.Frameworks.IFrameworkNameProvider)) { }
        public PackageArchiveReader(System.IO.Stream stream, bool leaveStreamOpen, NuGet.Frameworks.IFrameworkNameProvider frameworkProvider, NuGet.Frameworks.IFrameworkCompatibilityProvider compatibilityProvider) : base (default(NuGet.Frameworks.IFrameworkNameProvider)) { }
        public PackageArchiveReader(string filePath, NuGet.Frameworks.IFrameworkNameProvider frameworkProvider = null, NuGet.Frameworks.IFrameworkCompatibilityProvider compatibilityProvider = null) : base (default(NuGet.Frameworks.IFrameworkNameProvider)) { }
        protected NuGet.Packaging.Signing.SigningSpecifications SigningSpecifications { get { throw null; } }
        protected System.IO.Stream ZipReadStream { get { throw null; } set { } }
        public override bool CanVerifySignedPackages(NuGet.Packaging.Signing.SignedPackageVerifierSettings verifierSettings) { throw null; }
        public override System.Collections.Generic.IEnumerable<string> CopyFiles(string destination, System.Collections.Generic.IEnumerable<string> packageFiles, NuGet.Packaging.Core.ExtractPackageFileDelegate extractFile, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        protected override void Dispose(bool disposing) { }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.ZipFilePair> EnumeratePackageEntries(System.Collections.Generic.IEnumerable<string> packageFiles, string packageDirectory) { throw null; }
        public string ExtractFile(string packageFile, string targetFilePath, NuGet.Common.ILogger logger) { throw null; }
        public override System.Threading.Tasks.Task<byte[]> GetArchiveHashAsync(NuGet.Common.HashAlgorithmName hashAlgorithmName, System.Threading.CancellationToken token) { throw null; }
        public override string GetContentHash(System.Threading.CancellationToken token, System.Func<string> GetUnsignedPackageHash = null) { throw null; }
        public System.IO.Compression.ZipArchiveEntry GetEntry(string packageFile) { throw null; }
        public override System.Collections.Generic.IEnumerable<string> GetFiles() { throw null; }
        public override System.Collections.Generic.IEnumerable<string> GetFiles(string folder) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Packaging.Signing.PrimarySignature> GetPrimarySignatureAsync(System.Threading.CancellationToken token) { throw null; }
        public override System.IO.Stream GetStream(string path) { throw null; }
        public override System.Threading.Tasks.Task<bool> IsSignedAsync(System.Threading.CancellationToken token) { throw null; }
        protected void ThrowIfZipReadStreamIsNull() { }
        public override System.Threading.Tasks.Task ValidateIntegrityAsync(NuGet.Packaging.Signing.SignatureContent signatureContent, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task ValidatePackageEntriesAsync(System.Threading.CancellationToken token) { throw null; }
    }
    public partial class PackageBuilder : NuGet.Packaging.IPackageMetadata
    {
        public PackageBuilder() { }
        public PackageBuilder(System.IO.Stream stream, string basePath) { }
        public PackageBuilder(System.IO.Stream stream, string basePath, System.Func<string, string> propertyProvider) { }
        public PackageBuilder(string path, System.Func<string, string> propertyProvider, bool includeEmptyDirectories) { }
        public PackageBuilder(string path, string basePath, System.Func<string, string> propertyProvider, bool includeEmptyDirectories) { }
        public System.Collections.Generic.ISet<string> Authors { get { throw null; } }
        public System.Collections.Generic.ICollection<NuGet.Packaging.ManifestContentFiles> ContentFiles { get { throw null; } }
        public string Copyright { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<NuGet.Packaging.PackageDependencyGroup> DependencyGroups { get { throw null; } }
        public string Description { get { throw null; } set { } }
        public bool DevelopmentDependency { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<NuGet.Packaging.IPackageFile> Files { get { throw null; } }
        public System.Collections.ObjectModel.Collection<NuGet.Packaging.FrameworkReferenceGroup> FrameworkReferenceGroups { get { throw null; } }
        public System.Collections.ObjectModel.Collection<NuGet.Packaging.FrameworkAssemblyReference> FrameworkReferences { get { throw null; } }
        public bool HasSnapshotVersion { get { throw null; } set { } }
        public System.Uri IconUrl { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public NuGet.Packaging.LicenseMetadata LicenseMetadata { get { throw null; } set { } }
        public System.Uri LicenseUrl { get { throw null; } set { } }
        public System.Version MinClientVersion { get { throw null; } set { } }
        System.Collections.Generic.IEnumerable<string> NuGet.Packaging.IPackageMetadata.Authors { get { throw null; } }
        System.Collections.Generic.IEnumerable<NuGet.Packaging.ManifestContentFiles> NuGet.Packaging.IPackageMetadata.ContentFiles { get { throw null; } }
        System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> NuGet.Packaging.IPackageMetadata.DependencyGroups { get { throw null; } }
        System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkReferenceGroup> NuGet.Packaging.IPackageMetadata.FrameworkReferenceGroups { get { throw null; } }
        System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkAssemblyReference> NuGet.Packaging.IPackageMetadata.FrameworkReferences { get { throw null; } }
        System.Collections.Generic.IEnumerable<string> NuGet.Packaging.IPackageMetadata.Owners { get { throw null; } }
        System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageReferenceSet> NuGet.Packaging.IPackageMetadata.PackageAssemblyReferences { get { throw null; } }
        System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageType> NuGet.Packaging.IPackageMetadata.PackageTypes { get { throw null; } }
        string NuGet.Packaging.IPackageMetadata.Tags { get { throw null; } }
        public string OutputName { get { throw null; } set { } }
        public System.Collections.Generic.ISet<string> Owners { get { throw null; } }
        public System.Collections.Generic.ICollection<NuGet.Packaging.PackageReferenceSet> PackageAssemblyReferences { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<NuGet.Packaging.Core.PackageType> PackageTypes { get { throw null; } set { } }
        public System.Uri ProjectUrl { get { throw null; } set { } }
        public System.Collections.Generic.Dictionary<string, string> Properties { get { throw null; } }
        public string ReleaseNotes { get { throw null; } set { } }
        public NuGet.Packaging.Core.RepositoryMetadata Repository { get { throw null; } set { } }
        public bool RequireLicenseAcceptance { get { throw null; } set { } }
        public bool Serviceable { get { throw null; } set { } }
        public string Summary { get { throw null; } set { } }
        public System.Collections.Generic.ISet<string> Tags { get { throw null; } }
        public System.Collections.Generic.IList<NuGet.Frameworks.NuGetFramework> TargetFrameworks { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        public NuGet.Versioning.NuGetVersion Version { get { throw null; } set { } }
        public void AddFiles(string basePath, string source, string destination, string exclude = null) { }
        public void Populate(NuGet.Packaging.ManifestMetadata manifestMetadata) { }
        public void PopulateFiles(string basePath, System.Collections.Generic.IEnumerable<NuGet.Packaging.ManifestFile> files) { }
        public void Save(System.IO.Stream stream) { }
        public static void ValidateReferenceAssemblies(System.Collections.Generic.IEnumerable<NuGet.Packaging.IPackageFile> files, System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageReferenceSet> packageAssemblyReferences) { }
    }
    public partial class PackageDependencyGroup : NuGet.Frameworks.IFrameworkSpecific, System.IEquatable<NuGet.Packaging.PackageDependencyGroup>
    {
        public PackageDependencyGroup(NuGet.Frameworks.NuGetFramework targetFramework, System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependency> packages) { }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependency> Packages { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework TargetFramework { get { throw null; } }
        public bool Equals(NuGet.Packaging.PackageDependencyGroup other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PackageExtractionContext
    {
        public PackageExtractionContext(NuGet.Packaging.PackageSaveMode packageSaveMode, NuGet.Packaging.XmlDocFileSaveMode xmlDocFileSaveMode, NuGet.Packaging.Signing.ClientPolicyContext clientPolicyContext, NuGet.Common.ILogger logger) { }
        public NuGet.Packaging.Signing.ClientPolicyContext ClientPolicyContext { get { throw null; } }
        public bool CopySatelliteFiles { get { throw null; } set { } }
        public NuGet.Common.ILogger Logger { get { throw null; } }
        public NuGet.Packaging.PackageSaveMode PackageSaveMode { get { throw null; } set { } }
        public NuGet.Packaging.Signing.IPackageSignatureVerifier SignedPackageVerifier { get { throw null; } set { } }
        public NuGet.Packaging.XmlDocFileSaveMode XmlDocFileSaveMode { get { throw null; } set { } }
    }
    public partial class PackageExtractionResult
    {
        public PackageExtractionResult(bool cached, System.TimeSpan signVerifyDelay, NuGet.Packaging.PackageSignType packageType, bool success, System.DateTimeOffset signVerifyStartTime, System.DateTimeOffset signVerifyEndTime) { }
        public PackageExtractionResult(bool cached, System.TimeSpan signVerifyDelay, NuGet.Packaging.PackageSignType packageType, bool success, System.TimeSpan duration) { }
        public bool Cached { get { throw null; } }
        public System.TimeSpan Duration { get { throw null; } set { } }
        public NuGet.Packaging.PackageSignType PackageType { get { throw null; } }
        public System.TimeSpan SignVerifyDelay { get { throw null; } }
        public System.DateTimeOffset SignVerifyEndTime { get { throw null; } }
        public System.DateTimeOffset SignVerifyStartTime { get { throw null; } }
        public bool Success { get { throw null; } }
    }
    public partial class PackageExtractionTelemetryEvent : NuGet.Common.TelemetryEvent
    {
        public const string EventName = "PackageExtractionInformation";
        public PackageExtractionTelemetryEvent(NuGet.Packaging.PackageSaveMode packageSaveMode, NuGet.Common.NuGetOperationStatus status, NuGet.Packaging.ExtractionSource extractionSource, NuGet.Packaging.Core.PackageIdentity packageId) : base (default(string)) { }
        public NuGet.Packaging.ExtractionSource ExtractionSource { get { throw null; } }
        public string PackageId { get { throw null; } }
        public NuGet.Packaging.PackageSaveMode PackageSaveMode { get { throw null; } }
        public string PackageVersion { get { throw null; } }
        public NuGet.Common.NuGetOperationStatus Status { get { throw null; } }
    }
    public static partial class PackageExtractor
    {
        public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> CopySatelliteFilesAsync(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Packaging.PackagePathResolver packagePathResolver, NuGet.Packaging.PackageSaveMode packageSaveMode, NuGet.Packaging.PackageExtractionContext packageExtractionContext, System.Threading.CancellationToken token) { throw null; }
        public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> ExtractPackageAsync(string source, NuGet.Packaging.PackageReaderBase packageReader, NuGet.Packaging.PackagePathResolver packagePathResolver, NuGet.Packaging.PackageExtractionContext packageExtractionContext, System.Threading.CancellationToken token, System.Guid parentId = default(System.Guid)) { throw null; }
        public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> ExtractPackageAsync(string source, NuGet.Packaging.PackageReaderBase packageReader, System.IO.Stream packageStream, NuGet.Packaging.PackagePathResolver packagePathResolver, NuGet.Packaging.PackageExtractionContext packageExtractionContext, System.Threading.CancellationToken token, System.Guid parentId = default(System.Guid)) { throw null; }
        public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> ExtractPackageAsync(string source, System.IO.Stream packageStream, NuGet.Packaging.PackagePathResolver packagePathResolver, NuGet.Packaging.PackageExtractionContext packageExtractionContext, System.Threading.CancellationToken token, System.Guid parentId = default(System.Guid)) { throw null; }
        public static System.Threading.Tasks.Task<bool> InstallFromSourceAsync(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Packaging.IPackageDownloader packageDownloader, NuGet.Packaging.VersionFolderPathResolver versionFolderPathResolver, NuGet.Packaging.PackageExtractionContext packageExtractionContext, System.Threading.CancellationToken token, System.Guid parentId = default(System.Guid)) { throw null; }
        public static System.Threading.Tasks.Task<bool> InstallFromSourceAsync(string source, NuGet.Packaging.Core.PackageIdentity packageIdentity, System.Func<System.IO.Stream, System.Threading.Tasks.Task> copyToAsync, NuGet.Packaging.VersionFolderPathResolver versionFolderPathResolver, NuGet.Packaging.PackageExtractionContext packageExtractionContext, System.Threading.CancellationToken token, System.Guid parentId = default(System.Guid)) { throw null; }
    }
    public partial class PackageFileExtractor
    {
        public PackageFileExtractor(System.Collections.Generic.IEnumerable<string> packageFiles, NuGet.Packaging.XmlDocFileSaveMode xmlDocFileSaveMode) { }
        public string ExtractPackageFile(string source, string target, System.IO.Stream stream) { throw null; }
    }
    public partial class PackageFolderReader : NuGet.Packaging.PackageReaderBase
    {
        public PackageFolderReader(System.IO.DirectoryInfo folder) : base (default(NuGet.Frameworks.IFrameworkNameProvider)) { }
        public PackageFolderReader(System.IO.DirectoryInfo folder, NuGet.Frameworks.IFrameworkNameProvider frameworkProvider, NuGet.Frameworks.IFrameworkCompatibilityProvider compatibilityProvider) : base (default(NuGet.Frameworks.IFrameworkNameProvider)) { }
        public PackageFolderReader(string folderPath) : base (default(NuGet.Frameworks.IFrameworkNameProvider)) { }
        public PackageFolderReader(string folderPath, NuGet.Frameworks.IFrameworkNameProvider frameworkProvider, NuGet.Frameworks.IFrameworkCompatibilityProvider compatibilityProvider) : base (default(NuGet.Frameworks.IFrameworkNameProvider)) { }
        public override bool CanVerifySignedPackages(NuGet.Packaging.Signing.SignedPackageVerifierSettings verifierSettings) { throw null; }
        public override System.Collections.Generic.IEnumerable<string> CopyFiles(string destination, System.Collections.Generic.IEnumerable<string> packageFiles, NuGet.Packaging.Core.ExtractPackageFileDelegate extractFile, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override System.Threading.Tasks.Task<byte[]> GetArchiveHashAsync(NuGet.Common.HashAlgorithmName hashAlgorithm, System.Threading.CancellationToken token) { throw null; }
        public override string GetContentHash(System.Threading.CancellationToken token, System.Func<string> GetUnsignedPackageHash = null) { throw null; }
        public override System.Collections.Generic.IEnumerable<string> GetFiles() { throw null; }
        public override System.Collections.Generic.IEnumerable<string> GetFiles(string folder) { throw null; }
        public override string GetNuspecFile() { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Packaging.Signing.PrimarySignature> GetPrimarySignatureAsync(System.Threading.CancellationToken token) { throw null; }
        public override System.IO.Stream GetStream(string path) { throw null; }
        public override System.Threading.Tasks.Task<bool> IsSignedAsync(System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task ValidateIntegrityAsync(NuGet.Packaging.Signing.SignatureContent signatureContent, System.Threading.CancellationToken token) { throw null; }
    }
    public static partial class PackageHelper
    {
        public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.ZipFilePair>> GetInstalledPackageFilesAsync(NuGet.Packaging.PackageArchiveReader packageReader, NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Packaging.PackagePathResolver packagePathResolver, NuGet.Packaging.PackageSaveMode packageSaveMode, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<System.Tuple<string, System.Collections.Generic.IEnumerable<NuGet.Packaging.ZipFilePair>>> GetInstalledSatelliteFilesAsync(NuGet.Packaging.PackageArchiveReader packageReader, NuGet.Packaging.PackagePathResolver packagePathResolver, NuGet.Packaging.PackageSaveMode packageSaveMode, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<System.Tuple<string, System.Collections.Generic.IEnumerable<string>>> GetSatelliteFilesAsync(NuGet.Packaging.PackageReaderBase packageReader, NuGet.Packaging.PackagePathResolver packagePathResolver, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static bool IsAssembly(string path) { throw null; }
        public static bool IsManifest(string path) { throw null; }
        public static bool IsNuspec(string path) { throw null; }
        public static bool IsPackageFile(string packageFileName, NuGet.Packaging.PackageSaveMode packageSaveMode) { throw null; }
        public static bool IsRoot(string path) { throw null; }
    }
    public static partial class PackageIdValidator
    {
        public const int MaxPackageIdLength = 100;
        public static bool IsValidPackageId(string packageId) { throw null; }
        public static void ValidatePackageId(string packageId) { }
    }
    public static partial class PackagePathHelper
    {
        public static string GetInstalledPackageFilePath(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Packaging.PackagePathResolver packagePathResolver) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> GetPackageLookupPaths(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Packaging.PackagePathResolver packagePathResolver) { throw null; }
    }
    public partial class PackagePathResolver
    {
        public PackagePathResolver(string rootDirectory, bool useSideBySidePaths = true) { }
        protected internal string Root { get { throw null; } }
        public bool UseSideBySidePaths { get { throw null; } }
        public virtual string GetInstalledPackageFilePath(NuGet.Packaging.Core.PackageIdentity packageIdentity) { throw null; }
        public virtual string GetInstalledPath(NuGet.Packaging.Core.PackageIdentity packageIdentity) { throw null; }
        public virtual string GetInstallPath(NuGet.Packaging.Core.PackageIdentity packageIdentity) { throw null; }
        public string GetManifestFileName(NuGet.Packaging.Core.PackageIdentity packageIdentity) { throw null; }
        public virtual string GetPackageDirectoryName(NuGet.Packaging.Core.PackageIdentity packageIdentity) { throw null; }
        public string GetPackageDownloadMarkerFileName(NuGet.Packaging.Core.PackageIdentity packageIdentity) { throw null; }
        public virtual string GetPackageFileName(NuGet.Packaging.Core.PackageIdentity packageIdentity) { throw null; }
    }
    public abstract partial class PackageReaderBase : NuGet.Packaging.Core.IAsyncPackageCoreReader, NuGet.Packaging.Core.IPackageCoreReader, NuGet.Packaging.IAsyncPackageContentReader, NuGet.Packaging.IPackageContentReader, NuGet.Packaging.Signing.ISignedPackageReader, System.IDisposable
    {
        public PackageReaderBase(NuGet.Frameworks.IFrameworkNameProvider frameworkProvider) { }
        public PackageReaderBase(NuGet.Frameworks.IFrameworkNameProvider frameworkProvider, NuGet.Frameworks.IFrameworkCompatibilityProvider compatibilityProvider) { }
        protected NuGet.Frameworks.IFrameworkCompatibilityProvider CompatibilityProvider { get { throw null; } set { } }
        protected NuGet.Frameworks.IFrameworkNameProvider FrameworkProvider { get { throw null; } set { } }
        public virtual NuGet.Packaging.NuspecReader NuspecReader { get { throw null; } }
        public abstract bool CanVerifySignedPackages(NuGet.Packaging.Signing.SignedPackageVerifierSettings verifierSettings);
        public abstract System.Collections.Generic.IEnumerable<string> CopyFiles(string destination, System.Collections.Generic.IEnumerable<string> packageFiles, NuGet.Packaging.Core.ExtractPackageFileDelegate extractFile, NuGet.Common.ILogger logger, System.Threading.CancellationToken token);
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> CopyFilesAsync(string destination, System.Collections.Generic.IEnumerable<string> packageFiles, NuGet.Packaging.Core.ExtractPackageFileDelegate extractFile, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task<string> CopyNupkgAsync(string nupkgFilePath, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void Dispose() { }
        protected abstract void Dispose(bool disposing);
        public abstract System.Threading.Tasks.Task<byte[]> GetArchiveHashAsync(NuGet.Common.HashAlgorithmName hashAlgorithm, System.Threading.CancellationToken token);
        public virtual System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetBuildItems() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetBuildItemsAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract string GetContentHash(System.Threading.CancellationToken token, System.Func<string> GetUnsignedPackageHash = null);
        public virtual System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetContentItems() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetContentItemsAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual bool GetDevelopmentDependency() { throw null; }
        public virtual System.Threading.Tasks.Task<bool> GetDevelopmentDependencyAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        protected System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetFileGroups(string folder) { throw null; }
        public abstract System.Collections.Generic.IEnumerable<string> GetFiles();
        public abstract System.Collections.Generic.IEnumerable<string> GetFiles(string folder);
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> GetFilesAsync(string folder, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> GetFilesAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        protected NuGet.Frameworks.NuGetFramework GetFrameworkFromPath(string path, bool allowSubFolders = false) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetFrameworkItems() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetFrameworkItemsAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual NuGet.Packaging.Core.PackageIdentity GetIdentity() { throw null; }
        public virtual System.Threading.Tasks.Task<NuGet.Packaging.Core.PackageIdentity> GetIdentityAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetItems(string folderName) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetItemsAsync(string folderName, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetLibItems() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetLibItemsAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual NuGet.Versioning.NuGetVersion GetMinClientVersion() { throw null; }
        public virtual System.Threading.Tasks.Task<NuGet.Versioning.NuGetVersion> GetMinClientVersionAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.IO.Stream GetNuspec() { throw null; }
        public virtual System.Threading.Tasks.Task<System.IO.Stream> GetNuspecAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual string GetNuspecFile() { throw null; }
        protected static string GetNuspecFile(System.Collections.Generic.IEnumerable<string> files) { throw null; }
        public virtual System.Threading.Tasks.Task<string> GetNuspecFileAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task<NuGet.Packaging.NuspecReader> GetNuspecReaderAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> GetPackageDependencies() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup>> GetPackageDependenciesAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Core.PackageType> GetPackageTypes() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Core.PackageType>> GetPackageTypesAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract System.Threading.Tasks.Task<NuGet.Packaging.Signing.PrimarySignature> GetPrimarySignatureAsync(System.Threading.CancellationToken token);
        public virtual System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetReferenceItems() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetReferenceItemsAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract System.IO.Stream GetStream(string path);
        public virtual System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(string path, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> GetSupportedFrameworks() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework>> GetSupportedFrameworksAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetToolItems() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetToolItemsAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        protected static bool IsAllowedBuildFile(string packageId, string path) { throw null; }
        protected static bool IsReferenceAssembly(string path) { throw null; }
        public virtual bool IsServiceable() { throw null; }
        public virtual System.Threading.Tasks.Task<bool> IsServiceableAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract System.Threading.Tasks.Task<bool> IsSignedAsync(System.Threading.CancellationToken token);
        protected string NormalizeDirectoryPath(string path) { throw null; }
        public abstract System.Threading.Tasks.Task ValidateIntegrityAsync(NuGet.Packaging.Signing.SignatureContent signatureContent, System.Threading.CancellationToken token);
        protected static void ValidatePackageEntries(string normalizedDestination, System.Collections.Generic.IEnumerable<string> packageFiles, NuGet.Packaging.Core.PackageIdentity packageIdentity) { }
        protected static void ValidatePackageEntry(string normalizedDestination, string normalizedFilePath, NuGet.Packaging.Core.PackageIdentity packageIdentity) { }
    }
    public static partial class PackageReaderExtensions
    {
        public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> GetPackageFilesAsync(this NuGet.Packaging.Core.IAsyncPackageCoreReader packageReader, NuGet.Packaging.PackageSaveMode packageSaveMode, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> GetSatelliteFilesAsync(this NuGet.Packaging.IAsyncPackageContentReader packageReader, string packageLanguage, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class PackageReference
    {
        public PackageReference(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Frameworks.NuGetFramework targetFramework) { }
        public PackageReference(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Frameworks.NuGetFramework targetFramework, bool userInstalled) { }
        public PackageReference(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Frameworks.NuGetFramework targetFramework, bool userInstalled, bool developmentDependency, bool requireReinstallation) { }
        public PackageReference(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Frameworks.NuGetFramework targetFramework, bool userInstalled, bool developmentDependency, bool requireReinstallation, NuGet.Versioning.VersionRange allowedVersions) { }
        public NuGet.Versioning.VersionRange AllowedVersions { get { throw null; } }
        public bool HasAllowedVersions { get { throw null; } }
        public bool IsDevelopmentDependency { get { throw null; } }
        public bool IsUserInstalled { get { throw null; } }
        public NuGet.Packaging.Core.PackageIdentity PackageIdentity { get { throw null; } }
        public bool RequireReinstallation { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework TargetFramework { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class PackageReferenceSet
    {
        public PackageReferenceSet(NuGet.Frameworks.NuGetFramework targetFramework, System.Collections.Generic.IEnumerable<string> references) { }
        public PackageReferenceSet(System.Collections.Generic.IEnumerable<string> references) { }
        public PackageReferenceSet(string targetFramework, System.Collections.Generic.IEnumerable<string> references) { }
        public System.Collections.Generic.IReadOnlyCollection<string> References { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework TargetFramework { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> Validate() { throw null; }
    }
    [System.FlagsAttribute]
    public enum PackageSaveMode
    {
        Defaultv2 = 6,
        Defaultv3 = 7,
        Files = 4,
        None = 0,
        Nupkg = 2,
        Nuspec = 1,
    }
    public static partial class PackagesConfig
    {
        public static readonly string allowedVersionsAttributeName;
        public static readonly string developmentDependencyAttributeName;
        public static readonly string IdAttributeName;
        public static readonly string MinClientAttributeName;
        public static readonly string PackageNodeName;
        public static readonly string PackagesNodeName;
        public static readonly string RequireInstallAttributeName;
        public static readonly string TargetFrameworkAttributeName;
        public static readonly string UserInstalledAttributeName;
        public static readonly string VersionAttributeName;
        public static bool BoolAttribute(System.Xml.Linq.XElement node, string name, bool defaultValue = false) { throw null; }
        public static bool HasAttributeValue(System.Xml.Linq.XElement node, string attributeName, string targetValue, out System.Xml.Linq.XElement element) { throw null; }
        public static bool TryGetAttribute(System.Xml.Linq.XElement node, string name, out string value) { throw null; }
    }
    public partial class PackagesConfigReader
    {
        public PackagesConfigReader(NuGet.Frameworks.IFrameworkNameProvider frameworkMappings, System.IO.Stream stream, bool leaveStreamOpen) { }
        public PackagesConfigReader(NuGet.Frameworks.IFrameworkNameProvider frameworkMappings, System.Xml.Linq.XDocument xml) { }
        public PackagesConfigReader(System.IO.Stream stream) { }
        public PackagesConfigReader(System.IO.Stream stream, bool leaveStreamOpen) { }
        public PackagesConfigReader(System.Xml.Linq.XDocument xml) { }
        public NuGet.Versioning.NuGetVersion GetMinClientVersion() { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageReference> GetPackages() { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageReference> GetPackages(bool allowDuplicatePackageIds) { throw null; }
    }
    public partial class PackagesConfigReaderException : NuGet.Packaging.Core.PackagingException
    {
        public PackagesConfigReaderException(string message) : base (default(string)) { }
        public PackagesConfigReaderException(string message, System.Exception innerException) : base (default(string)) { }
    }
    public partial class PackagesConfigWriter : System.IDisposable
    {
        public PackagesConfigWriter(System.IO.Stream stream, bool createNew) { }
        public PackagesConfigWriter(System.IO.Stream stream, bool createNew, NuGet.Frameworks.IFrameworkNameProvider frameworkMappings) { }
        public PackagesConfigWriter(string fullPath, bool createNew) { }
        public PackagesConfigWriter(string fullPath, bool createNew, NuGet.Frameworks.IFrameworkNameProvider frameworkMappings) { }
        public void AddPackageEntry(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Frameworks.NuGetFramework targetFramework) { }
        public void AddPackageEntry(NuGet.Packaging.PackageReference entry) { }
        public void AddPackageEntry(string packageId, NuGet.Versioning.NuGetVersion version, NuGet.Frameworks.NuGetFramework targetFramework) { }
        public void Dispose() { }
        public void RemovePackageEntry(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Frameworks.NuGetFramework targetFramework) { }
        public void RemovePackageEntry(NuGet.Packaging.PackageReference entry) { }
        public void RemovePackageEntry(string packageId, NuGet.Versioning.NuGetVersion version, NuGet.Frameworks.NuGetFramework targetFramework) { }
        public void UpdateOrAddPackageEntry(System.Xml.Linq.XDocument originalConfig, NuGet.Packaging.PackageReference newEntry) { }
        public void UpdatePackageEntry(NuGet.Packaging.PackageReference oldEntry, NuGet.Packaging.PackageReference newEntry) { }
        public void WriteFile(string fullPath) { }
        public void WriteMinClientVersion(NuGet.Versioning.NuGetVersion version) { }
    }
    public partial class PackagesConfigWriterException : NuGet.Packaging.Core.PackagingException
    {
        public PackagesConfigWriterException(string message) : base (default(string)) { }
        public PackagesConfigWriterException(string message, System.Exception innerException) : base (default(string)) { }
    }
    public partial class PackageSigningTelemetryEvent : NuGet.Common.TelemetryEvent
    {
        public const string EventName = "SigningInformation";
        public PackageSigningTelemetryEvent(NuGet.Packaging.PackageSignType packageSignType, NuGet.Common.NuGetOperationStatus status) : base (default(string)) { }
        public string ExtractionId { get { throw null; } }
        public NuGet.Packaging.PackageSignType PackageSignType { get { throw null; } }
        public NuGet.Common.NuGetOperationStatus Status { get { throw null; } }
    }
    public enum PackageSignType
    {
        Signed = 0,
        Unsigned = 1,
    }
    public static partial class PackagingConstants
    {
        public static readonly string AgnosticFramework;
        public static readonly string AnyCodeLanguage;
        public static readonly string AnyFramework;
        public static readonly string ContentFilesDefaultBuildAction;
        public static readonly string ManifestExtension;
        public static readonly string PackageVerifyDurationName;
        public static readonly string SnupkgFormat;
        public static readonly string SymbolsNupkgFormat;
        public static readonly string TargetFrameworkPropertyKey;
        public static partial class Folders
        {
            public static readonly string Analyzers;
            public static readonly string Build;
            public static readonly string BuildCrossTargeting;
            public static readonly string BuildTransitive;
            public static readonly string Content;
            public static readonly string ContentFiles;
            public static readonly string Lib;
            public static readonly string Native;
            public static readonly string Ref;
            public static readonly string Runtimes;
            public static readonly string Source;
            public static readonly string Tools;
            public static string[] Known { get { throw null; } }
        }
    }
    public partial class PhysicalPackageFile : NuGet.Packaging.IPackageFile
    {
        public PhysicalPackageFile() { }
        public PhysicalPackageFile(System.IO.MemoryStream stream) { }
        public string EffectivePath { get { throw null; } }
        public System.DateTimeOffset LastWriteTime { get { throw null; } }
        public string Path { get { throw null; } }
        public string SourcePath { get { throw null; } set { } }
        public System.Runtime.Versioning.FrameworkName TargetFramework { get { throw null; } }
        public string TargetPath { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.IO.Stream GetStream() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RepositorySignatureInfo
    {
        public RepositorySignatureInfo(bool allRepositorySigned, System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.IRepositoryCertificateInfo> repositoryCertificateInfos) { }
        public bool AllRepositorySigned { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.IRepositoryCertificateInfo> RepositoryCertificateInfos { get { throw null; } }
    }
    public partial class RepositorySignatureInfoProvider
    {
        public RepositorySignatureInfoProvider() { }
        public static NuGet.Packaging.RepositorySignatureInfoProvider Instance { get { throw null; } }
        public void AddOrUpdateRepositorySignatureInfo(string source, NuGet.Packaging.RepositorySignatureInfo repositorySignatureInfo) { }
        public bool TryGetRepositorySignatureInfo(string source, out NuGet.Packaging.RepositorySignatureInfo repositorySignatureInfo) { throw null; }
    }
    public sealed partial class Sha512HashFunction : NuGet.Packaging.IHashFunction, System.IDisposable
    {
        public Sha512HashFunction() { }
        public void Dispose() { }
        public string GetHash() { throw null; }
        public void Update(byte[] data, int offset, int count) { }
    }
    public static partial class StreamExtensions
    {
        public static string CopyToFile(this System.IO.Stream inputStream, string fileFullPath) { throw null; }
    }
    public static partial class TopologicalSortUtility
    {
        public static System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Core.PackageDependencyInfo> SortPackagesByDependencyOrder(System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependencyInfo> packages) { throw null; }
        public static System.Collections.Generic.IReadOnlyList<T> SortPackagesByDependencyOrder<T>(System.Collections.Generic.IEnumerable<T> items, System.StringComparer comparer, System.Func<T, string> getId, System.Func<T, string[]> getDependencies) where T : class { throw null; }
    }
    public partial class UnsafePackageEntryException : NuGet.Packaging.Core.PackagingException, NuGet.Common.ILogMessageException
    {
        public UnsafePackageEntryException(string message) : base (default(string)) { }
        public override NuGet.Common.ILogMessage AsLogMessage() { throw null; }
    }
    public partial class VersionFolderPathResolver
    {
        public VersionFolderPathResolver(string rootPath) { }
        public VersionFolderPathResolver(string rootPath, bool isLowercase) { }
        public bool IsLowerCase { get { throw null; } }
        public string RootPath { get { throw null; } }
        public string GetHashFileName(string packageId, NuGet.Versioning.NuGetVersion version) { throw null; }
        public string GetHashPath(string packageId, NuGet.Versioning.NuGetVersion version) { throw null; }
        public virtual string GetInstallPath(string packageId, NuGet.Versioning.NuGetVersion version) { throw null; }
        public virtual string GetManifestFileName(string packageId, NuGet.Versioning.NuGetVersion version) { throw null; }
        public string GetManifestFilePath(string packageId, NuGet.Versioning.NuGetVersion version) { throw null; }
        public string GetNupkgMetadataPath(string packageId, NuGet.Versioning.NuGetVersion version) { throw null; }
        public virtual string GetPackageDirectory(string packageId, NuGet.Versioning.NuGetVersion version) { throw null; }
        public string GetPackageDownloadMarkerFileName(string packageId) { throw null; }
        public virtual string GetPackageFileName(string packageId, NuGet.Versioning.NuGetVersion version) { throw null; }
        public string GetPackageFilePath(string packageId, NuGet.Versioning.NuGetVersion version) { throw null; }
        public virtual string GetVersionListDirectory(string packageId) { throw null; }
        public string GetVersionListPath(string packageId) { throw null; }
    }
    public static partial class XElementExtensions
    {
        public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsNoNamespace(this System.Xml.Linq.XContainer container, string localName) { throw null; }
        public static System.Xml.Linq.XElement Except(this System.Xml.Linq.XElement source, System.Xml.Linq.XElement target) { throw null; }
        public static string GetOptionalAttributeValue(this System.Xml.Linq.XElement element, string localName, string namespaceName = null) { throw null; }
    }
    public enum XmlDocFileSaveMode
    {
        Compress = 2,
        None = 0,
        Skip = 1,
    }
    public static partial class XmlUtility
    {
        public static System.Xml.Linq.XDocument LoadSafe(System.IO.Stream input) { throw null; }
        public static System.Xml.Linq.XDocument LoadSafe(System.IO.Stream input, bool ignoreWhiteSpace) { throw null; }
    }
    public static partial class ZipArchiveExtensions
    {
        public static System.Collections.Generic.IEnumerable<string> GetFiles(this System.IO.Compression.ZipArchive zipArchive) { throw null; }
        public static System.IO.Compression.ZipArchiveEntry LookupEntry(this System.IO.Compression.ZipArchive zipArchive, string path) { throw null; }
        public static System.IO.Stream OpenFile(this System.IO.Compression.ZipArchive zipArchive, string path) { throw null; }
        public static string SaveAsFile(this System.IO.Compression.ZipArchiveEntry entry, string fileFullPath, NuGet.Common.ILogger logger) { throw null; }
        public static void UpdateFileTimeFromEntry(this System.IO.Compression.ZipArchiveEntry entry, string fileFullPath, NuGet.Common.ILogger logger) { }
    }
    public partial class ZipFilePair
    {
        public ZipFilePair(string fileFullPath, System.IO.Compression.ZipArchiveEntry entry) { }
        public string FileFullPath { get { throw null; } }
        public System.IO.Compression.ZipArchiveEntry PackageEntry { get { throw null; } }
        public bool IsInstalled() { throw null; }
    }
}
namespace NuGet.Packaging.Core
{
    public partial class ContentFilesEntry
    {
        public ContentFilesEntry(string include, string exclude, string buildAction, System.Nullable<bool> copyToOutput, System.Nullable<bool> flatten) { }
        public string BuildAction { get { throw null; } }
        public System.Nullable<bool> CopyToOutput { get { throw null; } }
        public string Exclude { get { throw null; } }
        public System.Nullable<bool> Flatten { get { throw null; } }
        public string Include { get { throw null; } }
    }
    public delegate string ExtractPackageFileDelegate(string sourceFile, string targetPath, System.IO.Stream fileStream);
    public partial class Fingerprints
    {
        public Fingerprints(System.Collections.Generic.IDictionary<string, string> fingerPrints) { }
        public string this[string key] { get { throw null; } }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator() { throw null; }
    }
    public partial interface IAsyncPackageCoreReader : System.IDisposable
    {
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> CopyFilesAsync(string destination, System.Collections.Generic.IEnumerable<string> packageFiles, NuGet.Packaging.Core.ExtractPackageFileDelegate extractFile, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> GetFilesAsync(string folder, System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> GetFilesAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<NuGet.Packaging.Core.PackageIdentity> GetIdentityAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<NuGet.Versioning.NuGetVersion> GetMinClientVersionAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.IO.Stream> GetNuspecAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<string> GetNuspecFileAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Core.PackageType>> GetPackageTypesAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(string path, System.Threading.CancellationToken cancellationToken);
    }
    public partial interface INuspecCoreReader
    {
        string GetId();
        NuGet.Packaging.Core.PackageIdentity GetIdentity();
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> GetMetadata();
        NuGet.Versioning.NuGetVersion GetMinClientVersion();
        System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Core.PackageType> GetPackageTypes();
        NuGet.Versioning.NuGetVersion GetVersion();
    }
    public partial interface IPackageCoreReader : System.IDisposable
    {
        System.Collections.Generic.IEnumerable<string> CopyFiles(string destination, System.Collections.Generic.IEnumerable<string> packageFiles, NuGet.Packaging.Core.ExtractPackageFileDelegate extractFile, NuGet.Common.ILogger logger, System.Threading.CancellationToken token);
        System.Collections.Generic.IEnumerable<string> GetFiles();
        System.Collections.Generic.IEnumerable<string> GetFiles(string folder);
        NuGet.Packaging.Core.PackageIdentity GetIdentity();
        NuGet.Versioning.NuGetVersion GetMinClientVersion();
        System.IO.Stream GetNuspec();
        string GetNuspecFile();
        System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Core.PackageType> GetPackageTypes();
        System.IO.Stream GetStream(string path);
    }
    public partial interface IPackageIdentityComparer : System.Collections.Generic.IComparer<NuGet.Packaging.Core.PackageIdentity>, System.Collections.Generic.IEqualityComparer<NuGet.Packaging.Core.PackageIdentity>
    {
    }
    public partial interface IRepositoryCertificateInfo
    {
        string ContentUrl { get; }
        NuGet.Packaging.Core.Fingerprints Fingerprints { get; }
        string Issuer { get; }
        System.DateTimeOffset NotAfter { get; }
        System.DateTimeOffset NotBefore { get; }
        string Subject { get; }
    }
    public partial class NuspecCoreReader : NuGet.Packaging.Core.NuspecCoreReaderBase
    {
        public NuspecCoreReader(System.IO.Stream stream) : base (default(string)) { }
        public NuspecCoreReader(System.Xml.Linq.XDocument xml) : base (default(string)) { }
        public virtual System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependency> GetDependencies() { throw null; }
    }
    public abstract partial class NuspecCoreReaderBase : NuGet.Packaging.Core.INuspecCoreReader
    {
        protected const string DevelopmentDependency = "developmentDependency";
        protected const string Id = "id";
        protected const string Metadata = "metadata";
        protected const string MinClientVersion = "minClientVersion";
        protected const string Version = "version";
        public NuspecCoreReaderBase(System.IO.Stream stream) { }
        public NuspecCoreReaderBase(System.IO.Stream stream, bool leaveStreamOpen) { }
        public NuspecCoreReaderBase(string path) { }
        public NuspecCoreReaderBase(System.Xml.Linq.XDocument xml) { }
        protected System.Xml.Linq.XElement MetadataNode { get { throw null; } }
        protected System.Collections.Generic.Dictionary<string, string> MetadataValues { get { throw null; } }
        public System.Xml.Linq.XDocument Xml { get { throw null; } }
        public virtual bool GetDevelopmentDependency() { throw null; }
        public virtual string GetId() { throw null; }
        public virtual NuGet.Packaging.Core.PackageIdentity GetIdentity() { throw null; }
        public virtual System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> GetMetadata() { throw null; }
        public virtual string GetMetadataValue(string name) { throw null; }
        public virtual NuGet.Versioning.NuGetVersion GetMinClientVersion() { throw null; }
        public virtual System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Core.PackageType> GetPackageTypes() { throw null; }
        public virtual NuGet.Versioning.NuGetVersion GetVersion() { throw null; }
        public virtual bool IsServiceable() { throw null; }
    }
    public static partial class NuspecUtility
    {
        public static readonly string FrameworkReference;
        public static readonly string FrameworkReferences;
        public static readonly string Group;
        public static readonly string License;
        public static readonly string Name;
        public static readonly string PackageType;
        public static readonly string PackageTypes;
        public static readonly string Repository;
        public static readonly string RepositoryBranch;
        public static readonly string RepositoryCommit;
        public static readonly string RepositoryUrl;
        public static readonly string Serviceable;
        public static readonly string TargetFramework;
        public static readonly string Type;
        public static readonly string Version;
        public static System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Core.PackageType> GetPackageTypes(System.Xml.Linq.XElement metadataNode, bool useMetadataNamespace) { throw null; }
        public static bool IsServiceable(System.Xml.Linq.XElement metadataNode) { throw null; }
    }
    public partial class PackageDependency : System.IEquatable<NuGet.Packaging.Core.PackageDependency>
    {
        public PackageDependency(string id) { }
        public PackageDependency(string id, NuGet.Versioning.VersionRange versionRange) { }
        public PackageDependency(string id, NuGet.Versioning.VersionRange versionRange, System.Collections.Generic.IReadOnlyList<string> include, System.Collections.Generic.IReadOnlyList<string> exclude) { }
        public System.Collections.Generic.IReadOnlyList<string> Exclude { get { throw null; } }
        public string Id { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Include { get { throw null; } }
        public NuGet.Versioning.VersionRange VersionRange { get { throw null; } }
        public bool Equals(NuGet.Packaging.Core.PackageDependency other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PackageDependencyComparer : System.Collections.Generic.IEqualityComparer<NuGet.Packaging.Core.PackageDependency>
    {
        public static readonly NuGet.Packaging.Core.PackageDependencyComparer Default;
        public PackageDependencyComparer() { }
        public PackageDependencyComparer(NuGet.Versioning.IVersionRangeComparer versionRangeComparer) { }
        public bool Equals(NuGet.Packaging.Core.PackageDependency x, NuGet.Packaging.Core.PackageDependency y) { throw null; }
        public int GetHashCode(NuGet.Packaging.Core.PackageDependency obj) { throw null; }
    }
    public partial class PackageDependencyInfo : NuGet.Packaging.Core.PackageIdentity, System.IEquatable<NuGet.Packaging.Core.PackageDependencyInfo>
    {
        public PackageDependencyInfo(NuGet.Packaging.Core.PackageIdentity identity, System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependency> dependencies) : base (default(string), default(NuGet.Versioning.NuGetVersion)) { }
        public PackageDependencyInfo(string id, NuGet.Versioning.NuGetVersion version) : base (default(string), default(NuGet.Versioning.NuGetVersion)) { }
        public PackageDependencyInfo(string id, NuGet.Versioning.NuGetVersion version, System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependency> dependencies) : base (default(string), default(NuGet.Versioning.NuGetVersion)) { }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependency> Dependencies { get { throw null; } }
        public bool Equals(NuGet.Packaging.Core.PackageDependencyInfo other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PackageDependencyInfoComparer : System.Collections.Generic.IEqualityComparer<NuGet.Packaging.Core.PackageDependencyInfo>
    {
        public PackageDependencyInfoComparer() { }
        public PackageDependencyInfoComparer(NuGet.Packaging.Core.IPackageIdentityComparer identityComparer, NuGet.Packaging.Core.PackageDependencyComparer dependencyComparer) { }
        public static NuGet.Packaging.Core.PackageDependencyInfoComparer Default { get { throw null; } }
        public bool Equals(NuGet.Packaging.Core.PackageDependencyInfo x, NuGet.Packaging.Core.PackageDependencyInfo y) { throw null; }
        public int GetHashCode(NuGet.Packaging.Core.PackageDependencyInfo obj) { throw null; }
    }
    public partial class PackageIdentity : System.IComparable<NuGet.Packaging.Core.PackageIdentity>, System.IEquatable<NuGet.Packaging.Core.PackageIdentity>
    {
        public PackageIdentity(string id, NuGet.Versioning.NuGetVersion version) { }
        public static NuGet.Packaging.Core.PackageIdentityComparer Comparer { get { throw null; } }
        public bool HasVersion { get { throw null; } }
        public string Id { get { throw null; } }
        public NuGet.Versioning.NuGetVersion Version { get { throw null; } }
        public int CompareTo(NuGet.Packaging.Core.PackageIdentity other) { throw null; }
        public bool Equals(NuGet.Packaging.Core.PackageIdentity other) { throw null; }
        public virtual bool Equals(NuGet.Packaging.Core.PackageIdentity other, NuGet.Versioning.VersionComparison versionComparison) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PackageIdentityComparer : NuGet.Packaging.Core.IPackageIdentityComparer, System.Collections.Generic.IComparer<NuGet.Packaging.Core.PackageIdentity>, System.Collections.Generic.IEqualityComparer<NuGet.Packaging.Core.PackageIdentity>
    {
        public PackageIdentityComparer() { }
        public PackageIdentityComparer(NuGet.Versioning.IVersionComparer versionComparer) { }
        public PackageIdentityComparer(NuGet.Versioning.VersionComparison versionComparison) { }
        public static NuGet.Packaging.Core.PackageIdentityComparer Default { get { throw null; } }
        public int Compare(NuGet.Packaging.Core.PackageIdentity x, NuGet.Packaging.Core.PackageIdentity y) { throw null; }
        public bool Equals(NuGet.Packaging.Core.PackageIdentity x, NuGet.Packaging.Core.PackageIdentity y) { throw null; }
        public int GetHashCode(NuGet.Packaging.Core.PackageIdentity obj) { throw null; }
    }
    public partial class PackageType : System.IComparable<NuGet.Packaging.Core.PackageType>, System.IEquatable<NuGet.Packaging.Core.PackageType>
    {
        public static readonly NuGet.Packaging.Core.PackageType Dependency;
        public static readonly NuGet.Packaging.Core.PackageType DotnetCliTool;
        public static readonly NuGet.Packaging.Core.PackageType DotnetPlatform;
        public static readonly NuGet.Packaging.Core.PackageType DotnetTool;
        public static readonly System.Version EmptyVersion;
        public static readonly NuGet.Packaging.Core.PackageType Legacy;
        public static readonly System.StringComparer PackageTypeNameComparer;
        public static readonly NuGet.Packaging.Core.PackageType SymbolsPackage;
        public PackageType(string name, System.Version version) { }
        public string Name { get { throw null; } }
        public System.Version Version { get { throw null; } }
        public int CompareTo(NuGet.Packaging.Core.PackageType other) { throw null; }
        public bool Equals(NuGet.Packaging.Core.PackageType other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(NuGet.Packaging.Core.PackageType a, NuGet.Packaging.Core.PackageType b) { throw null; }
        public static bool operator !=(NuGet.Packaging.Core.PackageType a, NuGet.Packaging.Core.PackageType b) { throw null; }
    }
    public static partial class PackagingCoreConstants
    {
        public static readonly string EmptyFolder;
        public static readonly string ForwardSlashEmptyFolder;
        public static readonly string HashFileExtension;
        public static readonly string NupkgExtension;
        public static readonly string NupkgMetadataFileExtension;
        public static readonly string NuspecExtension;
        public static readonly string PackageDownloadMarkerFileExtension;
    }
    public partial class PackagingException : System.Exception, NuGet.Common.ILogMessageException
    {
        public PackagingException(NuGet.Common.NuGetLogCode logCode, string message) { }
        public PackagingException(NuGet.Common.NuGetLogCode logCode, string message, System.Exception innerException) { }
        public PackagingException(string message) { }
        public PackagingException(string message, System.Exception innerException) { }
        public virtual NuGet.Common.ILogMessage AsLogMessage() { throw null; }
    }
    public partial class RepositoryMetadata : System.IEquatable<NuGet.Packaging.Core.RepositoryMetadata>
    {
        public RepositoryMetadata() { }
        public RepositoryMetadata(string type, string url, string branch, string commit) { }
        public string Branch { get { throw null; } set { } }
        public string Commit { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        public string Url { get { throw null; } set { } }
        public bool Equals(NuGet.Packaging.Core.RepositoryMetadata other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(NuGet.Packaging.Core.RepositoryMetadata a, NuGet.Packaging.Core.RepositoryMetadata b) { throw null; }
        public static bool operator !=(NuGet.Packaging.Core.RepositoryMetadata a, NuGet.Packaging.Core.RepositoryMetadata b) { throw null; }
    }
}
namespace NuGet.Packaging.Licenses
{
    public partial class ExceptionData
    {
        public ExceptionData(string licenseID, bool isDeprecatedLicenseId) { }
        public bool IsDeprecatedLicenseId { get { throw null; } }
        public string LicenseExceptionID { get { throw null; } }
    }
    public partial class LicenseData
    {
        public LicenseData(string licenseID, bool isOsiApproved, bool isDeprecatedLicenseId, bool isFsfLibre) { }
        public bool IsDeprecatedLicenseId { get { throw null; } }
        public bool IsFsfLibre { get { throw null; } }
        public bool IsOsiApproved { get { throw null; } }
        public string LicenseID { get { throw null; } }
    }
    public enum LicenseExpressionType
    {
        License = 0,
        Operator = 1,
    }
    public abstract partial class LicenseOperator : NuGet.Packaging.Licenses.NuGetLicenseExpression
    {
        protected LicenseOperator(NuGet.Packaging.Licenses.LicenseOperatorType operatorType) { }
        public NuGet.Packaging.Licenses.LicenseOperatorType OperatorType { get { throw null; } }
    }
    public enum LicenseOperatorType
    {
        LogicalOperator = 1,
        WithOperator = 0,
    }
    public partial class LogicalOperator : NuGet.Packaging.Licenses.LicenseOperator
    {
        public LogicalOperator(NuGet.Packaging.Licenses.LogicalOperatorType logicalOperatorType, NuGet.Packaging.Licenses.NuGetLicenseExpression left, NuGet.Packaging.Licenses.NuGetLicenseExpression right) : base (default(NuGet.Packaging.Licenses.LicenseOperatorType)) { }
        public NuGet.Packaging.Licenses.NuGetLicenseExpression Left { get { throw null; } }
        public NuGet.Packaging.Licenses.LogicalOperatorType LogicalOperatorType { get { throw null; } }
        public NuGet.Packaging.Licenses.NuGetLicenseExpression Right { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public enum LogicalOperatorType
    {
        And = 0,
        Or = 1,
    }
    public partial class NuGetLicense : NuGet.Packaging.Licenses.NuGetLicenseExpression
    {
        internal NuGetLicense() { }
        public string Identifier { get { throw null; } }
        public bool IsStandardLicense { get { throw null; } }
        public bool Plus { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class NuGetLicenseData
    {
        public static readonly System.Collections.Generic.IReadOnlyDictionary<string, NuGet.Packaging.Licenses.ExceptionData> ExceptionList;
        public static readonly System.Collections.Generic.IReadOnlyDictionary<string, NuGet.Packaging.Licenses.LicenseData> LicenseList;
        public static string LicenseListVersion;
        public NuGetLicenseData() { }
    }
    public partial class NuGetLicenseException
    {
        internal NuGetLicenseException() { }
        public string Identifier { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public abstract partial class NuGetLicenseExpression
    {
        protected NuGetLicenseExpression() { }
        public NuGet.Packaging.Licenses.LicenseExpressionType Type { get { throw null; } protected set { } }
        public static NuGet.Packaging.Licenses.NuGetLicenseExpression Parse(string expression) { throw null; }
    }
    public static partial class NuGetLicenseExpressionExtensions
    {
        public static bool HasOnlyStandardIdentifiers(this NuGet.Packaging.Licenses.NuGetLicenseExpression expression) { throw null; }
        public static bool IsUnlicensed(this NuGet.Packaging.Licenses.NuGetLicense license) { throw null; }
        public static bool IsUnlicensed(this NuGet.Packaging.Licenses.NuGetLicenseExpression expression) { throw null; }
        public static void OnEachLeafNode(this NuGet.Packaging.Licenses.NuGetLicenseExpression expression, System.Action<NuGet.Packaging.Licenses.NuGetLicense> licenseProcessor, System.Action<NuGet.Packaging.Licenses.NuGetLicenseException> exceptionProcessor) { }
    }
    public partial class NuGetLicenseExpressionParsingException : System.Exception
    {
        public NuGetLicenseExpressionParsingException(string message) { }
        public NuGetLicenseExpressionParsingException(string message, System.Exception innerException) { }
    }
    public partial class WithOperator : NuGet.Packaging.Licenses.LicenseOperator
    {
        public WithOperator(NuGet.Packaging.Licenses.NuGetLicense license, NuGet.Packaging.Licenses.NuGetLicenseException exception) : base (default(NuGet.Packaging.Licenses.LicenseOperatorType)) { }
        public NuGet.Packaging.Licenses.NuGetLicenseException Exception { get { throw null; } }
        public NuGet.Packaging.Licenses.NuGetLicense License { get { throw null; } }
        public override string ToString() { throw null; }
    }
}
namespace NuGet.Packaging.PackageExtraction
{
    public static partial class PackageExtractionBehavior
    {
        public static NuGet.Packaging.XmlDocFileSaveMode XmlDocFileSaveMode { get { throw null; } set { } }
    }
}
namespace NuGet.Packaging.Rules
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    public partial class AnalysisResources
    {
        internal AnalysisResources() { }
        public static string AssemblyDirectlyUnderLibWarning { get { throw null; } }
        public static string AssemblyOutsideLibWarning { get { throw null; } }
        public static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        public static string DefaultSpecValueWarning { get { throw null; } }
        public static string FilePathTooLongWarning { get { throw null; } }
        public static string InvalidFrameworkWarning { get { throw null; } }
        public static string InvalidPlaceholderFileWarning { get { throw null; } }
        public static string InvalidPrereleaseDependencyWarning { get { throw null; } }
        public static string LegacyVersionWarning { get { throw null; } }
        public static string LicenseUrlDeprecationWarning { get { throw null; } }
        public static string Migrator_AssemblyDirectlyUnderLibWarning { get { throw null; } }
        public static string Migrator_PackageHasContentFolder { get { throw null; } }
        public static string Migrator_PackageHasInstallScript { get { throw null; } }
        public static string Migrator_XdtTransformInPackage { get { throw null; } }
        public static string MisplacedInitScriptWarning { get { throw null; } }
        public static string MisplacedTransformFileWarning { get { throw null; } }
        public static string PlaceholderFileInPackageWarning { get { throw null; } }
        public static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        public static string ScriptOutsideToolsWarning { get { throw null; } }
        public static string UnrecognizedLicenseIdentifier { get { throw null; } }
        public static string UnrecognizedScriptWarning { get { throw null; } }
        public static string UnspecifiedDependencyVersionWarning { get { throw null; } }
        public static string WinRTObsoleteWarning { get { throw null; } }
    }
    public partial class DefaultManifestValuesRule : NuGet.Packaging.Rules.IPackageRule
    {
        public DefaultManifestValuesRule(string messageFormat) { }
        public string MessageFormat { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Common.PackagingLogMessage> Validate(NuGet.Packaging.PackageArchiveReader builder) { throw null; }
    }
    public partial interface IPackageRule
    {
        string MessageFormat { get; }
        System.Collections.Generic.IEnumerable<NuGet.Common.PackagingLogMessage> Validate(NuGet.Packaging.PackageArchiveReader builder);
    }
    public partial class LicenseUrlDeprecationWarning : NuGet.Packaging.Rules.IPackageRule
    {
        public LicenseUrlDeprecationWarning(string messageFormat) { }
        public string MessageFormat { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Common.PackagingLogMessage> Validate(NuGet.Packaging.PackageArchiveReader builder) { throw null; }
    }
    public partial class PathTooLongRule : NuGet.Packaging.Rules.IPackageRule
    {
        public PathTooLongRule(string messageFormat) { }
        public string MessageFormat { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Common.PackagingLogMessage> Validate(NuGet.Packaging.PackageArchiveReader builder) { throw null; }
    }
    public static partial class RuleSet
    {
        public static System.Collections.Generic.IEnumerable<NuGet.Packaging.Rules.IPackageRule> PackageCreationRuleSet { get { throw null; } }
        public static System.Collections.Generic.IEnumerable<NuGet.Packaging.Rules.IPackageRule> PackagesConfigToPackageReferenceMigrationRuleSet { get { throw null; } }
    }
    public partial class UnspecifiedDependencyVersionRule : NuGet.Packaging.Rules.IPackageRule
    {
        public UnspecifiedDependencyVersionRule(string messageFormat) { }
        public string MessageFormat { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Common.PackagingLogMessage> Validate(NuGet.Packaging.PackageArchiveReader builder) { throw null; }
    }
}
namespace NuGet.Packaging.Signing
{
    public sealed partial class Accuracy
    {
        internal Accuracy() { }
        public System.Nullable<int> Microseconds { get { throw null; } }
        public System.Nullable<int> Milliseconds { get { throw null; } }
        public System.Nullable<int> Seconds { get { throw null; } }
        public System.Nullable<long> GetTotalMicroseconds() { throw null; }
        public static NuGet.Packaging.Signing.Accuracy Read(byte[] bytes) { throw null; }
    }
    public sealed partial class AlgorithmIdentifier
    {
        internal AlgorithmIdentifier() { }
        public System.Security.Cryptography.Oid Algorithm { get { throw null; } }
        public static NuGet.Packaging.Signing.AlgorithmIdentifier Read(byte[] bytes) { throw null; }
    }
    public partial class AllowListVerificationProvider : NuGet.Packaging.Signing.ISignatureVerificationProvider
    {
        public AllowListVerificationProvider(System.Collections.Generic.IReadOnlyCollection<NuGet.Packaging.Signing.VerificationAllowListEntry> allowList, bool requireNonEmptyAllowList = false, string emptyListErrorMessage = "", string noMatchErrorMessage = "") { }
        public System.Threading.Tasks.Task<NuGet.Packaging.Signing.PackageVerificationResult> GetTrustResultAsync(NuGet.Packaging.Signing.ISignedPackageReader package, NuGet.Packaging.Signing.PrimarySignature signature, NuGet.Packaging.Signing.SignedPackageVerifierSettings settings, System.Threading.CancellationToken token) { throw null; }
    }
    public static partial class AttributeUtility
    {
    }
    public sealed partial class AuthorPrimarySignature : NuGet.Packaging.Signing.PrimarySignature
    {
        public AuthorPrimarySignature() { }
    }
    public sealed partial class AuthorSignPackageRequest : NuGet.Packaging.Signing.SignPackageRequest
    {
        public AuthorSignPackageRequest(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, NuGet.Common.HashAlgorithmName hashAlgorithm) : base (default(System.Security.Cryptography.X509Certificates.X509Certificate2), default(NuGet.Common.HashAlgorithmName), default(NuGet.Common.HashAlgorithmName)) { }
        public AuthorSignPackageRequest(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, NuGet.Common.HashAlgorithmName signatureHashAlgorithm, NuGet.Common.HashAlgorithmName timestampHashAlgorithm) : base (default(System.Security.Cryptography.X509Certificates.X509Certificate2), default(NuGet.Common.HashAlgorithmName), default(NuGet.Common.HashAlgorithmName)) { }
        public override NuGet.Packaging.Signing.SignatureType SignatureType { get { throw null; } }
    }
    public sealed partial class CentralDirectoryHeaderMetadata
    {
        public CentralDirectoryHeaderMetadata() { }
        public long ChangeInOffset { get { throw null; } set { } }
        public long FileEntryTotalSize { get { throw null; } set { } }
        public long HeaderSize { get { throw null; } set { } }
        public int IndexInHeaders { get { throw null; } set { } }
        public bool IsPackageSignatureFile { get { throw null; } set { } }
        public long OffsetToLocalFileHeader { get { throw null; } set { } }
        public long Position { get { throw null; } set { } }
    }
    public static partial class CertificateChainUtility
    {
        public static NuGet.Packaging.Signing.IX509CertificateChain GetCertificateChain(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore, NuGet.Common.ILogger logger, NuGet.Packaging.Signing.CertificateType certificateType) { throw null; }
        public static NuGet.Packaging.Signing.IX509CertificateChain GetCertificateChain(System.Security.Cryptography.X509Certificates.X509Chain x509Chain) { throw null; }
    }
    public partial class CertificateHashAllowListEntry : NuGet.Packaging.Signing.VerificationAllowListEntry
    {
        public CertificateHashAllowListEntry(NuGet.Packaging.Signing.VerificationTarget target, NuGet.Packaging.Signing.SignaturePlacement placement, string fingerprint, NuGet.Common.HashAlgorithmName algorithm) : base (default(NuGet.Packaging.Signing.VerificationTarget), default(NuGet.Packaging.Signing.SignaturePlacement)) { }
        public string Fingerprint { get { throw null; } }
        public NuGet.Common.HashAlgorithmName FingerprintAlgorithm { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public enum CertificateType
    {
        Signature = 0,
        Timestamp = 1,
    }
    public static partial class CertificateUtility
    {
        public static byte[] GetHash(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, NuGet.Common.HashAlgorithmName hashAlgorithm) { throw null; }
        public static string GetHashString(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, NuGet.Common.HashAlgorithmName hashAlgorithm) { throw null; }
        public static System.Collections.Generic.IReadOnlyList<byte[]> GetRawDataForCollection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { throw null; }
        public static bool HasExtendedKeyUsage(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, string ekuOid) { throw null; }
        public static bool HasLifetimeSigningEku(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public static bool IsCertificatePublicKeyValid(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public static bool IsCertificateValidityPeriodInTheFuture(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public static bool IsDateInsideValidityPeriod(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.DateTimeOffset date) { throw null; }
        public static bool IsSelfIssued(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public static bool IsSignatureAlgorithmSupported(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public static bool IsValidForPurposeFast(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, string ekuOid) { throw null; }
        public static string X509Certificate2CollectionToString(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certCollection, NuGet.Common.HashAlgorithmName fingerprintAlgorithm) { throw null; }
        public static string X509Certificate2ToString(System.Security.Cryptography.X509Certificates.X509Certificate2 cert, NuGet.Common.HashAlgorithmName fingerprintAlgorithm) { throw null; }
        public static string X509ChainToString(System.Security.Cryptography.X509Certificates.X509Chain chain, NuGet.Common.HashAlgorithmName fingerprintAlgorithm) { throw null; }
    }
    public partial class ClientPolicyContext
    {
        internal ClientPolicyContext() { }
        public System.Collections.Generic.IReadOnlyCollection<NuGet.Packaging.Signing.TrustedSignerAllowListEntry> AllowList { get { throw null; } }
        public NuGet.Common.SignatureValidationMode Policy { get { throw null; } }
        public NuGet.Packaging.Signing.SignedPackageVerifierSettings VerifierSettings { get { throw null; } }
        public static NuGet.Packaging.Signing.ClientPolicyContext GetClientPolicy(NuGet.Configuration.ISettings settings, NuGet.Common.ILogger logger) { throw null; }
    }
    public sealed partial class CommitmentTypeIndication
    {
        internal CommitmentTypeIndication() { }
        public System.Security.Cryptography.Oid CommitmentTypeId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Signing.CommitmentTypeQualifier> Qualifiers { get { throw null; } }
        public static NuGet.Packaging.Signing.CommitmentTypeIndication Create(System.Security.Cryptography.Oid commitmentTypeId) { throw null; }
        public static NuGet.Packaging.Signing.CommitmentTypeIndication Read(byte[] bytes) { throw null; }
    }
    public sealed partial class CommitmentTypeQualifier
    {
        internal CommitmentTypeQualifier() { }
        public System.Security.Cryptography.Oid CommitmentTypeIdentifier { get { throw null; } }
        public byte[] Qualifier { get { throw null; } }
        public static NuGet.Packaging.Signing.CommitmentTypeQualifier Read(byte[] bytes) { throw null; }
    }
    public static partial class Crc32
    {
        [System.CLSCompliantAttribute(false)]
        public static uint CalculateCrc(byte[] data) { throw null; }
    }
    public sealed partial class EssCertId
    {
        internal EssCertId() { }
        public byte[] CertificateHash { get { throw null; } }
        public NuGet.Packaging.Signing.IssuerSerial IssuerSerial { get { throw null; } }
        public static NuGet.Packaging.Signing.EssCertId Read(byte[] bytes) { throw null; }
    }
    public sealed partial class EssCertIdV2
    {
        internal EssCertIdV2() { }
        public byte[] CertificateHash { get { throw null; } }
        public NuGet.Packaging.Signing.AlgorithmIdentifier HashAlgorithm { get { throw null; } }
        public NuGet.Packaging.Signing.IssuerSerial IssuerSerial { get { throw null; } }
        public static NuGet.Packaging.Signing.EssCertIdV2 Create(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, NuGet.Common.HashAlgorithmName hashAlgorithmName) { throw null; }
        public static NuGet.Packaging.Signing.EssCertIdV2 Read(byte[] bytes) { throw null; }
    }
    public sealed partial class Extension
    {
        internal Extension() { }
        public bool Critical { get { throw null; } }
        public System.Security.Cryptography.Oid Id { get { throw null; } }
        public byte[] Value { get { throw null; } }
    }
    public sealed partial class Extensions
    {
        internal Extensions() { }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Signing.Extension> ExtensionsList { get { throw null; } }
        public static NuGet.Packaging.Signing.Extensions Read(byte[] bytes) { throw null; }
    }
    public sealed partial class GeneralName
    {
        internal GeneralName() { }
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName DirectoryName { get { throw null; } }
        public static NuGet.Packaging.Signing.GeneralName Create(System.Security.Cryptography.X509Certificates.X500DistinguishedName distinguishedName) { throw null; }
        public static NuGet.Packaging.Signing.GeneralName Read(byte[] bytes) { throw null; }
    }
    public partial class IntegrityVerificationProvider : NuGet.Packaging.Signing.ISignatureVerificationProvider
    {
        public IntegrityVerificationProvider() { }
        public System.Threading.Tasks.Task<NuGet.Packaging.Signing.PackageVerificationResult> GetTrustResultAsync(NuGet.Packaging.Signing.ISignedPackageReader package, NuGet.Packaging.Signing.PrimarySignature signature, NuGet.Packaging.Signing.SignedPackageVerifierSettings settings, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class InvalidSignaturePackageVerificationResult : NuGet.Packaging.Signing.PackageVerificationResult
    {
        public InvalidSignaturePackageVerificationResult(NuGet.Packaging.Signing.SignatureVerificationStatus trust, System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.SignatureLog> issues) : base (default(NuGet.Packaging.Signing.SignatureVerificationStatus), default(System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.SignatureLog>)) { }
    }
    public partial interface IPackageSignatureVerifier
    {
        System.Threading.Tasks.Task<NuGet.Packaging.Signing.VerifySignaturesResult> VerifySignaturesAsync(NuGet.Packaging.Signing.ISignedPackageReader package, NuGet.Packaging.Signing.SignedPackageVerifierSettings settings, System.Threading.CancellationToken token, System.Guid telemetryOperationId);
    }
    public partial interface IRepositorySignature : NuGet.Packaging.Signing.ISignature
    {
    }
    public partial interface ISignature
    {
    }
    public partial interface ISignatureProvider
    {
        System.Threading.Tasks.Task<NuGet.Packaging.Signing.PrimarySignature> CreatePrimarySignatureAsync(NuGet.Packaging.Signing.SignPackageRequest request, NuGet.Packaging.Signing.SignatureContent signatureContent, NuGet.Common.ILogger logger, System.Threading.CancellationToken token);
        System.Threading.Tasks.Task<NuGet.Packaging.Signing.PrimarySignature> CreateRepositoryCountersignatureAsync(NuGet.Packaging.Signing.RepositorySignPackageRequest request, NuGet.Packaging.Signing.PrimarySignature primarySignature, NuGet.Common.ILogger logger, System.Threading.CancellationToken token);
    }
    public partial interface ISignatureVerificationProvider
    {
        System.Threading.Tasks.Task<NuGet.Packaging.Signing.PackageVerificationResult> GetTrustResultAsync(NuGet.Packaging.Signing.ISignedPackageReader package, NuGet.Packaging.Signing.PrimarySignature signature, NuGet.Packaging.Signing.SignedPackageVerifierSettings settings, System.Threading.CancellationToken token);
    }
    public partial interface ISignedPackage : NuGet.Packaging.Signing.ISignedPackageReader, NuGet.Packaging.Signing.ISignedPackageWriter, System.IDisposable
    {
    }
    public partial interface ISignedPackageReader : System.IDisposable
    {
        bool CanVerifySignedPackages(NuGet.Packaging.Signing.SignedPackageVerifierSettings verifierSettings);
        System.Threading.Tasks.Task<byte[]> GetArchiveHashAsync(NuGet.Common.HashAlgorithmName hashAlgorithm, System.Threading.CancellationToken token);
        string GetContentHash(System.Threading.CancellationToken token, System.Func<string> GetUnsignedPackageHash = null);
        System.Threading.Tasks.Task<NuGet.Packaging.Signing.PrimarySignature> GetPrimarySignatureAsync(System.Threading.CancellationToken token);
        System.Threading.Tasks.Task<bool> IsSignedAsync(System.Threading.CancellationToken token);
        System.Threading.Tasks.Task ValidateIntegrityAsync(NuGet.Packaging.Signing.SignatureContent signatureContent, System.Threading.CancellationToken token);
    }
    public partial interface ISignedPackageWriter
    {
    }
    public sealed partial class IssuerSerial
    {
        internal IssuerSerial() { }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Signing.GeneralName> GeneralNames { get { throw null; } }
        public byte[] SerialNumber { get { throw null; } }
        public static NuGet.Packaging.Signing.IssuerSerial Create(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public static NuGet.Packaging.Signing.IssuerSerial Read(byte[] bytes) { throw null; }
    }
    public partial interface ITimestampProvider
    {
        System.Threading.Tasks.Task<NuGet.Packaging.Signing.PrimarySignature> TimestampSignatureAsync(NuGet.Packaging.Signing.PrimarySignature primarySignature, NuGet.Packaging.Signing.TimestampRequest request, NuGet.Common.ILogger logger, System.Threading.CancellationToken token);
    }
    public partial interface ITrustedSignersProvider
    {
        void AddOrUpdateTrustedSigner(NuGet.Configuration.TrustedSignerItem trustedSigner);
        System.Collections.Generic.IReadOnlyList<NuGet.Configuration.TrustedSignerItem> GetTrustedSigners();
        void Remove(System.Collections.Generic.IReadOnlyList<NuGet.Configuration.TrustedSignerItem> trustedSigners);
    }
    public partial interface IX509CertificateChain : System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Certificate2>, System.Collections.Generic.IReadOnlyCollection<System.Security.Cryptography.X509Certificates.X509Certificate2>, System.Collections.Generic.IReadOnlyList<System.Security.Cryptography.X509Certificates.X509Certificate2>, System.Collections.IEnumerable, System.IDisposable
    {
    }
    public partial class KeyPairFileReader : System.IDisposable
    {
        public KeyPairFileReader(System.IO.Stream stream, System.Text.Encoding encoding) { }
        public void Dispose() { }
        public System.Collections.Generic.Dictionary<string, string> ReadSection() { throw null; }
    }
    public static partial class KeyPairFileUtility
    {
        public static string GetValueOrThrow(System.Collections.Generic.Dictionary<string, string> values, string key) { throw null; }
    }
    public partial class KeyPairFileWriter : System.IDisposable
    {
        public KeyPairFileWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool leaveOpen) { }
        public void Dispose() { }
        public void WritePair(string key, string value) { }
        public void WriteSectionBreak() { }
    }
    public sealed partial class MessageImprint
    {
        internal MessageImprint() { }
        public NuGet.Packaging.Signing.AlgorithmIdentifier HashAlgorithm { get { throw null; } }
        public byte[] HashedMessage { get { throw null; } }
        public static NuGet.Packaging.Signing.MessageImprint Read(byte[] bytes) { throw null; }
    }
    public sealed partial class NuGetPackageOwners
    {
        public NuGetPackageOwners(System.Collections.Generic.IReadOnlyList<string> packageOwners) { }
        public System.Collections.Generic.IReadOnlyList<string> PackageOwners { get { throw null; } }
        public byte[] Encode() { throw null; }
        public static NuGet.Packaging.Signing.NuGetPackageOwners Read(byte[] bytes) { throw null; }
    }
    public sealed partial class NuGetV3ServiceIndexUrl
    {
        public NuGetV3ServiceIndexUrl(System.Uri v3ServiceIndexUrl) { }
        public System.Uri V3ServiceIndexUrl { get { throw null; } }
        public byte[] Encode() { throw null; }
        public static NuGet.Packaging.Signing.NuGetV3ServiceIndexUrl Read(byte[] bytes) { throw null; }
    }
    public static partial class Oids
    {
        public const string AnyPolicy = "2.5.29.32.0";
        public const string AuthorityKeyIdentifier = "2.5.29.35";
        public const string BaselineTimestampPolicy = "0.4.0.2023.1.1";
        public const string CodeSigningEku = "1.3.6.1.5.5.7.3.3";
        public const string CommitmentTypeIdentifierProofOfOrigin = "1.2.840.113549.1.9.16.6.1";
        public const string CommitmentTypeIdentifierProofOfReceipt = "1.2.840.113549.1.9.16.6.2";
        public const string CommitmentTypeIndication = "1.2.840.113549.1.9.16.2.16";
        public const string Countersignature = "1.2.840.113549.1.9.6";
        public const string EnhancedKeyUsage = "2.5.29.37";
        public const string IdQtCps = "1.3.6.1.5.5.7.2.1";
        public const string IdQtUnotice = "1.3.6.1.5.5.7.2.2";
        public const string LifetimeSigningEku = "1.3.6.1.4.1.311.10.3.13";
        public const string NuGetPackageOwners = "1.3.6.1.4.1.311.84.2.1.1.2";
        public const string NuGetV3ServiceIndexUrl = "1.3.6.1.4.1.311.84.2.1.1.1";
        public const string Pkcs7Data = "1.2.840.113549.1.7.1";
        public const string Sha1 = "1.3.14.3.2.26";
        public const string Sha256 = "2.16.840.1.101.3.4.2.1";
        public const string Sha256WithRSAEncryption = "1.2.840.113549.1.1.11";
        public const string Sha384 = "2.16.840.1.101.3.4.2.2";
        public const string Sha384WithRSAEncryption = "1.2.840.113549.1.1.12";
        public const string Sha512 = "2.16.840.1.101.3.4.2.3";
        public const string Sha512WithRSAEncryption = "1.2.840.113549.1.1.13";
        public const string SignatureTimeStampTokenAttribute = "1.2.840.113549.1.9.16.2.14";
        public const string SigningCertificate = "1.2.840.113549.1.9.16.2.12";
        public const string SigningCertificateV2 = "1.2.840.113549.1.9.16.2.47";
        public const string SigningTime = "1.2.840.113549.1.9.5";
        public const string SubjectKeyIdentifier = "2.5.29.14";
        public const string TimeStampingEku = "1.3.6.1.5.5.7.3.8";
        public const string TSTInfoContentType = "1.2.840.113549.1.9.16.1.4";
    }
    public partial class PackageSignatureVerifier : NuGet.Packaging.Signing.IPackageSignatureVerifier
    {
        public PackageSignatureVerifier(System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.ISignatureVerificationProvider> verificationProviders) { }
        public System.Threading.Tasks.Task<NuGet.Packaging.Signing.VerifySignaturesResult> VerifySignaturesAsync(NuGet.Packaging.Signing.ISignedPackageReader package, NuGet.Packaging.Signing.SignedPackageVerifierSettings settings, System.Threading.CancellationToken token, System.Guid parentId = default(System.Guid)) { throw null; }
    }
    public abstract partial class PackageVerificationResult
    {
        public PackageVerificationResult(NuGet.Packaging.Signing.SignatureVerificationStatus trust, System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.SignatureLog> issues) { }
        public virtual System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.SignatureLog> Issues { get { throw null; } }
        public virtual NuGet.Packaging.Signing.SignatureVerificationStatus Trust { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Common.ILogMessage> GetErrorIssues() { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Common.ILogMessage> GetWarningIssues() { throw null; }
    }
    public sealed partial class PolicyInformation
    {
        internal PolicyInformation() { }
        public System.Security.Cryptography.Oid PolicyIdentifier { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Signing.PolicyQualifierInfo> PolicyQualifiers { get { throw null; } }
        public static NuGet.Packaging.Signing.PolicyInformation Read(byte[] bytes) { throw null; }
    }
    public sealed partial class PolicyQualifierInfo
    {
        internal PolicyQualifierInfo() { }
        public System.Security.Cryptography.Oid PolicyQualifierId { get { throw null; } }
        public byte[] Qualifier { get { throw null; } }
        public static NuGet.Packaging.Signing.PolicyQualifierInfo Read(byte[] bytes) { throw null; }
    }
    public abstract partial class PrimarySignature : NuGet.Packaging.Signing.Signature
    {
        protected PrimarySignature() { }
        public byte[] GetBytes() { throw null; }
    }
    public static partial class PrimarySignatureFactory
    {
    }
    public sealed partial class ReadOnlyBufferedStream : System.IO.Stream
    {
        public ReadOnlyBufferedStream(System.IO.Stream stream, bool leaveOpen) { }
        public ReadOnlyBufferedStream(System.IO.Stream stream, bool leaveOpen, int bufferSize) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanTimeout { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override int ReadTimeout { get { throw null; } set { } }
        public override int WriteTimeout { get { throw null; } set { } }
        public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void WriteByte(byte value) { }
    }
    public sealed partial class RepositoryCountersignature : NuGet.Packaging.Signing.Signature, NuGet.Packaging.Signing.IRepositorySignature, NuGet.Packaging.Signing.ISignature
    {
        public RepositoryCountersignature() { }
        public static NuGet.Packaging.Signing.RepositoryCountersignature GetRepositoryCountersignature(NuGet.Packaging.Signing.PrimarySignature primarySignature) { throw null; }
    }
    public sealed partial class RepositoryPrimarySignature : NuGet.Packaging.Signing.PrimarySignature, NuGet.Packaging.Signing.IRepositorySignature, NuGet.Packaging.Signing.ISignature
    {
        public RepositoryPrimarySignature() { }
    }
    public static partial class RepositorySignatureInfoUtility
    {
        public static System.Collections.Generic.IReadOnlyCollection<NuGet.Packaging.Signing.CertificateHashAllowListEntry> GetRepositoryAllowList(System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.IRepositoryCertificateInfo> repositoryCertificateInfos) { throw null; }
        public static NuGet.Packaging.Signing.SignedPackageVerifierSettings GetSignedPackageVerifierSettings(NuGet.Packaging.RepositorySignatureInfo repoSignatureInfo, NuGet.Packaging.Signing.SignedPackageVerifierSettings fallbackSettings) { throw null; }
    }
    public sealed partial class RepositorySignPackageRequest : NuGet.Packaging.Signing.SignPackageRequest
    {
        public RepositorySignPackageRequest(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, NuGet.Common.HashAlgorithmName signatureHashAlgorithm, NuGet.Common.HashAlgorithmName timestampHashAlgorithm, System.Uri v3ServiceIndexUrl, System.Collections.Generic.IReadOnlyList<string> packageOwners) : base (default(System.Security.Cryptography.X509Certificates.X509Certificate2), default(NuGet.Common.HashAlgorithmName), default(NuGet.Common.HashAlgorithmName)) { }
        public System.Collections.Generic.IReadOnlyList<string> PackageOwners { get { throw null; } }
        public override NuGet.Packaging.Signing.SignatureType SignatureType { get { throw null; } }
        public System.Uri V3ServiceIndexUrl { get { throw null; } }
    }
    public partial class Rfc3161TimestampProvider : NuGet.Packaging.Signing.ITimestampProvider
    {
        public Rfc3161TimestampProvider(System.Uri timeStampServerUrl) { }
        public System.Threading.Tasks.Task<NuGet.Packaging.Signing.PrimarySignature> TimestampSignatureAsync(NuGet.Packaging.Signing.PrimarySignature primarySignature, NuGet.Packaging.Signing.TimestampRequest timestampRequest, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
    public sealed partial class Rfc3161TimestampTokenInfo : System.Security.Cryptography.AsnEncodedData
    {
        public Rfc3161TimestampTokenInfo() { }
    }
    public abstract partial class Signature : NuGet.Packaging.Signing.ISignature
    {
        protected Signature() { }
    }
    public sealed partial class SignatureContent
    {
        public SignatureContent(NuGet.Packaging.Signing.SigningSpecifications signingSpecifications, NuGet.Common.HashAlgorithmName hashAlgorithm, string hashValue) { }
        public NuGet.Common.HashAlgorithmName HashAlgorithm { get { throw null; } }
        public string HashValue { get { throw null; } }
        public byte[] GetBytes() { throw null; }
        public static NuGet.Packaging.Signing.SignatureContent Load(byte[] bytes, NuGet.Packaging.Signing.SigningSpecifications signingSpecifications) { throw null; }
    }
    public partial class SignatureException : NuGet.Packaging.Core.PackagingException
    {
        public SignatureException(NuGet.Common.NuGetLogCode code, string message) : base (default(string)) { }
        public SignatureException(NuGet.Common.NuGetLogCode code, string message, NuGet.Packaging.Core.PackageIdentity package) : base (default(string)) { }
        public SignatureException(NuGet.Common.NuGetLogCode code, string message, System.Exception innerException) : base (default(string)) { }
        public SignatureException(System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Signing.PackageVerificationResult> results, NuGet.Packaging.Core.PackageIdentity package) : base (default(string)) { }
        public SignatureException(string message) : base (default(string)) { }
        public NuGet.Common.NuGetLogCode Code { get { throw null; } }
        public NuGet.Packaging.Core.PackageIdentity PackageIdentity { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Signing.PackageVerificationResult> Results { get { throw null; } }
        public System.TimeSpan VerifyDuration { get { throw null; } set { } }
    }
    public partial class SignatureLog : NuGet.Common.ILogMessage, System.IEquatable<NuGet.Packaging.Signing.SignatureLog>
    {
        internal SignatureLog() { }
        public NuGet.Common.NuGetLogCode Code { get { throw null; } set { } }
        public NuGet.Common.LogLevel Level { get { throw null; } set { } }
        public string LibraryId { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public string ProjectPath { get { throw null; } set { } }
        public System.DateTimeOffset Time { get { throw null; } set { } }
        public NuGet.Common.WarningLevel WarningLevel { get { throw null; } set { } }
        public NuGet.Common.RestoreLogMessage AsRestoreLogMessage() { throw null; }
        public static NuGet.Packaging.Signing.SignatureLog DebugLog(string message) { throw null; }
        public static NuGet.Packaging.Signing.SignatureLog DetailedLog(string message) { throw null; }
        public bool Equals(NuGet.Packaging.Signing.SignatureLog other) { throw null; }
        public static NuGet.Packaging.Signing.SignatureLog Error(NuGet.Common.NuGetLogCode code, string message) { throw null; }
        public static NuGet.Packaging.Signing.SignatureLog InformationLog(string message) { throw null; }
        public static NuGet.Packaging.Signing.SignatureLog Issue(bool fatal, NuGet.Common.NuGetLogCode code, string message) { throw null; }
    }
    [System.FlagsAttribute]
    public enum SignaturePlacement
    {
        Any = 3,
        Countersignature = 2,
        PrimarySignature = 1,
    }
    public sealed partial class SignatureTrustAndValidityVerificationProvider : NuGet.Packaging.Signing.ISignatureVerificationProvider
    {
        public SignatureTrustAndValidityVerificationProvider(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, NuGet.Common.HashAlgorithmName>> allowUntrustedRootList = null) { }
        public System.Threading.Tasks.Task<NuGet.Packaging.Signing.PackageVerificationResult> GetTrustResultAsync(NuGet.Packaging.Signing.ISignedPackageReader package, NuGet.Packaging.Signing.PrimarySignature signature, NuGet.Packaging.Signing.SignedPackageVerifierSettings settings, System.Threading.CancellationToken token) { throw null; }
    }
    public enum SignatureType
    {
        Author = 1,
        Repository = 2,
        Unknown = 0,
    }
    public static partial class SignatureUtility
    {
    }
    public enum SignatureVerificationBehavior
    {
        Always = 3,
        IfExists = 1,
        IfExistsAndIsNecessary = 2,
        Never = 0,
    }
    public enum SignatureVerificationStatus
    {
        Disallowed = 2,
        Suspect = 1,
        Unknown = 0,
        Valid = 3,
    }
    [System.FlagsAttribute]
    public enum SignatureVerificationStatusFlags
    {
        CertificateExpired = 256,
        CertificatePublicKeyInvalid = 32,
        CertificateRevoked = 16384,
        CertificateValidityInTheFuture = 128,
        ChainBuildingFailure = 4096,
        GeneralizedTimeOutsideValidity = 65536,
        HashAlgorithmUnsupported = 512,
        HasLifetimeSigningEku = 64,
        Illegal = 1790,
        IntegrityCheckFailed = 2048,
        MessageImprintUnsupportedAlgorithm = 1024,
        MultipleSignatures = 4,
        MultipleTimestamps = 262144,
        NoCertificate = 2,
        NoErrors = 0,
        NoSignature = 1,
        NoValidTimestamp = 131072,
        SignatureAlgorithmUnsupported = 16,
        SignatureCheckFailed = 8,
        Suspect = 18432,
        UnknownRevocation = 8192,
        Untrusted = 110849,
        UntrustedRoot = 32768,
    }
    public sealed partial class SignatureVerificationSummary
    {
        public SignatureVerificationSummary(NuGet.Packaging.Signing.SignatureType signatureType, NuGet.Packaging.Signing.SignatureVerificationStatus status, NuGet.Packaging.Signing.SignatureVerificationStatusFlags flags, NuGet.Packaging.Signing.Timestamp timestamp, System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.SignatureLog> issues) { }
        public SignatureVerificationSummary(NuGet.Packaging.Signing.SignatureType signatureType, NuGet.Packaging.Signing.SignatureVerificationStatus status, NuGet.Packaging.Signing.SignatureVerificationStatusFlags flags, NuGet.Packaging.Signing.Timestamp timestamp, System.Nullable<System.DateTimeOffset> expirationTime, System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.SignatureLog> issues) { }
        public SignatureVerificationSummary(NuGet.Packaging.Signing.SignatureType signatureType, NuGet.Packaging.Signing.SignatureVerificationStatus status, NuGet.Packaging.Signing.SignatureVerificationStatusFlags flags, System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.SignatureLog> issues) { }
        public System.Nullable<System.DateTimeOffset> ExpirationTime { get { throw null; } }
        public NuGet.Packaging.Signing.SignatureVerificationStatusFlags Flags { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.SignatureLog> Issues { get { throw null; } set { } }
        public NuGet.Packaging.Signing.SignatureType SignatureType { get { throw null; } }
        public NuGet.Packaging.Signing.SignatureVerificationStatus Status { get { throw null; } }
        public NuGet.Packaging.Signing.Timestamp Timestamp { get { throw null; } }
    }
    public sealed partial class SignatureVerifySettings
    {
        public SignatureVerifySettings(bool allowIllegal, bool allowUntrusted, bool allowUnknownRevocation, bool reportUnknownRevocation, bool reportUntrustedRoot, NuGet.Common.RevocationMode revocationMode) { }
        public bool AllowIllegal { get { throw null; } }
        public bool AllowUnknownRevocation { get { throw null; } }
        public bool AllowUntrusted { get { throw null; } }
        public static NuGet.Packaging.Signing.SignatureVerifySettings Default { get { throw null; } }
        public bool ReportUnknownRevocation { get { throw null; } }
        public bool ReportUntrustedRoot { get { throw null; } }
        public NuGet.Common.RevocationMode RevocationMode { get { throw null; } }
    }
    public partial class SignedPackageArchive : NuGet.Packaging.PackageArchiveReader, NuGet.Packaging.Signing.ISignedPackage, NuGet.Packaging.Signing.ISignedPackageReader, NuGet.Packaging.Signing.ISignedPackageWriter, System.IDisposable
    {
        public SignedPackageArchive(System.IO.Stream packageReadStream, System.IO.Stream packageWriteStream) : base (default(System.IO.Stream)) { }
        public System.Threading.Tasks.Task AddSignatureAsync(System.IO.Stream signatureStream, System.Threading.CancellationToken token) { throw null; }
        protected override void Dispose(bool disposing) { }
        public System.Threading.Tasks.Task<bool> IsZip64Async(System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task RemoveSignatureAsync(System.Threading.CancellationToken token) { throw null; }
    }
    public static partial class SignedPackageArchiveIOUtility
    {
        public static void HashBytes(System.Security.Cryptography.HashAlgorithm hashAlgorithm, byte[] bytes) { }
        public static void ReadAndHashUntilPosition(System.IO.BinaryReader reader, System.Security.Cryptography.HashAlgorithm hashAlgorithm, long position) { }
        public static void ReadAndWriteUntilPosition(System.IO.BinaryReader reader, System.IO.BinaryWriter writer, long position) { }
        public static NuGet.Packaging.Signing.SignedPackageArchiveMetadata ReadSignedArchiveMetadata(System.IO.BinaryReader reader, bool validateSignatureEntry = true) { throw null; }
    }
    public sealed partial class SignedPackageArchiveMetadata
    {
        public SignedPackageArchiveMetadata() { }
        public System.Collections.Generic.List<NuGet.Packaging.Signing.CentralDirectoryHeaderMetadata> CentralDirectoryHeaders { get { throw null; } set { } }
        public long EndOfCentralDirectory { get { throw null; } set { } }
        public int SignatureCentralDirectoryHeaderIndex { get { throw null; } set { } }
        public long StartOfLocalFileHeaders { get { throw null; } set { } }
        public NuGet.Packaging.Signing.CentralDirectoryHeaderMetadata GetPackageSignatureFileCentralDirectoryHeaderMetadata() { throw null; }
    }
    public static partial class SignedPackageArchiveUtility
    {
        public static bool IsSigned(System.IO.BinaryReader reader) { throw null; }
        public static bool IsZip64(System.IO.BinaryReader reader) { throw null; }
        public static System.IO.Stream OpenPackageSignatureFileStream(System.IO.BinaryReader reader) { throw null; }
        public static System.Threading.Tasks.Task<bool> RemoveRepositorySignaturesAsync(System.IO.Stream input, System.IO.Stream output, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class SignedPackageVerificationResult : NuGet.Packaging.Signing.PackageVerificationResult
    {
        public SignedPackageVerificationResult(NuGet.Packaging.Signing.SignatureVerificationStatus trust, NuGet.Packaging.Signing.PrimarySignature signature, System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.SignatureLog> issues) : base (default(NuGet.Packaging.Signing.SignatureVerificationStatus), default(System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.SignatureLog>)) { }
        public NuGet.Packaging.Signing.PrimarySignature Signature { get { throw null; } }
    }
    public sealed partial class SignedPackageVerifierSettings
    {
        public SignedPackageVerifierSettings(bool allowUnsigned, bool allowIllegal, bool allowUntrusted, bool allowIgnoreTimestamp, bool allowMultipleTimestamps, bool allowNoTimestamp, bool allowUnknownRevocation, bool reportUnknownRevocation, NuGet.Packaging.Signing.VerificationTarget verificationTarget, NuGet.Packaging.Signing.SignaturePlacement signaturePlacement, NuGet.Packaging.Signing.SignatureVerificationBehavior repositoryCountersignatureVerificationBehavior, NuGet.Common.RevocationMode revocationMode) { }
        public bool AllowIgnoreTimestamp { get { throw null; } }
        public bool AllowIllegal { get { throw null; } }
        public bool AllowMultipleTimestamps { get { throw null; } }
        public bool AllowNoTimestamp { get { throw null; } }
        public bool AllowUnknownRevocation { get { throw null; } }
        public bool AllowUnsigned { get { throw null; } }
        public bool AllowUntrusted { get { throw null; } }
        public bool ReportUnknownRevocation { get { throw null; } }
        public NuGet.Packaging.Signing.SignatureVerificationBehavior RepositoryCountersignatureVerificationBehavior { get { throw null; } }
        public NuGet.Common.RevocationMode RevocationMode { get { throw null; } }
        public NuGet.Packaging.Signing.SignaturePlacement SignaturePlacement { get { throw null; } }
        public NuGet.Packaging.Signing.VerificationTarget VerificationTarget { get { throw null; } }
        public static NuGet.Packaging.Signing.SignedPackageVerifierSettings GetAcceptModeDefaultPolicy() { throw null; }
        public static NuGet.Packaging.Signing.SignedPackageVerifierSettings GetDefault() { throw null; }
        public static NuGet.Packaging.Signing.SignedPackageVerifierSettings GetRequireModeDefaultPolicy() { throw null; }
        public static NuGet.Packaging.Signing.SignedPackageVerifierSettings GetVerifyCommandDefaultPolicy() { throw null; }
    }
    public sealed partial class SigningCertificate
    {
        internal SigningCertificate() { }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Signing.EssCertId> Certificates { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Signing.PolicyInformation> Policies { get { throw null; } }
        public static NuGet.Packaging.Signing.SigningCertificate Read(byte[] bytes) { throw null; }
    }
    public sealed partial class SigningCertificateV2
    {
        internal SigningCertificateV2() { }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Signing.EssCertIdV2> Certificates { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Signing.PolicyInformation> Policies { get { throw null; } }
        public static NuGet.Packaging.Signing.SigningCertificateV2 Create(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, NuGet.Common.HashAlgorithmName hashAlgorithmName) { throw null; }
        public byte[] Encode() { throw null; }
        public static NuGet.Packaging.Signing.SigningCertificateV2 Read(byte[] bytes) { throw null; }
    }
    public sealed partial class SigningOptions : System.IDisposable
    {
        public SigningOptions(System.Lazy<System.IO.Stream> inputPackageStream, System.Lazy<System.IO.Stream> outputPackageStream, bool overwrite, NuGet.Packaging.Signing.ISignatureProvider signatureProvider, NuGet.Common.ILogger logger) { }
        public System.IO.Stream InputPackageStream { get { throw null; } }
        public NuGet.Common.ILogger Logger { get { throw null; } }
        public System.IO.Stream OutputPackageStream { get { throw null; } }
        public bool Overwrite { get { throw null; } }
        public NuGet.Packaging.Signing.ISignatureProvider SignatureProvider { get { throw null; } }
        public static NuGet.Packaging.Signing.SigningOptions CreateFromFilePaths(string inputPackageFilePath, string outputPackageFilePath, bool overwrite, NuGet.Packaging.Signing.ISignatureProvider signatureProvider, NuGet.Common.ILogger logger) { throw null; }
        public void Dispose() { }
    }
    public abstract partial class SigningSpecifications
    {
        public static readonly NuGet.Packaging.Signing.SigningSpecificationsV1 V1;
        protected SigningSpecifications() { }
        public abstract string[] AllowedHashAlgorithmOids { get; }
        public abstract NuGet.Common.HashAlgorithmName[] AllowedHashAlgorithms { get; }
        public abstract string[] AllowedSignatureAlgorithmOids { get; }
        public abstract NuGet.Common.SignatureAlgorithmName[] AllowedSignatureAlgorithms { get; }
        public abstract System.Text.Encoding Encoding { get; }
        public abstract int RSAPublicKeyMinLength { get; }
        public abstract string SignaturePath { get; }
        public abstract string Version { get; }
    }
    public sealed partial class SigningSpecificationsV1 : NuGet.Packaging.Signing.SigningSpecifications
    {
        public SigningSpecificationsV1() { }
        public override string[] AllowedHashAlgorithmOids { get { throw null; } }
        public override NuGet.Common.HashAlgorithmName[] AllowedHashAlgorithms { get { throw null; } }
        public override string[] AllowedSignatureAlgorithmOids { get { throw null; } }
        public override NuGet.Common.SignatureAlgorithmName[] AllowedSignatureAlgorithms { get { throw null; } }
        public override System.Text.Encoding Encoding { get { throw null; } }
        public override int RSAPublicKeyMinLength { get { throw null; } }
        public override string SignaturePath { get { throw null; } }
        public override string Version { get { throw null; } }
    }
    public static partial class SigningUtility
    {
        public static System.Threading.Tasks.Task SignAsync(NuGet.Packaging.Signing.SigningOptions options, NuGet.Packaging.Signing.SignPackageRequest signRequest, System.Threading.CancellationToken token) { throw null; }
        public static void Verify(NuGet.Packaging.Signing.SignPackageRequest request, NuGet.Common.ILogger logger) { }
    }
    public abstract partial class SignPackageRequest : System.IDisposable
    {
        protected SignPackageRequest(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, NuGet.Common.HashAlgorithmName signatureHashAlgorithm, NuGet.Common.HashAlgorithmName timestampHashAlgorithm) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection AdditionalCertificates { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { throw null; } }
        public NuGet.Common.HashAlgorithmName SignatureHashAlgorithm { get { throw null; } }
        public abstract NuGet.Packaging.Signing.SignatureType SignatureType { get; }
        public NuGet.Common.HashAlgorithmName TimestampHashAlgorithm { get { throw null; } }
        public void Dispose() { }
    }
    public sealed partial class Timestamp
    {
        public Timestamp() { }
    }
    public partial class TimestampException : NuGet.Packaging.Signing.SignatureException
    {
        public TimestampException() : base (default(NuGet.Common.NuGetLogCode), default(string)) { }
        public TimestampException(NuGet.Common.NuGetLogCode code, string message) : base (default(NuGet.Common.NuGetLogCode), default(string)) { }
        public TimestampException(NuGet.Common.NuGetLogCode code, string message, System.Exception innerException) : base (default(NuGet.Common.NuGetLogCode), default(string)) { }
        public TimestampException(string message) : base (default(NuGet.Common.NuGetLogCode), default(string)) { }
    }
    public partial class TimestampRequest
    {
        public TimestampRequest(NuGet.Packaging.Signing.SigningSpecifications signingSpecifications, byte[] hashedMessage, NuGet.Common.HashAlgorithmName hashAlgorithm, NuGet.Packaging.Signing.SignaturePlacement target) { }
        public NuGet.Common.HashAlgorithmName HashAlgorithm { get { throw null; } }
        public byte[] HashedMessage { get { throw null; } }
        public NuGet.Packaging.Signing.SigningSpecifications SigningSpecifications { get { throw null; } }
        public NuGet.Packaging.Signing.SignaturePlacement Target { get { throw null; } }
    }
    public sealed partial class TrustedSignerAllowListEntry : NuGet.Packaging.Signing.CertificateHashAllowListEntry
    {
        public TrustedSignerAllowListEntry(NuGet.Packaging.Signing.VerificationTarget target, NuGet.Packaging.Signing.SignaturePlacement placement, string fingerprint, NuGet.Common.HashAlgorithmName algorithm, bool allowUntrustedRoot = false, System.Collections.Generic.IReadOnlyList<string> owners = null) : base (default(NuGet.Packaging.Signing.VerificationTarget), default(NuGet.Packaging.Signing.SignaturePlacement), default(string), default(NuGet.Common.HashAlgorithmName)) { }
        public bool AllowUntrustedRoot { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Owners { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public sealed partial class TrustedSignersProvider : NuGet.Packaging.Signing.ITrustedSignersProvider
    {
        public TrustedSignersProvider(NuGet.Configuration.ISettings settings) { }
        public void AddOrUpdateTrustedSigner(NuGet.Configuration.TrustedSignerItem trustedSigner) { }
        public static System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Signing.TrustedSignerAllowListEntry> GetAllowListEntries(NuGet.Configuration.ISettings settings, NuGet.Common.ILogger logger) { throw null; }
        public System.Collections.Generic.IReadOnlyList<NuGet.Configuration.TrustedSignerItem> GetTrustedSigners() { throw null; }
        public void Remove(System.Collections.Generic.IReadOnlyList<NuGet.Configuration.TrustedSignerItem> trustedSigners) { }
    }
    public sealed partial class TstInfo
    {
        internal TstInfo() { }
        public NuGet.Packaging.Signing.Accuracy Accuracy { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509ExtensionCollection Extensions { get { throw null; } }
        public System.DateTimeOffset GenTime { get { throw null; } }
        public NuGet.Packaging.Signing.MessageImprint MessageImprint { get { throw null; } }
        public byte[] Nonce { get { throw null; } }
        public bool Ordering { get { throw null; } }
        public System.Security.Cryptography.Oid Policy { get { throw null; } }
        public byte[] SerialNumber { get { throw null; } }
        public byte[] Tsa { get { throw null; } }
        public int Version { get { throw null; } }
        public static NuGet.Packaging.Signing.TstInfo Read(byte[] bytes) { throw null; }
    }
    public sealed partial class UnknownPrimarySignature : NuGet.Packaging.Signing.PrimarySignature
    {
        public UnknownPrimarySignature() { }
    }
    public partial class UnsignedPackageVerificationResult : NuGet.Packaging.Signing.PackageVerificationResult
    {
        public UnsignedPackageVerificationResult(NuGet.Packaging.Signing.SignatureVerificationStatus trust, System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.SignatureLog> issues) : base (default(NuGet.Packaging.Signing.SignatureVerificationStatus), default(System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.SignatureLog>)) { }
    }
    public abstract partial class VerificationAllowListEntry
    {
        public VerificationAllowListEntry(NuGet.Packaging.Signing.VerificationTarget target, NuGet.Packaging.Signing.SignaturePlacement placement) { }
        public NuGet.Packaging.Signing.SignaturePlacement Placement { get { throw null; } }
        public NuGet.Packaging.Signing.VerificationTarget Target { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum VerificationTarget
    {
        All = 14,
        Author = 4,
        None = 0,
        Repository = 8,
        Unknown = 2,
    }
    public static partial class VerificationUtility
    {
        public static NuGet.Packaging.Signing.SignatureVerificationStatus GetSignatureVerificationStatus(NuGet.Packaging.Signing.SignatureVerificationStatusFlags flags) { throw null; }
        public static bool IsVerificationTarget(NuGet.Packaging.Signing.SignatureType signatureType, NuGet.Packaging.Signing.VerificationTarget target) { throw null; }
    }
    public sealed partial class VerifySignaturesResult
    {
        public VerifySignaturesResult(bool isValid, bool isSigned) { }
        public VerifySignaturesResult(bool isValid, bool isSigned, System.Collections.Generic.IEnumerable<NuGet.Packaging.Signing.PackageVerificationResult> results) { }
        public bool IsSigned { get { throw null; } }
        public bool IsValid { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Signing.PackageVerificationResult> Results { get { throw null; } }
    }
    public sealed partial class X509CertificateChain : System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Certificate2>, NuGet.Packaging.Signing.IX509CertificateChain, System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Certificate2>, System.Collections.Generic.IReadOnlyCollection<System.Security.Cryptography.X509Certificates.X509Certificate2>, System.Collections.Generic.IReadOnlyList<System.Security.Cryptography.X509Certificates.X509Certificate2>, System.Collections.IEnumerable, System.IDisposable
    {
        public X509CertificateChain() { }
        public void Dispose() { }
    }
    public sealed partial class X509ChainHolder : System.IDisposable
    {
        public X509ChainHolder() { }
        public System.Security.Cryptography.X509Certificates.X509Chain Chain { get { throw null; } }
        public void Dispose() { }
    }
    public partial class X509SignatureProvider : NuGet.Packaging.Signing.ISignatureProvider
    {
        public X509SignatureProvider(NuGet.Packaging.Signing.ITimestampProvider timestampProvider) { }
        public System.Threading.Tasks.Task<NuGet.Packaging.Signing.PrimarySignature> CreatePrimarySignatureAsync(NuGet.Packaging.Signing.SignPackageRequest request, NuGet.Packaging.Signing.SignatureContent signatureContent, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<NuGet.Packaging.Signing.PrimarySignature> CreateRepositoryCountersignatureAsync(NuGet.Packaging.Signing.RepositorySignPackageRequest request, NuGet.Packaging.Signing.PrimarySignature primarySignature, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
}
namespace NuGet.Packaging.Signing.DerEncoding
{
    public sealed partial class DerGeneralizedTime
    {
        internal DerGeneralizedTime() { }
        public System.DateTime DateTime { get { throw null; } }
        public static NuGet.Packaging.Signing.DerEncoding.DerGeneralizedTime Read(string decodedTime) { throw null; }
    }
}
namespace NuGet.RuntimeModel
{
    public partial class CompatibilityProfile : System.IEquatable<NuGet.RuntimeModel.CompatibilityProfile>
    {
        public CompatibilityProfile(string name) { }
        public CompatibilityProfile(string name, System.Collections.Generic.IEnumerable<NuGet.Frameworks.FrameworkRuntimePair> restoreContexts) { }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IList<NuGet.Frameworks.FrameworkRuntimePair> RestoreContexts { get { throw null; } }
        public NuGet.RuntimeModel.CompatibilityProfile Clone() { throw null; }
        public bool Equals(NuGet.RuntimeModel.CompatibilityProfile other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial interface IObjectWriter
    {
        void WriteArrayEnd();
        void WriteArrayStart(string name);
        void WriteNameArray(string name, System.Collections.Generic.IEnumerable<string> values);
        void WriteNameValue(string name, bool value);
        void WriteNameValue(string name, int value);
        void WriteNameValue(string name, string value);
        void WriteObjectEnd();
        void WriteObjectInArrayStart();
        void WriteObjectStart(string name);
    }
    public sealed partial class JsonObjectWriter : NuGet.RuntimeModel.IObjectWriter
    {
        public JsonObjectWriter() { }
        public Newtonsoft.Json.Linq.JObject GetJObject() { throw null; }
        public string GetJson() { throw null; }
        public void WriteArrayEnd() { }
        public void WriteArrayStart(string name) { }
        public void WriteNameArray(string name, System.Collections.Generic.IEnumerable<string> values) { }
        public void WriteNameValue(string name, bool value) { }
        public void WriteNameValue(string name, int value) { }
        public void WriteNameValue(string name, string value) { }
        public void WriteObjectEnd() { }
        public void WriteObjectInArrayStart() { }
        public void WriteObjectStart(string name) { }
        public void WriteTo(Newtonsoft.Json.JsonTextWriter writer) { }
    }
    public static partial class JsonRuntimeFormat
    {
        public static NuGet.RuntimeModel.RuntimeGraph ReadRuntimeGraph(Newtonsoft.Json.Linq.JToken json) { throw null; }
        public static NuGet.RuntimeModel.RuntimeGraph ReadRuntimeGraph(System.IO.Stream stream) { throw null; }
        public static NuGet.RuntimeModel.RuntimeGraph ReadRuntimeGraph(System.IO.TextReader textReader) { throw null; }
        public static NuGet.RuntimeModel.RuntimeGraph ReadRuntimeGraph(string filePath) { throw null; }
        public static void WriteRuntimeGraph(NuGet.RuntimeModel.IObjectWriter writer, NuGet.RuntimeModel.RuntimeGraph runtimeGraph) { }
        public static void WriteRuntimeGraph(string filePath, NuGet.RuntimeModel.RuntimeGraph runtimeGraph) { }
    }
    public partial class RuntimeDependencySet : System.IEquatable<NuGet.RuntimeModel.RuntimeDependencySet>
    {
        public RuntimeDependencySet(string id) { }
        public RuntimeDependencySet(string id, System.Collections.Generic.IEnumerable<NuGet.RuntimeModel.RuntimePackageDependency> dependencies) { }
        public System.Collections.Generic.IReadOnlyDictionary<string, NuGet.RuntimeModel.RuntimePackageDependency> Dependencies { get { throw null; } }
        public string Id { get { throw null; } }
        public NuGet.RuntimeModel.RuntimeDependencySet Clone() { throw null; }
        public bool Equals(NuGet.RuntimeModel.RuntimeDependencySet other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RuntimeDescription : System.IEquatable<NuGet.RuntimeModel.RuntimeDescription>
    {
        public RuntimeDescription(string runtimeIdentifier) { }
        public RuntimeDescription(string runtimeIdentifier, System.Collections.Generic.IEnumerable<NuGet.RuntimeModel.RuntimeDependencySet> runtimeDependencySets) { }
        public RuntimeDescription(string runtimeIdentifier, System.Collections.Generic.IEnumerable<string> inheritedRuntimes) { }
        public RuntimeDescription(string runtimeIdentifier, System.Collections.Generic.IEnumerable<string> inheritedRuntimes, System.Collections.Generic.IEnumerable<NuGet.RuntimeModel.RuntimeDependencySet> runtimeDependencySets) { }
        public System.Collections.Generic.IReadOnlyList<string> InheritedRuntimes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, NuGet.RuntimeModel.RuntimeDependencySet> RuntimeDependencySets { get { throw null; } }
        public string RuntimeIdentifier { get { throw null; } }
        public NuGet.RuntimeModel.RuntimeDescription Clone() { throw null; }
        public bool Equals(NuGet.RuntimeModel.RuntimeDescription other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static NuGet.RuntimeModel.RuntimeDescription Merge(NuGet.RuntimeModel.RuntimeDescription left, NuGet.RuntimeModel.RuntimeDescription right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RuntimeGraph : System.IEquatable<NuGet.RuntimeModel.RuntimeGraph>
    {
        public static readonly NuGet.RuntimeModel.RuntimeGraph Empty;
        public static readonly string RuntimeGraphFileName;
        public RuntimeGraph() { }
        public RuntimeGraph(System.Collections.Generic.IEnumerable<NuGet.RuntimeModel.CompatibilityProfile> supports) { }
        public RuntimeGraph(System.Collections.Generic.IEnumerable<NuGet.RuntimeModel.RuntimeDescription> runtimes) { }
        public RuntimeGraph(System.Collections.Generic.IEnumerable<NuGet.RuntimeModel.RuntimeDescription> runtimes, System.Collections.Generic.IEnumerable<NuGet.RuntimeModel.CompatibilityProfile> supports) { }
        public System.Collections.Generic.IReadOnlyDictionary<string, NuGet.RuntimeModel.RuntimeDescription> Runtimes { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, NuGet.RuntimeModel.CompatibilityProfile> Supports { get { throw null; } set { } }
        public bool AreCompatible(string criteria, string provided) { throw null; }
        public NuGet.RuntimeModel.RuntimeGraph Clone() { throw null; }
        public bool Equals(NuGet.RuntimeModel.RuntimeGraph other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public System.Collections.Generic.IEnumerable<string> ExpandRuntime(string runtime) { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.RuntimeModel.RuntimePackageDependency> FindRuntimeDependencies(string runtimeName, string packageId) { throw null; }
        public override int GetHashCode() { throw null; }
        public static NuGet.RuntimeModel.RuntimeGraph Merge(NuGet.RuntimeModel.RuntimeGraph left, NuGet.RuntimeModel.RuntimeGraph right) { throw null; }
    }
    public partial class RuntimePackageDependency : System.IEquatable<NuGet.RuntimeModel.RuntimePackageDependency>
    {
        public RuntimePackageDependency(string id, NuGet.Versioning.VersionRange versionRange) { }
        public string Id { get { throw null; } }
        public NuGet.Versioning.VersionRange VersionRange { get { throw null; } }
        public NuGet.RuntimeModel.RuntimePackageDependency Clone() { throw null; }
        public bool Equals(NuGet.RuntimeModel.RuntimePackageDependency other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
}
