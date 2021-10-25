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
[assembly: AssemblyTitle("Microsoft.Build.Tasks.Core")]
[assembly: AssemblyDescription("Microsoft.Build.Tasks.Core")]
[assembly: AssemblyDefaultAlias("Microsoft.Build.Tasks.Core")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("16.5.0.12403")]
[assembly: AssemblyInformationalVersion("16.5.0.12403 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("15.1.0.0")]




namespace Microsoft.Build.Tasks
{
    public partial class AL : Microsoft.Build.Tasks.ToolTaskExtension
    {
        public AL() { }
        public string AlgorithmId { get { throw null; } set { } }
        public string BaseAddress { get { throw null; } set { } }
        public string CompanyName { get { throw null; } set { } }
        public string Configuration { get { throw null; } set { } }
        public string Copyright { get { throw null; } set { } }
        public string Culture { get { throw null; } set { } }
        public bool DelaySign { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] EmbedResources { get { throw null; } set { } }
        public string EvidenceFile { get { throw null; } set { } }
        public string FileVersion { get { throw null; } set { } }
        public string Flags { get { throw null; } set { } }
        public bool GenerateFullPaths { get { throw null; } set { } }
        public string KeyContainer { get { throw null; } set { } }
        public string KeyFile { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] LinkResources { get { throw null; } set { } }
        public string MainEntryPoint { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputAssembly { get { throw null; } set { } }
        public string Platform { get { throw null; } set { } }
        public bool Prefer32Bit { get { throw null; } set { } }
        public string ProductName { get { throw null; } set { } }
        public string ProductVersion { get { throw null; } set { } }
        public string[] ResponseFiles { get { throw null; } set { } }
        public string SdkToolsPath { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] SourceModules { get { throw null; } set { } }
        public string TargetType { get { throw null; } set { } }
        public string TemplateFile { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        protected override string ToolName { get { throw null; } }
        public string Trademark { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        public string Win32Icon { get { throw null; } set { } }
        public string Win32Resource { get { throw null; } set { } }
        protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        public override bool Execute() { throw null; }
        protected override string GenerateFullPathToTool() { throw null; }
    }
    [Microsoft.Build.Framework.LoadInSeparateAppDomainAttribute]
    public abstract partial class AppDomainIsolatedTaskExtension : Microsoft.Build.Utilities.AppDomainIsolatedTask
    {
        internal AppDomainIsolatedTaskExtension() { }
        public Microsoft.Build.Utilities.TaskLoggingHelper Log { get { throw null; } }
    }
    public partial class AspNetCompiler : Microsoft.Build.Tasks.ToolTaskExtension
    {
        public AspNetCompiler() { }
        public bool AllowPartiallyTrustedCallers { get { throw null; } set { } }
        public bool Clean { get { throw null; } set { } }
        public bool Debug { get { throw null; } set { } }
        public bool DelaySign { get { throw null; } set { } }
        public bool FixedNames { get { throw null; } set { } }
        public bool Force { get { throw null; } set { } }
        public string KeyContainer { get { throw null; } set { } }
        public string KeyFile { get { throw null; } set { } }
        public string MetabasePath { get { throw null; } set { } }
        public string PhysicalPath { get { throw null; } set { } }
        public string TargetFrameworkMoniker { get { throw null; } set { } }
        public string TargetPath { get { throw null; } set { } }
        protected override string ToolName { get { throw null; } }
        public bool Updateable { get { throw null; } set { } }
        public string VirtualPath { get { throw null; } set { } }
        protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        public override bool Execute() { throw null; }
        protected override string GenerateFullPathToTool() { throw null; }
        protected override bool ValidateParameters() { throw null; }
    }
    public partial class AssignCulture : Microsoft.Build.Tasks.TaskExtension
    {
        public AssignCulture() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AssignedFiles { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AssignedFilesWithCulture { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AssignedFilesWithNoCulture { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] CultureNeutralAssignedFiles { get { throw null; } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class AssignLinkMetadata : Microsoft.Build.Tasks.TaskExtension
    {
        public AssignLinkMetadata() { }
        public Microsoft.Build.Framework.ITaskItem[] Items { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] OutputItems { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class AssignProjectConfiguration : Microsoft.Build.Tasks.ResolveProjectBase
    {
        public AssignProjectConfiguration() { }
        public bool AddSyntheticProjectReferencesForSolutionDependencies { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AssignedProjects { get { throw null; } set { } }
        public string CurrentProject { get { throw null; } set { } }
        public string CurrentProjectConfiguration { get { throw null; } set { } }
        public string CurrentProjectPlatform { get { throw null; } set { } }
        public string DefaultToVcxPlatformMapping { get { throw null; } set { } }
        public bool OnlyReferenceAndBuildProjectsEnabledInSolutionConfiguration { get { throw null; } set { } }
        public string OutputType { get { throw null; } set { } }
        public bool ResolveConfigurationPlatformUsingMappings { get { throw null; } set { } }
        public bool ShouldUnsetParentConfigurationAndPlatform { get { throw null; } set { } }
        public string SolutionConfigurationContents { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] UnassignedProjects { get { throw null; } set { } }
        public string VcxToDefaultPlatformMapping { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class AssignTargetPath : Microsoft.Build.Tasks.TaskExtension
    {
        public AssignTargetPath() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AssignedFiles { get { throw null; } }
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string RootFolder { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    [Microsoft.Build.Framework.RunInMTAAttribute]
    public partial class CallTarget : Microsoft.Build.Tasks.TaskExtension
    {
        public CallTarget() { }
        public bool RunEachTargetSeparately { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] TargetOutputs { get { throw null; } }
        public string[] Targets { get { throw null; } set { } }
        public bool UseResultsCache { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class CodeTaskFactory : Microsoft.Build.Framework.ITaskFactory
    {
        public CodeTaskFactory() { }
        public string FactoryName { get { throw null; } }
        public System.Type TaskType { get { throw null; } }
        public void CleanupTask(Microsoft.Build.Framework.ITask task) { }
        public Microsoft.Build.Framework.ITask CreateTask(Microsoft.Build.Framework.IBuildEngine loggingHost) { throw null; }
        public Microsoft.Build.Framework.TaskPropertyInfo[] GetTaskParameters() { throw null; }
        public bool Initialize(string taskName, System.Collections.Generic.IDictionary<string, Microsoft.Build.Framework.TaskPropertyInfo> taskParameters, string taskElementContents, Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost) { throw null; }
    }
    public partial class CombinePath : Microsoft.Build.Tasks.TaskExtension
    {
        public CombinePath() { }
        public string BasePath { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] CombinedPaths { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Paths { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class CommandLineBuilderExtension : Microsoft.Build.Utilities.CommandLineBuilder
    {
        public CommandLineBuilderExtension() { }
        public CommandLineBuilderExtension(bool quoteHyphensOnCommandLine, bool useNewLineSeparator) { }
        protected string GetQuotedText(string unquotedText) { throw null; }
    }
    public partial class ConvertToAbsolutePath : Microsoft.Build.Tasks.TaskExtension
    {
        public ConvertToAbsolutePath() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AbsolutePaths { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Paths { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class Copy : Microsoft.Build.Tasks.TaskExtension, Microsoft.Build.Framework.ICancelableTask, Microsoft.Build.Framework.ITask
    {
        public Copy() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] CopiedFiles { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] DestinationFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem DestinationFolder { get { throw null; } set { } }
        public bool ErrorIfLinkFails { get { throw null; } set { } }
        public bool OverwriteReadOnlyFiles { get { throw null; } set { } }
        public int Retries { get { throw null; } set { } }
        public int RetryDelayMilliseconds { get { throw null; } set { } }
        public bool SkipUnchangedFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SourceFiles { get { throw null; } set { } }
        public bool UseHardlinksIfPossible { get { throw null; } set { } }
        public bool UseSymboliclinksIfPossible { get { throw null; } set { } }
        public void Cancel() { }
        public override bool Execute() { throw null; }
    }
    public partial class CreateCSharpManifestResourceName : Microsoft.Build.Tasks.CreateManifestResourceName
    {
        public CreateCSharpManifestResourceName() { }
        protected override string SourceFileExtension { get { throw null; } }
        protected override string CreateManifestName(string fileName, string linkFileName, string rootNamespace, string dependentUponFileName, System.IO.Stream binaryStream) { throw null; }
        protected override bool IsSourceFile(string fileName) { throw null; }
    }
    public partial class CreateItem : Microsoft.Build.Tasks.TaskExtension
    {
        public CreateItem() { }
        public string[] AdditionalMetadata { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Exclude { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Include { get { throw null; } set { } }
        public bool PreserveExistingMetadata { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public abstract partial class CreateManifestResourceName : Microsoft.Build.Tasks.TaskExtension
    {
        protected System.Collections.Generic.Dictionary<string, Microsoft.Build.Framework.ITaskItem> itemSpecToTaskitem;
        protected CreateManifestResourceName() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ManifestResourceNames { get { throw null; } }
        public bool PrependCultureAsDirectory { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ResourceFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ResourceFilesWithManifestResourceNames { get { throw null; } set { } }
        public string RootNamespace { get { throw null; } set { } }
        protected abstract string SourceFileExtension { get; }
        public bool UseDependentUponConvention { get { throw null; } set { } }
        protected abstract string CreateManifestName(string fileName, string linkFileName, string rootNamespaceName, string dependentUponFileName, System.IO.Stream binaryStream);
        public override bool Execute() { throw null; }
        protected abstract bool IsSourceFile(string fileName);
        public static string MakeValidEverettIdentifier(string name) { throw null; }
    }
    public partial class CreateProperty : Microsoft.Build.Tasks.TaskExtension
    {
        public CreateProperty() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public string[] Value { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string[] ValueSetByTask { get { throw null; } }
        public override bool Execute() { throw null; }
    }
    public partial class CreateVisualBasicManifestResourceName : Microsoft.Build.Tasks.CreateManifestResourceName
    {
        public CreateVisualBasicManifestResourceName() { }
        protected override string SourceFileExtension { get { throw null; } }
        protected override string CreateManifestName(string fileName, string linkFileName, string rootNamespace, string dependentUponFileName, System.IO.Stream binaryStream) { throw null; }
        protected override bool IsSourceFile(string fileName) { throw null; }
    }
    public partial class Delete : Microsoft.Build.Tasks.TaskExtension, Microsoft.Build.Framework.ICancelableTask, Microsoft.Build.Framework.ITask
    {
        public Delete() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] DeletedFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        public bool TreatErrorsAsWarnings { get { throw null; } set { } }
        public void Cancel() { }
        public override bool Execute() { throw null; }
    }
    public sealed partial class DownloadFile : Microsoft.Build.Tasks.TaskExtension, Microsoft.Build.Framework.ICancelableTask, Microsoft.Build.Framework.ITask
    {
        public DownloadFile() { }
        public Microsoft.Build.Framework.ITaskItem DestinationFileName { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem DestinationFolder { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem DownloadedFile { get { throw null; } set { } }
        public int Retries { get { throw null; } set { } }
        public int RetryDelayMilliseconds { get { throw null; } set { } }
        public bool SkipUnchangedFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string SourceUrl { get { throw null; } set { } }
        public void Cancel() { }
        public override bool Execute() { throw null; }
    }
    public sealed partial class Error : Microsoft.Build.Tasks.TaskExtension
    {
        public Error() { }
        public string Code { get { throw null; } set { } }
        public string File { get { throw null; } set { } }
        public string HelpKeyword { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class ErrorFromResources : Microsoft.Build.Tasks.TaskExtension
    {
        public ErrorFromResources() { }
        public string[] Arguments { get { throw null; } set { } }
        public string Code { get { throw null; } set { } }
        public string File { get { throw null; } set { } }
        public string HelpKeyword { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string Resource { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class Exec : Microsoft.Build.Tasks.ToolTaskExtension
    {
        public Exec() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string Command { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ConsoleOutput { get { throw null; } }
        public bool ConsoleToMSBuild { get { throw null; } set { } }
        public string CustomErrorRegularExpression { get { throw null; } set { } }
        public string CustomWarningRegularExpression { get { throw null; } set { } }
        public bool IgnoreExitCode { get { throw null; } set { } }
        public bool IgnoreStandardErrorWarningFormat { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Outputs { get { throw null; } set { } }
        protected override System.Text.Encoding StandardErrorEncoding { get { throw null; } }
        protected override Microsoft.Build.Framework.MessageImportance StandardErrorLoggingImportance { get { throw null; } }
        protected override System.Text.Encoding StandardOutputEncoding { get { throw null; } }
        protected override Microsoft.Build.Framework.MessageImportance StandardOutputLoggingImportance { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string StdErrEncoding { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string StdOutEncoding { get { throw null; } set { } }
        protected override string ToolName { get { throw null; } }
        public string UseUtf8Encoding { get { throw null; } set { } }
        public string WorkingDirectory { get { throw null; } set { } }
        protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        protected override int ExecuteTool(string pathToTool, string responseFileCommands, string commandLineCommands) { throw null; }
        protected override string GenerateFullPathToTool() { throw null; }
        protected override string GetWorkingDirectory() { throw null; }
        protected override bool HandleTaskExecutionErrors() { throw null; }
        protected override void LogEventsFromTextOutput(string singleLine, Microsoft.Build.Framework.MessageImportance messageImportance) { }
        protected override void LogPathToTool(string toolName, string pathToTool) { }
        protected override void LogToolCommand(string message) { }
        protected override bool ValidateParameters() { throw null; }
    }
    public partial struct ExtractedClassName
    {
        private object _dummy;
        private int _dummyPrimitive;
        public bool IsInsideConditionalBlock { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    public partial class FindAppConfigFile : Microsoft.Build.Tasks.TaskExtension
    {
        public FindAppConfigFile() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem AppConfigFile { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] PrimaryList { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SecondaryList { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string TargetPath { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class FindInList : Microsoft.Build.Tasks.TaskExtension
    {
        public FindInList() { }
        public bool CaseSensitive { get { throw null; } set { } }
        public bool FindLastMatch { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem ItemFound { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string ItemSpecToFind { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] List { get { throw null; } set { } }
        public bool MatchFileNameOnly { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class FindInvalidProjectReferences : Microsoft.Build.Tasks.TaskExtension
    {
        public FindInvalidProjectReferences() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] InvalidReferences { get { throw null; } }
        public Microsoft.Build.Framework.ITaskItem[] ProjectReferences { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string TargetPlatformIdentifier { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string TargetPlatformVersion { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class FindUnderPath : Microsoft.Build.Tasks.TaskExtension
    {
        public FindUnderPath() { }
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] InPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] OutOfPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem Path { get { throw null; } set { } }
        public bool UpdateToAbsolutePaths { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class FormatUrl : Microsoft.Build.Tasks.TaskExtension
    {
        public FormatUrl() { }
        public string InputUrl { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string OutputUrl { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class FormatVersion : Microsoft.Build.Tasks.TaskExtension
    {
        public FormatVersion() { }
        public string FormatType { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string OutputVersion { get { throw null; } set { } }
        public int Revision { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class GenerateApplicationManifest : Microsoft.Build.Tasks.GenerateManifestBase
    {
        public GenerateApplicationManifest() { }
        public string ClrVersion { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem ConfigFile { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Dependencies { get { throw null; } set { } }
        public string ErrorReportUrl { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] FileAssociations { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        public bool HostInBrowser { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem IconFile { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] IsolatedComReferences { get { throw null; } set { } }
        public string ManifestType { get { throw null; } set { } }
        public string OSVersion { get { throw null; } set { } }
        public string Product { get { throw null; } set { } }
        public string Publisher { get { throw null; } set { } }
        public bool RequiresMinimumFramework35SP1 { get { throw null; } set { } }
        public string SuiteName { get { throw null; } set { } }
        public string SupportUrl { get { throw null; } set { } }
        public string TargetFrameworkProfile { get { throw null; } set { } }
        public string TargetFrameworkSubset { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem TrustInfoFile { get { throw null; } set { } }
        public bool UseApplicationTrust { get { throw null; } set { } }
        protected override System.Type GetObjectType() { throw null; }
        protected override bool OnManifestLoaded(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { throw null; }
        protected override bool OnManifestResolved(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { throw null; }
        protected internal override bool ValidateInputs() { throw null; }
    }
    public partial class GenerateBindingRedirects : Microsoft.Build.Tasks.TaskExtension
    {
        public GenerateBindingRedirects() { }
        public Microsoft.Build.Framework.ITaskItem AppConfigFile { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputAppConfigFile { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] SuggestedRedirects { get { throw null; } set { } }
        public string TargetName { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class GenerateBootstrapper : Microsoft.Build.Tasks.TaskExtension
    {
        public GenerateBootstrapper() { }
        public string ApplicationFile { get { throw null; } set { } }
        public string ApplicationName { get { throw null; } set { } }
        public bool ApplicationRequiresElevation { get { throw null; } set { } }
        public string ApplicationUrl { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string[] BootstrapperComponentFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] BootstrapperItems { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string BootstrapperKeyFile { get { throw null; } set { } }
        public string ComponentsLocation { get { throw null; } set { } }
        public string ComponentsUrl { get { throw null; } set { } }
        public bool CopyComponents { get { throw null; } set { } }
        public string Culture { get { throw null; } set { } }
        public string FallbackCulture { get { throw null; } set { } }
        public string OutputPath { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public string SupportUrl { get { throw null; } set { } }
        public bool Validate { get { throw null; } set { } }
        public string VisualStudioVersion { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class GenerateDeploymentManifest : Microsoft.Build.Tasks.GenerateManifestBase
    {
        public GenerateDeploymentManifest() { }
        public bool CreateDesktopShortcut { get { throw null; } set { } }
        public string DeploymentUrl { get { throw null; } set { } }
        public bool DisallowUrlActivation { get { throw null; } set { } }
        public string ErrorReportUrl { get { throw null; } set { } }
        public bool Install { get { throw null; } set { } }
        public bool MapFileExtensions { get { throw null; } set { } }
        public string MinimumRequiredVersion { get { throw null; } set { } }
        public string Product { get { throw null; } set { } }
        public string Publisher { get { throw null; } set { } }
        public string SuiteName { get { throw null; } set { } }
        public string SupportUrl { get { throw null; } set { } }
        public bool TrustUrlParameters { get { throw null; } set { } }
        public bool UpdateEnabled { get { throw null; } set { } }
        public int UpdateInterval { get { throw null; } set { } }
        public string UpdateMode { get { throw null; } set { } }
        public string UpdateUnit { get { throw null; } set { } }
        protected override System.Type GetObjectType() { throw null; }
        protected override bool OnManifestLoaded(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { throw null; }
        protected override bool OnManifestResolved(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { throw null; }
        protected internal override bool ValidateInputs() { throw null; }
    }
    public abstract partial class GenerateManifestBase : Microsoft.Build.Utilities.Task
    {
        protected GenerateManifestBase() { }
        public string AssemblyName { get { throw null; } set { } }
        public string AssemblyVersion { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem EntryPoint { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem InputManifest { get { throw null; } set { } }
        public int MaxTargetPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputManifest { get { throw null; } set { } }
        public string Platform { get { throw null; } set { } }
        public string TargetCulture { get { throw null; } set { } }
        public string TargetFrameworkMoniker { get { throw null; } set { } }
        public string TargetFrameworkVersion { get { throw null; } set { } }
        protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference AddAssemblyFromItem(Microsoft.Build.Framework.ITaskItem item) { throw null; }
        protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference AddAssemblyNameFromItem(Microsoft.Build.Framework.ITaskItem item, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType referenceType) { throw null; }
        protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference AddEntryPointFromItem(Microsoft.Build.Framework.ITaskItem item, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType referenceType) { throw null; }
        protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference AddFileFromItem(Microsoft.Build.Framework.ITaskItem item) { throw null; }
        public override bool Execute() { throw null; }
        protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference FindFileFromItem(Microsoft.Build.Framework.ITaskItem item) { throw null; }
        protected abstract System.Type GetObjectType();
        protected abstract bool OnManifestLoaded(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest);
        protected abstract bool OnManifestResolved(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest);
        protected internal virtual bool ValidateInputs() { throw null; }
        protected internal virtual bool ValidateOutput() { throw null; }
    }
    [Microsoft.Build.Framework.RequiredRuntimeAttribute("v2.0")]
    public sealed partial class GenerateResource : Microsoft.Build.Tasks.TaskExtension
    {
        public GenerateResource() { }
        public Microsoft.Build.Framework.ITaskItem[] AdditionalInputs { get { throw null; } set { } }
        public string[] EnvironmentVariables { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] ExcludedInputPaths { get { throw null; } set { } }
        public bool ExecuteAsTool { get { throw null; } set { } }
        public bool ExtractResWFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] FilesWritten { get { throw null; } }
        public bool MinimalRebuildFromTracking { get { throw null; } set { } }
        public bool NeverLockTypeAssemblies { get { throw null; } set { } }
        public string OutputDirectory { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] OutputResources { get { throw null; } set { } }
        public bool PublicClass { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] References { get { throw null; } set { } }
        public string SdkToolsPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Sources { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem StateFile { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string StronglyTypedClassName { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string StronglyTypedFileName { get { throw null; } set { } }
        public string StronglyTypedLanguage { get { throw null; } set { } }
        public string StronglyTypedManifestPrefix { get { throw null; } set { } }
        public string StronglyTypedNamespace { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] TLogReadFiles { get { throw null; } }
        public Microsoft.Build.Framework.ITaskItem[] TLogWriteFiles { get { throw null; } }
        public string ToolArchitecture { get { throw null; } set { } }
        public string TrackerFrameworkPath { get { throw null; } set { } }
        public string TrackerLogDirectory { get { throw null; } set { } }
        public string TrackerSdkPath { get { throw null; } set { } }
        public bool TrackFileAccess { get { throw null; } set { } }
        public bool UsePreserializedResources { get { throw null; } set { } }
        public bool UseSourcePath { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class GenerateTrustInfo : Microsoft.Build.Tasks.TaskExtension
    {
        public GenerateTrustInfo() { }
        public Microsoft.Build.Framework.ITaskItem[] ApplicationDependencies { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem BaseManifest { get { throw null; } set { } }
        public string ExcludedPermissions { get { throw null; } set { } }
        public string TargetFrameworkMoniker { get { throw null; } set { } }
        public string TargetZone { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem TrustInfoFile { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetAssemblyIdentity : Microsoft.Build.Tasks.TaskExtension
    {
        public GetAssemblyIdentity() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AssemblyFiles { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class GetFileHash : Microsoft.Build.Tasks.TaskExtension
    {
        public GetFileHash() { }
        public string Algorithm { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string Hash { get { throw null; } set { } }
        public string HashEncoding { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Items { get { throw null; } set { } }
        public string MetadataName { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetFrameworkPath : Microsoft.Build.Tasks.TaskExtension
    {
        public GetFrameworkPath() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion11Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion20Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion30Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion35Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion40Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion451Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion452Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion45Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion461Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion462Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion46Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion471Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion472Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion47Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion48Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string Path { get { throw null; } }
        public override bool Execute() { throw null; }
    }
    public partial class GetFrameworkSdkPath : Microsoft.Build.Tasks.TaskExtension
    {
        public GetFrameworkSdkPath() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkSdkVersion20Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkSdkVersion35Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkSdkVersion40Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkSdkVersion451Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkSdkVersion45Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkSdkVersion461Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkSdkVersion46Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string Path { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetInstalledSDKLocations : Microsoft.Build.Tasks.TaskExtension
    {
        public GetInstalledSDKLocations() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] InstalledSDKs { get { throw null; } set { } }
        public string[] SDKDirectoryRoots { get { throw null; } set { } }
        public string[] SDKExtensionDirectoryRoots { get { throw null; } set { } }
        public string SDKRegistryRoot { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string TargetPlatformIdentifier { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string TargetPlatformVersion { get { throw null; } set { } }
        public bool WarnWhenNoSDKsFound { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetReferenceAssemblyPaths : Microsoft.Build.Tasks.TaskExtension
    {
        public GetReferenceAssemblyPaths() { }
        public bool BypassFrameworkInstallChecks { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string[] FullFrameworkReferenceAssemblyPaths { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string[] ReferenceAssemblyPaths { get { throw null; } }
        public string RootPath { get { throw null; } set { } }
        public bool SuppressNotFoundError { get { throw null; } set { } }
        public string TargetFrameworkFallbackSearchPaths { get { throw null; } set { } }
        public string TargetFrameworkMoniker { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string TargetFrameworkMonikerDisplayName { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetSDKReferenceFiles : Microsoft.Build.Tasks.TaskExtension
    {
        public GetSDKReferenceFiles() { }
        public string CacheFileFolderPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] CopyLocalFiles { get { throw null; } }
        public bool LogCacheFileExceptions { get { throw null; } set { } }
        public bool LogRedistConflictBetweenSDKsAsWarning { get { throw null; } set { } }
        public bool LogRedistConflictWithinSDKAsWarning { get { throw null; } set { } }
        public bool LogRedistFilesList { get { throw null; } set { } }
        public bool LogReferenceConflictBetweenSDKsAsWarning { get { throw null; } set { } }
        public bool LogReferenceConflictWithinSDKAsWarning { get { throw null; } set { } }
        public bool LogReferencesList { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] RedistFiles { get { throw null; } }
        public string[] ReferenceExtensions { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] References { get { throw null; } }
        public Microsoft.Build.Framework.ITaskItem[] ResolvedSDKReferences { get { throw null; } set { } }
        public string TargetPlatformIdentifier { get { throw null; } set { } }
        public string TargetPlatformVersion { get { throw null; } set { } }
        public string TargetSDKIdentifier { get { throw null; } set { } }
        public string TargetSDKVersion { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class Hash : Microsoft.Build.Tasks.TaskExtension
    {
        public Hash() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public string HashResult { get { throw null; } set { } }
        public bool IgnoreCase { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ItemsToHash { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial interface IFixedTypeInfo
    {
        void AddressOfMember(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, out System.IntPtr ppv);
        void CreateInstance(object pUnkOuter, ref System.Guid riid, out object ppvObj);
        void GetContainingTypeLib(out System.Runtime.InteropServices.ComTypes.ITypeLib ppTLB, out int pIndex);
        void GetDllEntry(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, System.IntPtr pBstrDllName, System.IntPtr pBstrName, System.IntPtr pwOrdinal);
        void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        void GetFuncDesc(int index, out System.IntPtr ppFuncDesc);
        void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
        void GetImplTypeFlags(int index, out System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS pImplTypeFlags);
        void GetMops(int memid, out string pBstrMops);
        void GetNames(int memid, string[] rgBstrNames, int cMaxNames, out int pcNames);
        void GetRefTypeInfo(System.IntPtr hRef, out Microsoft.Build.Tasks.IFixedTypeInfo ppTI);
        void GetRefTypeOfImplType(int index, out System.IntPtr href);
        void GetTypeAttr(out System.IntPtr ppTypeAttr);
        void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
        void GetVarDesc(int index, out System.IntPtr ppVarDesc);
        void Invoke(object pvInstance, int memid, short wFlags, ref System.Runtime.InteropServices.ComTypes.DISPPARAMS pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, out int puArgErr);
        void ReleaseFuncDesc(System.IntPtr pFuncDesc);
        void ReleaseTypeAttr(System.IntPtr pTypeAttr);
        void ReleaseVarDesc(System.IntPtr pVarDesc);
    }
    public partial class LC : Microsoft.Build.Tasks.ToolTaskExtension
    {
        public LC() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem LicenseTarget { get { throw null; } set { } }
        public bool NoLogo { get { throw null; } set { } }
        public string OutputDirectory { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputLicense { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] ReferencedAssemblies { get { throw null; } set { } }
        public string SdkToolsPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Sources { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string TargetFrameworkVersion { get { throw null; } set { } }
        protected override string ToolName { get { throw null; } }
        protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        protected override string GenerateFullPathToTool() { throw null; }
        protected override bool ValidateParameters() { throw null; }
    }
    public partial class MakeDir : Microsoft.Build.Tasks.TaskExtension
    {
        public MakeDir() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Directories { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] DirectoriesCreated { get { throw null; } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class Message : Microsoft.Build.Tasks.TaskExtension
    {
        public Message() { }
        public string Code { get { throw null; } set { } }
        public string File { get { throw null; } set { } }
        public string HelpKeyword { get { throw null; } set { } }
        public string Importance { get { throw null; } set { } }
        public bool IsCritical { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class Move : Microsoft.Build.Tasks.TaskExtension, Microsoft.Build.Framework.ICancelableTask, Microsoft.Build.Framework.ITask
    {
        public Move() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] DestinationFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem DestinationFolder { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] MovedFiles { get { throw null; } }
        public bool OverwriteReadOnlyFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SourceFiles { get { throw null; } set { } }
        public void Cancel() { }
        public override bool Execute() { throw null; }
    }
    [Microsoft.Build.Framework.RunInMTAAttribute]
    public partial class MSBuild : Microsoft.Build.Tasks.TaskExtension
    {
        public MSBuild() { }
        public bool BuildInParallel { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Projects { get { throw null; } set { } }
        public string[] Properties { get { throw null; } set { } }
        public bool RebaseOutputs { get { throw null; } set { } }
        public string RemoveProperties { get { throw null; } set { } }
        public bool RunEachTargetSeparately { get { throw null; } set { } }
        public string SkipNonexistentProjects { get { throw null; } set { } }
        public bool StopOnFirstFailure { get { throw null; } set { } }
        public string[] TargetAndPropertyListSeparators { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] TargetOutputs { get { throw null; } }
        public string[] Targets { get { throw null; } set { } }
        public string ToolsVersion { get { throw null; } set { } }
        public bool UnloadProjectsOnCompletion { get { throw null; } set { } }
        public bool UseResultsCache { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class ReadLinesFromFile : Microsoft.Build.Tasks.TaskExtension
    {
        public ReadLinesFromFile() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem File { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Lines { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class RegisterAssembly : Microsoft.Build.Tasks.AppDomainIsolatedTaskExtension, System.Runtime.InteropServices.ITypeLibExporterNotifySink
    {
        public RegisterAssembly() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem AssemblyListFile { get { throw null; } set { } }
        public bool CreateCodeBase { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] TypeLibFiles { get { throw null; } set { } }
        public override bool Execute() { throw null; }
        public void ReportEvent(System.Runtime.InteropServices.ExporterEventKind kind, int code, string msg) { }
        public object ResolveRef(System.Reflection.Assembly assemblyToResolve) { throw null; }
    }
    public partial class RemoveDir : Microsoft.Build.Tasks.TaskExtension
    {
        public RemoveDir() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Directories { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] RemovedDirectories { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class RemoveDuplicates : Microsoft.Build.Tasks.TaskExtension
    {
        public RemoveDuplicates() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Filtered { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public bool HadAnyDuplicates { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Inputs { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class RequiresFramework35SP1Assembly : Microsoft.Build.Tasks.TaskExtension
    {
        public RequiresFramework35SP1Assembly() { }
        public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { throw null; } set { } }
        public bool CreateDesktopShortcut { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem DeploymentManifestEntryPoint { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem EntryPoint { get { throw null; } set { } }
        public string ErrorReportUrl { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] ReferencedAssemblies { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public bool RequiresMinimumFramework35SP1 { get { throw null; } set { } }
        public bool SigningManifests { get { throw null; } set { } }
        public string SuiteName { get { throw null; } set { } }
        public string TargetFrameworkVersion { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class ResolveAssemblyReference : Microsoft.Build.Tasks.TaskExtension
    {
        public ResolveAssemblyReference() { }
        public string[] AllowedAssemblyExtensions { get { throw null; } set { } }
        public string[] AllowedRelatedFileExtensions { get { throw null; } set { } }
        public string AppConfigFile { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] AssemblyFiles { get { throw null; } set { } }
        public bool AutoUnify { get { throw null; } set { } }
        public string[] CandidateAssemblyFiles { get { throw null; } set { } }
        public bool CopyLocalDependenciesWhenParentReferenceInGac { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] CopyLocalFiles { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string DependsOnNETStandard { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string DependsOnSystemRuntime { get { throw null; } }
        public bool DoNotCopyLocalIfInGac { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] FilesWritten { get { throw null; } set { } }
        public bool FindDependencies { get { throw null; } set { } }
        public bool FindDependenciesOfExternallyResolvedReferences { get { throw null; } set { } }
        public bool FindRelatedFiles { get { throw null; } set { } }
        public bool FindSatellites { get { throw null; } set { } }
        public bool FindSerializationAssemblies { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] FullFrameworkAssemblyTables { get { throw null; } set { } }
        public string[] FullFrameworkFolders { get { throw null; } set { } }
        public string[] FullTargetFrameworkSubsetNames { get { throw null; } set { } }
        public bool IgnoreDefaultInstalledAssemblySubsetTables { get { throw null; } set { } }
        public bool IgnoreDefaultInstalledAssemblyTables { get { throw null; } set { } }
        public bool IgnoreTargetFrameworkAttributeVersionMismatch { get { throw null; } set { } }
        public bool IgnoreVersionForFrameworkReferences { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] InstalledAssemblySubsetTables { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] InstalledAssemblyTables { get { throw null; } set { } }
        public string[] LatestTargetFrameworkDirectories { get { throw null; } set { } }
        public string ProfileName { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] RelatedFiles { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ResolvedDependencyFiles { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ResolvedFiles { get { throw null; } }
        public Microsoft.Build.Framework.ITaskItem[] ResolvedSDKReferences { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SatelliteFiles { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ScatterFiles { get { throw null; } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string[] SearchPaths { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SerializationAssemblyFiles { get { throw null; } }
        public bool Silent { get { throw null; } set { } }
        public string StateFile { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SuggestedRedirects { get { throw null; } }
        public bool SupportsBindingRedirectGeneration { get { throw null; } set { } }
        public string TargetedRuntimeVersion { get { throw null; } set { } }
        public string[] TargetFrameworkDirectories { get { throw null; } set { } }
        public string TargetFrameworkMoniker { get { throw null; } set { } }
        public string TargetFrameworkMonikerDisplayName { get { throw null; } set { } }
        public string[] TargetFrameworkSubsets { get { throw null; } set { } }
        public string TargetFrameworkVersion { get { throw null; } set { } }
        public string TargetProcessorArchitecture { get { throw null; } set { } }
        public bool UnresolveFrameworkAssembliesFromHigherFrameworks { get { throw null; } set { } }
        public string WarnOrErrorOnTargetArchitectureMismatch { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class ResolveCodeAnalysisRuleSet : Microsoft.Build.Tasks.TaskExtension
    {
        public ResolveCodeAnalysisRuleSet() { }
        public string CodeAnalysisRuleSet { get { throw null; } set { } }
        public string[] CodeAnalysisRuleSetDirectories { get { throw null; } set { } }
        public string MSBuildProjectDirectory { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string ResolvedCodeAnalysisRuleSet { get { throw null; } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class ResolveComReference : Microsoft.Build.Tasks.AppDomainIsolatedTaskExtension
    {
        public ResolveComReference() { }
        public bool DelaySign { get { throw null; } set { } }
        public string[] EnvironmentVariables { get { throw null; } set { } }
        public bool ExecuteAsTool { get { throw null; } set { } }
        public bool IncludeVersionInInteropName { get { throw null; } set { } }
        public string KeyContainer { get { throw null; } set { } }
        public string KeyFile { get { throw null; } set { } }
        public bool NoClassMembers { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] ResolvedAssemblyReferences { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ResolvedFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ResolvedModules { get { throw null; } set { } }
        public string SdkToolsPath { get { throw null; } set { } }
        public bool Silent { get { throw null; } set { } }
        public string StateFile { get { throw null; } set { } }
        public string TargetFrameworkVersion { get { throw null; } set { } }
        public string TargetProcessorArchitecture { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] TypeLibFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] TypeLibNames { get { throw null; } set { } }
        public string WrapperOutputDirectory { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class ResolveKeySource : Microsoft.Build.Tasks.TaskExtension
    {
        public ResolveKeySource() { }
        public int AutoClosePasswordPromptShow { get { throw null; } set { } }
        public int AutoClosePasswordPromptTimeout { get { throw null; } set { } }
        public string CertificateFile { get { throw null; } set { } }
        public string CertificateThumbprint { get { throw null; } set { } }
        public string KeyFile { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string ResolvedKeyContainer { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string ResolvedKeyFile { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string ResolvedThumbprint { get { throw null; } set { } }
        public bool ShowImportDialogDespitePreviousFailures { get { throw null; } set { } }
        public bool SuppressAutoClosePasswordPrompt { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class ResolveManifestFiles : Microsoft.Build.Tasks.TaskExtension
    {
        public ResolveManifestFiles() { }
        public Microsoft.Build.Framework.ITaskItem DeploymentManifestEntryPoint { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem EntryPoint { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] ExtraFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] ManagedAssemblies { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] NativeAssemblies { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] OutputAssemblies { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputDeploymentManifestEntryPoint { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputEntryPoint { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] OutputFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] PublishFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] SatelliteAssemblies { get { throw null; } set { } }
        public bool SigningManifests { get { throw null; } set { } }
        public string TargetCulture { get { throw null; } set { } }
        public string TargetFrameworkVersion { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class ResolveNativeReference : Microsoft.Build.Tasks.TaskExtension
    {
        public ResolveNativeReference() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string[] AdditionalSearchPaths { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ContainedComComponents { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ContainedLooseEtcFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ContainedLooseTlbFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ContainedPrerequisiteAssemblies { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ContainedTypeLibraries { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ContainingReferenceFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] NativeReferences { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class ResolveNonMSBuildProjectOutput : Microsoft.Build.Tasks.ResolveProjectBase
    {
        public ResolveNonMSBuildProjectOutput() { }
        public string PreresolvedProjectOutputs { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ResolvedOutputPaths { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] UnresolvedProjectReferences { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public abstract partial class ResolveProjectBase : Microsoft.Build.Tasks.TaskExtension
    {
        protected ResolveProjectBase() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ProjectReferences { get { throw null; } set { } }
        protected void AddSyntheticProjectReferences(string currentProjectAbsolutePath) { }
        protected System.Xml.XmlElement GetProjectElement(Microsoft.Build.Framework.ITaskItem projectRef) { throw null; }
        protected string GetProjectItem(Microsoft.Build.Framework.ITaskItem projectRef) { throw null; }
    }
    public partial class ResolveSDKReference : Microsoft.Build.Tasks.TaskExtension
    {
        public ResolveSDKReference() { }
        public Microsoft.Build.Framework.ITaskItem[] DisallowedSDKDependencies { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] InstalledSDKs { get { throw null; } set { } }
        public bool LogResolutionErrorsAsWarnings { get { throw null; } set { } }
        public bool Prefer32Bit { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string ProjectName { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] References { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ResolvedSDKReferences { get { throw null; } }
        public Microsoft.Build.Framework.ITaskItem[] RuntimeReferenceOnlySDKDependencies { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SDKReferences { get { throw null; } set { } }
        public string TargetedSDKArchitecture { get { throw null; } set { } }
        public string TargetedSDKConfiguration { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string TargetPlatformIdentifier { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string TargetPlatformVersion { get { throw null; } set { } }
        public bool WarnOnMissingPlatformVersion { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class RoslynCodeTaskFactory : Microsoft.Build.Framework.ITaskFactory
    {
        public RoslynCodeTaskFactory() { }
        public string FactoryName { get { throw null; } }
        public System.Type TaskType { get { throw null; } }
        public void CleanupTask(Microsoft.Build.Framework.ITask task) { }
        public Microsoft.Build.Framework.ITask CreateTask(Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost) { throw null; }
        public Microsoft.Build.Framework.TaskPropertyInfo[] GetTaskParameters() { throw null; }
        public bool Initialize(string taskName, System.Collections.Generic.IDictionary<string, Microsoft.Build.Framework.TaskPropertyInfo> parameterGroup, string taskBody, Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost) { throw null; }
    }
    public partial class SGen : Microsoft.Build.Tasks.ToolTaskExtension
    {
        public SGen() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string BuildAssemblyName { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string BuildAssemblyPath { get { throw null; } set { } }
        public bool DelaySign { get { throw null; } set { } }
        public string KeyContainer { get { throw null; } set { } }
        public string KeyFile { get { throw null; } set { } }
        public string Platform { get { throw null; } set { } }
        public string[] References { get { throw null; } set { } }
        public string SdkToolsPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SerializationAssembly { get { throw null; } set { } }
        public string SerializationAssemblyName { get { throw null; } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public bool ShouldGenerateSerializer { get { throw null; } set { } }
        protected override string ToolName { get { throw null; } }
        public string[] Types { get { throw null; } set { } }
        public bool UseKeep { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public bool UseProxyTypes { get { throw null; } set { } }
        protected override string GenerateCommandLineCommands() { throw null; }
        protected override string GenerateFullPathToTool() { throw null; }
        protected override bool SkipTaskExecution() { throw null; }
        protected override bool ValidateParameters() { throw null; }
    }
    public sealed partial class SignFile : Microsoft.Build.Utilities.Task
    {
        public SignFile() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string CertificateThumbprint { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem SigningTarget { get { throw null; } set { } }
        public string TargetFrameworkVersion { get { throw null; } set { } }
        public string TimestampUrl { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public abstract partial class TaskExtension : Microsoft.Build.Utilities.Task
    {
        internal TaskExtension() { }
        public new Microsoft.Build.Utilities.TaskLoggingHelper Log { get { throw null; } }
    }
    public partial class TaskLoggingHelperExtension : Microsoft.Build.Utilities.TaskLoggingHelper
    {
        public TaskLoggingHelperExtension(Microsoft.Build.Framework.ITask taskInstance, System.Resources.ResourceManager primaryResources, System.Resources.ResourceManager sharedResources, string helpKeywordPrefix) : base (default(Microsoft.Build.Framework.ITask)) { }
        public System.Resources.ResourceManager TaskSharedResources { get { throw null; } set { } }
        public override string FormatResourceString(string resourceName, params object[] args) { throw null; }
    }
    public sealed partial class Telemetry : Microsoft.Build.Tasks.TaskExtension
    {
        public Telemetry() { }
        public string EventData { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string EventName { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public abstract partial class ToolTaskExtension : Microsoft.Build.Utilities.ToolTask
    {
        internal ToolTaskExtension() { }
        protected internal System.Collections.Hashtable Bag { get { throw null; } }
        protected override bool HasLoggedErrors { get { throw null; } }
        public new Microsoft.Build.Utilities.TaskLoggingHelper Log { get { throw null; } }
        protected virtual bool UseNewLineSeparatorInResponseFile { get { throw null; } }
        protected internal virtual void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        protected internal virtual void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        protected override string GenerateCommandLineCommands() { throw null; }
        protected override string GenerateResponseFileCommands() { throw null; }
        protected internal bool GetBoolParameterWithDefault(string parameterName, bool defaultValue) { throw null; }
        protected internal int GetIntParameterWithDefault(string parameterName, int defaultValue) { throw null; }
    }
    public partial class Touch : Microsoft.Build.Tasks.TaskExtension
    {
        public Touch() { }
        public bool AlwaysCreate { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        public bool ForceTouch { get { throw null; } set { } }
        public string Time { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] TouchedFiles { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class UnregisterAssembly : Microsoft.Build.Tasks.AppDomainIsolatedTaskExtension
    {
        public UnregisterAssembly() { }
        public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem AssemblyListFile { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] TypeLibFiles { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class Unzip : Microsoft.Build.Tasks.TaskExtension, Microsoft.Build.Framework.ICancelableTask, Microsoft.Build.Framework.ITask
    {
        public Unzip() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem DestinationFolder { get { throw null; } set { } }
        public bool OverwriteReadOnlyFiles { get { throw null; } set { } }
        public bool SkipUnchangedFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SourceFiles { get { throw null; } set { } }
        public void Cancel() { }
        public override bool Execute() { throw null; }
    }
    public partial class UpdateManifest : Microsoft.Build.Utilities.Task
    {
        public UpdateManifest() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem ApplicationManifest { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string ApplicationPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem InputManifest { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputManifest { get { throw null; } set { } }
        public string TargetFrameworkVersion { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class VerifyFileHash : Microsoft.Build.Tasks.TaskExtension
    {
        public VerifyFileHash() { }
        public string Algorithm { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string File { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string Hash { get { throw null; } set { } }
        public string HashEncoding { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class Warning : Microsoft.Build.Tasks.TaskExtension
    {
        public Warning() { }
        public string Code { get { throw null; } set { } }
        public string File { get { throw null; } set { } }
        public string HelpKeyword { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class WinMDExp : Microsoft.Build.Tasks.ToolTaskExtension
    {
        public WinMDExp() { }
        public string AssemblyUnificationPolicy { get { throw null; } set { } }
        public string DisabledWarnings { get { throw null; } set { } }
        public string InputDocumentationFile { get { throw null; } set { } }
        public string InputPDBFile { get { throw null; } set { } }
        public string OutputDocumentationFile { get { throw null; } set { } }
        public string OutputPDBFile { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string OutputWindowsMetadataFile { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] References { get { throw null; } set { } }
        public string SdkToolsPath { get { throw null; } set { } }
        protected override System.Text.Encoding StandardErrorEncoding { get { throw null; } }
        protected override System.Text.Encoding StandardOutputEncoding { get { throw null; } }
        protected override string ToolName { get { throw null; } }
        public bool TreatWarningsAsErrors { get { throw null; } set { } }
        protected override bool UseNewLineSeparatorInResponseFile { get { throw null; } }
        public bool UTF8Output { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string WinMDModule { get { throw null; } set { } }
        protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        protected override string GenerateFullPathToTool() { throw null; }
        protected override bool SkipTaskExecution() { throw null; }
        protected override bool ValidateParameters() { throw null; }
    }
    public partial class WriteCodeFragment : Microsoft.Build.Tasks.TaskExtension
    {
        public WriteCodeFragment() { }
        public Microsoft.Build.Framework.ITaskItem[] AssemblyAttributes { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string Language { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem OutputDirectory { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputFile { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class WriteLinesToFile : Microsoft.Build.Tasks.TaskExtension
    {
        public WriteLinesToFile() { }
        public string Encoding { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem File { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Lines { get { throw null; } set { } }
        public bool Overwrite { get { throw null; } set { } }
        public bool WriteOnlyWhenDifferent { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class XamlTaskFactory : Microsoft.Build.Framework.ITaskFactory
    {
        public XamlTaskFactory() { }
        public string FactoryName { get { throw null; } }
        public string TaskElementContents { get { throw null; } }
        public string TaskName { get { throw null; } }
        public string TaskNamespace { get { throw null; } }
        public System.Type TaskType { get { throw null; } }
        public void CleanupTask(Microsoft.Build.Framework.ITask task) { }
        public Microsoft.Build.Framework.ITask CreateTask(Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost) { throw null; }
        public Microsoft.Build.Framework.TaskPropertyInfo[] GetTaskParameters() { throw null; }
        public bool Initialize(string taskName, System.Collections.Generic.IDictionary<string, Microsoft.Build.Framework.TaskPropertyInfo> taskParameters, string taskElementContents, Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost) { throw null; }
    }
    public partial class XmlPeek : Microsoft.Build.Tasks.TaskExtension
    {
        public XmlPeek() { }
        public string Namespaces { get { throw null; } set { } }
        public bool ProhibitDtd { get { throw null; } set { } }
        public string Query { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Result { get { throw null; } }
        public string XmlContent { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem XmlInputPath { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class XmlPoke : Microsoft.Build.Tasks.TaskExtension
    {
        public XmlPoke() { }
        public string Namespaces { get { throw null; } set { } }
        public string Query { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem Value { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem XmlInputPath { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class XslTransformation : Microsoft.Build.Tasks.TaskExtension
    {
        public XslTransformation() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] OutputPaths { get { throw null; } set { } }
        public string Parameters { get { throw null; } set { } }
        public bool UseTrustedSettings { get { throw null; } set { } }
        public string XmlContent { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] XmlInputPaths { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem XslCompiledDllPath { get { throw null; } set { } }
        public string XslContent { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem XslInputPath { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class ZipDirectory : Microsoft.Build.Tasks.TaskExtension
    {
        public ZipDirectory() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem DestinationFile { get { throw null; } set { } }
        public bool Overwrite { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem SourceDirectory { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
}
namespace Microsoft.Build.Tasks.Deployment.Bootstrapper
{
    public partial class BootstrapperBuilder : Microsoft.Build.Tasks.Deployment.Bootstrapper.IBootstrapperBuilder
    {
        public BootstrapperBuilder() { }
        public BootstrapperBuilder(string visualStudioVersion) { }
        public string Path { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Products { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildResults Build(Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildSettings settings) { throw null; }
        public string[] GetOutputFolders(string[] productCodes, string culture, string fallbackCulture, Microsoft.Build.Tasks.Deployment.Bootstrapper.ComponentsLocation componentsLocation) { throw null; }
        public static string XmlToConfigurationFile(System.Xml.XmlNode input) { throw null; }
    }
    public partial class BuildMessage : Microsoft.Build.Tasks.Deployment.Bootstrapper.IBuildMessage
    {
        internal BuildMessage() { }
        public int HelpId { get { throw null; } }
        public string HelpKeyword { get { throw null; } }
        public string Message { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessageSeverity Severity { get { throw null; } }
    }
    public enum BuildMessageSeverity
    {
        Info = 0,
        Warning = 1,
        Error = 2,
    }
    public partial class BuildResults : Microsoft.Build.Tasks.Deployment.Bootstrapper.IBuildResults
    {
        internal BuildResults() { }
        public string[] ComponentFiles { get { throw null; } }
        public string KeyFile { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessage[] Messages { get { throw null; } }
        public bool Succeeded { get { throw null; } }
    }
    public partial class BuildSettings : Microsoft.Build.Tasks.Deployment.Bootstrapper.IBuildSettings
    {
        public BuildSettings() { }
        public string ApplicationFile { get { throw null; } set { } }
        public string ApplicationName { get { throw null; } set { } }
        public bool ApplicationRequiresElevation { get { throw null; } set { } }
        public string ApplicationUrl { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.ComponentsLocation ComponentsLocation { get { throw null; } set { } }
        public string ComponentsUrl { get { throw null; } set { } }
        public bool CopyComponents { get { throw null; } set { } }
        public int FallbackLCID { get { throw null; } set { } }
        public int LCID { get { throw null; } set { } }
        public string OutputPath { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilderCollection ProductBuilders { get { throw null; } }
        public string SupportUrl { get { throw null; } set { } }
        public bool Validate { get { throw null; } set { } }
    }
    public enum ComponentsLocation
    {
        HomeSite = 0,
        Relative = 1,
        Absolute = 2,
    }
    public partial interface IBootstrapperBuilder
    {
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        string Path { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(4)]
        Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Products { get; }
        [System.Runtime.InteropServices.DispIdAttribute(5)]
        Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildResults Build(Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildSettings settings);
    }
    public partial interface IBuildMessage
    {
        [System.Runtime.InteropServices.DispIdAttribute(4)]
        int HelpId { get; }
        [System.Runtime.InteropServices.DispIdAttribute(3)]
        string HelpKeyword { get; }
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        string Message { get; }
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessageSeverity Severity { get; }
    }
    public partial interface IBuildResults
    {
        [System.Runtime.InteropServices.DispIdAttribute(3)]
        string[] ComponentFiles { get; }
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        string KeyFile { get; }
        [System.Runtime.InteropServices.DispIdAttribute(4)]
        Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessage[] Messages { get; }
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        bool Succeeded { get; }
    }
    public partial interface IBuildSettings
    {
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        string ApplicationFile { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        string ApplicationName { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(13)]
        bool ApplicationRequiresElevation { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(3)]
        string ApplicationUrl { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(11)]
        Microsoft.Build.Tasks.Deployment.Bootstrapper.ComponentsLocation ComponentsLocation { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(4)]
        string ComponentsUrl { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(5)]
        bool CopyComponents { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(7)]
        int FallbackLCID { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(6)]
        int LCID { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(8)]
        string OutputPath { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(9)]
        Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilderCollection ProductBuilders { get; }
        [System.Runtime.InteropServices.DispIdAttribute(12)]
        string SupportUrl { get; set; }
        [System.Runtime.InteropServices.DispIdAttribute(10)]
        bool Validate { get; set; }
    }
    public partial interface IProduct
    {
        [System.Runtime.InteropServices.DispIdAttribute(4)]
        Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Includes { get; }
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        string Name { get; }
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder ProductBuilder { get; }
        [System.Runtime.InteropServices.DispIdAttribute(3)]
        string ProductCode { get; }
    }
    public partial interface IProductBuilder
    {
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Product { get; }
    }
    public partial interface IProductBuilderCollection
    {
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        void Add(Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder builder);
    }
    public partial interface IProductCollection
    {
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        int Count { get; }
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Item(int index);
        [System.Runtime.InteropServices.DispIdAttribute(3)]
        Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Product(string productCode);
    }
    public partial class Product : Microsoft.Build.Tasks.Deployment.Bootstrapper.IProduct
    {
        public Product() { }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Includes { get { throw null; } }
        public string Name { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder ProductBuilder { get { throw null; } }
        public string ProductCode { get { throw null; } }
    }
    public partial class ProductBuilder : Microsoft.Build.Tasks.Deployment.Bootstrapper.IProductBuilder
    {
        internal ProductBuilder() { }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Product { get { throw null; } }
    }
    public partial class ProductBuilderCollection : Microsoft.Build.Tasks.Deployment.Bootstrapper.IProductBuilderCollection, System.Collections.IEnumerable
    {
        internal ProductBuilderCollection() { }
        public void Add(Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder builder) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    public partial class ProductCollection : Microsoft.Build.Tasks.Deployment.Bootstrapper.IProductCollection, System.Collections.IEnumerable
    {
        internal ProductCollection() { }
        public int Count { get { throw null; } }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Item(int index) { throw null; }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Product(string productCode) { throw null; }
    }
}
namespace Microsoft.Build.Tasks.Deployment.ManifestUtilities
{
    public sealed partial class ApplicationIdentity
    {
        public ApplicationIdentity(string url, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity deployManifestIdentity, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity applicationManifestIdentity) { }
        public ApplicationIdentity(string url, string deployManifestPath, string applicationManifestPath) { }
        public override string ToString() { throw null; }
    }
    public sealed partial class ApplicationManifest : Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyManifest
    {
        public ApplicationManifest() { }
        public ApplicationManifest(string targetFrameworkVersion) { }
        public string ConfigFile { get { throw null; } set { } }
        public override Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference EntryPoint { get { throw null; } set { } }
        public string ErrorReportUrl { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileAssociationCollection FileAssociations { get { throw null; } }
        public bool HostInBrowser { get { throw null; } set { } }
        public string IconFile { get { throw null; } set { } }
        public bool IsClickOnceManifest { get { throw null; } set { } }
        public int MaxTargetPath { get { throw null; } set { } }
        public string OSDescription { get { throw null; } set { } }
        public string OSSupportUrl { get { throw null; } set { } }
        public string OSVersion { get { throw null; } set { } }
        public string Product { get { throw null; } set { } }
        public string Publisher { get { throw null; } set { } }
        public string SuiteName { get { throw null; } set { } }
        public string SupportUrl { get { throw null; } set { } }
        public string TargetFrameworkVersion { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.TrustInfo TrustInfo { get { throw null; } set { } }
        public bool UseApplicationTrust { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlConfigFile { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlElementAttribute("EntryPointIdentity")]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity XmlEntryPointIdentity { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlEntryPointParameters { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlEntryPointPath { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlErrorReportUrl { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlArrayAttribute("FileAssociations")]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileAssociation[] XmlFileAssociations { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlHostInBrowser { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlIconFile { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlIsClickOnceManifest { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlOSBuild { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlOSDescription { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlOSMajor { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlOSMinor { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlOSRevision { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlOSSupportUrl { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlProduct { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlPublisher { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlSuiteName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlSupportUrl { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlUseApplicationTrust { get { throw null; } set { } }
        public override void Validate() { }
    }
    public sealed partial class AssemblyIdentity
    {
        public AssemblyIdentity() { }
        public AssemblyIdentity(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity identity) { }
        public AssemblyIdentity(string name) { }
        public AssemblyIdentity(string name, string version) { }
        public AssemblyIdentity(string name, string version, string publicKeyToken, string culture) { }
        public AssemblyIdentity(string name, string version, string publicKeyToken, string culture, string processorArchitecture) { }
        public AssemblyIdentity(string name, string version, string publicKeyToken, string culture, string processorArchitecture, string type) { }
        public string Culture { get { throw null; } set { } }
        public bool IsFrameworkAssembly { get { throw null; } }
        public bool IsNeutralPlatform { get { throw null; } }
        public bool IsStrongName { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string ProcessorArchitecture { get { throw null; } set { } }
        public string PublicKeyToken { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlCulture { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlProcessorArchitecture { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlPublicKeyToken { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlType { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlVersion { get { throw null; } set { } }
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromAssemblyName(string assemblyName) { throw null; }
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromFile(string path) { throw null; }
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromManagedAssembly(string path) { throw null; }
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromManifest(string path) { throw null; }
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromNativeAssembly(string path) { throw null; }
        public string GetFullName(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity.FullNameFlags flags) { throw null; }
        public bool IsInFramework(string frameworkIdentifier, string frameworkVersion) { throw null; }
        public override string ToString() { throw null; }
        [System.FlagsAttribute]
        public enum FullNameFlags
        {
            Default = 0,
            ProcessorArchitecture = 1,
            Type = 2,
            All = 3,
        }
    }
    public partial class AssemblyManifest : Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest
    {
        public AssemblyManifest() { }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] ExternalProxyStubs { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlArrayAttribute("ExternalProxyStubs")]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] XmlExternalProxyStubs { get { throw null; } set { } }
    }
    public sealed partial class AssemblyReference : Microsoft.Build.Tasks.Deployment.ManifestUtilities.BaseReference
    {
        public AssemblyReference() { }
        public AssemblyReference(string path) { }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity AssemblyIdentity { get { throw null; } set { } }
        public bool IsPrerequisite { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType ReferenceType { get { throw null; } set { } }
        protected internal override string SortName { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlElementAttribute("AssemblyIdentity")]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity XmlAssemblyIdentity { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlIsNative { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlIsPrerequisite { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    public sealed partial class AssemblyReferenceCollection : System.Collections.IEnumerable
    {
        internal AssemblyReferenceCollection() { }
        public int Count { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference this[int index] { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference Add(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference assembly) { throw null; }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference Add(string path) { throw null; }
        public void Clear() { }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference Find(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity identity) { throw null; }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference Find(string name) { throw null; }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference FindTargetPath(string targetPath) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public void Remove(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference assemblyReference) { }
    }
    public enum AssemblyReferenceType
    {
        Unspecified = 0,
        ClickOnceManifest = 1,
        ManagedAssembly = 2,
        NativeAssembly = 3,
    }
    public abstract partial class BaseReference
    {
        protected internal BaseReference() { }
        protected internal BaseReference(string path) { }
        public string Group { get { throw null; } set { } }
        public string Hash { get { throw null; } set { } }
        public bool IsOptional { get { throw null; } set { } }
        public string ResolvedPath { get { throw null; } set { } }
        public long Size { get { throw null; } set { } }
        protected internal abstract string SortName { get; }
        public string SourcePath { get { throw null; } set { } }
        public string TargetPath { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlGroup { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlHash { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlHashAlgorithm { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlIsOptional { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlPath { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlSize { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    public partial class ComClass
    {
        public ComClass() { }
        public string ClsId { get { throw null; } }
        public string Description { get { throw null; } }
        public string ProgId { get { throw null; } }
        public string ThreadingModel { get { throw null; } }
        public string TlbId { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlClsId { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlDescription { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlProgId { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlThreadingModel { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlTlbId { get { throw null; } set { } }
    }
    public sealed partial class CompatibleFramework
    {
        public CompatibleFramework() { }
        public string Profile { get { throw null; } set { } }
        public string SupportedRuntime { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlProfile { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlSupportedRuntime { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlVersion { get { throw null; } set { } }
    }
    public sealed partial class CompatibleFrameworkCollection : System.Collections.IEnumerable
    {
        internal CompatibleFrameworkCollection() { }
        public int Count { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.CompatibleFramework this[int index] { get { throw null; } }
        public void Add(Microsoft.Build.Tasks.Deployment.ManifestUtilities.CompatibleFramework compatibleFramework) { }
        public void Clear() { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    public sealed partial class DeployManifest : Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest
    {
        public DeployManifest() { }
        public DeployManifest(string targetFrameworkMoniker) { }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.CompatibleFrameworkCollection CompatibleFrameworks { get { throw null; } }
        public bool CreateDesktopShortcut { get { throw null; } set { } }
        public string DeploymentUrl { get { throw null; } set { } }
        public bool DisallowUrlActivation { get { throw null; } set { } }
        public override Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference EntryPoint { get { throw null; } set { } }
        public string ErrorReportUrl { get { throw null; } set { } }
        public bool Install { get { throw null; } set { } }
        public bool MapFileExtensions { get { throw null; } set { } }
        public string MinimumRequiredVersion { get { throw null; } set { } }
        public string Product { get { throw null; } set { } }
        public string Publisher { get { throw null; } set { } }
        public string SuiteName { get { throw null; } set { } }
        public string SupportUrl { get { throw null; } set { } }
        public string TargetFrameworkMoniker { get { throw null; } set { } }
        public bool TrustUrlParameters { get { throw null; } set { } }
        public bool UpdateEnabled { get { throw null; } set { } }
        public int UpdateInterval { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.UpdateMode UpdateMode { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.UpdateUnit UpdateUnit { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlArrayAttribute("CompatibleFrameworks")]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.CompatibleFramework[] XmlCompatibleFrameworks { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlCreateDesktopShortcut { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlDeploymentUrl { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlDisallowUrlActivation { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlErrorReportUrl { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlInstall { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlMapFileExtensions { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlMinimumRequiredVersion { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlProduct { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlPublisher { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlSuiteName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlSupportUrl { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlTrustUrlParameters { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlUpdateEnabled { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlUpdateInterval { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlUpdateMode { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlUpdateUnit { get { throw null; } set { } }
        public override void Validate() { }
    }
    public sealed partial class FileAssociation
    {
        public FileAssociation() { }
        public string DefaultIcon { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string Extension { get { throw null; } set { } }
        public string ProgId { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlDefaultIcon { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlDescription { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlExtension { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlProgId { get { throw null; } set { } }
    }
    public sealed partial class FileAssociationCollection : System.Collections.IEnumerable
    {
        internal FileAssociationCollection() { }
        public int Count { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileAssociation this[int index] { get { throw null; } }
        public void Add(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileAssociation fileAssociation) { }
        public void Clear() { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    public sealed partial class FileReference : Microsoft.Build.Tasks.Deployment.ManifestUtilities.BaseReference
    {
        public FileReference() { }
        public FileReference(string path) { }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ComClass[] ComClasses { get { throw null; } }
        public bool IsDataFile { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] ProxyStubs { get { throw null; } }
        protected internal override string SortName { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.TypeLib[] TypeLibs { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlArrayAttribute("ComClasses")]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ComClass[] XmlComClasses { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlArrayAttribute("ProxyStubs")]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] XmlProxyStubs { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlArrayAttribute("TypeLibs")]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.TypeLib[] XmlTypeLibs { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlWriteableType { get { throw null; } set { } }
    }
    public sealed partial class FileReferenceCollection : System.Collections.IEnumerable
    {
        internal FileReferenceCollection() { }
        public int Count { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference this[int index] { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference Add(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference file) { throw null; }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference Add(string path) { throw null; }
        public void Clear() { }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference FindTargetPath(string targetPath) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public void Remove(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference file) { }
    }
    public abstract partial class Manifest
    {
        protected internal Manifest() { }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity AssemblyIdentity { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceCollection AssemblyReferences { get { throw null; } }
        public string Description { get { throw null; } set { } }
        public virtual Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference EntryPoint { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReferenceCollection FileReferences { get { throw null; } }
        public System.IO.Stream InputStream { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessageCollection OutputMessages { get { throw null; } }
        public bool ReadOnly { get { throw null; } set { } }
        public string SourcePath { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlElementAttribute("AssemblyIdentity")]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity XmlAssemblyIdentity { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlArrayAttribute("AssemblyReferences")]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference[] XmlAssemblyReferences { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlDescription { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlArrayAttribute("FileReferences")]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference[] XmlFileReferences { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlSchema { get { throw null; } set { } }
        public void ResolveFiles() { }
        public void ResolveFiles(string[] searchPaths) { }
        public override string ToString() { throw null; }
        public void UpdateFileInfo() { }
        public void UpdateFileInfo(string targetFrameworkVersion) { }
        public virtual void Validate() { }
        protected void ValidatePlatform() { }
    }
    public static partial class ManifestReader
    {
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(System.IO.Stream input, bool preserveStream) { throw null; }
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(string path, bool preserveStream) { throw null; }
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(string manifestType, System.IO.Stream input, bool preserveStream) { throw null; }
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(string manifestType, string path, bool preserveStream) { throw null; }
    }
    public static partial class ManifestWriter
    {
        public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { }
        public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest, System.IO.Stream output) { }
        public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest, string path) { }
        public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest, string path, string targetframeWorkVersion) { }
    }
    public sealed partial class OutputMessage
    {
        internal OutputMessage() { }
        public string Name { get { throw null; } }
        public string Text { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessageType Type { get { throw null; } }
        public string[] GetArguments() { throw null; }
    }
    public sealed partial class OutputMessageCollection : System.Collections.IEnumerable
    {
        internal OutputMessageCollection() { }
        public int ErrorCount { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessage this[int index] { get { throw null; } }
        public int WarningCount { get { throw null; } }
        public void Clear() { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    public enum OutputMessageType
    {
        Info = 0,
        Warning = 1,
        Error = 2,
    }
    public partial class ProxyStub
    {
        public ProxyStub() { }
        public string BaseInterface { get { throw null; } }
        public string IID { get { throw null; } }
        public string Name { get { throw null; } }
        public string NumMethods { get { throw null; } }
        public string TlbId { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlBaseInterface { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlIID { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlNumMethods { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlTlbId { get { throw null; } set { } }
    }
    public static partial class SecurityUtilities
    {
        public static System.Security.PermissionSet ComputeZonePermissionSet(string targetZone, System.Security.PermissionSet includedPermissionSet, string[] excludedPermissions) { throw null; }
        public static System.Security.PermissionSet IdentityListToPermissionSet(string[] ids) { throw null; }
        public static string[] PermissionSetToIdentityList(System.Security.PermissionSet permissionSet) { throw null; }
        public static void SignFile(System.Security.Cryptography.X509Certificates.X509Certificate2 cert, System.Uri timestampUrl, string path) { }
        public static void SignFile(string certPath, System.Security.SecureString certPassword, System.Uri timestampUrl, string path) { }
        public static void SignFile(string certThumbprint, System.Uri timestampUrl, string path) { }
        public static void SignFile(string certThumbprint, System.Uri timestampUrl, string path, string targetFrameworkVersion) { }
        public static System.Security.PermissionSet XmlToPermissionSet(System.Xml.XmlElement element) { throw null; }
    }
    public sealed partial class TrustInfo
    {
        public TrustInfo() { }
        public bool HasUnmanagedCodePermission { get { throw null; } }
        public bool IsFullTrust { get { throw null; } set { } }
        public System.Security.PermissionSet PermissionSet { get { throw null; } set { } }
        public bool PreserveFullTrustPermissionSet { get { throw null; } set { } }
        public string SameSiteAccess { get { throw null; } set { } }
        public void Clear() { }
        public void Read(System.IO.Stream input) { }
        public void Read(string path) { }
        public void ReadManifest(System.IO.Stream input) { }
        public void ReadManifest(string path) { }
        public override string ToString() { throw null; }
        public void Write(System.IO.Stream output) { }
        public void Write(string path) { }
        public void WriteManifest(System.IO.Stream output) { }
        public void WriteManifest(System.IO.Stream input, System.IO.Stream output) { }
        public void WriteManifest(string path) { }
    }
    public partial class TypeLib
    {
        public TypeLib() { }
        public string Flags { get { throw null; } }
        public string HelpDirectory { get { throw null; } }
        public string ResourceId { get { throw null; } }
        public string TlbId { get { throw null; } }
        public string Version { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlFlags { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlHelpDirectory { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlResourceId { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlTlbId { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlVersion { get { throw null; } set { } }
    }
    public enum UpdateMode
    {
        Background = 0,
        Foreground = 1,
    }
    public enum UpdateUnit
    {
        Hours = 0,
        Days = 1,
        Weeks = 2,
    }
    public partial class WindowClass
    {
        public WindowClass() { }
        public WindowClass(string name, bool versioned) { }
        public string Name { get { throw null; } }
        public bool Versioned { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string XmlVersioned { get { throw null; } set { } }
    }
}
namespace Microsoft.Build.Tasks.Hosting
{
    public partial interface IAnalyzerHostObject
    {
        bool SetAdditionalFiles(Microsoft.Build.Framework.ITaskItem[] additionalFiles);
        bool SetAnalyzers(Microsoft.Build.Framework.ITaskItem[] analyzers);
        bool SetRuleSet(string ruleSetFile);
    }
    public partial interface ICscHostObject : Microsoft.Build.Framework.ITaskHost
    {
        void BeginInitialization();
        bool Compile();
        bool EndInitialization(out string errorMessage, out int errorCode);
        bool IsDesignTime();
        bool IsUpToDate();
        bool SetAdditionalLibPaths(string[] additionalLibPaths);
        bool SetAddModules(string[] addModules);
        bool SetAllowUnsafeBlocks(bool allowUnsafeBlocks);
        bool SetBaseAddress(string baseAddress);
        bool SetCheckForOverflowUnderflow(bool checkForOverflowUnderflow);
        bool SetCodePage(int codePage);
        bool SetDebugType(string debugType);
        bool SetDefineConstants(string defineConstants);
        bool SetDelaySign(bool delaySignExplicitlySet, bool delaySign);
        bool SetDisabledWarnings(string disabledWarnings);
        bool SetDocumentationFile(string documentationFile);
        bool SetEmitDebugInformation(bool emitDebugInformation);
        bool SetErrorReport(string errorReport);
        bool SetFileAlignment(int fileAlignment);
        bool SetGenerateFullPaths(bool generateFullPaths);
        bool SetKeyContainer(string keyContainer);
        bool SetKeyFile(string keyFile);
        bool SetLangVersion(string langVersion);
        bool SetLinkResources(Microsoft.Build.Framework.ITaskItem[] linkResources);
        bool SetMainEntryPoint(string targetType, string mainEntryPoint);
        bool SetModuleAssemblyName(string moduleAssemblyName);
        bool SetNoConfig(bool noConfig);
        bool SetNoStandardLib(bool noStandardLib);
        bool SetOptimize(bool optimize);
        bool SetOutputAssembly(string outputAssembly);
        bool SetPdbFile(string pdbFile);
        bool SetPlatform(string platform);
        bool SetReferences(Microsoft.Build.Framework.ITaskItem[] references);
        bool SetResources(Microsoft.Build.Framework.ITaskItem[] resources);
        bool SetResponseFiles(Microsoft.Build.Framework.ITaskItem[] responseFiles);
        bool SetSources(Microsoft.Build.Framework.ITaskItem[] sources);
        bool SetTargetType(string targetType);
        bool SetTreatWarningsAsErrors(bool treatWarningsAsErrors);
        bool SetWarningLevel(int warningLevel);
        bool SetWarningsAsErrors(string warningsAsErrors);
        bool SetWarningsNotAsErrors(string warningsNotAsErrors);
        bool SetWin32Icon(string win32Icon);
        bool SetWin32Resource(string win32Resource);
    }
    public partial interface ICscHostObject2 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.ICscHostObject
    {
        bool SetWin32Manifest(string win32Manifest);
    }
    public partial interface ICscHostObject3 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.ICscHostObject, Microsoft.Build.Tasks.Hosting.ICscHostObject2
    {
        bool SetApplicationConfiguration(string applicationConfiguration);
    }
    public partial interface ICscHostObject4 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.ICscHostObject, Microsoft.Build.Tasks.Hosting.ICscHostObject2, Microsoft.Build.Tasks.Hosting.ICscHostObject3
    {
        bool SetHighEntropyVA(bool highEntropyVA);
        bool SetPlatformWith32BitPreference(string platformWith32BitPreference);
        bool SetSubsystemVersion(string subsystemVersion);
    }
    public partial interface IVbcHostObject : Microsoft.Build.Framework.ITaskHost
    {
        void BeginInitialization();
        bool Compile();
        void EndInitialization();
        bool IsDesignTime();
        bool IsUpToDate();
        bool SetAdditionalLibPaths(string[] additionalLibPaths);
        bool SetAddModules(string[] addModules);
        bool SetBaseAddress(string targetType, string baseAddress);
        bool SetCodePage(int codePage);
        bool SetDebugType(bool emitDebugInformation, string debugType);
        bool SetDefineConstants(string defineConstants);
        bool SetDelaySign(bool delaySign);
        bool SetDisabledWarnings(string disabledWarnings);
        bool SetDocumentationFile(string documentationFile);
        bool SetErrorReport(string errorReport);
        bool SetFileAlignment(int fileAlignment);
        bool SetGenerateDocumentation(bool generateDocumentation);
        bool SetImports(Microsoft.Build.Framework.ITaskItem[] importsList);
        bool SetKeyContainer(string keyContainer);
        bool SetKeyFile(string keyFile);
        bool SetLinkResources(Microsoft.Build.Framework.ITaskItem[] linkResources);
        bool SetMainEntryPoint(string mainEntryPoint);
        bool SetNoConfig(bool noConfig);
        bool SetNoStandardLib(bool noStandardLib);
        bool SetNoWarnings(bool noWarnings);
        bool SetOptimize(bool optimize);
        bool SetOptionCompare(string optionCompare);
        bool SetOptionExplicit(bool optionExplicit);
        bool SetOptionStrict(bool optionStrict);
        bool SetOptionStrictType(string optionStrictType);
        bool SetOutputAssembly(string outputAssembly);
        bool SetPlatform(string platform);
        bool SetReferences(Microsoft.Build.Framework.ITaskItem[] references);
        bool SetRemoveIntegerChecks(bool removeIntegerChecks);
        bool SetResources(Microsoft.Build.Framework.ITaskItem[] resources);
        bool SetResponseFiles(Microsoft.Build.Framework.ITaskItem[] responseFiles);
        bool SetRootNamespace(string rootNamespace);
        bool SetSdkPath(string sdkPath);
        bool SetSources(Microsoft.Build.Framework.ITaskItem[] sources);
        bool SetTargetCompactFramework(bool targetCompactFramework);
        bool SetTargetType(string targetType);
        bool SetTreatWarningsAsErrors(bool treatWarningsAsErrors);
        bool SetWarningsAsErrors(string warningsAsErrors);
        bool SetWarningsNotAsErrors(string warningsNotAsErrors);
        bool SetWin32Icon(string win32Icon);
        bool SetWin32Resource(string win32Resource);
    }
    public partial interface IVbcHostObject2 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.IVbcHostObject
    {
        bool SetModuleAssemblyName(string moduleAssemblyName);
        bool SetOptionInfer(bool optionInfer);
        bool SetWin32Manifest(string win32Manifest);
    }
    public partial interface IVbcHostObject3 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.IVbcHostObject, Microsoft.Build.Tasks.Hosting.IVbcHostObject2
    {
        bool SetLanguageVersion(string languageVersion);
    }
    public partial interface IVbcHostObject4 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.IVbcHostObject, Microsoft.Build.Tasks.Hosting.IVbcHostObject2, Microsoft.Build.Tasks.Hosting.IVbcHostObject3
    {
        bool SetVBRuntime(string VBRuntime);
    }
    public partial interface IVbcHostObject5 : Microsoft.Build.Framework.ITaskHost, Microsoft.Build.Tasks.Hosting.IVbcHostObject, Microsoft.Build.Tasks.Hosting.IVbcHostObject2, Microsoft.Build.Tasks.Hosting.IVbcHostObject3, Microsoft.Build.Tasks.Hosting.IVbcHostObject4
    {
        int CompileAsync(out System.IntPtr buildSucceededEvent, out System.IntPtr buildFailedEvent);
        int EndCompile(bool buildSuccess);
        Microsoft.Build.Tasks.Hosting.IVbcHostObjectFreeThreaded GetFreeThreadedHostObject();
        bool SetHighEntropyVA(bool highEntropyVA);
        bool SetPlatformWith32BitPreference(string platformWith32BitPreference);
        bool SetSubsystemVersion(string subsystemVersion);
    }
    public partial interface IVbcHostObjectFreeThreaded
    {
        bool Compile();
    }
}
namespace Microsoft.Build.Tasks.Xaml
{
    public partial class CommandLineArgumentRelation : Microsoft.Build.Tasks.Xaml.PropertyRelation
    {
        public CommandLineArgumentRelation(string argument, string value, bool required, string separator) { }
        public string Separator { get { throw null; } set { } }
    }
    public partial class CommandLineGenerator
    {
        public CommandLineGenerator(Microsoft.Build.Framework.XamlTypes.Rule rule, System.Collections.Generic.Dictionary<string, object> parameterValues) { }
        public string AdditionalOptions { get { throw null; } set { } }
        public string AlwaysAppend { get { throw null; } set { } }
        public string CommandLineTemplate { get { throw null; } set { } }
        public string GenerateCommandLine() { throw null; }
    }
    public partial class CommandLineToolSwitch
    {
        public CommandLineToolSwitch() { }
        public CommandLineToolSwitch(Microsoft.Build.Tasks.Xaml.CommandLineToolSwitchType toolType) { }
        public bool AllowMultipleValues { get { throw null; } set { } }
        public bool ArgumentRequired { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<System.Tuple<string, bool>> Arguments { get { throw null; } set { } }
        public bool BooleanValue { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string FallbackArgumentParameter { get { throw null; } set { } }
        public string FalseSuffix { get { throw null; } set { } }
        public bool IncludeInCommandLine { get { throw null; } set { } }
        public bool IsValid { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public int Number { get { throw null; } set { } }
        public System.Collections.Generic.LinkedList<System.Collections.Generic.KeyValuePair<string, string>> Overrides { get { throw null; } }
        public System.Collections.Generic.LinkedList<string> Parents { get { throw null; } }
        public bool Required { get { throw null; } set { } }
        public string ReverseSwitchValue { get { throw null; } set { } }
        public bool Reversible { get { throw null; } set { } }
        public string Separator { get { throw null; } set { } }
        public string[] StringList { get { throw null; } set { } }
        public string SwitchValue { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] TaskItemArray { get { throw null; } set { } }
        public string TrueSuffix { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Xaml.CommandLineToolSwitchType Type { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public enum CommandLineToolSwitchType
    {
        Boolean = 0,
        Integer = 1,
        String = 2,
        StringArray = 3,
        ITaskItemArray = 4,
    }
    public partial class PropertyRelation
    {
        public PropertyRelation() { }
        public PropertyRelation(string argument, string value, bool required) { }
        public string Argument { get { throw null; } set { } }
        public bool Required { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public abstract partial class XamlDataDrivenToolTask : Microsoft.Build.Utilities.ToolTask
    {
        protected XamlDataDrivenToolTask(string[] switchOrderList, System.Resources.ResourceManager taskResources) { }
        public virtual string[] AcceptableNonZeroExitCodes { get { throw null; } set { } }
        protected internal System.Collections.Generic.Dictionary<string, Microsoft.Build.Tasks.Xaml.CommandLineToolSwitch> ActiveToolSwitches { get { throw null; } }
        public System.Collections.Generic.Dictionary<string, Microsoft.Build.Tasks.Xaml.CommandLineToolSwitch> ActiveToolSwitchesValues { get { throw null; } set { } }
        public string AdditionalOptions { get { throw null; } set { } }
        public string CommandLineTemplate { get { throw null; } set { } }
        protected override System.Text.Encoding ResponseFileEncoding { get { throw null; } }
        public void AddActiveSwitchToolValue(Microsoft.Build.Tasks.Xaml.CommandLineToolSwitch switchToAdd) { }
        public string CreateSwitchValue(string propertyName, string baseSwitch, string separator, System.Tuple<string, bool>[] arguments) { throw null; }
        public override bool Execute() { throw null; }
        protected override string GenerateCommandLineCommands() { throw null; }
        protected override string GenerateFullPathToTool() { throw null; }
        protected override string GenerateResponseFileCommands() { throw null; }
        protected override bool HandleTaskExecutionErrors() { throw null; }
        public bool IsPropertySet(string propertyName) { throw null; }
        public string ReadSwitchMap(string propertyName, string[][] switchMap, string value) { throw null; }
        public int ReadSwitchMap2(string propertyName, System.Tuple<string, string, System.Tuple<string, bool>[]>[] switchMap, string value) { throw null; }
        public void ReplaceToolSwitch(Microsoft.Build.Tasks.Xaml.CommandLineToolSwitch switchToAdd) { }
        public bool ValidateInteger(string switchName, int min, int max, int value) { throw null; }
        protected override bool ValidateParameters() { throw null; }
    }
}
namespace System.Deployment.Internal.CodeSigning
{
    public sealed partial class RSAPKCS1SHA256SignatureDescription : System.Security.Cryptography.SignatureDescription
    {
        public RSAPKCS1SHA256SignatureDescription() { }
        public override System.Security.Cryptography.AsymmetricSignatureDeformatter CreateDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key) { throw null; }
        public override System.Security.Cryptography.AsymmetricSignatureFormatter CreateFormatter(System.Security.Cryptography.AsymmetricAlgorithm key) { throw null; }
    }
}
