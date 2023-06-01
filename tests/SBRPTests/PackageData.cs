using System.Collections.Generic;

namespace SBRPTests;

public class PackageData
{
    public static IEnumerable<object[]> Data => new List<object[]>
    {
        new object[] { "Microsoft.CodeAnalysis.CSharp.Workspaces,4.5.0", PackageType.Reference },
        new object[] { "System/Threading.Tasks.Extensions,4.5.4", PackageType.Reference },
        new object[] { "System.Diagnostics.DiagnosticSource,7.0.2", PackageType.Reference },
        new object[] { "Microsoft.CodeAnalysis,4.5.0", PackageType.Text },
     };
}

public enum PackageType
{
    Reference,
    Text
}