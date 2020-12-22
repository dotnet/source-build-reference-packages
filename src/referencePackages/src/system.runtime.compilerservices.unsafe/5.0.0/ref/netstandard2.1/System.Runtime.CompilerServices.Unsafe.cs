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
[assembly: AssemblyTitle("System.Runtime.CompilerServices.Unsafe")]
[assembly: AssemblyDescription("System.Runtime.CompilerServices.Unsafe")]
[assembly: AssemblyDefaultAlias("System.Runtime.CompilerServices.Unsafe")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("5.0.20.51904")]
[assembly: AssemblyInformationalVersion("5.0.20.51904 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("5.0.0.0")]




namespace System.Runtime.CompilerServices
{
    public static partial class Unsafe
    {
        public static ref T AddByteOffset<T>(ref T source, System.IntPtr byteOffset) { throw null; }
        public unsafe static void* Add<T>(void* source, int elementOffset) { throw null; }
        public static ref T Add<T>(ref T source, int elementOffset) { throw null; }
        public static ref T Add<T>(ref T source, System.IntPtr elementOffset) { throw null; }
        public static bool AreSame<T>([System.Diagnostics.CodeAnalysis.AllowNullAttribute]ref T left, [System.Diagnostics.CodeAnalysis.AllowNullAttribute]ref T right) { throw null; }
        public unsafe static void* AsPointer<T>(ref T value) { throw null; }
        public unsafe static ref T AsRef<T>(void* source) { throw null; }
        public static ref T AsRef<T>(in T source) { throw null; }
        // Manual fixup on next line. Attribute was in wrong place and not marked "return:". https://github.com/dotnet/arcade/issues/6718
        [return: System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute("o")] public static T As<T>(object o) where T : class { throw null; }
        public static ref TTo As<TFrom, TTo>(ref TFrom source) { throw null; }
        public static System.IntPtr ByteOffset<T>([System.Diagnostics.CodeAnalysis.AllowNullAttribute]ref T origin, [System.Diagnostics.CodeAnalysis.AllowNullAttribute]ref T target) { throw null; }
        public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) { }
        public unsafe static void CopyBlock(void* destination, void* source, uint byteCount) { }
        public static void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount) { }
        public unsafe static void CopyBlockUnaligned(void* destination, void* source, uint byteCount) { }
        public unsafe static void Copy<T>(void* destination, ref T source) { }
        public unsafe static void Copy<T>(ref T destination, void* source) { }
        public static void InitBlock(ref byte startAddress, byte value, uint byteCount) { }
        public unsafe static void InitBlock(void* startAddress, byte value, uint byteCount) { }
        public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }
        public unsafe static void InitBlockUnaligned(void* startAddress, byte value, uint byteCount) { }
        public static bool IsAddressGreaterThan<T>([System.Diagnostics.CodeAnalysis.AllowNullAttribute]ref T left, [System.Diagnostics.CodeAnalysis.AllowNullAttribute]ref T right) { throw null; }
        public static bool IsAddressLessThan<T>([System.Diagnostics.CodeAnalysis.AllowNullAttribute]ref T left, [System.Diagnostics.CodeAnalysis.AllowNullAttribute]ref T right) { throw null; }
        public static bool IsNullRef<T>(ref T source) { throw null; }
        public static ref T NullRef<T>() { throw null; }
        public static T ReadUnaligned<T>(ref byte source) { throw null; }
        public unsafe static T ReadUnaligned<T>(void* source) { throw null; }
        public unsafe static T Read<T>(void* source) { throw null; }
        public static int SizeOf<T>() { throw null; }
        public static void SkipInit<T>(out T value) { throw null; }
        public static ref T SubtractByteOffset<T>(ref T source, System.IntPtr byteOffset) { throw null; }
        public unsafe static void* Subtract<T>(void* source, int elementOffset) { throw null; }
        public static ref T Subtract<T>(ref T source, int elementOffset) { throw null; }
        public static ref T Subtract<T>(ref T source, System.IntPtr elementOffset) { throw null; }
        public static ref T Unbox<T>(object box) where T : struct { throw null; }
        public static void WriteUnaligned<T>(ref byte destination, T value) { }
        public unsafe static void WriteUnaligned<T>(void* destination, T value) { }
        public unsafe static void Write<T>(void* destination, T value) { }
    }
}
