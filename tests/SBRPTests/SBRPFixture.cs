using System;

namespace SBRPTests;

public class SBRPFixture
{
    public string WorkingDirectory { get; set; }

    public SBRPFixture()
    {
        WorkingDirectory = Environment.CurrentDirectory = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("source-build-reference-packages") + 31);
        CommandHelper.CommandOutput("git", "reset HEAD", WorkingDirectory);
        CommandHelper.CommandOutput("git", "checkout src/", WorkingDirectory);
        CommandHelper.CommandOutput("git", "clean -fd src/", WorkingDirectory);
    }
}
