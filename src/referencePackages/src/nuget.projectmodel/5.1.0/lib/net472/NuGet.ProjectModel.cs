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
[assembly: AssemblyTitle("NuGet.ProjectModel")]
[assembly: AssemblyDescription("NuGet.ProjectModel")]
[assembly: AssemblyDefaultAlias("NuGet.ProjectModel")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("5.1.0.6013")]
[assembly: AssemblyInformationalVersion("5.1.0.6013 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("5.1.0.5")]




namespace NuGet.ProjectModel
{
    public partial class AssetsLogMessage : NuGet.ProjectModel.IAssetsLogMessage, System.IEquatable<NuGet.ProjectModel.IAssetsLogMessage>
    {
        public AssetsLogMessage(NuGet.Common.LogLevel logLevel, NuGet.Common.NuGetLogCode errorCode, string errorString) { }
        public AssetsLogMessage(NuGet.Common.LogLevel logLevel, NuGet.Common.NuGetLogCode errorCode, string errorString, string targetGraph) { }
        public NuGet.Common.NuGetLogCode Code { get { throw null; } }
        public int EndColumnNumber { get { throw null; } set { } }
        public int EndLineNumber { get { throw null; } set { } }
        public string FilePath { get { throw null; } set { } }
        public NuGet.Common.LogLevel Level { get { throw null; } }
        public string LibraryId { get { throw null; } set { } }
        public string Message { get { throw null; } }
        public string ProjectPath { get { throw null; } set { } }
        public int StartColumnNumber { get { throw null; } set { } }
        public int StartLineNumber { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> TargetGraphs { get { throw null; } set { } }
        public NuGet.Common.WarningLevel WarningLevel { get { throw null; } set { } }
        public static NuGet.ProjectModel.IAssetsLogMessage Create(NuGet.Common.IRestoreLogMessage logMessage) { throw null; }
        public bool Equals(NuGet.ProjectModel.IAssetsLogMessage other) { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial struct BuildAction : System.IEquatable<NuGet.ProjectModel.BuildAction>
    {
        private object _dummy;
        private int _dummyPrimitive;
        public static NuGet.ProjectModel.BuildAction AndroidAsset;
        public static NuGet.ProjectModel.BuildAction AndroidResource;
        public static NuGet.ProjectModel.BuildAction ApplicationDefinition;
        public static NuGet.ProjectModel.BuildAction BundleResource;
        public static NuGet.ProjectModel.BuildAction CodeAnalysisDictionary;
        public static NuGet.ProjectModel.BuildAction Compile;
        public static NuGet.ProjectModel.BuildAction Content;
        public static NuGet.ProjectModel.BuildAction DesignData;
        public static NuGet.ProjectModel.BuildAction DesignDataWithDesignTimeCreatableTypes;
        public static NuGet.ProjectModel.BuildAction EmbeddedResource;
        public static NuGet.ProjectModel.BuildAction None;
        public static NuGet.ProjectModel.BuildAction Page;
        public static NuGet.ProjectModel.BuildAction Resource;
        public static NuGet.ProjectModel.BuildAction SplashScreen;
        public bool IsKnown { get { throw null; } }
        public string Value { get { throw null; } }
        public bool Equals(NuGet.ProjectModel.BuildAction other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(NuGet.ProjectModel.BuildAction left, NuGet.ProjectModel.BuildAction right) { throw null; }
        public static bool operator !=(NuGet.ProjectModel.BuildAction left, NuGet.ProjectModel.BuildAction right) { throw null; }
        public static NuGet.ProjectModel.BuildAction Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BuildOptions : System.IEquatable<NuGet.ProjectModel.BuildOptions>
    {
        public BuildOptions() { }
        public string OutputName { get { throw null; } set { } }
        public NuGet.ProjectModel.BuildOptions Clone() { throw null; }
        public bool Equals(NuGet.ProjectModel.BuildOptions other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class CacheFile : System.IEquatable<NuGet.ProjectModel.CacheFile>
    {
        public CacheFile(string dgSpecHash) { }
        public string DgSpecHash { get { throw null; } }
        public bool IsValid { get { throw null; } }
        public bool Success { get { throw null; } set { } }
        public int Version { get { throw null; } set { } }
        public bool Equals(NuGet.ProjectModel.CacheFile other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class CacheFileFormat
    {
        public CacheFileFormat() { }
        public static NuGet.ProjectModel.CacheFile Read(System.IO.Stream stream, NuGet.Common.ILogger log, string path) { throw null; }
        public static void Write(System.IO.Stream stream, NuGet.ProjectModel.CacheFile cacheFile) { }
        public static void Write(string filePath, NuGet.ProjectModel.CacheFile lockFile) { }
    }
    public partial class DependencyGraphSpec
    {
        public DependencyGraphSpec() { }
        public DependencyGraphSpec(Newtonsoft.Json.Linq.JObject json) { }
        public Newtonsoft.Json.Linq.JObject Json { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.ProjectModel.PackageSpec> Projects { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Restore { get { throw null; } }
        public void AddProject(NuGet.ProjectModel.PackageSpec projectSpec) { }
        public void AddRestore(string projectUniqueName) { }
        public System.Collections.Generic.IReadOnlyList<NuGet.ProjectModel.PackageSpec> GetClosure(string rootUniqueName) { throw null; }
        public static string GetDGSpecFileName(string projectName) { throw null; }
        public string GetHash() { throw null; }
        public System.Collections.Generic.IReadOnlyList<string> GetParents(string rootUniqueName) { throw null; }
        public NuGet.ProjectModel.PackageSpec GetProjectSpec(string projectUniqueName) { throw null; }
        public static NuGet.ProjectModel.DependencyGraphSpec Load(Newtonsoft.Json.Linq.JObject json) { throw null; }
        public static NuGet.ProjectModel.DependencyGraphSpec Load(string path) { throw null; }
        public void Save(string path) { }
        public static System.Collections.Generic.IReadOnlyList<NuGet.ProjectModel.PackageSpec> SortPackagesByDependencyOrder(System.Collections.Generic.IEnumerable<NuGet.ProjectModel.PackageSpec> packages) { throw null; }
        public static NuGet.ProjectModel.DependencyGraphSpec Union(System.Collections.Generic.IEnumerable<NuGet.ProjectModel.DependencyGraphSpec> dgSpecs) { throw null; }
        public NuGet.ProjectModel.DependencyGraphSpec WithoutRestores() { throw null; }
        public NuGet.ProjectModel.DependencyGraphSpec WithoutTools() { throw null; }
        public NuGet.ProjectModel.DependencyGraphSpec WithProjectClosure(string projectUniqueName) { throw null; }
        public NuGet.ProjectModel.DependencyGraphSpec WithReplacedSpec(NuGet.ProjectModel.PackageSpec project) { throw null; }
    }
    public partial class ExternalProjectReference : System.IComparable<NuGet.ProjectModel.ExternalProjectReference>, System.IEquatable<NuGet.ProjectModel.ExternalProjectReference>
    {
        public ExternalProjectReference(string uniqueName, NuGet.ProjectModel.PackageSpec packageSpec, string msbuildProjectPath, System.Collections.Generic.IEnumerable<string> projectReferences) { }
        public ExternalProjectReference(string uniqueName, string packageSpecProjectName, string packageSpecPath, string msbuildProjectPath, System.Collections.Generic.IEnumerable<string> projectReferences) { }
        public System.Collections.Generic.IReadOnlyList<string> ExternalProjectReferences { get { throw null; } }
        public string MSBuildProjectPath { get { throw null; } }
        public NuGet.ProjectModel.PackageSpec PackageSpec { get { throw null; } }
        public string PackageSpecProjectName { get { throw null; } }
        public string ProjectJsonPath { get { throw null; } }
        public string ProjectName { get { throw null; } }
        public string UniqueName { get { throw null; } }
        public int CompareTo(NuGet.ProjectModel.ExternalProjectReference other) { throw null; }
        public bool Equals(NuGet.ProjectModel.ExternalProjectReference other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FileFormatException : System.Exception
    {
        public FileFormatException(string message) { }
        public FileFormatException(string message, System.Exception innerException) { }
        public int Column { get { throw null; } }
        public int Line { get { throw null; } }
        public string Path { get { throw null; } }
        public static NuGet.ProjectModel.FileFormatException Create(System.Exception exception, Newtonsoft.Json.Linq.JToken value, string path) { throw null; }
        public static NuGet.ProjectModel.FileFormatException Create(string message, Newtonsoft.Json.Linq.JToken value, string path) { throw null; }
    }
    public sealed partial class HashObjectWriter : NuGet.RuntimeModel.IObjectWriter, System.IDisposable
    {
        public HashObjectWriter(NuGet.Packaging.IHashFunction hashFunc) { }
        public void Dispose() { }
        public string GetHash() { throw null; }
        public void WriteArrayEnd() { }
        public void WriteArrayStart(string name) { }
        public void WriteNameArray(string name, System.Collections.Generic.IEnumerable<string> values) { }
        public void WriteNameValue(string name, bool value) { }
        public void WriteNameValue(string name, int value) { }
        public void WriteNameValue(string name, string value) { }
        public void WriteObjectEnd() { }
        public void WriteObjectInArrayStart() { }
        public void WriteObjectStart(string name) { }
    }
    public partial interface IAssetsLogMessage
    {
        NuGet.Common.NuGetLogCode Code { get; }
        int EndColumnNumber { get; }
        int EndLineNumber { get; }
        string FilePath { get; }
        NuGet.Common.LogLevel Level { get; }
        string LibraryId { get; }
        string Message { get; }
        string ProjectPath { get; }
        int StartColumnNumber { get; }
        int StartLineNumber { get; }
        System.Collections.Generic.IReadOnlyList<string> TargetGraphs { get; }
        NuGet.Common.WarningLevel WarningLevel { get; }
    }
    public partial interface IExternalProjectReferenceProvider
    {
        System.Collections.Generic.IReadOnlyList<NuGet.ProjectModel.ExternalProjectReference> GetEntryPoints();
        System.Collections.Generic.IReadOnlyList<NuGet.ProjectModel.ExternalProjectReference> GetReferences(string entryPointPath);
    }
    public partial class IncludeExcludeFiles : System.IEquatable<NuGet.ProjectModel.IncludeExcludeFiles>
    {
        public IncludeExcludeFiles() { }
        public System.Collections.Generic.IReadOnlyList<string> Exclude { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> ExcludeFiles { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> Include { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> IncludeFiles { get { throw null; } set { } }
        public NuGet.ProjectModel.IncludeExcludeFiles Clone() { throw null; }
        public bool Equals(NuGet.ProjectModel.IncludeExcludeFiles other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public bool HandleIncludeExcludeFiles(Newtonsoft.Json.Linq.JObject jsonObject) { throw null; }
    }
    public partial class JsonPackageSpecReader
    {
        public static readonly string Files;
        public static readonly string HideWarningsAndErrors;
        public static readonly string PackageType;
        public static readonly string PackOptions;
        public static readonly string RestoreOptions;
        public static readonly string RestoreSettings;
        public JsonPackageSpecReader() { }
        public static NuGet.ProjectModel.PackageSpec GetPackageSpec(Newtonsoft.Json.Linq.JObject json) { throw null; }
        public static NuGet.ProjectModel.PackageSpec GetPackageSpec(Newtonsoft.Json.Linq.JObject rawPackageSpec, string name, string packageSpecPath, string snapshotValue) { throw null; }
        public static NuGet.ProjectModel.PackageSpec GetPackageSpec(System.IO.Stream stream, string name, string packageSpecPath, string snapshotValue) { throw null; }
        public static NuGet.ProjectModel.PackageSpec GetPackageSpec(string name, string packageSpecPath) { throw null; }
        public static NuGet.ProjectModel.PackageSpec GetPackageSpec(string json, string name, string packageSpecPath) { throw null; }
    }
    public static partial class JTokenExtensions
    {
        public static T GetValue<T>(this Newtonsoft.Json.Linq.JToken token, string name) { throw null; }
        public static T[] ValueAsArray<T>(this Newtonsoft.Json.Linq.JToken jToken) { throw null; }
        public static T[] ValueAsArray<T>(this Newtonsoft.Json.Linq.JToken jToken, string name) { throw null; }
    }
    public partial class LockFile : System.IEquatable<NuGet.ProjectModel.LockFile>
    {
        public static readonly char DirectorySeparatorChar;
        public static readonly NuGet.Frameworks.NuGetFramework ToolFramework;
        public LockFile() { }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileLibrary> Libraries { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.IAssetsLogMessage> LogMessages { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileItem> PackageFolders { get { throw null; } set { } }
        public NuGet.ProjectModel.PackageSpec PackageSpec { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.ProjectFileDependencyGroup> ProjectFileDependencyGroups { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileTarget> Targets { get { throw null; } set { } }
        public int Version { get { throw null; } set { } }
        public bool Equals(NuGet.ProjectModel.LockFile other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public NuGet.ProjectModel.LockFileLibrary GetLibrary(string name, NuGet.Versioning.NuGetVersion version) { throw null; }
        public NuGet.ProjectModel.LockFileTarget GetTarget(NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier) { throw null; }
        public bool IsValidForPackageSpec(NuGet.ProjectModel.PackageSpec spec) { throw null; }
        public bool IsValidForPackageSpec(NuGet.ProjectModel.PackageSpec spec, int requestLockFileVersion) { throw null; }
    }
    public partial class LockFileContentFile : NuGet.ProjectModel.LockFileItem
    {
        public static readonly string BuildActionProperty;
        public static readonly string CodeLanguageProperty;
        public static readonly string CopyToOutputProperty;
        public static readonly string OutputPathProperty;
        public static readonly string PPOutputPathProperty;
        public LockFileContentFile(string path) : base (default(string)) { }
        public NuGet.ProjectModel.BuildAction BuildAction { get { throw null; } set { } }
        public string CodeLanguage { get { throw null; } set { } }
        public bool CopyToOutput { get { throw null; } set { } }
        public string OutputPath { get { throw null; } set { } }
        public string PPOutputPath { get { throw null; } set { } }
    }
    public partial class LockFileDependency : System.IEquatable<NuGet.ProjectModel.LockFileDependency>
    {
        public LockFileDependency() { }
        public string ContentHash { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.Packaging.Core.PackageDependency> Dependencies { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public NuGet.Versioning.VersionRange RequestedVersion { get { throw null; } set { } }
        public NuGet.Versioning.NuGetVersion ResolvedVersion { get { throw null; } set { } }
        public NuGet.ProjectModel.PackageDependencyType Type { get { throw null; } set { } }
        public bool Equals(NuGet.ProjectModel.LockFileDependency other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class LockFileDependencyIdVersionComparer : System.Collections.Generic.IEqualityComparer<NuGet.ProjectModel.LockFileDependency>
    {
        public LockFileDependencyIdVersionComparer() { }
        public bool Equals(NuGet.ProjectModel.LockFileDependency x, NuGet.ProjectModel.LockFileDependency y) { throw null; }
        public int GetHashCode(NuGet.ProjectModel.LockFileDependency obj) { throw null; }
    }
    public partial class LockFileDependencyProvider : NuGet.DependencyResolver.IDependencyProvider
    {
        public LockFileDependencyProvider(NuGet.ProjectModel.LockFile lockFile) { }
        public NuGet.LibraryModel.Library GetLibrary(NuGet.LibraryModel.LibraryRange libraryRange, NuGet.Frameworks.NuGetFramework targetFramework) { throw null; }
        public bool SupportsType(NuGet.LibraryModel.LibraryDependencyTarget libraryType) { throw null; }
    }
    public static partial class LockFileExtensions
    {
        public static System.Collections.Generic.IEnumerable<NuGet.ProjectModel.LockFileTarget> GetTargetGraphs(this NuGet.ProjectModel.IAssetsLogMessage message, NuGet.ProjectModel.LockFile assetsFile) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.ProjectModel.LockFileTargetLibrary> GetTargetLibraries(this NuGet.ProjectModel.IAssetsLogMessage message, NuGet.ProjectModel.LockFile assetsFile) { throw null; }
        public static NuGet.ProjectModel.LockFileTargetLibrary GetTargetLibrary(this NuGet.ProjectModel.LockFileTarget target, string libraryId) { throw null; }
    }
    public partial class LockFileFormat
    {
        public static readonly string AssetsFileName;
        public static readonly string LockFileName;
        public static readonly int Version;
        public LockFileFormat() { }
        public NuGet.ProjectModel.LockFile Parse(string lockFileContent, NuGet.Common.ILogger log, string path) { throw null; }
        public NuGet.ProjectModel.LockFile Parse(string lockFileContent, string path) { throw null; }
        public NuGet.ProjectModel.LockFile Read(System.IO.Stream stream, NuGet.Common.ILogger log, string path) { throw null; }
        public NuGet.ProjectModel.LockFile Read(System.IO.Stream stream, string path) { throw null; }
        public NuGet.ProjectModel.LockFile Read(System.IO.TextReader reader, NuGet.Common.ILogger log, string path) { throw null; }
        public NuGet.ProjectModel.LockFile Read(System.IO.TextReader reader, string path) { throw null; }
        public NuGet.ProjectModel.LockFile Read(string filePath) { throw null; }
        public NuGet.ProjectModel.LockFile Read(string filePath, NuGet.Common.ILogger log) { throw null; }
        public string Render(NuGet.ProjectModel.LockFile lockFile) { throw null; }
        public void Write(System.IO.Stream stream, NuGet.ProjectModel.LockFile lockFile) { }
        public void Write(System.IO.TextWriter textWriter, NuGet.ProjectModel.LockFile lockFile) { }
        public void Write(string filePath, NuGet.ProjectModel.LockFile lockFile) { }
    }
    public partial class LockFileItem : System.IEquatable<NuGet.ProjectModel.LockFileItem>
    {
        public LockFileItem(string path) { }
        public string Path { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }
        public bool Equals(NuGet.ProjectModel.LockFileItem other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        protected string GetProperty(string name) { throw null; }
        public static implicit operator NuGet.ProjectModel.LockFileItem (string path) { throw null; }
        protected void SetProperty(string name, string value) { }
        public override string ToString() { throw null; }
    }
    public partial class LockFileLibrary : System.IEquatable<NuGet.ProjectModel.LockFileLibrary>
    {
        public LockFileLibrary() { }
        public System.Collections.Generic.IList<string> Files { get { throw null; } set { } }
        public bool HasTools { get { throw null; } set { } }
        public bool IsServiceable { get { throw null; } set { } }
        public string MSBuildProject { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public string Sha512 { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        public NuGet.Versioning.NuGetVersion Version { get { throw null; } set { } }
        public NuGet.ProjectModel.LockFileLibrary Clone() { throw null; }
        public bool Equals(NuGet.ProjectModel.LockFileLibrary other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class LockFileRuntimeTarget : NuGet.ProjectModel.LockFileItem
    {
        public static readonly string AssetTypeProperty;
        public static readonly string RidProperty;
        public LockFileRuntimeTarget(string path) : base (default(string)) { }
        public LockFileRuntimeTarget(string path, string runtime, string assetType) : base (default(string)) { }
        public string AssetType { get { throw null; } set { } }
        public string Runtime { get { throw null; } set { } }
    }
    public partial class LockFileTarget : System.IEquatable<NuGet.ProjectModel.LockFileTarget>
    {
        public LockFileTarget() { }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileTargetLibrary> Libraries { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public string RuntimeIdentifier { get { throw null; } set { } }
        public NuGet.Frameworks.NuGetFramework TargetFramework { get { throw null; } set { } }
        public bool Equals(NuGet.ProjectModel.LockFileTarget other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class LockFileTargetLibrary : System.IEquatable<NuGet.ProjectModel.LockFileTargetLibrary>
    {
        public LockFileTargetLibrary() { }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileItem> Build { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileItem> BuildMultiTargeting { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileItem> CompileTimeAssemblies { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileContentFile> ContentFiles { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.Packaging.Core.PackageDependency> Dependencies { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileItem> EmbedAssemblies { get { throw null; } set { } }
        public string Framework { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> FrameworkAssemblies { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> FrameworkReferences { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileItem> NativeLibraries { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.Packaging.Core.PackageType> PackageType { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileItem> ResourceAssemblies { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileItem> RuntimeAssemblies { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileRuntimeTarget> RuntimeTargets { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileItem> ToolsAssemblies { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        public NuGet.Versioning.NuGetVersion Version { get { throw null; } set { } }
        public bool Equals(NuGet.ProjectModel.LockFileTargetLibrary other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public static partial class LockFileUtilities
    {
        public static NuGet.ProjectModel.LockFile GetLockFile(string lockFilePath, NuGet.Common.ILogger logger) { throw null; }
    }
    public enum PackageDependencyType
    {
        Direct = 0,
        Project = 2,
        Transitive = 1,
    }
    public partial class PackagesLockFile : System.IEquatable<NuGet.ProjectModel.PackagesLockFile>
    {
        public PackagesLockFile() { }
        public string Path { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.PackagesLockFileTarget> Targets { get { throw null; } set { } }
        public int Version { get { throw null; } set { } }
        public bool Equals(NuGet.ProjectModel.PackagesLockFile other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class PackagesLockFileFormat
    {
        public static readonly string LockFileName;
        public static readonly int Version;
        public PackagesLockFileFormat() { }
        public static NuGet.ProjectModel.PackagesLockFile Parse(string lockFileContent, NuGet.Common.ILogger log, string path) { throw null; }
        public static NuGet.ProjectModel.PackagesLockFile Parse(string lockFileContent, string path) { throw null; }
        public static NuGet.ProjectModel.PackagesLockFile Read(System.IO.Stream stream, NuGet.Common.ILogger log, string path) { throw null; }
        public static NuGet.ProjectModel.PackagesLockFile Read(System.IO.TextReader reader, NuGet.Common.ILogger log, string path) { throw null; }
        public static NuGet.ProjectModel.PackagesLockFile Read(string filePath) { throw null; }
        public static NuGet.ProjectModel.PackagesLockFile Read(string filePath, NuGet.Common.ILogger log) { throw null; }
        public static string Render(NuGet.ProjectModel.PackagesLockFile lockFile) { throw null; }
        public static void Write(System.IO.Stream stream, NuGet.ProjectModel.PackagesLockFile lockFile) { }
        public static void Write(System.IO.TextWriter textWriter, NuGet.ProjectModel.PackagesLockFile lockFile) { }
        public static void Write(string filePath, NuGet.ProjectModel.PackagesLockFile lockFile) { }
    }
    public partial class PackagesLockFileTarget : System.IEquatable<NuGet.ProjectModel.PackagesLockFileTarget>
    {
        public PackagesLockFileTarget() { }
        public System.Collections.Generic.IList<NuGet.ProjectModel.LockFileDependency> Dependencies { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public string RuntimeIdentifier { get { throw null; } set { } }
        public NuGet.Frameworks.NuGetFramework TargetFramework { get { throw null; } set { } }
        public bool Equals(NuGet.ProjectModel.PackagesLockFileTarget other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public static partial class PackagesLockFileUtilities
    {
        public static string GetNuGetLockFilePath(NuGet.ProjectModel.PackageSpec project) { throw null; }
        public static bool IsLockFileStillValid(NuGet.ProjectModel.DependencyGraphSpec dgSpec, NuGet.ProjectModel.PackagesLockFile nuGetLockFile) { throw null; }
        public static bool IsNuGetLockFileEnabled(NuGet.ProjectModel.PackageSpec project) { throw null; }
    }
    public partial class PackageSpec
    {
        public static readonly NuGet.Versioning.NuGetVersion DefaultVersion;
        public static readonly string PackageSpecFileName;
        public PackageSpec() { }
        public PackageSpec(System.Collections.Generic.IList<NuGet.ProjectModel.TargetFrameworkInformation> frameworks) { }
        public string[] Authors { get { throw null; } set { } }
        public string BaseDirectory { get { throw null; } }
        public NuGet.ProjectModel.BuildOptions BuildOptions { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ContentFiles { get { throw null; } set { } }
        public string Copyright { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.LibraryModel.LibraryDependency> Dependencies { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string FilePath { get { throw null; } set { } }
        public bool HasVersionSnapshot { get { throw null; } set { } }
        public string IconUrl { get { throw null; } set { } }
        public bool IsDefaultVersion { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public string LicenseUrl { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string[] Owners { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> PackInclude { get { throw null; } }
        public NuGet.ProjectModel.PackOptions PackOptions { get { throw null; } set { } }
        public string ProjectUrl { get { throw null; } set { } }
        public string ReleaseNotes { get { throw null; } set { } }
        public bool RequireLicenseAcceptance { get { throw null; } set { } }
        public NuGet.ProjectModel.ProjectRestoreMetadata RestoreMetadata { get { throw null; } set { } }
        public NuGet.ProjectModel.ProjectRestoreSettings RestoreSettings { get { throw null; } set { } }
        public NuGet.RuntimeModel.RuntimeGraph RuntimeGraph { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IEnumerable<string>> Scripts { get { throw null; } }
        public string Summary { get { throw null; } set { } }
        public string[] Tags { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.TargetFrameworkInformation> TargetFrameworks { get { throw null; } }
        public string Title { get { throw null; } set { } }
        public NuGet.Versioning.NuGetVersion Version { get { throw null; } set { } }
        public NuGet.ProjectModel.PackageSpec Clone() { throw null; }
        public bool Equals(NuGet.ProjectModel.PackageSpec other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public static partial class PackageSpecExtensions
    {
        public static NuGet.ProjectModel.ProjectRestoreMetadataFrameworkInfo GetRestoreMetadataFramework(this NuGet.ProjectModel.PackageSpec project, NuGet.Frameworks.NuGetFramework targetFramework) { throw null; }
        public static NuGet.ProjectModel.TargetFrameworkInformation GetTargetFramework(this NuGet.ProjectModel.PackageSpec project, NuGet.Frameworks.NuGetFramework targetFramework) { throw null; }
    }
    public static partial class PackageSpecOperations
    {
        public static void AddOrUpdateDependency(NuGet.ProjectModel.PackageSpec spec, NuGet.Packaging.Core.PackageDependency dependency) { }
        public static void AddOrUpdateDependency(NuGet.ProjectModel.PackageSpec spec, NuGet.Packaging.Core.PackageDependency dependency, System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworksToAdd) { }
        public static void AddOrUpdateDependency(NuGet.ProjectModel.PackageSpec spec, NuGet.Packaging.Core.PackageIdentity identity) { }
        public static void AddOrUpdateDependency(NuGet.ProjectModel.PackageSpec spec, NuGet.Packaging.Core.PackageIdentity identity, System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworksToAdd) { }
        public static bool HasPackage(NuGet.ProjectModel.PackageSpec spec, string packageId) { throw null; }
        public static void RemoveDependency(NuGet.ProjectModel.PackageSpec spec, string packageId) { }
    }
    public partial class PackageSpecReferenceDependencyProvider : NuGet.DependencyResolver.IDependencyProvider
    {
        public PackageSpecReferenceDependencyProvider(System.Collections.Generic.IEnumerable<NuGet.ProjectModel.ExternalProjectReference> externalProjects, NuGet.Common.ILogger logger) { }
        public NuGet.LibraryModel.Library GetLibrary(NuGet.LibraryModel.LibraryRange libraryRange, NuGet.Frameworks.NuGetFramework targetFramework) { throw null; }
        public bool SupportsType(NuGet.LibraryModel.LibraryDependencyTarget libraryType) { throw null; }
    }
    public static partial class PackageSpecUtility
    {
        public static bool IsSnapshotVersion(string version) { throw null; }
        public static NuGet.Versioning.NuGetVersion SpecifySnapshot(string version, string snapshotValue) { throw null; }
    }
    public sealed partial class PackageSpecWriter
    {
        public PackageSpecWriter() { }
        public static void Write(NuGet.ProjectModel.PackageSpec packageSpec, NuGet.RuntimeModel.IObjectWriter writer) { }
        public static void WriteToFile(NuGet.ProjectModel.PackageSpec packageSpec, string filePath) { }
    }
    public partial class PackOptions : System.IEquatable<NuGet.ProjectModel.PackOptions>
    {
        public PackOptions() { }
        public NuGet.ProjectModel.IncludeExcludeFiles IncludeExcludeFiles { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, NuGet.ProjectModel.IncludeExcludeFiles> Mappings { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Core.PackageType> PackageType { get { throw null; } set { } }
        public NuGet.ProjectModel.PackOptions Clone() { throw null; }
        public bool Equals(NuGet.ProjectModel.PackOptions other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class ProjectFileDependencyGroup : System.IEquatable<NuGet.ProjectModel.ProjectFileDependencyGroup>
    {
        public ProjectFileDependencyGroup(string frameworkName, System.Collections.Generic.IEnumerable<string> dependencies) { }
        public System.Collections.Generic.IEnumerable<string> Dependencies { get { throw null; } }
        public string FrameworkName { get { throw null; } }
        public bool Equals(NuGet.ProjectModel.ProjectFileDependencyGroup other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class ProjectRestoreMetadata : System.IEquatable<NuGet.ProjectModel.ProjectRestoreMetadata>
    {
        public ProjectRestoreMetadata() { }
        public string CacheFilePath { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ConfigFilePaths { get { throw null; } set { } }
        public bool CrossTargeting { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> FallbackFolders { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.ProjectRestoreMetadataFile> Files { get { throw null; } set { } }
        public bool LegacyPackagesDirectory { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> OriginalTargetFrameworks { get { throw null; } set { } }
        public string OutputPath { get { throw null; } set { } }
        public string PackagesPath { get { throw null; } set { } }
        public string ProjectJsonPath { get { throw null; } set { } }
        public string ProjectName { get { throw null; } set { } }
        public string ProjectPath { get { throw null; } set { } }
        public NuGet.ProjectModel.ProjectStyle ProjectStyle { get { throw null; } set { } }
        public string ProjectUniqueName { get { throw null; } set { } }
        public NuGet.ProjectModel.WarningProperties ProjectWideWarningProperties { get { throw null; } set { } }
        public NuGet.ProjectModel.RestoreLockProperties RestoreLockProperties { get { throw null; } set { } }
        public bool SkipContentFileWrite { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.Configuration.PackageSource> Sources { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.ProjectRestoreMetadataFrameworkInfo> TargetFrameworks { get { throw null; } set { } }
        public bool ValidateRuntimeAssets { get { throw null; } set { } }
        public NuGet.ProjectModel.ProjectRestoreMetadata Clone() { throw null; }
        public bool Equals(NuGet.ProjectModel.ProjectRestoreMetadata other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class ProjectRestoreMetadataFile : System.IComparable<NuGet.ProjectModel.ProjectRestoreMetadataFile>, System.IEquatable<NuGet.ProjectModel.ProjectRestoreMetadataFile>
    {
        public ProjectRestoreMetadataFile(string packagePath, string absolutePath) { }
        public string AbsolutePath { get { throw null; } }
        public string PackagePath { get { throw null; } }
        public NuGet.ProjectModel.ProjectRestoreMetadataFile Clone() { throw null; }
        public int CompareTo(NuGet.ProjectModel.ProjectRestoreMetadataFile other) { throw null; }
        public bool Equals(NuGet.ProjectModel.ProjectRestoreMetadataFile other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ProjectRestoreMetadataFrameworkInfo : System.IEquatable<NuGet.ProjectModel.ProjectRestoreMetadataFrameworkInfo>
    {
        public ProjectRestoreMetadataFrameworkInfo() { }
        public ProjectRestoreMetadataFrameworkInfo(NuGet.Frameworks.NuGetFramework frameworkName) { }
        public NuGet.Frameworks.NuGetFramework FrameworkName { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.ProjectRestoreReference> ProjectReferences { get { throw null; } set { } }
        public NuGet.ProjectModel.ProjectRestoreMetadataFrameworkInfo Clone() { throw null; }
        public bool Equals(NuGet.ProjectModel.ProjectRestoreMetadataFrameworkInfo other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ProjectRestoreReference : System.IEquatable<NuGet.ProjectModel.ProjectRestoreReference>
    {
        public ProjectRestoreReference() { }
        public NuGet.LibraryModel.LibraryIncludeFlags ExcludeAssets { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryIncludeFlags IncludeAssets { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryIncludeFlags PrivateAssets { get { throw null; } set { } }
        public string ProjectPath { get { throw null; } set { } }
        public string ProjectUniqueName { get { throw null; } set { } }
        public NuGet.ProjectModel.ProjectRestoreReference Clone() { throw null; }
        public bool Equals(NuGet.ProjectModel.ProjectRestoreReference other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ProjectRestoreSettings
    {
        public ProjectRestoreSettings() { }
        public bool HideWarningsAndErrors { get { throw null; } set { } }
        public NuGet.ProjectModel.ProjectRestoreSettings Clone() { throw null; }
        public bool Equals(NuGet.ProjectModel.ProjectRestoreSettings other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public enum ProjectStyle : ushort
    {
        DotnetCliTool = (ushort)3,
        DotnetToolReference = (ushort)6,
        PackageReference = (ushort)2,
        PackagesConfig = (ushort)5,
        ProjectJson = (ushort)1,
        Standalone = (ushort)4,
        Unknown = (ushort)0,
    }
    public partial class RestoreLockProperties : System.IEquatable<NuGet.ProjectModel.RestoreLockProperties>
    {
        public RestoreLockProperties() { }
        public RestoreLockProperties(string restorePackagesWithLockFile, string nuGetLockFilePath, bool restoreLockedMode) { }
        public string NuGetLockFilePath { get { throw null; } }
        public bool RestoreLockedMode { get { throw null; } }
        public string RestorePackagesWithLockFile { get { throw null; } }
        public NuGet.ProjectModel.RestoreLockProperties Clone() { throw null; }
        public bool Equals(NuGet.ProjectModel.RestoreLockProperties other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class TargetFrameworkInformation : System.IEquatable<NuGet.ProjectModel.TargetFrameworkInformation>
    {
        public TargetFrameworkInformation() { }
        public bool AssetTargetFallback { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.LibraryModel.LibraryDependency> Dependencies { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.LibraryModel.DownloadDependency> DownloadDependencies { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework FrameworkName { get { throw null; } set { } }
        public System.Collections.Generic.ISet<string> FrameworkReferences { get { throw null; } }
        public System.Collections.Generic.IList<NuGet.Frameworks.NuGetFramework> Imports { get { throw null; } set { } }
        public bool Warn { get { throw null; } set { } }
        public NuGet.ProjectModel.TargetFrameworkInformation Clone() { throw null; }
        public bool Equals(NuGet.ProjectModel.TargetFrameworkInformation other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ToolPathResolver
    {
        public ToolPathResolver(string packagesDirectory) { }
        public ToolPathResolver(string packagesDirectory, bool isLowercase) { }
        public string GetBestToolDirectoryPath(string packageId, NuGet.Versioning.VersionRange versionRange, NuGet.Frameworks.NuGetFramework framework) { throw null; }
        public string GetLockFilePath(string toolDirectory) { throw null; }
        public string GetLockFilePath(string packageId, NuGet.Versioning.NuGetVersion version, NuGet.Frameworks.NuGetFramework framework) { throw null; }
        public string GetToolDirectoryPath(string packageId, NuGet.Versioning.NuGetVersion version, NuGet.Frameworks.NuGetFramework framework) { throw null; }
    }
    public partial class WarningProperties : System.IEquatable<NuGet.ProjectModel.WarningProperties>
    {
        public WarningProperties() { }
        public WarningProperties(System.Collections.Generic.ISet<NuGet.Common.NuGetLogCode> warningsAsErrors, System.Collections.Generic.ISet<NuGet.Common.NuGetLogCode> noWarn, bool allWarningsAsErrors) { }
        public bool AllWarningsAsErrors { get { throw null; } set { } }
        public System.Collections.Generic.ISet<NuGet.Common.NuGetLogCode> NoWarn { get { throw null; } }
        public System.Collections.Generic.ISet<NuGet.Common.NuGetLogCode> WarningsAsErrors { get { throw null; } }
        public NuGet.ProjectModel.WarningProperties Clone() { throw null; }
        public bool Equals(NuGet.ProjectModel.WarningProperties other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static NuGet.ProjectModel.WarningProperties GetWarningProperties(string treatWarningsAsErrors, System.Collections.Generic.IEnumerable<NuGet.Common.NuGetLogCode> warningsAsErrors, System.Collections.Generic.IEnumerable<NuGet.Common.NuGetLogCode> noWarn) { throw null; }
        public static NuGet.ProjectModel.WarningProperties GetWarningProperties(string treatWarningsAsErrors, string warningsAsErrors, string noWarn) { throw null; }
    }
}
