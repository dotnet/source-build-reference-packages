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
[assembly: AssemblyTitle("NuGet.Commands")]
[assembly: AssemblyDescription("NuGet.Commands")]
[assembly: AssemblyDefaultAlias("NuGet.Commands")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("5.1.0.6013")]
[assembly: AssemblyInformationalVersion("5.1.0.6013 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("5.1.0.5")]




namespace Microsoft.AspNet.FileProviders
{
    public partial interface IDirectoryContents : System.Collections.Generic.IEnumerable<Microsoft.AspNet.FileProviders.IFileInfo>, System.Collections.IEnumerable
    {
        bool Exists { get; }
    }
    public partial interface IFileInfo
    {
        bool Exists { get; }
        bool IsDirectory { get; }
        System.DateTimeOffset LastModified { get; }
        long Length { get; }
        string Name { get; }
        string PhysicalPath { get; }
        System.IO.Stream CreateReadStream();
    }
    public partial interface IFileProvider
    {
        Microsoft.AspNet.FileProviders.IDirectoryContents GetDirectoryContents(string subpath);
        Microsoft.AspNet.FileProviders.IFileInfo GetFileInfo(string subpath);
        Microsoft.Extensions.Primitives.IChangeToken Watch(string filter);
    }
}
namespace Microsoft.Extensions.FileSystemGlobbing
{
    public partial struct FilePatternMatch : System.IEquatable<Microsoft.Extensions.FileSystemGlobbing.FilePatternMatch>
    {
        private object _dummy;
        public FilePatternMatch(string path, string stem) { throw null; }
        public string Path { get { throw null; } }
        public string Stem { get { throw null; } }
        public bool Equals(Microsoft.Extensions.FileSystemGlobbing.FilePatternMatch other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class Matcher
    {
        public Matcher() { }
        public Matcher(System.StringComparison comparisonType) { }
        public virtual Microsoft.Extensions.FileSystemGlobbing.Matcher AddExclude(string pattern) { throw null; }
        public virtual Microsoft.Extensions.FileSystemGlobbing.Matcher AddInclude(string pattern) { throw null; }
        public virtual Microsoft.Extensions.FileSystemGlobbing.PatternMatchingResult Execute(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directoryInfo) { throw null; }
    }
    public static partial class MatcherExtensions
    {
        public static void AddExcludePatterns(this Microsoft.Extensions.FileSystemGlobbing.Matcher matcher, params System.Collections.Generic.IEnumerable<string>[] excludePatternsGroups) { }
        public static void AddIncludePatterns(this Microsoft.Extensions.FileSystemGlobbing.Matcher matcher, params System.Collections.Generic.IEnumerable<string>[] includePatternsGroups) { }
        public static System.Collections.Generic.IEnumerable<string> GetResultsInFullPath(this Microsoft.Extensions.FileSystemGlobbing.Matcher matcher, string directoryPath) { throw null; }
    }
    public partial class PatternMatchingResult
    {
        public PatternMatchingResult(System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.FilePatternMatch> files) { }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.FilePatternMatch> Files { get { throw null; } set { } }
    }
}
namespace Microsoft.Extensions.FileSystemGlobbing.Abstractions
{
    public abstract partial class DirectoryInfoBase : Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileSystemInfoBase
    {
        protected DirectoryInfoBase() { }
        public abstract System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileSystemInfoBase> EnumerateFileSystemInfos();
        public abstract Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase GetDirectory(string path);
        public abstract Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase GetFile(string path);
    }
    public partial class DirectoryInfoWrapper : Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase
    {
        public DirectoryInfoWrapper(System.IO.DirectoryInfo directoryInfo, bool isParentPath = false) { }
        public override string FullName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase ParentDirectory { get { throw null; } }
        public override System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileSystemInfoBase> EnumerateFileSystemInfos() { throw null; }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase GetDirectory(string name) { throw null; }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase GetFile(string name) { throw null; }
    }
    public abstract partial class FileInfoBase : Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileSystemInfoBase
    {
        protected FileInfoBase() { }
    }
    public partial class FileInfoWrapper : Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase
    {
        public FileInfoWrapper(System.IO.FileInfo fileInfo) { }
        public override string FullName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase ParentDirectory { get { throw null; } }
    }
    public abstract partial class FileSystemInfoBase
    {
        protected FileSystemInfoBase() { }
        public abstract string FullName { get; }
        public abstract string Name { get; }
        public abstract Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase ParentDirectory { get; }
    }
}
namespace Microsoft.Extensions.FileSystemGlobbing.Internal
{
    public partial interface ILinearPattern : Microsoft.Extensions.FileSystemGlobbing.Internal.IPattern
    {
        System.Collections.Generic.IList<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment> Segments { get; }
    }
    public partial interface IPathSegment
    {
        bool CanProduceStem { get; }
        bool Match(string value);
    }
    public partial interface IPattern
    {
        Microsoft.Extensions.FileSystemGlobbing.Internal.IPatternContext CreatePatternContextForExclude();
        Microsoft.Extensions.FileSystemGlobbing.Internal.IPatternContext CreatePatternContextForInclude();
    }
    public partial interface IPatternContext
    {
        void Declare(System.Action<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment, bool> onDeclare);
        void PopDirectory();
        void PushDirectory(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory);
        bool Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory);
        Microsoft.Extensions.FileSystemGlobbing.Internal.PatternTestResult Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase file);
    }
    public partial interface IRaggedPattern : Microsoft.Extensions.FileSystemGlobbing.Internal.IPattern
    {
        System.Collections.Generic.IList<System.Collections.Generic.IList<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment>> Contains { get; }
        System.Collections.Generic.IList<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment> EndsWith { get; }
        System.Collections.Generic.IList<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment> Segments { get; }
        System.Collections.Generic.IList<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment> StartsWith { get; }
    }
    public partial class MatcherContext
    {
        public MatcherContext(System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.Internal.IPattern> includePatterns, System.Collections.Generic.IEnumerable<Microsoft.Extensions.FileSystemGlobbing.Internal.IPattern> excludePatterns, Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directoryInfo, System.StringComparison comparison) { }
        public Microsoft.Extensions.FileSystemGlobbing.PatternMatchingResult Execute() { throw null; }
    }
    public partial struct PatternTestResult
    {
        private object _dummy;
        private int _dummyPrimitive;
        public static readonly Microsoft.Extensions.FileSystemGlobbing.Internal.PatternTestResult Failed;
        public bool IsSuccessful { get { throw null; } }
        public string Stem { get { throw null; } }
        public static Microsoft.Extensions.FileSystemGlobbing.Internal.PatternTestResult Success(string stem) { throw null; }
    }
}
namespace Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments
{
    public partial class CurrentPathSegment : Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment
    {
        public CurrentPathSegment() { }
        public bool CanProduceStem { get { throw null; } }
        public bool Match(string value) { throw null; }
    }
    public partial class LiteralPathSegment : Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment
    {
        public LiteralPathSegment(string value, System.StringComparison comparisonType) { }
        public bool CanProduceStem { get { throw null; } }
        public string Value { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public bool Match(string value) { throw null; }
    }
    public partial class ParentPathSegment : Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment
    {
        public ParentPathSegment() { }
        public bool CanProduceStem { get { throw null; } }
        public bool Match(string value) { throw null; }
    }
    public partial class RecursiveWildcardSegment : Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment
    {
        public RecursiveWildcardSegment() { }
        public bool CanProduceStem { get { throw null; } }
        public bool Match(string value) { throw null; }
    }
    public partial class WildcardPathSegment : Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment
    {
        public static readonly Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments.WildcardPathSegment MatchAll;
        public WildcardPathSegment(string beginsWith, System.Collections.Generic.List<string> contains, string endsWith, System.StringComparison comparisonType) { }
        public string BeginsWith { get { throw null; } }
        public bool CanProduceStem { get { throw null; } }
        public System.Collections.Generic.List<string> Contains { get { throw null; } }
        public string EndsWith { get { throw null; } }
        public bool Match(string value) { throw null; }
    }
}
namespace Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts
{
    public abstract partial class PatternContextLinear : Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContext<Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContextLinear.FrameData>
    {
        public PatternContextLinear(Microsoft.Extensions.FileSystemGlobbing.Internal.ILinearPattern pattern) { }
        protected Microsoft.Extensions.FileSystemGlobbing.Internal.ILinearPattern Pattern { get { throw null; } }
        protected string CalculateStem(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase matchedFile) { throw null; }
        protected bool IsLastSegment() { throw null; }
        public override void PushDirectory(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory) { }
        public override Microsoft.Extensions.FileSystemGlobbing.Internal.PatternTestResult Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase file) { throw null; }
        protected bool TestMatchingSegment(string value) { throw null; }
        public partial struct FrameData
        {
            private object _dummy;
            public bool InStem;
            public bool IsNotApplicable;
            public int SegmentIndex;
            public string Stem { get { throw null; } }
            public System.Collections.Generic.IList<string> StemItems { get { throw null; } }
        }
    }
    public partial class PatternContextLinearExclude : Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContextLinear
    {
        public PatternContextLinearExclude(Microsoft.Extensions.FileSystemGlobbing.Internal.ILinearPattern pattern) : base (default(Microsoft.Extensions.FileSystemGlobbing.Internal.ILinearPattern)) { }
        public override bool Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory) { throw null; }
    }
    public partial class PatternContextLinearInclude : Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContextLinear
    {
        public PatternContextLinearInclude(Microsoft.Extensions.FileSystemGlobbing.Internal.ILinearPattern pattern) : base (default(Microsoft.Extensions.FileSystemGlobbing.Internal.ILinearPattern)) { }
        public override void Declare(System.Action<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment, bool> onDeclare) { }
        public override bool Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory) { throw null; }
    }
    public abstract partial class PatternContextRagged : Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContext<Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContextRagged.FrameData>
    {
        public PatternContextRagged(Microsoft.Extensions.FileSystemGlobbing.Internal.IRaggedPattern pattern) { }
        protected Microsoft.Extensions.FileSystemGlobbing.Internal.IRaggedPattern Pattern { get { throw null; } }
        protected string CalculateStem(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase matchedFile) { throw null; }
        protected bool IsEndingGroup() { throw null; }
        protected bool IsStartingGroup() { throw null; }
        public sealed override void PushDirectory(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory) { }
        public override Microsoft.Extensions.FileSystemGlobbing.Internal.PatternTestResult Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase file) { throw null; }
        protected bool TestMatchingGroup(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileSystemInfoBase value) { throw null; }
        protected bool TestMatchingSegment(string value) { throw null; }
        public partial struct FrameData
        {
            private object _dummy;
            public int BacktrackAvailable;
            public bool InStem;
            public bool IsNotApplicable;
            public System.Collections.Generic.IList<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment> SegmentGroup;
            public int SegmentGroupIndex;
            public int SegmentIndex;
            public string Stem { get { throw null; } }
            public System.Collections.Generic.IList<string> StemItems { get { throw null; } }
        }
    }
    public partial class PatternContextRaggedExclude : Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContextRagged
    {
        public PatternContextRaggedExclude(Microsoft.Extensions.FileSystemGlobbing.Internal.IRaggedPattern pattern) : base (default(Microsoft.Extensions.FileSystemGlobbing.Internal.IRaggedPattern)) { }
        public override bool Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory) { throw null; }
    }
    public partial class PatternContextRaggedInclude : Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts.PatternContextRagged
    {
        public PatternContextRaggedInclude(Microsoft.Extensions.FileSystemGlobbing.Internal.IRaggedPattern pattern) : base (default(Microsoft.Extensions.FileSystemGlobbing.Internal.IRaggedPattern)) { }
        public override void Declare(System.Action<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment, bool> onDeclare) { }
        public override bool Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory) { throw null; }
    }
    public abstract partial class PatternContext<TFrame> : Microsoft.Extensions.FileSystemGlobbing.Internal.IPatternContext
    {
        protected TFrame Frame;
        protected PatternContext() { }
        public virtual void Declare(System.Action<Microsoft.Extensions.FileSystemGlobbing.Internal.IPathSegment, bool> declare) { }
        protected bool IsStackEmpty() { throw null; }
        public void PopDirectory() { }
        protected void PushDataFrame(TFrame frame) { }
        public abstract void PushDirectory(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory);
        public abstract bool Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.DirectoryInfoBase directory);
        public abstract Microsoft.Extensions.FileSystemGlobbing.Internal.PatternTestResult Test(Microsoft.Extensions.FileSystemGlobbing.Abstractions.FileInfoBase file);
    }
}
namespace Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns
{
    public partial class PatternBuilder
    {
        public PatternBuilder() { }
        public PatternBuilder(System.StringComparison comparisonType) { }
        public System.StringComparison ComparisonType { get { throw null; } }
        public Microsoft.Extensions.FileSystemGlobbing.Internal.IPattern Build(string pattern) { throw null; }
    }
}
namespace Microsoft.Extensions.Primitives
{
    public partial interface IChangeToken
    {
        bool ActiveChangeCallbacks { get; }
        bool HasChanged { get; }
        System.IDisposable RegisterChangeCallback(System.Action<object> callback, object state);
    }
}
namespace NuGet.Commands
{
    public static partial class AssetTargetFallbackUtility
    {
        public static readonly string AssetTargetFallback;
        public static void ApplyFramework(NuGet.ProjectModel.TargetFrameworkInformation targetFrameworkInfo, System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> packageTargetFallback, System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> assetTargetFallback) { }
        public static void EnsureValidFallback(System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> packageTargetFallback, System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> assetTargetFallback, string filePath) { }
        public static NuGet.Frameworks.NuGetFramework GetFallbackFramework(NuGet.Frameworks.NuGetFramework projectFramework, System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> packageTargetFallback, System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> assetTargetFallback) { throw null; }
        public static NuGet.Common.RestoreLogMessage GetInvalidFallbackCombinationMessage(string path) { throw null; }
    }
    public static partial class BuildAssetsUtils
    {
        public static readonly string[] MacroCandidates;
        public static void AddNuGetProperties(System.Xml.Linq.XDocument doc, System.Collections.Generic.IEnumerable<string> packageFolders, string repositoryRoot, NuGet.ProjectModel.ProjectStyle projectStyle, string assetsFilePath, bool success) { }
        public static void AddNuGetPropertiesToFirstImport(System.Collections.Generic.IEnumerable<NuGet.Commands.MSBuildOutputFile> files, System.Collections.Generic.IEnumerable<string> packageFolders, string repositoryRoot, NuGet.ProjectModel.ProjectStyle projectStyle, string assetsFilePath, bool success) { }
        public static System.Xml.Linq.XElement GenerateContentFilesItem(string path, NuGet.ProjectModel.LockFileContentFile item, string packageId, string packageVersion) { throw null; }
        public static System.Xml.Linq.XDocument GenerateEmptyImportsFile() { throw null; }
        public static System.Xml.Linq.XElement GenerateImport(string path) { throw null; }
        public static System.Xml.Linq.XDocument GenerateMSBuildFile(System.Collections.Generic.List<NuGet.Commands.MSBuildRestoreItemGroup> groups, NuGet.ProjectModel.ProjectStyle outputType) { throw null; }
        public static System.Collections.Generic.List<NuGet.Commands.MSBuildOutputFile> GenerateMultiTargetFailureFiles(string targetsPath, string propsPath, NuGet.ProjectModel.ProjectStyle restoreType) { throw null; }
        public static System.Xml.Linq.XDocument GenerateMultiTargetFrameworkWarning() { throw null; }
        public static System.Xml.Linq.XElement GenerateProperty(string propertyName, string content) { throw null; }
        public static string GetLanguage(string nugetLanguage) { throw null; }
        public static string GetMSBuildFilePath(NuGet.ProjectModel.PackageSpec project, NuGet.Commands.RestoreRequest request, string extension) { throw null; }
        public static System.Collections.Generic.List<NuGet.Commands.MSBuildOutputFile> GetMSBuildOutputFiles(NuGet.ProjectModel.PackageSpec project, NuGet.ProjectModel.LockFile assetsFile, System.Collections.Generic.IEnumerable<NuGet.Commands.RestoreTargetGraph> targetGraphs, System.Collections.Generic.IReadOnlyList<NuGet.Repositories.NuGetv3LocalRepository> repositories, NuGet.Commands.RestoreRequest request, string assetsFilePath, bool restoreSuccess, NuGet.Common.ILogger log) { throw null; }
        public static string GetPathWithMacros(string absolutePath, string repositoryRoot) { throw null; }
        public static bool HasChanges(System.Xml.Linq.XDocument newFile, string path, NuGet.Common.ILogger log) { throw null; }
        public static System.Xml.Linq.XDocument ReadExisting(string path, NuGet.Common.ILogger log) { throw null; }
        public static void WriteFiles(System.Collections.Generic.IEnumerable<NuGet.Commands.MSBuildOutputFile> files, NuGet.Common.ILogger log) { }
        public static void WriteXML(string path, System.Xml.Linq.XDocument doc) { }
    }
    public partial class CompatibilityCheckResult
    {
        public CompatibilityCheckResult(NuGet.Commands.RestoreTargetGraph graph, System.Collections.Generic.IEnumerable<NuGet.Commands.CompatibilityIssue> issues) { }
        public NuGet.Commands.RestoreTargetGraph Graph { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.Commands.CompatibilityIssue> Issues { get { throw null; } }
        public bool Success { get { throw null; } }
    }
    public partial class CompatibilityIssue : System.IEquatable<NuGet.Commands.CompatibilityIssue>
    {
        internal CompatibilityIssue() { }
        public string AssemblyName { get { throw null; } }
        public System.Collections.Generic.List<NuGet.Frameworks.FrameworkRuntimePair> AvailableFrameworkRuntimePairs { get { throw null; } }
        public System.Collections.Generic.List<NuGet.Frameworks.NuGetFramework> AvailableFrameworks { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework Framework { get { throw null; } }
        public NuGet.Packaging.Core.PackageIdentity Package { get { throw null; } }
        public string RuntimeIdentifier { get { throw null; } }
        public NuGet.Commands.CompatibilityIssueType Type { get { throw null; } }
        public bool Equals(NuGet.Commands.CompatibilityIssue other) { throw null; }
        public string Format() { throw null; }
        public static NuGet.Commands.CompatibilityIssue IncompatiblePackage(NuGet.Packaging.Core.PackageIdentity referenceAssemblyPackage, NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier, System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> packageFrameworks) { throw null; }
        public static NuGet.Commands.CompatibilityIssue IncompatiblePackageWithDotnetTool(NuGet.Packaging.Core.PackageIdentity referenceAssemblyPackage) { throw null; }
        public static NuGet.Commands.CompatibilityIssue IncompatibleProject(NuGet.Packaging.Core.PackageIdentity project, NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier, System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> projectFrameworks) { throw null; }
        public static NuGet.Commands.CompatibilityIssue IncompatibleProjectType(NuGet.Packaging.Core.PackageIdentity project) { throw null; }
        public static NuGet.Commands.CompatibilityIssue IncompatibleToolsPackage(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier, System.Collections.Generic.HashSet<NuGet.Frameworks.FrameworkRuntimePair> available) { throw null; }
        public static NuGet.Commands.CompatibilityIssue ReferenceAssemblyNotImplemented(string assemblyName, NuGet.Packaging.Core.PackageIdentity referenceAssemblyPackage, NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier) { throw null; }
        public static NuGet.Commands.CompatibilityIssue ToolsPackageWithExtraPackageTypes(NuGet.Packaging.Core.PackageIdentity referenceAssemblyPackage) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum CompatibilityIssueType
    {
        IncompatiblePackageWithDotnetTool = 5,
        PackageIncompatible = 1,
        PackageToolsAssetsIncompatible = 3,
        PackageTypeIncompatible = 7,
        ProjectIncompatible = 2,
        ProjectWithIncorrectDependencyCount = 4,
        ReferenceAssemblyNotImplemented = 0,
        ToolsPackageWithExtraPackageTypes = 6,
    }
    public partial struct ContentMetadata
    {
        private object _dummy;
        public string BuildAction { get { throw null; } set { } }
        public string CopyToOutput { get { throw null; } set { } }
        public string Flatten { get { throw null; } set { } }
        public string Source { get { throw null; } set { } }
        public string Target { get { throw null; } set { } }
    }
    public static partial class DeleteRunner
    {
        public static System.Threading.Tasks.Task Run(NuGet.Configuration.ISettings settings, NuGet.Configuration.IPackageSourceProvider sourceProvider, string packageId, string packageVersion, string source, string apiKey, bool nonInteractive, bool noServiceEndpoint, System.Func<string, bool> confirmFunc, NuGet.Common.ILogger logger) { throw null; }
    }
    public partial class DependencyGraphFileRequestProvider : NuGet.Commands.IRestoreRequestProvider
    {
        public DependencyGraphFileRequestProvider(NuGet.Commands.RestoreCommandProvidersCache providerCache) { }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Commands.RestoreSummaryRequest>> CreateRequests(string inputPath, NuGet.Commands.RestoreArgs restoreContext) { throw null; }
        public virtual System.Threading.Tasks.Task<bool> Supports(string path) { throw null; }
    }
    public partial class DependencyGraphSpecRequestProvider : NuGet.Commands.IPreLoadedRestoreRequestProvider
    {
        public DependencyGraphSpecRequestProvider(NuGet.Commands.RestoreCommandProvidersCache providerCache, NuGet.ProjectModel.DependencyGraphSpec dgFile) { }
        public System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Commands.RestoreSummaryRequest>> CreateRequests(NuGet.Commands.RestoreArgs restoreContext) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.ProjectModel.ExternalProjectReference> GetExternalClosure(NuGet.ProjectModel.DependencyGraphSpec dgFile, string projectNameToRestore) { throw null; }
    }
    public static partial class DiagnosticUtility
    {
        public static string FormatDependency(string id, NuGet.Versioning.VersionRange range) { throw null; }
        public static string FormatExpectedIdentity(string id, NuGet.Versioning.VersionRange range) { throw null; }
        public static string FormatGraphName(NuGet.Commands.RestoreTargetGraph graph) { throw null; }
        public static string FormatIdentity(NuGet.LibraryModel.LibraryIdentity identity) { throw null; }
        public static string GetMultiLineMessage(System.Collections.Generic.IEnumerable<string> lines) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Common.RestoreLogMessage> MergeOnTargetGraph(System.Collections.Generic.IEnumerable<NuGet.Common.RestoreLogMessage> messages) { throw null; }
    }
    public partial class DownloadDependencyResolutionResult
    {
        internal DownloadDependencyResolutionResult() { }
        public System.Collections.Generic.IList<System.Tuple<NuGet.LibraryModel.LibraryRange, NuGet.DependencyResolver.RemoteMatch>> Dependencies { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework Framework { get { throw null; } }
        public System.Collections.Generic.ISet<NuGet.DependencyResolver.RemoteMatch> Install { get { throw null; } }
        public System.Collections.Generic.ISet<NuGet.LibraryModel.LibraryRange> Unresolved { get { throw null; } }
        public static NuGet.Commands.DownloadDependencyResolutionResult Create(NuGet.Frameworks.NuGetFramework framework, System.Collections.Generic.IList<System.Tuple<NuGet.LibraryModel.LibraryRange, NuGet.DependencyResolver.RemoteMatch>> dependencies, System.Collections.Generic.IList<NuGet.DependencyResolver.IRemoteDependencyProvider> remoteDependencyProviders) { throw null; }
    }
    public partial interface IListCommandRunner
    {
        System.Threading.Tasks.Task ExecuteCommand(NuGet.Commands.ListArgs listArgs);
    }
    public partial interface ILocalsCommandRunner
    {
        void ExecuteCommand(NuGet.Commands.LocalsArgs localsArgs);
    }
    public partial interface IMSBuildItem
    {
        string Identity { get; }
        System.Collections.Generic.IReadOnlyList<string> Properties { get; }
        string GetProperty(string property);
        string GetProperty(string property, bool trim);
    }
    public partial class IndexedRestoreTargetGraph
    {
        internal IndexedRestoreTargetGraph() { }
        public NuGet.Commands.IRestoreTargetGraph Graph { get { throw null; } }
        public static NuGet.Commands.IndexedRestoreTargetGraph Create(NuGet.Commands.IRestoreTargetGraph graph) { throw null; }
        public NuGet.DependencyResolver.GraphItem<NuGet.DependencyResolver.RemoteResolveResult> GetItemById(string id) { throw null; }
        public NuGet.DependencyResolver.GraphItem<NuGet.DependencyResolver.RemoteResolveResult> GetItemById(string id, NuGet.LibraryModel.LibraryType libraryType) { throw null; }
        public bool HasErrors(string id) { throw null; }
    }
    public partial interface IPreLoadedRestoreRequestProvider
    {
        System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Commands.RestoreSummaryRequest>> CreateRequests(NuGet.Commands.RestoreArgs restoreContext);
    }
    public partial interface IProjectFactory
    {
        NuGet.Common.ILogger Logger { get; set; }
        NuGet.Packaging.PackageBuilder CreateBuilder(string basePath, NuGet.Versioning.NuGetVersion version, string suffix, bool buildIfNeeded, NuGet.Packaging.PackageBuilder builder = null);
        System.Collections.Generic.Dictionary<string, string> GetProjectProperties();
        NuGet.ProjectModel.WarningProperties GetWarningPropertiesForProject();
        void SetIncludeSymbols(bool includeSymbols);
    }
    public partial interface IRestoreRequestProvider
    {
        System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Commands.RestoreSummaryRequest>> CreateRequests(string inputPath, NuGet.Commands.RestoreArgs restoreContext);
        System.Threading.Tasks.Task<bool> Supports(string path);
    }
    public partial interface IRestoreResult
    {
        NuGet.ProjectModel.LockFile LockFile { get; }
        string LockFilePath { get; }
        System.Collections.Generic.IEnumerable<NuGet.Commands.MSBuildOutputFile> MSBuildOutputFiles { get; }
        NuGet.ProjectModel.LockFile PreviousLockFile { get; }
        bool Success { get; }
    }
    public partial interface IRestoreTargetGraph
    {
        NuGet.DependencyResolver.AnalyzeResult<NuGet.DependencyResolver.RemoteResolveResult> AnalyzeResult { get; }
        System.Collections.Generic.IEnumerable<NuGet.Commands.ResolverConflict> Conflicts { get; }
        NuGet.Client.ManagedCodeConventions Conventions { get; }
        System.Collections.Generic.ISet<NuGet.DependencyResolver.GraphItem<NuGet.DependencyResolver.RemoteResolveResult>> Flattened { get; }
        NuGet.Frameworks.NuGetFramework Framework { get; }
        System.Collections.Generic.IEnumerable<NuGet.DependencyResolver.GraphNode<NuGet.DependencyResolver.RemoteResolveResult>> Graphs { get; }
        bool InConflict { get; }
        System.Collections.Generic.ISet<NuGet.DependencyResolver.RemoteMatch> Install { get; }
        string Name { get; }
        System.Collections.Generic.ISet<NuGet.Commands.ResolvedDependencyKey> ResolvedDependencies { get; }
        NuGet.RuntimeModel.RuntimeGraph RuntimeGraph { get; }
        string RuntimeIdentifier { get; }
        string TargetGraphName { get; }
        System.Collections.Generic.ISet<NuGet.LibraryModel.LibraryRange> Unresolved { get; }
    }
    public partial interface ISignCommandRunner
    {
        System.Threading.Tasks.Task<int> ExecuteCommandAsync(NuGet.Commands.SignArgs signArgs);
    }
    public partial interface ITrustedSignersCommandRunner
    {
        System.Threading.Tasks.Task<int> ExecuteCommandAsync(NuGet.Commands.TrustedSignersArgs trustedSignersArgs);
    }
    public partial interface IVerifyCommandRunner
    {
        System.Threading.Tasks.Task<int> ExecuteCommandAsync(NuGet.Commands.VerifyArgs verifyArgs);
    }
    public partial class ListArgs
    {
        public ListArgs(System.Collections.Generic.IList<string> arguments, System.Collections.Generic.IList<NuGet.Configuration.PackageSource> listEndpoints, NuGet.Configuration.ISettings settings, NuGet.Common.ILogger logger, NuGet.Commands.ListArgs.Log printJustified, bool isDetailedl, string listCommandNoPackages, string listCommandLicenseUrl, string listCommandListNotSupported, bool allVersions, bool includeDelisted, bool prerelease, System.Threading.CancellationToken token) { }
        public bool AllVersions { get { throw null; } }
        public System.Collections.Generic.IList<string> Arguments { get { throw null; } }
        public System.Threading.CancellationToken CancellationToken { get { throw null; } }
        public bool IncludeDelisted { get { throw null; } }
        public bool IsDetailed { get { throw null; } }
        public string ListCommandLicenseUrl { get { throw null; } }
        public string ListCommandListNotSupported { get { throw null; } }
        public string ListCommandNoPackages { get { throw null; } }
        public System.Collections.Generic.IList<NuGet.Configuration.PackageSource> ListEndpoints { get { throw null; } }
        public NuGet.Common.ILogger Logger { get { throw null; } }
        public bool Prerelease { get { throw null; } }
        public NuGet.Commands.ListArgs.Log PrintJustified { get { throw null; } }
        public NuGet.Configuration.ISettings Settings { get { throw null; } }
        public delegate void Log(int startIndex, string message);
    }
    public partial class ListCommandRunner : NuGet.Commands.IListCommandRunner
    {
        public ListCommandRunner() { }
        public System.Threading.Tasks.Task ExecuteCommand(NuGet.Commands.ListArgs listArgs) { throw null; }
    }
    public partial class LocalsArgs
    {
        public LocalsArgs(System.Collections.Generic.IList<string> arguments, NuGet.Configuration.ISettings settings, NuGet.Commands.LocalsArgs.Log logInformation, NuGet.Commands.LocalsArgs.Log logError, bool clear, bool list) { }
        public System.Collections.Generic.IList<string> Arguments { get { throw null; } }
        public bool Clear { get { throw null; } }
        public bool List { get { throw null; } }
        public NuGet.Commands.LocalsArgs.Log LogError { get { throw null; } }
        public NuGet.Commands.LocalsArgs.Log LogInformation { get { throw null; } }
        public NuGet.Configuration.ISettings Settings { get { throw null; } }
        public delegate void Log(string message);
    }
    public partial class LocalsCommandRunner : NuGet.Commands.ILocalsCommandRunner
    {
        public LocalsCommandRunner() { }
        public void ExecuteCommand(NuGet.Commands.LocalsArgs localsArgs) { }
    }
    public partial class LockFileBuilder
    {
        public LockFileBuilder(int lockFileVersion, NuGet.Common.ILogger logger, System.Collections.Generic.Dictionary<NuGet.Commands.RestoreTargetGraph, System.Collections.Generic.Dictionary<string, NuGet.LibraryModel.LibraryIncludeFlags>> includeFlagGraphs) { }
        public NuGet.ProjectModel.LockFile CreateLockFile(NuGet.ProjectModel.LockFile previousLockFile, NuGet.ProjectModel.PackageSpec project, System.Collections.Generic.IEnumerable<NuGet.Commands.RestoreTargetGraph> targetGraphs, System.Collections.Generic.IReadOnlyList<NuGet.Repositories.NuGetv3LocalRepository> localRepositories, NuGet.DependencyResolver.RemoteWalkContext context) { throw null; }
    }
    public partial class LockFileBuilderCache
    {
        public LockFileBuilderCache() { }
        public NuGet.ContentModel.ContentItemCollection GetContentItems(NuGet.ProjectModel.LockFileLibrary library, NuGet.Repositories.LocalPackageInfo package) { throw null; }
        public System.Collections.Generic.List<System.Collections.Generic.List<NuGet.ContentModel.SelectionCriteria>> GetSelectionCriteria(NuGet.Commands.RestoreTargetGraph graph, NuGet.Frameworks.NuGetFramework framework) { throw null; }
    }
    public static partial class LockFileUtils
    {
        public static readonly string LIBANY;
        public static NuGet.ProjectModel.LockFileTargetLibrary CreateLockFileTargetLibrary(NuGet.ProjectModel.LockFileLibrary library, NuGet.Repositories.LocalPackageInfo package, NuGet.Commands.RestoreTargetGraph targetGraph, NuGet.LibraryModel.LibraryIncludeFlags dependencyType) { throw null; }
        public static NuGet.ProjectModel.LockFileTargetLibrary CreateLockFileTargetLibrary(NuGet.ProjectModel.LockFileLibrary library, NuGet.Repositories.LocalPackageInfo package, NuGet.Commands.RestoreTargetGraph targetGraph, NuGet.LibraryModel.LibraryIncludeFlags dependencyType, NuGet.Frameworks.NuGetFramework targetFrameworkOverride, System.Collections.Generic.IEnumerable<NuGet.LibraryModel.LibraryDependency> dependencies, NuGet.Commands.LockFileBuilderCache cache) { throw null; }
        public static NuGet.ProjectModel.LockFileTargetLibrary CreateLockFileTargetProject(NuGet.DependencyResolver.GraphItem<NuGet.DependencyResolver.RemoteResolveResult> graphItem, NuGet.LibraryModel.LibraryIdentity library, NuGet.LibraryModel.LibraryIncludeFlags dependencyType, NuGet.Commands.RestoreTargetGraph targetGraph, NuGet.ProjectModel.ProjectStyle rootProjectStyle) { throw null; }
        public static void ExcludeItems(NuGet.ProjectModel.LockFileTargetLibrary lockFileLib, NuGet.LibraryModel.LibraryIncludeFlags dependencyType) { }
        public static string ToDirectorySeparator(string path) { throw null; }
    }
    public partial class MSBuildItem : NuGet.Commands.IMSBuildItem
    {
        public MSBuildItem(string identity, System.Collections.Generic.IDictionary<string, string> metadata) { }
        public string Identity { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Properties { get { throw null; } }
        public string GetProperty(string property) { throw null; }
        public string GetProperty(string property, bool trim) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MSBuildOutputFile
    {
        public MSBuildOutputFile(string path, System.Xml.Linq.XDocument content) { }
        public System.Xml.Linq.XDocument Content { get { throw null; } }
        public string Path { get { throw null; } }
    }
    public partial class MSBuildPackTargetArgs
    {
        public MSBuildPackTargetArgs() { }
        public System.Collections.Generic.HashSet<string> AllowedOutputExtensionsInPackageBuildOutputFolder { get { throw null; } set { } }
        public System.Collections.Generic.HashSet<string> AllowedOutputExtensionsInSymbolsPackageBuildOutputFolder { get { throw null; } set { } }
        public string AssemblyName { get { throw null; } set { } }
        public string[] BuildOutputFolder { get { throw null; } set { } }
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<NuGet.Commands.ContentMetadata>> ContentFiles { get { throw null; } set { } }
        public bool IncludeBuildOutput { get { throw null; } set { } }
        public string NuspecOutputPath { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> SourceFiles { get { throw null; } set { } }
        public System.Collections.Generic.ISet<NuGet.Frameworks.NuGetFramework> TargetFrameworks { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<NuGet.Commands.OutputLibFile> TargetPathsToAssemblies { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<NuGet.Commands.OutputLibFile> TargetPathsToSymbols { get { throw null; } set { } }
    }
    public partial class MSBuildProjectFactory : NuGet.Commands.IProjectFactory
    {
        public MSBuildProjectFactory() { }
        public bool Build { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<NuGet.Packaging.ManifestFile> Files { get { throw null; } set { } }
        public bool IncludeSymbols { get { throw null; } set { } }
        public bool IsTool { get { throw null; } set { } }
        public NuGet.Common.ILogger Logger { get { throw null; } set { } }
        public NuGet.Configuration.IMachineWideSettings MachineWideSettings { get { throw null; } set { } }
        public System.Collections.Generic.Dictionary<string, string> ProjectProperties { get { throw null; } }
        public NuGet.Packaging.PackageBuilder CreateBuilder(string basePath, NuGet.Versioning.NuGetVersion version, string suffix, bool buildIfNeeded, NuGet.Packaging.PackageBuilder builder) { throw null; }
        public System.Collections.Generic.Dictionary<string, string> GetProjectProperties() { throw null; }
        public static string GetTargetPathForSourceFile(string sourcePath, string projectDirectory) { throw null; }
        public NuGet.ProjectModel.WarningProperties GetWarningPropertiesForProject() { throw null; }
        public static NuGet.Commands.IProjectFactory ProjectCreator(NuGet.Commands.PackArgs packArgs, string path) { throw null; }
        public void SetIncludeSymbols(bool includeSymbols) { }
    }
    public static partial class MSBuildProjectFrameworkUtility
    {
        public static NuGet.Frameworks.NuGetFramework GetProjectFrameworkReplacement(NuGet.Frameworks.NuGetFramework framework) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> GetProjectFrameworks(System.Collections.Generic.IEnumerable<string> frameworkStrings) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> GetProjectFrameworkStrings(string projectFilePath, string targetFrameworks, string targetFramework, string targetFrameworkMoniker, string targetPlatformIdentifier, string targetPlatformVersion, string targetPlatformMinVersion) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> GetProjectFrameworkStrings(string projectFilePath, string targetFrameworks, string targetFramework, string targetFrameworkMoniker, string targetPlatformIdentifier, string targetPlatformVersion, string targetPlatformMinVersion, bool isXnaWindowsPhoneProject, bool isManagementPackProject) { throw null; }
    }
    public partial class MSBuildRestoreItemGroup
    {
        public static readonly string ImportGroup;
        public static readonly string ItemGroup;
        public MSBuildRestoreItemGroup() { }
        public string Condition { get { throw null; } }
        public System.Collections.Generic.List<string> Conditions { get { throw null; } set { } }
        public System.Collections.Generic.List<System.Xml.Linq.XElement> Items { get { throw null; } set { } }
        public int Position { get { throw null; } set { } }
        public string RootName { get { throw null; } set { } }
        public static NuGet.Commands.MSBuildRestoreItemGroup Create(string rootName, System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> items, int position, System.Collections.Generic.IEnumerable<string> conditions) { throw null; }
    }
    public static partial class MSBuildRestoreUtility
    {
        public static readonly string Clear;
        public static System.Collections.Generic.IEnumerable<string> AggregateSources(System.Collections.Generic.IEnumerable<string> values, System.Collections.Generic.IEnumerable<string> excludeValues) { throw null; }
        public static void ApplyIncludeFlags(NuGet.LibraryModel.LibraryDependency dependency, string includeAssets, string excludeAssets, string privateAssets) { }
        public static void ApplyIncludeFlags(NuGet.ProjectModel.ProjectRestoreReference dependency, string includeAssets, string excludeAssets, string privateAssets) { }
        public static bool ContainsClearKeyword(System.Collections.Generic.IEnumerable<string> values) { throw null; }
        public static void Dump(System.Collections.Generic.IEnumerable<NuGet.Commands.IMSBuildItem> items, NuGet.Common.ILogger log) { }
        public static string FixSourcePath(string s) { throw null; }
        public static NuGet.ProjectModel.DependencyGraphSpec GetDependencySpec(System.Collections.Generic.IEnumerable<NuGet.Commands.IMSBuildItem> items) { throw null; }
        public static NuGet.ProjectModel.PackageSpec GetPackageSpec(System.Collections.Generic.IEnumerable<NuGet.Commands.IMSBuildItem> items) { throw null; }
        public static NuGet.Common.RestoreLogMessage GetWarningForUnsupportedProject(string path) { throw null; }
        public static bool HasInvalidClear(System.Collections.Generic.IEnumerable<string> values) { throw null; }
        public static bool LogErrorForClearIfInvalid(System.Collections.Generic.IEnumerable<string> values, string projectPath, NuGet.Common.ILogger logger) { throw null; }
        public static void NormalizePathCasings(System.Collections.Generic.Dictionary<string, string> paths, NuGet.ProjectModel.DependencyGraphSpec graphSpec) { }
        public static void RemoveMissingProjects(NuGet.ProjectModel.DependencyGraphSpec graphSpec) { }
        public static System.Threading.Tasks.Task ReplayWarningsAndErrorsAsync(NuGet.ProjectModel.LockFile lockFile, NuGet.Common.ILogger logger) { throw null; }
    }
    public partial class NoOpRestoreResult : NuGet.Commands.RestoreResult
    {
        public NoOpRestoreResult(bool success, NuGet.ProjectModel.LockFile lockFile, NuGet.ProjectModel.LockFile previousLockFile, string lockFilePath, NuGet.ProjectModel.CacheFile cacheFile, string cacheFilePath, NuGet.ProjectModel.ProjectStyle projectStyle, System.TimeSpan elapsedTime) : base (default(bool), default(System.Collections.Generic.IEnumerable<NuGet.Commands.RestoreTargetGraph>), default(System.Collections.Generic.IEnumerable<NuGet.Commands.CompatibilityCheckResult>), default(System.Collections.Generic.IEnumerable<NuGet.Commands.MSBuildOutputFile>), default(NuGet.ProjectModel.LockFile), default(NuGet.ProjectModel.LockFile), default(string), default(NuGet.ProjectModel.CacheFile), default(string), default(string), default(NuGet.ProjectModel.PackagesLockFile), default(NuGet.ProjectModel.ProjectStyle), default(System.TimeSpan)) { }
        public override System.Threading.Tasks.Task CommitAsync(NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Collections.Generic.ISet<NuGet.LibraryModel.LibraryIdentity> GetAllInstalled() { throw null; }
    }
    public partial class NoOpRestoreUtilities
    {
        public NoOpRestoreUtilities() { }
        public static string GetProjectCacheFilePath(string cacheRoot, string projectPath) { throw null; }
    }
    public partial class OriginalCaseGlobalPackageFolder
    {
        public OriginalCaseGlobalPackageFolder(NuGet.Commands.RestoreRequest request) { }
        public OriginalCaseGlobalPackageFolder(NuGet.Commands.RestoreRequest request, System.Guid parentId) { }
        public System.Guid ParentId { get { throw null; } }
        public void ConvertLockFileToOriginalCase(NuGet.ProjectModel.LockFile lockFile) { }
        public System.Threading.Tasks.Task CopyPackagesToOriginalCaseAsync(System.Collections.Generic.IEnumerable<NuGet.Commands.RestoreTargetGraph> graphs, System.Threading.CancellationToken token) { throw null; }
    }
    public partial struct OutputLibFile
    {
        private object _dummy;
        public string FinalOutputPath { get { throw null; } set { } }
        public string TargetFramework { get { throw null; } set { } }
        public string TargetPath { get { throw null; } set { } }
    }
    public partial class PackagesLockFileBuilder
    {
        public PackagesLockFileBuilder() { }
        public NuGet.ProjectModel.PackagesLockFile CreateNuGetLockFile(NuGet.ProjectModel.LockFile assetsFile) { throw null; }
    }
    public static partial class PackageSourceProviderExtensions
    {
        public static string ResolveAndValidateSource(this NuGet.Configuration.IPackageSourceProvider sourceProvider, string source) { throw null; }
        public static NuGet.Configuration.PackageSource ResolveSource(System.Collections.Generic.IEnumerable<NuGet.Configuration.PackageSource> availableSources, string source) { throw null; }
    }
    public partial class PackageSpecificWarningProperties : System.IEquatable<NuGet.Commands.PackageSpecificWarningProperties>
    {
        public PackageSpecificWarningProperties() { }
        public System.Collections.Generic.IDictionary<NuGet.Common.NuGetLogCode, System.Collections.Generic.IDictionary<string, System.Collections.Generic.ISet<NuGet.Frameworks.NuGetFramework>>> Properties { get { throw null; } }
        public void Add(NuGet.Common.NuGetLogCode code, string libraryId, NuGet.Frameworks.NuGetFramework framework) { }
        public void AddRangeOfCodes(System.Collections.Generic.IEnumerable<NuGet.Common.NuGetLogCode> codes, string libraryId, NuGet.Frameworks.NuGetFramework framework) { }
        public void AddRangeOfFrameworks(NuGet.Common.NuGetLogCode code, string libraryId, System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> frameworks) { }
        public bool Contains(NuGet.Common.NuGetLogCode code, string libraryId, NuGet.Frameworks.NuGetFramework framework) { throw null; }
        public static NuGet.Commands.PackageSpecificWarningProperties CreatePackageSpecificWarningProperties(NuGet.ProjectModel.PackageSpec packageSpec) { throw null; }
        public static NuGet.Commands.PackageSpecificWarningProperties CreatePackageSpecificWarningProperties(NuGet.ProjectModel.PackageSpec packageSpec, NuGet.Frameworks.NuGetFramework framework) { throw null; }
        public bool Equals(NuGet.Commands.PackageSpecificWarningProperties other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class PackArgs
    {
        public PackArgs() { }
        public System.Collections.Generic.IEnumerable<string> Arguments { get { throw null; } set { } }
        public string BasePath { get { throw null; } set { } }
        public bool Build { get { throw null; } set { } }
        public string CurrentDirectory { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> Exclude { get { throw null; } set { } }
        public bool ExcludeEmptyDirectories { get { throw null; } set { } }
        public bool IncludeReferencedProjects { get { throw null; } set { } }
        public bool InstallPackageToOutputPath { get { throw null; } set { } }
        public NuGet.Common.ILogger Logger { get { throw null; } set { } }
        public NuGet.Common.LogLevel LogLevel { get { throw null; } set { } }
        public NuGet.Configuration.IMachineWideSettings MachineWideSettings { get { throw null; } set { } }
        public System.Version MinClientVersion { get { throw null; } set { } }
        public System.Lazy<string> MsBuildDirectory { get { throw null; } set { } }
        public bool NoDefaultExcludes { get { throw null; } set { } }
        public bool NoPackageAnalysis { get { throw null; } set { } }
        public string OutputDirectory { get { throw null; } set { } }
        public bool OutputFileNamesWithoutVersion { get { throw null; } set { } }
        public NuGet.Commands.MSBuildPackTargetArgs PackTargetArgs { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public System.Collections.Generic.Dictionary<string, string> Properties { get { throw null; } }
        public bool Serviceable { get { throw null; } set { } }
        public string Suffix { get { throw null; } set { } }
        public NuGet.Commands.SymbolPackageFormat SymbolPackageFormat { get { throw null; } set { } }
        public bool Symbols { get { throw null; } set { } }
        public bool Tool { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        public NuGet.ProjectModel.WarningProperties WarningProperties { get { throw null; } set { } }
        public string GetPropertyValue(string propertyName) { throw null; }
        public static NuGet.Commands.SymbolPackageFormat GetSymbolPackageFormat(string symbolPackageFormat) { throw null; }
    }
    public partial class PackCollectorLogger : NuGet.Common.LoggerBase
    {
        public PackCollectorLogger(NuGet.Common.ILogger innerLogger, NuGet.ProjectModel.WarningProperties warningProperties) { }
        public NuGet.ProjectModel.WarningProperties WarningProperties { get { throw null; } set { } }
        public override void Log(NuGet.Common.ILogMessage message) { }
        public override System.Threading.Tasks.Task LogAsync(NuGet.Common.ILogMessage message) { throw null; }
    }
    public partial class PackCommandRunner
    {
        public PackCommandRunner(NuGet.Commands.PackArgs packArgs, NuGet.Commands.PackCommandRunner.CreateProjectFactory createProjectFactory) { }
        public PackCommandRunner(NuGet.Commands.PackArgs packArgs, NuGet.Commands.PackCommandRunner.CreateProjectFactory createProjectFactory, NuGet.Packaging.PackageBuilder packageBuilder) { }
        public bool GenerateNugetPackage { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.Rules.IPackageRule> Rules { get { throw null; } set { } }
        public static void AddDependencyGroups(System.Collections.Generic.IEnumerable<NuGet.LibraryModel.LibraryDependency> dependencies, NuGet.Frameworks.NuGetFramework framework, NuGet.Packaging.PackageBuilder builder) { }
        public static void AddLibraryDependency(NuGet.LibraryModel.LibraryDependency dependency, System.Collections.Generic.ISet<NuGet.LibraryModel.LibraryDependency> list) { }
        public static void AddPackageDependency(NuGet.Packaging.Core.PackageDependency dependency, System.Collections.Generic.ISet<NuGet.Packaging.Core.PackageDependency> @set) { }
        public void BuildPackage() { }
        public NuGet.Packaging.PackageArchiveReader BuildPackage(NuGet.Packaging.PackageBuilder builder, string outputPath = null) { throw null; }
        public static string GetInputFile(NuGet.Commands.PackArgs packArgs) { throw null; }
        public static string GetOutputFileName(string packageId, NuGet.Versioning.NuGetVersion version, bool isNupkg, bool symbols, NuGet.Commands.SymbolPackageFormat symbolPackageFormat, bool excludeVersion = false) { throw null; }
        public static string GetOutputPath(NuGet.Packaging.PackageBuilder builder, NuGet.Commands.PackArgs packArgs, bool symbols = false, NuGet.Versioning.NuGetVersion nugetVersion = null, string outputDirectory = null, bool isNupkg = true) { throw null; }
        public static bool ProcessProjectJsonFile(NuGet.Packaging.PackageBuilder builder, string basePath, string id, NuGet.Versioning.NuGetVersion version, string suffix, System.Func<string, string> propertyProvider) { throw null; }
        public static void SetupCurrentDirectory(NuGet.Commands.PackArgs packArgs) { }
        public delegate NuGet.Commands.IProjectFactory CreateProjectFactory(NuGet.Commands.PackArgs packArgs, string path);
    }
    public static partial class PushRunner
    {
        public static System.Threading.Tasks.Task Run(NuGet.Configuration.ISettings settings, NuGet.Configuration.IPackageSourceProvider sourceProvider, string packagePath, string source, string apiKey, string symbolSource, string symbolApiKey, int timeoutSeconds, bool disableBuffering, bool noSymbols, bool noServiceEndpoint, bool skipDuplicate, NuGet.Common.ILogger logger) { throw null; }
    }
    public static partial class RequestRuntimeUtility
    {
        public static System.Collections.Generic.IEnumerable<string> GetDefaultRestoreRuntimes(string os, string runtimeOsName) { throw null; }
    }
    public partial class ResolvedDependencyKey : System.IEquatable<NuGet.Commands.ResolvedDependencyKey>
    {
        public ResolvedDependencyKey(NuGet.LibraryModel.LibraryIdentity parent, NuGet.Versioning.VersionRange range, NuGet.LibraryModel.LibraryIdentity child) { }
        public NuGet.LibraryModel.LibraryIdentity Child { get { throw null; } }
        public NuGet.LibraryModel.LibraryIdentity Parent { get { throw null; } }
        public NuGet.Versioning.VersionRange Range { get { throw null; } }
        public bool Equals(NuGet.Commands.ResolvedDependencyKey other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class ResolverConflict
    {
        public ResolverConflict(string name, System.Collections.Generic.IEnumerable<NuGet.Commands.ResolverRequest> requests) { }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IList<NuGet.Commands.ResolverRequest> Requests { get { throw null; } }
    }
    public partial class ResolverRequest
    {
        public ResolverRequest(NuGet.LibraryModel.LibraryIdentity requestor, NuGet.LibraryModel.LibraryRange request) { }
        public NuGet.LibraryModel.LibraryRange Request { get { throw null; } }
        public NuGet.LibraryModel.LibraryIdentity Requestor { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class RestoreArgs
    {
        public RestoreArgs() { }
        public bool AllowNoOp { get { throw null; } set { } }
        public NuGet.Protocol.Core.Types.SourceCacheContext CacheContext { get { throw null; } set { } }
        public NuGet.Protocol.CachingSourceProvider CachingSourceProvider { get { throw null; } set { } }
        public string ConfigFile { get { throw null; } set { } }
        public bool DisableParallel { get { throw null; } set { } }
        public System.Collections.Generic.HashSet<string> FallbackRuntimes { get { throw null; } set { } }
        public string GlobalPackagesFolder { get { throw null; } set { } }
        public bool HideWarningsAndErrors { get { throw null; } set { } }
        public System.Collections.Generic.List<string> Inputs { get { throw null; } set { } }
        public System.Nullable<bool> IsLowercaseGlobalPackagesFolder { get { throw null; } set { } }
        public bool IsRestoreOriginalAction { get { throw null; } set { } }
        public System.Nullable<int> LockFileVersion { get { throw null; } set { } }
        public NuGet.Common.ILogger Log { get { throw null; } set { } }
        public NuGet.Configuration.IMachineWideSettings MachineWideSettings { get { throw null; } set { } }
        public NuGet.Packaging.PackageSaveMode PackageSaveMode { get { throw null; } set { } }
        public System.Guid ParentId { get { throw null; } set { } }
        public System.Collections.Generic.List<NuGet.Commands.IPreLoadedRestoreRequestProvider> PreLoadedRequestProviders { get { throw null; } set { } }
        public System.Collections.Generic.List<NuGet.Commands.IRestoreRequestProvider> RequestProviders { get { throw null; } set { } }
        public bool RestoreForceEvaluate { get { throw null; } set { } }
        public System.Collections.Generic.HashSet<string> Runtimes { get { throw null; } set { } }
        public System.Collections.Generic.List<string> Sources { get { throw null; } set { } }
        public System.Nullable<bool> ValidateRuntimeAssets { get { throw null; } set { } }
        public void ApplyStandardProperties(NuGet.Commands.RestoreRequest request) { }
        public System.Collections.Generic.IReadOnlyList<string> GetEffectiveFallbackPackageFolders(NuGet.Configuration.ISettings settings) { throw null; }
        public string GetEffectiveGlobalPackagesFolder(string rootDirectory, NuGet.Configuration.ISettings settings) { throw null; }
        public NuGet.Configuration.ISettings GetSettings(string projectDirectory) { throw null; }
    }
    public partial class RestoreCollectorLogger : NuGet.Common.LoggerBase, NuGet.Common.ICollectorLogger, NuGet.Common.ILogger
    {
        public RestoreCollectorLogger(NuGet.Common.ILogger innerLogger) { }
        public RestoreCollectorLogger(NuGet.Common.ILogger innerLogger, NuGet.Common.LogLevel verbosity) { }
        public RestoreCollectorLogger(NuGet.Common.ILogger innerLogger, NuGet.Common.LogLevel verbosity, bool hideWarningsAndErrors) { }
        public RestoreCollectorLogger(NuGet.Common.ILogger innerLogger, bool hideWarningsAndErrors) { }
        public System.Collections.Generic.IEnumerable<NuGet.Common.IRestoreLogMessage> Errors { get { throw null; } }
        public string ProjectPath { get { throw null; } }
        public NuGet.Commands.WarningPropertiesCollection ProjectWarningPropertiesCollection { get { throw null; } set { } }
        public NuGet.Commands.WarningPropertiesCollection TransitiveWarningPropertiesCollection { get { throw null; } set { } }
        public void ApplyRestoreInputs(NuGet.ProjectModel.PackageSpec projectSpec) { }
        public void ApplyRestoreOutput(System.Collections.Generic.IEnumerable<NuGet.Commands.RestoreTargetGraph> restoreTargetGraphs) { }
        protected bool DisplayMessage(NuGet.Common.IRestoreLogMessage message) { throw null; }
        public override void Log(NuGet.Common.ILogMessage message) { }
        public void Log(NuGet.Common.IRestoreLogMessage message) { }
        public override System.Threading.Tasks.Task LogAsync(NuGet.Common.ILogMessage message) { throw null; }
        public System.Threading.Tasks.Task LogAsync(NuGet.Common.IRestoreLogMessage message) { throw null; }
    }
    public partial class RestoreCommand
    {
        public RestoreCommand(NuGet.Commands.RestoreRequest request) { }
        public System.Guid ParentId { get { throw null; } }
        public System.Threading.Tasks.Task<NuGet.Commands.RestoreResult> ExecuteAsync() { throw null; }
        public System.Threading.Tasks.Task<NuGet.Commands.RestoreResult> ExecuteAsync(System.Threading.CancellationToken token) { throw null; }
    }
    public partial class RestoreCommandException : System.Exception, NuGet.Common.ILogMessageException
    {
        public RestoreCommandException(NuGet.Common.IRestoreLogMessage logMessage) { }
        public NuGet.Common.ILogMessage AsLogMessage() { throw null; }
    }
    public partial class RestoreCommandProviders
    {
        public RestoreCommandProviders(NuGet.Repositories.NuGetv3LocalRepository globalPackages, System.Collections.Generic.IReadOnlyList<NuGet.Repositories.NuGetv3LocalRepository> fallbackPackageFolders, System.Collections.Generic.IReadOnlyList<NuGet.DependencyResolver.IRemoteDependencyProvider> localProviders, System.Collections.Generic.IReadOnlyList<NuGet.DependencyResolver.IRemoteDependencyProvider> remoteProviders, NuGet.Protocol.LocalPackageFileCache packageFileCache) { }
        public System.Collections.Generic.IReadOnlyList<NuGet.Repositories.NuGetv3LocalRepository> FallbackPackageFolders { get { throw null; } }
        public NuGet.Repositories.NuGetv3LocalRepository GlobalPackages { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.DependencyResolver.IRemoteDependencyProvider> LocalProviders { get { throw null; } }
        public NuGet.Protocol.LocalPackageFileCache PackageFileCache { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.DependencyResolver.IRemoteDependencyProvider> RemoteProviders { get { throw null; } }
        public static NuGet.Commands.RestoreCommandProviders Create(string globalFolderPath, System.Collections.Generic.IEnumerable<string> fallbackPackageFolderPaths, System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.SourceRepository> sources, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Protocol.LocalPackageFileCache packageFileCache, NuGet.Common.ILogger log) { throw null; }
    }
    public partial class RestoreCommandProvidersCache
    {
        public RestoreCommandProvidersCache() { }
        public NuGet.Commands.RestoreCommandProviders GetOrCreate(string globalPackagesPath, System.Collections.Generic.IReadOnlyList<string> fallbackPackagesPaths, System.Collections.Generic.IReadOnlyList<NuGet.Protocol.Core.Types.SourceRepository> sources, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log) { throw null; }
    }
    public partial class RestoreRequest
    {
        public static readonly int DefaultDegreeOfConcurrency;
        public RestoreRequest(NuGet.ProjectModel.PackageSpec project, NuGet.Commands.RestoreCommandProviders dependencyProviders, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Packaging.Signing.ClientPolicyContext clientPolicyContext, NuGet.Common.ILogger log) { }
        public bool AllowNoOp { get { throw null; } set { } }
        public NuGet.Protocol.Core.Types.SourceCacheContext CacheContext { get { throw null; } set { } }
        public NuGet.Packaging.Signing.ClientPolicyContext ClientPolicyContext { get { throw null; } }
        public System.Collections.Generic.ISet<NuGet.Frameworks.FrameworkRuntimePair> CompatibilityProfiles { get { throw null; } }
        public NuGet.ProjectModel.DependencyGraphSpec DependencyGraphSpec { get { throw null; } set { } }
        public NuGet.Commands.RestoreCommandProviders DependencyProviders { get { throw null; } set { } }
        public NuGet.ProjectModel.LockFile ExistingLockFile { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.ProjectModel.ExternalProjectReference> ExternalProjects { get { throw null; } set { } }
        public System.Collections.Generic.ISet<string> FallbackRuntimes { get { throw null; } }
        public bool HideWarningsAndErrors { get { throw null; } set { } }
        public bool IsLowercasePackagesDirectory { get { throw null; } set { } }
        public bool IsRestoreOriginalAction { get { throw null; } set { } }
        public string LockFilePath { get { throw null; } set { } }
        public int LockFileVersion { get { throw null; } set { } }
        public NuGet.Common.ILogger Log { get { throw null; } set { } }
        public int MaxDegreeOfConcurrency { get { throw null; } set { } }
        public string MSBuildProjectExtensionsPath { get { throw null; } set { } }
        public NuGet.Packaging.PackageSaveMode PackageSaveMode { get { throw null; } set { } }
        public string PackagesDirectory { get { throw null; } }
        public System.Guid ParentId { get { throw null; } set { } }
        public NuGet.ProjectModel.PackageSpec Project { get { throw null; } }
        public NuGet.ProjectModel.ProjectStyle ProjectStyle { get { throw null; } set { } }
        public System.Collections.Generic.ISet<string> RequestedRuntimes { get { throw null; } }
        public bool RestoreForceEvaluate { get { throw null; } set { } }
        public string RestoreOutputPath { get { throw null; } set { } }
        public bool ValidateRuntimeAssets { get { throw null; } set { } }
        public NuGet.Packaging.XmlDocFileSaveMode XmlDocFileSaveMode { get { throw null; } set { } }
    }
    public partial class RestoreResult : NuGet.Commands.IRestoreResult
    {
        public RestoreResult(bool success, System.Collections.Generic.IEnumerable<NuGet.Commands.RestoreTargetGraph> restoreGraphs, System.Collections.Generic.IEnumerable<NuGet.Commands.CompatibilityCheckResult> compatibilityCheckResults, System.Collections.Generic.IEnumerable<NuGet.Commands.MSBuildOutputFile> msbuildFiles, NuGet.ProjectModel.LockFile lockFile, NuGet.ProjectModel.LockFile previousLockFile, string lockFilePath, NuGet.ProjectModel.CacheFile cacheFile, string cacheFilePath, string packagesLockFilePath, NuGet.ProjectModel.PackagesLockFile packagesLockFile, NuGet.ProjectModel.ProjectStyle projectStyle, System.TimeSpan elapsedTime) { }
        protected string CacheFilePath { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Commands.CompatibilityCheckResult> CompatibilityCheckResults { get { throw null; } }
        public System.TimeSpan ElapsedTime { get { throw null; } }
        public NuGet.ProjectModel.LockFile LockFile { get { throw null; } }
        public string LockFilePath { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<NuGet.Commands.MSBuildOutputFile> MSBuildOutputFiles { get { throw null; } }
        public NuGet.ProjectModel.LockFile PreviousLockFile { get { throw null; } }
        public NuGet.ProjectModel.ProjectStyle ProjectStyle { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Commands.RestoreTargetGraph> RestoreGraphs { get { throw null; } }
        public bool Success { get { throw null; } }
        public virtual System.Threading.Tasks.Task CommitAsync(NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public virtual System.Collections.Generic.ISet<NuGet.LibraryModel.LibraryIdentity> GetAllInstalled() { throw null; }
        public System.Collections.Generic.ISet<NuGet.LibraryModel.LibraryRange> GetAllUnresolved() { throw null; }
    }
    public partial class RestoreResultPair
    {
        public RestoreResultPair(NuGet.Commands.RestoreSummaryRequest request, NuGet.Commands.RestoreResult result) { }
        public NuGet.Commands.RestoreResult Result { get { throw null; } }
        public NuGet.Commands.RestoreSummaryRequest SummaryRequest { get { throw null; } }
    }
    public static partial class RestoreRunner
    {
        public static System.Threading.Tasks.Task<NuGet.Commands.RestoreSummary> CommitAsync(NuGet.Commands.RestoreResultPair restoreResult, System.Threading.CancellationToken token) { throw null; }
        public static string GetInvalidInputErrorMessage(string input) { throw null; }
        public static System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Commands.RestoreSummaryRequest>> GetRequests(NuGet.Commands.RestoreArgs restoreContext) { throw null; }
        public static System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Commands.RestoreSummary>> RunAsync(NuGet.Commands.RestoreArgs restoreContext) { throw null; }
        public static System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Commands.RestoreSummary>> RunAsync(NuGet.Commands.RestoreArgs restoreContext, System.Threading.CancellationToken token) { throw null; }
        public static System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Commands.RestoreResultPair>> RunWithoutCommit(System.Collections.Generic.IEnumerable<NuGet.Commands.RestoreSummaryRequest> restoreRequests, NuGet.Commands.RestoreArgs restoreContext) { throw null; }
    }
    public partial class RestoreSpecException : System.Exception
    {
        internal RestoreSpecException() { }
        public System.Collections.Generic.IEnumerable<string> Files { get { throw null; } }
        public static NuGet.Commands.RestoreSpecException Create(string message, System.Collections.Generic.IEnumerable<string> files) { throw null; }
        public static NuGet.Commands.RestoreSpecException Create(string message, System.Collections.Generic.IEnumerable<string> files, System.Exception innerException) { throw null; }
    }
    public partial class RestoreSummary
    {
        public RestoreSummary(NuGet.Commands.RestoreResult result, string inputPath, System.Collections.Generic.IEnumerable<string> configFiles, System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.SourceRepository> sourceRepositories, System.Collections.Generic.IEnumerable<NuGet.Common.RestoreLogMessage> errors) { }
        public RestoreSummary(bool success) { }
        public RestoreSummary(bool success, string inputPath, System.Collections.Generic.IEnumerable<string> configFiles, System.Collections.Generic.IEnumerable<string> feedsUsed, int installCount, System.Collections.Generic.IEnumerable<NuGet.Common.IRestoreLogMessage> errors) { }
        public System.Collections.Generic.IList<string> ConfigFiles { get { throw null; } }
        public System.Collections.Generic.IList<NuGet.Common.IRestoreLogMessage> Errors { get { throw null; } }
        public System.Collections.Generic.IList<string> FeedsUsed { get { throw null; } }
        public string InputPath { get { throw null; } }
        public int InstallCount { get { throw null; } }
        public bool NoOpRestore { get { throw null; } }
        public bool Success { get { throw null; } }
        public static void Log(NuGet.Common.ILogger logger, System.Collections.Generic.IEnumerable<NuGet.Commands.RestoreSummary> restoreSummaries, bool logErrors = false) { }
    }
    public partial class RestoreSummaryRequest
    {
        public RestoreSummaryRequest(NuGet.Commands.RestoreRequest request, string inputPath, System.Collections.Generic.IEnumerable<string> configFiles, System.Collections.Generic.IReadOnlyList<NuGet.Protocol.Core.Types.SourceRepository> sources) { }
        public System.Collections.Generic.IEnumerable<string> ConfigFiles { get { throw null; } }
        public string InputPath { get { throw null; } }
        public NuGet.Commands.RestoreRequest Request { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.Protocol.Core.Types.SourceRepository> Sources { get { throw null; } }
    }
    public partial class RestoreTargetGraph : NuGet.Commands.IRestoreTargetGraph
    {
        internal RestoreTargetGraph() { }
        public NuGet.DependencyResolver.AnalyzeResult<NuGet.DependencyResolver.RemoteResolveResult> AnalyzeResult { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Commands.ResolverConflict> Conflicts { get { throw null; } }
        public NuGet.Client.ManagedCodeConventions Conventions { get { throw null; } }
        public System.Collections.Generic.ISet<NuGet.DependencyResolver.GraphItem<NuGet.DependencyResolver.RemoteResolveResult>> Flattened { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework Framework { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.DependencyResolver.GraphNode<NuGet.DependencyResolver.RemoteResolveResult>> Graphs { get { throw null; } }
        public bool InConflict { get { throw null; } }
        public System.Collections.Generic.ISet<NuGet.DependencyResolver.RemoteMatch> Install { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.ISet<NuGet.Commands.ResolvedDependencyKey> ResolvedDependencies { get { throw null; } }
        public NuGet.RuntimeModel.RuntimeGraph RuntimeGraph { get { throw null; } }
        public string RuntimeIdentifier { get { throw null; } }
        public string TargetGraphName { get { throw null; } }
        public System.Collections.Generic.ISet<NuGet.LibraryModel.LibraryRange> Unresolved { get { throw null; } }
        public static NuGet.Commands.RestoreTargetGraph Create(NuGet.RuntimeModel.RuntimeGraph runtimeGraph, System.Collections.Generic.IEnumerable<NuGet.DependencyResolver.GraphNode<NuGet.DependencyResolver.RemoteResolveResult>> graphs, NuGet.DependencyResolver.RemoteWalkContext context, NuGet.Common.ILogger log, NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier) { throw null; }
        public static NuGet.Commands.RestoreTargetGraph Create(System.Collections.Generic.IEnumerable<NuGet.DependencyResolver.GraphNode<NuGet.DependencyResolver.RemoteResolveResult>> graphs, NuGet.DependencyResolver.RemoteWalkContext context, NuGet.Common.ILogger logger, NuGet.Frameworks.NuGetFramework framework) { throw null; }
    }
    public partial class SignArgs
    {
        public SignArgs() { }
        public string CertificateFingerprint { get { throw null; } set { } }
        public string CertificatePassword { get { throw null; } set { } }
        public string CertificatePath { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.StoreLocation CertificateStoreLocation { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.StoreName CertificateStoreName { get { throw null; } set { } }
        public string CertificateSubjectName { get { throw null; } set { } }
        public NuGet.Common.ILogger Logger { get { throw null; } set { } }
        public bool NonInteractive { get { throw null; } set { } }
        public string OutputDirectory { get { throw null; } set { } }
        public bool Overwrite { get { throw null; } set { } }
        public string PackagePath { get { throw null; } set { } }
        public NuGet.Commands.SignCommand.IPasswordProvider PasswordProvider { get { throw null; } set { } }
        public NuGet.Common.HashAlgorithmName SignatureHashAlgorithm { get { throw null; } set { } }
        public string Timestamper { get { throw null; } set { } }
        public NuGet.Common.HashAlgorithmName TimestampHashAlgorithm { get { throw null; } set { } }
        public System.Threading.CancellationToken Token { get { throw null; } set { } }
    }
    public sealed partial class SignCommandException : System.Exception, NuGet.Common.ILogMessageException
    {
        public SignCommandException(NuGet.Common.ILogMessage logMessage) { }
        public NuGet.Common.ILogMessage AsLogMessage() { throw null; }
    }
    public partial class SignCommandRunner : NuGet.Commands.ISignCommandRunner
    {
        public SignCommandRunner() { }
        public System.Threading.Tasks.Task<int> ExecuteCommandAsync(NuGet.Commands.SignArgs signArgs) { throw null; }
        public System.Threading.Tasks.Task<int> ExecuteCommandAsync(System.Collections.Generic.IEnumerable<string> packagesToSign, NuGet.Packaging.Signing.SignPackageRequest signPackageRequest, string timestamper, NuGet.Common.ILogger logger, string outputDirectory, bool overwrite, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class SourceRepositoryDependencyProvider : NuGet.DependencyResolver.IRemoteDependencyProvider
    {
        public SourceRepositoryDependencyProvider(NuGet.Protocol.Core.Types.SourceRepository sourceRepository, NuGet.Common.ILogger logger, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, bool ignoreFailedSources, bool ignoreWarning) { }
        public SourceRepositoryDependencyProvider(NuGet.Protocol.Core.Types.SourceRepository sourceRepository, NuGet.Common.ILogger logger, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, bool ignoreFailedSources, bool ignoreWarning, NuGet.Protocol.LocalPackageFileCache fileCache, bool isFallbackFolderSource) { }
        public bool IsHttp { get { throw null; } }
        public NuGet.Configuration.PackageSource Source { get { throw null; } }
        public System.Threading.Tasks.Task<NuGet.LibraryModel.LibraryIdentity> FindLibraryAsync(NuGet.LibraryModel.LibraryRange libraryRange, NuGet.Frameworks.NuGetFramework targetFramework, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetAllVersionsAsync(string id, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<NuGet.LibraryModel.LibraryDependencyInfo> GetDependenciesAsync(NuGet.LibraryModel.LibraryIdentity libraryIdentity, NuGet.Frameworks.NuGetFramework targetFramework, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<NuGet.Packaging.IPackageDownloader> GetPackageDownloaderAsync(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public static partial class SpecValidationUtility
    {
        public static void ValidateDependencySpec(NuGet.ProjectModel.DependencyGraphSpec spec) { }
        public static void ValidateProjectSpec(NuGet.ProjectModel.PackageSpec spec) { }
    }
    public enum SymbolPackageFormat
    {
        Snupkg = 0,
        SymbolsNupkg = 1,
    }
    public static partial class ToolRestoreUtility
    {
        public static NuGet.ProjectModel.PackageSpec GetSpec(string projectFilePath, string id, NuGet.Versioning.VersionRange versionRange, NuGet.Frameworks.NuGetFramework framework, string packagesPath, System.Collections.Generic.IList<string> fallbackFolders, System.Collections.Generic.IList<NuGet.Configuration.PackageSource> sources, NuGet.ProjectModel.WarningProperties projectWideWarningProperties) { throw null; }
        public static System.Collections.Generic.IReadOnlyList<NuGet.Commands.RestoreSummaryRequest> GetSubSetRequests(System.Collections.Generic.IEnumerable<NuGet.Commands.RestoreSummaryRequest> requestSummaries) { throw null; }
        public static System.Collections.Generic.IReadOnlyList<NuGet.Commands.RestoreSummaryRequest> GetSubSetRequestsForSingleId(System.Collections.Generic.IEnumerable<NuGet.Commands.RestoreSummaryRequest> requests) { throw null; }
        public static NuGet.LibraryModel.LibraryDependency GetToolDependencyOrNullFromSpec(NuGet.ProjectModel.PackageSpec spec) { throw null; }
        public static string GetToolIdOrNullFromSpec(NuGet.ProjectModel.PackageSpec spec) { throw null; }
        public static NuGet.ProjectModel.LockFileTargetLibrary GetToolTargetLibrary(NuGet.ProjectModel.LockFile toolLockFile, string toolId) { throw null; }
        public static string GetUniqueName(string id, string framework, NuGet.Versioning.VersionRange versionRange) { throw null; }
    }
    public static partial class TransitiveNoWarnUtils
    {
        public static NuGet.Commands.WarningPropertiesCollection CreateTransitiveWarningPropertiesCollection(System.Collections.Generic.IEnumerable<NuGet.Commands.RestoreTargetGraph> targetGraphs, NuGet.ProjectModel.PackageSpec parentProjectSpec) { throw null; }
        public static System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode>> ExtractPackageSpecificNoWarnForFramework(NuGet.Commands.PackageSpecificWarningProperties packageSpecificWarningProperties, NuGet.Frameworks.NuGetFramework framework) { throw null; }
        public static System.Collections.Generic.Dictionary<NuGet.Frameworks.NuGetFramework, System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode>>> ExtractPackageSpecificNoWarnPerFramework(NuGet.Commands.PackageSpecificWarningProperties packageSpecificWarningProperties) { throw null; }
        public static System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode> ExtractPathNoWarnProperties(NuGet.Commands.TransitiveNoWarnUtils.NodeWarningProperties nodeWarningProperties, string libraryId) { throw null; }
        public static System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode> MergeCodes(System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode> first, System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode> second) { throw null; }
        public static System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode>> MergePackageSpecificNoWarn(System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode>> first, System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode>> second) { throw null; }
        public static NuGet.Commands.PackageSpecificWarningProperties MergePackageSpecificWarningProperties(NuGet.Commands.PackageSpecificWarningProperties first, NuGet.Commands.PackageSpecificWarningProperties second) { throw null; }
        public static bool TryMergeNullObjects<T>(T first, T second, out T merged) where T : class { throw null; }
        public partial class DependencyNode : System.IEquatable<NuGet.Commands.TransitiveNoWarnUtils.DependencyNode>
        {
            public DependencyNode(string id, bool isProject, NuGet.Commands.TransitiveNoWarnUtils.NodeWarningProperties nodeWarningProperties) { }
            public DependencyNode(string id, bool isProject, System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode> projectWideNoWarn, System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode>> packageSpecificNoWarn) { }
            public string Id { get { throw null; } }
            public bool IsProject { get { throw null; } }
            public NuGet.Commands.TransitiveNoWarnUtils.NodeWarningProperties NodeWarningProperties { get { throw null; } }
            public bool Equals(NuGet.Commands.TransitiveNoWarnUtils.DependencyNode other) { throw null; }
            public override bool Equals(object obj) { throw null; }
            public override int GetHashCode() { throw null; }
            public override string ToString() { throw null; }
        }
        public partial class NodeWarningProperties : System.IEquatable<NuGet.Commands.TransitiveNoWarnUtils.NodeWarningProperties>
        {
            public NodeWarningProperties(System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode> projectWide, System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode>> packageSpecific) { }
            public System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode>> PackageSpecific { get { throw null; } }
            public System.Collections.Generic.HashSet<NuGet.Common.NuGetLogCode> ProjectWide { get { throw null; } }
            public bool Equals(NuGet.Commands.TransitiveNoWarnUtils.NodeWarningProperties other) { throw null; }
            public override bool Equals(object obj) { throw null; }
            public override int GetHashCode() { throw null; }
            public NuGet.Commands.TransitiveNoWarnUtils.NodeWarningProperties GetIntersect(NuGet.Commands.TransitiveNoWarnUtils.NodeWarningProperties other) { throw null; }
            public bool IsSubSetOf(NuGet.Commands.TransitiveNoWarnUtils.NodeWarningProperties other) { throw null; }
        }
    }
    public sealed partial class TrustedSignerActionsProvider
    {
        public TrustedSignerActionsProvider(NuGet.Packaging.Signing.ITrustedSignersProvider trustedSignersProvider, NuGet.Common.ILogger logger) { }
        public void AddOrUpdateTrustedSigner(string name, string fingerprint, NuGet.Common.HashAlgorithmName hashAlgorithm, bool allowUntrustedRoot) { }
        public System.Threading.Tasks.Task AddTrustedRepositoryAsync(string name, System.Uri serviceIndex, System.Collections.Generic.IEnumerable<string> owners, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task SyncTrustedRepositoryAsync(string name, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class TrustedSignersArgs
    {
        public TrustedSignersArgs() { }
        public NuGet.Commands.TrustedSignersArgs.TrustedSignersAction Action { get { throw null; } set { } }
        public bool AllowUntrustedRoot { get { throw null; } set { } }
        public bool Author { get { throw null; } set { } }
        public string CertificateFingerprint { get { throw null; } set { } }
        public string FingerprintAlgorithm { get { throw null; } set { } }
        public NuGet.Common.ILogger Logger { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> Owners { get { throw null; } set { } }
        public string PackagePath { get { throw null; } set { } }
        public bool Repository { get { throw null; } set { } }
        public string ServiceIndex { get { throw null; } set { } }
        public enum TrustedSignersAction
        {
            Add = 0,
            List = 1,
            Remove = 2,
            Sync = 3,
        }
    }
    public partial class TrustedSignersCommandRunner : NuGet.Commands.ITrustedSignersCommandRunner
    {
        public TrustedSignersCommandRunner(NuGet.Packaging.Signing.ITrustedSignersProvider trustedSignersProvider, NuGet.Configuration.IPackageSourceProvider packageSourceProvider) { }
        public System.Threading.Tasks.Task<int> ExecuteCommandAsync(NuGet.Commands.TrustedSignersArgs trustedSignersArgs) { throw null; }
    }
    public static partial class UnexpectedDependencyMessages
    {
        public static bool DependencyRangeHasMissingExactMatch(NuGet.Commands.ResolvedDependencyKey dependency) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Common.RestoreLogMessage> GetBumpedUpDependencies(System.Collections.Generic.List<NuGet.Commands.IndexedRestoreTargetGraph> graphs, NuGet.ProjectModel.PackageSpec project, System.Collections.Generic.ISet<string> ignoreIds) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Common.RestoreLogMessage> GetDependenciesAboveUpperBounds(System.Collections.Generic.List<NuGet.Commands.IndexedRestoreTargetGraph> graphs, NuGet.Common.ILogger logger) { throw null; }
        public static NuGet.Common.RestoreLogMessage GetMissingLowerBoundMessage(NuGet.Commands.ResolvedDependencyKey dependency, params string[] targetGraphs) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Common.RestoreLogMessage> GetMissingLowerBounds(System.Collections.Generic.IEnumerable<NuGet.Commands.IRestoreTargetGraph> graphs, System.Collections.Generic.ISet<string> ignoreIds) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Common.RestoreLogMessage> GetProjectDependenciesMissingLowerBounds(NuGet.ProjectModel.PackageSpec project) { throw null; }
        public static bool HasMissingLowerBound(NuGet.Versioning.VersionRange range) { throw null; }
        public static System.Threading.Tasks.Task LogAsync(System.Collections.Generic.IEnumerable<NuGet.Commands.IRestoreTargetGraph> graphs, NuGet.ProjectModel.PackageSpec project, NuGet.Common.ILogger logger) { throw null; }
    }
    public static partial class UnresolvedMessages
    {
        public static System.Threading.Tasks.Task<NuGet.Common.RestoreLogMessage> GetMessageAsync(string targetGraphName, NuGet.LibraryModel.LibraryRange unresolved, System.Collections.Generic.IList<NuGet.DependencyResolver.IRemoteDependencyProvider> remoteLibraryProviders, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public static System.Threading.Tasks.Task LogAsync(System.Collections.Generic.IEnumerable<NuGet.Commands.IRestoreTargetGraph> graphs, NuGet.DependencyResolver.RemoteWalkContext context, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public static System.Threading.Tasks.Task LogAsync(System.Collections.Generic.IList<NuGet.Commands.DownloadDependencyResolutionResult> downloadDependencyResults, System.Collections.Generic.IList<NuGet.DependencyResolver.IRemoteDependencyProvider> remoteLibraryProviders, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class VerifyArgs
    {
        public VerifyArgs() { }
        public System.Collections.Generic.IEnumerable<string> CertificateFingerprint { get { throw null; } set { } }
        public NuGet.Common.ILogger Logger { get { throw null; } set { } }
        public NuGet.Common.LogLevel LogLevel { get { throw null; } set { } }
        public string PackagePath { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.Commands.VerifyArgs.Verification> Verifications { get { throw null; } set { } }
        public enum Verification
        {
            All = 1,
            Signatures = 2,
            Unknown = 0,
        }
    }
    public partial class VerifyCommandRunner : NuGet.Commands.IVerifyCommandRunner
    {
        public VerifyCommandRunner() { }
        public System.Threading.Tasks.Task<int> ExecuteCommandAsync(NuGet.Commands.VerifyArgs verifyArgs) { throw null; }
    }
    public partial class WarningPropertiesCollection : System.IEquatable<NuGet.Commands.WarningPropertiesCollection>
    {
        public WarningPropertiesCollection(NuGet.ProjectModel.WarningProperties projectWideWarningProperties, NuGet.Commands.PackageSpecificWarningProperties packageSpecificWarningProperties, System.Collections.Generic.IReadOnlyList<NuGet.Frameworks.NuGetFramework> projectFrameworks) { }
        public NuGet.Commands.PackageSpecificWarningProperties PackageSpecificWarningProperties { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.Frameworks.NuGetFramework> ProjectFrameworks { get { throw null; } }
        public NuGet.ProjectModel.WarningProperties ProjectWideWarningProperties { get { throw null; } }
        public bool ApplyNoWarnProperties(NuGet.Common.IRestoreLogMessage message) { throw null; }
        public static bool ApplyProjectWideNoWarnProperties(NuGet.Common.ILogMessage message, NuGet.ProjectModel.WarningProperties warningProperties) { throw null; }
        public static void ApplyProjectWideWarningsAsErrorProperties(NuGet.Common.ILogMessage message, NuGet.ProjectModel.WarningProperties warningProperties) { }
        public void ApplyWarningAsErrorProperties(NuGet.Common.IRestoreLogMessage message) { }
        public bool ApplyWarningProperties(NuGet.Common.IRestoreLogMessage message) { throw null; }
        public bool Equals(NuGet.Commands.WarningPropertiesCollection other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
}
namespace NuGet.Commands.SignCommand
{
    public partial interface IPasswordProvider
    {
    }
}
