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
[assembly: AssemblyTitle("NuGet.Protocol")]
[assembly: AssemblyDescription("NuGet.Protocol")]
[assembly: AssemblyDefaultAlias("NuGet.Protocol")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("5.1.0.6013")]
[assembly: AssemblyInformationalVersion("5.1.0.6013 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("5.1.0.5")]




namespace NuGet.Protocol
{
    public partial class AmbientAuthenticationState
    {
        public AmbientAuthenticationState() { }
        public int AuthenticationRetriesCount { get { throw null; } }
        public bool IsBlocked { get { throw null; } }
        public void Block() { }
        public void Increment() { }
    }
    public partial class AutoCompleteResourceV2Feed : NuGet.Protocol.Core.Types.AutoCompleteResource
    {
        public AutoCompleteResourceV2Feed(NuGet.Protocol.HttpSourceResource httpSourceResource, string baseAddress, NuGet.Configuration.PackageSource packageSource) { }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> IdStartsWith(string packageIdPrefix, bool includePrerelease, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> VersionStartsWith(string packageId, string versionPrefix, bool includePrerelease, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class AutoCompleteResourceV2FeedProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public AutoCompleteResourceV2FeedProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class AutoCompleteResourceV3 : NuGet.Protocol.Core.Types.AutoCompleteResource
    {
        public AutoCompleteResourceV3(NuGet.Protocol.HttpSource client, NuGet.Protocol.ServiceIndexResourceV3 serviceIndex, NuGet.Protocol.RegistrationResourceV3 regResource) { }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> IdStartsWith(string packageIdPrefix, bool includePrerelease, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> VersionStartsWith(string packageId, string versionPrefix, bool includePrerelease, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class AutoCompleteResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public AutoCompleteResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class CachingSourceProvider : NuGet.Protocol.Core.Types.ISourceRepositoryProvider
    {
        public CachingSourceProvider(NuGet.Configuration.IPackageSourceProvider packageSourceProvider) { }
        public NuGet.Configuration.IPackageSourceProvider PackageSourceProvider { get { throw null; } }
        public void AddSourceRepository(NuGet.Protocol.Core.Types.SourceRepository source) { }
        public NuGet.Protocol.Core.Types.SourceRepository CreateRepository(NuGet.Configuration.PackageSource source) { throw null; }
        public NuGet.Protocol.Core.Types.SourceRepository CreateRepository(NuGet.Configuration.PackageSource source, NuGet.Protocol.FeedType type) { throw null; }
        public NuGet.Protocol.Core.Types.SourceRepository CreateRepository(string source) { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.SourceRepository> GetRepositories() { throw null; }
    }
    public partial class CachingUtility
    {
        public const int BufferSize = 8192;
        public CachingUtility() { }
        public static string ComputeHash(string value, bool addIdentifiableCharacters = true) { throw null; }
        public static bool IsFileAlreadyOpen(string filePath) { throw null; }
        public static System.IO.Stream ReadCacheFile(System.TimeSpan maxAge, string cacheFile) { throw null; }
        public static string RemoveInvalidFileNameChars(string value) { throw null; }
    }
    public partial class DependencyInfoResourceV2Feed : NuGet.Protocol.Core.Types.DependencyInfoResource
    {
        public DependencyInfoResourceV2Feed(NuGet.Protocol.V2FeedParser feedParser, NuGet.Protocol.Core.Types.SourceRepository source) { }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.SourcePackageDependencyInfo> ResolvePackage(NuGet.Packaging.Core.PackageIdentity package, NuGet.Frameworks.NuGetFramework projectFramework, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.SourcePackageDependencyInfo>> ResolvePackages(string packageId, NuGet.Frameworks.NuGetFramework projectFramework, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class DependencyInfoResourceV2FeedProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public DependencyInfoResourceV2FeedProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public sealed partial class DependencyInfoResourceV3 : NuGet.Protocol.Core.Types.DependencyInfoResource
    {
        public DependencyInfoResourceV3(NuGet.Protocol.HttpSource client, NuGet.Protocol.RegistrationResourceV3 regResource, NuGet.Protocol.Core.Types.SourceRepository source) { }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.SourcePackageDependencyInfo> ResolvePackage(NuGet.Packaging.Core.PackageIdentity package, NuGet.Frameworks.NuGetFramework projectFramework, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.SourcePackageDependencyInfo>> ResolvePackages(string packageId, NuGet.Frameworks.NuGetFramework projectFramework, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.RemoteSourceDependencyInfo>> ResolvePackages(string packageId, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class DependencyInfoResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public DependencyInfoResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public sealed partial class DownloadResourcePlugin : NuGet.Protocol.Core.Types.DownloadResource
    {
        public DownloadResourcePlugin(NuGet.Protocol.Plugins.IPlugin plugin, NuGet.Protocol.Plugins.IPluginMulticlientUtilities utilities, NuGet.Configuration.PackageSource packageSource) { }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.DownloadResourceResult> GetDownloadResourceResultAsync(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Protocol.Core.Types.PackageDownloadContext downloadContext, string globalPackagesFolder, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class DownloadResourcePluginProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public DownloadResourcePluginProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class DownloadResourceV2Feed : NuGet.Protocol.Core.Types.DownloadResource
    {
        public DownloadResourceV2Feed(NuGet.Protocol.V2FeedParser feedParser) { }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.DownloadResourceResult> GetDownloadResourceResultAsync(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Protocol.Core.Types.PackageDownloadContext downloadContext, string globalPackagesFolder, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class DownloadResourceV2FeedProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public DownloadResourceV2FeedProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class DownloadResourceV3 : NuGet.Protocol.Core.Types.DownloadResource
    {
        public DownloadResourceV3(NuGet.Protocol.HttpSource client, NuGet.Protocol.RegistrationResourceV3 regResource) { }
        public DownloadResourceV3(NuGet.Protocol.HttpSource client, string packageBaseAddress) { }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.DownloadResourceResult> GetDownloadResourceResultAsync(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Protocol.Core.Types.PackageDownloadContext downloadContext, string globalPackagesFolder, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class DownloadResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public DownloadResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class DownloadTimeoutStream : System.IO.Stream
    {
        public DownloadTimeoutStream(string downloadName, System.IO.Stream networkStream, System.TimeSpan timeout) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }
    public partial class DownloadTimeoutStreamContent : System.Net.Http.StreamContent
    {
        public DownloadTimeoutStreamContent(string downloadName, System.IO.Stream networkStream, System.TimeSpan timeout) : base (default(System.IO.Stream)) { }
    }
    public static partial class FactoryExtensionsV3
    {
        public static NuGet.Protocol.Core.Types.SourceRepository GetCoreV2(this NuGet.Protocol.Core.Types.Repository.RepositoryFactory factory, NuGet.Configuration.PackageSource source) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Lazy<NuGet.Protocol.Core.Types.INuGetResourceProvider>> GetCoreV3(this NuGet.Protocol.Core.Types.Repository.ProviderFactory factory) { throw null; }
        public static NuGet.Protocol.Core.Types.SourceRepository GetCoreV3(this NuGet.Protocol.Core.Types.Repository.RepositoryFactory factory, string source) { throw null; }
        public static NuGet.Protocol.Core.Types.SourceRepository GetCoreV3(this NuGet.Protocol.Core.Types.Repository.RepositoryFactory factory, string source, NuGet.Protocol.FeedType type) { throw null; }
    }
    public enum FeedType
    {
        FileSystemPackagesConfig = 32,
        FileSystemUnknown = 1024,
        FileSystemUnzipped = 16,
        FileSystemV2 = 4,
        FileSystemV3 = 8,
        HttpV2 = 1,
        HttpV3 = 2,
        Undefined = 0,
    }
    public partial class FeedTypePackageSource : NuGet.Configuration.PackageSource
    {
        public FeedTypePackageSource(string source, NuGet.Protocol.FeedType feedType) : base (default(string)) { }
        public NuGet.Protocol.FeedType FeedType { get { throw null; } }
    }
    public partial class FeedTypeResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        public FeedTypeResource(NuGet.Protocol.FeedType feedType) { }
        public NuGet.Protocol.FeedType FeedType { get { throw null; } }
    }
    public partial class FeedTypeResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public FeedTypeResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public static partial class FeedTypeUtility
    {
        public static NuGet.Protocol.FeedType GetFeedType(NuGet.Configuration.PackageSource packageSource) { throw null; }
    }
    public abstract partial class FindLocalPackagesResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        protected FindLocalPackagesResource() { }
        public string Root { get { throw null; } protected set { } }
        public virtual bool Exists(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public virtual bool Exists(string packageId, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public abstract System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> FindPackagesById(string id, NuGet.Common.ILogger logger, System.Threading.CancellationToken token);
        public abstract NuGet.Protocol.LocalPackageInfo GetPackage(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Common.ILogger logger, System.Threading.CancellationToken token);
        public abstract NuGet.Protocol.LocalPackageInfo GetPackage(System.Uri path, NuGet.Common.ILogger logger, System.Threading.CancellationToken token);
        public abstract System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> GetPackages(NuGet.Common.ILogger logger, System.Threading.CancellationToken token);
    }
    public partial class FindLocalPackagesResourcePackagesConfig : NuGet.Protocol.FindLocalPackagesResource
    {
        public FindLocalPackagesResourcePackagesConfig(string root) { }
        public override System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> FindPackagesById(string id, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override NuGet.Protocol.LocalPackageInfo GetPackage(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override NuGet.Protocol.LocalPackageInfo GetPackage(System.Uri path, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> GetPackages(NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class FindLocalPackagesResourcePackagesConfigProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public FindLocalPackagesResourcePackagesConfigProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class FindLocalPackagesResourceUnzipped : NuGet.Protocol.FindLocalPackagesResource
    {
        public FindLocalPackagesResourceUnzipped(string root) { }
        public override bool Exists(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> FindPackagesById(string id, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override NuGet.Protocol.LocalPackageInfo GetPackage(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override NuGet.Protocol.LocalPackageInfo GetPackage(System.Uri path, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> GetPackages(NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class FindLocalPackagesResourceUnzippedProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public FindLocalPackagesResourceUnzippedProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class FindLocalPackagesResourceV2 : NuGet.Protocol.FindLocalPackagesResource
    {
        public FindLocalPackagesResourceV2(string root) { }
        public override System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> FindPackagesById(string id, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override NuGet.Protocol.LocalPackageInfo GetPackage(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override NuGet.Protocol.LocalPackageInfo GetPackage(System.Uri path, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> GetPackages(NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class FindLocalPackagesResourceV2Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public FindLocalPackagesResourceV2Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class FindLocalPackagesResourceV3 : NuGet.Protocol.FindLocalPackagesResource
    {
        public FindLocalPackagesResourceV3(string root) { }
        public override System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> FindPackagesById(string id, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override NuGet.Protocol.LocalPackageInfo GetPackage(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override NuGet.Protocol.LocalPackageInfo GetPackage(System.Uri path, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> GetPackages(NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class FindLocalPackagesResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public FindLocalPackagesResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class FindPackagesByIdNupkgDownloader
    {
        public FindPackagesByIdNupkgDownloader(NuGet.Protocol.HttpSource httpSource) { }
        public System.Threading.Tasks.Task<bool> CopyNupkgToStreamAsync(NuGet.Packaging.Core.PackageIdentity identity, string url, System.IO.Stream destination, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<NuGet.Packaging.NuspecReader> GetNuspecReaderFromNupkgAsync(NuGet.Packaging.Core.PackageIdentity identity, string url, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class FingerprintsConverter : Newtonsoft.Json.JsonConverter
    {
        public FingerprintsConverter() { }
        public override bool CanWrite { get { throw null; } }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public static partial class GetDownloadResultUtility
    {
        public static void CleanUpDirectDownloads(NuGet.Protocol.Core.Types.PackageDownloadContext downloadContext) { }
        public static System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.DownloadResourceResult> GetDownloadResultAsync(NuGet.Protocol.HttpSource client, NuGet.Packaging.Core.PackageIdentity identity, System.Uri uri, NuGet.Protocol.Core.Types.PackageDownloadContext downloadContext, string globalPackagesFolder, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
    public static partial class GlobalPackagesFolderUtility
    {
        public static System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.DownloadResourceResult> AddPackageAsync(string source, NuGet.Packaging.Core.PackageIdentity packageIdentity, System.IO.Stream packageStream, string globalPackagesFolder, System.Guid parentId, NuGet.Packaging.Signing.ClientPolicyContext clientPolicyContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public static NuGet.Protocol.Core.Types.DownloadResourceResult GetPackage(NuGet.Packaging.Core.PackageIdentity packageIdentity, string globalPackagesFolder) { throw null; }
    }
    public partial class HttpCacheResult
    {
        public HttpCacheResult(System.TimeSpan maxAge, string newFile, string cacheFule) { }
        public string CacheFile { get { throw null; } }
        public System.TimeSpan MaxAge { get { throw null; } }
        public string NewFile { get { throw null; } }
        public System.IO.Stream Stream { get { throw null; } set { } }
    }
    public static partial class HttpCacheUtility
    {
        public static System.Threading.Tasks.Task CreateCacheFileAsync(NuGet.Protocol.HttpCacheResult result, System.Net.Http.HttpResponseMessage response, System.Action<System.IO.Stream> ensureValidContents, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static NuGet.Protocol.HttpCacheResult InitializeHttpCacheResult(string httpCacheDirectory, System.Uri sourceUri, string cacheKey, NuGet.Protocol.Core.Types.HttpSourceCacheContext context) { throw null; }
    }
    public partial class HttpFileSystemBasedFindPackageByIdResource : NuGet.Protocol.Core.Types.FindPackageByIdResource
    {
        public HttpFileSystemBasedFindPackageByIdResource(System.Collections.Generic.IReadOnlyList<System.Uri> baseUris, NuGet.Protocol.HttpSource httpSource) { }
        public override System.Threading.Tasks.Task<bool> CopyNupkgToStreamAsync(string id, NuGet.Versioning.NuGetVersion version, System.IO.Stream destination, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<bool> DoesPackageExistAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetAllVersionsAsync(string id, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.FindPackageByIdDependencyInfo> GetDependencyInfoAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Packaging.IPackageDownloader> GetPackageDownloaderAsync(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class HttpFileSystemBasedFindPackageByIdResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public HttpFileSystemBasedFindPackageByIdResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository sourceRepository, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class HttpHandlerResourceV3 : NuGet.Protocol.Core.Types.HttpHandlerResource
    {
        public HttpHandlerResourceV3(System.Net.Http.HttpClientHandler clientHandler, System.Net.Http.HttpMessageHandler messageHandler) { }
        public override System.Net.Http.HttpClientHandler ClientHandler { get { throw null; } }
        public static System.Lazy<NuGet.Configuration.ICredentialService> CredentialService { get { throw null; } set { } }
        public static System.Action<System.Uri, System.Net.ICredentials> CredentialsSuccessfullyUsed { get { throw null; } set { } }
        public override System.Net.Http.HttpMessageHandler MessageHandler { get { throw null; } }
    }
    public partial class HttpHandlerResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public HttpHandlerResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class HttpRequestMessageConfiguration
    {
        public static readonly NuGet.Protocol.HttpRequestMessageConfiguration Default;
        public HttpRequestMessageConfiguration(NuGet.Common.ILogger logger = null, bool promptOn403 = true) { }
        public NuGet.Common.ILogger Logger { get { throw null; } }
        public bool PromptOn403 { get { throw null; } }
    }
    public static partial class HttpRequestMessageExtensions
    {
        public static NuGet.Protocol.HttpRequestMessageConfiguration GetOrCreateConfiguration(this System.Net.Http.HttpRequestMessage request) { throw null; }
        public static void SetConfiguration(this System.Net.Http.HttpRequestMessage request, NuGet.Protocol.HttpRequestMessageConfiguration configuration) { }
    }
    public static partial class HttpRequestMessageFactory
    {
        public static System.Net.Http.HttpRequestMessage Create(System.Net.Http.HttpMethod method, string requestUri, NuGet.Common.ILogger log) { throw null; }
        public static System.Net.Http.HttpRequestMessage Create(System.Net.Http.HttpMethod method, string requestUri, NuGet.Protocol.HttpRequestMessageConfiguration configuration) { throw null; }
        public static System.Net.Http.HttpRequestMessage Create(System.Net.Http.HttpMethod method, System.Uri requestUri, NuGet.Common.ILogger log) { throw null; }
        public static System.Net.Http.HttpRequestMessage Create(System.Net.Http.HttpMethod method, System.Uri requestUri, NuGet.Protocol.HttpRequestMessageConfiguration configuration) { throw null; }
    }
    public static partial class HttpResponseMessageExtensions
    {
        public static void LogServerWarning(this System.Net.Http.HttpResponseMessage response, NuGet.Common.ILogger log) { }
    }
    public partial class HttpRetryHandler : NuGet.Protocol.IHttpRetryHandler
    {
        public HttpRetryHandler() { }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(NuGet.Protocol.HttpRetryHandlerRequest request, NuGet.Common.ILogger log, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class HttpRetryHandlerRequest
    {
        public static readonly System.TimeSpan DefaultDownloadTimeout;
        public static readonly int DefaultMaxTries;
        public HttpRetryHandlerRequest(System.Net.Http.HttpClient httpClient, System.Func<System.Net.Http.HttpRequestMessage> requestFactory) { }
        public System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IEnumerable<string>>> AddHeaders { get { throw null; } set { } }
        public System.Net.Http.HttpCompletionOption CompletionOption { get { throw null; } set { } }
        public System.TimeSpan DownloadTimeout { get { throw null; } set { } }
        public System.Net.Http.HttpClient HttpClient { get { throw null; } }
        public int MaxTries { get { throw null; } set { } }
        public System.Func<System.Net.Http.HttpRequestMessage> RequestFactory { get { throw null; } }
        public System.TimeSpan RequestTimeout { get { throw null; } set { } }
        public System.TimeSpan RetryDelay { get { throw null; } set { } }
    }
    public partial class HttpSource : System.IDisposable
    {
        public HttpSource(NuGet.Configuration.PackageSource packageSource, System.Func<System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.HttpHandlerResource>> messageHandlerFactory, NuGet.Protocol.IThrottle throttle) { }
        public string HttpCacheDirectory { get { throw null; } set { } }
        public string PackageSource { get { throw null; } }
        public NuGet.Protocol.IHttpRetryHandler RetryHandler { get { throw null; } set { } }
        public static NuGet.Protocol.HttpSource Create(NuGet.Protocol.Core.Types.SourceRepository source) { throw null; }
        public static NuGet.Protocol.HttpSource Create(NuGet.Protocol.Core.Types.SourceRepository source, NuGet.Protocol.IThrottle throttle) { throw null; }
        public void Dispose() { }
        public virtual System.Threading.Tasks.Task<T> GetAsync<T>(NuGet.Protocol.HttpSourceCachedRequest request, System.Func<NuGet.Protocol.HttpSourceResult, System.Threading.Tasks.Task<T>> processAsync, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JObject> GetJObjectAsync(NuGet.Protocol.HttpSourceRequest request, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<T> ProcessResponseAsync<T>(NuGet.Protocol.HttpSourceRequest request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<T>> processAsync, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<T> ProcessResponseAsync<T>(NuGet.Protocol.HttpSourceRequest request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<T>> processAsync, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<T> ProcessStreamAsync<T>(NuGet.Protocol.HttpSourceRequest request, System.Func<System.IO.Stream, System.Threading.Tasks.Task<T>> processAsync, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<T> ProcessStreamAsync<T>(NuGet.Protocol.HttpSourceRequest request, System.Func<System.IO.Stream, System.Threading.Tasks.Task<T>> processAsync, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        protected virtual System.IO.Stream TryReadCacheFile(string uri, System.TimeSpan maxAge, string cacheFile) { throw null; }
    }
    public partial class HttpSourceAuthenticationHandler : System.Net.Http.DelegatingHandler
    {
        public static readonly int MaxAuthRetries;
        public HttpSourceAuthenticationHandler(NuGet.Configuration.PackageSource packageSource, System.Net.Http.HttpClientHandler clientHandler, NuGet.Configuration.ICredentialService credentialService) { }
        protected override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class HttpSourceCachedRequest
    {
        public HttpSourceCachedRequest(string uri, string cacheKey, NuGet.Protocol.Core.Types.HttpSourceCacheContext cacheContext) { }
        public System.Collections.Generic.IList<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue> AcceptHeaderValues { get { throw null; } }
        public NuGet.Protocol.Core.Types.HttpSourceCacheContext CacheContext { get { throw null; } }
        public string CacheKey { get { throw null; } }
        public System.TimeSpan DownloadTimeout { get { throw null; } set { } }
        public System.Action<System.IO.Stream> EnsureValidContents { get { throw null; } set { } }
        public bool IgnoreNotFounds { get { throw null; } set { } }
        public int MaxTries { get { throw null; } set { } }
        public System.TimeSpan RequestTimeout { get { throw null; } set { } }
        public string Uri { get { throw null; } }
    }
    public partial class HttpSourceCredentials : System.Net.CredentialCache, System.Net.ICredentials
    {
        public HttpSourceCredentials() { }
        public HttpSourceCredentials(System.Net.ICredentials credentials = null) { }
        public System.Net.ICredentials Credentials { get { throw null; } set { } }
        public System.Guid Version { get { throw null; } }
        System.Net.NetworkCredential System.Net.ICredentials.GetCredential(System.Uri uri, string authType) { throw null; }
    }
    public partial class HttpSourceRequest
    {
        public static readonly System.TimeSpan DefaultRequestTimeout;
        public HttpSourceRequest(System.Func<System.Net.Http.HttpRequestMessage> requestFactory) { }
        public HttpSourceRequest(string uri, NuGet.Common.ILogger log) { }
        public HttpSourceRequest(System.Uri uri, NuGet.Common.ILogger log) { }
        public System.TimeSpan DownloadTimeout { get { throw null; } set { } }
        public bool IgnoreNotFounds { get { throw null; } set { } }
        public int MaxTries { get { throw null; } set { } }
        public System.Func<System.Net.Http.HttpRequestMessage> RequestFactory { get { throw null; } }
        public System.TimeSpan RequestTimeout { get { throw null; } set { } }
    }
    public partial class HttpSourceResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        public HttpSourceResource(NuGet.Protocol.HttpSource httpSource) { }
        public NuGet.Protocol.HttpSource HttpSource { get { throw null; } }
    }
    public partial class HttpSourceResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public HttpSourceResourceProvider() : base (default(System.Type)) { }
        public static NuGet.Protocol.IThrottle Throttle { get { throw null; } set { } }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class HttpSourceResult : System.IDisposable
    {
        public HttpSourceResult(NuGet.Protocol.HttpSourceResultStatus status) { }
        public HttpSourceResult(NuGet.Protocol.HttpSourceResultStatus status, string cacheFileName, System.IO.Stream stream) { }
        public string CacheFile { get { throw null; } }
        public NuGet.Protocol.HttpSourceResultStatus Status { get { throw null; } }
        public System.IO.Stream Stream { get { throw null; } }
        public void Dispose() { }
    }
    public enum HttpSourceResultStatus
    {
        NoContent = 1,
        NotFound = 0,
        OpenedFromDisk = 2,
        OpenedFromNetwork = 3,
    }
    public static partial class HttpStreamValidation
    {
        public static void ValidateJObject(string uri, System.IO.Stream stream) { }
        public static void ValidateNupkg(string uri, System.IO.Stream stream) { }
        public static void ValidateXml(string uri, System.IO.Stream stream) { }
    }
    public partial interface IHttpRetryHandler
    {
        System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(NuGet.Protocol.HttpRetryHandlerRequest request, NuGet.Common.ILogger log, System.Threading.CancellationToken cancellationToken);
    }
    public abstract partial class InvalidCacheProtocolException : NuGet.Protocol.Core.Types.FatalProtocolException
    {
        public InvalidCacheProtocolException(string message) : base (default(string)) { }
        public InvalidCacheProtocolException(string message, System.Exception innerException) : base (default(string)) { }
    }
    public partial interface IThrottle
    {
        void Release();
        System.Threading.Tasks.Task WaitAsync();
    }
    public partial interface IV2FeedParser
    {
        System.Threading.Tasks.Task<NuGet.Protocol.V2FeedPage> GetPackagesPageAsync(string searchTerm, NuGet.Protocol.Core.Types.SearchFilter filters, int skip, int take, NuGet.Common.ILogger log, System.Threading.CancellationToken token);
        System.Threading.Tasks.Task<NuGet.Protocol.V2FeedPage> GetSearchPageAsync(string searchTerm, NuGet.Protocol.Core.Types.SearchFilter filters, int skip, int take, NuGet.Common.ILogger log, System.Threading.CancellationToken token);
    }
    public static partial class JsonExtensions
    {
        public const int JsonSerializationMaxDepth = 512;
        public static readonly Newtonsoft.Json.JsonSerializerSettings ObjectSerializationSettings;
        public static object FromJson(this string json, System.Type type) { throw null; }
        public static T FromJson<T>(this string json) { throw null; }
        public static T FromJson<T>(this string json, Newtonsoft.Json.JsonSerializerSettings settings) { throw null; }
        public static object FromJToken(this Newtonsoft.Json.Linq.JToken jtoken, System.Type type) { throw null; }
        public static T FromJToken<T>(this Newtonsoft.Json.Linq.JToken jtoken) { throw null; }
        public static System.Nullable<bool> GetBoolean(this Newtonsoft.Json.Linq.JObject json, string propertyName) { throw null; }
        public static T GetJObjectProperty<T>(this Newtonsoft.Json.Linq.JObject jobject, string propertyName) { throw null; }
        public static string ToJson(this object obj, Newtonsoft.Json.Formatting formatting = 0) { throw null; }
        public static Newtonsoft.Json.Linq.JToken ToJToken(this object obj) { throw null; }
    }
    public static partial class JsonProperties
    {
        public const string AllRepositorySigned = "allRepositorySigned";
        public const string Authors = "authors";
        public const string ContentUrl = "contentUrl";
        public const string Created = "created";
        public const string Data = "data";
        public const string Dependencies = "dependencies";
        public const string DependencyGroups = "dependencyGroups";
        public const string Description = "description";
        public const string DownloadCount = "totalDownloads";
        public const string Fingerprints = "fingerprints";
        public const string IconUrl = "iconUrl";
        public const string Issuer = "issuer";
        public const string Language = "language";
        public const string LastEdited = "lastEdited";
        public const string LatestVersion = "latestVersion";
        public const string LicenseExpression = "licenseExpression";
        public const string LicenseExpressionVersion = "licenseExpressionVersion";
        public const string LicenseUrl = "licenseUrl";
        public const string Listed = "listed";
        public const string MinimumClientVersion = "minClientVersion";
        public const string NotAfter = "notAfter";
        public const string NotBefore = "notBefore";
        public const string Owners = "owners";
        public const string PackageContent = "packageContent";
        public const string PackageId = "id";
        public const string PrefixReserved = "verified";
        public const string ProjectUrl = "projectUrl";
        public const string Published = "published";
        public const string Range = "range";
        public const string RequireLicenseAcceptance = "requireLicenseAcceptance";
        public const string SigningCertificates = "signingCertificates";
        public const string Subject = "subject";
        public const string SubjectId = "@id";
        public const string Summary = "summary";
        public const string Tags = "tags";
        public const string TargetFramework = "targetFramework";
        public const string Title = "title";
        public const string Type = "@type";
        public const string Version = "version";
        public const string Versions = "versions";
    }
    public partial class LegacyFeedCapabilityResourceV2Feed : NuGet.Protocol.Core.Types.LegacyFeedCapabilityResource
    {
        public LegacyFeedCapabilityResourceV2Feed(NuGet.Protocol.V2FeedParser feedParser, string baseAddress) { }
        public override System.Threading.Tasks.Task<bool> SupportsIsAbsoluteLatestVersionAsync(NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<bool> SupportsSearchAsync(NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalAutoCompleteResource : NuGet.Protocol.Core.Types.AutoCompleteResource
    {
        public LocalAutoCompleteResource(NuGet.Protocol.FindLocalPackagesResource localResource) { }
        protected System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetPackageVersionsFromLocalPackageRepository(string packageId, string versionPrefix, bool includePrerelease, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> IdStartsWith(string packageIdPrefix, bool includePrerelease, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> VersionStartsWith(string packageId, string versionPrefix, bool includePrerelease, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalAutoCompleteResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public LocalAutoCompleteResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalDependencyInfoResource : NuGet.Protocol.Core.Types.DependencyInfoResource
    {
        public LocalDependencyInfoResource(NuGet.Protocol.FindLocalPackagesResource localResource, NuGet.Protocol.Core.Types.SourceRepository source) { }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.SourcePackageDependencyInfo> ResolvePackage(NuGet.Packaging.Core.PackageIdentity package, NuGet.Frameworks.NuGetFramework projectFramework, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.SourcePackageDependencyInfo>> ResolvePackages(string packageId, NuGet.Frameworks.NuGetFramework projectFramework, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalDependencyInfoResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public LocalDependencyInfoResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalDownloadResource : NuGet.Protocol.Core.Types.DownloadResource
    {
        public LocalDownloadResource(NuGet.Protocol.FindLocalPackagesResource localResource) { }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.DownloadResourceResult> GetDownloadResourceResultAsync(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Protocol.Core.Types.PackageDownloadContext downloadContext, string globalPackagesFolder, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalDownloadResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public LocalDownloadResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public static partial class LocalFolderUtility
    {
        public static void EnsurePackageFileExists(string packagePath, System.Collections.Generic.IEnumerable<string> matchingPackagePaths) { }
        public static void GenerateNupkgMetadataFile(string nupkgPath, string installPath, string hashPath, string nupkgMetadataPath) { }
        public static System.IO.DirectoryInfo GetAndVerifyRootDirectory(string root) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> GetDistinctPackages(System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> packages) { throw null; }
        public static NuGet.Packaging.Core.PackageIdentity GetIdentityFromNupkgPath(System.IO.FileInfo file, string id) { throw null; }
        public static NuGet.Protocol.FeedType GetLocalFeedType(string root, NuGet.Common.ILogger log) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.IO.FileInfo> GetNupkgsFromFlatFolder(string root, NuGet.Common.ILogger log) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.IO.FileInfo> GetNupkgsFromFlatFolder(string root, string id, NuGet.Common.ILogger log) { throw null; }
        public static NuGet.Protocol.LocalPackageInfo GetPackage(System.Uri path, NuGet.Common.ILogger log) { throw null; }
        public static NuGet.Protocol.LocalPackageInfo GetPackagesConfigFolderPackage(string root, NuGet.Packaging.Core.PackageIdentity identity, NuGet.Common.ILogger log) { throw null; }
        public static NuGet.Protocol.LocalPackageInfo GetPackagesConfigFolderPackage(string root, string id, NuGet.Versioning.NuGetVersion version, NuGet.Common.ILogger log) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> GetPackagesConfigFolderPackages(string root, NuGet.Common.ILogger log) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> GetPackagesConfigFolderPackages(string root, string id, NuGet.Common.ILogger log) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> GetPackagesV2(string root, NuGet.Common.ILogger log) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> GetPackagesV2(string root, string id, NuGet.Common.ILogger log) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> GetPackagesV3(string root, NuGet.Common.ILogger log) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Protocol.LocalPackageInfo> GetPackagesV3(string root, string id, NuGet.Common.ILogger log) { throw null; }
        public static NuGet.Protocol.LocalPackageInfo GetPackageV2(string root, NuGet.Packaging.Core.PackageIdentity identity, NuGet.Common.ILogger log) { throw null; }
        public static NuGet.Protocol.LocalPackageInfo GetPackageV2(string root, string id, NuGet.Versioning.NuGetVersion version, NuGet.Common.ILogger log) { throw null; }
        public static NuGet.Protocol.LocalPackageInfo GetPackageV3(string root, NuGet.Packaging.Core.PackageIdentity identity, NuGet.Common.ILogger log) { throw null; }
        public static NuGet.Protocol.LocalPackageInfo GetPackageV3(string root, string id, NuGet.Versioning.NuGetVersion version, NuGet.Common.ILogger log) { throw null; }
        public static NuGet.Versioning.NuGetVersion GetVersionFromFileName(string fileName, string id, string extension) { throw null; }
        public static bool IsPossiblePackageMatch(System.IO.FileInfo file, NuGet.Packaging.Core.PackageIdentity identity) { throw null; }
        public static bool IsPossiblePackageMatch(System.IO.FileInfo file, string id) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> ResolvePackageFromPath(string packagePath, bool isSnupkg = false) { throw null; }
    }
    public partial class LocalMetadataResource : NuGet.Protocol.Core.Types.MetadataResource
    {
        public LocalMetadataResource(NuGet.Protocol.FindLocalPackagesResource localResource) { }
        public override System.Threading.Tasks.Task<bool> Exists(NuGet.Packaging.Core.PackageIdentity identity, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<bool> Exists(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, NuGet.Versioning.NuGetVersion>>> GetLatestVersions(System.Collections.Generic.IEnumerable<string> packageIds, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetVersions(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalMetadataResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public LocalMetadataResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalPackageFileCache
    {
        public LocalPackageFileCache() { }
        public System.Lazy<System.Collections.Generic.IReadOnlyList<string>> GetOrAddFiles(string expandedPath) { throw null; }
        public System.Lazy<NuGet.Packaging.NuspecReader> GetOrAddNuspec(string manifestPath, string expandedPath) { throw null; }
        public System.Lazy<NuGet.RuntimeModel.RuntimeGraph> GetOrAddRuntimeGraph(string expandedPath) { throw null; }
        public System.Lazy<string> GetOrAddSha512(string sha512Path) { throw null; }
        public bool Sha512Exists(string sha512Path) { throw null; }
    }
    public partial class LocalPackageInfo
    {
        protected LocalPackageInfo() { }
        public LocalPackageInfo(NuGet.Packaging.Core.PackageIdentity identity, string path, System.DateTime lastWriteTimeUtc, System.Lazy<NuGet.Packaging.NuspecReader> nuspec, System.Func<NuGet.Packaging.PackageReaderBase> getPackageReader) { }
        public virtual NuGet.Packaging.Core.PackageIdentity Identity { get { throw null; } }
        public virtual bool IsNupkg { get { throw null; } }
        public virtual System.DateTime LastWriteTimeUtc { get { throw null; } }
        public virtual NuGet.Packaging.NuspecReader Nuspec { get { throw null; } }
        public virtual string Path { get { throw null; } }
        public virtual NuGet.Packaging.PackageReaderBase GetReader() { throw null; }
    }
    public partial class LocalPackageListResource : NuGet.Protocol.Core.Types.ListResource
    {
        public LocalPackageListResource(NuGet.Protocol.Core.Types.PackageSearchResource localPackageSearchResource, string baseAddress) { }
        public override string Source { get { throw null; } }
        public override System.Threading.Tasks.Task<NuGet.Common.IEnumerableAsync<NuGet.Protocol.Core.Types.IPackageSearchMetadata>> ListAsync(string searchTerm, bool prerelease, bool allVersions, bool includeDelisted, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalPackageMetadataResource : NuGet.Protocol.Core.Types.PackageMetadataResource
    {
        public LocalPackageMetadataResource(NuGet.Protocol.FindLocalPackagesResource localResource) { }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.IPackageSearchMetadata> GetMetadataAsync(NuGet.Packaging.Core.PackageIdentity package, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.IPackageSearchMetadata>> GetMetadataAsync(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalPackageMetadataResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public LocalPackageMetadataResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalPackageSearchMetadata : NuGet.Protocol.Core.Types.IPackageSearchMetadata
    {
        public LocalPackageSearchMetadata(NuGet.Protocol.LocalPackageInfo package) { }
        public string Authors { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> DependencySets { get { throw null; } }
        public string Description { get { throw null; } }
        public System.Nullable<long> DownloadCount { get { throw null; } }
        public System.Uri IconUrl { get { throw null; } }
        public NuGet.Packaging.Core.PackageIdentity Identity { get { throw null; } }
        public bool IsListed { get { throw null; } }
        public NuGet.Packaging.LicenseMetadata LicenseMetadata { get { throw null; } }
        public System.Uri LicenseUrl { get { throw null; } }
        public string Owners { get { throw null; } }
        public System.Uri PackageDetailsUrl { get { throw null; } }
        public bool PrefixReserved { get { throw null; } }
        public System.Uri ProjectUrl { get { throw null; } }
        public System.Nullable<System.DateTimeOffset> Published { get { throw null; } }
        public System.Uri ReportAbuseUrl { get { throw null; } }
        public bool RequireLicenseAcceptance { get { throw null; } }
        public string Summary { get { throw null; } }
        public string Tags { get { throw null; } }
        public string Title { get { throw null; } }
        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.VersionInfo>> GetVersionsAsync() { throw null; }
        public string LoadFileAsText(string path) { throw null; }
    }
    public partial class LocalPackageSearchResource : NuGet.Protocol.Core.Types.PackageSearchResource
    {
        public LocalPackageSearchResource(NuGet.Protocol.FindLocalPackagesResource localResource) { }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.IPackageSearchMetadata>> SearchAsync(string searchTerm, NuGet.Protocol.Core.Types.SearchFilter filters, int skip, int take, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalPackageSearchResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public LocalPackageSearchResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalV2FindPackageByIdResource : NuGet.Protocol.Core.Types.FindPackageByIdResource
    {
        public LocalV2FindPackageByIdResource(NuGet.Configuration.PackageSource packageSource) { }
        public override System.Threading.Tasks.Task<bool> CopyNupkgToStreamAsync(string id, NuGet.Versioning.NuGetVersion version, System.IO.Stream destination, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<bool> DoesPackageExistAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetAllVersionsAsync(string id, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.FindPackageByIdDependencyInfo> GetDependencyInfoAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Packaging.IPackageDownloader> GetPackageDownloaderAsync(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class LocalV2FindPackageByIdResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public LocalV2FindPackageByIdResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class LocalV3FindPackageByIdResource : NuGet.Protocol.Core.Types.FindPackageByIdResource
    {
        public LocalV3FindPackageByIdResource(NuGet.Configuration.PackageSource packageSource) { }
        public bool IsFallbackFolder { get { throw null; } set { } }
        public NuGet.Protocol.LocalPackageFileCache PackageFileCache { get { throw null; } set { } }
        public override System.Threading.Tasks.Task<bool> CopyNupkgToStreamAsync(string id, NuGet.Versioning.NuGetVersion version, System.IO.Stream destination, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<bool> DoesPackageExistAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetAllVersionsAsync(string id, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.FindPackageByIdDependencyInfo> GetDependencyInfoAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Packaging.IPackageDownloader> GetPackageDownloaderAsync(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class LocalV3FindPackageByIdResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public LocalV3FindPackageByIdResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class MetadataFieldConverter : Newtonsoft.Json.JsonConverter
    {
        public MetadataFieldConverter() { }
        public override bool CanWrite { get { throw null; } }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class MetadataReferenceCache
    {
        public MetadataReferenceCache() { }
        public static System.Collections.Generic.IEnumerable<System.Type> CachableTypes { get { throw null; } }
        public T GetObject<T>(T input) { throw null; }
        public string GetString(string s) { throw null; }
        public NuGet.Versioning.NuGetVersion GetVersion(string s) { throw null; }
    }
    public partial class MetadataResourceV2Feed : NuGet.Protocol.Core.Types.MetadataResource
    {
        public MetadataResourceV2Feed(NuGet.Protocol.V2FeedParser feedParser, NuGet.Protocol.Core.Types.SourceRepository source) { }
        public override System.Threading.Tasks.Task<bool> Exists(NuGet.Packaging.Core.PackageIdentity identity, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<bool> Exists(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, NuGet.Versioning.NuGetVersion>>> GetLatestVersions(System.Collections.Generic.IEnumerable<string> packageIds, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetVersions(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class MetadataResourceV2FeedProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public MetadataResourceV2FeedProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class MetadataResourceV3 : NuGet.Protocol.Core.Types.MetadataResource
    {
        public MetadataResourceV3(NuGet.Protocol.HttpSource client, NuGet.Protocol.RegistrationResourceV3 regResource) { }
        public override System.Threading.Tasks.Task<bool> Exists(NuGet.Packaging.Core.PackageIdentity identity, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<bool> Exists(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, NuGet.Versioning.NuGetVersion>>> GetLatestVersions(System.Collections.Generic.IEnumerable<string> packageIds, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetVersions(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class MetadataResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public MetadataResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class NuGetVersionConverter : Newtonsoft.Json.JsonConverter
    {
        public NuGetVersionConverter() { }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class NullThrottle : NuGet.Protocol.IThrottle
    {
        public NullThrottle() { }
        public static NuGet.Protocol.NullThrottle Instance { get { throw null; } }
        public void Release() { }
        public System.Threading.Tasks.Task WaitAsync() { throw null; }
    }
    public partial class ODataServiceDocumentResourceV2 : NuGet.Protocol.Core.Types.INuGetResource
    {
        public ODataServiceDocumentResourceV2(string baseAddress, System.DateTime requestTime) { }
        public string BaseAddress { get { throw null; } }
        public virtual System.DateTime RequestTime { get { throw null; } }
    }
    public partial class ODataServiceDocumentResourceV2Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public ODataServiceDocumentResourceV2Provider() : base (default(System.Type)) { }
        public System.TimeSpan MaxCacheDuration { get { throw null; } protected set { } }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
        protected partial class ODataServiceDocumentCacheInfo
        {
            public ODataServiceDocumentCacheInfo() { }
            public System.DateTime CachedTime { get { throw null; } set { } }
            public NuGet.Protocol.ODataServiceDocumentResourceV2 ServiceDocument { get { throw null; } set { } }
        }
    }
    public partial class PackageDependencyGroupConverter : Newtonsoft.Json.JsonConverter
    {
        public PackageDependencyGroupConverter() { }
        public override bool CanWrite { get { throw null; } }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class PackageDetailsUriResourceV3 : NuGet.Protocol.Core.Types.INuGetResource
    {
        internal PackageDetailsUriResourceV3() { }
        public static NuGet.Protocol.PackageDetailsUriResourceV3 CreateOrNull(string uriTemplate) { throw null; }
        public System.Uri GetUri(string id, NuGet.Versioning.NuGetVersion version) { throw null; }
    }
    public partial class PackageDetailsUriResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public PackageDetailsUriResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class PackageMetadataResourceV2Feed : NuGet.Protocol.Core.Types.PackageMetadataResource
    {
        public PackageMetadataResourceV2Feed(NuGet.Protocol.HttpSourceResource httpSourceResource, string baseAddress, NuGet.Configuration.PackageSource packageSource) { }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.IPackageSearchMetadata> GetMetadataAsync(NuGet.Packaging.Core.PackageIdentity package, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.IPackageSearchMetadata>> GetMetadataAsync(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class PackageMetadataResourceV2FeedProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public PackageMetadataResourceV2FeedProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class PackageMetadataResourceV3 : NuGet.Protocol.Core.Types.PackageMetadataResource
    {
        public PackageMetadataResourceV3(NuGet.Protocol.HttpSource client, NuGet.Protocol.RegistrationResourceV3 regResource, NuGet.Protocol.ReportAbuseResourceV3 reportAbuseResource, NuGet.Protocol.PackageDetailsUriResourceV3 packageDetailsUriResource) { }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.IPackageSearchMetadata> GetMetadataAsync(NuGet.Packaging.Core.PackageIdentity package, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.IPackageSearchMetadata>> GetMetadataAsync(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class PackageMetadataResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public PackageMetadataResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class PackageNotFoundProtocolException : NuGet.Protocol.InvalidCacheProtocolException
    {
        public PackageNotFoundProtocolException(NuGet.Packaging.Core.PackageIdentity package) : base (default(string)) { }
        public PackageNotFoundProtocolException(NuGet.Packaging.Core.PackageIdentity package, System.Exception innerException) : base (default(string)) { }
        public NuGet.Packaging.Core.PackageIdentity PackageIdentity { get { throw null; } }
    }
    public partial class PackageSearchMetadata : NuGet.Protocol.Core.Types.IPackageSearchMetadata
    {
        public PackageSearchMetadata() { }
        [Newtonsoft.Json.JsonConverterAttribute(typeof(NuGet.Protocol.MetadataFieldConverter))]
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="authors")]
        public string Authors { get { throw null; } }
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> DependencySets { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="dependencyGroups", ItemConverterType=typeof(NuGet.Protocol.PackageDependencyGroupConverter))]
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> DependencySetsInternal { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="description")]
        public string Description { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="totalDownloads")]
        public System.Nullable<long> DownloadCount { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="iconUrl")]
        public System.Uri IconUrl { get { throw null; } }
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public NuGet.Packaging.Core.PackageIdentity Identity { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="listed")]
        public bool IsListed { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="licenseExpression")]
        public string LicenseExpression { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="licenseExpressionVersion")]
        public string LicenseExpressionVersion { get { throw null; } }
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public NuGet.Packaging.LicenseMetadata LicenseMetadata { get { throw null; } }
        [Newtonsoft.Json.JsonConverterAttribute(typeof(NuGet.Protocol.SafeUriConverter))]
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="licenseUrl")]
        public System.Uri LicenseUrl { get { throw null; } }
        [Newtonsoft.Json.JsonConverterAttribute(typeof(NuGet.Protocol.MetadataFieldConverter))]
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="owners")]
        public string Owners { get { throw null; } }
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public System.Uri PackageDetailsUrl { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="id")]
        public string PackageId { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="versions")]
        public NuGet.Protocol.Core.Types.VersionInfo[] ParsedVersions { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="verified")]
        public bool PrefixReserved { get { throw null; } }
        [Newtonsoft.Json.JsonConverterAttribute(typeof(NuGet.Protocol.SafeUriConverter))]
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="projectUrl")]
        public System.Uri ProjectUrl { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="published")]
        public System.Nullable<System.DateTimeOffset> Published { get { throw null; } }
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public System.Uri ReportAbuseUrl { get { throw null; } set { } }
        [Newtonsoft.Json.JsonConverterAttribute(typeof(NuGet.Protocol.SafeBoolConverter))]
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="requireLicenseAcceptance", DefaultValueHandling=Newtonsoft.Json.DefaultValueHandling.Populate)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool RequireLicenseAcceptance { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="summary")]
        public string Summary { get { throw null; } }
        [Newtonsoft.Json.JsonConverterAttribute(typeof(NuGet.Protocol.MetadataFieldConverter))]
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="tags")]
        public string Tags { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="title")]
        public string Title { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="version")]
        public NuGet.Versioning.NuGetVersion Version { get { throw null; } }
        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.VersionInfo>> GetVersionsAsync() { throw null; }
    }
    public partial class PackageSearchMetadataRegistration : NuGet.Protocol.PackageSearchMetadata
    {
        public PackageSearchMetadataRegistration() { }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="@id")]
        public System.Uri CatalogUri { get { throw null; } }
    }
    public partial class PackageSearchMetadataV2Feed : NuGet.Protocol.Core.Types.IPackageSearchMetadata
    {
        public PackageSearchMetadataV2Feed(NuGet.Protocol.V2FeedPackageInfo package) { }
        public PackageSearchMetadataV2Feed(NuGet.Protocol.V2FeedPackageInfo package, NuGet.Protocol.MetadataReferenceCache metadataCache) { }
        public string Authors { get { throw null; } }
        public System.Nullable<System.DateTimeOffset> Created { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> DependencySets { get { throw null; } }
        public string Description { get { throw null; } }
        public System.Nullable<long> DownloadCount { get { throw null; } }
        public System.Uri IconUrl { get { throw null; } }
        public NuGet.Packaging.Core.PackageIdentity Identity { get { throw null; } }
        public bool IsListed { get { throw null; } }
        public System.Nullable<System.DateTimeOffset> LastEdited { get { throw null; } }
        public NuGet.Packaging.LicenseMetadata LicenseMetadata { get { throw null; } }
        public System.Uri LicenseUrl { get { throw null; } }
        public string Owners { get { throw null; } }
        public System.Uri PackageDetailsUrl { get { throw null; } }
        public string PackageId { get { throw null; } }
        public bool PrefixReserved { get { throw null; } }
        public System.Uri ProjectUrl { get { throw null; } }
        public System.Nullable<System.DateTimeOffset> Published { get { throw null; } }
        public System.Uri ReportAbuseUrl { get { throw null; } }
        public bool RequireLicenseAcceptance { get { throw null; } }
        public string Summary { get { throw null; } }
        public string Tags { get { throw null; } }
        public string Title { get { throw null; } }
        public NuGet.Versioning.NuGetVersion Version { get { throw null; } }
        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.VersionInfo>> GetVersionsAsync() { throw null; }
    }
    public partial class PackageSearchResourceV2Feed : NuGet.Protocol.Core.Types.PackageSearchResource
    {
        public PackageSearchResourceV2Feed(NuGet.Protocol.HttpSourceResource httpSourceResource, string baseAddress, NuGet.Configuration.PackageSource packageSource) { }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.IPackageSearchMetadata>> SearchAsync(string searchTerm, NuGet.Protocol.Core.Types.SearchFilter filters, int skip, int take, NuGet.Common.ILogger log, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class PackageSearchResourceV2FeedProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public PackageSearchResourceV2FeedProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class PackageSearchResourceV3 : NuGet.Protocol.Core.Types.PackageSearchResource
    {
        public PackageSearchResourceV3(NuGet.Protocol.RawSearchResourceV3 searchResource) { }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.IPackageSearchMetadata>> SearchAsync(string searchTerm, NuGet.Protocol.Core.Types.SearchFilter filter, int skip, int take, NuGet.Common.ILogger log, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class PackageSearchResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public PackageSearchResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class PackageUpdateResourceV2Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public PackageUpdateResourceV2Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class PackageUpdateResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public PackageUpdateResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public sealed partial class PluginFindPackageByIdResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public PluginFindPackageByIdResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public static partial class ProtocolConstants
    {
        public static readonly string ApiKeyHeader;
        public static readonly string ServerWarningHeader;
        public static readonly string SessionId;
    }
    public partial class ProxyAuthenticationHandler : System.Net.Http.DelegatingHandler
    {
        public static readonly int MaxAuthRetries;
        public ProxyAuthenticationHandler(System.Net.Http.HttpClientHandler clientHandler, NuGet.Configuration.ICredentialService credentialService, NuGet.Configuration.IProxyCredentialCache credentialCache) { }
        protected override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class RawSearchResourceV3 : NuGet.Protocol.Core.Types.INuGetResource
    {
        public RawSearchResourceV3(NuGet.Protocol.HttpSource client, System.Collections.Generic.IEnumerable<System.Uri> searchEndpoints) { }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JObject>> Search(string searchTerm, NuGet.Protocol.Core.Types.SearchFilter filters, int skip, int take, NuGet.Common.ILogger log, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JObject> SearchPage(string searchTerm, NuGet.Protocol.Core.Types.SearchFilter filters, int skip, int take, NuGet.Common.ILogger log, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class RawSearchResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public RawSearchResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class RegistrationResourceV3 : NuGet.Protocol.Core.Types.INuGetResource
    {
        public RegistrationResourceV3(NuGet.Protocol.HttpSource client, System.Uri baseUrl) { }
        public System.Uri BaseUri { get { throw null; } }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JObject>> GetPackageEntries(string packageId, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public virtual System.Threading.Tasks.Task<Newtonsoft.Json.Linq.JObject> GetPackageMetadata(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JObject>> GetPackageMetadata(string packageId, NuGet.Versioning.VersionRange range, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JObject>> GetPackageMetadata(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public virtual System.Uri GetUri(NuGet.Packaging.Core.PackageIdentity package) { throw null; }
        public virtual System.Uri GetUri(string packageId) { throw null; }
        public virtual System.Uri GetUri(string id, NuGet.Versioning.NuGetVersion version) { throw null; }
    }
    public partial class RegistrationResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public RegistrationResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public static partial class RegistrationUtility
    {
        public static NuGet.Versioning.VersionRange CreateVersionRange(string stringToParse) { throw null; }
        public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JObject>> LoadRanges(NuGet.Protocol.HttpSource httpSource, System.Uri registrationUri, string packageId, NuGet.Versioning.VersionRange range, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public sealed partial class RemotePackageArchiveDownloader : NuGet.Packaging.IPackageDownloader, System.IDisposable
    {
        public RemotePackageArchiveDownloader(string source, NuGet.Protocol.Core.Types.FindPackageByIdResource resource, NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger) { }
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
    public partial class RemoteV2FindPackageByIdResource : NuGet.Protocol.Core.Types.FindPackageByIdResource
    {
        public RemoteV2FindPackageByIdResource(NuGet.Configuration.PackageSource packageSource, NuGet.Protocol.HttpSource httpSource) { }
        public NuGet.Configuration.PackageSource PackageSource { get { throw null; } }
        public override System.Threading.Tasks.Task<bool> CopyNupkgToStreamAsync(string id, NuGet.Versioning.NuGetVersion version, System.IO.Stream destination, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<bool> DoesPackageExistAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetAllVersionsAsync(string id, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.FindPackageByIdDependencyInfo> GetDependencyInfoAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Packaging.IPackageDownloader> GetPackageDownloaderAsync(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class RemoteV2FindPackageByIdResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public RemoteV2FindPackageByIdResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository sourceRepository, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class RemoteV3FindPackageByIdResource : NuGet.Protocol.Core.Types.FindPackageByIdResource
    {
        public RemoteV3FindPackageByIdResource(NuGet.Protocol.Core.Types.SourceRepository sourceRepository, NuGet.Protocol.HttpSource httpSource) { }
        public NuGet.Protocol.Core.Types.SourceRepository SourceRepository { get { throw null; } }
        public override System.Threading.Tasks.Task<bool> CopyNupkgToStreamAsync(string id, NuGet.Versioning.NuGetVersion version, System.IO.Stream destination, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<bool> DoesPackageExistAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetAllVersionsAsync(string id, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.FindPackageByIdDependencyInfo> GetDependencyInfoAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Packaging.IPackageDownloader> GetPackageDownloaderAsync(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class RemoteV3FindPackageByIdResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public RemoteV3FindPackageByIdResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository sourceRepository, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class ReportAbuseResourceV3 : NuGet.Protocol.Core.Types.INuGetResource
    {
        public ReportAbuseResourceV3(string uriTemplate) { }
        public System.Uri GetReportAbuseUrl(string id, NuGet.Versioning.NuGetVersion version) { throw null; }
    }
    public partial class ReportAbuseResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public ReportAbuseResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class RepositoryCertificateInfo : NuGet.Packaging.Core.IRepositoryCertificateInfo
    {
        public RepositoryCertificateInfo() { }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="contentUrl")]
        public string ContentUrl { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="fingerprints")]
        public NuGet.Packaging.Core.Fingerprints Fingerprints { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="issuer")]
        public string Issuer { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="notAfter")]
        public System.DateTimeOffset NotAfter { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="notBefore")]
        public System.DateTimeOffset NotBefore { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute(PropertyName="subject")]
        public string Subject { get { throw null; } }
    }
    public partial class RepositorySignatureResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        public RepositorySignatureResource(Newtonsoft.Json.Linq.JObject repoSignInformationContent, NuGet.Protocol.Core.Types.SourceRepository source) { }
        public RepositorySignatureResource(bool allRepositorySigned, System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.IRepositoryCertificateInfo> repositoryCertInfos) { }
        public bool AllRepositorySigned { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.IRepositoryCertificateInfo> RepositoryCertificateInfos { get { throw null; } }
        public string Source { get { throw null; } }
        public void UpdateRepositorySignatureInfo() { }
    }
    public partial class RepositorySignatureResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public RepositorySignatureResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class SafeBoolConverter : Newtonsoft.Json.JsonConverter
    {
        public SafeBoolConverter() { }
        public override bool CanRead { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class SafeUriConverter : Newtonsoft.Json.JsonConverter
    {
        public SafeUriConverter() { }
        public override bool CanRead { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public sealed partial class SemanticVersionConverter : Newtonsoft.Json.JsonConverter
    {
        public SemanticVersionConverter() { }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class SemaphoreSlimThrottle : NuGet.Protocol.IThrottle
    {
        public SemaphoreSlimThrottle(System.Threading.SemaphoreSlim semaphore) { }
        public int CurrentCount { get { throw null; } }
        public static NuGet.Protocol.SemaphoreSlimThrottle CreateBinarySemaphore() { throw null; }
        public static NuGet.Protocol.SemaphoreSlimThrottle CreateSemaphoreThrottle(int initialCount) { throw null; }
        public void Release() { }
        public System.Threading.Tasks.Task WaitAsync() { throw null; }
    }
    public partial class ServerWarningLogHandler : System.Net.Http.DelegatingHandler
    {
        public ServerWarningLogHandler(System.Net.Http.HttpClientHandler clientHandler) { }
        protected override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class ServiceIndexEntry
    {
        public ServiceIndexEntry(System.Uri serviceUri, string serviceType, NuGet.Versioning.SemanticVersion clientVersion) { }
        public NuGet.Versioning.SemanticVersion ClientVersion { get { throw null; } }
        public string Type { get { throw null; } }
        public System.Uri Uri { get { throw null; } }
    }
    public partial class ServiceIndexResourceV3 : NuGet.Protocol.Core.Types.INuGetResource
    {
        public ServiceIndexResourceV3(Newtonsoft.Json.Linq.JObject index, System.DateTime requestTime) { }
        public virtual System.Collections.Generic.IReadOnlyList<NuGet.Protocol.ServiceIndexEntry> Entries { get { throw null; } }
        public virtual string Json { get { throw null; } }
        public virtual System.DateTime RequestTime { get { throw null; } }
        public virtual System.Collections.Generic.IReadOnlyList<NuGet.Protocol.ServiceIndexEntry> GetServiceEntries(NuGet.Versioning.NuGetVersion clientVersion, params string[] orderedTypes) { throw null; }
        public virtual System.Collections.Generic.IReadOnlyList<NuGet.Protocol.ServiceIndexEntry> GetServiceEntries(params string[] orderedTypes) { throw null; }
        public virtual System.Uri GetServiceEntryUri(params string[] orderedTypes) { throw null; }
        public virtual System.Collections.Generic.IReadOnlyList<System.Uri> GetServiceEntryUris(NuGet.Versioning.NuGetVersion clientVersion, params string[] orderedTypes) { throw null; }
        public virtual System.Collections.Generic.IReadOnlyList<System.Uri> GetServiceEntryUris(params string[] orderedTypes) { throw null; }
    }
    public partial class ServiceIndexResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public ServiceIndexResourceV3Provider() : base (default(System.Type)) { }
        public System.TimeSpan MaxCacheDuration { get { throw null; } protected set { } }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
        protected partial class ServiceIndexCacheInfo
        {
            public ServiceIndexCacheInfo() { }
            public System.DateTime CachedTime { get { throw null; } set { } }
            public NuGet.Protocol.ServiceIndexResourceV3 Index { get { throw null; } set { } }
        }
    }
    public static partial class ServiceTypes
    {
        public static readonly string[] LegacyGallery;
        public static readonly string[] PackageBaseAddress;
        public static readonly string[] PackageDetailsUriTemplate;
        public static readonly string[] PackagePublish;
        public static readonly string[] RegistrationsBaseUrl;
        public static readonly string[] ReportAbuse;
        public static readonly string[] RepositorySignatures;
        public static readonly string[] SearchAutocompleteService;
        public static readonly string[] SearchQueryService;
        public static readonly string[] SymbolPackagePublish;
        public static readonly string Version200;
        public static readonly string Version300;
        public static readonly string Version300beta;
        public static readonly string Version340;
        public static readonly string Version470;
        public static readonly string Version490;
        public static readonly string Version500;
        public static readonly string Version510;
        public static readonly string Versioned;
    }
    public static partial class StreamExtensions
    {
        public static readonly int BufferSize;
        public static System.Threading.Tasks.Task CopyToAsync(this System.IO.Stream stream, System.IO.Stream destination, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class StsAuthenticationHandler : System.Net.Http.DelegatingHandler
    {
        public const string STSEndPointHeader = "X-NuGet-STS-EndPoint";
        public const string STSRealmHeader = "X-NuGet-STS-Realm";
        public const string STSTokenHeader = "X-NuGet-STS-Token";
        public StsAuthenticationHandler(NuGet.Configuration.PackageSource packageSource, NuGet.Protocol.TokenStore tokenStore) { }
        public StsAuthenticationHandler(NuGet.Configuration.PackageSource packageSource, NuGet.Protocol.TokenStore tokenStore, System.Func<string, string, string> tokenFactory) { }
        protected override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { throw null; }
        public bool TryRetrieveSTSToken(System.Net.Http.HttpResponseMessage response) { throw null; }
    }
    public partial class SymbolPackageUpdateResourceV3Provider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public SymbolPackageUpdateResourceV3Provider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public static partial class TimeoutUtility
    {
        public static System.Threading.Tasks.Task StartWithTimeout(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task> getTask, System.TimeSpan timeout, string timeoutMessage, System.Threading.CancellationToken token) { throw null; }
        public static System.Threading.Tasks.Task<T> StartWithTimeout<T>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> getTask, System.TimeSpan timeout, string timeoutMessage, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class TokenStore
    {
        public TokenStore() { }
        public static NuGet.Protocol.TokenStore Instance { get { throw null; } }
        public System.Guid Version { get { throw null; } }
        public void AddToken(System.Uri sourceUri, string token) { }
        public string GetToken(System.Uri sourceUri) { throw null; }
    }
    public partial class V2FeedListResource : NuGet.Protocol.Core.Types.ListResource
    {
        public V2FeedListResource(NuGet.Protocol.IV2FeedParser feedParser, NuGet.Protocol.Core.Types.ILegacyFeedCapabilityResource feedCapabilities, string baseAddress) { }
        public override string Source { get { throw null; } }
        public override System.Threading.Tasks.Task<NuGet.Common.IEnumerableAsync<NuGet.Protocol.Core.Types.IPackageSearchMetadata>> ListAsync(string searchTerm, bool prerelease, bool allVersions, bool includeDelisted, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class V2FeedListResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public V2FeedListResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class V2FeedPackageInfo : NuGet.Packaging.Core.PackageIdentity
    {
        public V2FeedPackageInfo(NuGet.Packaging.Core.PackageIdentity identity, string title, string summary, string description, System.Collections.Generic.IEnumerable<string> authors, System.Collections.Generic.IEnumerable<string> owners, string iconUrl, string licenseUrl, string projectUrl, string reportAbuseUrl, string galleryDetailsUrl, string tags, System.Nullable<System.DateTimeOffset> created, System.Nullable<System.DateTimeOffset> lastEdited, System.Nullable<System.DateTimeOffset> published, string dependencies, bool requireLicenseAccept, string downloadUrl, string downloadCount, string packageHash, string packageHashAlgorithm, NuGet.Versioning.NuGetVersion minClientVersion) : base (default(string), default(NuGet.Versioning.NuGetVersion)) { }
        public System.Collections.Generic.IEnumerable<string> Authors { get { throw null; } }
        public System.Nullable<System.DateTimeOffset> Created { get { throw null; } }
        public string Dependencies { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.PackageDependencyGroup> DependencySets { get { throw null; } }
        public string Description { get { throw null; } }
        public string DownloadCount { get { throw null; } }
        public int DownloadCountAsInt { get { throw null; } }
        public string DownloadUrl { get { throw null; } }
        public string GalleryDetailsUrl { get { throw null; } }
        public string IconUrl { get { throw null; } }
        public bool IsListed { get { throw null; } }
        public System.Nullable<System.DateTimeOffset> LastEdited { get { throw null; } }
        public string LicenseUrl { get { throw null; } }
        public NuGet.Versioning.NuGetVersion MinClientVersion { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> Owners { get { throw null; } }
        public string PackageHash { get { throw null; } }
        public string PackageHashAlgorithm { get { throw null; } }
        public string ProjectUrl { get { throw null; } }
        public System.Nullable<System.DateTimeOffset> Published { get { throw null; } }
        public string ReportAbuseUrl { get { throw null; } }
        public bool RequireLicenseAcceptance { get { throw null; } }
        public string Summary { get { throw null; } }
        public string Tags { get { throw null; } }
        public string Title { get { throw null; } }
    }
    public partial class V2FeedPage
    {
        public V2FeedPage(System.Collections.Generic.List<NuGet.Protocol.V2FeedPackageInfo> items, string nextUri) { }
        public System.Collections.Generic.IReadOnlyList<NuGet.Protocol.V2FeedPackageInfo> Items { get { throw null; } }
        public string NextUri { get { throw null; } }
    }
    public sealed partial class V2FeedParser : NuGet.Protocol.IV2FeedParser
    {
        public V2FeedParser(NuGet.Protocol.HttpSource httpSource, string baseAddress) { }
        public V2FeedParser(NuGet.Protocol.HttpSource httpSource, string baseAddress, string source) { }
        public string Source { get { throw null; } }
        public System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.DownloadResourceResult> DownloadFromIdentity(NuGet.Packaging.Core.PackageIdentity package, NuGet.Protocol.Core.Types.PackageDownloadContext downloadContext, string globalPackagesFolder, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.DownloadResourceResult> DownloadFromUrl(NuGet.Packaging.Core.PackageIdentity package, System.Uri downloadUri, NuGet.Protocol.Core.Types.PackageDownloadContext downloadContext, string globalPackagesFolder, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Protocol.V2FeedPackageInfo>> FindPackagesByIdAsync(string id, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Protocol.V2FeedPackageInfo>> FindPackagesByIdAsync(string id, bool includeUnlisted, bool includePrerelease, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<NuGet.Protocol.V2FeedPackageInfo> GetPackage(NuGet.Packaging.Core.PackageIdentity package, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<NuGet.Protocol.V2FeedPage> GetPackagesPageAsync(string searchTerm, NuGet.Protocol.Core.Types.SearchFilter filters, int skip, int take, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<NuGet.Protocol.V2FeedPage> GetSearchPageAsync(string searchTerm, NuGet.Protocol.Core.Types.SearchFilter filters, int skip, int take, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<NuGet.Protocol.V2FeedPage> QueryV2FeedAsync(string relativeUri, string id, int max, bool ignoreNotFounds, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Protocol.V2FeedPackageInfo>> Search(string searchTerm, NuGet.Protocol.Core.Types.SearchFilter filters, int skip, int take, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class V2FeedQueryBuilder
    {
        public V2FeedQueryBuilder() { }
        public string BuildFindPackagesByIdUri(string id) { throw null; }
        public string BuildGetPackagesUri(string searchTerm, NuGet.Protocol.Core.Types.SearchFilter filters, System.Nullable<int> skip, System.Nullable<int> take) { throw null; }
        public string BuildGetPackageUri(NuGet.Packaging.Core.PackageIdentity package) { throw null; }
        public string BuildSearchUri(string searchTerm, NuGet.Protocol.Core.Types.SearchFilter filters, int skip, int take) { throw null; }
    }
    public partial class V2FeedUtilities
    {
        public V2FeedUtilities() { }
        public static NuGet.Protocol.Core.Types.IPackageSearchMetadata CreatePackageSearchResult(NuGet.Protocol.V2FeedPackageInfo package, NuGet.Protocol.MetadataReferenceCache metadataCache, NuGet.Protocol.Core.Types.SearchFilter filter, NuGet.Protocol.V2FeedParser feedParser, NuGet.Common.ILogger log, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class V3FeedListResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public V3FeedListResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class VersionInfoConverter : Newtonsoft.Json.JsonConverter
    {
        public VersionInfoConverter() { }
        public override bool CanWrite { get { throw null; } }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
}
namespace NuGet.Protocol.Core.Types
{
    public abstract partial class AutoCompleteResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        protected AutoCompleteResource() { }
        public abstract System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> IdStartsWith(string packageIdPrefix, bool includePrerelease, NuGet.Common.ILogger log, System.Threading.CancellationToken token);
        public abstract System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> VersionStartsWith(string packageId, string versionPrefix, bool includePrerelease, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token);
    }
    public abstract partial class DependencyInfoResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        protected DependencyInfoResource() { }
        public abstract System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.SourcePackageDependencyInfo> ResolvePackage(NuGet.Packaging.Core.PackageIdentity package, NuGet.Frameworks.NuGetFramework projectFramework, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token);
        public abstract System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.SourcePackageDependencyInfo>> ResolvePackages(string packageId, NuGet.Frameworks.NuGetFramework projectFramework, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token);
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.RemoteSourceDependencyInfo>> ResolvePackages(string packageId, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
    }
    public abstract partial class DownloadResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        protected DownloadResource() { }
        public abstract System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.DownloadResourceResult> GetDownloadResourceResultAsync(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Protocol.Core.Types.PackageDownloadContext downloadContext, string globalPackagesFolder, NuGet.Common.ILogger logger, System.Threading.CancellationToken token);
    }
    public sealed partial class DownloadResourceResult : System.IDisposable
    {
        public DownloadResourceResult(NuGet.Packaging.PackageReaderBase packageReader, string source) { }
        public DownloadResourceResult(NuGet.Protocol.Core.Types.DownloadResourceResultStatus status) { }
        public DownloadResourceResult(System.IO.Stream stream, NuGet.Packaging.PackageReaderBase packageReader, string source) { }
        public DownloadResourceResult(System.IO.Stream stream, string source) { }
        public NuGet.Packaging.PackageReaderBase PackageReader { get { throw null; } }
        public string PackageSource { get { throw null; } }
        public System.IO.Stream PackageStream { get { throw null; } }
        public bool SignatureVerified { get { throw null; } set { } }
        public NuGet.Protocol.Core.Types.DownloadResourceResultStatus Status { get { throw null; } }
        public void Dispose() { }
    }
    public enum DownloadResourceResultStatus
    {
        Available = 0,
        AvailableWithoutStream = 1,
        Cancelled = 3,
        NotFound = 2,
    }
    public partial class FatalProtocolException : NuGet.Protocol.Core.Types.NuGetProtocolException
    {
        public FatalProtocolException(string message) : base (default(string)) { }
        public FatalProtocolException(string message, System.Exception innerException) : base (default(string)) { }
    }
    public partial class FindPackageByIdDependencyInfo
    {
        public FindPackageByIdDependencyInfo(NuGet.Packaging.Core.PackageIdentity packageIdentity, System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> dependencyGroups, System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> frameworkReferenceGroups) { }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.PackageDependencyGroup> DependencyGroups { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.Packaging.FrameworkSpecificGroup> FrameworkReferenceGroups { get { throw null; } }
        public NuGet.Packaging.Core.PackageIdentity PackageIdentity { get { throw null; } }
    }
    public abstract partial class FindPackageByIdResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        protected FindPackageByIdResource() { }
        public abstract System.Threading.Tasks.Task<bool> CopyNupkgToStreamAsync(string id, NuGet.Versioning.NuGetVersion version, System.IO.Stream destination, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken);
        public abstract System.Threading.Tasks.Task<bool> DoesPackageExistAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken);
        public abstract System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetAllVersionsAsync(string id, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken);
        protected static NuGet.Protocol.Core.Types.FindPackageByIdDependencyInfo GetDependencyInfo(NuGet.Packaging.NuspecReader reader) { throw null; }
        public abstract System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.FindPackageByIdDependencyInfo> GetDependencyInfoAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken);
        public abstract System.Threading.Tasks.Task<NuGet.Packaging.IPackageDownloader> GetPackageDownloaderAsync(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken);
    }
    public abstract partial class HttpHandlerResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        protected HttpHandlerResource() { }
        public abstract System.Net.Http.HttpClientHandler ClientHandler { get; }
        public abstract System.Net.Http.HttpMessageHandler MessageHandler { get; }
    }
    public partial class HttpSourceCacheContext
    {
        internal HttpSourceCacheContext() { }
        public bool DirectDownload { get { throw null; } }
        public System.TimeSpan MaxAge { get { throw null; } }
        public string RootTempFolder { get { throw null; } }
        public NuGet.Protocol.Core.Types.SourceCacheContext SourceCacheContext { get { throw null; } }
        public static NuGet.Protocol.Core.Types.HttpSourceCacheContext Create(NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, int retryCount) { throw null; }
    }
    public partial interface ILegacyFeedCapabilityResource
    {
        System.Threading.Tasks.Task<bool> SupportsIsAbsoluteLatestVersionAsync(NuGet.Common.ILogger log, System.Threading.CancellationToken token);
        System.Threading.Tasks.Task<bool> SupportsSearchAsync(NuGet.Common.ILogger log, System.Threading.CancellationToken token);
    }
    public partial interface INuGetResource
    {
    }
    public partial interface INuGetResourceProvider
    {
        System.Collections.Generic.IEnumerable<string> After { get; }
        System.Collections.Generic.IEnumerable<string> Before { get; }
        string Name { get; }
        System.Type ResourceType { get; }
        System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token);
    }
    public partial interface IPackageSearchMetadata
    {
        string Authors { get; }
        System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> DependencySets { get; }
        string Description { get; }
        System.Nullable<long> DownloadCount { get; }
        System.Uri IconUrl { get; }
        NuGet.Packaging.Core.PackageIdentity Identity { get; }
        bool IsListed { get; }
        NuGet.Packaging.LicenseMetadata LicenseMetadata { get; }
        System.Uri LicenseUrl { get; }
        string Owners { get; }
        System.Uri PackageDetailsUrl { get; }
        bool PrefixReserved { get; }
        System.Uri ProjectUrl { get; }
        System.Nullable<System.DateTimeOffset> Published { get; }
        System.Uri ReportAbuseUrl { get; }
        bool RequireLicenseAcceptance { get; }
        string Summary { get; }
        string Tags { get; }
        string Title { get; }
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.VersionInfo>> GetVersionsAsync();
    }
    public partial interface ISourceRepositoryProvider
    {
        NuGet.Configuration.IPackageSourceProvider PackageSourceProvider { get; }
        NuGet.Protocol.Core.Types.SourceRepository CreateRepository(NuGet.Configuration.PackageSource source);
        NuGet.Protocol.Core.Types.SourceRepository CreateRepository(NuGet.Configuration.PackageSource source, NuGet.Protocol.FeedType type);
        System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.SourceRepository> GetRepositories();
    }
    public abstract partial class LegacyFeedCapabilityResource : NuGet.Protocol.Core.Types.ILegacyFeedCapabilityResource, NuGet.Protocol.Core.Types.INuGetResource
    {
        protected LegacyFeedCapabilityResource() { }
        public abstract System.Threading.Tasks.Task<bool> SupportsIsAbsoluteLatestVersionAsync(NuGet.Common.ILogger log, System.Threading.CancellationToken token);
        public abstract System.Threading.Tasks.Task<bool> SupportsSearchAsync(NuGet.Common.ILogger log, System.Threading.CancellationToken token);
    }
    public abstract partial class ListResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        protected ListResource() { }
        public abstract string Source { get; }
        public abstract System.Threading.Tasks.Task<NuGet.Common.IEnumerableAsync<NuGet.Protocol.Core.Types.IPackageSearchMetadata>> ListAsync(string searchTerm, bool prerelease, bool allVersions, bool includeDelisted, NuGet.Common.ILogger log, System.Threading.CancellationToken token);
    }
    public abstract partial class MetadataResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        protected MetadataResource() { }
        public System.Threading.Tasks.Task<bool> Exists(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public abstract System.Threading.Tasks.Task<bool> Exists(NuGet.Packaging.Core.PackageIdentity identity, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token);
        public System.Threading.Tasks.Task<bool> Exists(string packageId, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public abstract System.Threading.Tasks.Task<bool> Exists(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token);
        public System.Threading.Tasks.Task<NuGet.Versioning.NuGetVersion> GetLatestVersion(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public abstract System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, NuGet.Versioning.NuGetVersion>>> GetLatestVersions(System.Collections.Generic.IEnumerable<string> packageIds, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token);
        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetVersions(string packageId, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token) { throw null; }
        public abstract System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetVersions(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token);
    }
    public abstract partial class NuGetProtocolException : System.Exception
    {
        public NuGetProtocolException(string message) { }
        public NuGetProtocolException(string message, System.Exception innerException) { }
    }
    public sealed partial class NuGetResourceProviderPositions
    {
        public const string First = "First";
        public const string Last = "Last";
        public NuGetResourceProviderPositions() { }
    }
    public static partial class NuGetTestMode
    {
        public const string NuGetTestClientName = "NuGet Test Client";
        public static bool Enabled { get { throw null; } }
        public static T InvokeTestFunctionAgainstTestMode<T>(System.Func<T> function, bool testModeEnabled) { throw null; }
    }
    public partial class NullSourceCacheContext : NuGet.Protocol.Core.Types.SourceCacheContext
    {
        public NullSourceCacheContext() { }
        public override string GeneratedTempFolder { get { throw null; } }
        public static NuGet.Protocol.Core.Types.SourceCacheContext Instance { get { throw null; } }
        public override NuGet.Protocol.Core.Types.SourceCacheContext Clone() { throw null; }
        public override NuGet.Protocol.Core.Types.SourceCacheContext WithRefreshCacheTrue() { throw null; }
    }
    public partial class OfflineFeedAddContext
    {
        public OfflineFeedAddContext(string packagePath, string source, NuGet.Common.ILogger logger, bool throwIfSourcePackageIsInvalid, bool throwIfPackageExistsAndInvalid, bool throwIfPackageExists, NuGet.Packaging.PackageExtractionContext extractionContext) { }
        public NuGet.Packaging.PackageExtractionContext ExtractionContext { get { throw null; } }
        public NuGet.Common.ILogger Logger { get { throw null; } }
        public string PackagePath { get { throw null; } }
        public string Source { get { throw null; } }
        public bool ThrowIfPackageExists { get { throw null; } }
        public bool ThrowIfPackageExistsAndInvalid { get { throw null; } }
        public bool ThrowIfSourcePackageIsInvalid { get { throw null; } }
    }
    public static partial class OfflineFeedUtility
    {
        public static System.Threading.Tasks.Task AddPackageToSource(NuGet.Protocol.Core.Types.OfflineFeedAddContext offlineFeedAddContext, System.Threading.CancellationToken token) { throw null; }
        public static string GetPackageDirectory(NuGet.Packaging.Core.PackageIdentity packageIdentity, string offlineFeed) { throw null; }
        public static bool PackageExists(NuGet.Packaging.Core.PackageIdentity packageIdentity, string offlineFeed, out bool isValidPackage) { throw null; }
        public static void ThrowIfInvalid(string path) { }
        public static void ThrowIfInvalidOrNotFound(string path, bool isDirectory, string resourceString) { }
    }
    public partial class PackageDownloadContext
    {
        public PackageDownloadContext(NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext) { }
        public PackageDownloadContext(NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, string directDownloadDirectory, bool directDownload) { }
        public NuGet.Packaging.Signing.ClientPolicyContext ClientPolicyContext { get { throw null; } set { } }
        public bool DirectDownload { get { throw null; } }
        public string DirectDownloadDirectory { get { throw null; } }
        public System.Guid ParentId { get { throw null; } set { } }
        public NuGet.Protocol.Core.Types.SourceCacheContext SourceCacheContext { get { throw null; } }
    }
    public abstract partial class PackageMetadataResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        protected PackageMetadataResource() { }
        public abstract System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.IPackageSearchMetadata> GetMetadataAsync(NuGet.Packaging.Core.PackageIdentity package, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token);
        public abstract System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.IPackageSearchMetadata>> GetMetadataAsync(string packageId, bool includePrerelease, bool includeUnlisted, NuGet.Protocol.Core.Types.SourceCacheContext sourceCacheContext, NuGet.Common.ILogger log, System.Threading.CancellationToken token);
    }
    public partial class PackageProgressEventArgs : System.EventArgs
    {
        public PackageProgressEventArgs(NuGet.Packaging.Core.PackageIdentity identity, NuGet.Configuration.PackageSource source, double complete) { }
        public double Complete { get { throw null; } }
        public bool HasPackageSource { get { throw null; } }
        public bool IsComplete { get { throw null; } }
        public NuGet.Packaging.Core.PackageIdentity PackageIdentity { get { throw null; } }
        public NuGet.Configuration.PackageSource PackageSource { get { throw null; } }
    }
    public partial class PackageSearchMetadataBuilder
    {
        internal PackageSearchMetadataBuilder() { }
        public NuGet.Protocol.Core.Types.IPackageSearchMetadata Build() { throw null; }
        public static NuGet.Protocol.Core.Types.PackageSearchMetadataBuilder FromIdentity(NuGet.Packaging.Core.PackageIdentity identity) { throw null; }
        public static NuGet.Protocol.Core.Types.PackageSearchMetadataBuilder FromMetadata(NuGet.Protocol.Core.Types.IPackageSearchMetadata metadata) { throw null; }
        public NuGet.Protocol.Core.Types.PackageSearchMetadataBuilder WithVersions(NuGet.Common.AsyncLazy<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.VersionInfo>> lazyVersionsFactory) { throw null; }
        public partial class ClonedPackageSearchMetadata : NuGet.Protocol.Core.Types.IPackageSearchMetadata
        {
            public ClonedPackageSearchMetadata() { }
            public string Authors { get { throw null; } set { } }
            public System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> DependencySets { get { throw null; } set { } }
            public string Description { get { throw null; } set { } }
            public System.Nullable<long> DownloadCount { get { throw null; } set { } }
            public System.Uri IconUrl { get { throw null; } set { } }
            public NuGet.Packaging.Core.PackageIdentity Identity { get { throw null; } set { } }
            public bool IsListed { get { throw null; } set { } }
            public NuGet.Common.AsyncLazy<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.VersionInfo>> LazyVersionsFactory { get { throw null; } set { } }
            public NuGet.Packaging.LicenseMetadata LicenseMetadata { get { throw null; } set { } }
            public System.Uri LicenseUrl { get { throw null; } set { } }
            public string Owners { get { throw null; } set { } }
            public System.Uri PackageDetailsUrl { get { throw null; } set { } }
            public bool PrefixReserved { get { throw null; } set { } }
            public System.Uri ProjectUrl { get { throw null; } set { } }
            public System.Nullable<System.DateTimeOffset> Published { get { throw null; } set { } }
            public System.Uri ReportAbuseUrl { get { throw null; } set { } }
            public bool RequireLicenseAcceptance { get { throw null; } set { } }
            public string Summary { get { throw null; } set { } }
            public string Tags { get { throw null; } set { } }
            public string Title { get { throw null; } set { } }
            public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.VersionInfo>> GetVersionsAsync() { throw null; }
        }
    }
    public static partial class PackageSearchMetadataExtensions
    {
        public static NuGet.Protocol.Core.Types.IPackageSearchMetadata WithVersions(this NuGet.Protocol.Core.Types.IPackageSearchMetadata metadata, System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.VersionInfo> versions) { throw null; }
        public static NuGet.Protocol.Core.Types.IPackageSearchMetadata WithVersions(this NuGet.Protocol.Core.Types.IPackageSearchMetadata metadata, System.Func<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.VersionInfo>> valueFactory) { throw null; }
        public static NuGet.Protocol.Core.Types.IPackageSearchMetadata WithVersions(this NuGet.Protocol.Core.Types.IPackageSearchMetadata metadata, System.Func<System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.VersionInfo>>> asyncValueFactory) { throw null; }
    }
    public abstract partial class PackageSearchResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        protected PackageSearchResource() { }
        public abstract System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.IPackageSearchMetadata>> SearchAsync(string searchTerm, NuGet.Protocol.Core.Types.SearchFilter filters, int skip, int take, NuGet.Common.ILogger log, System.Threading.CancellationToken cancellationToken);
    }
    public partial class PackageUpdateResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        public PackageUpdateResource(string source, NuGet.Protocol.HttpSource httpSource) { }
        public NuGet.Configuration.ISettings Settings { get { throw null; } set { } }
        public System.Uri SourceUri { get { throw null; } }
        public System.Threading.Tasks.Task Delete(string packageId, string packageVersion, System.Func<string, string> getApiKey, System.Func<string, bool> confirm, bool noServiceEndpoint, NuGet.Common.ILogger log) { throw null; }
        public static void ForceDeleteDirectory(string path) { }
        public System.Threading.Tasks.Task Push(string packagePath, string symbolSource, int timeoutInSecond, bool disableBuffering, System.Func<string, string> getApiKey, System.Func<string, string> getSymbolApiKey, bool noServiceEndpoint, NuGet.Common.ILogger log) { throw null; }
        public System.Threading.Tasks.Task Push(string packagePath, string symbolSource, int timeoutInSecond, bool disableBuffering, System.Func<string, string> getApiKey, System.Func<string, string> getSymbolApiKey, bool noServiceEndpoint, bool skipDuplicate, NuGet.Protocol.Core.Types.SymbolPackageUpdateResourceV3 symbolPackageUpdateResource, NuGet.Common.ILogger log) { throw null; }
    }
    public sealed partial class PluginFindPackageByIdResource : NuGet.Protocol.Core.Types.FindPackageByIdResource
    {
        public PluginFindPackageByIdResource(NuGet.Protocol.Plugins.IPlugin plugin, NuGet.Protocol.Plugins.IPluginMulticlientUtilities utilities, NuGet.Configuration.PackageSource packageSource) { }
        public override System.Threading.Tasks.Task<bool> CopyNupkgToStreamAsync(string id, NuGet.Versioning.NuGetVersion version, System.IO.Stream destination, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<bool> DoesPackageExistAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Versioning.NuGetVersion>> GetAllVersionsAsync(string id, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.FindPackageByIdDependencyInfo> GetDependencyInfoAsync(string id, NuGet.Versioning.NuGetVersion version, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Packaging.IPackageDownloader> GetPackageDownloaderAsync(NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Protocol.Core.Types.SourceCacheContext cacheContext, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class PluginResource : NuGet.Protocol.Core.Types.INuGetResource
    {
        public PluginResource(System.Collections.Generic.IEnumerable<NuGet.Protocol.Plugins.PluginCreationResult> pluginCreationResults, NuGet.Configuration.PackageSource packageSource, NuGet.Configuration.ICredentialService credentialService) { }
        public System.Threading.Tasks.Task<NuGet.Protocol.Core.Types.PluginResource.GetPluginResult> GetPluginAsync(NuGet.Protocol.Plugins.OperationClaim requiredClaim, System.Threading.CancellationToken cancellationToken) { throw null; }
        public sealed partial class GetPluginResult
        {
            internal GetPluginResult() { }
            public NuGet.Protocol.Plugins.IPlugin Plugin { get { throw null; } }
            public NuGet.Protocol.Plugins.IPluginMulticlientUtilities PluginMulticlientUtilities { get { throw null; } }
        }
    }
    public partial class PluginResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public PluginResourceProvider() : base (default(System.Type)) { }
        public PluginResourceProvider(NuGet.Protocol.Plugins.IPluginManager pluginManager) : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class RemoteSourceDependencyInfo : System.IEquatable<NuGet.Protocol.Core.Types.RemoteSourceDependencyInfo>
    {
        public RemoteSourceDependencyInfo(NuGet.Packaging.Core.PackageIdentity identity, bool listed, System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> dependencyGroups, string contentUri) { }
        public string ContentUri { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> DependencyGroups { get { throw null; } }
        public NuGet.Packaging.Core.PackageIdentity Identity { get { throw null; } }
        public bool Listed { get { throw null; } }
        public bool Equals(NuGet.Protocol.Core.Types.RemoteSourceDependencyInfo other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class Repository
    {
        public static NuGet.Protocol.Core.Types.Repository.RepositoryFactory Factory { get { throw null; } }
        public static NuGet.Protocol.Core.Types.Repository.ProviderFactory Provider { get { throw null; } }
        public static NuGet.Protocol.Core.Types.ISourceRepositoryProvider CreateProvider(System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.INuGetResourceProvider> resourceProviders) { throw null; }
        public static NuGet.Protocol.Core.Types.ISourceRepositoryProvider CreateProvider(System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.INuGetResourceProvider> resourceProviders, string rootPath) { throw null; }
        public static NuGet.Protocol.Core.Types.SourceRepository CreateSource(System.Collections.Generic.IEnumerable<System.Lazy<NuGet.Protocol.Core.Types.INuGetResourceProvider>> resourceProviders, NuGet.Configuration.PackageSource source) { throw null; }
        public static NuGet.Protocol.Core.Types.SourceRepository CreateSource(System.Collections.Generic.IEnumerable<System.Lazy<NuGet.Protocol.Core.Types.INuGetResourceProvider>> resourceProviders, NuGet.Configuration.PackageSource source, NuGet.Protocol.FeedType type) { throw null; }
        public static NuGet.Protocol.Core.Types.SourceRepository CreateSource(System.Collections.Generic.IEnumerable<System.Lazy<NuGet.Protocol.Core.Types.INuGetResourceProvider>> resourceProviders, string sourceUrl) { throw null; }
        public static NuGet.Protocol.Core.Types.SourceRepository CreateSource(System.Collections.Generic.IEnumerable<System.Lazy<NuGet.Protocol.Core.Types.INuGetResourceProvider>> resourceProviders, string sourceUrl, NuGet.Protocol.FeedType type) { throw null; }
        public partial class ProviderFactory
        {
            public ProviderFactory() { }
        }
        public partial class RepositoryFactory
        {
            public RepositoryFactory() { }
        }
    }
    public abstract partial class ResourceProvider : NuGet.Protocol.Core.Types.INuGetResourceProvider
    {
        public ResourceProvider(System.Type resourceType) { }
        public ResourceProvider(System.Type resourceType, string name) { }
        public ResourceProvider(System.Type resourceType, string name, System.Collections.Generic.IEnumerable<string> before, System.Collections.Generic.IEnumerable<string> after) { }
        public ResourceProvider(System.Type resourceType, string name, string before) { }
        public virtual System.Collections.Generic.IEnumerable<string> After { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<string> Before { get { throw null; } }
        public virtual string Name { get { throw null; } }
        public virtual System.Type ResourceType { get { throw null; } }
        public abstract System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token);
    }
    public partial class RetriableProtocolException : NuGet.Protocol.Core.Types.NuGetProtocolException
    {
        public RetriableProtocolException(string message) : base (default(string)) { }
        public RetriableProtocolException(string message, System.Exception innerException) : base (default(string)) { }
    }
    public partial class SearchFilter
    {
        public SearchFilter(bool includePrerelease) { }
        public SearchFilter(bool includePrerelease, System.Nullable<NuGet.Protocol.Core.Types.SearchFilterType> filter) { }
        public System.Nullable<NuGet.Protocol.Core.Types.SearchFilterType> Filter { get { throw null; } }
        public bool IncludeDelisted { get { throw null; } set { } }
        public bool IncludePrerelease { get { throw null; } }
        public System.Nullable<NuGet.Protocol.Core.Types.SearchOrderBy> OrderBy { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> PackageTypes { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<string> SupportedFrameworks { get { throw null; } set { } }
    }
    public enum SearchFilterType
    {
        IsAbsoluteLatestVersion = 1,
        IsLatestVersion = 0,
    }
    public enum SearchOrderBy
    {
        Id = 0,
    }
    public partial class SourceCacheContext : System.IDisposable
    {
        public SourceCacheContext() { }
        public bool DirectDownload { get { throw null; } set { } }
        public virtual string GeneratedTempFolder { get { throw null; } set { } }
        public bool IgnoreFailedSources { get { throw null; } set { } }
        public System.Nullable<System.DateTimeOffset> MaxAge { get { throw null; } set { } }
        public System.TimeSpan MaxAgeTimeSpan { get { throw null; } }
        public bool NoCache { get { throw null; } set { } }
        public bool RefreshMemoryCache { get { throw null; } set { } }
        public System.Guid SessionId { get { throw null; } set { } }
        public virtual NuGet.Protocol.Core.Types.SourceCacheContext Clone() { throw null; }
        public void Dispose() { }
        public virtual NuGet.Protocol.Core.Types.SourceCacheContext WithRefreshCacheTrue() { throw null; }
    }
    public partial class SourcePackageDependencyInfo : NuGet.Packaging.Core.PackageDependencyInfo
    {
        public SourcePackageDependencyInfo(NuGet.Packaging.Core.PackageIdentity identity, System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependency> dependencies, bool listed, NuGet.Protocol.Core.Types.SourceRepository source, System.Uri downloadUri, string packageHash) : base (default(string), default(NuGet.Versioning.NuGetVersion)) { }
        public SourcePackageDependencyInfo(string id, NuGet.Versioning.NuGetVersion version, System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependency> dependencies, bool listed, NuGet.Protocol.Core.Types.SourceRepository source) : base (default(string), default(NuGet.Versioning.NuGetVersion)) { }
        public SourcePackageDependencyInfo(string id, NuGet.Versioning.NuGetVersion version, System.Collections.Generic.IEnumerable<NuGet.Packaging.Core.PackageDependency> dependencies, bool listed, NuGet.Protocol.Core.Types.SourceRepository source, System.Uri downloadUri, string packageHash) : base (default(string), default(NuGet.Versioning.NuGetVersion)) { }
        public System.Uri DownloadUri { get { throw null; } }
        public bool Listed { get { throw null; } }
        public string PackageHash { get { throw null; } }
        public NuGet.Protocol.Core.Types.SourceRepository Source { get { throw null; } }
    }
    public partial class SourceRepository
    {
        protected SourceRepository() { }
        public SourceRepository(NuGet.Configuration.PackageSource source, System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.INuGetResourceProvider> providers) { }
        public SourceRepository(NuGet.Configuration.PackageSource source, System.Collections.Generic.IEnumerable<System.Lazy<NuGet.Protocol.Core.Types.INuGetResourceProvider>> providers) { }
        public SourceRepository(NuGet.Configuration.PackageSource source, System.Collections.Generic.IEnumerable<System.Lazy<NuGet.Protocol.Core.Types.INuGetResourceProvider>> providers, NuGet.Protocol.FeedType feedTypeOverride) { }
        public NuGet.Protocol.FeedType FeedTypeOverride { get { throw null; } }
        public virtual NuGet.Configuration.PackageSource PackageSource { get { throw null; } }
        public virtual System.Threading.Tasks.Task<NuGet.Protocol.FeedType> GetFeedType(System.Threading.CancellationToken token) { throw null; }
        public virtual System.Threading.Tasks.Task<T> GetResourceAsync<T>() where T : class, NuGet.Protocol.Core.Types.INuGetResource { throw null; }
        public virtual System.Threading.Tasks.Task<T> GetResourceAsync<T>(System.Threading.CancellationToken token) where T : class, NuGet.Protocol.Core.Types.INuGetResource { throw null; }
        public virtual T GetResource<T>() where T : class, NuGet.Protocol.Core.Types.INuGetResource { throw null; }
        public virtual T GetResource<T>(System.Threading.CancellationToken token) where T : class, NuGet.Protocol.Core.Types.INuGetResource { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SourceRepositoryProvider : NuGet.Protocol.Core.Types.ISourceRepositoryProvider
    {
        public SourceRepositoryProvider(NuGet.Configuration.IPackageSourceProvider packageSourceProvider, System.Collections.Generic.IEnumerable<System.Lazy<NuGet.Protocol.Core.Types.INuGetResourceProvider>> resourceProviders) { }
        public SourceRepositoryProvider(NuGet.Configuration.ISettings settings, System.Collections.Generic.IEnumerable<System.Lazy<NuGet.Protocol.Core.Types.INuGetResourceProvider>> resourceProviders) { }
        public NuGet.Configuration.IPackageSourceProvider PackageSourceProvider { get { throw null; } }
        public NuGet.Protocol.Core.Types.SourceRepository CreateRepository(NuGet.Configuration.PackageSource source) { throw null; }
        public NuGet.Protocol.Core.Types.SourceRepository CreateRepository(NuGet.Configuration.PackageSource source, NuGet.Protocol.FeedType type) { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Protocol.Core.Types.SourceRepository> GetRepositories() { throw null; }
    }
    public partial class SymbolPackageUpdateResourceV3 : NuGet.Protocol.Core.Types.INuGetResource
    {
        public SymbolPackageUpdateResourceV3(string source, NuGet.Protocol.HttpSource httpSource) { }
        public System.Uri SourceUri { get { throw null; } }
    }
    public static partial class UserAgent
    {
        public static string UserAgentString { get { throw null; } }
        public static void SetUserAgent(System.Net.Http.HttpClient client) { }
        public static void SetUserAgentString(NuGet.Protocol.Core.Types.UserAgentStringBuilder builder) { }
    }
    public partial class UserAgentStringBuilder
    {
        public static readonly string DefaultNuGetClientName;
        public UserAgentStringBuilder() { }
        public UserAgentStringBuilder(string clientName) { }
        public string NuGetClientVersion { get { throw null; } }
        public string Build() { throw null; }
        public NuGet.Protocol.Core.Types.UserAgentStringBuilder WithOSDescription(string osInfo) { throw null; }
        public NuGet.Protocol.Core.Types.UserAgentStringBuilder WithVisualStudioSKU(string vsInfo) { throw null; }
    }
    public partial class VersionInfo
    {
        public VersionInfo(NuGet.Versioning.NuGetVersion version) { }
        public VersionInfo(NuGet.Versioning.NuGetVersion version, System.Nullable<long> downloadCount) { }
        public VersionInfo(NuGet.Versioning.NuGetVersion version, string downloadCount) { }
        public System.Nullable<long> DownloadCount { get { throw null; } }
        public NuGet.Protocol.Core.Types.IPackageSearchMetadata PackageSearchMetadata { get { throw null; } set { } }
        public NuGet.Versioning.NuGetVersion Version { get { throw null; } }
    }
}
namespace NuGet.Protocol.LocalRepositories
{
    public partial class LocalPackageListResourceProvider : NuGet.Protocol.Core.Types.ResourceProvider
    {
        public LocalPackageListResourceProvider() : base (default(System.Type)) { }
        public override System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Core.Types.INuGetResource>> TryCreate(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken token) { throw null; }
    }
}
namespace NuGet.Protocol.Plugins
{
    public sealed partial class AutomaticProgressReporter : System.IDisposable
    {
        internal AutomaticProgressReporter() { }
        public static NuGet.Protocol.Plugins.AutomaticProgressReporter Create(NuGet.Protocol.Plugins.IConnection connection, NuGet.Protocol.Plugins.Message request, System.TimeSpan interval, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void Dispose() { }
    }
    public sealed partial class CloseRequestHandler : NuGet.Protocol.Plugins.IRequestHandler, System.IDisposable
    {
        public CloseRequestHandler(NuGet.Protocol.Plugins.IPlugin plugin) { }
        public System.Threading.CancellationToken CancellationToken { get { throw null; } }
        public void Dispose() { }
        public System.Threading.Tasks.Task HandleResponseAsync(NuGet.Protocol.Plugins.IConnection connection, NuGet.Protocol.Plugins.Message request, NuGet.Protocol.Plugins.IResponseHandler responseHandler, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class Connection : NuGet.Protocol.Plugins.IConnection, System.IDisposable
    {
        public Connection(NuGet.Protocol.Plugins.IMessageDispatcher dispatcher, NuGet.Protocol.Plugins.ISender sender, NuGet.Protocol.Plugins.IReceiver receiver, NuGet.Protocol.Plugins.ConnectionOptions options) { }
        public NuGet.Protocol.Plugins.IMessageDispatcher MessageDispatcher { get { throw null; } }
        public NuGet.Protocol.Plugins.ConnectionOptions Options { get { throw null; } }
        public NuGet.Versioning.SemanticVersion ProtocolVersion { get { throw null; } }
        public NuGet.Protocol.Plugins.ConnectionState State { get { throw null; } }
        public event System.EventHandler<NuGet.Protocol.Plugins.ProtocolErrorEventArgs> Faulted { add { } remove { } }
        public event System.EventHandler<NuGet.Protocol.Plugins.MessageEventArgs> MessageReceived { add { } remove { } }
        public void Close() { }
        public System.Threading.Tasks.Task ConnectAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public void Dispose() { }
        public System.Threading.Tasks.Task SendAsync(NuGet.Protocol.Plugins.Message message, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<TInbound> SendRequestAndReceiveResponseAsync<TOutbound, TInbound>(NuGet.Protocol.Plugins.MessageMethod method, TOutbound payload, System.Threading.CancellationToken cancellationToken) where TOutbound : class where TInbound : class { throw null; }
    }
    public sealed partial class ConnectionOptions
    {
        public ConnectionOptions(NuGet.Versioning.SemanticVersion protocolVersion, NuGet.Versioning.SemanticVersion minimumProtocolVersion, System.TimeSpan handshakeTimeout, System.TimeSpan requestTimeout) { }
        public System.TimeSpan HandshakeTimeout { get { throw null; } }
        public NuGet.Versioning.SemanticVersion MinimumProtocolVersion { get { throw null; } }
        public NuGet.Versioning.SemanticVersion ProtocolVersion { get { throw null; } }
        public System.TimeSpan RequestTimeout { get { throw null; } }
        public static NuGet.Protocol.Plugins.ConnectionOptions CreateDefault(NuGet.Common.IEnvironmentVariableReader reader = null) { throw null; }
        public void SetRequestTimeout(System.TimeSpan requestTimeout) { }
    }
    public enum ConnectionState
    {
        Closed = 2,
        Closing = 1,
        Connected = 6,
        Connecting = 4,
        FailedToHandshake = 0,
        Handshaking = 5,
        ReadyToConnect = 3,
    }
    public sealed partial class CopyFilesInPackageRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public CopyFilesInPackageRequest(string packageSourceRepository, string packageId, string packageVersion, System.Collections.Generic.IEnumerable<string> filesInPackage, string destinationFolderPath) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string DestinationFolderPath { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public System.Collections.Generic.IEnumerable<string> FilesInPackage { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageId { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageSourceRepository { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageVersion { get { throw null; } }
    }
    public sealed partial class CopyFilesInPackageResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public CopyFilesInPackageResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode, System.Collections.Generic.IEnumerable<string> copiedFiles) { }
        public System.Collections.Generic.IEnumerable<string> CopiedFiles { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
    }
    public sealed partial class CopyNupkgFileRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public CopyNupkgFileRequest(string packageSourceRepository, string packageId, string packageVersion, string destinationFilePath) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string DestinationFilePath { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageId { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageSourceRepository { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageVersion { get { throw null; } }
    }
    public sealed partial class CopyNupkgFileResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public CopyNupkgFileResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
    }
    public abstract partial class EmbeddedSignatureVerifier
    {
        protected EmbeddedSignatureVerifier() { }
        public static NuGet.Protocol.Plugins.EmbeddedSignatureVerifier Create() { throw null; }
        public abstract bool IsValid(string filePath);
    }
    public sealed partial class FallbackEmbeddedSignatureVerifier : NuGet.Protocol.Plugins.EmbeddedSignatureVerifier
    {
        public FallbackEmbeddedSignatureVerifier() { }
        public override bool IsValid(string filePath) { throw null; }
    }
    public sealed partial class Fault
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public Fault(string message) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string Message { get { throw null; } }
    }
    public sealed partial class FaultedPluginEventArgs : System.EventArgs
    {
        public FaultedPluginEventArgs(NuGet.Protocol.Plugins.IPlugin plugin, System.Exception exception) { }
        public System.Exception Exception { get { throw null; } }
        public NuGet.Protocol.Plugins.IPlugin Plugin { get { throw null; } }
    }
    public sealed partial class GetAuthenticationCredentialsRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetAuthenticationCredentialsRequest(System.Uri uri, bool isRetry, bool isNonInteractive, bool canShowDialog) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public bool CanShowDialog { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public bool IsNonInteractive { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public bool IsRetry { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public System.Uri Uri { get { throw null; } }
    }
    public sealed partial class GetAuthenticationCredentialsResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetAuthenticationCredentialsResponse(string username, string password, string message, System.Collections.Generic.IList<string> authenticationTypes, NuGet.Protocol.Plugins.MessageResponseCode responseCode) { }
        public System.Collections.Generic.IList<string> AuthenticationTypes { get { throw null; } }
        public string Message { get { throw null; } }
        public string Password { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
        public string Username { get { throw null; } }
        public bool IsValid() { throw null; }
    }
    public sealed partial class GetCredentialsRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetCredentialsRequest(string packageSourceRepository, System.Net.HttpStatusCode statusCode) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageSourceRepository { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public System.Net.HttpStatusCode StatusCode { get { throw null; } }
    }
    public sealed partial class GetCredentialsRequestHandler : NuGet.Protocol.Plugins.IRequestHandler, System.IDisposable
    {
        public GetCredentialsRequestHandler(NuGet.Protocol.Plugins.IPlugin plugin, System.Net.IWebProxy proxy, NuGet.Configuration.ICredentialService credentialService) { }
        public System.Threading.CancellationToken CancellationToken { get { throw null; } }
        public void AddOrUpdateSourceRepository(NuGet.Protocol.Core.Types.SourceRepository sourceRepository) { }
        public void Dispose() { }
        public System.Threading.Tasks.Task HandleResponseAsync(NuGet.Protocol.Plugins.IConnection connection, NuGet.Protocol.Plugins.Message request, NuGet.Protocol.Plugins.IResponseHandler responseHandler, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class GetCredentialsResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetCredentialsResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode, string username, string password, System.Collections.Generic.IReadOnlyList<string> authenticationTypes = null) { }
        public System.Collections.Generic.IReadOnlyList<string> AuthenticationTypes { get { throw null; } }
        public string Password { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
        public string Username { get { throw null; } }
    }
    public sealed partial class GetFilesInPackageRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetFilesInPackageRequest(string packageSourceRepository, string packageId, string packageVersion) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageId { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageSourceRepository { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageVersion { get { throw null; } }
    }
    public sealed partial class GetFilesInPackageResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetFilesInPackageResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode, System.Collections.Generic.IEnumerable<string> files) { }
        public System.Collections.Generic.IEnumerable<string> Files { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
    }
    public sealed partial class GetOperationClaimsRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetOperationClaimsRequest(string packageSourceRepository, Newtonsoft.Json.Linq.JObject serviceIndex) { }
        public string PackageSourceRepository { get { throw null; } }
        public Newtonsoft.Json.Linq.JObject ServiceIndex { get { throw null; } }
    }
    public sealed partial class GetOperationClaimsResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetOperationClaimsResponse(System.Collections.Generic.IEnumerable<NuGet.Protocol.Plugins.OperationClaim> claims) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public System.Collections.Generic.IReadOnlyList<NuGet.Protocol.Plugins.OperationClaim> Claims { get { throw null; } }
    }
    public sealed partial class GetPackageHashRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetPackageHashRequest(string packageSourceRepository, string packageId, string packageVersion, string hashAlgorithm) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string HashAlgorithm { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageId { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageSourceRepository { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageVersion { get { throw null; } }
    }
    public sealed partial class GetPackageHashResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetPackageHashResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode, string hash) { }
        public string Hash { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
    }
    public sealed partial class GetPackageVersionsRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetPackageVersionsRequest(string packageSourceRepository, string packageId) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageId { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageSourceRepository { get { throw null; } }
    }
    public sealed partial class GetPackageVersionsResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetPackageVersionsResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode, System.Collections.Generic.IEnumerable<string> versions) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> Versions { get { throw null; } }
    }
    public sealed partial class GetServiceIndexRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetServiceIndexRequest(string packageSourceRepository) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageSourceRepository { get { throw null; } }
    }
    public sealed partial class GetServiceIndexRequestHandler : NuGet.Protocol.Plugins.IRequestHandler, System.IDisposable
    {
        public GetServiceIndexRequestHandler(NuGet.Protocol.Plugins.IPlugin plugin) { }
        public System.Threading.CancellationToken CancellationToken { get { throw null; } }
        public void AddOrUpdateSourceRepository(NuGet.Protocol.Core.Types.SourceRepository sourceRepository) { }
        public void Dispose() { }
        public System.Threading.Tasks.Task HandleResponseAsync(NuGet.Protocol.Plugins.IConnection connection, NuGet.Protocol.Plugins.Message request, NuGet.Protocol.Plugins.IResponseHandler responseHandler, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class GetServiceIndexResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public GetServiceIndexResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode, Newtonsoft.Json.Linq.JObject serviceIndex) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
        public Newtonsoft.Json.Linq.JObject ServiceIndex { get { throw null; } }
    }
    public sealed partial class HandshakeRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public HandshakeRequest(NuGet.Versioning.SemanticVersion protocolVersion, NuGet.Versioning.SemanticVersion minimumProtocolVersion) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Versioning.SemanticVersion MinimumProtocolVersion { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Versioning.SemanticVersion ProtocolVersion { get { throw null; } }
    }
    public sealed partial class HandshakeResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public HandshakeResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode, NuGet.Versioning.SemanticVersion protocolVersion) { }
        public NuGet.Versioning.SemanticVersion ProtocolVersion { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
    }
    public partial interface IConnection : System.IDisposable
    {
        NuGet.Protocol.Plugins.IMessageDispatcher MessageDispatcher { get; }
        NuGet.Protocol.Plugins.ConnectionOptions Options { get; }
        NuGet.Versioning.SemanticVersion ProtocolVersion { get; }
        event System.EventHandler<NuGet.Protocol.Plugins.ProtocolErrorEventArgs> Faulted;
        event System.EventHandler<NuGet.Protocol.Plugins.MessageEventArgs> MessageReceived;
        void Close();
        System.Threading.Tasks.Task SendAsync(NuGet.Protocol.Plugins.Message message, System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<TInbound> SendRequestAndReceiveResponseAsync<TOutbound, TInbound>(NuGet.Protocol.Plugins.MessageMethod method, TOutbound payload, System.Threading.CancellationToken cancellationToken) where TOutbound : class where TInbound : class;
    }
    public partial interface IIdGenerator
    {
        string GenerateUniqueId();
    }
    public partial interface IMessageDispatcher : System.IDisposable
    {
        NuGet.Protocol.Plugins.IRequestHandlers RequestHandlers { get; }
        void Close();
        NuGet.Protocol.Plugins.Message CreateMessage(NuGet.Protocol.Plugins.MessageType type, NuGet.Protocol.Plugins.MessageMethod method);
        NuGet.Protocol.Plugins.Message CreateMessage<TPayload>(NuGet.Protocol.Plugins.MessageType type, NuGet.Protocol.Plugins.MessageMethod method, TPayload payload) where TPayload : class;
        System.Threading.Tasks.Task DispatchCancelAsync(NuGet.Protocol.Plugins.Message request, System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task DispatchFaultAsync(NuGet.Protocol.Plugins.Message request, NuGet.Protocol.Plugins.Fault fault, System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task DispatchProgressAsync(NuGet.Protocol.Plugins.Message request, NuGet.Protocol.Plugins.Progress progress, System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<TInbound> DispatchRequestAsync<TOutbound, TInbound>(NuGet.Protocol.Plugins.MessageMethod method, TOutbound payload, System.Threading.CancellationToken cancellationToken) where TOutbound : class where TInbound : class;
        System.Threading.Tasks.Task DispatchResponseAsync<TOutbound>(NuGet.Protocol.Plugins.Message request, TOutbound responsePayload, System.Threading.CancellationToken cancellationToken) where TOutbound : class;
        void SetConnection(NuGet.Protocol.Plugins.IConnection connection);
    }
    public sealed partial class InboundRequestContext : System.IDisposable
    {
        public InboundRequestContext(NuGet.Protocol.Plugins.IConnection connection, string requestId, System.Threading.CancellationToken cancellationToken) { }
        public string RequestId { get { throw null; } }
        public void BeginFaultAsync(NuGet.Protocol.Plugins.Message request, System.Exception exception) { }
        public void BeginResponseAsync(NuGet.Protocol.Plugins.Message request, NuGet.Protocol.Plugins.IRequestHandler requestHandler, NuGet.Protocol.Plugins.IResponseHandler responseHandler) { }
        public void Cancel() { }
        public void Dispose() { }
    }
    public sealed partial class InitializeRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public InitializeRequest(string clientVersion, string culture, System.TimeSpan requestTimeout) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string ClientVersion { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string Culture { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public System.TimeSpan RequestTimeout { get { throw null; } }
    }
    public sealed partial class InitializeResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public InitializeResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
    }
    public partial interface IPlugin : System.IDisposable
    {
        NuGet.Protocol.Plugins.IConnection Connection { get; }
        string FilePath { get; }
        string Id { get; }
        string Name { get; }
        event System.EventHandler BeforeClose;
        event System.EventHandler Closed;
        void Close();
    }
    public partial interface IPluginDiscoverer : System.IDisposable
    {
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Plugins.PluginDiscoveryResult>> DiscoverAsync(System.Threading.CancellationToken cancellationToken);
    }
    public partial interface IPluginFactory : System.IDisposable
    {
        System.Threading.Tasks.Task<NuGet.Protocol.Plugins.IPlugin> GetOrCreateAsync(string filePath, System.Collections.Generic.IEnumerable<string> arguments, NuGet.Protocol.Plugins.IRequestHandlers requestHandlers, NuGet.Protocol.Plugins.ConnectionOptions options, System.Threading.CancellationToken sessionCancellationToken);
    }
    public partial interface IPluginManager
    {
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Plugins.PluginCreationResult>> CreatePluginsAsync(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Plugins.PluginDiscoveryResult>> FindAvailablePluginsAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Plugins.PluginCreationResult>> TryGetSourceAgnosticPluginAsync(NuGet.Protocol.Plugins.PluginDiscoveryResult pluginDiscoveryResult, NuGet.Protocol.Plugins.OperationClaim requestedOperationClaim, System.Threading.CancellationToken cancellationToken);
    }
    public partial interface IPluginMulticlientUtilities
    {
        System.Threading.Tasks.Task DoOncePerPluginLifetimeAsync(string key, System.Func<System.Threading.Tasks.Task> taskFunc, System.Threading.CancellationToken cancellationToken);
    }
    public partial interface IPluginProcess : System.IDisposable
    {
        bool HasExited { get; }
        event System.EventHandler Exited;
        event System.EventHandler<NuGet.Protocol.Plugins.LineReadEventArgs> LineRead;
        void BeginReadLine();
        void CancelRead();
        void Kill();
    }
    public partial interface IReceiver : System.IDisposable
    {
        event System.EventHandler<NuGet.Protocol.Plugins.ProtocolErrorEventArgs> Faulted;
        event System.EventHandler<NuGet.Protocol.Plugins.MessageEventArgs> MessageReceived;
        void Close();
        void Connect();
    }
    public partial interface IRequestHandler
    {
        System.Threading.CancellationToken CancellationToken { get; }
        System.Threading.Tasks.Task HandleResponseAsync(NuGet.Protocol.Plugins.IConnection connection, NuGet.Protocol.Plugins.Message request, NuGet.Protocol.Plugins.IResponseHandler responseHandler, System.Threading.CancellationToken cancellationToken);
    }
    public partial interface IRequestHandlers
    {
        void AddOrUpdate(NuGet.Protocol.Plugins.MessageMethod method, System.Func<NuGet.Protocol.Plugins.IRequestHandler> addHandlerFunc, System.Func<NuGet.Protocol.Plugins.IRequestHandler, NuGet.Protocol.Plugins.IRequestHandler> updateHandlerFunc);
        bool TryAdd(NuGet.Protocol.Plugins.MessageMethod method, NuGet.Protocol.Plugins.IRequestHandler handler);
        bool TryGet(NuGet.Protocol.Plugins.MessageMethod method, out NuGet.Protocol.Plugins.IRequestHandler handler);
        bool TryRemove(NuGet.Protocol.Plugins.MessageMethod method);
    }
    public partial interface IResponseHandler
    {
        System.Threading.Tasks.Task SendResponseAsync<TPayload>(NuGet.Protocol.Plugins.Message request, TPayload payload, System.Threading.CancellationToken cancellationToken) where TPayload : class;
    }
    public partial interface ISender : System.IDisposable
    {
        void Close();
        void Connect();
        System.Threading.Tasks.Task SendAsync(NuGet.Protocol.Plugins.Message message, System.Threading.CancellationToken cancellationToken);
    }
    public static partial class JsonSerializationUtilities
    {
        public static Newtonsoft.Json.JsonSerializer Serializer { get { throw null; } }
        public static T Deserialize<T>(string json) where T : class { throw null; }
        public static Newtonsoft.Json.Linq.JObject FromObject(object value) { throw null; }
        public static void Serialize(Newtonsoft.Json.JsonWriter writer, object value) { }
        public static T ToObject<T>(Newtonsoft.Json.Linq.JObject jObject) { throw null; }
    }
    public sealed partial class LineReadEventArgs : System.EventArgs
    {
        public LineReadEventArgs(string line) { }
        public string Line { get { throw null; } }
    }
    public sealed partial class LogRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public LogRequest(NuGet.Common.LogLevel logLevel, string message) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Common.LogLevel LogLevel { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string Message { get { throw null; } }
    }
    public sealed partial class LogRequestHandler : NuGet.Protocol.Plugins.IRequestHandler
    {
        public LogRequestHandler(NuGet.Common.ILogger logger) { }
        public System.Threading.CancellationToken CancellationToken { get { throw null; } }
        public static NuGet.Common.LogLevel GetLogLevel(NuGet.Common.ILogger logger) { throw null; }
        public System.Threading.Tasks.Task HandleResponseAsync(NuGet.Protocol.Plugins.IConnection connection, NuGet.Protocol.Plugins.Message request, NuGet.Protocol.Plugins.IResponseHandler responseHandler, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void SetLogger(NuGet.Common.ILogger logger) { }
    }
    public sealed partial class LogResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public LogResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
    }
    public sealed partial class Message
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public Message(string requestId, NuGet.Protocol.Plugins.MessageType type, NuGet.Protocol.Plugins.MessageMethod method, Newtonsoft.Json.Linq.JObject payload = null) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageMethod Method { get { throw null; } }
        public Newtonsoft.Json.Linq.JObject Payload { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string RequestId { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageType Type { get { throw null; } }
    }
    public sealed partial class MessageDispatcher : NuGet.Protocol.Plugins.IMessageDispatcher, NuGet.Protocol.Plugins.IResponseHandler, System.IDisposable
    {
        public MessageDispatcher(NuGet.Protocol.Plugins.IRequestHandlers requestHandlers, NuGet.Protocol.Plugins.IIdGenerator idGenerator) { }
        public NuGet.Protocol.Plugins.IRequestHandlers RequestHandlers { get { throw null; } }
        public void Close() { }
        public NuGet.Protocol.Plugins.Message CreateMessage(NuGet.Protocol.Plugins.MessageType type, NuGet.Protocol.Plugins.MessageMethod method) { throw null; }
        public NuGet.Protocol.Plugins.Message CreateMessage<TPayload>(NuGet.Protocol.Plugins.MessageType type, NuGet.Protocol.Plugins.MessageMethod method, TPayload payload) where TPayload : class { throw null; }
        public System.Threading.Tasks.Task DispatchCancelAsync(NuGet.Protocol.Plugins.Message request, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task DispatchFaultAsync(NuGet.Protocol.Plugins.Message request, NuGet.Protocol.Plugins.Fault fault, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task DispatchProgressAsync(NuGet.Protocol.Plugins.Message request, NuGet.Protocol.Plugins.Progress progress, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<TInbound> DispatchRequestAsync<TOutbound, TInbound>(NuGet.Protocol.Plugins.MessageMethod method, TOutbound payload, System.Threading.CancellationToken cancellationToken) where TOutbound : class where TInbound : class { throw null; }
        public System.Threading.Tasks.Task DispatchResponseAsync<TOutbound>(NuGet.Protocol.Plugins.Message request, TOutbound responsePayload, System.Threading.CancellationToken cancellationToken) where TOutbound : class { throw null; }
        public void Dispose() { }
        System.Threading.Tasks.Task NuGet.Protocol.Plugins.IResponseHandler.SendResponseAsync<TPayload>(NuGet.Protocol.Plugins.Message request, TPayload payload, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void SetConnection(NuGet.Protocol.Plugins.IConnection connection) { }
    }
    public sealed partial class MessageEventArgs : System.EventArgs
    {
        public MessageEventArgs(NuGet.Protocol.Plugins.Message message) { }
        public NuGet.Protocol.Plugins.Message Message { get { throw null; } }
    }
    public enum MessageMethod
    {
        Close = 1,
        CopyFilesInPackage = 2,
        CopyNupkgFile = 3,
        GetAuthenticationCredentials = 17,
        GetCredentials = 4,
        GetFilesInPackage = 5,
        GetOperationClaims = 6,
        GetPackageHash = 7,
        GetPackageVersions = 8,
        GetServiceIndex = 9,
        Handshake = 10,
        Initialize = 11,
        Log = 12,
        MonitorNuGetProcessExit = 13,
        None = 0,
        PrefetchPackage = 14,
        SetCredentials = 15,
        SetLogLevel = 16,
    }
    public enum MessageResponseCode
    {
        Error = 1,
        NotFound = 2,
        Success = 0,
    }
    public enum MessageType
    {
        Cancel = 0,
        Fault = 1,
        Progress = 2,
        Request = 3,
        Response = 4,
    }
    public static partial class MessageUtilities
    {
        public static NuGet.Protocol.Plugins.Message Create(string requestId, NuGet.Protocol.Plugins.MessageType type, NuGet.Protocol.Plugins.MessageMethod method) { throw null; }
        public static NuGet.Protocol.Plugins.Message Create<TPayload>(string requestId, NuGet.Protocol.Plugins.MessageType type, NuGet.Protocol.Plugins.MessageMethod method, TPayload payload) where TPayload : class { throw null; }
        public static TPayload DeserializePayload<TPayload>(NuGet.Protocol.Plugins.Message message) { throw null; }
    }
    public sealed partial class MonitorNuGetProcessExitRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public MonitorNuGetProcessExitRequest(int processId) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public int ProcessId { get { throw null; } }
    }
    public sealed partial class MonitorNuGetProcessExitRequestHandler : NuGet.Protocol.Plugins.IRequestHandler, System.IDisposable
    {
        public MonitorNuGetProcessExitRequestHandler(NuGet.Protocol.Plugins.IPlugin plugin) { }
        public System.Threading.CancellationToken CancellationToken { get { throw null; } }
        public void Dispose() { }
        public System.Threading.Tasks.Task HandleResponseAsync(NuGet.Protocol.Plugins.IConnection connection, NuGet.Protocol.Plugins.Message request, NuGet.Protocol.Plugins.IResponseHandler responseHandler, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class MonitorNuGetProcessExitResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public MonitorNuGetProcessExitResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
    }
    public sealed partial class NoOpDisposePlugin : NuGet.Protocol.Plugins.IPlugin, System.IDisposable
    {
        public NoOpDisposePlugin(NuGet.Protocol.Plugins.IPlugin plugin) { }
        public NuGet.Protocol.Plugins.IConnection Connection { get { throw null; } }
        public string FilePath { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        public event System.EventHandler BeforeClose { add { } remove { } }
        public event System.EventHandler Closed { add { } remove { } }
        public void Close() { }
        public void Dispose() { }
    }
    public enum OperationClaim
    {
        Authentication = 1,
        DownloadPackage = 0,
    }
    public abstract partial class OutboundRequestContext : System.IDisposable
    {
        protected OutboundRequestContext() { }
        public System.Threading.CancellationToken CancellationToken { get { throw null; } protected set { } }
        public string RequestId { get { throw null; } protected set { } }
        public void Dispose() { }
        protected abstract void Dispose(bool disposing);
        public abstract void HandleCancelResponse();
        public abstract void HandleFault(NuGet.Protocol.Plugins.Message fault);
        public abstract void HandleProgress(NuGet.Protocol.Plugins.Message progress);
        public abstract void HandleResponse(NuGet.Protocol.Plugins.Message response);
    }
    public sealed partial class OutboundRequestContext<TResult> : NuGet.Protocol.Plugins.OutboundRequestContext
    {
        public OutboundRequestContext(NuGet.Protocol.Plugins.IConnection connection, NuGet.Protocol.Plugins.Message request, System.Nullable<System.TimeSpan> timeout, bool isKeepAlive, System.Threading.CancellationToken cancellationToken) { }
        public System.Threading.Tasks.Task<TResult> CompletionTask { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public override void HandleCancelResponse() { }
        public override void HandleFault(NuGet.Protocol.Plugins.Message fault) { }
        public override void HandleProgress(NuGet.Protocol.Plugins.Message progress) { }
        public override void HandleResponse(NuGet.Protocol.Plugins.Message response) { }
    }
    public sealed partial class Plugin : NuGet.Protocol.Plugins.IPlugin, System.IDisposable
    {
        public Plugin(string filePath, NuGet.Protocol.Plugins.IConnection connection, NuGet.Protocol.Plugins.IPluginProcess process, bool isOwnProcess, System.TimeSpan idleTimeout) { }
        public NuGet.Protocol.Plugins.IConnection Connection { get { throw null; } }
        public string FilePath { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        public event System.EventHandler BeforeClose { add { } remove { } }
        public event System.EventHandler Closed { add { } remove { } }
        public event System.EventHandler<NuGet.Protocol.Plugins.PluginEventArgs> Exited { add { } remove { } }
        public event System.EventHandler<NuGet.Protocol.Plugins.FaultedPluginEventArgs> Faulted { add { } remove { } }
        public event System.EventHandler<NuGet.Protocol.Plugins.PluginEventArgs> Idle { add { } remove { } }
        public void Close() { }
        public void Dispose() { }
    }
    public sealed partial class PluginCacheEntry
    {
        public PluginCacheEntry(string rootCacheFolder, string pluginFilePath, string requestKey) { }
        public System.Collections.Generic.IReadOnlyList<NuGet.Protocol.Plugins.OperationClaim> OperationClaims { get { throw null; } set { } }
        public void LoadFromFile() { }
        public System.Threading.Tasks.Task UpdateCacheFileAsync() { throw null; }
    }
    public static partial class PluginConstants
    {
        public static readonly System.TimeSpan CloseTimeout;
        public static readonly System.TimeSpan IdleTimeout;
        public static readonly System.Collections.Generic.IEnumerable<string> PluginArguments;
        public static readonly System.TimeSpan ProgressInterval;
        public static readonly System.TimeSpan RequestTimeout;
    }
    public sealed partial class PluginCreationResult
    {
        public PluginCreationResult(NuGet.Protocol.Plugins.IPlugin plugin, NuGet.Protocol.Plugins.IPluginMulticlientUtilities utilities, System.Collections.Generic.IReadOnlyList<NuGet.Protocol.Plugins.OperationClaim> claims) { }
        public PluginCreationResult(string message) { }
        public PluginCreationResult(string message, System.Exception exception) { }
        public System.Collections.Generic.IReadOnlyList<NuGet.Protocol.Plugins.OperationClaim> Claims { get { throw null; } }
        public System.Exception Exception { get { throw null; } }
        public string Message { get { throw null; } }
        public NuGet.Protocol.Plugins.IPlugin Plugin { get { throw null; } }
        public NuGet.Protocol.Plugins.IPluginMulticlientUtilities PluginMulticlientUtilities { get { throw null; } }
    }
    public sealed partial class PluginDiscoverer : NuGet.Protocol.Plugins.IPluginDiscoverer, System.IDisposable
    {
        public PluginDiscoverer(string rawPluginPaths, NuGet.Protocol.Plugins.EmbeddedSignatureVerifier verifier) { }
        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Plugins.PluginDiscoveryResult>> DiscoverAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public void Dispose() { }
    }
    public sealed partial class PluginDiscoveryResult
    {
        public PluginDiscoveryResult(NuGet.Protocol.Plugins.PluginFile pluginFile) { }
        public string Message { get { throw null; } }
        public NuGet.Protocol.Plugins.PluginFile PluginFile { get { throw null; } }
    }
    public static partial class PluginDiscoveryUtility
    {
        public static System.Lazy<string> InternalPluginDiscoveryRoot { get { throw null; } set { } }
        public static System.Collections.Generic.IEnumerable<string> GetConventionBasedPlugins(System.Collections.Generic.IEnumerable<string> directories) { throw null; }
        public static string GetInternalPluginRelativeToMSBuildExe(string msbuildExePath) { throw null; }
        public static string GetInternalPlugins() { throw null; }
        public static string GetNuGetHomePluginsPath() { throw null; }
        public static string GetNuGetPluginsDirectoryRelativeToNuGetAssembly(string nugetAssemblyPath) { throw null; }
    }
    public sealed partial class PluginEventArgs : System.EventArgs
    {
        public PluginEventArgs(NuGet.Protocol.Plugins.IPlugin plugin) { }
        public NuGet.Protocol.Plugins.IPlugin Plugin { get { throw null; } }
    }
    public sealed partial class PluginException : System.Exception
    {
        public PluginException(string message) { }
        public PluginException(string message, System.Exception innerException) { }
    }
    public sealed partial class PluginFactory : NuGet.Protocol.Plugins.IPluginFactory, System.IDisposable
    {
        public PluginFactory(System.TimeSpan pluginIdleTimeout) { }
        public static System.Threading.Tasks.Task<NuGet.Protocol.Plugins.IPlugin> CreateFromCurrentProcessAsync(NuGet.Protocol.Plugins.IRequestHandlers requestHandlers, NuGet.Protocol.Plugins.ConnectionOptions options, System.Threading.CancellationToken sessionCancellationToken) { throw null; }
        public void Dispose() { }
        public System.Threading.Tasks.Task<NuGet.Protocol.Plugins.IPlugin> GetOrCreateAsync(string filePath, System.Collections.Generic.IEnumerable<string> arguments, NuGet.Protocol.Plugins.IRequestHandlers requestHandlers, NuGet.Protocol.Plugins.ConnectionOptions options, System.Threading.CancellationToken sessionCancellationToken) { throw null; }
    }
    public sealed partial class PluginFile
    {
        public PluginFile(string filePath, System.Lazy<NuGet.Protocol.Plugins.PluginFileState> state) { }
        public string Path { get { throw null; } }
        public System.Lazy<NuGet.Protocol.Plugins.PluginFileState> State { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public enum PluginFileState
    {
        InvalidEmbeddedSignature = 3,
        InvalidFilePath = 2,
        NotFound = 1,
        Valid = 0,
    }
    public sealed partial class PluginManager : NuGet.Protocol.Plugins.IPluginManager, System.IDisposable
    {
        internal PluginManager() { }
        public NuGet.Common.IEnvironmentVariableReader EnvironmentVariableReader { get { throw null; } }
        public static NuGet.Protocol.Plugins.IPluginManager Instance { get { throw null; } }
        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Plugins.PluginCreationResult>> CreatePluginsAsync(NuGet.Protocol.Core.Types.SourceRepository source, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void Dispose() { }
        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Protocol.Plugins.PluginDiscoveryResult>> FindAvailablePluginsAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Tuple<bool, NuGet.Protocol.Plugins.PluginCreationResult>> TryGetSourceAgnosticPluginAsync(NuGet.Protocol.Plugins.PluginDiscoveryResult pluginDiscoveryResult, NuGet.Protocol.Plugins.OperationClaim requestedOperationClaim, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class PluginMulticlientUtilities : NuGet.Protocol.Plugins.IPluginMulticlientUtilities
    {
        public PluginMulticlientUtilities() { }
        public System.Threading.Tasks.Task DoOncePerPluginLifetimeAsync(string key, System.Func<System.Threading.Tasks.Task> taskFunc, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class PluginPackageDownloader : NuGet.Packaging.IPackageDownloader, System.IDisposable
    {
        public PluginPackageDownloader(NuGet.Protocol.Plugins.IPlugin plugin, NuGet.Packaging.Core.PackageIdentity packageIdentity, NuGet.Protocol.Plugins.PluginPackageReader packageReader, string packageSourceRepository) { }
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
    public sealed partial class PluginPackageReader : NuGet.Packaging.PackageReaderBase
    {
        public PluginPackageReader(NuGet.Protocol.Plugins.IPlugin plugin, NuGet.Packaging.Core.PackageIdentity packageIdentity, string packageSourceRepository) : base (default(NuGet.Frameworks.IFrameworkNameProvider)) { }
        public override NuGet.Packaging.NuspecReader NuspecReader { get { throw null; } }
        public override bool CanVerifySignedPackages(NuGet.Packaging.Signing.SignedPackageVerifierSettings verifierSettings) { throw null; }
        public override System.Collections.Generic.IEnumerable<string> CopyFiles(string destination, System.Collections.Generic.IEnumerable<string> packageFiles, NuGet.Packaging.Core.ExtractPackageFileDelegate extractFile, NuGet.Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> CopyFilesAsync(string destination, System.Collections.Generic.IEnumerable<string> packageFiles, NuGet.Packaging.Core.ExtractPackageFileDelegate extractFile, NuGet.Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<string> CopyNupkgAsync(string nupkgFilePath, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override System.Threading.Tasks.Task<byte[]> GetArchiveHashAsync(NuGet.Common.HashAlgorithmName hashAlgorithm, System.Threading.CancellationToken token) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetBuildItems() { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetBuildItemsAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override string GetContentHash(System.Threading.CancellationToken token, System.Func<string> GetUnsignedPackageHash = null) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetContentItems() { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetContentItemsAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override bool GetDevelopmentDependency() { throw null; }
        public override System.Threading.Tasks.Task<bool> GetDevelopmentDependencyAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Collections.Generic.IEnumerable<string> GetFiles() { throw null; }
        public override System.Collections.Generic.IEnumerable<string> GetFiles(string folder) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> GetFilesAsync(string folder, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>> GetFilesAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetFrameworkItems() { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetFrameworkItemsAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override NuGet.Packaging.Core.PackageIdentity GetIdentity() { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Packaging.Core.PackageIdentity> GetIdentityAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetItems(string folderName) { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetItemsAsync(string folderName, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetLibItems() { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetLibItemsAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override NuGet.Versioning.NuGetVersion GetMinClientVersion() { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Versioning.NuGetVersion> GetMinClientVersionAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.IO.Stream GetNuspec() { throw null; }
        public override System.Threading.Tasks.Task<System.IO.Stream> GetNuspecAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override string GetNuspecFile() { throw null; }
        public override System.Threading.Tasks.Task<string> GetNuspecFileAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Packaging.NuspecReader> GetNuspecReaderAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup> GetPackageDependencies() { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.PackageDependencyGroup>> GetPackageDependenciesAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Core.PackageType> GetPackageTypes() { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<NuGet.Packaging.Core.PackageType>> GetPackageTypesAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<NuGet.Packaging.Signing.PrimarySignature> GetPrimarySignatureAsync(System.Threading.CancellationToken token) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetReferenceItems() { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetReferenceItemsAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.IO.Stream GetStream(string path) { throw null; }
        public override System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(string path, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework> GetSupportedFrameworks() { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Frameworks.NuGetFramework>> GetSupportedFrameworksAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup> GetToolItems() { throw null; }
        public override System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Packaging.FrameworkSpecificGroup>> GetToolItemsAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override bool IsServiceable() { throw null; }
        public override System.Threading.Tasks.Task<bool> IsServiceableAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<bool> IsSignedAsync(System.Threading.CancellationToken token) { throw null; }
        public override System.Threading.Tasks.Task ValidateIntegrityAsync(NuGet.Packaging.Signing.SignatureContent signatureContent, System.Threading.CancellationToken token) { throw null; }
    }
    public sealed partial class PluginProcess : NuGet.Protocol.Plugins.IPluginProcess, System.IDisposable
    {
        public PluginProcess(System.Diagnostics.Process process) { }
        public bool HasExited { get { throw null; } }
        public event System.EventHandler Exited { add { } remove { } }
        public event System.EventHandler<NuGet.Protocol.Plugins.LineReadEventArgs> LineRead { add { } remove { } }
        public void BeginReadLine() { }
        public void CancelRead() { }
        public void Dispose() { }
        public void Kill() { }
    }
    public sealed partial class PrefetchPackageRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public PrefetchPackageRequest(string packageSourceRepository, string packageId, string packageVersion) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageId { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageSourceRepository { get { throw null; } }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageVersion { get { throw null; } }
    }
    public sealed partial class PrefetchPackageResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public PrefetchPackageResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
    }
    public sealed partial class Progress
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public Progress(System.Nullable<double> percentage = default(System.Nullable<double>)) { }
        public System.Nullable<double> Percentage { get { throw null; } }
    }
    public static partial class ProtocolConstants
    {
        public static readonly NuGet.Versioning.SemanticVersion CurrentVersion;
        public static readonly System.TimeSpan HandshakeTimeout;
        public static readonly System.TimeSpan MaxTimeout;
        public static readonly System.TimeSpan MinTimeout;
        public static readonly System.TimeSpan RequestTimeout;
        public static readonly NuGet.Versioning.SemanticVersion Version100;
    }
    public sealed partial class ProtocolErrorEventArgs : System.EventArgs
    {
        public ProtocolErrorEventArgs(System.Exception exception) { }
        public ProtocolErrorEventArgs(System.Exception exception, NuGet.Protocol.Plugins.Message message) { }
        public System.Exception Exception { get { throw null; } }
        public NuGet.Protocol.Plugins.Message Message { get { throw null; } }
    }
    public sealed partial class ProtocolException : System.Exception
    {
        public ProtocolException(string message) { }
        public ProtocolException(string message, System.Exception innerException) { }
    }
    public abstract partial class Receiver : NuGet.Protocol.Plugins.IReceiver, System.IDisposable
    {
        protected Receiver() { }
        protected bool IsClosed { get { throw null; } }
        protected bool IsDisposed { get { throw null; } set { } }
        public event System.EventHandler<NuGet.Protocol.Plugins.ProtocolErrorEventArgs> Faulted { add { } remove { } }
        public event System.EventHandler<NuGet.Protocol.Plugins.MessageEventArgs> MessageReceived { add { } remove { } }
        public virtual void Close() { }
        public abstract void Connect();
        public abstract void Dispose();
        protected void FireFaultEvent(System.Exception exception, NuGet.Protocol.Plugins.Message message) { }
        protected void FireMessageReceivedEvent(NuGet.Protocol.Plugins.Message message) { }
        protected void ThrowIfClosed() { }
        protected void ThrowIfDisposed() { }
    }
    public sealed partial class RequestHandlers : NuGet.Protocol.Plugins.IRequestHandlers
    {
        public RequestHandlers() { }
        public void AddOrUpdate(NuGet.Protocol.Plugins.MessageMethod method, System.Func<NuGet.Protocol.Plugins.IRequestHandler> addHandlerFunc, System.Func<NuGet.Protocol.Plugins.IRequestHandler, NuGet.Protocol.Plugins.IRequestHandler> updateHandlerFunc) { }
        public bool TryAdd(NuGet.Protocol.Plugins.MessageMethod method, NuGet.Protocol.Plugins.IRequestHandler handler) { throw null; }
        public bool TryGet(NuGet.Protocol.Plugins.MessageMethod method, out NuGet.Protocol.Plugins.IRequestHandler handler) { throw null; }
        public bool TryRemove(NuGet.Protocol.Plugins.MessageMethod method) { throw null; }
    }
    public sealed partial class RequestIdGenerator : NuGet.Protocol.Plugins.IIdGenerator
    {
        public RequestIdGenerator() { }
        public string GenerateUniqueId() { throw null; }
    }
    public sealed partial class Sender : NuGet.Protocol.Plugins.ISender, System.IDisposable
    {
        public Sender(System.IO.TextWriter writer) { }
        public void Close() { }
        public void Connect() { }
        public void Dispose() { }
        public System.Threading.Tasks.Task SendAsync(NuGet.Protocol.Plugins.Message message, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class SetCredentialsRequest
    {
        public SetCredentialsRequest(string packageSourceRepository, string proxyUsername, string proxyPassword, string username, string password) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public string PackageSourceRepository { get { throw null; } }
        public string Password { get { throw null; } }
        public string ProxyPassword { get { throw null; } }
        public string ProxyUsername { get { throw null; } }
        public string Username { get { throw null; } }
    }
    public sealed partial class SetCredentialsResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public SetCredentialsResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
    }
    public sealed partial class SetLogLevelRequest
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public SetLogLevelRequest(NuGet.Common.LogLevel logLevel) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Common.LogLevel LogLevel { get { throw null; } }
    }
    public sealed partial class SetLogLevelResponse
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public SetLogLevelResponse(NuGet.Protocol.Plugins.MessageResponseCode responseCode) { }
        [Newtonsoft.Json.JsonRequiredAttribute]
        public NuGet.Protocol.Plugins.MessageResponseCode ResponseCode { get { throw null; } }
    }
    public sealed partial class StandardInputReceiver : NuGet.Protocol.Plugins.Receiver
    {
        public StandardInputReceiver(System.IO.TextReader reader) { }
        public override void Connect() { }
        public override void Dispose() { }
    }
    public sealed partial class StandardOutputReceiver : NuGet.Protocol.Plugins.Receiver
    {
        public StandardOutputReceiver(NuGet.Protocol.Plugins.IPluginProcess process) { }
        public override void Close() { }
        public override void Connect() { }
        public override void Dispose() { }
    }
    public sealed partial class SymmetricHandshake : NuGet.Protocol.Plugins.IRequestHandler, System.IDisposable
    {
        public SymmetricHandshake(NuGet.Protocol.Plugins.IConnection connection, System.TimeSpan handshakeTimeout, NuGet.Versioning.SemanticVersion protocolVersion, NuGet.Versioning.SemanticVersion minimumProtocolVersion) { }
        public System.Threading.CancellationToken CancellationToken { get { throw null; } }
        public void Dispose() { }
        public System.Threading.Tasks.Task HandleResponseAsync(NuGet.Protocol.Plugins.IConnection connection, NuGet.Protocol.Plugins.Message request, NuGet.Protocol.Plugins.IResponseHandler responseHandler, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<NuGet.Versioning.SemanticVersion> HandshakeAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public static partial class TimeoutUtilities
    {
        public static System.TimeSpan GetTimeout(string timeoutInSeconds, System.TimeSpan fallbackTimeout) { throw null; }
        public static bool IsValid(System.TimeSpan timeout) { throw null; }
    }
    public partial class UnixAndMonoPlatformsEmbeddedSignatureVerifier : NuGet.Protocol.Plugins.EmbeddedSignatureVerifier
    {
        public UnixAndMonoPlatformsEmbeddedSignatureVerifier() { }
        public override bool IsValid(string filePath) { throw null; }
    }
    public sealed partial class WindowsEmbeddedSignatureVerifier : NuGet.Protocol.Plugins.EmbeddedSignatureVerifier
    {
        public WindowsEmbeddedSignatureVerifier() { }
        public override bool IsValid(string filePath) { throw null; }
    }
}
namespace NuGet.Protocol.VisualStudio
{
    public static partial class FactoryExtensionsVS
    {
        public static System.Collections.Generic.IEnumerable<System.Lazy<NuGet.Protocol.Core.Types.INuGetResourceProvider>> GetVisualStudio(this NuGet.Protocol.Core.Types.Repository.ProviderFactory factory) { throw null; }
        public static NuGet.Protocol.Core.Types.SourceRepository GetVisualStudio(this NuGet.Protocol.Core.Types.Repository.RepositoryFactory factory, NuGet.Configuration.PackageSource source) { throw null; }
        public static NuGet.Protocol.Core.Types.SourceRepository GetVisualStudio(this NuGet.Protocol.Core.Types.Repository.RepositoryFactory factory, string source) { throw null; }
    }
}
namespace NuGet.Repositories
{
    public partial class LocalPackageInfo
    {
        public LocalPackageInfo(string packageId, NuGet.Versioning.NuGetVersion version, string path, string manifestPath, string zipPath, string sha512Path, System.Lazy<NuGet.Packaging.NuspecReader> nuspec, System.Lazy<System.Collections.Generic.IReadOnlyList<string>> files, System.Lazy<string> sha512, System.Lazy<NuGet.RuntimeModel.RuntimeGraph> runtimeGraph) { }
        public string ExpandedPath { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> Files { get { throw null; } }
        public string Id { get { throw null; } }
        public string ManifestPath { get { throw null; } }
        public NuGet.Packaging.NuspecReader Nuspec { get { throw null; } }
        public NuGet.RuntimeModel.RuntimeGraph RuntimeGraph { get { throw null; } }
        public string Sha512 { get { throw null; } }
        public string Sha512Path { get { throw null; } }
        public NuGet.Versioning.NuGetVersion Version { get { throw null; } }
        public string ZipPath { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class LocalPackageSourceInfo
    {
        public LocalPackageSourceInfo(NuGet.Repositories.NuGetv3LocalRepository repository, NuGet.Repositories.LocalPackageInfo package) { }
        public NuGet.Repositories.LocalPackageInfo Package { get { throw null; } }
        public NuGet.Repositories.NuGetv3LocalRepository Repository { get { throw null; } }
    }
    public partial class NuGetv3LocalRepository
    {
        public NuGetv3LocalRepository(string path) { }
        public NuGetv3LocalRepository(string path, NuGet.Protocol.LocalPackageFileCache packageFileCache, bool isFallbackFolder) { }
        public NuGet.Packaging.VersionFolderPathResolver PathResolver { get { throw null; } }
        public string RepositoryRoot { get { throw null; } }
        public void ClearCacheForIds(System.Collections.Generic.IEnumerable<string> packageIds) { }
        public bool Exists(string packageId, NuGet.Versioning.NuGetVersion version) { throw null; }
        public NuGet.Repositories.LocalPackageInfo FindPackage(string packageId, NuGet.Versioning.NuGetVersion version) { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Repositories.LocalPackageInfo> FindPackagesById(string packageId) { throw null; }
    }
    public static partial class NuGetv3LocalRepositoryUtility
    {
        public static NuGet.Repositories.LocalPackageSourceInfo GetPackage(System.Collections.Generic.IReadOnlyList<NuGet.Repositories.NuGetv3LocalRepository> repositories, string id, NuGet.Versioning.NuGetVersion version) { throw null; }
    }
}
