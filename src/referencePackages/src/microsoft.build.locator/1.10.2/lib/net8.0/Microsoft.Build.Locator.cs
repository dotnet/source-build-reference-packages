// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Reflection.AssemblyFileVersion("1.10.2.26959")]
[assembly: System.Reflection.AssemblyInformationalVersion("1.10.2+694ff392b2")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Microsoft.Build.Locator.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100adad416086fc859fe034cc45ba1ae17cbcaa8d471c5884ef08af87f7cd4e1bbb663e1387f24bbc479d913f125643e19d6da998b0b31a2979abcd36a858756676a65f36b27d6b6a3fd330e20ed5f73da134938bbbf90276d1fcf2f887e44e0eca4d767e147d95220433e5a4e14dcb6e6cea955e360a53642985b407a63e21f0ab")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v8.0", FrameworkDisplayName = ".NET 8.0")]
[assembly: System.Reflection.AssemblyCompany("Microsoft")]
[assembly: System.Reflection.AssemblyConfiguration("Release")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
[assembly: System.Reflection.AssemblyDescription("Package that assists in locating and using a copy of MSBuild installed as part of Visual Studio 2017 or higher or .NET Core SDK 2.1 or higher.")]
[assembly: System.Reflection.AssemblyProduct("Microsoft.Build.Locator")]
[assembly: System.Reflection.AssemblyTitle("Microsoft.Build.Locator")]
[assembly: System.Reflection.AssemblyMetadata("RepositoryUrl", "https://github.com/microsoft/MSBuildLocator")]
[assembly: System.Reflection.AssemblyVersionAttribute("1.0.0.0")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace Microsoft.Build.Locator
{
    [System.Flags]
    public enum DiscoveryType
    {
        DeveloperConsole = 1,
        VisualStudioSetup = 2,
        DotNetSdk = 4
    }

    public static partial class MSBuildLocator
    {
        public static bool AllowQueryAllDotnetLocations { get { throw null; } set { } }
        public static bool AllowQueryAllRuntimeVersions { get { throw null; } set { } }
        public static bool CanRegister { get { throw null; } }
        public static bool IsRegistered { get { throw null; } }

        public static System.Collections.Generic.IEnumerable<VisualStudioInstance> QueryVisualStudioInstances() { throw null; }
        public static System.Collections.Generic.IEnumerable<VisualStudioInstance> QueryVisualStudioInstances(VisualStudioInstanceQueryOptions options) { throw null; }
        public static VisualStudioInstance RegisterDefaults() { throw null; }
        public static void RegisterInstance(VisualStudioInstance instance) { }
        public static void RegisterMSBuildPath(string msbuildPath) { }
        public static void RegisterMSBuildPath(string[] msbuildSearchPaths) { }
        public static void Unregister() { }
    }
    public partial class VisualStudioInstance
    {
        internal VisualStudioInstance() { }
        public DiscoveryType DiscoveryType { get { throw null; } }
        public string MSBuildPath { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Version Version { get { throw null; } }
        public string VisualStudioRootPath { get { throw null; } }
    }
    public partial class VisualStudioInstanceQueryOptions
    {
        public bool AllowAllDotnetLocations { get { throw null; } set { } }
        public bool AllowAllRuntimeVersions { get { throw null; } set { } }
        public static VisualStudioInstanceQueryOptions Default { get { throw null; } }
        public DiscoveryType DiscoveryTypes { get { throw null; } set { } }
        public string WorkingDirectory { get { throw null; } set { } }
    }
}