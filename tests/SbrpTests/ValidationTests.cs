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

namespace SbrpTests;

public class ValidationTests
{
    private const string SbrpAttributeType = "System.Reflection.AssemblyMetadataAttribute";
    private const string VersionPattern = @"(\.\d)+([\-\w])*";
    private string[] Packages = Array.Empty<string>();
    public ITestOutputHelper Output { get; set; }

    public ValidationTests(ITestOutputHelper output) => Output = output;

    [SkippableFact]
    public async void ValidateSbrp()
    {
        Skip.If(RuntimeInformation.IsOSPlatform(OSPlatform.Windows), "This test is not supported on Windows.");
        
        InitializeValidationTests();

        CheckForSbrpAttribute();
        await CheckForSignatureAsync();
    }

    private void InitializeValidationTests()
    {
        Utilities.ValidateConfigParameters(new string[] { Config.RepoRootEnv, Config.BuildTypeEnv });
    
        string buildPackagesDirectory = Path.Combine(Config.RepoRoot, "artifacts/source-build/self/src/artifacts/packages", Config.BuildType, "Shipping");

        if (!Directory.Exists(buildPackagesDirectory))
        {
            throw new DirectoryNotFoundException($"Directory {buildPackagesDirectory} does not exist, try building with './build.sh -sb'.");
        }

        Packages = Directory.GetFiles(buildPackagesDirectory, "*.nupkg", SearchOption.AllDirectories);

        if (Packages.Length == 0)
        {
            throw new FileNotFoundException($"No packages found in {buildPackagesDirectory}");
        }
    }
    private void CheckForSbrpAttribute()
    {
        HashSet<string> targetAndTextOnlyPacks = new HashSet<string>(
            Directory.GetDirectories(Path.Combine(Config.RepoRoot, "src/targetPacks/ILsrc"))
                .Union(Directory.GetDirectories(Path.Combine(Config.RepoRoot, "src/textOnlyPackages/src")))
                .Select(x => Path.GetFileName(x).ToLower())
        );

        var filteredPackages = Packages
            .Where(package =>
            {
                string packageName = Path.GetFileNameWithoutExtension(package).ToLower();
                packageName = Regex.Replace(packageName, VersionPattern, string.Empty);
                return !targetAndTextOnlyPacks.Contains(packageName);
            });

        Output.WriteLine($"Checking {filteredPackages.Count()} packages for SBRP attribute.");

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

    private async Task CheckForSignatureAsync()
    {
        Skip.If(RuntimeInformation.IsOSPlatform(OSPlatform.Windows), "This test is not supported on Windows.");

        ISignatureVerificationProvider[] trustProviders = [new SignatureTrustAndValidityVerificationProvider()];
        var verifier = new PackageSignatureVerifier(trustProviders);
        var settings = SignedPackageVerifierSettings.GetDefault();

        Output.WriteLine($"Checking {Packages.Count()} packages for signatures.");

        foreach (var package in Packages)
        {
            bool isSigned = await IsPackageSignedAsync(package, verifier, settings);
            Assert.False(isSigned, $"{package} is signed. Signed packages are not allowed in source-build-reference-packages.");
        }
    }

    private bool HasSbrpAttribute(MetadataReader reader) =>
        reader.CustomAttributes
            .Select(attrHandle => reader.GetCustomAttribute(attrHandle))
            .Any(attr => IsAttributeSbrp(reader, attr));

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
                return decodedValue.FixedArguments[0].Value?.ToString() == "source" && decodedValue.FixedArguments[1].Value?.ToString() == "source-build-reference-packages";
            }
            catch
            {
                throw new InvalidOperationException($"{SbrpAttributeType} is not formatted properly with a key, value pair.");
            }
        }

        return false;
    }

    public async Task<bool> IsPackageSignedAsync(string packagePath, PackageSignatureVerifier verifier, SignedPackageVerifierSettings settings)
    {
        using var packageReader = new PackageArchiveReader(packagePath);
        var result = await verifier.VerifySignaturesAsync(packageReader, settings, CancellationToken.None);
        return result.IsSigned;
    }
}
