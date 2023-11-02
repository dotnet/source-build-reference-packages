// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using NuGet.Packaging;
using NuGet.Packaging.Signing;
using Xunit;
using Xunit.Abstractions;

namespace ValidateSbrpTests;

public class ValidateSbrpTests
{
    private string[] Packages { get; set; }

    private const string SbrpAttributeType = "System.Reflection.AssemblyMetadataAttribute";

    private const string VerionPattern = @"(\.\d)+([\-\w])*";

    private string RepoRoot { get; set; }

    public ITestOutputHelper output { get; set; }

    public ValidateSbrpTests(ITestOutputHelper _output)
    {
        output = _output;

        RepoRoot = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("artifacts"));

        string buildPackagesDirectory = Path.Combine(RepoRoot, "artifacts/source-build/self/src/artifacts/packages/Release/Shipping");

        if (!Directory.Exists(buildPackagesDirectory))
        {
            throw new DirectoryNotFoundException($"Directory {buildPackagesDirectory} does not exist. Try building with './build.sh -sb' first.");
        }

        Packages = Directory.GetFiles(buildPackagesDirectory, "*.nupkg", SearchOption.AllDirectories);
    }

    [Fact]
    public void CheckForSbrpAttribute()
    {
        string[] targetPacks = Directory.GetDirectories(Path.Combine(RepoRoot, "src/targetPacks/ILsrc")).Select(x => Path.GetFileName(x).ToLower()).ToArray();
        string[] textOnlyPackages = Directory.GetDirectories(Path.Combine(RepoRoot, "src/textOnlyPackages/src")).Select(x => Path.GetFileName(x).ToLower()).ToArray();

        var filteredPackages = new List<string>();
        
        foreach (var package in Packages)
        {
            string packageName = Path.GetFileNameWithoutExtension(package).ToLower();
            packageName = Regex.Replace(packageName, VerionPattern, string.Empty);
            if (!targetPacks.Contains(packageName) && !textOnlyPackages.Contains(packageName))
            {
                filteredPackages.Add(package);
            }
        }

        foreach (var package in filteredPackages)
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName(), Path.GetFileNameWithoutExtension(package));

            try
            {
                Directory.CreateDirectory(tempDirectory);

                ZipFile.ExtractToDirectory(package, tempDirectory);

                var dlls = Directory.GetFiles(tempDirectory, "*.dll", SearchOption.AllDirectories);

                foreach (var dll in dlls)
                {
                    using var stream = new FileStream(dll, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    using var peReader = new PEReader(stream);

                    MetadataReader reader = peReader.GetMetadataReader();

                    Assert.True(HasSbrpAttribute(reader), $"{package}/{Path.GetRelativePath(tempDirectory, dll)} does not contain the {SbrpAttributeType} attribute with key='source' and value='source-build-reference-packages'.");
                }
            }
            finally
            {
                Directory.Delete(tempDirectory, true);
            }
        }
    }

    [Fact]
    public async Task CheckForSignature()
    {
        var trustProviders = new List<ISignatureVerificationProvider>()
        {
            new SignatureTrustAndValidityVerificationProvider()
        };
        var verifier = new PackageSignatureVerifier(trustProviders);

        var settings = SignedPackageVerifierSettings.GetDefault();

        foreach (var package in Packages)
        {
            bool isSigned = await IsPackageSigned(package, verifier, settings);
            Assert.False(isSigned, $"{package} is signed. Signed packages are not allowed in source-build-reference-packages.");
        }
    }

    private bool HasSbrpAttribute(MetadataReader reader)
    {
        return reader.CustomAttributes.Select(attrHandle => reader.GetCustomAttribute(attrHandle)).Any(attr => IsAttributeSbrp(reader, attr));
    }

    private bool IsAttributeSbrp(MetadataReader reader, CustomAttribute attr)
    {
        string attributeType = string.Empty;

        if (attr.Constructor.Kind == HandleKind.MemberReference)
        {
            var mref = reader.GetMemberReference((MemberReferenceHandle)attr.Constructor);
            if (mref.Parent.Kind == HandleKind.TypeReference)
            {
                var tref = reader.GetTypeReference((TypeReferenceHandle)mref.Parent);
                attributeType = $"{reader.GetString(tref.Namespace)}.{reader.GetString(tref.Name)}";
            }
            else if (mref.Parent.Kind == HandleKind.TypeDefinition)
            {
                var tdef = reader.GetTypeDefinition((TypeDefinitionHandle)mref.Parent);
                attributeType = $"{reader.GetString(tdef.Namespace)}.{reader.GetString(tdef.Name)}";
            }
        }
        else if (attr.Constructor.Kind == HandleKind.MethodDefinition)
        {
            var mdef = reader.GetMethodDefinition((MethodDefinitionHandle)attr.Constructor);
            var tdef = reader.GetTypeDefinition(mdef.GetDeclaringType());
            attributeType = $"{reader.GetString(tdef.Namespace)}.{reader.GetString(tdef.Name)}";
        }

        if (attributeType == SbrpAttributeType)
        {
            var decodedValue = attr.DecodeValue(DummyAttributeTypeProvider.Instance);
            try
            {
                return decodedValue.FixedArguments[0].Value.ToString() == "source" && decodedValue.FixedArguments[1].Value.ToString() == "source-build-reference-packages";
            }
            catch
            {
                throw new InvalidOperationException($"{SbrpAttributeType} is not formatted properly with a key, value pair.");
            }
        }

        return false;
    }

    public async Task<bool> IsPackageSigned(string packagePath, PackageSignatureVerifier verifier, SignedPackageVerifierSettings settings)
    {
        using (var packageReader = new PackageArchiveReader(packagePath))
        {
            var result = await verifier.VerifySignaturesAsync(packageReader, settings, CancellationToken.None);
            return result.IsSigned;
        }
    }
}
