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
[assembly: AssemblyTitle("NuGet.DependencyResolver.Core")]
[assembly: AssemblyDescription("NuGet.DependencyResolver.Core")]
[assembly: AssemblyDefaultAlias("NuGet.DependencyResolver.Core")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("5.1.0.6013")]
[assembly: AssemblyInformationalVersion("5.1.0.6013 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("5.1.0.5")]




namespace NuGet.DependencyResolver
{
    public partial class AnalyzeResult<TItem>
    {
        public AnalyzeResult() { }
        public System.Collections.Generic.List<NuGet.DependencyResolver.GraphNode<TItem>> Cycles { get { throw null; } }
        public System.Collections.Generic.List<NuGet.DependencyResolver.DowngradeResult<TItem>> Downgrades { get { throw null; } }
        public System.Collections.Generic.List<NuGet.DependencyResolver.VersionConflictResult<TItem>> VersionConflicts { get { throw null; } }
        public void Combine(NuGet.DependencyResolver.AnalyzeResult<TItem> result) { }
    }
    public enum Disposition
    {
        Acceptable = 0,
        Accepted = 2,
        Cycle = 4,
        PotentiallyDowngraded = 3,
        Rejected = 1,
    }
    public partial class DowngradeResult<TItem>
    {
        public DowngradeResult() { }
        public NuGet.DependencyResolver.GraphNode<TItem> DowngradedFrom { get { throw null; } set { } }
        public NuGet.DependencyResolver.GraphNode<TItem> DowngradedTo { get { throw null; } set { } }
    }
    public partial class GraphEdge<TItem>
    {
        public GraphEdge(NuGet.DependencyResolver.GraphEdge<TItem> outerEdge, NuGet.DependencyResolver.GraphItem<TItem> item, NuGet.LibraryModel.LibraryDependency edge) { }
        public NuGet.LibraryModel.LibraryDependency Edge { get { throw null; } }
        public NuGet.DependencyResolver.GraphItem<TItem> Item { get { throw null; } }
        public NuGet.DependencyResolver.GraphEdge<TItem> OuterEdge { get { throw null; } }
    }
    public partial class GraphItem<TItem> : System.IEquatable<NuGet.DependencyResolver.GraphItem<TItem>>
    {
        public GraphItem(NuGet.LibraryModel.LibraryIdentity key) { }
        public TItem Data { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryIdentity Key { get { throw null; } set { } }
        public bool Equals(NuGet.DependencyResolver.GraphItem<TItem> other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class GraphNode<TItem>
    {
        public GraphNode(NuGet.LibraryModel.LibraryRange key) { }
        public NuGet.DependencyResolver.Disposition Disposition { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.DependencyResolver.GraphNode<TItem>> InnerNodes { get { throw null; } set { } }
        public NuGet.DependencyResolver.GraphItem<TItem> Item { get { throw null; } set { } }
        public NuGet.LibraryModel.LibraryRange Key { get { throw null; } set { } }
        public NuGet.DependencyResolver.GraphNode<TItem> OuterNode { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    public static partial class GraphOperations
    {
        public static NuGet.DependencyResolver.AnalyzeResult<NuGet.DependencyResolver.RemoteResolveResult> Analyze(this NuGet.DependencyResolver.GraphNode<NuGet.DependencyResolver.RemoteResolveResult> root) { throw null; }
        public static void Dump<TItem>(this NuGet.DependencyResolver.GraphNode<TItem> root, System.Action<string> write) { }
        public static void ForEach<TItem>(this NuGet.DependencyResolver.GraphNode<TItem> root, System.Action<NuGet.DependencyResolver.GraphNode<TItem>> visitor) { }
        public static void ForEach<TItem>(this System.Collections.Generic.IEnumerable<NuGet.DependencyResolver.GraphNode<TItem>> roots, System.Action<NuGet.DependencyResolver.GraphNode<TItem>> visitor) { }
        public static void ForEach<TItem, TContext>(this NuGet.DependencyResolver.GraphNode<TItem> root, System.Action<NuGet.DependencyResolver.GraphNode<TItem>, TContext> visitor, TContext context) { }
        public static string GetIdAndRange<TItem>(this NuGet.DependencyResolver.GraphNode<TItem> node) { throw null; }
        public static string GetIdAndVersionOrRange<TItem>(this NuGet.DependencyResolver.GraphNode<TItem> node) { throw null; }
        public static string GetId<TItem>(this NuGet.DependencyResolver.GraphNode<TItem> node) { throw null; }
        public static string GetPathWithLastRange<TItem>(this NuGet.DependencyResolver.GraphNode<TItem> node) { throw null; }
        public static string GetPath<TItem>(this NuGet.DependencyResolver.GraphNode<TItem> node) { throw null; }
        public static NuGet.Versioning.NuGetVersion GetVersionOrDefault<TItem>(this NuGet.DependencyResolver.GraphNode<TItem> node) { throw null; }
        public static NuGet.Versioning.VersionRange GetVersionRange<TItem>(this NuGet.DependencyResolver.GraphNode<TItem> node) { throw null; }
        public static bool IsPackage<TItem>(this NuGet.DependencyResolver.GraphNode<TItem> node) { throw null; }
        public static NuGet.DependencyResolver.GraphNode<TItem> Path<TItem>(this NuGet.DependencyResolver.GraphNode<TItem> node, params string[] path) { throw null; }
        public static void ReleaseDowngradesDictionary(System.Collections.Generic.Dictionary<NuGet.DependencyResolver.GraphNode<NuGet.DependencyResolver.RemoteResolveResult>, NuGet.DependencyResolver.GraphNode<NuGet.DependencyResolver.RemoteResolveResult>> dictionary) { }
        public static System.Collections.Generic.Dictionary<NuGet.DependencyResolver.GraphNode<NuGet.DependencyResolver.RemoteResolveResult>, NuGet.DependencyResolver.GraphNode<NuGet.DependencyResolver.RemoteResolveResult>> RentDowngradesDictionary() { throw null; }
    }
    public partial interface IDependencyProvider
    {
        NuGet.LibraryModel.Library GetLibrary(NuGet.LibraryModel.LibraryRange libraryRange, NuGet.Frameworks.NuGetFramework targetFramework);
        bool SupportsType(NuGet.LibraryModel.LibraryDependencyTarget libraryTypeFlag);
    }
    public partial interface IRemoteDependencyProvider
    {
        bool IsHttp { get; }
        NuGet.Configuration.PackageSource Source { get; }
        System.Threading.Tasks.Task<NuGet.LibraryModel.LibraryIdentity> FindLibraryAsync(NuGet.LibraryModel.LibraryRange libraryRange, NuGet.Frameworks.NuGetFramework targetFramework, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetAllVersionsAsync(string id, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken token);
        System.Threading.Tasks.Task<NuGet.LibraryModel.LibraryDependencyInfo> GetDependenciesAsync(NuGet.LibraryModel.LibraryIdentity libraryIdentity, NuGet.Frameworks.NuGetFramework targetFramework, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<NuGet.Packaging.IPackageDownloader> GetPackageDownloaderAsync(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken);
    }
    public partial class LibraryRangeCacheKey : System.IEquatable<NuGet.DependencyResolver.LibraryRangeCacheKey>
    {
        public LibraryRangeCacheKey(NuGet.LibraryModel.LibraryRange range, NuGet.Frameworks.NuGetFramework framework) { }
        public NuGet.Frameworks.NuGetFramework Framework { get { throw null; } }
        public NuGet.LibraryModel.LibraryRange LibraryRange { get { throw null; } }
        public bool Equals(NuGet.DependencyResolver.LibraryRangeCacheKey other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LocalDependencyProvider : NuGet.DependencyResolver.IRemoteDependencyProvider
    {
        public LocalDependencyProvider(NuGet.DependencyResolver.IDependencyProvider dependencyProvider) { }
        public bool IsHttp { get { throw null; } }
        public NuGet.Configuration.PackageSource Source { get { throw null; } }
        public System.Threading.Tasks.Task<NuGet.LibraryModel.LibraryIdentity> FindLibraryAsync(NuGet.LibraryModel.LibraryRange libraryRange, NuGet.Frameworks.NuGetFramework targetFramework, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetAllVersionsAsync(string id, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<NuGet.LibraryModel.LibraryDependencyInfo> GetDependenciesAsync(NuGet.LibraryModel.LibraryIdentity libraryIdentity, NuGet.Frameworks.NuGetFramework targetFramework, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<NuGet.Packaging.IPackageDownloader> GetPackageDownloaderAsync(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class LocalMatch : NuGet.DependencyResolver.RemoteMatch
    {
        public LocalMatch() { }
        public NuGet.LibraryModel.Library LocalLibrary { get { throw null; } set { } }
        public NuGet.DependencyResolver.IDependencyProvider LocalProvider { get { throw null; } set { } }
    }
    public partial class LockFileCacheKey : System.IEquatable<NuGet.DependencyResolver.LockFileCacheKey>
    {
        public LockFileCacheKey(NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier) { }
        public string Name { get { throw null; } }
        public string RuntimeIdentifier { get { throw null; } }
        public NuGet.Frameworks.NuGetFramework TargetFramework { get { throw null; } }
        public bool Equals(NuGet.DependencyResolver.LockFileCacheKey other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class PackagingUtility
    {
        public static NuGet.LibraryModel.LibraryDependency GetLibraryDependencyFromNuspec(NuGet.Packaging.Core.PackageDependency dependency) { throw null; }
    }
    public partial class RemoteDependencyWalker
    {
        public RemoteDependencyWalker(NuGet.DependencyResolver.RemoteWalkContext context) { }
        public static bool IsGreaterThanOrEqualTo(NuGet.Versioning.VersionRange nearVersion, NuGet.Versioning.VersionRange farVersion) { throw null; }
        public System.Threading.Tasks.Task<NuGet.DependencyResolver.GraphNode<NuGet.DependencyResolver.RemoteResolveResult>> WalkAsync(NuGet.LibraryModel.LibraryRange library, NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier, NuGet.RuntimeModel.RuntimeGraph runtimeGraph, bool recursive) { throw null; }
    }
    public partial class RemoteMatch : System.IEquatable<NuGet.DependencyResolver.RemoteMatch>
    {
        public RemoteMatch() { }
        public NuGet.LibraryModel.LibraryIdentity Library { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public NuGet.DependencyResolver.IRemoteDependencyProvider Provider { get { throw null; } set { } }
        public bool Equals(NuGet.DependencyResolver.RemoteMatch other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class RemoteResolveResult
    {
        public RemoteResolveResult() { }
        public System.Collections.Generic.IEnumerable<NuGet.LibraryModel.LibraryDependency> Dependencies { get { throw null; } set { } }
        public NuGet.DependencyResolver.RemoteMatch Match { get { throw null; } set { } }
    }
    public partial class RemoteWalkContext
    {
        public RemoteWalkContext(NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger) { }
        public NuGet.Protocol.Core.Types.SourceCacheContext CacheContext { get { throw null; } }
        public System.Collections.Concurrent.ConcurrentDictionary<NuGet.DependencyResolver.LibraryRangeCacheKey, System.Threading.Tasks.Task<NuGet.DependencyResolver.GraphItem<NuGet.DependencyResolver.RemoteResolveResult>>> FindLibraryEntryCache { get { throw null; } }
        public bool IsMsBuildBased { get { throw null; } set { } }
        public System.Collections.Generic.IList<NuGet.DependencyResolver.IRemoteDependencyProvider> LocalLibraryProviders { get { throw null; } }
        public System.Collections.Generic.IDictionary<NuGet.DependencyResolver.LockFileCacheKey, System.Collections.Generic.IList<NuGet.LibraryModel.LibraryIdentity>> LockFileLibraries { get { throw null; } }
        public NuGet.Common.ILogger Logger { get { throw null; } }
        public System.Collections.Generic.IList<NuGet.DependencyResolver.IDependencyProvider> ProjectLibraryProviders { get { throw null; } }
        public System.Collections.Generic.IList<NuGet.DependencyResolver.IRemoteDependencyProvider> RemoteLibraryProviders { get { throw null; } }
    }
    public static partial class ResolverUtility
    {
        public static System.Threading.Tasks.Task<NuGet.DependencyResolver.RemoteMatch> FindLibraryByVersionAsync(NuGet.LibraryModel.LibraryRange libraryRange, NuGet.Frameworks.NuGetFramework framework, System.Collections.Generic.IEnumerable<NuGet.DependencyResolver.IRemoteDependencyProvider> providers, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public static System.Threading.Tasks.Task<NuGet.DependencyResolver.GraphItem<NuGet.DependencyResolver.RemoteResolveResult>> FindLibraryCachedAsync(System.Collections.Concurrent.ConcurrentDictionary<NuGet.DependencyResolver.LibraryRangeCacheKey, System.Threading.Tasks.Task<NuGet.DependencyResolver.GraphItem<NuGet.DependencyResolver.RemoteResolveResult>>> cache, NuGet.LibraryModel.LibraryRange libraryRange, NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier, NuGet.DependencyResolver.RemoteWalkContext context, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<NuGet.DependencyResolver.GraphItem<NuGet.DependencyResolver.RemoteResolveResult>> FindLibraryEntryAsync(NuGet.LibraryModel.LibraryRange libraryRange, NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier, NuGet.DependencyResolver.RemoteWalkContext context, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<NuGet.DependencyResolver.RemoteMatch> FindLibraryMatchAsync(NuGet.LibraryModel.LibraryRange libraryRange, NuGet.Frameworks.NuGetFramework framework, string runtimeIdentifier, System.Collections.Generic.IEnumerable<NuGet.DependencyResolver.IRemoteDependencyProvider> remoteProviders, System.Collections.Generic.IEnumerable<NuGet.DependencyResolver.IRemoteDependencyProvider> localProviders, System.Collections.Generic.IEnumerable<NuGet.DependencyResolver.IDependencyProvider> projectProviders, System.Collections.Generic.IDictionary<NuGet.DependencyResolver.LockFileCacheKey, System.Collections.Generic.IList<NuGet.LibraryModel.LibraryIdentity>> lockFileLibraries, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<System.Tuple<NuGet.LibraryModel.LibraryRange, NuGet.DependencyResolver.RemoteMatch>> FindPackageLibraryMatchCachedAsync(System.Collections.Concurrent.ConcurrentDictionary<NuGet.LibraryModel.LibraryRange, System.Threading.Tasks.Task<System.Tuple<NuGet.LibraryModel.LibraryRange, NuGet.DependencyResolver.RemoteMatch>>> cache, NuGet.LibraryModel.LibraryRange libraryRange, System.Collections.Generic.IEnumerable<NuGet.DependencyResolver.IRemoteDependencyProvider> remoteProviders, System.Collections.Generic.IEnumerable<NuGet.DependencyResolver.IRemoteDependencyProvider> localProviders, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<NuGet.DependencyResolver.RemoteMatch> FindProjectMatchAsync(NuGet.LibraryModel.LibraryRange libraryRange, NuGet.Frameworks.NuGetFramework framework, System.Collections.Generic.IEnumerable<NuGet.DependencyResolver.IDependencyProvider> projectProviders, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class Tracker<TItem>
    {
        public Tracker() { }
        public System.Collections.Generic.IEnumerable<NuGet.DependencyResolver.GraphItem<TItem>> GetDisputes(NuGet.DependencyResolver.GraphItem<TItem> item) { throw null; }
        public bool IsAmbiguous(NuGet.DependencyResolver.GraphItem<TItem> item) { throw null; }
        public bool IsBestVersion(NuGet.DependencyResolver.GraphItem<TItem> item) { throw null; }
        public bool IsDisputed(NuGet.DependencyResolver.GraphItem<TItem> item) { throw null; }
        public void MarkAmbiguous(NuGet.DependencyResolver.GraphItem<TItem> item) { }
        public void Track(NuGet.DependencyResolver.GraphItem<TItem> item) { }
    }
    public partial class VersionConflictResult<TItem>
    {
        public VersionConflictResult() { }
        public NuGet.DependencyResolver.GraphNode<TItem> Conflicting { get { throw null; } set { } }
        public NuGet.DependencyResolver.GraphNode<TItem> Selected { get { throw null; } set { } }
    }
}
