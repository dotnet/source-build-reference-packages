// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AllowPartiallyTrustedCallers]
[assembly: ReferenceAssembly]
[assembly: AssemblyTitle("NuGet.Build.Tasks")]
[assembly: AssemblyDescription("NuGet.Build.Tasks")]
[assembly: AssemblyDefaultAlias("NuGet.Build.Tasks")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("5.1.0.6013")]
[assembly: AssemblyInformationalVersion("5.1.0.6013 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("5.1.0.5")]




namespace NuGet.Build
{
    public partial class MSBuildTaskItem : NuGet.Commands.IMSBuildItem
    {
        public MSBuildTaskItem(Microsoft.Build.Framework.ITaskItem item) { }
        public string Identity { get { throw null; } }
        public Microsoft.Build.Framework.ITaskItem Item { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Properties { get { throw null; } }
        public System.Collections.IDictionary CloneCustomMetadata() { throw null; }
        public string GetProperty(string property) { throw null; }
        public string GetProperty(string property, bool trim) { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace NuGet.Build.Tasks
{
    public static partial class BuildTasksUtility
    {
        public static void AddAllProjectsForRestore(NuGet.ProjectModel.DependencyGraphSpec spec) { }
        public static void AddPropertyIfExists(System.Collections.Generic.IDictionary<string, string> properties, string key, string value) { }
        public static void AddPropertyIfExists(System.Collections.Generic.IDictionary<string, string> properties, string key, string[] value) { }
        public static void CopyPropertyIfExists(Microsoft.Build.Framework.ITaskItem item, System.Collections.Generic.IDictionary<string, string> properties, string key) { }
        public static void CopyPropertyIfExists(Microsoft.Build.Framework.ITaskItem item, System.Collections.Generic.IDictionary<string, string> properties, string key, string toKey) { }
        public static string GetPropertyIfExists(Microsoft.Build.Framework.ITaskItem item, string key) { throw null; }
        public static void LogInputParam(NuGet.Common.ILogger log, string name, params string[] values) { }
        public static void LogOutputParam(NuGet.Common.ILogger log, string name, params string[] values) { }
    }
    public partial class GetProjectTargetFrameworksTask : Microsoft.Build.Utilities.Task
    {
        public GetProjectTargetFrameworksTask() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string ProjectPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string ProjectTargetFrameworks { get { throw null; } set { } }
        public string TargetFramework { get { throw null; } set { } }
        public string TargetFrameworkMoniker { get { throw null; } set { } }
        public string TargetFrameworks { get { throw null; } set { } }
        public string TargetPlatformIdentifier { get { throw null; } set { } }
        public string TargetPlatformMinVersion { get { throw null; } set { } }
        public string TargetPlatformVersion { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetReferenceNearestTargetFrameworkTask : Microsoft.Build.Utilities.Task
    {
        public GetReferenceNearestTargetFrameworkTask() { }
        public Microsoft.Build.Framework.ITaskItem[] AnnotatedProjectReferences { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AssignedProjects { get { throw null; } set { } }
        public string CurrentProjectName { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string CurrentProjectTargetFramework { get { throw null; } set { } }
        public string[] FallbackTargetFrameworks { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetRestoreDotnetCliToolsTask : Microsoft.Build.Utilities.Task
    {
        public GetRestoreDotnetCliToolsTask() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] DotnetCliToolReferences { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string ProjectPath { get { throw null; } set { } }
        public string[] RestoreConfigFilePaths { get { throw null; } set { } }
        public string[] RestoreFallbackFolders { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] RestoreGraphItems { get { throw null; } set { } }
        public string RestorePackagesPath { get { throw null; } set { } }
        public string[] RestoreSources { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string ToolFramework { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetRestoreFrameworkReferencesTask : Microsoft.Build.Utilities.Task
    {
        public GetRestoreFrameworkReferencesTask() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] FrameworkReferences { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string ProjectUniqueName { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] RestoreGraphItems { get { throw null; } set { } }
        public string TargetFrameworks { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetRestorePackageDownloadsTask : Microsoft.Build.Utilities.Task
    {
        public GetRestorePackageDownloadsTask() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] PackageDownloads { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string ProjectUniqueName { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] RestoreGraphItems { get { throw null; } set { } }
        public string TargetFrameworks { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetRestorePackageReferencesTask : Microsoft.Build.Utilities.Task
    {
        public GetRestorePackageReferencesTask() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] PackageReferences { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string ProjectUniqueName { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] RestoreGraphItems { get { throw null; } set { } }
        public string TargetFrameworks { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetRestoreProjectJsonPathTask : Microsoft.Build.Utilities.Task
    {
        public GetRestoreProjectJsonPathTask() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public string ProjectJsonPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string ProjectPath { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetRestoreProjectReferencesTask : Microsoft.Build.Utilities.Task
    {
        public GetRestoreProjectReferencesTask() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string ParentProjectPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ProjectReferences { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string ProjectUniqueName { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] RestoreGraphItems { get { throw null; } set { } }
        public string TargetFrameworks { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetRestoreSettingsTask : Microsoft.Build.Utilities.Task
    {
        public GetRestoreSettingsTask() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string MSBuildStartupDirectory { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string[] OutputConfigFilePaths { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string[] OutputFallbackFolders { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string OutputPackagesPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string[] OutputSources { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string ProjectUniqueName { get { throw null; } set { } }
        public string RestoreConfigFile { get { throw null; } set { } }
        public string[] RestoreFallbackFolders { get { throw null; } set { } }
        public string[] RestoreFallbackFoldersOverride { get { throw null; } set { } }
        public string RestorePackagesPath { get { throw null; } set { } }
        public string RestorePackagesPathOverride { get { throw null; } set { } }
        public string RestoreRootConfigDirectory { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] RestoreSettingsPerFramework { get { throw null; } set { } }
        public string RestoreSolutionDirectory { get { throw null; } set { } }
        public string[] RestoreSources { get { throw null; } set { } }
        public string[] RestoreSourcesOverride { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetRestoreSolutionProjectsTask : Microsoft.Build.Utilities.Task
    {
        public GetRestoreSolutionProjectsTask() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] OutputProjectReferences { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ProjectReferences { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string SolutionFilePath { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class RestoreSettingsUtils
    {
        public static readonly string Clear;
        public RestoreSettingsUtils() { }
        public static T GetValue<T>(params System.Func<T>[] funcs) { throw null; }
        public static NuGet.Configuration.ISettings ReadSettings(string solutionDirectory, string restoreDirectory, string restoreConfigFile, System.Lazy<NuGet.Configuration.IMachineWideSettings> machineWideSettings) { throw null; }
    }
    public partial class RestoreTask : Microsoft.Build.Utilities.Task, Microsoft.Build.Framework.ICancelableTask, Microsoft.Build.Framework.ITask, System.IDisposable
    {
        public RestoreTask() { }
        public bool HideWarningsAndErrors { get { throw null; } set { } }
        public bool Interactive { get { throw null; } set { } }
        public bool RestoreDisableParallel { get { throw null; } set { } }
        public bool RestoreForce { get { throw null; } set { } }
        public bool RestoreForceEvaluate { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] RestoreGraphItems { get { throw null; } set { } }
        public bool RestoreIgnoreFailedSources { get { throw null; } set { } }
        public bool RestoreNoCache { get { throw null; } set { } }
        public bool RestoreRecursive { get { throw null; } set { } }
        public void Cancel() { }
        public void Dispose() { }
        public override bool Execute() { throw null; }
    }
    public partial class WarnForInvalidProjectsTask : Microsoft.Build.Utilities.Task
    {
        public WarnForInvalidProjectsTask() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AllProjects { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ValidProjects { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class WriteRestoreGraphTask : Microsoft.Build.Utilities.Task
    {
        public WriteRestoreGraphTask() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] RestoreGraphItems { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string RestoreGraphOutputPath { get { throw null; } set { } }
        public bool RestoreRecursive { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
}
