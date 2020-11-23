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

// Manual modification: remove assembly attributes in all but one source file.
// These source files end up in one assembly **unlike the Microsoft package** so
// we have to pick a "main" assembly.
// [assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
// [assembly: AllowPartiallyTrustedCallers]
// [assembly: ReferenceAssembly]
// [assembly: AssemblyTitle("microsoft.dotnet.templateLocator")]
// [assembly: AssemblyDescription("microsoft.dotnet.templateLocator")]
// [assembly: AssemblyDefaultAlias("microsoft.dotnet.templateLocator")]
// [assembly: AssemblyCompany("Microsoft Corporation")]
// [assembly: AssemblyProduct("Microsoft® .NET Framework")]
// [assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
// [assembly: AssemblyFileVersion("5.1.20.42119")]
// [assembly: AssemblyInformationalVersion("5.1.20.42119 built by: SOURCEBUILD")]
// [assembly: CLSCompliant(true)]
// [assembly: AssemblyMetadata("", "")]
// [assembly: AssemblyVersion("5.0.100.0")]




namespace Microsoft.DotNet.DotNetSdkResolver
{
    public partial class NETCoreSdkResolver
    {
        public NETCoreSdkResolver() { }
        public NETCoreSdkResolver(System.Func<string, string> getEnvironmentVariable, Microsoft.DotNet.DotNetSdkResolver.VSSettings vsSettings) { }
        public string GetDotnetExeDirectory() { throw null; }
        public System.Version GetMinimumMSBuildVersion(string netcoreSdkDir) { throw null; }
        public Microsoft.DotNet.DotNetSdkResolver.SdkResolutionResult ResolveNETCoreSdkDirectory(string globalJsonStartDir, System.Version msbuildVersion, bool isRunningInVisualStudio, string dotnetExeDir) { throw null; }
    }
    public partial class SdkResolutionResult
    {
        public bool FailedToResolveSDKSpecifiedInGlobalJson;
        public string GlobalJsonPath;
        public string ResolvedSdkDirectory;
        public SdkResolutionResult() { }
    }
    public sealed partial class VSSettings
    {
        public static readonly Microsoft.DotNet.DotNetSdkResolver.VSSettings Ambient;
        public VSSettings(string settingsFilePath, bool disallowPrereleaseByDefault) { }
        public bool DisallowPrerelease() { throw null; }
    }
}
namespace Microsoft.VisualStudio.Setup.Configuration
{
    [System.Runtime.InteropServices.TypeIdentifierAttribute]
    public partial interface ISetupConfiguration
    {
    }
    [System.Runtime.InteropServices.TypeIdentifierAttribute]
    public partial interface ISetupConfiguration2 : Microsoft.VisualStudio.Setup.Configuration.ISetupConfiguration
    {
        Microsoft.VisualStudio.Setup.Configuration.ISetupInstance GetInstanceForCurrentProcess();
        void _VtblGap1_1() { }
    }
    [System.Runtime.InteropServices.TypeIdentifierAttribute]
    public partial interface ISetupInstance
    {
        string GetInstallationVersion();
        string GetInstanceId();
        void _VtblGap1_3() { }
    }
    [System.Runtime.InteropServices.TypeIdentifierAttribute]
    public partial interface ISetupInstanceCatalog
    {
        bool IsPrerelease();
        void _VtblGap1_1() { }
    }
    [System.Runtime.InteropServices.CoClassAttribute(typeof(object))]
    [System.Runtime.InteropServices.TypeIdentifierAttribute]
    public partial interface SetupConfiguration : Microsoft.VisualStudio.Setup.Configuration.ISetupConfiguration, Microsoft.VisualStudio.Setup.Configuration.ISetupConfiguration2
    {
    }
}
