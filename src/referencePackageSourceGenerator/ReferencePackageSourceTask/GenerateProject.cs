// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Microsoft.DotNet.SourceBuild.Tasks
{
    public class GenerateProject : Task
    {
        [Required]
        public string PackageId { get; set; }

        [Required]
        public string[] TargetFrameworks { get; set; }

        [Required]
        public ITaskItem[] CompileItems { get; set; }

        [Required]
        public ITaskItem[] PackageDependencies { get; set; }

        [Required]
        public ITaskItem[] FrameworkReferences { get; set; }

        [Required]
        public string BaseTargetPath { get; set; }

        [Required]
        public string TargetPath { get; set; }

        [Required]
        public string ProjectTemplate { get; set; }

        public override bool Execute()
        {
            string projectTemplateContent = File.ReadAllText(ProjectTemplate);
            string pkgProjectOutput = projectTemplateContent;
            string packageReferenceIncludes = "\n";
            string tfmSpecificProperties = "\n";

            // Make sure that we always use the same directory separator.
            string relativePath = Path.GetRelativePath(BaseTargetPath, Path.GetDirectoryName(TargetPath)).Replace('\\', '/');
            StrongNameData strongNameData = default;
            string[] orderedTargetFrameworks = TargetFrameworks.Order().ToArray();

            foreach (string targetFramework in orderedTargetFrameworks)
            {
                string packageReferences = "";

                // Add package dependencies
                foreach (ITaskItem packageDependency in PackageDependencies.Where(packageDependency => packageDependency.GetMetadata("TargetFramework") == targetFramework))
                {
                    // Don't emit package references for targeting packs as those are added implicitly by the SDK.
                    if (packageDependency.ItemSpec == "NETStandard.Library")
                        continue;

                    packageReferences += $"    <PackageReference Include=\"{packageDependency.ItemSpec}\" Version=\"{packageDependency.GetMetadata("Version")}\" />\n";
                }

                // Add framework references
                foreach (ITaskItem frameworkReference in FrameworkReferences.Where(frameworkReference => frameworkReference.GetMetadata("TargetFramework") == targetFramework))
                {
                    if (frameworkReference.ItemSpec != "mscorlib")
                    {
                        packageReferences += $"    <Reference Include=\"{frameworkReference.ItemSpec}\" />\n";
                    }
                }

                // Write the gathered package references into the project file.
                if (packageReferences != "")
                {
                    packageReferenceIncludes += $"  <ItemGroup Condition=\" '$(TargetFramework)' == '{targetFramework}' \">\n";
                    packageReferenceIncludes += packageReferences;
                    packageReferenceIncludes += $"  </ItemGroup>\n\n";
                }

                // Retrieve the target framework's sub path and strong name data. For historical reasons,
                // we just use the first item that has the data available.
                string subPath = null;
                ITaskItem[] compileItems = CompileItems.Where(compileItem => compileItem.GetMetadata("TargetFramework") == targetFramework).ToArray();
                foreach (ITaskItem compileItem in compileItems)
                {
                    if (strongNameData == default)
                    {
                        string strongNameKey = compileItem.GetMetadata(SharedMetadata.StrongNameKeyMetadataName);
                        string strongNameId = compileItem.GetMetadata(SharedMetadata.StrongNameIdMetadataName);
                        string strongNameFilename = compileItem.GetMetadata(SharedMetadata.StrongNameFilenameMetadataName);

                        if (!string.IsNullOrWhiteSpace(strongNameKey) &&
                            !string.IsNullOrWhiteSpace(strongNameId) &&
                            !string.IsNullOrWhiteSpace(strongNameFilename))
                        {
                            strongNameData = new(strongNameKey, strongNameId, strongNameFilename);
                        }
                    }

                    if (subPath is null)
                    {
                        string relativeCompileItemPath = compileItem.ItemSpec;
                        string[] splitParts = relativeCompileItemPath.Split('/');
                        if (splitParts.Length < 3)
                        {
                            Log.LogWarning("Path '{0}' does not have expected depth", relativeCompileItemPath);
                            continue;
                        }

                        subPath = splitParts[0];
                    }
                }

                tfmSpecificProperties += $"  <PropertyGroup Condition=\" '$(TargetFramework)' == '{targetFramework}' \">\n";
                if (subPath == "lib")
                {
                    tfmSpecificProperties += $"    <OutputPath>$(ArtifactsBinDir){relativePath}/{subPath}/</OutputPath>\n";
                }
                tfmSpecificProperties += $"  </PropertyGroup>\n\n";
            }

            // If necessary, write the strong name key into the project file.
            string keyFileTag = "";
            // Don't generate StrongNameKeyId for MSFT key
            if (strongNameData != default && strongNameData.Filename != "MSFT")
            {
                keyFileTag = $"\n    <StrongNameKeyId>{strongNameData.Id}</StrongNameKeyId>";
            }

            pkgProjectOutput = pkgProjectOutput.Replace("$$LowerCaseFileName$$", PackageId.ToLowerInvariant());
            pkgProjectOutput = pkgProjectOutput.Replace("$$TfmSpecificProperties$$", tfmSpecificProperties);
            pkgProjectOutput = pkgProjectOutput.Replace("$$RelativePath$$", relativePath);
            pkgProjectOutput = pkgProjectOutput.Replace("$$PackageReferences$$", packageReferenceIncludes);
            pkgProjectOutput = pkgProjectOutput.Replace("$$TargetFrameworks$$", string.Join(';', orderedTargetFrameworks));
            pkgProjectOutput = pkgProjectOutput.Replace("$$KeyFileTag$$", keyFileTag);

            // Generate the project file
            Directory.CreateDirectory(Path.GetDirectoryName(TargetPath));
            File.WriteAllText(TargetPath, pkgProjectOutput);

            return true;
        }
    }
}
