using System;
using System.Runtime.InteropServices;
using Xunit;

namespace SBRPTests;

public class ReferencePackagesTest : IClassFixture<SBRPFixture>, IDisposable
{

    public string WorkingDirectory { get; set; }
    public ReferencePackagesTest(SBRPFixture fixture)
    {
        WorkingDirectory = fixture.WorkingDirectory;
    }

    [Theory(Timeout = 300000)]    
    [MemberData(nameof(PackageData.Data), MemberType = typeof(PackageData))]
    public void VerifySBRP(string package, PackageType type)
    {
        switch (type)
        {
            case PackageType.Reference:
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    CommandHelper.CommandOutput("generate.cmd", string.Format("-package {0} -excludedependencies", package), WorkingDirectory);
                }
                else
                {
                    CommandHelper.CommandOutput("generate.sh", string.Format("--package {0} --excludedependencies", package), WorkingDirectory);
                }

                CommandHelper.CommandOutput("git", "add .", WorkingDirectory);
                Assert.DoesNotContain("modified:   src/", CommandHelper.CommandOutput("git", "status", WorkingDirectory));
                break;
            case PackageType.Text:
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    CommandHelper.CommandOutput("generate.cmd", string.Format("-type text -package {0} -excludedependencies", package), WorkingDirectory);
                }
                else
                {
                    CommandHelper.CommandOutput("generate.sh", string.Format("--type text --package {0} --excludedependencies", package), WorkingDirectory);
                }

                CommandHelper.CommandOutput("git", "add .", WorkingDirectory);
                Assert.DoesNotContain("modified:   src/", CommandHelper.CommandOutput("git", "status", WorkingDirectory));
                break;
        }
    }

    public void Dispose()
    {
        CommandHelper.CommandOutput("git", "reset HEAD", WorkingDirectory);
        CommandHelper.CommandOutput("git", "checkout src/", WorkingDirectory);
        CommandHelper.CommandOutput("git", "clean -fd src/", WorkingDirectory);
    }
}
