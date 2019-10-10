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
[assembly: AssemblyTitle("NuGet.Configuration")]
[assembly: AssemblyDescription("NuGet.Configuration")]
[assembly: AssemblyDefaultAlias("NuGet.Configuration")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("5.1.0.6013")]
[assembly: AssemblyInformationalVersion("5.1.0.6013 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("5.1.0.5")]




namespace NuGet.Configuration
{
    public partial class AddItem : NuGet.Configuration.SettingItem
    {
        public AddItem(string key, string value) { }
        public AddItem(string key, string value, System.Collections.Generic.IReadOnlyDictionary<string, string> additionalAttributes) { }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> AdditionalAttributes { get { throw null; } }
        protected override System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyCollection<string>> DisallowedValues { get { throw null; } }
        public override string ElementName { get { throw null; } }
        public string Key { get { throw null; } }
        protected override System.Collections.Generic.IReadOnlyCollection<string> RequiredAttributes { get { throw null; } }
        public virtual string Value { get { throw null; } set { } }
        public void AddOrUpdateAdditionalAttribute(string attributeName, string value) { }
        public override NuGet.Configuration.SettingBase Clone() { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
        public virtual string GetValueAsPath() { throw null; }
    }
    public sealed partial class AuthorItem : NuGet.Configuration.TrustedSignerItem
    {
        public AuthorItem(string name, params NuGet.Configuration.CertificateItem[] certificates) : base (default(string), default(System.Collections.Generic.IEnumerable<NuGet.Configuration.CertificateItem>)) { }
        public override string ElementName { get { throw null; } }
        protected override System.Collections.Generic.IReadOnlyCollection<string> RequiredAttributes { get { throw null; } }
        public override NuGet.Configuration.SettingBase Clone() { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public sealed partial class CertificateItem : NuGet.Configuration.SettingItem
    {
        public CertificateItem(string fingerprint, NuGet.Common.HashAlgorithmName hashAlgorithm, bool allowUntrustedRoot = false) { }
        public bool AllowUntrustedRoot { get { throw null; } set { } }
        public override string ElementName { get { throw null; } }
        public string Fingerprint { get { throw null; } set { } }
        public NuGet.Common.HashAlgorithmName HashAlgorithm { get { throw null; } set { } }
        protected override System.Collections.Generic.IReadOnlyCollection<string> RequiredAttributes { get { throw null; } }
        public override NuGet.Configuration.SettingBase Clone() { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public sealed partial class ClearItem : NuGet.Configuration.SettingItem
    {
        public ClearItem() { }
        public override string ElementName { get { throw null; } }
        public override NuGet.Configuration.SettingBase Clone() { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsEmpty() { throw null; }
    }
    public static partial class ConfigurationConstants
    {
        public static readonly string ActivePackageSourceSectionName;
        public static readonly string Add;
        public static readonly string AllowUntrustedRoot;
        public static readonly string ApiKeys;
        public static readonly string Author;
        public static readonly string BeginIgnoreMarker;
        public static readonly string BindingRedirectsSection;
        public static readonly string Certificate;
        public static readonly string Clear;
        public static readonly string ClearTextPasswordToken;
        public static readonly string Config;
        public static readonly string Configuration;
        public static readonly string ConfigurationDefaultsFile;
        public static readonly string CredentialsSectionName;
        public static readonly string DefaultPackageManagementFormatKey;
        public static readonly string DefaultPushSource;
        public static readonly string DependencyVersion;
        public static readonly string DisabledPackageSources;
        public static readonly string DoNotShowPackageManagementSelectionKey;
        public static readonly string Enabled;
        public static readonly string EndIgnoreMarker;
        public static readonly string FailOnBindingRedirects;
        public static readonly string FallbackPackageFolders;
        public static readonly string Fingerprint;
        public static readonly string FingerprintAlgorithm;
        public static readonly string GlobalPackagesFolder;
        public static readonly string HashAlgorithm;
        public static readonly string HostKey;
        public static readonly string KeyAttribute;
        public static readonly string MaxHttpRequestsPerSource;
        public static readonly string NameAttribute;
        public static readonly string NoProxy;
        public static readonly string Owners;
        public static readonly string PackageManagementSection;
        public static readonly string PackageRestore;
        public static readonly string PackageSources;
        public static readonly string PasswordKey;
        public static readonly string PasswordToken;
        public static readonly string ProtocolVersionAttribute;
        public static readonly string Repository;
        public static readonly string RepositoryPath;
        public static readonly string ServiceIndex;
        public static readonly string SignatureValidationMode;
        public static readonly string SkipBindingRedirectsKey;
        public static readonly string TrustedSigners;
        public static readonly string UserKey;
        public static readonly string UsernameToken;
        public static readonly string ValidAuthenticationTypesToken;
        public static readonly string ValueAttribute;
    }
    public partial class ConfigurationDefaults
    {
        internal ConfigurationDefaults() { }
        public string DefaultPackageRestoreConsent { get { throw null; } }
        public System.Collections.Generic.IEnumerable<NuGet.Configuration.PackageSource> DefaultPackageSources { get { throw null; } }
        public string DefaultPushSource { get { throw null; } }
        public static NuGet.Configuration.ConfigurationDefaults Instance { get { throw null; } }
    }
    public enum CredentialRequestType
    {
        Forbidden = 2,
        Proxy = 0,
        Unauthorized = 1,
    }
    public sealed partial class CredentialsItem : NuGet.Configuration.SettingItem
    {
        public CredentialsItem(string name, string username, string password, bool isPasswordClearText, string validAuthenticationTypes) { }
        protected override bool CanHaveChildren { get { throw null; } }
        public override string ElementName { get { throw null; } protected set { } }
        public bool IsPasswordClearText { get { throw null; } }
        public string Password { get { throw null; } }
        public string Username { get { throw null; } set { } }
        public string ValidAuthenticationTypes { get { throw null; } set { } }
        public override NuGet.Configuration.SettingBase Clone() { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsEmpty() { throw null; }
        public void UpdatePassword(string password, bool isPasswordClearText = true) { }
    }
    public static partial class EncryptionUtility
    {
        public static string DecryptString(string encryptedString) { throw null; }
        public static string EncryptString(string value) { throw null; }
    }
    public partial interface ICredentialCache
    {
        void Add(System.Uri uri, System.Net.ICredentials credentials);
        System.Net.ICredentials GetCredentials(System.Uri uri);
    }
    public partial interface ICredentialService
    {
        bool HandlesDefaultCredentials { get; }
        System.Threading.Tasks.Task<System.Net.ICredentials> GetCredentialsAsync(System.Uri uri, System.Net.IWebProxy proxy, NuGet.Configuration.CredentialRequestType type, string message, System.Threading.CancellationToken cancellationToken);
        bool TryGetLastKnownGoodCredentialsFromCache(System.Uri uri, bool isProxy, out System.Net.ICredentials credentials);
    }
    public partial interface IExtensionLocator
    {
        System.Collections.Generic.IEnumerable<string> FindCredentialProviders();
        System.Collections.Generic.IEnumerable<string> FindExtensions();
    }
    public partial interface IMachineWideSettings
    {
        NuGet.Configuration.ISettings Settings { get; }
    }
    public partial interface IPackageSourceProvider
    {
        string ActivePackageSourceName { get; }
        string DefaultPushSource { get; }
        event System.EventHandler PackageSourcesChanged;
        void AddPackageSource(NuGet.Configuration.PackageSource source);
        void DisablePackageSource(string name);
        void EnablePackageSource(string name);
        NuGet.Configuration.PackageSource GetPackageSourceByName(string name);
        NuGet.Configuration.PackageSource GetPackageSourceBySource(string source);
        bool IsPackageSourceEnabled(string name);
        System.Collections.Generic.IEnumerable<NuGet.Configuration.PackageSource> LoadPackageSources();
        void RemovePackageSource(string name);
        void SaveActivePackageSource(NuGet.Configuration.PackageSource source);
        void SavePackageSources(System.Collections.Generic.IEnumerable<NuGet.Configuration.PackageSource> sources);
        void UpdatePackageSource(NuGet.Configuration.PackageSource source, bool updateCredentials, bool updateEnabled);
    }
    public partial interface IProxyCache
    {
        void Add(System.Net.IWebProxy proxy);
        System.Net.IWebProxy GetProxy(System.Uri uri);
    }
    public partial interface IProxyCredentialCache : System.Net.ICredentials
    {
        System.Guid Version { get; }
        void UpdateCredential(System.Uri proxyAddress, System.Net.NetworkCredential credentials);
    }
    public partial interface ISettings
    {
        event System.EventHandler SettingsChanged;
        void AddOrUpdate(string sectionName, NuGet.Configuration.SettingItem item);
        System.Collections.Generic.IList<string> GetConfigFilePaths();
        System.Collections.Generic.IList<string> GetConfigRoots();
        NuGet.Configuration.SettingSection GetSection(string sectionName);
        void Remove(string sectionName, NuGet.Configuration.SettingItem item);
        void SaveToDisk();
    }
    public partial class NuGetConfigurationException : System.Exception
    {
        public NuGetConfigurationException(string message) { }
        public NuGetConfigurationException(string message, System.Exception innerException) { }
    }
    public static partial class NuGetConstants
    {
        public static readonly string AddV3TrackFile;
        public static readonly string DefaultConfigContent;
        public static readonly string DefaultGalleryServerUrl;
        public static readonly string DefaultSymbolServerUrl;
        public static readonly string FeedName;
        public static readonly string ManifestExtension;
        public static readonly string ManifestSymbolsExtension;
        public static readonly string NuGetHostName;
        public static readonly string NuGetSolutionSettingsFolder;
        public static readonly string NuGetSymbolHostName;
        public static readonly string PackageExtension;
        public static readonly string PackageReferenceFile;
        public static readonly string PackageSpecFileName;
        public static readonly string ReadmeFileName;
        public static readonly string SnupkgExtension;
        public static readonly string SymbolsExtension;
        public static readonly string V1FeedUrl;
        public static readonly string V2FeedUrl;
        public static readonly string V2LegacyFeedUrl;
        public static readonly string V2LegacyOfficialPackageSourceUrl;
        public static readonly string V3FeedUrl;
    }
    public partial class NuGetPathContext : NuGet.Common.INuGetPathContext
    {
        public NuGetPathContext() { }
        public System.Collections.Generic.IReadOnlyList<string> FallbackPackageFolders { get { throw null; } }
        public string HttpCacheFolder { get { throw null; } }
        public string UserPackageFolder { get { throw null; } }
        public static NuGet.Configuration.NuGetPathContext Create(NuGet.Configuration.ISettings settings) { throw null; }
        public static NuGet.Configuration.NuGetPathContext Create(string settingsRoot) { throw null; }
    }
    public partial class NullSettings : NuGet.Configuration.ISettings
    {
        public NullSettings() { }
        public static NuGet.Configuration.NullSettings Instance { get { throw null; } }
        public event System.EventHandler SettingsChanged { add { } remove { } }
        public void AddOrUpdate(string sectionName, NuGet.Configuration.SettingItem item) { }
        public System.Collections.Generic.IList<string> GetConfigFilePaths() { throw null; }
        public System.Collections.Generic.IList<string> GetConfigRoots() { throw null; }
        public NuGet.Configuration.SettingSection GetSection(string sectionName) { throw null; }
        public void Remove(string sectionName, NuGet.Configuration.SettingItem item) { }
        public void SaveToDisk() { }
    }
    public sealed partial class OwnersItem : NuGet.Configuration.SettingItem
    {
        public static readonly char OwnersListSeparator;
        public OwnersItem(string owners) { }
        protected override bool CanHaveChildren { get { throw null; } }
        public System.Collections.Generic.IList<string> Content { get { throw null; } }
        public override string ElementName { get { throw null; } }
        public override NuGet.Configuration.SettingBase Clone() { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class PackageSource : System.IEquatable<NuGet.Configuration.PackageSource>
    {
        public const int DefaultProtocolVersion = 2;
        public PackageSource(string source) { }
        public PackageSource(string source, string name) { }
        public PackageSource(string source, string name, bool isEnabled) { }
        public PackageSource(string source, string name, bool isEnabled, bool isOfficial, bool isPersistable = true) { }
        public NuGet.Configuration.PackageSourceCredential Credentials { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public bool IsEnabled { get { throw null; } set { } }
        public bool IsHttp { get { throw null; } }
        public bool IsLocal { get { throw null; } }
        public bool IsMachineWide { get { throw null; } set { } }
        public bool IsOfficial { get { throw null; } set { } }
        public bool IsPersistable { get { throw null; } }
        public int MaxHttpRequestsPerSource { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public int ProtocolVersion { get { throw null; } set { } }
        public string Source { get { throw null; } set { } }
        public System.Uri SourceUri { get { throw null; } }
        public System.Uri TrySourceAsUri { get { throw null; } }
        public NuGet.Configuration.SourceItem AsSourceItem() { throw null; }
        public NuGet.Configuration.PackageSource Clone() { throw null; }
        public bool Equals(NuGet.Configuration.PackageSource other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PackageSourceCredential : System.IEquatable<NuGet.Configuration.PackageSourceCredential>
    {
        public PackageSourceCredential(string source, string username, string passwordText, bool isPasswordClearText, string validAuthenticationTypesText) { }
        public bool IsPasswordClearText { get { throw null; } }
        public string Password { get { throw null; } }
        public string PasswordText { get { throw null; } }
        public string Source { get { throw null; } }
        public string Username { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> ValidAuthenticationTypes { get { throw null; } }
        public string ValidAuthenticationTypesText { get { throw null; } }
        public NuGet.Configuration.CredentialsItem AsCredentialsItem() { throw null; }
        public bool Equals(NuGet.Configuration.PackageSourceCredential other) { throw null; }
        public override bool Equals(object other) { throw null; }
        public static NuGet.Configuration.PackageSourceCredential FromUserInput(string source, string username, string password, bool storePasswordInClearText, string validAuthenticationTypesText) { throw null; }
        public override int GetHashCode() { throw null; }
        public bool IsValid() { throw null; }
        public System.Net.ICredentials ToICredentials() { throw null; }
    }
    public partial class PackageSourceProvider : NuGet.Configuration.IPackageSourceProvider
    {
        public PackageSourceProvider(NuGet.Configuration.ISettings settings) { }
        public PackageSourceProvider(NuGet.Configuration.ISettings settings, System.Collections.Generic.IEnumerable<NuGet.Configuration.PackageSource> configurationDefaultSources) { }
        public string ActivePackageSourceName { get { throw null; } }
        public string DefaultPushSource { get { throw null; } }
        public NuGet.Configuration.ISettings Settings { get { throw null; } }
        public event System.EventHandler PackageSourcesChanged { add { } remove { } }
        public void AddPackageSource(NuGet.Configuration.PackageSource source) { }
        [System.ObsoleteAttribute("DisablePackageSource(PackageSource source) is deprecated. Please use DisablePackageSource(string name) instead.")]
        public void DisablePackageSource(NuGet.Configuration.PackageSource source) { }
        public void DisablePackageSource(string name) { }
        public void EnablePackageSource(string name) { }
        public NuGet.Configuration.PackageSource GetPackageSourceByName(string name) { throw null; }
        public NuGet.Configuration.PackageSource GetPackageSourceBySource(string source) { throw null; }
        [System.ObsoleteAttribute("IsPackageSourceEnabled(PackageSource source) is deprecated. Please use IsPackageSourceEnabled(string name) instead.")]
        public bool IsPackageSourceEnabled(NuGet.Configuration.PackageSource source) { throw null; }
        public bool IsPackageSourceEnabled(string name) { throw null; }
        public System.Collections.Generic.IEnumerable<NuGet.Configuration.PackageSource> LoadPackageSources() { throw null; }
        public void RemovePackageSource(string name) { }
        public void SaveActivePackageSource(NuGet.Configuration.PackageSource source) { }
        public void SavePackageSources(System.Collections.Generic.IEnumerable<NuGet.Configuration.PackageSource> sources) { }
        public void UpdatePackageSource(NuGet.Configuration.PackageSource source, bool updateCredentials, bool updateEnabled) { }
    }
    public partial class ProxyCache : NuGet.Configuration.IProxyCache, NuGet.Configuration.IProxyCredentialCache, System.Net.ICredentials
    {
        public ProxyCache(NuGet.Configuration.ISettings settings, NuGet.Common.IEnvironmentVariableReader environment) { }
        public static NuGet.Configuration.ProxyCache Instance { get { throw null; } }
        public System.Guid Version { get { throw null; } }
        [System.ObsoleteAttribute("Retained for backcompat only. Use UpdateCredential instead")]
        public void Add(System.Net.IWebProxy proxy) { }
        public System.Net.NetworkCredential GetCredential(System.Uri proxyAddress, string authType) { throw null; }
        public System.Net.IWebProxy GetProxy(System.Uri sourceUri) { throw null; }
        public NuGet.Configuration.WebProxy GetUserConfiguredProxy() { throw null; }
        public void UpdateCredential(System.Uri proxyAddress, System.Net.NetworkCredential credentials) { }
    }
    public sealed partial class RepositoryItem : NuGet.Configuration.TrustedSignerItem
    {
        public RepositoryItem(string name, string serviceIndex, params NuGet.Configuration.CertificateItem[] certificates) : base (default(string), default(System.Collections.Generic.IEnumerable<NuGet.Configuration.CertificateItem>)) { }
        public RepositoryItem(string name, string serviceIndex, string owners, params NuGet.Configuration.CertificateItem[] certificates) : base (default(string), default(System.Collections.Generic.IEnumerable<NuGet.Configuration.CertificateItem>)) { }
        public override string ElementName { get { throw null; } }
        public new string Name { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Owners { get { throw null; } }
        protected override System.Collections.Generic.IReadOnlyCollection<string> RequiredAttributes { get { throw null; } }
        public string ServiceIndex { get { throw null; } }
        public override NuGet.Configuration.SettingBase Clone() { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public abstract partial class SettingBase
    {
        protected SettingBase() { }
        public abstract NuGet.Configuration.SettingBase Clone();
        public abstract bool IsEmpty();
    }
    public abstract partial class SettingElement : NuGet.Configuration.SettingBase
    {
        protected SettingElement() { }
        protected SettingElement(System.Collections.Generic.IReadOnlyDictionary<string, string> attributes) { }
        protected virtual System.Collections.Generic.IReadOnlyCollection<string> AllowedAttributes { get { throw null; } }
        protected virtual System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyCollection<string>> AllowedValues { get { throw null; } }
        protected virtual System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyCollection<string>> DisallowedValues { get { throw null; } }
        public virtual string ElementName { get { throw null; } protected set { } }
        protected System.Collections.Generic.Dictionary<string, string> MutableAttributes { get { throw null; } }
        protected virtual System.Collections.Generic.IReadOnlyCollection<string> RequiredAttributes { get { throw null; } }
        protected void AddAttribute(string attributeName, string value) { }
        protected void AddOrUpdateAttribute(string attributeName, string value) { }
        public override bool IsEmpty() { throw null; }
    }
    public enum SettingElementType
    {
        ActivePackageSource = 2,
        Add = 9,
        Author = 10,
        BindingRedirects = 3,
        Certificate = 11,
        Clear = 12,
        Config = 4,
        Configuration = 1,
        Owners = 13,
        PackageManagement = 5,
        PackageRestore = 6,
        PackageSourceCredentials = 7,
        PackageSources = 8,
        Repository = 14,
        Unknown = 0,
    }
    public abstract partial class SettingItem : NuGet.Configuration.SettingElement
    {
        protected SettingItem() { }
        protected SettingItem(System.Collections.Generic.IReadOnlyDictionary<string, string> attributes) { }
        protected virtual bool CanHaveChildren { get { throw null; } }
    }
    public partial class Settings : NuGet.Configuration.ISettings
    {
        public static readonly string DefaultSettingsFileName;
        public static readonly string[] OrderedSettingsFileNames;
        public static readonly string[] SupportedMachineWideConfigExtension;
        public Settings(string root) { }
        public Settings(string root, string fileName) { }
        public Settings(string root, string fileName, bool isMachineWide) { }
        public event System.EventHandler SettingsChanged { add { } remove { } }
        public void AddOrUpdate(string sectionName, NuGet.Configuration.SettingItem item) { }
        public static string ApplyEnvironmentTransform(string value) { throw null; }
        public System.Collections.Generic.IList<string> GetConfigFilePaths() { throw null; }
        public System.Collections.Generic.IList<string> GetConfigRoots() { throw null; }
        public static System.Tuple<string, string> GetFileNameAndItsRoot(string root, string settingsPath) { throw null; }
        public NuGet.Configuration.SettingSection GetSection(string sectionName) { throw null; }
        public static NuGet.Configuration.ISettings LoadDefaultSettings(string root) { throw null; }
        public static NuGet.Configuration.ISettings LoadDefaultSettings(string root, string configFileName, NuGet.Configuration.IMachineWideSettings machineWideSettings) { throw null; }
        public static NuGet.Configuration.ISettings LoadMachineWideSettings(string root, params string[] paths) { throw null; }
        public static NuGet.Configuration.ISettings LoadSettingsGivenConfigPaths(System.Collections.Generic.IList<string> configFilePaths) { throw null; }
        public static NuGet.Configuration.ISettings LoadSpecificSettings(string root, string configFileName) { throw null; }
        public void Remove(string sectionName, NuGet.Configuration.SettingItem item) { }
        public void SaveToDisk() { }
    }
    public abstract partial class SettingSection : NuGet.Configuration.SettingsGroup<NuGet.Configuration.SettingItem>
    {
        protected SettingSection(string name, System.Collections.Generic.IReadOnlyDictionary<string, string> attributes, System.Collections.Generic.IEnumerable<NuGet.Configuration.SettingItem> children) { }
        public override string ElementName { get { throw null; } protected set { } }
        public System.Collections.Generic.IReadOnlyCollection<NuGet.Configuration.SettingItem> Items { get { throw null; } }
        public override bool Equals(object other) { throw null; }
        public T GetFirstItemWithAttribute<T>(string attributeName, string expectedAttributeValue) where T : NuGet.Configuration.SettingItem { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public abstract partial class SettingsGroup<T> : NuGet.Configuration.SettingElement where T : NuGet.Configuration.SettingElement
    {
        protected SettingsGroup() { }
        protected SettingsGroup(System.Collections.Generic.IReadOnlyDictionary<string, string> attributes, System.Collections.Generic.IEnumerable<T> children) { }
        protected virtual bool CanBeCleared { get { throw null; } }
        protected System.Collections.Generic.IList<T> Children { get { throw null; } }
        public override bool IsEmpty() { throw null; }
        protected bool TryGetChild(T expectedChild, out T currentChild) { throw null; }
    }
    public static partial class SettingsUtility
    {
        public static readonly string DefaultGlobalPackagesFolderPath;
        public static bool DeleteConfigValue(NuGet.Configuration.ISettings settings, string key) { throw null; }
        public static bool DeleteValue(NuGet.Configuration.ISettings settings, string section, string attributeKey, string attributeValue) { throw null; }
        public static string GetConfigValue(NuGet.Configuration.ISettings settings, string key, bool decrypt = false, bool isPath = false) { throw null; }
        public static string GetDecryptedValueForAddItem(NuGet.Configuration.ISettings settings, string section, string key, bool isPath = false) { throw null; }
        public static string GetDefaultPushSource(NuGet.Configuration.ISettings settings) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Configuration.PackageSource> GetEnabledSources(NuGet.Configuration.ISettings settings) { throw null; }
        public static System.Collections.Generic.IReadOnlyList<string> GetFallbackPackageFolders(NuGet.Configuration.ISettings settings) { throw null; }
        public static string GetGlobalPackagesFolder(NuGet.Configuration.ISettings settings) { throw null; }
        public static string GetHttpCacheFolder() { throw null; }
        public static int GetMaxHttpRequest(NuGet.Configuration.ISettings settings) { throw null; }
        public static string GetPluginsCacheFolder() { throw null; }
        public static string GetRepositoryPath(NuGet.Configuration.ISettings settings) { throw null; }
        public static NuGet.Common.RevocationMode GetRevocationMode() { throw null; }
        public static NuGet.Common.SignatureValidationMode GetSignatureValidationMode(NuGet.Configuration.ISettings settings) { throw null; }
        public static string GetValueForAddItem(NuGet.Configuration.ISettings settings, string section, string key, bool isPath = false) { throw null; }
        public static void SetConfigValue(NuGet.Configuration.ISettings settings, string key, string value, bool encrypt = false) { }
        public static void SetEncryptedValueForAddItem(NuGet.Configuration.ISettings settings, string section, string key, string value) { }
    }
    public sealed partial class SettingText : NuGet.Configuration.SettingBase
    {
        public SettingText(string value) { }
        public string Value { get { throw null; } set { } }
        public override NuGet.Configuration.SettingBase Clone() { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsEmpty() { throw null; }
    }
    [System.ObsoleteAttribute("SettingValue is deprecated. Please use AddItem instead")]
    public partial class SettingValue
    {
        public SettingValue(string key, string value, NuGet.Configuration.ISettings origin, bool isMachineWide, int priority = 0) { }
        public SettingValue(string key, string value, NuGet.Configuration.ISettings origin, bool isMachineWide, string originalValue, int priority = 0) { }
        public SettingValue(string key, string value, bool isMachineWide, int priority = 0) { }
        public System.Collections.Generic.IDictionary<string, string> AdditionalData { get { throw null; } }
        public bool IsMachineWide { get { throw null; } set { } }
        public string Key { get { throw null; } }
        public NuGet.Configuration.ISettings Origin { get { throw null; } }
        public string OriginalValue { get { throw null; } set { } }
        public int Priority { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public sealed partial class SourceItem : NuGet.Configuration.AddItem
    {
        public SourceItem(string key, string value, string protocolVersion = "") : base (default(string), default(string)) { }
        public string ProtocolVersion { get { throw null; } set { } }
        public override NuGet.Configuration.SettingBase Clone() { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public abstract partial class TrustedSignerItem : NuGet.Configuration.SettingItem
    {
        protected TrustedSignerItem(string name, System.Collections.Generic.IEnumerable<NuGet.Configuration.CertificateItem> certificates) { }
        protected override bool CanHaveChildren { get { throw null; } }
        public System.Collections.Generic.IList<NuGet.Configuration.CertificateItem> Certificates { get { throw null; } }
        public virtual string Name { get { throw null; } }
        protected void SetName(string value) { }
    }
    public sealed partial class UnknownItem : NuGet.Configuration.SettingItem
    {
        public UnknownItem(string name, System.Collections.Generic.IReadOnlyDictionary<string, string> attributes, System.Collections.Generic.IEnumerable<NuGet.Configuration.SettingBase> children) { }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Attributes { get { throw null; } }
        protected override bool CanHaveChildren { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<NuGet.Configuration.SettingBase> Children { get { throw null; } }
        public override string ElementName { get { throw null; } protected set { } }
        public override NuGet.Configuration.SettingBase Clone() { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsEmpty() { throw null; }
    }
    public sealed partial class VirtualSettingSection : NuGet.Configuration.SettingSection
    {
        internal VirtualSettingSection() : base (default(string), default(System.Collections.Generic.IReadOnlyDictionary<string, string>), default(System.Collections.Generic.IEnumerable<NuGet.Configuration.SettingItem>)) { }
        public override NuGet.Configuration.SettingBase Clone() { throw null; }
    }
    public partial class WebProxy : System.Net.IWebProxy
    {
        public WebProxy(string proxyAddress) { }
        public WebProxy(System.Uri proxyAddress) { }
        public System.Collections.Generic.IReadOnlyList<string> BypassList { get { throw null; } set { } }
        public System.Net.ICredentials Credentials { get { throw null; } set { } }
        public System.Uri ProxyAddress { get { throw null; } }
        public System.Uri GetProxy(System.Uri destination) { throw null; }
        public bool IsBypassed(System.Uri uri) { throw null; }
    }
    public partial class XPlatMachineWideSetting : NuGet.Configuration.IMachineWideSettings
    {
        public XPlatMachineWideSetting() { }
        public NuGet.Configuration.ISettings Settings { get { throw null; } }
    }
}
