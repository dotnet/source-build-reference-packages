// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Microsoft.DotNet.SourceBuild.Tasks
{
    public partial class AddSbrpAttribute : Task
    {

        [Required]
        public string[] CSharpPaths { get; set; }

        public override bool Execute()
        {
            foreach (string path in CSharpPaths)
            {
                if (AddSbrpAttributeToSpec(path))
                {
                    Log.LogMessage(MessageImportance.Low, $"Added SBRP attribute to {path}");
                }
            }
            return true;
        }

        private bool AddSbrpAttributeToSpec(string CSharpPath) {

            string specContent = File.ReadAllText(CSharpPath!);

            Match versionMatch = GetVersionRegex().Match(specContent);

            if (versionMatch.Success)
            {
                string version = versionMatch.Groups["version"].Value;

                if (!GetSbrpAttributeRegex().IsMatch(specContent))
                {
                    string sbrpAttribute = $"[assembly: System.Reflection.AssemblyInformationalVersion(\"{version} originated from source-build-reference-packages\")]";

                    specContent = GetVersionRegex().Replace(specContent, $"{versionMatch.Value}{Environment.NewLine}{sbrpAttribute}");

                    File.WriteAllText(CSharpPath!, specContent);

                    return true;
                }
            }
            return false;
        }

        [GeneratedRegex(@"\[assembly:\s+System\.Reflection\.AssemblyVersionAttribute\(""(?<version>[0-9.]+)""\)\]")]
        private static partial Regex GetVersionRegex();

        [GeneratedRegex(@"\[assembly:\s+System\.Reflection\.AssemblyInformationalVersion\(""(?<version>.+ originated from source-build-reference-packages)""\)\]")]
        private static partial Regex GetSbrpAttributeRegex();
    }
}
