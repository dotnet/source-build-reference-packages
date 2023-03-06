// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Reflection.AssemblyDescription("System.Diagnostics.Debug.dll")]
[assembly: System.Reflection.AssemblyDefaultAlias("System.Diagnostics.Debug.dll")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Reflection.AssemblyTitle("System.Diagnostics.Debug.dll")]
[assembly: System.Reflection.AssemblyFileVersion("4.0.30319.17929")]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyProduct("Microsoft® .NET Framework")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: System.Reflection.AssemblyDelaySign(true)]
[assembly: System.Reflection.AssemblyInformationalVersion("4.0.30319.17929")]
[assembly: System.Reflection.AssemblyKeyFile("f:\\dd\\tools\\devdiv\\FinalPublicKey.snk")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Security.AllowPartiallyTrustedCallers]
namespace System.Diagnostics
{
    public static partial class Debug
    {
        public static void Assert(bool condition, string message) { }

        public static void Assert(bool condition) { }

        public static void WriteLine(object value) { }

        public static void WriteLine(string format, params object[] args) { }

        public static void WriteLine(string message) { }

        public static void WriteLineIf(bool condition, string message) { }
    }

    public static partial class Debugger
    {
        public static bool IsAttached { get { throw null; } }

        public static void Break() { }

        public static bool Launch() { throw null; }
    }

    public enum DebuggerBrowsableState
    {
        Never = 0,
        Collapsed = 2,
        RootHidden = 3
    }
}