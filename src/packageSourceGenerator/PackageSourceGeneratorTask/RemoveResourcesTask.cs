// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Microsoft.DotNet.SourceBuild.Tasks
{
    // Resources are binary files that we don't include in the src
    // for a target pack.  These files are not source and so cannot
    // be included.
    public class RemoveResources : Task
    {
        [Required]
        public ITaskItem[] ILFileNames { get; set; } = null!;

        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.High, "STARTING REMOVE RESOURCES");

            foreach (var ilFile in ILFileNames)
            {
                var lines = File.ReadAllLines(ilFile.ItemSpec);
                var outputLines = new List<string>();

                bool insideResource = false;
                foreach (var line in lines)
                {
                    if (line.StartsWith(".mresource") || line.Contains(" static pinvokeimpl"))
                    {
                        insideResource = true;
                    }
                    if (insideResource && line.Trim().StartsWith("}"))
                    {
                        insideResource = false;
                    }
                    else
                    {
                        if (!insideResource) outputLines.Add(line);
                    }
                }
                File.WriteAllLines(ilFile.ItemSpec, outputLines);
            }

            return true;
        }
    }
}
