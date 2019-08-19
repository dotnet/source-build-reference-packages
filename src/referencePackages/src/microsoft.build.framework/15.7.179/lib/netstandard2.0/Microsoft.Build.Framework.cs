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
[assembly: AssemblyTitle("Microsoft.Build.Framework")]
[assembly: AssemblyDescription("Microsoft.Build.Framework")]
[assembly: AssemblyDefaultAlias("Microsoft.Build.Framework")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("15.7.179.6572")]
[assembly: AssemblyInformationalVersion("15.7.179.6572 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("15.1.0.0")]




namespace Microsoft.Build.Framework
{
    public delegate void AnyEventHandler(object sender, Microsoft.Build.Framework.BuildEventArgs e);
    public partial struct BuildEngineResult
    {
        private object _dummy;
        private int _dummyPrimitive;
        public BuildEngineResult(bool result, System.Collections.Generic.List<System.Collections.Generic.IDictionary<string, Microsoft.Build.Framework.ITaskItem[]>> targetOutputsPerProject) { throw null; }
        public bool Result { get { throw null; } }
        public System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, Microsoft.Build.Framework.ITaskItem[]>> TargetOutputsPerProject { get { throw null; } }
    }
    public partial class BuildErrorEventArgs : Microsoft.Build.Framework.LazyFormattedBuildEventArgs
    {
        protected BuildErrorEventArgs() { }
        public BuildErrorEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName) { }
        public BuildErrorEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, System.DateTime eventTimestamp) { }
        public BuildErrorEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, System.DateTime eventTimestamp, params object[] messageArgs) { }
        public string Code { get { throw null; } }
        public int ColumnNumber { get { throw null; } }
        public int EndColumnNumber { get { throw null; } }
        public int EndLineNumber { get { throw null; } }
        public string File { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public string ProjectFile { get { throw null; } set { } }
        public string Subcategory { get { throw null; } }
    }
    public delegate void BuildErrorEventHandler(object sender, Microsoft.Build.Framework.BuildErrorEventArgs e);
    public abstract partial class BuildEventArgs : System.EventArgs
    {
        protected BuildEventArgs() { }
        protected BuildEventArgs(string message, string helpKeyword, string senderName) { }
        protected BuildEventArgs(string message, string helpKeyword, string senderName, System.DateTime eventTimestamp) { }
        public Microsoft.Build.Framework.BuildEventContext BuildEventContext { get { throw null; } set { } }
        public string HelpKeyword { get { throw null; } }
        public virtual string Message { get { throw null; } protected set { } }
        public string SenderName { get { throw null; } }
        public int ThreadId { get { throw null; } }
        public System.DateTime Timestamp { get { throw null; } }
    }
    public partial class BuildEventContext
    {
        public const int InvalidEvaluationId = -1;
        public const int InvalidNodeId = -2;
        public const int InvalidProjectContextId = -2;
        public const int InvalidProjectInstanceId = -1;
        public const int InvalidSubmissionId = -1;
        public const int InvalidTargetId = -1;
        public const int InvalidTaskId = -1;
        public BuildEventContext(int nodeId, int targetId, int projectContextId, int taskId) { }
        public BuildEventContext(int nodeId, int projectInstanceId, int projectContextId, int targetId, int taskId) { }
        public BuildEventContext(int submissionId, int nodeId, int projectInstanceId, int projectContextId, int targetId, int taskId) { }
        public BuildEventContext(int submissionId, int nodeId, int evaluationId, int projectInstanceId, int projectContextId, int targetId, int taskId) { }
        public long BuildRequestId { get { throw null; } }
        public int EvaluationId { get { throw null; } }
        public static Microsoft.Build.Framework.BuildEventContext Invalid { get { throw null; } }
        public int NodeId { get { throw null; } }
        public int ProjectContextId { get { throw null; } }
        public int ProjectInstanceId { get { throw null; } }
        public int SubmissionId { get { throw null; } }
        public int TargetId { get { throw null; } }
        public int TaskId { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Microsoft.Build.Framework.BuildEventContext left, Microsoft.Build.Framework.BuildEventContext right) { throw null; }
        public static bool operator !=(Microsoft.Build.Framework.BuildEventContext left, Microsoft.Build.Framework.BuildEventContext right) { throw null; }
    }
    public partial class BuildFinishedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs
    {
        protected BuildFinishedEventArgs() { }
        public BuildFinishedEventArgs(string message, string helpKeyword, bool succeeded) { }
        public BuildFinishedEventArgs(string message, string helpKeyword, bool succeeded, System.DateTime eventTimestamp) { }
        public BuildFinishedEventArgs(string message, string helpKeyword, bool succeeded, System.DateTime eventTimestamp, params object[] messageArgs) { }
        public bool Succeeded { get { throw null; } }
    }
    public delegate void BuildFinishedEventHandler(object sender, Microsoft.Build.Framework.BuildFinishedEventArgs e);
    public partial class BuildMessageEventArgs : Microsoft.Build.Framework.LazyFormattedBuildEventArgs
    {
        protected BuildMessageEventArgs() { }
        public BuildMessageEventArgs(string message, string helpKeyword, string senderName, Microsoft.Build.Framework.MessageImportance importance) { }
        public BuildMessageEventArgs(string message, string helpKeyword, string senderName, Microsoft.Build.Framework.MessageImportance importance, System.DateTime eventTimestamp) { }
        public BuildMessageEventArgs(string message, string helpKeyword, string senderName, Microsoft.Build.Framework.MessageImportance importance, System.DateTime eventTimestamp, params object[] messageArgs) { }
        public BuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, Microsoft.Build.Framework.MessageImportance importance) { }
        public BuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, Microsoft.Build.Framework.MessageImportance importance, System.DateTime eventTimestamp) { }
        public BuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, Microsoft.Build.Framework.MessageImportance importance, System.DateTime eventTimestamp, params object[] messageArgs) { }
        public string Code { get { throw null; } }
        public int ColumnNumber { get { throw null; } }
        public int EndColumnNumber { get { throw null; } }
        public int EndLineNumber { get { throw null; } }
        public string File { get { throw null; } }
        public Microsoft.Build.Framework.MessageImportance Importance { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public string ProjectFile { get { throw null; } set { } }
        public string Subcategory { get { throw null; } }
    }
    public delegate void BuildMessageEventHandler(object sender, Microsoft.Build.Framework.BuildMessageEventArgs e);
    public partial class BuildStartedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs
    {
        protected BuildStartedEventArgs() { }
        public BuildStartedEventArgs(string message, string helpKeyword) { }
        public BuildStartedEventArgs(string message, string helpKeyword, System.Collections.Generic.IDictionary<string, string> environmentOfBuild) { }
        public BuildStartedEventArgs(string message, string helpKeyword, System.DateTime eventTimestamp) { }
        public BuildStartedEventArgs(string message, string helpKeyword, System.DateTime eventTimestamp, params object[] messageArgs) { }
        public System.Collections.Generic.IDictionary<string, string> BuildEnvironment { get { throw null; } }
    }
    public delegate void BuildStartedEventHandler(object sender, Microsoft.Build.Framework.BuildStartedEventArgs e);
    public abstract partial class BuildStatusEventArgs : Microsoft.Build.Framework.LazyFormattedBuildEventArgs
    {
        protected BuildStatusEventArgs() { }
        protected BuildStatusEventArgs(string message, string helpKeyword, string senderName) { }
        protected BuildStatusEventArgs(string message, string helpKeyword, string senderName, System.DateTime eventTimestamp) { }
        protected BuildStatusEventArgs(string message, string helpKeyword, string senderName, System.DateTime eventTimestamp, params object[] messageArgs) { }
    }
    public delegate void BuildStatusEventHandler(object sender, Microsoft.Build.Framework.BuildStatusEventArgs e);
    public partial class BuildWarningEventArgs : Microsoft.Build.Framework.LazyFormattedBuildEventArgs
    {
        protected BuildWarningEventArgs() { }
        public BuildWarningEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName) { }
        public BuildWarningEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, System.DateTime eventTimestamp) { }
        public BuildWarningEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, System.DateTime eventTimestamp, params object[] messageArgs) { }
        public string Code { get { throw null; } }
        public int ColumnNumber { get { throw null; } }
        public int EndColumnNumber { get { throw null; } }
        public int EndLineNumber { get { throw null; } }
        public string File { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public string ProjectFile { get { throw null; } set { } }
        public string Subcategory { get { throw null; } }
    }
    public delegate void BuildWarningEventHandler(object sender, Microsoft.Build.Framework.BuildWarningEventArgs e);
    public partial class CriticalBuildMessageEventArgs : Microsoft.Build.Framework.BuildMessageEventArgs
    {
        protected CriticalBuildMessageEventArgs() { }
        public CriticalBuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName) { }
        public CriticalBuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, System.DateTime eventTimestamp) { }
        public CriticalBuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, System.DateTime eventTimestamp, params object[] messageArgs) { }
    }
    public abstract partial class CustomBuildEventArgs : Microsoft.Build.Framework.LazyFormattedBuildEventArgs
    {
        protected CustomBuildEventArgs() { }
        protected CustomBuildEventArgs(string message, string helpKeyword, string senderName) { }
        protected CustomBuildEventArgs(string message, string helpKeyword, string senderName, System.DateTime eventTimestamp) { }
        protected CustomBuildEventArgs(string message, string helpKeyword, string senderName, System.DateTime eventTimestamp, params object[] messageArgs) { }
    }
    public delegate void CustomBuildEventHandler(object sender, Microsoft.Build.Framework.CustomBuildEventArgs e);
    public partial class ExternalProjectFinishedEventArgs : Microsoft.Build.Framework.CustomBuildEventArgs
    {
        protected ExternalProjectFinishedEventArgs() { }
        public ExternalProjectFinishedEventArgs(string message, string helpKeyword, string senderName, string projectFile, bool succeeded) { }
        public ExternalProjectFinishedEventArgs(string message, string helpKeyword, string senderName, string projectFile, bool succeeded, System.DateTime eventTimestamp) { }
        public string ProjectFile { get { throw null; } }
        public bool Succeeded { get { throw null; } }
    }
    public partial class ExternalProjectStartedEventArgs : Microsoft.Build.Framework.CustomBuildEventArgs
    {
        protected ExternalProjectStartedEventArgs() { }
        public ExternalProjectStartedEventArgs(string message, string helpKeyword, string senderName, string projectFile, string targetNames) { }
        public ExternalProjectStartedEventArgs(string message, string helpKeyword, string senderName, string projectFile, string targetNames, System.DateTime eventTimestamp) { }
        public string ProjectFile { get { throw null; } }
        public string TargetNames { get { throw null; } }
    }
    public partial interface IBuildEngine
    {
        int ColumnNumberOfTaskNode { get; }
        bool ContinueOnError { get; }
        int LineNumberOfTaskNode { get; }
        string ProjectFileOfTaskNode { get; }
        bool BuildProjectFile(string projectFileName, string[] targetNames, System.Collections.IDictionary globalProperties, System.Collections.IDictionary targetOutputs);
        void LogCustomEvent(Microsoft.Build.Framework.CustomBuildEventArgs e);
        void LogErrorEvent(Microsoft.Build.Framework.BuildErrorEventArgs e);
        void LogMessageEvent(Microsoft.Build.Framework.BuildMessageEventArgs e);
        void LogWarningEvent(Microsoft.Build.Framework.BuildWarningEventArgs e);
    }
    public partial interface IBuildEngine2 : Microsoft.Build.Framework.IBuildEngine
    {
        bool IsRunningMultipleNodes { get; }
        bool BuildProjectFile(string projectFileName, string[] targetNames, System.Collections.IDictionary globalProperties, System.Collections.IDictionary targetOutputs, string toolsVersion);
        bool BuildProjectFilesInParallel(string[] projectFileNames, string[] targetNames, System.Collections.IDictionary[] globalProperties, System.Collections.IDictionary[] targetOutputsPerProject, string[] toolsVersion, bool useResultsCache, bool unloadProjectsOnCompletion);
    }
    public partial interface IBuildEngine3 : Microsoft.Build.Framework.IBuildEngine, Microsoft.Build.Framework.IBuildEngine2
    {
        Microsoft.Build.Framework.BuildEngineResult BuildProjectFilesInParallel(string[] projectFileNames, string[] targetNames, System.Collections.IDictionary[] globalProperties, System.Collections.Generic.IList<string>[] removeGlobalProperties, string[] toolsVersion, bool returnTargetOutputs);
        void Reacquire();
        void Yield();
    }
    public partial interface IBuildEngine4 : Microsoft.Build.Framework.IBuildEngine, Microsoft.Build.Framework.IBuildEngine2, Microsoft.Build.Framework.IBuildEngine3
    {
        object GetRegisteredTaskObject(object key, Microsoft.Build.Framework.RegisteredTaskObjectLifetime lifetime);
        void RegisterTaskObject(object key, object obj, Microsoft.Build.Framework.RegisteredTaskObjectLifetime lifetime, bool allowEarlyCollection);
        object UnregisterTaskObject(object key, Microsoft.Build.Framework.RegisteredTaskObjectLifetime lifetime);
    }
    public partial interface IBuildEngine5 : Microsoft.Build.Framework.IBuildEngine, Microsoft.Build.Framework.IBuildEngine2, Microsoft.Build.Framework.IBuildEngine3, Microsoft.Build.Framework.IBuildEngine4
    {
        void LogTelemetry(string eventName, System.Collections.Generic.IDictionary<string, string> properties);
    }
    public partial interface ICancelableTask : Microsoft.Build.Framework.ITask
    {
        void Cancel();
    }
    public partial interface IEventRedirector
    {
        void ForwardEvent(Microsoft.Build.Framework.BuildEventArgs buildEvent);
    }
    public partial interface IEventSource
    {
        event Microsoft.Build.Framework.AnyEventHandler AnyEventRaised;
        event Microsoft.Build.Framework.BuildFinishedEventHandler BuildFinished;
        event Microsoft.Build.Framework.BuildStartedEventHandler BuildStarted;
        event Microsoft.Build.Framework.CustomBuildEventHandler CustomEventRaised;
        event Microsoft.Build.Framework.BuildErrorEventHandler ErrorRaised;
        event Microsoft.Build.Framework.BuildMessageEventHandler MessageRaised;
        event Microsoft.Build.Framework.ProjectFinishedEventHandler ProjectFinished;
        event Microsoft.Build.Framework.ProjectStartedEventHandler ProjectStarted;
        event Microsoft.Build.Framework.BuildStatusEventHandler StatusEventRaised;
        event Microsoft.Build.Framework.TargetFinishedEventHandler TargetFinished;
        event Microsoft.Build.Framework.TargetStartedEventHandler TargetStarted;
        event Microsoft.Build.Framework.TaskFinishedEventHandler TaskFinished;
        event Microsoft.Build.Framework.TaskStartedEventHandler TaskStarted;
        event Microsoft.Build.Framework.BuildWarningEventHandler WarningRaised;
    }
    public partial interface IEventSource2 : Microsoft.Build.Framework.IEventSource
    {
        event Microsoft.Build.Framework.TelemetryEventHandler TelemetryLogged;
    }
    public partial interface IForwardingLogger : Microsoft.Build.Framework.ILogger, Microsoft.Build.Framework.INodeLogger
    {
        Microsoft.Build.Framework.IEventRedirector BuildEventRedirector { get; set; }
        int NodeId { get; set; }
    }
    public partial interface IGeneratedTask : Microsoft.Build.Framework.ITask
    {
        object GetPropertyValue(Microsoft.Build.Framework.TaskPropertyInfo property);
        void SetPropertyValue(Microsoft.Build.Framework.TaskPropertyInfo property, object value);
    }
    public partial interface ILogger
    {
        string Parameters { get; set; }
        Microsoft.Build.Framework.LoggerVerbosity Verbosity { get; set; }
        void Initialize(Microsoft.Build.Framework.IEventSource eventSource);
        void Shutdown();
    }
    public partial interface INodeLogger : Microsoft.Build.Framework.ILogger
    {
        void Initialize(Microsoft.Build.Framework.IEventSource eventSource, int nodeCount);
    }
    public partial interface IProjectElement
    {
        string ElementName { get; }
        string OuterElement { get; }
    }
    public partial interface ITask
    {
        Microsoft.Build.Framework.IBuildEngine BuildEngine { get; set; }
        Microsoft.Build.Framework.ITaskHost HostObject { get; set; }
        bool Execute();
    }
    public partial interface ITaskFactory
    {
        string FactoryName { get; }
        System.Type TaskType { get; }
        void CleanupTask(Microsoft.Build.Framework.ITask task);
        Microsoft.Build.Framework.ITask CreateTask(Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost);
        Microsoft.Build.Framework.TaskPropertyInfo[] GetTaskParameters();
        bool Initialize(string taskName, System.Collections.Generic.IDictionary<string, Microsoft.Build.Framework.TaskPropertyInfo> parameterGroup, string taskBody, Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost);
    }
    public partial interface ITaskFactory2 : Microsoft.Build.Framework.ITaskFactory
    {
        Microsoft.Build.Framework.ITask CreateTask(Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost, System.Collections.Generic.IDictionary<string, string> taskIdentityParameters);
        bool Initialize(string taskName, System.Collections.Generic.IDictionary<string, string> factoryIdentityParameters, System.Collections.Generic.IDictionary<string, Microsoft.Build.Framework.TaskPropertyInfo> parameterGroup, string taskBody, Microsoft.Build.Framework.IBuildEngine taskFactoryLoggingHost);
    }
    public partial interface ITaskHost
    {
    }
    public partial interface ITaskItem
    {
        string ItemSpec { get; set; }
        int MetadataCount { get; }
        System.Collections.ICollection MetadataNames { get; }
        System.Collections.IDictionary CloneCustomMetadata();
        void CopyMetadataTo(Microsoft.Build.Framework.ITaskItem destinationItem);
        string GetMetadata(string metadataName);
        void RemoveMetadata(string metadataName);
        void SetMetadata(string metadataName, string metadataValue);
    }
    public partial interface ITaskItem2 : Microsoft.Build.Framework.ITaskItem
    {
        string EvaluatedIncludeEscaped { get; set; }
        System.Collections.IDictionary CloneCustomMetadataEscaped();
        string GetMetadataValueEscaped(string metadataName);
        void SetMetadataValueLiteral(string metadataName, string metadataValue);
    }
    public partial class LazyFormattedBuildEventArgs : Microsoft.Build.Framework.BuildEventArgs
    {
        protected LazyFormattedBuildEventArgs() { }
        public LazyFormattedBuildEventArgs(string message, string helpKeyword, string senderName) { }
        public LazyFormattedBuildEventArgs(string message, string helpKeyword, string senderName, System.DateTime eventTimestamp, params object[] messageArgs) { }
        public override string Message { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=true)]
    public sealed partial class LoadInSeparateAppDomainAttribute : System.Attribute
    {
        public LoadInSeparateAppDomainAttribute() { }
    }
    public partial class LoggerException : System.Exception
    {
        public LoggerException() { }
        protected LoggerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public LoggerException(string message) { }
        public LoggerException(string message, System.Exception innerException) { }
        public LoggerException(string message, System.Exception innerException, string errorCode, string helpKeyword) { }
        public string ErrorCode { get { throw null; } }
        public string HelpKeyword { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public enum LoggerVerbosity
    {
        Detailed = 3,
        Diagnostic = 4,
        Minimal = 1,
        Normal = 2,
        Quiet = 0,
    }
    public enum MessageImportance
    {
        High = 0,
        Low = 2,
        Normal = 1,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=false)]
    public sealed partial class OutputAttribute : System.Attribute
    {
        public OutputAttribute() { }
    }
    public sealed partial class ProjectEvaluationFinishedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs
    {
        public ProjectEvaluationFinishedEventArgs() { }
        public ProjectEvaluationFinishedEventArgs(string message, params object[] messageArgs) { }
        public System.Nullable<Microsoft.Build.Framework.Profiler.ProfilerResult> ProfilerResult { get { throw null; } set { } }
        public string ProjectFile { get { throw null; } set { } }
    }
    public partial class ProjectEvaluationStartedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs
    {
        public ProjectEvaluationStartedEventArgs() { }
        public ProjectEvaluationStartedEventArgs(string message, params object[] messageArgs) { }
        public string ProjectFile { get { throw null; } set { } }
    }
    public partial class ProjectFinishedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs
    {
        protected ProjectFinishedEventArgs() { }
        public ProjectFinishedEventArgs(string message, string helpKeyword, string projectFile, bool succeeded) { }
        public ProjectFinishedEventArgs(string message, string helpKeyword, string projectFile, bool succeeded, System.DateTime eventTimestamp) { }
        public string ProjectFile { get { throw null; } }
        public bool Succeeded { get { throw null; } }
    }
    public delegate void ProjectFinishedEventHandler(object sender, Microsoft.Build.Framework.ProjectFinishedEventArgs e);
    public partial class ProjectImportedEventArgs : Microsoft.Build.Framework.BuildMessageEventArgs
    {
        public ProjectImportedEventArgs() { }
        public ProjectImportedEventArgs(int lineNumber, int columnNumber, string message, params object[] messageArgs) { }
        public string ImportedProjectFile { get { throw null; } set { } }
        public bool ImportIgnored { get { throw null; } set { } }
        public string UnexpandedProject { get { throw null; } set { } }
    }
    public partial class ProjectStartedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs
    {
        public const int InvalidProjectId = -1;
        protected ProjectStartedEventArgs() { }
        public ProjectStartedEventArgs(int projectId, string message, string helpKeyword, string projectFile, string targetNames, System.Collections.IEnumerable properties, System.Collections.IEnumerable items, Microsoft.Build.Framework.BuildEventContext parentBuildEventContext) { }
        public ProjectStartedEventArgs(int projectId, string message, string helpKeyword, string projectFile, string targetNames, System.Collections.IEnumerable properties, System.Collections.IEnumerable items, Microsoft.Build.Framework.BuildEventContext parentBuildEventContext, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion) { }
        public ProjectStartedEventArgs(int projectId, string message, string helpKeyword, string projectFile, string targetNames, System.Collections.IEnumerable properties, System.Collections.IEnumerable items, Microsoft.Build.Framework.BuildEventContext parentBuildEventContext, System.DateTime eventTimestamp) { }
        public ProjectStartedEventArgs(string message, string helpKeyword, string projectFile, string targetNames, System.Collections.IEnumerable properties, System.Collections.IEnumerable items) { }
        public ProjectStartedEventArgs(string message, string helpKeyword, string projectFile, string targetNames, System.Collections.IEnumerable properties, System.Collections.IEnumerable items, System.DateTime eventTimestamp) { }
        public System.Collections.Generic.IDictionary<string, string> GlobalProperties { get { throw null; } }
        public System.Collections.IEnumerable Items { get { throw null; } }
        public Microsoft.Build.Framework.BuildEventContext ParentProjectBuildEventContext { get { throw null; } }
        public string ProjectFile { get { throw null; } }
        public int ProjectId { get { throw null; } }
        public System.Collections.IEnumerable Properties { get { throw null; } }
        public string TargetNames { get { throw null; } }
        public string ToolsVersion { get { throw null; } }
    }
    public delegate void ProjectStartedEventHandler(object sender, Microsoft.Build.Framework.ProjectStartedEventArgs e);
    public enum RegisteredTaskObjectLifetime
    {
        AppDomain = 1,
        Build = 0,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=false)]
    public sealed partial class RequiredAttribute : System.Attribute
    {
        public RequiredAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=false)]
    public sealed partial class RequiredRuntimeAttribute : System.Attribute
    {
        public RequiredRuntimeAttribute(string runtimeVersion) { }
        public string RuntimeVersion { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=false)]
    public sealed partial class RunInMTAAttribute : System.Attribute
    {
        public RunInMTAAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false, Inherited=false)]
    public sealed partial class RunInSTAAttribute : System.Attribute
    {
        public RunInSTAAttribute() { }
    }
    public abstract partial class SdkLogger
    {
        protected SdkLogger() { }
        public abstract void LogMessage(string message, Microsoft.Build.Framework.MessageImportance messageImportance = Microsoft.Build.Framework.MessageImportance.Low);
    }
    public sealed partial class SdkReference : System.IEquatable<Microsoft.Build.Framework.SdkReference>
    {
        public SdkReference(string name, string version, string minimumVersion) { }
        public string MinimumVersion { get { throw null; } }
        public string Name { get { throw null; } }
        public string Version { get { throw null; } }
        public bool Equals(Microsoft.Build.Framework.SdkReference other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string sdk, out Microsoft.Build.Framework.SdkReference sdkReference) { throw null; }
    }
    public abstract partial class SdkResolver
    {
        protected SdkResolver() { }
        public abstract string Name { get; }
        public abstract int Priority { get; }
        public abstract Microsoft.Build.Framework.SdkResult Resolve(Microsoft.Build.Framework.SdkReference sdkReference, Microsoft.Build.Framework.SdkResolverContext resolverContext, Microsoft.Build.Framework.SdkResultFactory factory);
    }
    public abstract partial class SdkResolverContext
    {
        protected SdkResolverContext() { }
        public virtual Microsoft.Build.Framework.SdkLogger Logger { get { throw null; } protected set { } }
        public virtual System.Version MSBuildVersion { get { throw null; } protected set { } }
        public virtual string ProjectFilePath { get { throw null; } protected set { } }
        public virtual string SolutionFilePath { get { throw null; } protected set { } }
        public virtual object State { get { throw null; } set { } }
    }
    public abstract partial class SdkResult
    {
        protected SdkResult() { }
        public bool Success { get { throw null; } protected set { } }
    }
    public abstract partial class SdkResultFactory
    {
        protected SdkResultFactory() { }
        public abstract Microsoft.Build.Framework.SdkResult IndicateFailure(System.Collections.Generic.IEnumerable<string> errors, System.Collections.Generic.IEnumerable<string> warnings = null);
        public abstract Microsoft.Build.Framework.SdkResult IndicateSuccess(string path, string version, System.Collections.Generic.IEnumerable<string> warnings = null);
    }
    public enum TargetBuiltReason
    {
        AfterTargets = 3,
        BeforeTargets = 1,
        DependsOn = 2,
        None = 0,
    }
    public partial class TargetFinishedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs
    {
        protected TargetFinishedEventArgs() { }
        public TargetFinishedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, bool succeeded) { }
        public TargetFinishedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, bool succeeded, System.Collections.IEnumerable targetOutputs) { }
        public TargetFinishedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, bool succeeded, System.DateTime eventTimestamp, System.Collections.IEnumerable targetOutputs) { }
        public string ProjectFile { get { throw null; } }
        public bool Succeeded { get { throw null; } }
        public string TargetFile { get { throw null; } }
        public string TargetName { get { throw null; } }
        public System.Collections.IEnumerable TargetOutputs { get { throw null; } set { } }
    }
    public delegate void TargetFinishedEventHandler(object sender, Microsoft.Build.Framework.TargetFinishedEventArgs e);
    public partial class TargetSkippedEventArgs : Microsoft.Build.Framework.BuildMessageEventArgs
    {
        public TargetSkippedEventArgs() { }
        public TargetSkippedEventArgs(string message, params object[] messageArgs) { }
        public Microsoft.Build.Framework.TargetBuiltReason BuildReason { get { throw null; } set { } }
        public string ParentTarget { get { throw null; } set { } }
        public string TargetFile { get { throw null; } set { } }
        public string TargetName { get { throw null; } set { } }
    }
    public partial class TargetStartedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs
    {
        protected TargetStartedEventArgs() { }
        public TargetStartedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile) { }
        public TargetStartedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, string parentTarget, Microsoft.Build.Framework.TargetBuiltReason buildReason, System.DateTime eventTimestamp) { }
        public TargetStartedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, string parentTarget, System.DateTime eventTimestamp) { }
        public Microsoft.Build.Framework.TargetBuiltReason BuildReason { get { throw null; } }
        public string ParentTarget { get { throw null; } }
        public string ProjectFile { get { throw null; } }
        public string TargetFile { get { throw null; } }
        public string TargetName { get { throw null; } }
    }
    public delegate void TargetStartedEventHandler(object sender, Microsoft.Build.Framework.TargetStartedEventArgs e);
    public partial class TaskCommandLineEventArgs : Microsoft.Build.Framework.BuildMessageEventArgs
    {
        protected TaskCommandLineEventArgs() { }
        public TaskCommandLineEventArgs(string commandLine, string taskName, Microsoft.Build.Framework.MessageImportance importance) { }
        public TaskCommandLineEventArgs(string commandLine, string taskName, Microsoft.Build.Framework.MessageImportance importance, System.DateTime eventTimestamp) { }
        public string CommandLine { get { throw null; } }
        public string TaskName { get { throw null; } }
    }
    public partial class TaskFinishedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs
    {
        protected TaskFinishedEventArgs() { }
        public TaskFinishedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName, bool succeeded) { }
        public TaskFinishedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName, bool succeeded, System.DateTime eventTimestamp) { }
        public string ProjectFile { get { throw null; } }
        public bool Succeeded { get { throw null; } }
        public string TaskFile { get { throw null; } }
        public string TaskName { get { throw null; } }
    }
    public delegate void TaskFinishedEventHandler(object sender, Microsoft.Build.Framework.TaskFinishedEventArgs e);
    public partial class TaskPropertyInfo
    {
        public TaskPropertyInfo(string name, System.Type typeOfParameter, bool output, bool required) { }
        public string Name { get { throw null; } }
        public bool Output { get { throw null; } }
        public System.Type PropertyType { get { throw null; } }
        public bool Required { get { throw null; } }
    }
    public partial class TaskStartedEventArgs : Microsoft.Build.Framework.BuildStatusEventArgs
    {
        protected TaskStartedEventArgs() { }
        public TaskStartedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName) { }
        public TaskStartedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName, System.DateTime eventTimestamp) { }
        public string ProjectFile { get { throw null; } }
        public string TaskFile { get { throw null; } }
        public string TaskName { get { throw null; } }
    }
    public delegate void TaskStartedEventHandler(object sender, Microsoft.Build.Framework.TaskStartedEventArgs e);
    public sealed partial class TelemetryEventArgs : Microsoft.Build.Framework.BuildEventArgs
    {
        public TelemetryEventArgs() { }
        public string EventName { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } set { } }
    }
    public delegate void TelemetryEventHandler(object sender, Microsoft.Build.Framework.TelemetryEventArgs e);
}
namespace Microsoft.Build.Framework.Profiler
{
    public partial struct EvaluationLocation
    {
        private object _dummy;
        private int _dummyPrimitive;
        public EvaluationLocation(Microsoft.Build.Framework.Profiler.EvaluationPass evaluationPass, string evaluationPassDescription, string file, System.Nullable<int> line, string elementName, string elementDescription, Microsoft.Build.Framework.Profiler.EvaluationLocationKind kind) { throw null; }
        public EvaluationLocation(long id, System.Nullable<long> parentId, Microsoft.Build.Framework.Profiler.EvaluationPass evaluationPass, string evaluationPassDescription, string file, System.Nullable<int> line, string elementName, string elementDescription, Microsoft.Build.Framework.Profiler.EvaluationLocationKind kind) { throw null; }
        public EvaluationLocation(System.Nullable<long> parentId, Microsoft.Build.Framework.Profiler.EvaluationPass evaluationPass, string evaluationPassDescription, string file, System.Nullable<int> line, string elementName, string elementDescription, Microsoft.Build.Framework.Profiler.EvaluationLocationKind kind) { throw null; }
        public string ElementDescription { get { throw null; } }
        public string ElementName { get { throw null; } }
        public static Microsoft.Build.Framework.Profiler.EvaluationLocation EmptyLocation { get { throw null; } }
        public Microsoft.Build.Framework.Profiler.EvaluationPass EvaluationPass { get { throw null; } }
        public string EvaluationPassDescription { get { throw null; } }
        public string File { get { throw null; } }
        public long Id { get { throw null; } }
        public bool IsEvaluationPass { get { throw null; } }
        public Microsoft.Build.Framework.Profiler.EvaluationLocationKind Kind { get { throw null; } }
        public System.Nullable<int> Line { get { throw null; } }
        public System.Nullable<long> ParentId { get { throw null; } }
        public static Microsoft.Build.Framework.Profiler.EvaluationLocation CreateLocationForAggregatedGlob() { throw null; }
        public static Microsoft.Build.Framework.Profiler.EvaluationLocation CreateLocationForCondition(System.Nullable<long> parentId, Microsoft.Build.Framework.Profiler.EvaluationPass evaluationPass, string evaluationDescription, string file, System.Nullable<int> line, string condition) { throw null; }
        public static Microsoft.Build.Framework.Profiler.EvaluationLocation CreateLocationForGlob(System.Nullable<long> parentId, Microsoft.Build.Framework.Profiler.EvaluationPass evaluationPass, string evaluationDescription, string file, System.Nullable<int> line, string globDescription) { throw null; }
        public static Microsoft.Build.Framework.Profiler.EvaluationLocation CreateLocationForProject(System.Nullable<long> parentId, Microsoft.Build.Framework.Profiler.EvaluationPass evaluationPass, string evaluationDescription, string file, System.Nullable<int> line, Microsoft.Build.Framework.IProjectElement element) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
        public Microsoft.Build.Framework.Profiler.EvaluationLocation WithEvaluationPass(Microsoft.Build.Framework.Profiler.EvaluationPass evaluationPass, string passDescription = null) { throw null; }
        public Microsoft.Build.Framework.Profiler.EvaluationLocation WithFile(string file) { throw null; }
        public Microsoft.Build.Framework.Profiler.EvaluationLocation WithFileLineAndCondition(string file, System.Nullable<int> line, string condition) { throw null; }
        public Microsoft.Build.Framework.Profiler.EvaluationLocation WithFileLineAndElement(string file, System.Nullable<int> line, Microsoft.Build.Framework.IProjectElement element) { throw null; }
        public Microsoft.Build.Framework.Profiler.EvaluationLocation WithGlob(string globDescription) { throw null; }
        public Microsoft.Build.Framework.Profiler.EvaluationLocation WithParentId(System.Nullable<long> parentId) { throw null; }
    }
    public enum EvaluationLocationKind : byte
    {
        Condition = (byte)1,
        Element = (byte)0,
        Glob = (byte)2,
    }
    public enum EvaluationPass : byte
    {
        InitialProperties = (byte)2,
        ItemDefinitionGroups = (byte)4,
        Items = (byte)5,
        LazyItems = (byte)6,
        Properties = (byte)3,
        Targets = (byte)8,
        TotalEvaluation = (byte)0,
        TotalGlobbing = (byte)1,
        UsingTasks = (byte)7,
    }
    public partial struct ProfiledLocation
    {
        private int _dummyPrimitive;
        public ProfiledLocation(System.TimeSpan inclusiveTime, System.TimeSpan exclusiveTime, int numberOfHits) { throw null; }
        public System.TimeSpan ExclusiveTime { get { throw null; } }
        public System.TimeSpan InclusiveTime { get { throw null; } }
        public int NumberOfHits { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial struct ProfilerResult
    {
        private object _dummy;
        public ProfilerResult(System.Collections.Generic.IDictionary<Microsoft.Build.Framework.Profiler.EvaluationLocation, Microsoft.Build.Framework.Profiler.ProfiledLocation> profiledLocations) { throw null; }
        public System.Collections.Generic.IReadOnlyDictionary<Microsoft.Build.Framework.Profiler.EvaluationLocation, Microsoft.Build.Framework.Profiler.ProfiledLocation> ProfiledLocations { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
}
