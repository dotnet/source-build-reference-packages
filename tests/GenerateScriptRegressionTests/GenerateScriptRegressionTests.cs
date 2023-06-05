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
        new object[] { "Microsoft.CodeAnalysis.CSharp.Workspaces,4.5.0", PackageType.Reference },
        new object[] { "System.Threading.Tasks.Extensions,4.5.4", PackageType.Reference },
        new object[] { "System.Diagnostics.DiagnosticSource,7.0.2", PackageType.Reference },
        new object[] { "Microsoft.CodeAnalysis,4.5.0", PackageType.Text },
     };
}

public enum PackageType
{
    Reference,
    Text
}

public class GenerateScriptRegressionTests : IClassFixture<GenerateScriptRegressionTestsFixture>, IDisposable
{
    public ITestOutputHelper output { get; set; }
    public string WorkingDirectory { get; set; }
    public GenerateScriptRegressionTests(GenerateScriptRegressionTestsFixture fixture, ITestOutputHelper output)
    {
        WorkingDirectory = fixture.WorkingDirectory;
        this.output = output;
    }

    [Theory]    
    [MemberData(nameof(PackageData.Data), MemberType = typeof(PackageData))]
    public void VerifyGenerateScript(string package, PackageType type)
    {
        string command = Path.Combine(WorkingDirectory,RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "generate.cmd" : "generate.sh");
        string arguments = string.Format("-p {0} -x",package);
        switch (type)
        {
            case PackageType.Reference:
                break;
            case PackageType.Text:
                arguments += " -t text";
                break;
        }
        ExecuteHelper.ExecuteProcess(command, arguments, output, WorkingDirectory);
        ExecuteHelper.ExecuteProcess("git", "add .", output, WorkingDirectory);
        Assert.DoesNotContain("modified:   src/", ExecuteHelper.ExecuteProcess("git", "status", output, WorkingDirectory).StdOut);
    }

    public void Dispose()
    {
        ExecuteHelper.ExecuteProcess("git", "reset HEAD", output, WorkingDirectory);
        ExecuteHelper.ExecuteProcess("git", "checkout src/", output, WorkingDirectory);
        ExecuteHelper.ExecuteProcess("git", "clean -fd src/", output, WorkingDirectory);
    }
}
