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
[assembly: AssemblyTitle("System.Reflection.MetadataLoadContext")]
[assembly: AssemblyDescription("System.Reflection.MetadataLoadContext")]
[assembly: AssemblyDefaultAlias("System.Reflection.MetadataLoadContext")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("4.700.20.6702")]
[assembly: AssemblyInformationalVersion("4.700.20.6702 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("4.0.1.1")]




namespace System.Reflection
{
    public abstract partial class MetadataAssemblyResolver
    {
        protected MetadataAssemblyResolver() { }
        public abstract System.Reflection.Assembly Resolve(System.Reflection.MetadataLoadContext context, System.Reflection.AssemblyName assemblyName);
    }
    public sealed partial class MetadataLoadContext : System.IDisposable
    {
        public MetadataLoadContext(System.Reflection.MetadataAssemblyResolver resolver, string coreAssemblyName = null) { }
        public System.Reflection.Assembly CoreAssembly { get { throw null; } }
        public void Dispose() { }
        public System.Collections.Generic.IEnumerable<System.Reflection.Assembly> GetAssemblies() { throw null; }
        public System.Reflection.Assembly LoadFromAssemblyName(System.Reflection.AssemblyName assemblyName) { throw null; }
        public System.Reflection.Assembly LoadFromAssemblyName(string assemblyName) { throw null; }
        public System.Reflection.Assembly LoadFromAssemblyPath(string assemblyPath) { throw null; }
        public System.Reflection.Assembly LoadFromByteArray(byte[] assembly) { throw null; }
        public System.Reflection.Assembly LoadFromStream(System.IO.Stream assembly) { throw null; }
    }
    public partial class PathAssemblyResolver : System.Reflection.MetadataAssemblyResolver
    {
        public PathAssemblyResolver(System.Collections.Generic.IEnumerable<string> assemblyPaths) { }
        public override System.Reflection.Assembly Resolve(System.Reflection.MetadataLoadContext context, System.Reflection.AssemblyName assemblyName) { throw null; }
    }
}
