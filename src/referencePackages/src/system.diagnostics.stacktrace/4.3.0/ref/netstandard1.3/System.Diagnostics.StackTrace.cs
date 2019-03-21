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
[assembly: AssemblyTitle("System.Diagnostics.StackTrace")]
[assembly: AssemblyDescription("System.Diagnostics.StackTrace")]
[assembly: AssemblyDefaultAlias("System.Diagnostics.StackTrace")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("1.0.24301.01")]
[assembly: AssemblyInformationalVersion("1.0.24301.01 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("4.0.2.0")]




namespace System.Diagnostics
{
    public sealed partial class StackFrame
    {
        internal StackFrame() { }
        public const int OFFSET_UNKNOWN = -1;
        public int GetFileColumnNumber() { throw null; }
        public int GetFileLineNumber() { throw null; }
        public string GetFileName() { throw null; }
        public int GetILOffset() { throw null; }
        public System.Reflection.MethodBase GetMethod() { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class StackFrameExtensions
    {
        public static System.IntPtr GetNativeImageBase(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        public static System.IntPtr GetNativeIP(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        public static bool HasILOffset(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        public static bool HasMethod(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        public static bool HasNativeImage(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        public static bool HasSource(this System.Diagnostics.StackFrame stackFrame) { throw null; }
    }
    public sealed partial class StackTrace
    {
        public StackTrace(System.Exception exception, bool needFileInfo) { }
        public System.Diagnostics.StackFrame[] GetFrames() { throw null; }
        public override string ToString() { throw null; }
    }
}
