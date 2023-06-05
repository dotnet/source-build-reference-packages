using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Xunit;
using Xunit.Abstractions;

namespace GenerateScriptRegressionTests;

public class PackageData
{
    public static IEnumerable<object[]> Data => new List<object[]>
    {
        new object[] { "Microsoft.CodeAnalysis.CSharp.Workspaces", "4.5.0", PackageType.Reference },
        new object[] { "System.Threading.Tasks.Extensions", "4.5.4", PackageType.Reference },
        new object[] { "System.Diagnostics.DiagnosticSource", "7.0.2", PackageType.Reference },
        new object[] { "Microsoft.CodeAnalysis", "4.5.0", PackageType.Text },
     };
}

public enum PackageType
{
    Reference,
    Text
}

public class GenerateScriptRegressionTests : IClassFixture<GenerateScriptRegressionTestsFixture>, IDisposable
{
    private string sandbox_folder = Path.Combine(Environment.CurrentDirectory,"sandbox_folder");
    public ITestOutputHelper output { get; set; }
    public string WorkingDirectory { get; set; }
    public GenerateScriptRegressionTests(GenerateScriptRegressionTestsFixture fixture, ITestOutputHelper output)
    {
        WorkingDirectory = fixture.WorkingDirectory;        
        ExecuteHelper.ExecuteProcess("mkdir", "sandbox_folder", output);
        this.output = output;
    }

    [Theory]    
    [MemberData(nameof(PackageData.Data), MemberType = typeof(PackageData))]
    public void VerifyGenerateScript(string package, string version, PackageType type)
    {
        string command = Path.Combine(WorkingDirectory, RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "generate.cmd" : "generate.sh");
        string arguments = string.Format("-p {0} -x -d {1}",string.Format("{0},{1}", package, version), sandbox_folder);
        string packageSrcFolder = Path.Combine(WorkingDirectory, "src");
        switch (type)
        {
            case PackageType.Reference:
                packageSrcFolder = Path.Combine(packageSrcFolder, "referencePackages", "src");
                break;
            case PackageType.Text:
                arguments += " -t text";
                packageSrcFolder = Path.Combine(packageSrcFolder, "textOnlyPackages", "src");
                break;
        }
        packageSrcFolder = Path.Combine(packageSrcFolder, package.ToLower(), version);
        ExecuteHelper.ExecuteProcess(command, arguments, output);
        Assert.True(CompareDirs.Compare(packageSrcFolder, sandbox_folder, output), string.Format("{0},{1} failed in the test!", package, version));        
    }

    public void Dispose()
    {
        ExecuteHelper.ExecuteProcess("rm", "-r sandbox_folder", output);
    }
}
