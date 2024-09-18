// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Microsoft.DotNet.SourceBuild.Tasks;

public class ParsePackagesCsv : Task
{
    /// <summary>
    /// The path to the CSV file to parse.
    /// </summary>
    [Required]
    public string? CsvPath { get; set; }

    /// <summary>
    /// The packages specified in the CSV file.
    /// </summary>
    [Output]
    public ITaskItem[]? PackageInfo { get; set; }

    /// <summary>
    /// The packages specified in the CSV file grouped by package name.
    /// </summary>
    [Output]
    public ITaskItem[]? GroupedPackageInfo { get; set; }

    public override bool Execute()
    {
        if (CsvPath is null)
        {
            Log.LogError("CsvPath is required.");
            return false;
        }

        if (!File.Exists(CsvPath))
        {
            Log.LogError($"CsvPath '{CsvPath}' does not exist.");
            return false;
        }

        string[] lines = File.ReadAllLines(CsvPath);
        if (lines.Length == 0)
        {
            Log.LogError($"CsvPath '{CsvPath}' is empty.");
            return false;
        }

        string[][] csvParts = lines.Select(line =>
            {
                string[] parts = line.Split(',');

                if (parts.Length != 2 && parts.Length != 3)
                {
                    Log.LogError($"CsvPath '{CsvPath}' contains an invalid line: '{line}'.");
                    return null;
                }

                return parts;
            })
            .Where(item => item is not null)
            .ToArray()!;

        PackageInfo = csvParts.Select(parts => new TaskItem(parts[0], new Dictionary<string, string>
            {
                { "PackageName", parts[0] },
                { "PackageVersion", parts[1] },
                { "TargetFrameworks", parts.Length == 3 ? parts[2] : string.Empty }
            }))
            .ToArray();

        GroupedPackageInfo = csvParts.GroupBy(parts => parts[0])
            .Select(group => new TaskItem(group.Key, new Dictionary<string, string>
                {
                    { "PackageName", group.Key },
                    { "PackageVersions", group.Select(parts => $"[{parts[1]}]").Aggregate((working, next) => $"{working};{next}") }
                }))
            .ToArray();

        return !Log.HasLoggedErrors;
    }
}
