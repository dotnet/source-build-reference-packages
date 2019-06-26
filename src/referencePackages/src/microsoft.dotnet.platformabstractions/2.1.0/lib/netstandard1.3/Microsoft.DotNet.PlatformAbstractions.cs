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
[assembly: AssemblyTitle("Microsoft.DotNet.PlatformAbstractions")]
[assembly: AssemblyDescription("Microsoft.DotNet.PlatformAbstractions")]
[assembly: AssemblyDefaultAlias("Microsoft.DotNet.PlatformAbstractions")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("2.1.0")]
[assembly: AssemblyInformationalVersion("2.1.0 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("2.1.0.0")]




namespace Microsoft.DotNet.PlatformAbstractions
{
    public static partial class ApplicationEnvironment
    {
        public static string ApplicationBasePath { get { throw null; } }
    }
    public partial struct HashCodeCombiner
    {
        private int _dummyPrimitive;
        public int CombinedHash { get { throw null; } }
        public void Add(int i) { }
        public void Add(object o) { }
        public void Add(string s) { }
        public void Add<TValue>(TValue value, System.Collections.Generic.IEqualityComparer<TValue> comparer) { }
        public static Microsoft.DotNet.PlatformAbstractions.HashCodeCombiner Start() { throw null; }
    }
    public enum Platform
    {
        Darwin = 3,
        FreeBSD = 4,
        Linux = 2,
        Unknown = 0,
        Windows = 1,
    }
    public static partial class RuntimeEnvironment
    {
        public static string OperatingSystem { get { throw null; } }
        public static Microsoft.DotNet.PlatformAbstractions.Platform OperatingSystemPlatform { get { throw null; } }
        public static string OperatingSystemVersion { get { throw null; } }
        public static string RuntimeArchitecture { get { throw null; } }
        public static string GetRuntimeIdentifier() { throw null; }
    }
}
