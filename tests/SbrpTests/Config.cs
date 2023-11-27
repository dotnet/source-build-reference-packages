// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;

namespace SbrpTests;

internal static class Config
{
    public const string RepoRootEnv = "SBRP_TESTS_REPO_ROOT";
    public const string BuildTypeEnv = "SBRP_TESTS_BUILD_TYPE";

    public static string RepoRoot
    {
        get
        {
            string repoRoot = Environment.GetEnvironmentVariable(RepoRootEnv) ??
                Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("artifacts"));
            if (string.IsNullOrWhiteSpace(repoRoot))
            {
                throw new InvalidOperationException($"Environment variable {RepoRootEnv} cannot be null, empty, or whitespace.");
            }
            return repoRoot;
        }
    }

    public static string BuildType { get; } = Environment.GetEnvironmentVariable(BuildTypeEnv) ??
        "Release";
}
