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
[assembly: AssemblyTitle("System.Security.Cryptography.ProtectedData")]
[assembly: AssemblyDescription("System.Security.Cryptography.ProtectedData")]
[assembly: AssemblyDefaultAlias("System.Security.Cryptography.ProtectedData")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("4.6.25519.03")]
[assembly: AssemblyInformationalVersion("4.6.25519.03 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("4.0.2.0")]




namespace System.Security.Cryptography
{
    public enum DataProtectionScope
    {
        CurrentUser = 0,
        LocalMachine = 1,
    }
    public static partial class ProtectedData
    {
        public static byte[] Protect(byte[] userData, byte[] optionalEntropy, System.Security.Cryptography.DataProtectionScope scope) { throw null; }
        public static byte[] Unprotect(byte[] encryptedData, byte[] optionalEntropy, System.Security.Cryptography.DataProtectionScope scope) { throw null; }
    }
}
