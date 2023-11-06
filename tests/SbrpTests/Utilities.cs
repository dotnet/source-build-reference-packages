// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;

namespace SbrpTests;

public static class Utilities
{
    public static void ValidateConfigParameters(string[] configParameters)
    {
        foreach (string parameter in configParameters)
        {
            switch (parameter)
            {
                case Config.RepoRootEnv:
                    if (string.IsNullOrEmpty(Config.RepoRoot))
                    {
                        throw new InvalidOperationException($"Environment variable '{Config.RepoRootEnv}' must be set to the root of the source-build-reference-packages repo.");
                    }
                    else if (!Directory.Exists(Config.RepoRoot))
                    {
                        throw new InvalidOperationException($"Environment variable '{Config.RepoRootEnv}' does not exist.");
                    }
                    break;
                case Config.BuildTypeEnv:
                    if (string.IsNullOrEmpty(Config.BuildType) || (Config.BuildType != "Debug" && Config.BuildType != "Release"))
                    {
                        throw new InvalidOperationException($"Environment variable '{Config.BuildTypeEnv}' must be set to either 'Debug' or 'Release'.");
                    }
                    break;
                default:
                    throw new InvalidOperationException($"Unknown environment variable '{parameter}'.");
            }
        }
    }
}