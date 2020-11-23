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




namespace Microsoft.NET.Sdk.WorkloadManifestReader
{
    public partial class WorkloadManifest
    {
        public WorkloadManifest() { }
        public System.Collections.Generic.Dictionary<string, (string version, string kind)> SdkPackDetail { get { throw null; } set { } }
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> Workloads { get { throw null; } set { } }
        public static Microsoft.NET.Sdk.WorkloadManifestReader.WorkloadManifest LoadFromFolder(string manifestFolder) { throw null; }
        public static Microsoft.NET.Sdk.WorkloadManifestReader.WorkloadManifest Merge(System.Collections.Generic.IEnumerable<Microsoft.NET.Sdk.WorkloadManifestReader.WorkloadManifest> manifests) { throw null; }
    }
}
