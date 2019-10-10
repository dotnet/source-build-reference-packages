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
[assembly: AssemblyTitle("NuGet.Common")]
[assembly: AssemblyDescription("NuGet.Common")]
[assembly: AssemblyDefaultAlias("NuGet.Common")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("5.1.0.6013")]
[assembly: AssemblyInformationalVersion("5.1.0.6013 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("5.1.0.5")]




namespace NuGet.Common
{
    public static partial class ActivityCorrelationId
    {
        public static string Current { get { throw null; } }
        public static void Clear() { }
        public static void StartNew() { }
    }
    public partial class AggregateEnumerableAsync<T> : NuGet.Common.IEnumerableAsync<T>
    {
        public AggregateEnumerableAsync(System.Collections.Generic.IList<NuGet.Common.IEnumerableAsync<T>> asyncEnumerables, System.Collections.Generic.IComparer<T> comparer, System.Collections.Generic.IEqualityComparer<T> equalityComparer) { }
        public NuGet.Common.IEnumeratorAsync<T> GetEnumeratorAsync() { throw null; }
    }
    public partial class AggregateEnumeratorAsync<T> : NuGet.Common.IEnumeratorAsync<T>
    {
        public AggregateEnumeratorAsync(System.Collections.Generic.IList<NuGet.Common.IEnumerableAsync<T>> asyncEnumerables, System.Collections.Generic.IComparer<T> orderingComparer, System.Collections.Generic.IEqualityComparer<T> equalityComparer) { }
        public T Current { get { throw null; } }
        public System.Threading.Tasks.Task<bool> MoveNextAsync() { throw null; }
    }
    public static partial class AsyncLazy
    {
        public static NuGet.Common.AsyncLazy<T> New<T>(System.Func<System.Threading.Tasks.Task<T>> asyncValueFactory) { throw null; }
        public static NuGet.Common.AsyncLazy<T> New<T>(System.Func<T> valueFactory) { throw null; }
        public static NuGet.Common.AsyncLazy<T> New<T>(System.Lazy<System.Threading.Tasks.Task<T>> inner) { throw null; }
        public static NuGet.Common.AsyncLazy<T> New<T>(T innerData) { throw null; }
    }
    [System.CLSCompliantAttribute(true)]
    public partial class AsyncLazy<T>
    {
        public AsyncLazy(System.Func<System.Threading.Tasks.Task<T>> valueFactory) { }
        public AsyncLazy(System.Lazy<System.Threading.Tasks.Task<T>> inner) { }
        public System.Runtime.CompilerServices.TaskAwaiter<T> GetAwaiter() { throw null; }
        public static implicit operator System.Lazy<System.Threading.Tasks.Task<T>> (NuGet.Common.AsyncLazy<T> outer) { throw null; }
    }
    public partial class AuthTypeFilteredCredentials : System.Net.ICredentials
    {
        public AuthTypeFilteredCredentials(System.Net.NetworkCredential innerCredential, System.Collections.Generic.IEnumerable<string> authTypes) { }
        public System.Collections.Generic.IReadOnlyList<string> AuthTypes { get { throw null; } }
        public System.Net.NetworkCredential InnerCredential { get { throw null; } }
        public System.Net.NetworkCredential GetCredential(System.Uri uri, string authType) { throw null; }
    }
    public static partial class ClientVersionUtility
    {
        public static string GetNuGetAssemblyVersion() { throw null; }
    }
    public partial class CommandLineArgumentCombinationException : System.Exception, NuGet.Common.ILogMessageException
    {
        public CommandLineArgumentCombinationException(string message) { }
        public virtual NuGet.Common.ILogMessage AsLogMessage() { throw null; }
    }
    public static partial class ConcurrencyUtilities
    {
        public static void ExecuteWithFileLocked(string filePath, System.Action action) { }
        public static System.Threading.Tasks.Task<T> ExecuteWithFileLockedAsync<T>(string filePath, System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> action, System.Threading.CancellationToken token) { throw null; }
    }
    public partial class CryptoHashProvider
    {
        public CryptoHashProvider() { }
        public CryptoHashProvider(string hashAlgorithm) { }
        public byte[] CalculateHash(byte[] data) { throw null; }
        public byte[] CalculateHash(System.IO.Stream stream) { throw null; }
        public bool VerifyHash(byte[] data, byte[] hash) { throw null; }
    }
    public static partial class CryptoHashUtility
    {
        public static byte[] ComputeHash(this NuGet.Common.HashAlgorithmName hashAlgorithmName, byte[] data) { throw null; }
        public static byte[] ComputeHash(this System.Security.Cryptography.HashAlgorithm hashAlgorithm, System.IO.Stream data) { throw null; }
        public static byte[] ComputeHash(this System.Security.Cryptography.HashAlgorithm hashAlgorithm, System.IO.Stream data, bool leaveStreamOpen) { throw null; }
        public static string ComputeHashAsBase64(this System.Security.Cryptography.HashAlgorithm hashAlgorithm, System.IO.Stream data) { throw null; }
        public static string ComputeHashAsBase64(this System.Security.Cryptography.HashAlgorithm hashAlgorithm, System.IO.Stream data, bool leaveStreamOpen) { throw null; }
        public static System.Security.Cryptography.Oid ConvertToOid(this NuGet.Common.HashAlgorithmName hashAlgorithm) { throw null; }
        public static string ConvertToOidString(this NuGet.Common.HashAlgorithmName hashAlgorithmName) { throw null; }
        public static string ConvertToOidString(this NuGet.Common.SignatureAlgorithmName signatureAlgorithmName) { throw null; }
        public static System.Security.Cryptography.HashAlgorithmName ConvertToSystemSecurityHashAlgorithmName(this NuGet.Common.HashAlgorithmName hashAlgorithmName) { throw null; }
        public static string GenerateUniqueToken(string caseInsensitiveKey) { throw null; }
        public static System.Security.Cryptography.HashAlgorithm GetHashAlgorithm(NuGet.Common.HashAlgorithmName hashAlgorithmName) { throw null; }
        public static System.Security.Cryptography.HashAlgorithm GetHashAlgorithm(string hashAlgorithmName) { throw null; }
        public static NuGet.Common.HashAlgorithmName GetHashAlgorithmName(string hashAlgorithm) { throw null; }
        public static System.Security.Cryptography.HashAlgorithm GetHashProvider(this NuGet.Common.HashAlgorithmName hashAlgorithmName) { throw null; }
        public static System.Security.Cryptography.HashAlgorithm GetSha1HashProvider() { throw null; }
        public static NuGet.Common.HashAlgorithmName OidToHashAlgorithmName(string oid) { throw null; }
    }
    public partial class CultureUtility
    {
        public CultureUtility() { }
        public static void DisableLocalization() { }
    }
    public partial class DatetimeUtility
    {
        public DatetimeUtility() { }
        public static string ToReadableTimeFormat(System.TimeSpan time) { throw null; }
    }
    public static partial class DirectoryUtility
    {
        public static void CreateSharedDirectory(string path) { }
    }
    public partial class EnvironmentVariableWrapper : NuGet.Common.IEnvironmentVariableReader
    {
        public EnvironmentVariableWrapper() { }
        public string GetEnvironmentVariable(string variable) { throw null; }
    }
    public partial class ExceptionLogger
    {
        public ExceptionLogger(NuGet.Common.IEnvironmentVariableReader reader) { }
        public static NuGet.Common.ExceptionLogger Instance { get { throw null; } }
        public bool ShowStack { get { throw null; } }
    }
    public static partial class ExceptionUtilities
    {
        public static string DisplayMessage(System.AggregateException exception) { throw null; }
        public static string DisplayMessage(System.Exception exception) { throw null; }
        public static string DisplayMessage(System.Exception exception, bool indent) { throw null; }
        public static string DisplayMessage(System.Reflection.TargetInvocationException exception) { throw null; }
        public static void LogException(System.Exception ex, NuGet.Common.ILogger logger) { }
        public static void LogException(System.Exception ex, NuGet.Common.ILogger logger, bool logStackAsError) { }
        public static System.Exception Unwrap(System.Exception exception) { throw null; }
    }
    public static partial class FileUtility
    {
        public static readonly System.IO.FileShare FileSharePermissions;
        public static readonly int MaxTries;
        public static void Delete(string path) { }
        public static System.Threading.Tasks.Task DeleteWithLock(string filePath) { throw null; }
        public static string GetTempFilePath(string directory) { throw null; }
        public static void Move(string sourceFileName, string destFileName) { }
        public static void Replace(System.Action<string> writeSourceFile, string destFilePath) { }
        public static void Replace(string sourceFileName, string destFileName) { }
        public static System.Threading.Tasks.Task ReplaceAsync(System.Func<string, System.Threading.Tasks.Task> writeSourceFile, string destFilePath) { throw null; }
        public static System.Threading.Tasks.Task ReplaceWithLock(System.Action<string> writeSourceFile, string destFilePath) { throw null; }
        public static System.Threading.Tasks.Task<T> SafeReadAsync<T>(string filePath, System.Func<System.IO.FileStream, string, System.Threading.Tasks.Task<T>> read) { throw null; }
        public static T SafeRead<T>(string filePath, System.Func<System.IO.FileStream, string, T> read) { throw null; }
    }
    public enum HashAlgorithmName
    {
        SHA256 = 1,
        SHA384 = 2,
        SHA512 = 3,
        Unknown = 0,
    }
    public partial interface ICollectorLogger : NuGet.Common.ILogger
    {
        System.Collections.Generic.IEnumerable<NuGet.Common.IRestoreLogMessage> Errors { get; }
    }
    public partial interface IEnumerableAsync<T>
    {
        NuGet.Common.IEnumeratorAsync<T> GetEnumeratorAsync();
    }
    public partial interface IEnumeratorAsync<T>
    {
        T Current { get; }
        System.Threading.Tasks.Task<bool> MoveNextAsync();
    }
    public partial interface IEnvironmentVariableReader
    {
        string GetEnvironmentVariable(string variable);
    }
    public partial interface ILogFileContext
    {
        int EndColumnNumber { get; set; }
        int EndLineNumber { get; set; }
        string FilePath { get; set; }
        int StartColumnNumber { get; set; }
        int StartLineNumber { get; set; }
    }
    public partial interface ILogger
    {
        void Log(NuGet.Common.ILogMessage message);
        void Log(NuGet.Common.LogLevel level, string data);
        System.Threading.Tasks.Task LogAsync(NuGet.Common.ILogMessage message);
        System.Threading.Tasks.Task LogAsync(NuGet.Common.LogLevel level, string data);
        void LogDebug(string data);
        void LogError(string data);
        void LogInformation(string data);
        void LogInformationSummary(string data);
        void LogMinimal(string data);
        void LogVerbose(string data);
        void LogWarning(string data);
    }
    public partial interface ILogMessage
    {
        NuGet.Common.NuGetLogCode Code { get; set; }
        NuGet.Common.LogLevel Level { get; set; }
        string Message { get; set; }
        string ProjectPath { get; set; }
        System.DateTimeOffset Time { get; set; }
        NuGet.Common.WarningLevel WarningLevel { get; set; }
    }
    public partial interface ILogMessageException
    {
        NuGet.Common.ILogMessage AsLogMessage();
    }
    public partial interface INuGetLogMessage : NuGet.Common.ILogFileContext, NuGet.Common.ILogMessage
    {
    }
    public partial interface INuGetPathContext
    {
        System.Collections.Generic.IReadOnlyList<string> FallbackPackageFolders { get; }
        string HttpCacheFolder { get; }
        string UserPackageFolder { get; }
    }
    public partial interface INuGetTelemetryService
    {
        void EmitTelemetryEvent(NuGet.Common.TelemetryEvent telemetryData);
    }
    public partial interface IPackLogMessage : NuGet.Common.ILogFileContext, NuGet.Common.ILogMessage, NuGet.Common.INuGetLogMessage
    {
    }
    public partial interface IRestoreLogMessage : NuGet.Common.ILogFileContext, NuGet.Common.ILogMessage, NuGet.Common.INuGetLogMessage
    {
        string LibraryId { get; set; }
        bool ShouldDisplay { get; set; }
        System.Collections.Generic.IReadOnlyList<string> TargetGraphs { get; set; }
    }
    public partial interface ITelemetrySession
    {
        void PostEvent(NuGet.Common.TelemetryEvent telemetryEvent);
    }
    public abstract partial class LegacyLoggerAdapter : NuGet.Common.ILogger
    {
        protected LegacyLoggerAdapter() { }
        public virtual void Log(NuGet.Common.ILogMessage message) { }
        public void Log(NuGet.Common.LogLevel level, string data) { }
        public virtual System.Threading.Tasks.Task LogAsync(NuGet.Common.ILogMessage message) { throw null; }
        public System.Threading.Tasks.Task LogAsync(NuGet.Common.LogLevel level, string data) { throw null; }
        public abstract void LogDebug(string data);
        public abstract void LogError(string data);
        public abstract void LogInformation(string data);
        public abstract void LogInformationSummary(string data);
        public abstract void LogMinimal(string data);
        public abstract void LogVerbose(string data);
        public abstract void LogWarning(string data);
    }
    public partial class LocalResourceUtils
    {
        public LocalResourceUtils() { }
        public static void DeleteDirectoryTree(string folderPath, System.Collections.Generic.List<string> failedDeletes) { }
    }
    public abstract partial class LoggerBase : NuGet.Common.ILogger
    {
        public LoggerBase() { }
        public LoggerBase(NuGet.Common.LogLevel verbosityLevel) { }
        public NuGet.Common.LogLevel VerbosityLevel { get { throw null; } set { } }
        protected virtual bool CollectMessage(NuGet.Common.LogLevel messageLevel) { throw null; }
        protected virtual bool DisplayMessage(NuGet.Common.LogLevel messageLevel) { throw null; }
        public abstract void Log(NuGet.Common.ILogMessage message);
        public virtual void Log(NuGet.Common.LogLevel level, string data) { }
        public abstract System.Threading.Tasks.Task LogAsync(NuGet.Common.ILogMessage message);
        public virtual System.Threading.Tasks.Task LogAsync(NuGet.Common.LogLevel level, string data) { throw null; }
        public virtual void LogDebug(string data) { }
        public virtual void LogError(string data) { }
        public virtual void LogInformation(string data) { }
        public virtual void LogInformationSummary(string data) { }
        public virtual void LogMinimal(string data) { }
        public virtual void LogVerbose(string data) { }
        public virtual void LogWarning(string data) { }
    }
    public static partial class LoggingExtensions
    {
        public static string FormatWithCode(this NuGet.Common.ILogMessage message) { throw null; }
        public static string GetName(this NuGet.Common.NuGetLogCode code) { throw null; }
        public static bool TryGetName(this NuGet.Common.NuGetLogCode code, out string codeString) { throw null; }
    }
    public enum LogLevel
    {
        Debug = 0,
        Error = 5,
        Information = 2,
        Minimal = 3,
        Verbose = 1,
        Warning = 4,
    }
    public partial class LogMessage : NuGet.Common.ILogMessage
    {
        public LogMessage(NuGet.Common.LogLevel level, string message) { }
        public LogMessage(NuGet.Common.LogLevel level, string message, NuGet.Common.NuGetLogCode code) { }
        public NuGet.Common.NuGetLogCode Code { get { throw null; } set { } }
        public NuGet.Common.LogLevel Level { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public string ProjectPath { get { throw null; } set { } }
        public System.DateTimeOffset Time { get { throw null; } set { } }
        public NuGet.Common.WarningLevel WarningLevel { get { throw null; } set { } }
        public static NuGet.Common.LogMessage Create(NuGet.Common.LogLevel level, string message) { throw null; }
        public static NuGet.Common.LogMessage CreateError(NuGet.Common.NuGetLogCode code, string message) { throw null; }
        public static NuGet.Common.LogMessage CreateWarning(NuGet.Common.NuGetLogCode code, string message) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LogMessageProperties
    {
        public const string CODE = "code";
        public const string END_COLUMN_NUMBER = "endColumnNumber";
        public const string END_LINE_NUMBER = "endLineNumber";
        public const string FILE_PATH = "filePath";
        public const string LEVEL = "level";
        public const string LIBRARY_ID = "libraryId";
        public const string MESSAGE = "message";
        public const string START_COLUMN_NUMBER = "startColumnNumber";
        public const string START_LINE_NUMBER = "startLineNumber";
        public const string TARGET_GRAPHS = "targetGraphs";
        public const string WARNING_LEVEL = "warningLevel";
        public LogMessageProperties() { }
    }
    public static partial class MSBuildStringUtility
    {
        public static string Convert(string value) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Common.NuGetLogCode> GetDistinctNuGetLogCodesOrDefault(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<NuGet.Common.NuGetLogCode>> nugetLogCodeLists) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Common.NuGetLogCode> GetNuGetLogCodes(string s) { throw null; }
        public static bool IsTrue(string value) { throw null; }
        public static bool IsTrueOrEmpty(string value) { throw null; }
        public static string[] Split(string s) { throw null; }
        public static string[] Split(string s, params char[] chars) { throw null; }
        public static string[] TrimAndExcludeNullOrEmpty(string[] strings) { throw null; }
        public static string TrimAndGetNullForEmpty(string s) { throw null; }
    }
    public static partial class NetworkProtocolUtility
    {
        public static void ConfigureSupportedSslProtocols() { }
        public static void SetConnectionLimit() { }
    }
    public static partial class NuGetEnvironment
    {
        public static string GetDotNetLocation() { throw null; }
        public static string GetFolderPath(NuGet.Common.NuGetFolderPath folder) { throw null; }
    }
    public enum NuGetFolderPath
    {
        DefaultMsBuildPath = 5,
        HttpCacheDirectory = 3,
        MachineWideConfigDirectory = 1,
        MachineWideSettingsBaseDirectory = 0,
        NuGetHome = 4,
        NuGetPluginsCacheDirectory = 7,
        Temp = 6,
        UserSettingsDirectory = 2,
    }
    public enum NuGetLogCode
    {
        NU1000 = 1000,
        NU1001 = 1001,
        NU1002 = 1002,
        NU1003 = 1003,
        NU1004 = 1004,
        NU1005 = 1005,
        NU1006 = 1006,
        NU1100 = 1100,
        NU1101 = 1101,
        NU1102 = 1102,
        NU1103 = 1103,
        NU1104 = 1104,
        NU1105 = 1105,
        NU1106 = 1106,
        NU1107 = 1107,
        NU1108 = 1108,
        NU1201 = 1201,
        NU1202 = 1202,
        NU1203 = 1203,
        NU1204 = 1204,
        NU1211 = 1211,
        NU1212 = 1212,
        NU1213 = 1213,
        NU1401 = 1401,
        NU1402 = 1402,
        NU1403 = 1403,
        NU1410 = 1410,
        NU1500 = 1500,
        NU1501 = 1501,
        NU1502 = 1502,
        NU1503 = 1503,
        NU1601 = 1601,
        NU1602 = 1602,
        NU1603 = 1603,
        NU1604 = 1604,
        NU1605 = 1605,
        NU1608 = 1608,
        NU1701 = 1701,
        NU1702 = 1702,
        NU1801 = 1801,
        NU3000 = 3000,
        NU3001 = 3001,
        NU3002 = 3002,
        NU3003 = 3003,
        NU3004 = 3004,
        NU3005 = 3005,
        NU3006 = 3006,
        NU3007 = 3007,
        NU3008 = 3008,
        NU3009 = 3009,
        NU3010 = 3010,
        NU3011 = 3011,
        NU3012 = 3012,
        NU3013 = 3013,
        NU3014 = 3014,
        NU3015 = 3015,
        NU3016 = 3016,
        NU3017 = 3017,
        NU3018 = 3018,
        NU3019 = 3019,
        NU3020 = 3020,
        NU3021 = 3021,
        NU3022 = 3022,
        NU3023 = 3023,
        NU3024 = 3024,
        NU3025 = 3025,
        NU3026 = 3026,
        NU3027 = 3027,
        NU3028 = 3028,
        NU3029 = 3029,
        NU3030 = 3030,
        NU3031 = 3031,
        NU3032 = 3032,
        NU3033 = 3033,
        NU3034 = 3034,
        NU3035 = 3035,
        NU3036 = 3036,
        NU3037 = 3037,
        NU3038 = 3038,
        NU3039 = 3039,
        NU3040 = 3040,
        NU3041 = 3041,
        NU5000 = 5000,
        NU5001 = 5001,
        NU5002 = 5002,
        NU5003 = 5003,
        NU5004 = 5004,
        NU5005 = 5005,
        NU5007 = 5007,
        NU5008 = 5008,
        NU5009 = 5009,
        NU5010 = 5010,
        NU5011 = 5011,
        NU5012 = 5012,
        NU5013 = 5013,
        NU5014 = 5014,
        NU5015 = 5015,
        NU5016 = 5016,
        NU5017 = 5017,
        NU5018 = 5018,
        NU5019 = 5019,
        NU5020 = 5020,
        NU5021 = 5021,
        NU5022 = 5022,
        NU5023 = 5023,
        NU5024 = 5024,
        NU5025 = 5025,
        NU5026 = 5026,
        NU5027 = 5027,
        NU5028 = 5028,
        NU5029 = 5029,
        NU5030 = 5030,
        NU5031 = 5031,
        NU5032 = 5032,
        NU5033 = 5033,
        NU5034 = 5034,
        NU5035 = 5035,
        NU5100 = 5100,
        NU5101 = 5101,
        NU5102 = 5102,
        NU5103 = 5103,
        NU5104 = 5104,
        NU5105 = 5105,
        NU5106 = 5106,
        NU5107 = 5107,
        NU5108 = 5108,
        NU5109 = 5109,
        NU5110 = 5110,
        NU5111 = 5111,
        NU5112 = 5112,
        NU5114 = 5114,
        NU5115 = 5115,
        NU5116 = 5116,
        NU5117 = 5117,
        NU5118 = 5118,
        NU5119 = 5119,
        NU5120 = 5120,
        NU5121 = 5121,
        NU5122 = 5122,
        NU5123 = 5123,
        NU5124 = 5124,
        NU5125 = 5125,
        NU5126 = 5126,
        NU5500 = 5500,
        Undefined = 0,
    }
    public enum NuGetOperationStatus
    {
        Cancelled = 3,
        Failed = 2,
        NoOp = 0,
        Succeeded = 1,
    }
    public partial class NullLogger : NuGet.Common.LoggerBase
    {
        public NullLogger() { }
        public static NuGet.Common.ILogger Instance { get { throw null; } }
        public override void Log(NuGet.Common.ILogMessage message) { }
        public override void Log(NuGet.Common.LogLevel level, string data) { }
        public override System.Threading.Tasks.Task LogAsync(NuGet.Common.ILogMessage message) { throw null; }
        public override System.Threading.Tasks.Task LogAsync(NuGet.Common.LogLevel level, string data) { throw null; }
    }
    public partial class PackagingLogMessage : NuGet.Common.ILogFileContext, NuGet.Common.ILogMessage, NuGet.Common.INuGetLogMessage, NuGet.Common.IPackLogMessage
    {
        internal PackagingLogMessage() { }
        public NuGet.Common.NuGetLogCode Code { get { throw null; } set { } }
        public int EndColumnNumber { get { throw null; } set { } }
        public int EndLineNumber { get { throw null; } set { } }
        public string FilePath { get { throw null; } set { } }
        public NuGet.Common.LogLevel Level { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public string ProjectPath { get { throw null; } set { } }
        public int StartColumnNumber { get { throw null; } set { } }
        public int StartLineNumber { get { throw null; } set { } }
        public System.DateTimeOffset Time { get { throw null; } set { } }
        public NuGet.Common.WarningLevel WarningLevel { get { throw null; } set { } }
        public static NuGet.Common.PackagingLogMessage CreateError(string message, NuGet.Common.NuGetLogCode code) { throw null; }
        public static NuGet.Common.PackagingLogMessage CreateMessage(string message, NuGet.Common.LogLevel logLevel) { throw null; }
        public static NuGet.Common.PackagingLogMessage CreateWarning(string message, NuGet.Common.NuGetLogCode code) { throw null; }
    }
    public static partial class PathResolver
    {
        public static void FilterPackageFiles<T>(System.Collections.Generic.ICollection<T> source, System.Func<T, string> getPath, System.Collections.Generic.IEnumerable<string> wildcards) { }
        public static System.Collections.Generic.IEnumerable<T> GetFilteredPackageFiles<T>(System.Collections.Generic.ICollection<T> source, System.Func<T, string> getPath, System.Collections.Generic.IEnumerable<string> wildcards) { throw null; }
        public static System.Collections.Generic.IEnumerable<T> GetMatches<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, string> getPath, System.Collections.Generic.IEnumerable<string> wildcards) { throw null; }
        public static bool IsDirectoryPath(string path) { throw null; }
        public static bool IsWildcardSearch(string filter) { throw null; }
        public static string NormalizeWildcardForExcludedFiles(string basePath, string wildcard) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> PerformWildcardSearch(string basePath, string searchPath) { throw null; }
        public static System.Collections.Generic.IEnumerable<NuGet.Common.PathResolver.SearchPathResult> PerformWildcardSearch(string basePath, string searchPath, bool includeEmptyDirectories, out string normalizedBasePath) { throw null; }
        public partial struct SearchPathResult
        {
            private object _dummy;
            private int _dummyPrimitive;
            public SearchPathResult(string path, bool isFile) { throw null; }
            public bool IsFile { get { throw null; } }
            public string Path { get { throw null; } }
        }
    }
    public static partial class PathUtility
    {
        public static bool IsFileSystemCaseInsensitive { get { throw null; } }
        public static void EnsureParentDirectory(string filePath) { }
        public static string EnsureTrailingForwardSlash(string path) { throw null; }
        public static string EnsureTrailingSlash(string path) { throw null; }
        public static string EscapePSPath(string path) { throw null; }
        public static string GetAbsolutePath(string basePath, string relativePath) { throw null; }
        public static string GetDirectoryName(string path) { throw null; }
        public static System.IO.Compression.ZipArchiveEntry GetEntry(System.IO.Compression.ZipArchive archive, string path) { throw null; }
        public static string GetPath(System.Uri uri) { throw null; }
        public static string GetPathWithBackSlashes(string path) { throw null; }
        public static string GetPathWithDirectorySeparator(string path) { throw null; }
        public static string GetPathWithForwardSlashes(string path) { throw null; }
        public static string GetRelativePath(string path1, string path2) { throw null; }
        public static string GetRelativePath(string path1, string path2, char separator) { throw null; }
        public static System.StringComparer GetStringComparerBasedOnOS() { throw null; }
        public static System.StringComparison GetStringComparisonBasedOnOS() { throw null; }
        public static System.Collections.Generic.IEnumerable<string> GetUniquePathsBasedOnOS(System.Collections.Generic.IEnumerable<string> paths) { throw null; }
        public static bool HasTrailingDirectorySeparator(string path) { throw null; }
        public static bool IsChildOfDirectory(string dir, string candidate) { throw null; }
        public static bool IsDirectorySeparatorChar(char ch) { throw null; }
        public static bool IsSubdirectory(string basePath, string path) { throw null; }
        public static string ReplaceAltDirSeparatorWithDirSeparator(string path) { throw null; }
        public static string ReplaceDirSeparatorWithAltDirSeparator(string path) { throw null; }
        public static string SmartTruncate(string path, int maxWidth) { throw null; }
        public static string StripLeadingDirectorySeparators(string filename) { throw null; }
    }
    public static partial class PathValidator
    {
        public static bool IsValidLocalPath(string path) { throw null; }
        public static bool IsValidRelativePath(string path) { throw null; }
        public static bool IsValidSource(string source) { throw null; }
        public static bool IsValidUncPath(string path) { throw null; }
        public static bool IsValidUrl(string url) { throw null; }
    }
    public partial class Preprocessor
    {
        public Preprocessor() { }
        public static string Process(System.IO.Stream stream, System.Func<string, string> tokenReplacement) { throw null; }
        public static System.Threading.Tasks.Task<string> ProcessAsync(System.Func<System.Threading.Tasks.Task<System.IO.Stream>> streamTaskFactory, System.Func<string, string> tokenReplacement, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class ProjectJsonPathUtilities
    {
        public static readonly string ProjectConfigFileEnding;
        public static readonly string ProjectConfigFileName;
        public static readonly string ProjectLockFileName;
        public ProjectJsonPathUtilities() { }
        public static string GetLockFilePath(string configFilePath) { throw null; }
        public static string GetProjectConfigPath(string directoryPath, string projectName) { throw null; }
        public static string GetProjectConfigWithProjectName(string projectName) { throw null; }
        public static string GetProjectLockFileNameWithProjectName(string projectName) { throw null; }
        public static string GetProjectNameFromConfigFileName(string configPath) { throw null; }
        public static bool IsProjectConfig(string configPath) { throw null; }
    }
    public partial class RestoreLogMessage : NuGet.Common.ILogFileContext, NuGet.Common.ILogMessage, NuGet.Common.INuGetLogMessage, NuGet.Common.IRestoreLogMessage
    {
        public RestoreLogMessage(NuGet.Common.LogLevel logLevel, NuGet.Common.NuGetLogCode errorCode, string errorString) { }
        public RestoreLogMessage(NuGet.Common.LogLevel logLevel, NuGet.Common.NuGetLogCode errorCode, string errorString, string targetGraph) { }
        public RestoreLogMessage(NuGet.Common.LogLevel logLevel, NuGet.Common.NuGetLogCode errorCode, string errorString, string targetGraph, bool logToInnerLogger) { }
        public RestoreLogMessage(NuGet.Common.LogLevel logLevel, string errorString) { }
        public NuGet.Common.NuGetLogCode Code { get { throw null; } set { } }
        public int EndColumnNumber { get { throw null; } set { } }
        public int EndLineNumber { get { throw null; } set { } }
        public string FilePath { get { throw null; } set { } }
        public NuGet.Common.LogLevel Level { get { throw null; } set { } }
        public string LibraryId { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public string ProjectPath { get { throw null; } set { } }
        public bool ShouldDisplay { get { throw null; } set { } }
        public int StartColumnNumber { get { throw null; } set { } }
        public int StartLineNumber { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> TargetGraphs { get { throw null; } set { } }
        public System.DateTimeOffset Time { get { throw null; } set { } }
        public NuGet.Common.WarningLevel WarningLevel { get { throw null; } set { } }
        public static NuGet.Common.RestoreLogMessage CreateError(NuGet.Common.NuGetLogCode code, string message) { throw null; }
        public static NuGet.Common.RestoreLogMessage CreateError(NuGet.Common.NuGetLogCode code, string message, string libraryId, params string[] targetGraphs) { throw null; }
        public static NuGet.Common.RestoreLogMessage CreateWarning(NuGet.Common.NuGetLogCode code, string message) { throw null; }
        public static NuGet.Common.RestoreLogMessage CreateWarning(NuGet.Common.NuGetLogCode code, string message, string libraryId, params string[] targetGraphs) { throw null; }
    }
    public enum RevocationMode
    {
        Offline = 1,
        Online = 0,
    }
    public static partial class RuntimeEnvironmentHelper
    {
        public static bool IsDev14 { get { throw null; } set { } }
        public static bool IsLinux { get { throw null; } }
        public static bool IsMacOSX { get { throw null; } }
        public static bool IsMono { get { throw null; } }
        public static bool IsRunningInVisualStudio { get { throw null; } }
        public static bool IsWindows { get { throw null; } }
    }
    public enum SignatureAlgorithmName
    {
        SHA256RSA = 1,
        SHA384RSA = 2,
        SHA512RSA = 3,
        Unknown = 0,
    }
    public enum SignatureValidationMode
    {
        Accept = 0,
        Require = 1,
    }
    public partial class TelemetryActivity : System.IDisposable
    {
        public TelemetryActivity(System.Guid parentId) { }
        public TelemetryActivity(System.Guid parentId, System.Guid opeartionId) { }
        public TelemetryActivity(System.Guid parentId, System.Guid opeartionId, NuGet.Common.TelemetryEvent telemetryEvent) { }
        public static NuGet.Common.INuGetTelemetryService NuGetTelemetryService { get { throw null; } set { } }
        public System.Guid OperationId { get { throw null; } }
        public System.Guid ParentId { get { throw null; } }
        public NuGet.Common.TelemetryEvent TelemetryEvent { get { throw null; } set { } }
        public static NuGet.Common.TelemetryActivity CreateTelemetryActivityWithNewOperationId() { throw null; }
        public static NuGet.Common.TelemetryActivity CreateTelemetryActivityWithNewOperationId(System.Guid parentId) { throw null; }
        public static NuGet.Common.TelemetryActivity CreateTelemetryActivityWithNewOperationIdAndEvent(System.Guid parentId, string eventName) { throw null; }
        public void Dispose() { }
        public static void EmitTelemetryEvent(NuGet.Common.TelemetryEvent TelemetryEvent) { }
        public void EndIntervalMeasure(string propertyName) { }
        public void StartIntervalMeasure() { }
    }
    public partial class TelemetryEvent
    {
        public TelemetryEvent(string eventName) { }
        public TelemetryEvent(string eventName, System.Collections.Generic.Dictionary<string, object> properties) { }
        public int Count { get { throw null; } }
        public object this[string key] { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public void AddPiiData(string key, object value) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator() { throw null; }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> GetPiiData() { throw null; }
    }
    public static partial class TelemetryServiceUtility
    {
        public static System.TimeSpan GetTimerElapsedTime() { throw null; }
        public static double GetTimerElapsedTimeInSeconds() { throw null; }
        public static void StartOrResumeTimer() { }
        public static void StopTimer() { }
    }
    public partial class Token
    {
        public Token(NuGet.Common.TokenCategory category, string value) { }
        public NuGet.Common.TokenCategory Category { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public enum TokenCategory
    {
        Text = 0,
        Variable = 1,
    }
    public partial class Tokenizer
    {
        public Tokenizer(string text) { }
        public NuGet.Common.Token Read() { throw null; }
    }
    public static partial class UriUtility
    {
        public static System.Uri CreateSourceUri(string source, System.UriKind kind = System.UriKind.Absolute) { throw null; }
        public static string GetAbsolutePath(string rootDirectory, string path) { throw null; }
        public static string GetAbsolutePathFromFile(string sourceFile, string path) { throw null; }
        public static string GetLocalPath(string localOrUriPath) { throw null; }
        public static System.Uri TryCreateSourceUri(string source, System.UriKind kind) { throw null; }
        public static string UrlEncodeOdataParameter(string value) { throw null; }
    }
    public enum WarningLevel
    {
        Default = 4,
        Important = 2,
        Minimal = 3,
        Severe = 1,
    }
}
