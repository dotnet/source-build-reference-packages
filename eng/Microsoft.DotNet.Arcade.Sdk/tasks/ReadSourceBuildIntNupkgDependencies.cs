// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Microsoft.DotNet.Build.Tasks
{
    public class ReadSourceBuildIntNupkgDependencies : Task
    {
        [Required]
        public string VersionDetailsXmlFile { get; set; }

        [Output]
        public ITaskItem[] Dependencies { get; set; }

        public override bool Execute()
        {
            var root = XElement.Load(VersionDetailsXmlFile, LoadOptions.PreserveWhitespace);
            XName qualifiedName(string plainName) => root.GetDefaultNamespace().GetName(plainName);

            var sourceBuildDependencies = root
                .Elements()
                .Elements(qualifiedName("Dependency"))
                .Where(d => d.Element(qualifiedName("SourceBuildRepoName")) != null)
                .ToArray();

            foreach (var d in sourceBuildDependencies)
            {
                if (d.Attribute("Name") == null)
                {
                    Log.LogError($"{d} has no Name");
                }
                if (d.Attribute("Version") == null)
                {
                    Log.LogError($"{d} has no Version");
                }
            }

            Dependencies = sourceBuildDependencies
                .Select(d => new TaskItem(
                    d.Attribute("Name").Value,
                    new Dictionary<string, string>()
                    {
                        ["Version"] = d.Attribute("Version").Value
                    }))
                .ToArray();

            return !Log.HasLoggedErrors;
        }
    }
}
