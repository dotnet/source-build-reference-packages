// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Reflection.AssemblyDefaultAlias("System.Security.Cryptography.Cng")]
[assembly: System.Reflection.AssemblyMetadata(".NETFrameworkAssembly", "")]
[assembly: System.Reflection.AssemblyMetadata("Serviceable", "True")]
[assembly: System.Reflection.AssemblyMetadata("PreferInbox", "True")]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
[assembly: System.Reflection.AssemblyDescription("System.Security.Cryptography.Cng")]
[assembly: System.Reflection.AssemblyFileVersion("4.700.19.56404")]
[assembly: System.Reflection.AssemblyInformationalVersion("3.1.0+0f7f38c4fd323b26da10cce95f857f77f0f09b48")]
[assembly: System.Reflection.AssemblyProduct("Microsoft® .NET Core")]
[assembly: System.Reflection.AssemblyTitle("System.Security.Cryptography.Cng")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.CLSCompliant(true)]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(Microsoft.Win32.SafeHandles.SafeNCryptHandle))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(Microsoft.Win32.SafeHandles.SafeNCryptKeyHandle))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(Microsoft.Win32.SafeHandles.SafeNCryptProviderHandle))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(Microsoft.Win32.SafeHandles.SafeNCryptSecretHandle))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngAlgorithm))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngAlgorithmGroup))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngExportPolicies))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngKey))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngKeyBlobFormat))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngKeyCreationOptions))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngKeyCreationParameters))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngKeyHandleOpenOptions))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngKeyOpenOptions))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngKeyUsages))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngProperty))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngPropertyCollection))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngPropertyOptions))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngProvider))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngUIPolicy))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.CngUIProtectionLevels))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.ECDiffieHellmanCng))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.ECDiffieHellmanCngPublicKey))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.ECDsaCng))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.ECKeyXmlFormat))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Security.Cryptography.RSACng))]
namespace System.Security.Cryptography
{
    public sealed partial class AesCng : Aes
    {
        public AesCng() { }

        public AesCng(string keyName, CngProvider provider, CngKeyOpenOptions openOptions) { }

        public AesCng(string keyName, CngProvider provider) { }

        public AesCng(string keyName) { }

        public override byte[] Key { get { throw null; } set { } }

        public override int KeySize { get { throw null; } set { } }

        public override ICryptoTransform CreateDecryptor() { throw null; }

        public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }

        public override ICryptoTransform CreateEncryptor() { throw null; }

        public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }

        protected override void Dispose(bool disposing) { }

        public override void GenerateIV() { }

        public override void GenerateKey() { }
    }

    public sealed partial class DSACng : DSA
    {
        public DSACng() { }

        public DSACng(int keySize) { }

        public DSACng(CngKey key) { }

        public CngKey Key { get { throw null; } }

        public override string KeyExchangeAlgorithm { get { throw null; } }

        public override KeySizes[] LegalKeySizes { get { throw null; } }

        public override string SignatureAlgorithm { get { throw null; } }

        public override byte[] CreateSignature(byte[] rgbHash) { throw null; }

        protected override void Dispose(bool disposing) { }

        public override DSAParameters ExportParameters(bool includePrivateParameters) { throw null; }

        public override void ImportParameters(DSAParameters parameters) { }

        public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { throw null; }
    }

    public sealed partial class TripleDESCng : TripleDES
    {
        public TripleDESCng() { }

        public TripleDESCng(string keyName, CngProvider provider, CngKeyOpenOptions openOptions) { }

        public TripleDESCng(string keyName, CngProvider provider) { }

        public TripleDESCng(string keyName) { }

        public override byte[] Key { get { throw null; } set { } }

        public override int KeySize { get { throw null; } set { } }

        public override ICryptoTransform CreateDecryptor() { throw null; }

        public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }

        public override ICryptoTransform CreateEncryptor() { throw null; }

        public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }

        protected override void Dispose(bool disposing) { }

        public override void GenerateIV() { }

        public override void GenerateKey() { }
    }
}