// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Reflection.AssemblyFileVersion("2.6.1")]
[assembly: System.Reflection.AssemblyInformationalVersion("2.6.1+9f1684f5f7")]
[assembly: System.Reflection.AssemblyCompany(".NET Foundation")]
[assembly: System.Reflection.AssemblyProduct("xUnit.net Testing Framework")]
[assembly: System.Reflection.AssemblyCopyright("Copyright (C) .NET Foundation")]
[assembly: System.Reflection.AssemblyTitle("xUnit.net Execution (dotnet)")]
[assembly: System.CLSCompliant(true)]
[assembly: Xunit.Sdk.PlatformSpecificAssembly]
[assembly: System.Runtime.Versioning.TargetFramework(".NETStandard,Version=v1.1", FrameworkDisplayName = "")]
[assembly: System.Reflection.AssemblyConfiguration("Release")]
[assembly: System.Reflection.AssemblyVersionAttribute("2.6.1.0")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace <global namespace>
{
    public static partial class ReflectionAbstractionExtensions
    {
        public static object CreateTestClass(this Xunit.Abstractions.ITest test, System.Type testClassType, object[] constructorArguments, Xunit.Sdk.IMessageBus messageBus, Xunit.Sdk.ExecutionTimer timer, System.Threading.CancellationTokenSource cancellationTokenSource) { throw null; }

        public static void DisposeTestClass(this Xunit.Abstractions.ITest test, object testClass, Xunit.Sdk.IMessageBus messageBus, Xunit.Sdk.ExecutionTimer timer, System.Threading.CancellationTokenSource cancellationTokenSource) { }

        public static System.Collections.Generic.IEnumerable<Xunit.Abstractions.IAttributeInfo> GetCustomAttributes(this Xunit.Abstractions.IAssemblyInfo assemblyInfo, System.Type attributeType) { throw null; }

        public static System.Collections.Generic.IEnumerable<Xunit.Abstractions.IAttributeInfo> GetCustomAttributes(this Xunit.Abstractions.IAttributeInfo attributeInfo, System.Type attributeType) { throw null; }

        public static System.Collections.Generic.IEnumerable<Xunit.Abstractions.IAttributeInfo> GetCustomAttributes(this Xunit.Abstractions.IMethodInfo methodInfo, System.Type attributeType) { throw null; }

        public static System.Collections.Generic.IEnumerable<Xunit.Abstractions.IAttributeInfo> GetCustomAttributes(this Xunit.Abstractions.ITypeInfo typeInfo, System.Type attributeType) { throw null; }

        public static System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetMatchingMethods(this System.Type type, System.Reflection.MethodInfo methodInfo) { throw null; }

        public static System.Reflection.MethodInfo ToRuntimeMethod(this Xunit.Abstractions.IMethodInfo methodInfo) { throw null; }

        public static System.Type ToRuntimeType(this Xunit.Abstractions.ITypeInfo typeInfo) { throw null; }
    }

    public static partial class TestFrameworkOptionsReadExtensions
    {
        public static bool? DiagnosticMessages(this Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { throw null; }

        public static bool? DiagnosticMessages(this Xunit.Abstractions.ITestFrameworkExecutionOptions executionOptions) { throw null; }

        public static bool DiagnosticMessagesOrDefault(this Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { throw null; }

        public static bool DiagnosticMessagesOrDefault(this Xunit.Abstractions.ITestFrameworkExecutionOptions executionOptions) { throw null; }

        public static bool? DisableParallelization(this Xunit.Abstractions.ITestFrameworkExecutionOptions executionOptions) { throw null; }

        public static bool DisableParallelizationOrDefault(this Xunit.Abstractions.ITestFrameworkExecutionOptions executionOptions) { throw null; }

        public static int? MaxParallelThreads(this Xunit.Abstractions.ITestFrameworkExecutionOptions executionOptions) { throw null; }

        public static int MaxParallelThreadsOrDefault(this Xunit.Abstractions.ITestFrameworkExecutionOptions executionOptions) { throw null; }

        public static Xunit.Sdk.TestMethodDisplay? MethodDisplay(this Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { throw null; }

        public static Xunit.Sdk.TestMethodDisplayOptions? MethodDisplayOptions(this Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { throw null; }

        public static Xunit.Sdk.TestMethodDisplayOptions MethodDisplayOptionsOrDefault(this Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { throw null; }

        public static Xunit.Sdk.TestMethodDisplay MethodDisplayOrDefault(this Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { throw null; }

        public static bool? PreEnumerateTheories(this Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { throw null; }

        public static bool PreEnumerateTheoriesOrDefault(this Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { throw null; }

        public static bool? StopOnTestFail(this Xunit.Abstractions.ITestFrameworkExecutionOptions executionOptions) { throw null; }

        public static bool StopOnTestFailOrDefault(this Xunit.Abstractions.ITestFrameworkExecutionOptions executionOptions) { throw null; }

        public static bool? SynchronousMessageReporting(this Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { throw null; }

        public static bool? SynchronousMessageReporting(this Xunit.Abstractions.ITestFrameworkExecutionOptions executionOptions) { throw null; }

        public static bool SynchronousMessageReportingOrDefault(this Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { throw null; }

        public static bool SynchronousMessageReportingOrDefault(this Xunit.Abstractions.ITestFrameworkExecutionOptions executionOptions) { throw null; }
    }
}

namespace Xunit
{
    public abstract partial class LongLivedMarshalByRefObject
    {
        public static void DisconnectAll() { }
    }
}

namespace Xunit.Sdk
{
    public partial class AfterTestFinished : TestMessage, Abstractions.IAfterTestFinished, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public AfterTestFinished(Abstractions.ITest test, string attributeName) : base(default!) { }

        public string AttributeName { get { throw null; } }
    }

    public partial class AfterTestStarting : TestMessage, Abstractions.IAfterTestStarting, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public AfterTestStarting(Abstractions.ITest test, string attributeName) : base(default!) { }

        public string AttributeName { get { throw null; } }
    }

    public partial class AsyncTestSyncContext : System.Threading.SynchronizationContext
    {
        public AsyncTestSyncContext(System.Threading.SynchronizationContext innerContext) { }

        public override void OperationCompleted() { }

        public override void OperationStarted() { }

        public override void Post(System.Threading.SendOrPostCallback d, object state) { }

        public override void Send(System.Threading.SendOrPostCallback d, object state) { }

        public System.Threading.Tasks.Task<System.Exception> WaitForCompletionAsync() { throw null; }
    }

    public partial class BeforeTestFinished : TestMessage, Abstractions.IBeforeTestFinished, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public BeforeTestFinished(Abstractions.ITest test, string attributeName) : base(default!) { }

        public string AttributeName { get { throw null; } }
    }

    public partial class BeforeTestStarting : TestMessage, Abstractions.IBeforeTestStarting, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public BeforeTestStarting(Abstractions.ITest test, string attributeName) : base(default!) { }

        public string AttributeName { get { throw null; } }
    }

    public partial class CollectionPerAssemblyTestCollectionFactory : IXunitTestCollectionFactory
    {
        public CollectionPerAssemblyTestCollectionFactory(Abstractions.ITestAssembly testAssembly, Abstractions.IMessageSink diagnosticMessageSink) { }

        public string DisplayName { get { throw null; } }

        public Abstractions.ITestCollection Get(Abstractions.ITypeInfo testClass) { throw null; }
    }

    public partial class CollectionPerClassTestCollectionFactory : IXunitTestCollectionFactory
    {
        public CollectionPerClassTestCollectionFactory(Abstractions.ITestAssembly testAssembly, Abstractions.IMessageSink diagnosticMessageSink) { }

        public string DisplayName { get { throw null; } }

        public Abstractions.ITestCollection Get(Abstractions.ITypeInfo testClass) { throw null; }
    }

    public partial class DefaultTestCaseOrderer : ITestCaseOrderer
    {
        public DefaultTestCaseOrderer(Abstractions.IMessageSink diagnosticMessageSink) { }

        public System.Collections.Generic.IEnumerable<TTestCase> OrderTestCases<TTestCase>(System.Collections.Generic.IEnumerable<TTestCase> testCases)
            where TTestCase : Abstractions.ITestCase { throw null; }
    }

    public partial class DefaultTestCollectionOrderer : ITestCollectionOrderer
    {
        public System.Collections.Generic.IEnumerable<Abstractions.ITestCollection> OrderTestCollections(System.Collections.Generic.IEnumerable<Abstractions.ITestCollection> TestCollections) { throw null; }
    }

    public partial class DelegatingMessageBus : IMessageBus, System.IDisposable
    {
        public DelegatingMessageBus(IMessageBus innerMessageBus, System.Action<Abstractions.IMessageSinkMessage> callback = null) { }

        public void Dispose() { }

        public virtual bool QueueMessage(Abstractions.IMessageSinkMessage message) { throw null; }
    }

    public partial class DelegatingMessageBus<TFinalMessage> : DelegatingMessageBus where TFinalMessage : class, Abstractions.IMessageSinkMessage
    {
        public DelegatingMessageBus(IMessageBus innerMessageBus, System.Action<Abstractions.IMessageSinkMessage> callback = null) : base(default!, default!) { }

        public TFinalMessage FinalMessage { get { throw null; } }

        public System.Threading.ManualResetEvent Finished { get { throw null; } }

        public override bool QueueMessage(Abstractions.IMessageSinkMessage message) { throw null; }
    }

    public partial class DelegatingMessageSink : LongLivedMarshalByRefObject, Abstractions.IMessageSink
    {
        public DelegatingMessageSink(Abstractions.IMessageSink innerSink, System.Action<Abstractions.IMessageSinkMessage> callback = null) { }

        public void Dispose() { }

        public virtual bool OnMessage(Abstractions.IMessageSinkMessage message) { throw null; }
    }

    public partial class DelegatingMessageSink<TFinalMessage> : DelegatingMessageSink where TFinalMessage : class, Abstractions.IMessageSinkMessage
    {
        public DelegatingMessageSink(Abstractions.IMessageSink innerSink, System.Action<Abstractions.IMessageSinkMessage> callback = null) : base(default!, default!) { }

        public TFinalMessage FinalMessage { get { throw null; } }

        public System.Threading.ManualResetEvent Finished { get { throw null; } }

        public override bool OnMessage(Abstractions.IMessageSinkMessage message) { throw null; }
    }

    public partial class DiagnosticMessage : LongLivedMarshalByRefObject, Abstractions.IDiagnosticMessage, Abstractions.IMessageSinkMessage
    {
        public DiagnosticMessage() { }

        public DiagnosticMessage(string format, params object[] args) { }

        public DiagnosticMessage(string message) { }

        public System.Collections.Generic.HashSet<string> InterfaceTypes { get { throw null; } }

        public string Message { get { throw null; } set { } }

        public override string ToString() { throw null; }
    }

    public partial class DiscoveryCompleteMessage : LongLivedMarshalByRefObject, Abstractions.IDiscoveryCompleteMessage, Abstractions.IMessageSinkMessage
    {
    }

    public partial class DisplayNameFormatter
    {
        public DisplayNameFormatter() { }

        public DisplayNameFormatter(TestMethodDisplay display, TestMethodDisplayOptions displayOptions) { }

        public string Format(string displayName) { throw null; }
    }

    public partial class DisposalTracker : System.IDisposable
    {
        public void Add(System.IDisposable disposable) { }

        public void Dispose() { }
    }

    public partial class ErrorMessage : LongLivedMarshalByRefObject, Abstractions.IErrorMessage, Abstractions.IFailureInformation, Abstractions.IExecutionMessage, Abstractions.IMessageSinkMessage
    {
        public ErrorMessage(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, System.Exception ex) { }

        public ErrorMessage(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, string[] exceptionTypes, string[] messages, string[] stackTraces, int[] exceptionParentIndices) { }

        public int[] ExceptionParentIndices { get { throw null; } }

        public string[] ExceptionTypes { get { throw null; } }

        public string[] Messages { get { throw null; } }

        public string[] StackTraces { get { throw null; } }

        public System.Collections.Generic.IEnumerable<Abstractions.ITestCase> TestCases { get { throw null; } }
    }

    public static partial class ExceptionUtility
    {
        public static string CombineMessages(Abstractions.IFailureInformation failureInfo) { throw null; }

        public static string CombineStackTraces(Abstractions.IFailureInformation failureInfo) { throw null; }

        public static Abstractions.IFailureInformation ConvertExceptionToFailureInformation(System.Exception ex) { throw null; }
    }

    public partial class ExecutionErrorTestCase : XunitTestCase
    {
        [System.Obsolete("Called by the de-serializer; should only be called by deriving classes for de-serialization purposes")]
        public ExecutionErrorTestCase() { }

        [System.Obsolete("Please call the constructor which takes TestMethodDisplayOptions")]
        public ExecutionErrorTestCase(Abstractions.IMessageSink diagnosticMessageSink, TestMethodDisplay defaultMethodDisplay, Abstractions.ITestMethod testMethod, string errorMessage) { }

        public ExecutionErrorTestCase(Abstractions.IMessageSink diagnosticMessageSink, TestMethodDisplay defaultMethodDisplay, TestMethodDisplayOptions defaultMethodDisplayOptions, Abstractions.ITestMethod testMethod, string errorMessage) { }

        public string ErrorMessage { get { throw null; } }

        public override void Deserialize(Abstractions.IXunitSerializationInfo data) { }

        public override System.Threading.Tasks.Task<RunSummary> RunAsync(Abstractions.IMessageSink diagnosticMessageSink, IMessageBus messageBus, object[] constructorArguments, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) { throw null; }

        public override void Serialize(Abstractions.IXunitSerializationInfo data) { }
    }

    public partial class ExecutionErrorTestCaseRunner : TestCaseRunner<ExecutionErrorTestCase>
    {
        public ExecutionErrorTestCaseRunner(ExecutionErrorTestCase testCase, IMessageBus messageBus, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) : base(default!, default!, default!, default!) { }

        protected override System.Threading.Tasks.Task<RunSummary> RunTestAsync() { throw null; }
    }

    public partial class ExecutionTimer
    {
        public decimal Total { get { throw null; } }

        public void Aggregate(System.Action action) { }

        public void Aggregate(System.TimeSpan time) { }

        public System.Threading.Tasks.Task AggregateAsync(System.Func<System.Threading.Tasks.Task> asyncAction) { throw null; }
    }

    public static partial class ExtensibilityPointFactory
    {
        public static void Dispose() { }

        public static TInterface Get<TInterface>(Abstractions.IMessageSink diagnosticMessageSink, System.Type type, object[] ctorArgs = null) { throw null; }

        public static IDataDiscoverer GetDataDiscoverer(Abstractions.IMessageSink diagnosticMessageSink, System.Type discovererType) { throw null; }

        public static IDataDiscoverer GetDataDiscoverer(Abstractions.IMessageSink diagnosticMessageSink, Abstractions.IAttributeInfo dataDiscovererAttribute) { throw null; }

        public static ITestCaseOrderer GetTestCaseOrderer(Abstractions.IMessageSink diagnosticMessageSink, System.Type ordererType) { throw null; }

        public static ITestCaseOrderer GetTestCaseOrderer(Abstractions.IMessageSink diagnosticMessageSink, Abstractions.IAttributeInfo testCaseOrdererAttribute) { throw null; }

        public static ITestCollectionOrderer GetTestCollectionOrderer(Abstractions.IMessageSink diagnosticMessageSink, System.Type ordererType) { throw null; }

        public static ITestCollectionOrderer GetTestCollectionOrderer(Abstractions.IMessageSink diagnosticMessageSink, Abstractions.IAttributeInfo testCollectionOrdererAttribute) { throw null; }

        public static ITestFrameworkTypeDiscoverer GetTestFrameworkTypeDiscoverer(Abstractions.IMessageSink diagnosticMessageSink, System.Type frameworkType) { throw null; }

        public static ITestFrameworkTypeDiscoverer GetTestFrameworkTypeDiscoverer(Abstractions.IMessageSink diagnosticMessageSink, Abstractions.IAttributeInfo testFrameworkDiscovererAttribute) { throw null; }

        public static ITraitDiscoverer GetTraitDiscoverer(Abstractions.IMessageSink diagnosticMessageSink, System.Type traitDiscovererType) { throw null; }

        public static ITraitDiscoverer GetTraitDiscoverer(Abstractions.IMessageSink diagnosticMessageSink, Abstractions.IAttributeInfo traitDiscovererAttribute) { throw null; }

        public static IXunitTestCaseDiscoverer GetXunitTestCaseDiscoverer(Abstractions.IMessageSink diagnosticMessageSink, System.Type testCaseDiscovererType) { throw null; }

        public static IXunitTestCollectionFactory GetXunitTestCollectionFactory(Abstractions.IMessageSink diagnosticMessageSink, System.Type testCollectionFactoryType, Abstractions.ITestAssembly testAssembly) { throw null; }

        public static IXunitTestCollectionFactory GetXunitTestCollectionFactory(Abstractions.IMessageSink diagnosticMessageSink, Abstractions.IAttributeInfo collectionBehaviorAttribute, Abstractions.ITestAssembly testAssembly) { throw null; }
    }

    public partial class FactDiscoverer : IXunitTestCaseDiscoverer
    {
        public FactDiscoverer(Abstractions.IMessageSink diagnosticMessageSink) { }

        protected Abstractions.IMessageSink DiagnosticMessageSink { get { throw null; } }

        protected virtual IXunitTestCase CreateTestCase(Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Abstractions.ITestMethod testMethod, Abstractions.IAttributeInfo factAttribute) { throw null; }

        public virtual System.Collections.Generic.IEnumerable<IXunitTestCase> Discover(Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Abstractions.ITestMethod testMethod, Abstractions.IAttributeInfo factAttribute) { throw null; }
    }

    public abstract partial class GeneralDigest
    {
        internal GeneralDigest() { }

        public abstract string AlgorithmName { get; }

        public void BlockUpdate(byte[] input, int inOff, int length) { }

        protected void CopyIn(GeneralDigest t) { }

        public abstract int DoFinal(byte[] output, int outOff);
        public void Finish() { }

        public int GetByteLength() { throw null; }

        public abstract int GetDigestSize();
        public virtual void Reset() { }

        public void Update(byte input) { }
    }

    public partial class MaxConcurrencySyncContext : System.Threading.SynchronizationContext, System.IDisposable
    {
        public MaxConcurrencySyncContext(int maximumConcurrencyLevel) { }

        public static bool IsSupported { get { throw null; } }

        public void Dispose() { }

        public override void Post(System.Threading.SendOrPostCallback d, object state) { }

        public override void Send(System.Threading.SendOrPostCallback d, object state) { }
    }

    public partial class MessageBus : IMessageBus, System.IDisposable
    {
        public MessageBus(Abstractions.IMessageSink messageSink, bool stopOnFail = false) { }

        public void Dispose() { }

        public bool QueueMessage(Abstractions.IMessageSinkMessage message) { throw null; }
    }

    public partial class NullMessageSink : LongLivedMarshalByRefObject, Abstractions.IMessageSink
    {
        public void Dispose() { }

        public bool OnMessage(Abstractions.IMessageSinkMessage message) { throw null; }

        public bool OnMessageWithTypes(Abstractions.IMessageSinkMessage message, System.Collections.Generic.HashSet<string> messageTypes) { throw null; }
    }

    public partial class ReflectionAssemblyInfo : LongLivedMarshalByRefObject, Abstractions.IReflectionAssemblyInfo, Abstractions.IAssemblyInfo
    {
        public ReflectionAssemblyInfo(System.Reflection.Assembly assembly) { }

        public ReflectionAssemblyInfo(string assemblyFileName) { }

        public System.Reflection.Assembly Assembly { get { throw null; } }

        public string AssemblyPath { get { throw null; } }

        public string Name { get { throw null; } }

        public System.Collections.Generic.IEnumerable<Abstractions.IAttributeInfo> GetCustomAttributes(string assemblyQualifiedAttributeTypeName) { throw null; }

        public Abstractions.ITypeInfo GetType(string typeName) { throw null; }

        public System.Collections.Generic.IEnumerable<Abstractions.ITypeInfo> GetTypes(bool includePrivateTypes) { throw null; }

        public override string ToString() { throw null; }
    }

    public partial class ReflectionAttributeInfo : LongLivedMarshalByRefObject, Abstractions.IReflectionAttributeInfo, Abstractions.IAttributeInfo
    {
        public ReflectionAttributeInfo(System.Reflection.CustomAttributeData attribute) { }

        public System.Attribute Attribute { get { throw null; } }

        public System.Reflection.CustomAttributeData AttributeData { get { throw null; } }

        public System.Collections.Generic.IEnumerable<object> GetConstructorArguments() { throw null; }

        public System.Collections.Generic.IEnumerable<Abstractions.IAttributeInfo> GetCustomAttributes(string assemblyQualifiedAttributeTypeName) { throw null; }

        public TValue GetNamedArgument<TValue>(string argumentName) { throw null; }

        public override string ToString() { throw null; }
    }

    public partial class ReflectionMethodInfo : LongLivedMarshalByRefObject, Abstractions.IReflectionMethodInfo, Abstractions.IMethodInfo
    {
        public ReflectionMethodInfo(System.Reflection.MethodInfo method) { }

        public bool IsAbstract { get { throw null; } }

        public bool IsGenericMethodDefinition { get { throw null; } }

        public bool IsPublic { get { throw null; } }

        public bool IsStatic { get { throw null; } }

        public System.Reflection.MethodInfo MethodInfo { get { throw null; } }

        public string Name { get { throw null; } }

        public Abstractions.ITypeInfo ReturnType { get { throw null; } }

        public Abstractions.ITypeInfo Type { get { throw null; } }

        public System.Collections.Generic.IEnumerable<Abstractions.IAttributeInfo> GetCustomAttributes(string assemblyQualifiedAttributeTypeName) { throw null; }

        public System.Collections.Generic.IEnumerable<Abstractions.ITypeInfo> GetGenericArguments() { throw null; }

        public System.Collections.Generic.IEnumerable<Abstractions.IParameterInfo> GetParameters() { throw null; }

        public Abstractions.IMethodInfo MakeGenericMethod(params Abstractions.ITypeInfo[] typeArguments) { throw null; }

        public override string ToString() { throw null; }
    }

    public partial class ReflectionParameterInfo : LongLivedMarshalByRefObject, Abstractions.IReflectionParameterInfo, Abstractions.IParameterInfo
    {
        public ReflectionParameterInfo(System.Reflection.ParameterInfo parameterInfo) { }

        public string Name { get { throw null; } }

        public System.Reflection.ParameterInfo ParameterInfo { get { throw null; } }

        public Abstractions.ITypeInfo ParameterType { get { throw null; } }
    }

    public partial class ReflectionTypeInfo : LongLivedMarshalByRefObject, Abstractions.IReflectionTypeInfo, Abstractions.ITypeInfo
    {
        public ReflectionTypeInfo(System.Type type) { }

        public Abstractions.IAssemblyInfo Assembly { get { throw null; } }

        public Abstractions.ITypeInfo BaseType { get { throw null; } }

        public System.Collections.Generic.IEnumerable<Abstractions.ITypeInfo> Interfaces { get { throw null; } }

        public bool IsAbstract { get { throw null; } }

        public bool IsGenericParameter { get { throw null; } }

        public bool IsGenericType { get { throw null; } }

        public bool IsSealed { get { throw null; } }

        public bool IsValueType { get { throw null; } }

        public string Name { get { throw null; } }

        public System.Type Type { get { throw null; } }

        public System.Collections.Generic.IEnumerable<Abstractions.IAttributeInfo> GetCustomAttributes(string assemblyQualifiedAttributeTypeName) { throw null; }

        public System.Collections.Generic.IEnumerable<Abstractions.ITypeInfo> GetGenericArguments() { throw null; }

        public Abstractions.IMethodInfo GetMethod(string methodName, bool includePrivateMethod) { throw null; }

        public System.Collections.Generic.IEnumerable<Abstractions.IMethodInfo> GetMethods(bool includePrivateMethods) { throw null; }

        public override string ToString() { throw null; }
    }

    public static partial class Reflector
    {
        public static object[] ConvertArguments(object[] args, System.Type[] types) { throw null; }

        public static Abstractions.IReflectionAssemblyInfo Wrap(System.Reflection.Assembly assembly) { throw null; }

        public static Abstractions.IReflectionAttributeInfo Wrap(System.Reflection.CustomAttributeData attribute) { throw null; }

        public static Abstractions.IReflectionMethodInfo Wrap(System.Reflection.MethodInfo method) { throw null; }

        public static Abstractions.IReflectionParameterInfo Wrap(System.Reflection.ParameterInfo parameter) { throw null; }

        public static Abstractions.IReflectionTypeInfo Wrap(System.Type type) { throw null; }
    }

    public static partial class SerializationHelper
    {
        public static T Deserialize<T>(string serializedValue) { throw null; }

        public static System.Type GetType(string assemblyName, string typeName) { throw null; }

        public static System.Type GetType(string assemblyQualifiedTypeName) { throw null; }

        public static string GetTypeNameForSerialization(System.Type type) { throw null; }

        public static bool IsSerializable(object value) { throw null; }

        public static string Serialize(object value) { throw null; }
    }

    public partial class Sha1Digest : GeneralDigest
    {
        public Sha1Digest() { }

        public Sha1Digest(Sha1Digest t) { }

        public override string AlgorithmName { get { throw null; } }

        public override int DoFinal(byte[] output, int outOff) { throw null; }

        public override int GetDigestSize() { throw null; }

        public override void Reset() { }

        public void Reset(Sha1Digest other) { }
    }

    public partial class SourceInformation : LongLivedMarshalByRefObject, Abstractions.ISourceInformation, Abstractions.IXunitSerializable
    {
        public string FileName { get { throw null; } set { } }

        public int? LineNumber { get { throw null; } set { } }

        public void Deserialize(Abstractions.IXunitSerializationInfo info) { }

        public void Serialize(Abstractions.IXunitSerializationInfo info) { }
    }

    public partial class SynchronousMessageBus : IMessageBus, System.IDisposable
    {
        public SynchronousMessageBus(Abstractions.IMessageSink messageSink) { }

        public void Dispose() { }

        public bool QueueMessage(Abstractions.IMessageSinkMessage message) { throw null; }
    }

    public partial class TestAssembly : LongLivedMarshalByRefObject, Abstractions.ITestAssembly, Abstractions.IXunitSerializable
    {
        [System.Obsolete("Called by the de-serializer; should only be called by deriving classes for de-serialization purposes")]
        public TestAssembly() { }

        public TestAssembly(Abstractions.IAssemblyInfo assembly, string configFileName = null, System.Version version = null) { }

        public Abstractions.IAssemblyInfo Assembly { get { throw null; } set { } }

        public string ConfigFileName { get { throw null; } set { } }

        public System.Version Version { get { throw null; } }

        public void Deserialize(Abstractions.IXunitSerializationInfo info) { }

        public void Serialize(Abstractions.IXunitSerializationInfo info) { }
    }

    public partial class TestAssemblyCleanupFailure : TestAssemblyMessage, Abstractions.ITestAssemblyCleanupFailure, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage, Abstractions.IFailureInformation
    {
        public TestAssemblyCleanupFailure(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestAssembly testAssembly, System.Exception ex) : base(default!, default!) { }

        public TestAssemblyCleanupFailure(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestAssembly testAssembly, string[] exceptionTypes, string[] messages, string[] stackTraces, int[] exceptionParentIndices) : base(default!, default!) { }

        public int[] ExceptionParentIndices { get { throw null; } }

        public string[] ExceptionTypes { get { throw null; } }

        public string[] Messages { get { throw null; } }

        public string[] StackTraces { get { throw null; } }
    }

    public partial class TestAssemblyFinished : TestAssemblyMessage, Abstractions.ITestAssemblyFinished, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage, Abstractions.IFinishedMessage
    {
        public TestAssemblyFinished(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestAssembly testAssembly, decimal executionTime, int testsRun, int testsFailed, int testsSkipped) : base(default!, default!) { }

        public decimal ExecutionTime { get { throw null; } }

        public int TestsFailed { get { throw null; } }

        public int TestsRun { get { throw null; } }

        public int TestsSkipped { get { throw null; } }
    }

    public partial class TestAssemblyMessage : LongLivedMarshalByRefObject, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestAssemblyMessage(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestAssembly testAssembly) { }

        public Abstractions.ITestAssembly TestAssembly { get { throw null; } set { } }

        public System.Collections.Generic.IEnumerable<Abstractions.ITestCase> TestCases { get { throw null; } }
    }

    public abstract partial class TestAssemblyRunner<TTestCase> : System.IDisposable where TTestCase : Abstractions.ITestCase
    {
        protected TestAssemblyRunner(Abstractions.ITestAssembly testAssembly, System.Collections.Generic.IEnumerable<TTestCase> testCases, Abstractions.IMessageSink diagnosticMessageSink, Abstractions.IMessageSink executionMessageSink, Abstractions.ITestFrameworkExecutionOptions executionOptions) { }

        protected ExceptionAggregator Aggregator { get { throw null; } set { } }

        protected Abstractions.IMessageSink DiagnosticMessageSink { get { throw null; } set { } }

        protected Abstractions.IMessageSink ExecutionMessageSink { get { throw null; } set { } }

        protected Abstractions.ITestFrameworkExecutionOptions ExecutionOptions { get { throw null; } set { } }

        protected Abstractions.ITestAssembly TestAssembly { get { throw null; } set { } }

        protected ITestCaseOrderer TestCaseOrderer { get { throw null; } set { } }

        protected System.Collections.Generic.IEnumerable<TTestCase> TestCases { get { throw null; } set { } }

        protected ITestCollectionOrderer TestCollectionOrderer { get { throw null; } set { } }

        protected virtual System.Threading.Tasks.Task AfterTestAssemblyStartingAsync() { throw null; }

        protected virtual System.Threading.Tasks.Task BeforeTestAssemblyFinishedAsync() { throw null; }

        protected virtual IMessageBus CreateMessageBus() { throw null; }

        public virtual void Dispose() { }

        protected abstract string GetTestFrameworkDisplayName();
        protected virtual string GetTestFrameworkEnvironment() { throw null; }

        protected System.Collections.Generic.List<System.Tuple<Abstractions.ITestCollection, System.Collections.Generic.List<TTestCase>>> OrderTestCollections() { throw null; }

        public System.Threading.Tasks.Task<RunSummary> RunAsync() { throw null; }

        protected abstract System.Threading.Tasks.Task<RunSummary> RunTestCollectionAsync(IMessageBus messageBus, Abstractions.ITestCollection testCollection, System.Collections.Generic.IEnumerable<TTestCase> testCases, System.Threading.CancellationTokenSource cancellationTokenSource);
        protected virtual System.Threading.Tasks.Task<RunSummary> RunTestCollectionsAsync(IMessageBus messageBus, System.Threading.CancellationTokenSource cancellationTokenSource) { throw null; }
    }

    public partial class TestAssemblyStarting : TestAssemblyMessage, Abstractions.ITestAssemblyStarting, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestAssemblyStarting(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestAssembly testAssembly, System.DateTime startTime, string testEnvironment, string testFrameworkDisplayName) : base(default!, default!) { }

        public System.DateTime StartTime { get { throw null; } set { } }

        public string TestEnvironment { get { throw null; } set { } }

        public string TestFrameworkDisplayName { get { throw null; } set { } }
    }

    public partial class TestCaseBulkDeserializer : LongLivedMarshalByRefObject
    {
        public TestCaseBulkDeserializer(object discovererObject, object executorObject, object serializedTestCasesObject, object callbackObject) { }
    }

    public partial class TestCaseCleanupFailure : TestCaseMessage, Abstractions.ITestCaseCleanupFailure, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage, Abstractions.IFailureInformation
    {
        public TestCaseCleanupFailure(Abstractions.ITestCase testCase, System.Exception ex) : base(default!) { }

        public TestCaseCleanupFailure(Abstractions.ITestCase testCase, string[] exceptionTypes, string[] messages, string[] stackTraces, int[] exceptionParentIndices) : base(default!) { }

        public int[] ExceptionParentIndices { get { throw null; } }

        public string[] ExceptionTypes { get { throw null; } }

        public string[] Messages { get { throw null; } }

        public string[] StackTraces { get { throw null; } }
    }

    public partial class TestCaseDescriptorFactory : LongLivedMarshalByRefObject
    {
        public TestCaseDescriptorFactory(object discovererObject, object testCasesObject, object callbackObject) { }
    }

    public partial class TestCaseDiscoveryMessage : TestCaseMessage, Abstractions.ITestCaseDiscoveryMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestCaseDiscoveryMessage(Abstractions.ITestCase testCase) : base(default!) { }
    }

    public partial class TestCaseFinished : TestCaseMessage, Abstractions.ITestCaseFinished, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage, Abstractions.IFinishedMessage
    {
        public TestCaseFinished(Abstractions.ITestCase testCase, decimal executionTime, int testsRun, int testsFailed, int testsSkipped) : base(default!) { }

        public decimal ExecutionTime { get { throw null; } }

        public int TestsFailed { get { throw null; } }

        public int TestsRun { get { throw null; } }

        public int TestsSkipped { get { throw null; } }
    }

    public partial class TestCaseMessage : TestMethodMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage
    {
        public TestCaseMessage(Abstractions.ITestCase testCase) : base(default!, default!) { }

        public Abstractions.ITestCase TestCase { get { throw null; } }
    }

    public abstract partial class TestCaseRunner<TTestCase>
        where TTestCase : Abstractions.ITestCase
    {
        protected TestCaseRunner(TTestCase testCase, IMessageBus messageBus, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) { }

        protected ExceptionAggregator Aggregator { get { throw null; } set { } }

        protected System.Threading.CancellationTokenSource CancellationTokenSource { get { throw null; } set { } }

        protected IMessageBus MessageBus { get { throw null; } set { } }

        protected TTestCase TestCase { get { throw null; } set { } }

        protected virtual System.Threading.Tasks.Task AfterTestCaseStartingAsync() { throw null; }

        protected virtual System.Threading.Tasks.Task BeforeTestCaseFinishedAsync() { throw null; }

        public System.Threading.Tasks.Task<RunSummary> RunAsync() { throw null; }

        protected abstract System.Threading.Tasks.Task<RunSummary> RunTestAsync();
    }

    public partial class TestCaseStarting : TestCaseMessage, Abstractions.ITestCaseStarting, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestCaseStarting(Abstractions.ITestCase testCase) : base(default!) { }
    }

    public partial class TestClass : LongLivedMarshalByRefObject, Abstractions.ITestClass, Abstractions.IXunitSerializable
    {
        [System.Obsolete("Called by the de-serializer; should only be called by deriving classes for de-serialization purposes")]
        public TestClass() { }

        public TestClass(Abstractions.ITestCollection testCollection, Abstractions.ITypeInfo @class) { }

        public Abstractions.ITypeInfo Class { get { throw null; } set { } }

        public Abstractions.ITestCollection TestCollection { get { throw null; } set { } }

        public void Deserialize(Abstractions.IXunitSerializationInfo info) { }

        public void Serialize(Abstractions.IXunitSerializationInfo info) { }
    }

    public partial class TestClassCleanupFailure : TestClassMessage, Abstractions.ITestClassCleanupFailure, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage, Abstractions.IFailureInformation
    {
        public TestClassCleanupFailure(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestClass testClass, System.Exception ex) : base(default!, default!) { }

        public TestClassCleanupFailure(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestClass testClass, string[] exceptionTypes, string[] messages, string[] stackTraces, int[] exceptionParentIndices) : base(default!, default!) { }

        public int[] ExceptionParentIndices { get { throw null; } }

        public string[] ExceptionTypes { get { throw null; } }

        public string[] Messages { get { throw null; } }

        public string[] StackTraces { get { throw null; } }
    }

    public partial class TestClassComparer : System.Collections.Generic.IEqualityComparer<Abstractions.ITestClass>
    {
        public static readonly TestClassComparer Instance;
        public bool Equals(Abstractions.ITestClass x, Abstractions.ITestClass y) { throw null; }

        public int GetHashCode(Abstractions.ITestClass obj) { throw null; }
    }

    public partial class TestClassConstructionFinished : TestMessage, Abstractions.ITestClassConstructionFinished, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestClassConstructionFinished(Abstractions.ITest test) : base(default!) { }
    }

    public partial class TestClassConstructionStarting : TestMessage, Abstractions.ITestClassConstructionStarting, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestClassConstructionStarting(Abstractions.ITest test) : base(default!) { }
    }

    public partial class TestClassDisposeFinished : TestMessage, Abstractions.ITestClassDisposeFinished, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestClassDisposeFinished(Abstractions.ITest test) : base(default!) { }
    }

    public partial class TestClassDisposeStarting : TestMessage, Abstractions.ITestClassDisposeStarting, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestClassDisposeStarting(Abstractions.ITest test) : base(default!) { }
    }

    public partial class TestClassException : System.Exception
    {
        public TestClassException(string message) { }
    }

    public partial class TestClassFinished : TestClassMessage, Abstractions.ITestClassFinished, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage, Abstractions.IFinishedMessage
    {
        public TestClassFinished(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestClass testClass, decimal executionTime, int testsRun, int testsFailed, int testsSkipped) : base(default!, default!) { }

        public decimal ExecutionTime { get { throw null; } }

        public int TestsFailed { get { throw null; } }

        public int TestsRun { get { throw null; } }

        public int TestsSkipped { get { throw null; } }
    }

    public partial class TestClassMessage : TestCollectionMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage
    {
        public TestClassMessage(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestClass testClass) : base(default!, default!) { }

        public Abstractions.ITestClass TestClass { get { throw null; } set { } }
    }

    public abstract partial class TestClassRunner<TTestCase>
        where TTestCase : Abstractions.ITestCase
    {
        protected TestClassRunner(Abstractions.ITestClass testClass, Abstractions.IReflectionTypeInfo @class, System.Collections.Generic.IEnumerable<TTestCase> testCases, Abstractions.IMessageSink diagnosticMessageSink, IMessageBus messageBus, ITestCaseOrderer testCaseOrderer, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) { }

        protected ExceptionAggregator Aggregator { get { throw null; } set { } }

        protected System.Threading.CancellationTokenSource CancellationTokenSource { get { throw null; } set { } }

        protected Abstractions.IReflectionTypeInfo Class { get { throw null; } set { } }

        protected Abstractions.IMessageSink DiagnosticMessageSink { get { throw null; } }

        protected IMessageBus MessageBus { get { throw null; } set { } }

        protected ITestCaseOrderer TestCaseOrderer { get { throw null; } set { } }

        protected System.Collections.Generic.IEnumerable<TTestCase> TestCases { get { throw null; } set { } }

        protected Abstractions.ITestClass TestClass { get { throw null; } set { } }

        protected virtual System.Threading.Tasks.Task AfterTestClassStartingAsync() { throw null; }

        protected virtual System.Threading.Tasks.Task BeforeTestClassFinishedAsync() { throw null; }

        protected virtual object[] CreateTestClassConstructorArguments() { throw null; }

        protected virtual string FormatConstructorArgsMissingMessage(System.Reflection.ConstructorInfo constructor, System.Collections.Generic.IReadOnlyList<System.Tuple<int, System.Reflection.ParameterInfo>> unusedArguments) { throw null; }

        public System.Threading.Tasks.Task<RunSummary> RunAsync() { throw null; }

        protected abstract System.Threading.Tasks.Task<RunSummary> RunTestMethodAsync(Abstractions.ITestMethod testMethod, Abstractions.IReflectionMethodInfo method, System.Collections.Generic.IEnumerable<TTestCase> testCases, object[] constructorArguments);
        protected virtual System.Threading.Tasks.Task<RunSummary> RunTestMethodsAsync() { throw null; }

        protected virtual System.Reflection.ConstructorInfo SelectTestClassConstructor() { throw null; }

        protected virtual bool TryGetConstructorArgument(System.Reflection.ConstructorInfo constructor, int index, System.Reflection.ParameterInfo parameter, out object argumentValue) { throw null; }
    }

    public partial class TestClassStarting : TestClassMessage, Abstractions.ITestClassStarting, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestClassStarting(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestClass testClass) : base(default!, default!) { }
    }

    public partial class TestCleanupFailure : TestMessage, Abstractions.ITestCleanupFailure, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage, Abstractions.IFailureInformation
    {
        public TestCleanupFailure(Abstractions.ITest test, System.Exception ex) : base(default!) { }

        public TestCleanupFailure(Abstractions.ITest test, string[] exceptionTypes, string[] messages, string[] stackTraces, int[] exceptionParentIndices) : base(default!) { }

        public int[] ExceptionParentIndices { get { throw null; } }

        public string[] ExceptionTypes { get { throw null; } }

        public string[] Messages { get { throw null; } }

        public string[] StackTraces { get { throw null; } }
    }

    public partial class TestCollection : LongLivedMarshalByRefObject, Abstractions.ITestCollection, Abstractions.IXunitSerializable
    {
        [System.Obsolete("Called by the de-serializer; should only be called by deriving classes for de-serialization purposes")]
        public TestCollection() { }

        public TestCollection(Abstractions.ITestAssembly testAssembly, Abstractions.ITypeInfo collectionDefinition, string displayName, System.Guid? uniqueId) { }

        public TestCollection(Abstractions.ITestAssembly testAssembly, Abstractions.ITypeInfo collectionDefinition, string displayName) { }

        public Abstractions.ITypeInfo CollectionDefinition { get { throw null; } set { } }

        public string DisplayName { get { throw null; } set { } }

        public Abstractions.ITestAssembly TestAssembly { get { throw null; } set { } }

        public System.Guid UniqueID { get { throw null; } set { } }

        public virtual void Deserialize(Abstractions.IXunitSerializationInfo info) { }

        public virtual void Serialize(Abstractions.IXunitSerializationInfo info) { }
    }

    public partial class TestCollectionCleanupFailure : TestCollectionMessage, Abstractions.ITestCollectionCleanupFailure, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage, Abstractions.IFailureInformation
    {
        public TestCollectionCleanupFailure(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestCollection testCollection, System.Exception ex) : base(default!, default!) { }

        public TestCollectionCleanupFailure(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestCollection testCollection, string[] exceptionTypes, string[] messages, string[] stackTraces, int[] exceptionParentIndices) : base(default!, default!) { }

        public int[] ExceptionParentIndices { get { throw null; } }

        public string[] ExceptionTypes { get { throw null; } }

        public string[] Messages { get { throw null; } }

        public string[] StackTraces { get { throw null; } }
    }

    public partial class TestCollectionComparer : System.Collections.Generic.IEqualityComparer<Abstractions.ITestCollection>
    {
        public static readonly TestCollectionComparer Instance;
        public bool Equals(Abstractions.ITestCollection x, Abstractions.ITestCollection y) { throw null; }

        public int GetHashCode(Abstractions.ITestCollection obj) { throw null; }
    }

    public static partial class TestCollectionFactoryHelper
    {
        public static System.Collections.Generic.Dictionary<string, Abstractions.ITypeInfo> GetTestCollectionDefinitions(Abstractions.IAssemblyInfo assemblyInfo, Abstractions.IMessageSink diagnosticMessageSink) { throw null; }
    }

    public partial class TestCollectionFinished : TestCollectionMessage, Abstractions.ITestCollectionFinished, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage, Abstractions.IFinishedMessage
    {
        public TestCollectionFinished(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestCollection testCollection, decimal executionTime, int testsRun, int testsFailed, int testsSkipped) : base(default!, default!) { }

        public decimal ExecutionTime { get { throw null; } }

        public int TestsFailed { get { throw null; } }

        public int TestsRun { get { throw null; } }

        public int TestsSkipped { get { throw null; } }
    }

    public partial class TestCollectionMessage : TestAssemblyMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage
    {
        public TestCollectionMessage(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestCollection testCollection) : base(default!, default!) { }

        public Abstractions.ITestCollection TestCollection { get { throw null; } }
    }

    public abstract partial class TestCollectionRunner<TTestCase>
        where TTestCase : Abstractions.ITestCase
    {
        protected TestCollectionRunner(Abstractions.ITestCollection testCollection, System.Collections.Generic.IEnumerable<TTestCase> testCases, IMessageBus messageBus, ITestCaseOrderer testCaseOrderer, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) { }

        protected ExceptionAggregator Aggregator { get { throw null; } set { } }

        protected System.Threading.CancellationTokenSource CancellationTokenSource { get { throw null; } set { } }

        protected IMessageBus MessageBus { get { throw null; } set { } }

        protected ITestCaseOrderer TestCaseOrderer { get { throw null; } set { } }

        protected System.Collections.Generic.IEnumerable<TTestCase> TestCases { get { throw null; } set { } }

        protected Abstractions.ITestCollection TestCollection { get { throw null; } set { } }

        protected virtual System.Threading.Tasks.Task AfterTestCollectionStartingAsync() { throw null; }

        protected virtual System.Threading.Tasks.Task BeforeTestCollectionFinishedAsync() { throw null; }

        public System.Threading.Tasks.Task<RunSummary> RunAsync() { throw null; }

        protected abstract System.Threading.Tasks.Task<RunSummary> RunTestClassAsync(Abstractions.ITestClass testClass, Abstractions.IReflectionTypeInfo @class, System.Collections.Generic.IEnumerable<TTestCase> testCases);
        protected virtual System.Threading.Tasks.Task<RunSummary> RunTestClassesAsync() { throw null; }
    }

    public partial class TestCollectionStarting : TestCollectionMessage, Abstractions.ITestCollectionStarting, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestCollectionStarting(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestCollection testCollection) : base(default!, default!) { }
    }

    public partial class TestFailed : TestResultMessage, Abstractions.ITestFailed, Abstractions.ITestResultMessage, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage, Abstractions.IFailureInformation
    {
        public TestFailed(Abstractions.ITest test, decimal executionTime, string output, System.Exception ex) : base(default!, default, default!) { }

        public TestFailed(Abstractions.ITest test, decimal executionTime, string output, string[] exceptionTypes, string[] messages, string[] stackTraces, int[] exceptionParentIndices) : base(default!, default, default!) { }

        public int[] ExceptionParentIndices { get { throw null; } }

        public string[] ExceptionTypes { get { throw null; } }

        public string[] Messages { get { throw null; } }

        public string[] StackTraces { get { throw null; } }
    }

    public partial class TestFinished : TestMessage, Abstractions.ITestFinished, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestFinished(Abstractions.ITest test, decimal executionTime, string output) : base(default!) { }

        public decimal ExecutionTime { get { throw null; } }

        public string Output { get { throw null; } }
    }

    public abstract partial class TestFramework : LongLivedMarshalByRefObject, Abstractions.ITestFramework, System.IDisposable
    {
        protected TestFramework(Abstractions.IMessageSink diagnosticMessageSink) { }

        public Abstractions.IMessageSink DiagnosticMessageSink { get { throw null; } }

        protected DisposalTracker DisposalTracker { get { throw null; } set { } }

        public Abstractions.ISourceInformationProvider SourceInformationProvider { get { throw null; } set { } }

        protected abstract Abstractions.ITestFrameworkDiscoverer CreateDiscoverer(Abstractions.IAssemblyInfo assemblyInfo);
        protected abstract Abstractions.ITestFrameworkExecutor CreateExecutor(System.Reflection.AssemblyName assemblyName);
        public void Dispose() { }

        public Abstractions.ITestFrameworkDiscoverer GetDiscoverer(Abstractions.IAssemblyInfo assemblyInfo) { throw null; }

        public Abstractions.ITestFrameworkExecutor GetExecutor(System.Reflection.AssemblyName assemblyName) { throw null; }
    }

    public abstract partial class TestFrameworkDiscoverer : LongLivedMarshalByRefObject, Abstractions.ITestFrameworkDiscoverer, System.IDisposable
    {
        protected TestFrameworkDiscoverer(Abstractions.IAssemblyInfo assemblyInfo, Abstractions.ISourceInformationProvider sourceProvider, Abstractions.IMessageSink diagnosticMessageSink) { }

        protected internal Abstractions.IAssemblyInfo AssemblyInfo { get { throw null; } set { } }

        protected Abstractions.IMessageSink DiagnosticMessageSink { get { throw null; } set { } }

        protected DisposalTracker DisposalTracker { get { throw null; } set { } }

        protected Abstractions.ISourceInformationProvider SourceProvider { get { throw null; } set { } }

        public string TargetFramework { get { throw null; } }

        public string TestFrameworkDisplayName { get { throw null; } protected set { } }

        protected internal abstract Abstractions.ITestClass CreateTestClass(Abstractions.ITypeInfo @class);
        public void Dispose() { }

        public void Find(bool includeSourceInformation, Abstractions.IMessageSink discoveryMessageSink, Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { }

        public void Find(string typeName, bool includeSourceInformation, Abstractions.IMessageSink discoveryMessageSink, Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { }

        protected abstract bool FindTestsForType(Abstractions.ITestClass testClass, bool includeSourceInformation, IMessageBus messageBus, Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions);
        protected virtual bool IsValidTestClass(Abstractions.ITypeInfo type) { throw null; }

        protected bool ReportDiscoveredTestCase(Abstractions.ITestCase testCase, bool includeSourceInformation, IMessageBus messageBus) { throw null; }

        public virtual string Serialize(Abstractions.ITestCase testCase) { throw null; }
    }

    public abstract partial class TestFrameworkExecutor<TTestCase> : LongLivedMarshalByRefObject, Abstractions.ITestFrameworkExecutor, System.IDisposable where TTestCase : Abstractions.ITestCase
    {
        protected TestFrameworkExecutor(System.Reflection.AssemblyName assemblyName, Abstractions.ISourceInformationProvider sourceInformationProvider, Abstractions.IMessageSink diagnosticMessageSink) { }

        protected Abstractions.IAssemblyInfo AssemblyInfo { get { throw null; } set { } }

        protected Abstractions.IMessageSink DiagnosticMessageSink { get { throw null; } set { } }

        protected DisposalTracker DisposalTracker { get { throw null; } set { } }

        protected Abstractions.ISourceInformationProvider SourceInformationProvider { get { throw null; } set { } }

        protected abstract Abstractions.ITestFrameworkDiscoverer CreateDiscoverer();
        public virtual Abstractions.ITestCase Deserialize(string value) { throw null; }

        public void Dispose() { }

        public virtual void RunAll(Abstractions.IMessageSink executionMessageSink, Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Abstractions.ITestFrameworkExecutionOptions executionOptions) { }

        protected abstract void RunTestCases(System.Collections.Generic.IEnumerable<TTestCase> testCases, Abstractions.IMessageSink executionMessageSink, Abstractions.ITestFrameworkExecutionOptions executionOptions);
        public virtual void RunTests(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.IMessageSink executionMessageSink, Abstractions.ITestFrameworkExecutionOptions executionOptions) { }
    }

    public partial class TestFrameworkProxy : LongLivedMarshalByRefObject, Abstractions.ITestFramework, System.IDisposable
    {
        public TestFrameworkProxy(object testAssemblyObject, object sourceInformationProviderObject, object diagnosticMessageSinkObject) { }

        public Abstractions.ITestFramework InnerTestFramework { get { throw null; } }

        public Abstractions.ISourceInformationProvider SourceInformationProvider { set { } }

        public void Dispose() { }

        public Abstractions.ITestFrameworkDiscoverer GetDiscoverer(Abstractions.IAssemblyInfo assembly) { throw null; }

        public Abstractions.ITestFrameworkExecutor GetExecutor(System.Reflection.AssemblyName assemblyName) { throw null; }

        public partial class MessageSinkWrapper : LongLivedMarshalByRefObject, Abstractions.IMessageSink
        {
            public readonly Abstractions.IMessageSink InnerSink;
            public MessageSinkWrapper(Abstractions.IMessageSink innerSink) { }

            public bool OnMessage(Abstractions.IMessageSinkMessage message) { throw null; }
        }
    }

    public partial class TestFrameworkTypeDiscoverer : ITestFrameworkTypeDiscoverer
    {
        public System.Type GetTestFrameworkType(Abstractions.IAttributeInfo attribute) { throw null; }
    }

    public abstract partial class TestInvoker<TTestCase>
        where TTestCase : Abstractions.ITestCase
    {
        protected TestInvoker(Abstractions.ITest test, IMessageBus messageBus, System.Type testClass, object[] constructorArguments, System.Reflection.MethodInfo testMethod, object[] testMethodArguments, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) { }

        protected ExceptionAggregator Aggregator { get { throw null; } set { } }

        protected System.Threading.CancellationTokenSource CancellationTokenSource { get { throw null; } set { } }

        protected object[] ConstructorArguments { get { throw null; } set { } }

        protected string DisplayName { get { throw null; } }

        protected IMessageBus MessageBus { get { throw null; } set { } }

        protected Abstractions.ITest Test { get { throw null; } set { } }

        protected TTestCase TestCase { get { throw null; } }

        protected System.Type TestClass { get { throw null; } set { } }

        protected System.Reflection.MethodInfo TestMethod { get { throw null; } set { } }

        protected object[] TestMethodArguments { get { throw null; } set { } }

        protected ExecutionTimer Timer { get { throw null; } set { } }

        protected virtual System.Threading.Tasks.Task AfterTestMethodInvokedAsync() { throw null; }

        protected virtual System.Threading.Tasks.Task BeforeTestMethodInvokedAsync() { throw null; }

        protected virtual object CallTestMethod(object testClassInstance) { throw null; }

        protected virtual object CreateTestClass() { throw null; }

        public static System.Threading.Tasks.Task GetTaskFromResult(object obj) { throw null; }

        protected virtual System.Threading.Tasks.Task<decimal> InvokeTestMethodAsync(object testClassInstance) { throw null; }

        public System.Threading.Tasks.Task<decimal> RunAsync() { throw null; }
    }

    public partial class TestMessage : TestCaseMessage, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage
    {
        public TestMessage(Abstractions.ITest test) : base(default!) { }

        public Abstractions.ITest Test { get { throw null; } }
    }

    public partial class TestMethod : LongLivedMarshalByRefObject, Abstractions.ITestMethod, Abstractions.IXunitSerializable
    {
        [System.Obsolete("Called by the de-serializer; should only be called by deriving classes for de-serialization purposes")]
        public TestMethod() { }

        public TestMethod(Abstractions.ITestClass @class, Abstractions.IMethodInfo method) { }

        public Abstractions.IMethodInfo Method { get { throw null; } set { } }

        public Abstractions.ITestClass TestClass { get { throw null; } set { } }

        public void Deserialize(Abstractions.IXunitSerializationInfo info) { }

        public void Serialize(Abstractions.IXunitSerializationInfo info) { }
    }

    public partial class TestMethodCleanupFailure : TestMethodMessage, Abstractions.ITestMethodCleanupFailure, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage, Abstractions.IFailureInformation
    {
        public TestMethodCleanupFailure(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestMethod testMethod, System.Exception ex) : base(default!, default!) { }

        public TestMethodCleanupFailure(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestMethod testMethod, string[] exceptionTypes, string[] messages, string[] stackTraces, int[] exceptionParentIndices) : base(default!, default!) { }

        public int[] ExceptionParentIndices { get { throw null; } }

        public string[] ExceptionTypes { get { throw null; } }

        public string[] Messages { get { throw null; } }

        public string[] StackTraces { get { throw null; } }
    }

    public partial class TestMethodComparer : System.Collections.Generic.IEqualityComparer<Abstractions.ITestMethod>
    {
        public static readonly TestMethodComparer Instance;
        public bool Equals(Abstractions.ITestMethod x, Abstractions.ITestMethod y) { throw null; }

        public int GetHashCode(Abstractions.ITestMethod obj) { throw null; }
    }

    public partial class TestMethodFinished : TestMethodMessage, Abstractions.ITestMethodFinished, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage, Abstractions.IFinishedMessage
    {
        public TestMethodFinished(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestMethod testMethod, decimal executionTime, int testsRun, int testsFailed, int testsSkipped) : base(default!, default!) { }

        public decimal ExecutionTime { get { throw null; } }

        public int TestsFailed { get { throw null; } }

        public int TestsRun { get { throw null; } }

        public int TestsSkipped { get { throw null; } }
    }

    public partial class TestMethodMessage : TestClassMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage
    {
        public TestMethodMessage(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestMethod testMethod) : base(default!, default!) { }

        public Abstractions.ITestMethod TestMethod { get { throw null; } set { } }
    }

    public abstract partial class TestMethodRunner<TTestCase>
        where TTestCase : Abstractions.ITestCase
    {
        protected TestMethodRunner(Abstractions.ITestMethod testMethod, Abstractions.IReflectionTypeInfo @class, Abstractions.IReflectionMethodInfo method, System.Collections.Generic.IEnumerable<TTestCase> testCases, IMessageBus messageBus, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) { }

        protected ExceptionAggregator Aggregator { get { throw null; } set { } }

        protected System.Threading.CancellationTokenSource CancellationTokenSource { get { throw null; } set { } }

        protected Abstractions.IReflectionTypeInfo Class { get { throw null; } set { } }

        protected IMessageBus MessageBus { get { throw null; } set { } }

        protected Abstractions.IReflectionMethodInfo Method { get { throw null; } set { } }

        protected System.Collections.Generic.IEnumerable<TTestCase> TestCases { get { throw null; } set { } }

        protected Abstractions.ITestMethod TestMethod { get { throw null; } set { } }

        protected virtual void AfterTestMethodStarting() { }

        protected virtual void BeforeTestMethodFinished() { }

        public System.Threading.Tasks.Task<RunSummary> RunAsync() { throw null; }

        protected abstract System.Threading.Tasks.Task<RunSummary> RunTestCaseAsync(TTestCase testCase);
        protected virtual System.Threading.Tasks.Task<RunSummary> RunTestCasesAsync() { throw null; }
    }

    public partial class TestMethodStarting : TestMethodMessage, Abstractions.ITestMethodStarting, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestMethodStarting(System.Collections.Generic.IEnumerable<Abstractions.ITestCase> testCases, Abstractions.ITestMethod testMethod) : base(default!, default!) { }
    }

    public abstract partial class TestMethodTestCase : LongLivedMarshalByRefObject, Abstractions.ITestCase, Abstractions.IXunitSerializable, System.IDisposable
    {
        protected TestMethodTestCase() { }

        [System.Obsolete("Please call the constructor which takes TestMethodDisplayOptions")]
        protected TestMethodTestCase(TestMethodDisplay defaultMethodDisplay, Abstractions.ITestMethod testMethod, object[] testMethodArguments = null) { }

        protected TestMethodTestCase(TestMethodDisplay defaultMethodDisplay, TestMethodDisplayOptions defaultMethodDisplayOptions, Abstractions.ITestMethod testMethod, object[] testMethodArguments = null) { }

        protected string BaseDisplayName { get { throw null; } }

        protected internal TestMethodDisplay DefaultMethodDisplay { get { throw null; } }

        protected internal TestMethodDisplayOptions DefaultMethodDisplayOptions { get { throw null; } }

        public string DisplayName { get { throw null; } protected set { } }

        public System.Exception InitializationException { get { throw null; } protected set { } }

        public Abstractions.IMethodInfo Method { get { throw null; } protected set { } }

        protected Abstractions.ITypeInfo[] MethodGenericTypes { get { throw null; } }

        public string SkipReason { get { throw null; } protected set { } }

        public Abstractions.ISourceInformation SourceInformation { get { throw null; } set { } }

        public Abstractions.ITestMethod TestMethod { get { throw null; } protected set { } }

        public object[] TestMethodArguments { get { throw null; } protected set { } }

        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> Traits { get { throw null; } protected set { } }

        public string UniqueID { get { throw null; } }

        public virtual void Deserialize(Abstractions.IXunitSerializationInfo data) { }

        public virtual void Dispose() { }

        protected void EnsureInitialized() { }

        protected virtual string GetUniqueID() { throw null; }

        protected virtual void Initialize() { }

        public virtual void Serialize(Abstractions.IXunitSerializationInfo data) { }
    }

    public partial class TestOutput : TestMessage, Abstractions.ITestOutput, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestOutput(Abstractions.ITest test, string output) : base(default!) { }

        public string Output { get { throw null; } }
    }

    public partial class TestOutputHelper : Abstractions.ITestOutputHelper
    {
        public string Output { get { throw null; } }

        public void Initialize(IMessageBus messageBus, Abstractions.ITest test) { }

        public void Uninitialize() { }

        public void WriteLine(string format, params object[] args) { }

        public void WriteLine(string message) { }
    }

    public partial class TestPassed : TestResultMessage, Abstractions.ITestPassed, Abstractions.ITestResultMessage, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestPassed(Abstractions.ITest test, decimal executionTime, string output) : base(default!, default, default!) { }
    }

    public partial class TestResultMessage : TestMessage, Abstractions.ITestResultMessage, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage
    {
        public TestResultMessage(Abstractions.ITest test, decimal executionTime, string output) : base(default!) { }

        public decimal ExecutionTime { get { throw null; } }

        public string Output { get { throw null; } }
    }

    public abstract partial class TestRunner<TTestCase>
        where TTestCase : Abstractions.ITestCase
    {
        protected TestRunner(Abstractions.ITest test, IMessageBus messageBus, System.Type testClass, object[] constructorArguments, System.Reflection.MethodInfo testMethod, object[] testMethodArguments, string skipReason, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) { }

        protected ExceptionAggregator Aggregator { get { throw null; } set { } }

        protected System.Threading.CancellationTokenSource CancellationTokenSource { get { throw null; } set { } }

        protected object[] ConstructorArguments { get { throw null; } set { } }

        protected string DisplayName { get { throw null; } }

        protected IMessageBus MessageBus { get { throw null; } set { } }

        protected string SkipReason { get { throw null; } set { } }

        protected Abstractions.ITest Test { get { throw null; } set { } }

        protected TTestCase TestCase { get { throw null; } }

        protected System.Type TestClass { get { throw null; } set { } }

        protected System.Reflection.MethodInfo TestMethod { get { throw null; } set { } }

        protected object[] TestMethodArguments { get { throw null; } set { } }

        protected virtual void AfterTestStarting() { }

        protected virtual void BeforeTestFinished() { }

        protected abstract System.Threading.Tasks.Task<System.Tuple<decimal, string>> InvokeTestAsync(ExceptionAggregator aggregator);
        public System.Threading.Tasks.Task<RunSummary> RunAsync() { throw null; }
    }

    public partial class TestSkipped : TestResultMessage, Abstractions.ITestSkipped, Abstractions.ITestResultMessage, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestSkipped(Abstractions.ITest test, string reason) : base(default!, default, default!) { }

        public string Reason { get { throw null; } }
    }

    public partial class TestStarting : TestMessage, Abstractions.ITestStarting, Abstractions.ITestMessage, Abstractions.ITestCaseMessage, Abstractions.ITestMethodMessage, Abstractions.ITestClassMessage, Abstractions.ITestCollectionMessage, Abstractions.ITestAssemblyMessage, Abstractions.IMessageSinkMessage, Abstractions.IExecutionMessage
    {
        public TestStarting(Abstractions.ITest test) : base(default!) { }
    }

    public partial class TestTimeoutException : System.Exception
    {
        public TestTimeoutException(int timeout) { }
    }

    public partial class TheoryDiscoverer : IXunitTestCaseDiscoverer
    {
        public TheoryDiscoverer(Abstractions.IMessageSink diagnosticMessageSink) { }

        protected Abstractions.IMessageSink DiagnosticMessageSink { get { throw null; } }

        [System.Obsolete("Please override CreateTestCasesForDataRow instead")]
        protected virtual IXunitTestCase CreateTestCaseForDataRow(Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Abstractions.ITestMethod testMethod, Abstractions.IAttributeInfo theoryAttribute, object[] dataRow) { throw null; }

        [System.Obsolete("Please override CreateTestCasesForSkip instead")]
        protected virtual IXunitTestCase CreateTestCaseForSkip(Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Abstractions.ITestMethod testMethod, Abstractions.IAttributeInfo theoryAttribute, string skipReason) { throw null; }

        [System.Obsolete("Please override CreateTestCasesForSkippedDataRow instead")]
        protected virtual IXunitTestCase CreateTestCaseForSkippedDataRow(Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Abstractions.ITestMethod testMethod, Abstractions.IAttributeInfo theoryAttribute, object[] dataRow, string skipReason) { throw null; }

        [System.Obsolete("Please override CreateTestCasesForTheory instead")]
        protected virtual IXunitTestCase CreateTestCaseForTheory(Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Abstractions.ITestMethod testMethod, Abstractions.IAttributeInfo theoryAttribute) { throw null; }

        protected virtual System.Collections.Generic.IEnumerable<IXunitTestCase> CreateTestCasesForDataRow(Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Abstractions.ITestMethod testMethod, Abstractions.IAttributeInfo theoryAttribute, object[] dataRow) { throw null; }

        protected virtual System.Collections.Generic.IEnumerable<IXunitTestCase> CreateTestCasesForSkip(Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Abstractions.ITestMethod testMethod, Abstractions.IAttributeInfo theoryAttribute, string skipReason) { throw null; }

        protected virtual System.Collections.Generic.IEnumerable<IXunitTestCase> CreateTestCasesForSkippedDataRow(Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Abstractions.ITestMethod testMethod, Abstractions.IAttributeInfo theoryAttribute, object[] dataRow, string skipReason) { throw null; }

        protected virtual System.Collections.Generic.IEnumerable<IXunitTestCase> CreateTestCasesForTheory(Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Abstractions.ITestMethod testMethod, Abstractions.IAttributeInfo theoryAttribute) { throw null; }

        public virtual System.Collections.Generic.IEnumerable<IXunitTestCase> Discover(Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Abstractions.ITestMethod testMethod, Abstractions.IAttributeInfo theoryAttribute) { throw null; }
    }

    public static partial class TraitHelper
    {
        public static System.Collections.Generic.IReadOnlyList<System.Collections.Generic.KeyValuePair<string, string>> GetTraits(System.Reflection.MemberInfo member) { throw null; }
    }

    public static partial class TypeUtility
    {
        public static string ConvertToSimpleTypeName(Abstractions.ITypeInfo type) { throw null; }

        public static string GetDisplayNameWithArguments(this Abstractions.IMethodInfo method, string baseDisplayName, object[] arguments, Abstractions.ITypeInfo[] genericTypes) { throw null; }

        public static Abstractions.ITypeInfo ResolveGenericType(this Abstractions.ITypeInfo genericType, object[] parameters, Abstractions.IParameterInfo[] parameterInfos) { throw null; }

        public static Abstractions.ITypeInfo[] ResolveGenericTypes(this Abstractions.IMethodInfo method, object[] parameters) { throw null; }

        public static object[] ResolveMethodArguments(this System.Reflection.MethodBase testMethod, object[] arguments) { throw null; }
    }

    public partial class XunitSkippedDataRowTestCase : XunitTestCase
    {
        [System.Obsolete("Called by the de-serializer; should only be called by deriving classes for de-serialization purposes")]
        public XunitSkippedDataRowTestCase() { }

        [System.Obsolete("Please call the constructor which takes TestMethodDisplayOptions")]
        public XunitSkippedDataRowTestCase(Abstractions.IMessageSink diagnosticMessageSink, TestMethodDisplay defaultMethodDisplay, Abstractions.ITestMethod testMethod, string skipReason, object[] testMethodArguments = null) { }

        public XunitSkippedDataRowTestCase(Abstractions.IMessageSink diagnosticMessageSink, TestMethodDisplay defaultMethodDisplay, TestMethodDisplayOptions defaultMethodDisplayOptions, Abstractions.ITestMethod testMethod, string skipReason, object[] testMethodArguments = null) { }

        public override void Deserialize(Abstractions.IXunitSerializationInfo data) { }

        protected override string GetSkipReason(Abstractions.IAttributeInfo factAttribute) { throw null; }

        public override void Serialize(Abstractions.IXunitSerializationInfo data) { }
    }

    public partial class XunitTest : LongLivedMarshalByRefObject, Abstractions.ITest
    {
        public XunitTest(IXunitTestCase testCase, string displayName) { }

        public string DisplayName { get { throw null; } }

        public IXunitTestCase TestCase { get { throw null; } }

        Abstractions.ITestCase Abstractions.ITest.TestCase { get { throw null; } }
    }

    public partial class XunitTestAssemblyRunner : TestAssemblyRunner<IXunitTestCase>
    {
        public XunitTestAssemblyRunner(Abstractions.ITestAssembly testAssembly, System.Collections.Generic.IEnumerable<IXunitTestCase> testCases, Abstractions.IMessageSink diagnosticMessageSink, Abstractions.IMessageSink executionMessageSink, Abstractions.ITestFrameworkExecutionOptions executionOptions) : base(default!, default!, default!, default!, default!) { }

        protected override System.Threading.Tasks.Task AfterTestAssemblyStartingAsync() { throw null; }

        protected override System.Threading.Tasks.Task BeforeTestAssemblyFinishedAsync() { throw null; }

        public override void Dispose() { }

        protected override string GetTestFrameworkDisplayName() { throw null; }

        protected override string GetTestFrameworkEnvironment() { throw null; }

        protected void Initialize() { }

        protected override System.Threading.Tasks.Task<RunSummary> RunTestCollectionAsync(IMessageBus messageBus, Abstractions.ITestCollection testCollection, System.Collections.Generic.IEnumerable<IXunitTestCase> testCases, System.Threading.CancellationTokenSource cancellationTokenSource) { throw null; }

        protected override System.Threading.Tasks.Task<RunSummary> RunTestCollectionsAsync(IMessageBus messageBus, System.Threading.CancellationTokenSource cancellationTokenSource) { throw null; }

        protected virtual void SetupSyncContext(int maxParallelThreads) { }
    }

    public partial class XunitTestCase : TestMethodTestCase, IXunitTestCase, Abstractions.ITestCase, Abstractions.IXunitSerializable
    {
        [System.Obsolete("Called by the de-serializer; should only be called by deriving classes for de-serialization purposes")]
        public XunitTestCase() { }

        [System.Obsolete("Please call the constructor which takes TestMethodDisplayOptions")]
        public XunitTestCase(Abstractions.IMessageSink diagnosticMessageSink, TestMethodDisplay defaultMethodDisplay, Abstractions.ITestMethod testMethod, object[] testMethodArguments = null) { }

        public XunitTestCase(Abstractions.IMessageSink diagnosticMessageSink, TestMethodDisplay defaultMethodDisplay, TestMethodDisplayOptions defaultMethodDisplayOptions, Abstractions.ITestMethod testMethod, object[] testMethodArguments = null) { }

        protected Abstractions.IMessageSink DiagnosticMessageSink { get { throw null; } }

        public int Timeout { get { throw null; } protected set { } }

        public override void Deserialize(Abstractions.IXunitSerializationInfo data) { }

        protected virtual string GetDisplayName(Abstractions.IAttributeInfo factAttribute, string displayName) { throw null; }

        protected virtual string GetSkipReason(Abstractions.IAttributeInfo factAttribute) { throw null; }

        protected virtual int GetTimeout(Abstractions.IAttributeInfo factAttribute) { throw null; }

        protected override void Initialize() { }

        public virtual System.Threading.Tasks.Task<RunSummary> RunAsync(Abstractions.IMessageSink diagnosticMessageSink, IMessageBus messageBus, object[] constructorArguments, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) { throw null; }

        public override void Serialize(Abstractions.IXunitSerializationInfo data) { }
    }

    public partial class XunitTestCaseRunner : TestCaseRunner<IXunitTestCase>
    {
        public XunitTestCaseRunner(IXunitTestCase testCase, string displayName, string skipReason, object[] constructorArguments, object[] testMethodArguments, IMessageBus messageBus, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) : base(default!, default!, default!, default!) { }

        public System.Collections.Generic.IReadOnlyList<BeforeAfterTestAttribute> BeforeAfterAttributes { get { throw null; } }

        protected object[] ConstructorArguments { get { throw null; } set { } }

        protected string DisplayName { get { throw null; } set { } }

        protected string SkipReason { get { throw null; } set { } }

        protected System.Type TestClass { get { throw null; } set { } }

        protected System.Reflection.MethodInfo TestMethod { get { throw null; } set { } }

        protected object[] TestMethodArguments { get { throw null; } set { } }

        protected virtual Abstractions.ITest CreateTest(IXunitTestCase testCase, string displayName) { throw null; }

        protected virtual XunitTestRunner CreateTestRunner(Abstractions.ITest test, IMessageBus messageBus, System.Type testClass, object[] constructorArguments, System.Reflection.MethodInfo testMethod, object[] testMethodArguments, string skipReason, System.Collections.Generic.IReadOnlyList<BeforeAfterTestAttribute> beforeAfterAttributes, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) { throw null; }

        protected virtual System.Collections.Generic.List<BeforeAfterTestAttribute> GetBeforeAfterTestAttributes() { throw null; }

        protected override System.Threading.Tasks.Task<RunSummary> RunTestAsync() { throw null; }
    }

    public partial class XunitTestClassRunner : TestClassRunner<IXunitTestCase>
    {
        public XunitTestClassRunner(Abstractions.ITestClass testClass, Abstractions.IReflectionTypeInfo @class, System.Collections.Generic.IEnumerable<IXunitTestCase> testCases, Abstractions.IMessageSink diagnosticMessageSink, IMessageBus messageBus, ITestCaseOrderer testCaseOrderer, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource, System.Collections.Generic.IDictionary<System.Type, object> collectionFixtureMappings) : base(default!, default!, default!, default!, default!, default!, default!, default!) { }

        protected System.Collections.Generic.Dictionary<System.Type, object> ClassFixtureMappings { get { throw null; } set { } }

        protected System.Collections.Generic.HashSet<IAsyncLifetime> InitializedAsyncFixtures { get { throw null; } set { } }

        protected override System.Threading.Tasks.Task AfterTestClassStartingAsync() { throw null; }

        protected override System.Threading.Tasks.Task BeforeTestClassFinishedAsync() { throw null; }

        protected virtual void CreateClassFixture(System.Type fixtureType) { }

        protected override string FormatConstructorArgsMissingMessage(System.Reflection.ConstructorInfo constructor, System.Collections.Generic.IReadOnlyList<System.Tuple<int, System.Reflection.ParameterInfo>> unusedArguments) { throw null; }

        protected override System.Threading.Tasks.Task<RunSummary> RunTestMethodAsync(Abstractions.ITestMethod testMethod, Abstractions.IReflectionMethodInfo method, System.Collections.Generic.IEnumerable<IXunitTestCase> testCases, object[] constructorArguments) { throw null; }

        protected override System.Reflection.ConstructorInfo SelectTestClassConstructor() { throw null; }

        protected override bool TryGetConstructorArgument(System.Reflection.ConstructorInfo constructor, int index, System.Reflection.ParameterInfo parameter, out object argumentValue) { throw null; }
    }

    public partial class XunitTestCollectionRunner : TestCollectionRunner<IXunitTestCase>
    {
        public XunitTestCollectionRunner(Abstractions.ITestCollection testCollection, System.Collections.Generic.IEnumerable<IXunitTestCase> testCases, Abstractions.IMessageSink diagnosticMessageSink, IMessageBus messageBus, ITestCaseOrderer testCaseOrderer, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) : base(default!, default!, default!, default!, default!, default!) { }

        protected System.Collections.Generic.Dictionary<System.Type, object> CollectionFixtureMappings { get { throw null; } set { } }

        protected Abstractions.IMessageSink DiagnosticMessageSink { get { throw null; } }

        protected override System.Threading.Tasks.Task AfterTestCollectionStartingAsync() { throw null; }

        protected override System.Threading.Tasks.Task BeforeTestCollectionFinishedAsync() { throw null; }

        protected virtual void CreateCollectionFixture(System.Type fixtureType) { }

        protected virtual ITestCaseOrderer GetTestCaseOrderer() { throw null; }

        protected override System.Threading.Tasks.Task<RunSummary> RunTestClassAsync(Abstractions.ITestClass testClass, Abstractions.IReflectionTypeInfo @class, System.Collections.Generic.IEnumerable<IXunitTestCase> testCases) { throw null; }
    }

    public partial class XunitTestFramework : TestFramework
    {
        public XunitTestFramework(Abstractions.IMessageSink messageSink) : base(default!) { }

        protected override Abstractions.ITestFrameworkDiscoverer CreateDiscoverer(Abstractions.IAssemblyInfo assemblyInfo) { throw null; }

        protected override Abstractions.ITestFrameworkExecutor CreateExecutor(System.Reflection.AssemblyName assemblyName) { throw null; }
    }

    public partial class XunitTestFrameworkDiscoverer : TestFrameworkDiscoverer
    {
        public static readonly string DisplayName;
        public XunitTestFrameworkDiscoverer(Abstractions.IAssemblyInfo assemblyInfo, Abstractions.ISourceInformationProvider sourceProvider, Abstractions.IMessageSink diagnosticMessageSink, IXunitTestCollectionFactory collectionFactory = null) : base(default!, default!, default!) { }

        protected System.Collections.Generic.Dictionary<System.Type, System.Type> DiscovererTypeCache { get { throw null; } }

        public IXunitTestCollectionFactory TestCollectionFactory { get { throw null; } }

        protected internal override Abstractions.ITestClass CreateTestClass(Abstractions.ITypeInfo @class) { throw null; }

        protected internal virtual bool FindTestsForMethod(Abstractions.ITestMethod testMethod, bool includeSourceInformation, IMessageBus messageBus, Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { throw null; }

        protected override bool FindTestsForType(Abstractions.ITestClass testClass, bool includeSourceInformation, IMessageBus messageBus, Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions) { throw null; }

        protected IXunitTestCaseDiscoverer GetDiscoverer(System.Type discovererType) { throw null; }

        public override string Serialize(Abstractions.ITestCase testCase) { throw null; }
    }

    public partial class XunitTestFrameworkExecutor : TestFrameworkExecutor<IXunitTestCase>
    {
        public XunitTestFrameworkExecutor(System.Reflection.AssemblyName assemblyName, Abstractions.ISourceInformationProvider sourceInformationProvider, Abstractions.IMessageSink diagnosticMessageSink) : base(default!, default!, default!) { }

        protected TestAssembly TestAssembly { get { throw null; } set { } }

        protected override Abstractions.ITestFrameworkDiscoverer CreateDiscoverer() { throw null; }

        public override Abstractions.ITestCase Deserialize(string value) { throw null; }

        protected override void RunTestCases(System.Collections.Generic.IEnumerable<IXunitTestCase> testCases, Abstractions.IMessageSink executionMessageSink, Abstractions.ITestFrameworkExecutionOptions executionOptions) { }
    }

    public partial class XunitTestInvoker : TestInvoker<IXunitTestCase>
    {
        public XunitTestInvoker(Abstractions.ITest test, IMessageBus messageBus, System.Type testClass, object[] constructorArguments, System.Reflection.MethodInfo testMethod, object[] testMethodArguments, System.Collections.Generic.IReadOnlyList<BeforeAfterTestAttribute> beforeAfterAttributes, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) : base(default!, default!, default!, default!, default!, default!, default!, default!) { }

        protected System.Collections.Generic.IReadOnlyList<BeforeAfterTestAttribute> BeforeAfterAttributes { get { throw null; } }

        protected override System.Threading.Tasks.Task AfterTestMethodInvokedAsync() { throw null; }

        protected override System.Threading.Tasks.Task BeforeTestMethodInvokedAsync() { throw null; }

        protected override System.Threading.Tasks.Task<decimal> InvokeTestMethodAsync(object testClassInstance) { throw null; }
    }

    public partial class XunitTestMethodRunner : TestMethodRunner<IXunitTestCase>
    {
        public XunitTestMethodRunner(Abstractions.ITestMethod testMethod, Abstractions.IReflectionTypeInfo @class, Abstractions.IReflectionMethodInfo method, System.Collections.Generic.IEnumerable<IXunitTestCase> testCases, Abstractions.IMessageSink diagnosticMessageSink, IMessageBus messageBus, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource, object[] constructorArguments) : base(default!, default!, default!, default!, default!, default!, default!) { }

        protected override System.Threading.Tasks.Task<RunSummary> RunTestCaseAsync(IXunitTestCase testCase) { throw null; }
    }

    public partial class XunitTestRunner : TestRunner<IXunitTestCase>
    {
        public XunitTestRunner(Abstractions.ITest test, IMessageBus messageBus, System.Type testClass, object[] constructorArguments, System.Reflection.MethodInfo testMethod, object[] testMethodArguments, string skipReason, System.Collections.Generic.IReadOnlyList<BeforeAfterTestAttribute> beforeAfterAttributes, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) : base(default!, default!, default!, default!, default!, default!, default!, default!, default!) { }

        protected System.Collections.Generic.IReadOnlyList<BeforeAfterTestAttribute> BeforeAfterAttributes { get { throw null; } }

        protected override System.Threading.Tasks.Task<System.Tuple<decimal, string>> InvokeTestAsync(ExceptionAggregator aggregator) { throw null; }

        protected virtual System.Threading.Tasks.Task<decimal> InvokeTestMethodAsync(ExceptionAggregator aggregator) { throw null; }
    }

    public partial class XunitTheoryTestCase : XunitTestCase
    {
        [System.Obsolete("Called by the de-serializer; should only be called by deriving classes for de-serialization purposes")]
        public XunitTheoryTestCase() { }

        [System.Obsolete("Please call the constructor which takes TestMethodDisplayOptions")]
        public XunitTheoryTestCase(Abstractions.IMessageSink diagnosticMessageSink, TestMethodDisplay defaultMethodDisplay, Abstractions.ITestMethod testMethod) { }

        public XunitTheoryTestCase(Abstractions.IMessageSink diagnosticMessageSink, TestMethodDisplay defaultMethodDisplay, TestMethodDisplayOptions defaultMethodDisplayOptions, Abstractions.ITestMethod testMethod) { }

        public override System.Threading.Tasks.Task<RunSummary> RunAsync(Abstractions.IMessageSink diagnosticMessageSink, IMessageBus messageBus, object[] constructorArguments, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) { throw null; }
    }

    public partial class XunitTheoryTestCaseRunner : XunitTestCaseRunner
    {
        public XunitTheoryTestCaseRunner(IXunitTestCase testCase, string displayName, string skipReason, object[] constructorArguments, Abstractions.IMessageSink diagnosticMessageSink, IMessageBus messageBus, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource) : base(default!, default!, default!, default!, default!, default!, default!, default!) { }

        protected Abstractions.IMessageSink DiagnosticMessageSink { get { throw null; } }

        protected override System.Threading.Tasks.Task AfterTestCaseStartingAsync() { throw null; }

        protected override System.Threading.Tasks.Task BeforeTestCaseFinishedAsync() { throw null; }

        protected override System.Threading.Tasks.Task<RunSummary> RunTestAsync() { throw null; }
    }
}