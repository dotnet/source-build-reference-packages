using System;
using Xunit.Abstractions;

namespace GenerateScriptRegressionTests;

public class GenerateScriptRegressionTestsFixture
{
    public string WorkingDirectory { get; set; }

    public GenerateScriptRegressionTestsFixture()
    {
        WorkingDirectory = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("source-build-reference-packages") + 31);
    }
}
