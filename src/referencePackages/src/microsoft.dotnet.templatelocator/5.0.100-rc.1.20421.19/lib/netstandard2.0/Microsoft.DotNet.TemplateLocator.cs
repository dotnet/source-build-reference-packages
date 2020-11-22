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
[assembly: AssemblyTitle("microsoft.dotnet.templateLocator")]
[assembly: AssemblyDescription("microsoft.dotnet.templateLocator")]
[assembly: AssemblyDefaultAlias("microsoft.dotnet.templateLocator")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("5.1.20.42119")]
[assembly: AssemblyInformationalVersion("5.1.20.42119 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("5.0.100.0")]




namespace Microsoft.DotNet.TemplateLocator
{
    public partial interface IOptionalSdkTemplatePackageInfo
    {
        string Path { get; }
        string TemplatePackageId { get; }
        string TemplateVersion { get; }
    }
    public sealed partial class TemplateLocator
    {
        public TemplateLocator() { }
        public TemplateLocator(System.Func<string, string> getEnvironmentVariable, Microsoft.DotNet.DotNetSdkResolver.VSSettings vsSettings) { }
        public System.Collections.Generic.IReadOnlyCollection<Microsoft.DotNet.TemplateLocator.IOptionalSdkTemplatePackageInfo> GetDotnetSdkTemplatePackages(string sdkVersion, string dotnetRootPath) { throw null; }
        public bool TryGetDotnetSdkVersionUsedInVs(string vsVersion, out string sdkVersion) { throw null; }
    }
}
