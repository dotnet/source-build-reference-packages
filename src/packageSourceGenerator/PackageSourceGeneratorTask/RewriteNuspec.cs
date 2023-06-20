// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using NuGet.Packaging;

namespace Microsoft.DotNet.SourceBuild.Tasks
{
    public partial class RewriteNuspec : Task
    {
        private const string MicrosoftMitLicenseUrl = "https://microsoft.mit-license.org/";

        [Required]
        public string? NuspecPath { get; set; }

        [Required]
        public string? TargetPath { get; set; }

        public string? IncludeTargetFrameworks { get; set; }

        public string? ExcludeTargetFrameworks { get; set; }

        public bool RemoveIcon { get; set; }

        public bool RemoveReadMe { get; set; }

        public bool RemoveRuntimeSpecificDependencies { get; set; }

        public override bool Execute()
        {
            string nuspecContent = File.ReadAllText(NuspecPath!);
            NuspecReader nuspecReader = new(NuspecPath!);
            TargetFrameworkRegexFilter targetFrameworkRegexFilter = new(IncludeTargetFrameworks,
                ExcludeTargetFrameworks);
            string pattern;

            IEnumerable<FrameworkSpecificGroup> frameworkAssemblyGroups = nuspecReader.GetFrameworkAssemblyGroups();
            foreach (FrameworkSpecificGroup frameworkSpecificGroup in frameworkAssemblyGroups)
            {
                string targetFramework = frameworkSpecificGroup.TargetFramework.GetShortFolderName();
                if (targetFrameworkRegexFilter.IsIncludedAndNotExcluded(targetFramework))
                    continue;

                string framework = frameworkSpecificGroup.TargetFramework.GetFrameworkString();
                pattern = $@" *<frameworkAssembly.*?targetFramework=""{framework}"" />\r?\n";
                nuspecContent = Regex.Replace(nuspecContent, pattern, string.Empty);
            }

            // If all frameworkAssemblyGroups have been removed, remove the empty frameworkAssemblies element
            pattern = @" *<frameworkAssemblies>\r?\n *</frameworkAssemblies>\r?\n";
            nuspecContent = Regex.Replace(nuspecContent, pattern, string.Empty);

            IEnumerable<PackageDependencyGroup> dependencyGroups = nuspecReader.GetDependencyGroups();
            foreach (PackageDependencyGroup dependencyGroup in dependencyGroups)
            {
                string targetFramework = dependencyGroup.TargetFramework.GetShortFolderName();
                if (targetFrameworkRegexFilter.IsIncludedAndNotExcluded(targetFramework))
                    continue;

                string framework = dependencyGroup.TargetFramework.GetFrameworkString();
                pattern = @$" *<group targetFramework=""{framework}""(?:>.+?</group>| />)\r?\n";
                nuspecContent = Regex.Replace(nuspecContent, pattern, string.Empty, RegexOptions.Singleline);
            }

            if (RemoveIcon)
            {
                nuspecContent = GetIconRegex().Replace(nuspecContent, string.Empty);
            }

            if (RemoveReadMe)
            {
                nuspecContent = GetReadMeRegex().Replace(nuspecContent, string.Empty);
            }

            if (RemoveRuntimeSpecificDependencies)
            {
                nuspecContent = GetRuntimeSpecificDependenciesRegex().Replace(nuspecContent, string.Empty);
            }

            // Ensure that the nuspec's line endings match the current environment
            nuspecContent = nuspecContent.ReplaceLineEndings();

            nuspecContent = nuspecContent.Replace("http://go.microsoft.com/fwlink/?LinkId=529443", MicrosoftMitLicenseUrl);
            nuspecContent = nuspecContent.Replace("http://go.microsoft.com/fwlink/?LinkId=329770", MicrosoftMitLicenseUrl);

            File.WriteAllText(TargetPath!, nuspecContent);
            return true;
        }

        [GeneratedRegex(" *<icon>.+</icon>\r?\n")]
        private static partial Regex GetIconRegex();

        [GeneratedRegex(" *<readme>.+</readme>\r?\n")]
        private static partial Regex GetReadMeRegex();

        [GeneratedRegex(@" *<dependency id=""runtime.native.+?"".+? />\r?\n")]
        private static partial Regex GetRuntimeSpecificDependenciesRegex();
    }
}
