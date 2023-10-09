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
    public partial class AddAttributes : Task
    {

        [Required]
        // The paths to the C# files to add the attributes to
        public string[] CSharpPaths { get; set; }

        [Required]
        // The attributes to add
        public string[] Attributes { get; set; }

        public override bool Execute()
        {
            foreach (string path in CSharpPaths)
            {
                if (AddAttributesToFile(path))
                {
                    Log.LogMessage(MessageImportance.Low, $"Added attributes to {path}");
                }
                else
                {
                    Log.LogMessage(MessageImportance.Low, $"Attributes already exist in {path}");
                }
            }
            return true;
        }

        private bool AddAttributesToFile(string CSharpPath) {

            string fileContent = File.ReadAllText(CSharpPath!);

            string[] attributesNotInFile = Attributes
                .Where(attribute => !fileContent.Contains(attribute))
                .ToArray();

            string attributesToAppend = string.Join(Environment.NewLine, attributesNotInFile);
            string replacement = "]" + Environment.NewLine + attributesToAppend + Environment.NewLine + "namespace";

            Log.LogMessage(MessageImportance.Low, $"Adding newline {replacement} to {CSharpPath}");

            string modifiedContent = GetEndOfAttributesRegex().Replace(fileContent, replacement);

            File.WriteAllText(CSharpPath, modifiedContent);

            if (attributesNotInFile.Length < Attributes.Length)
            {
                return false;
            }
            return true;
        }

        [GeneratedRegex(@"\]\nnamespace")]
        private static partial Regex GetEndOfAttributesRegex();
    }
}
