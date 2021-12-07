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
[assembly: AssemblyTitle("NuGet.Credentials")]
[assembly: AssemblyDescription("NuGet.Credentials")]
[assembly: AssemblyDefaultAlias("NuGet.Credentials")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("5.1.0.6013")]
[assembly: AssemblyInformationalVersion("5.1.0.6013 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("5.1.0.5")]




namespace NuGet.Credentials
{
    public partial class CredentialResponse
    {
        public CredentialResponse(NuGet.Credentials.CredentialStatus status) { }
        public CredentialResponse(System.Net.ICredentials credentials) { }
        public System.Net.ICredentials Credentials { get { throw null; } }
        public NuGet.Credentials.CredentialStatus Status { get { throw null; } }
    }
    public partial class CredentialsConstants
    {
        public static readonly int ProviderTimeoutSecondsDefault;
        public static readonly string ProviderTimeoutSecondsEnvar;
        public static readonly string ProviderTimeoutSecondsSetting;
        public CredentialsConstants() { }
    }
    public partial class CredentialService : NuGet.Configuration.ICredentialService
    {
        public CredentialService(NuGet.Common.AsyncLazy<System.Collections.Generic.IEnumerable<NuGet.Credentials.ICredentialProvider>> providers, bool nonInteractive, bool handlesDefaultCredentials) { }
        public bool HandlesDefaultCredentials { get { throw null; } }
        public System.Threading.Tasks.Task<System.Net.ICredentials> GetCredentialsAsync(System.Uri uri, System.Net.IWebProxy proxy, NuGet.Configuration.CredentialRequestType type, string message, System.Threading.CancellationToken cancellationToken) { throw null; }
        public bool TryGetLastKnownGoodCredentialsFromCache(System.Uri uri, bool isProxy, out System.Net.ICredentials credentials) { throw null; }
    }
    public enum CredentialStatus
    {
        ProviderNotApplicable = 1,
        Success = 0,
        UserCanceled = 2,
    }
    public partial class DefaultCredentialServiceUtility
    {
        public DefaultCredentialServiceUtility() { }
        public static void SetupDefaultCredentialService(NuGet.Common.ILogger logger, bool nonInteractive) { }
    }
    public partial class DefaultNetworkCredentialsCredentialProvider : NuGet.Credentials.ICredentialProvider
    {
        public DefaultNetworkCredentialsCredentialProvider() { }
        public string Id { get { throw null; } }
        public System.Threading.Tasks.Task<NuGet.Credentials.CredentialResponse> GetAsync(System.Uri uri, System.Net.IWebProxy proxy, NuGet.Configuration.CredentialRequestType type, string message, bool isRetry, bool nonInteractive, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial interface ICredentialProvider
    {
        string Id { get; }
        System.Threading.Tasks.Task<NuGet.Credentials.CredentialResponse> GetAsync(System.Uri uri, System.Net.IWebProxy proxy, NuGet.Configuration.CredentialRequestType type, string message, bool isRetry, bool nonInteractive, System.Threading.CancellationToken cancellationToken);
    }
    public partial class PluginCredentialProvider : NuGet.Credentials.ICredentialProvider
    {
        public PluginCredentialProvider(NuGet.Common.ILogger logger, string path, int timeoutSeconds, string verbosity) { }
        public string Id { get { throw null; } }
        public string Path { get { throw null; } }
        public int TimeoutSeconds { get { throw null; } }
        public virtual int Execute(System.Diagnostics.ProcessStartInfo startInfo, System.Threading.CancellationToken cancellationToken, out string stdOut) { throw null; }
        public System.Threading.Tasks.Task<NuGet.Credentials.CredentialResponse> GetAsync(System.Uri uri, System.Net.IWebProxy proxy, NuGet.Configuration.CredentialRequestType type, string message, bool isRetry, bool nonInteractive, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class PluginCredentialProviderBuilder
    {
        public PluginCredentialProviderBuilder(NuGet.Configuration.IExtensionLocator extensionLocator, NuGet.Configuration.ISettings settings, NuGet.Common.ILogger logger) { }
        public PluginCredentialProviderBuilder(NuGet.Configuration.IExtensionLocator extensionLocator, NuGet.Configuration.ISettings settings, NuGet.Common.ILogger logger, NuGet.Common.IEnvironmentVariableReader envarReader) { }
        public System.Collections.Generic.IEnumerable<NuGet.Credentials.ICredentialProvider> BuildAll(string verbosity) { throw null; }
    }
    public partial class PluginCredentialRequest
    {
        public PluginCredentialRequest() { }
        public bool IsRetry { get { throw null; } set { } }
        public bool NonInteractive { get { throw null; } set { } }
        public string Uri { get { throw null; } set { } }
        public string Verbosity { get { throw null; } set { } }
    }
    public partial class PluginCredentialResponse
    {
        public PluginCredentialResponse() { }
        public System.Collections.Generic.IList<string> AuthTypes { get { throw null; } set { } }
        public bool IsValid { get { throw null; } }
        public string Message { get { throw null; } set { } }
        public string Password { get { throw null; } set { } }
        public string Username { get { throw null; } set { } }
    }
    public enum PluginCredentialResponseExitCode
    {
        Failure = 2,
        ProviderNotApplicable = 1,
        Success = 0,
    }
    public partial class PluginException : System.Exception
    {
        public PluginException() { }
        protected PluginException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public PluginException(string message) { }
        public PluginException(string message, System.Exception inner) { }
        public static NuGet.Credentials.PluginException Create(string path, System.Exception inner) { throw null; }
        public static NuGet.Credentials.PluginException CreateAbortMessage(string path, string message) { throw null; }
        public static NuGet.Credentials.PluginException CreateInvalidResponseExceptionMessage(string path, NuGet.Credentials.PluginCredentialResponseExitCode status, NuGet.Credentials.PluginCredentialResponse response) { throw null; }
        public static NuGet.Credentials.PluginException CreateNotStartedMessage(string path) { throw null; }
        public static NuGet.Credentials.PluginException CreatePathNotFoundMessage(string path, string attempted) { throw null; }
        public static NuGet.Credentials.PluginException CreateTimeoutMessage(string path, int timeoutMillis) { throw null; }
        public static NuGet.Credentials.PluginException CreateUnreadableResponseExceptionMessage(string path, NuGet.Credentials.PluginCredentialResponseExitCode status) { throw null; }
    }
    public partial class PluginUnexpectedStatusException : NuGet.Credentials.PluginException
    {
        public PluginUnexpectedStatusException() { }
        protected PluginUnexpectedStatusException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public PluginUnexpectedStatusException(string message) { }
        public PluginUnexpectedStatusException(string message, System.Exception inner) { }
        public static NuGet.Credentials.PluginException CreateUnexpectedStatusMessage(string path, NuGet.Credentials.PluginCredentialResponseExitCode status) { throw null; }
    }
    public static partial class PreviewFeatureSettings
    {
        public const string DefaultCredentialsAfterCredentialProvidersEnvironmentVariableName = "NUGET_CREDENTIAL_PROVIDER_OVERRIDE_DEFAULT";
        public static bool DefaultCredentialsAfterCredentialProviders { get { throw null; } set { } }
    }
    public partial class ProviderException : System.Exception
    {
        public ProviderException() { }
        protected ProviderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ProviderException(string message) { }
        public ProviderException(string message, System.Exception inner) { }
    }
    public sealed partial class SecurePluginCredentialProvider : NuGet.Credentials.ICredentialProvider
    {
        public SecurePluginCredentialProvider(NuGet.Protocol.Plugins.IPluginManager pluginManager, NuGet.Protocol.Plugins.PluginDiscoveryResult pluginDiscoveryResult, bool canShowDialog, NuGet.Common.ILogger logger) { }
        public string Id { get { throw null; } }
        public System.Threading.Tasks.Task<NuGet.Credentials.CredentialResponse> GetAsync(System.Uri uri, System.Net.IWebProxy proxy, NuGet.Configuration.CredentialRequestType type, string message, bool isRetry, bool nonInteractive, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class SecurePluginCredentialProviderBuilder
    {
        public SecurePluginCredentialProviderBuilder(NuGet.Protocol.Plugins.IPluginManager pluginManager, bool canShowDialog, NuGet.Common.ILogger logger) { }
        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<NuGet.Credentials.ICredentialProvider>> BuildAllAsync() { throw null; }
    }
}
