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
[assembly: System.Reflection.AssemblyTitle("xUnit.net Core")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Runtime.Versioning.TargetFramework(".NETStandard,Version=v1.1", FrameworkDisplayName = "")]
[assembly: System.Reflection.AssemblyConfiguration("Release")]
[assembly: System.Reflection.AssemblyVersionAttribute("2.6.1.0")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace Xunit
{
    [Sdk.TraitDiscoverer("Xunit.Sdk.AssemblyTraitDiscoverer", "xunit.core")]
    [System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed partial class AssemblyTraitAttribute : System.Attribute, Sdk.ITraitAttribute
    {
        public AssemblyTraitAttribute(string name, string value) { }
    }

    [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public partial class ClassDataAttribute : Sdk.DataAttribute
    {
        public ClassDataAttribute(System.Type @class) { }

        public System.Type Class { get { throw null; } }

        public override System.Collections.Generic.IEnumerable<object[]> GetData(System.Reflection.MethodInfo testMethod) { throw null; }
    }

    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed partial class CollectionAttribute : System.Attribute
    {
        public CollectionAttribute(string name) { }
    }

    public enum CollectionBehavior
    {
        CollectionPerAssembly = 0,
        CollectionPerClass = 1
    }

    [System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = false)]
    public sealed partial class CollectionBehaviorAttribute : System.Attribute
    {
        public CollectionBehaviorAttribute() { }

        public CollectionBehaviorAttribute(string factoryTypeName, string factoryAssemblyName) { }

        public CollectionBehaviorAttribute(CollectionBehavior collectionBehavior) { }

        public bool DisableTestParallelization { get { throw null; } set { } }

        public int MaxParallelThreads { get { throw null; } set { } }
    }

    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed partial class CollectionDefinitionAttribute : System.Attribute
    {
        public CollectionDefinitionAttribute(string name) { }

        public bool DisableParallelization { get { throw null; } set { } }
    }

    [Sdk.XunitTestCaseDiscoverer("Xunit.Sdk.FactDiscoverer", "xunit.execution.{Platform}")]
    [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
    public partial class FactAttribute : System.Attribute
    {
        public virtual string DisplayName { get { throw null; } set { } }

        public virtual string Skip { get { throw null; } set { } }

        public virtual int Timeout { get { throw null; } set { } }
    }

    public partial interface IAsyncLifetime
    {
        System.Threading.Tasks.Task DisposeAsync();
        System.Threading.Tasks.Task InitializeAsync();
    }

    public partial interface IClassFixture<TFixture>
        where TFixture : class
    {
    }

    public partial interface ICollectionFixture<TFixture>
        where TFixture : class
    {
    }

    [System.CLSCompliant(false)]
    [Sdk.DataDiscoverer("Xunit.Sdk.InlineDataDiscoverer", "xunit.core")]
    [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class InlineDataAttribute : Sdk.DataAttribute
    {
        public InlineDataAttribute(params object[] data) { }

        public override System.Collections.Generic.IEnumerable<object[]> GetData(System.Reflection.MethodInfo testMethod) { throw null; }
    }

    public partial interface ITestCollectionOrderer
    {
        System.Collections.Generic.IEnumerable<Abstractions.ITestCollection> OrderTestCollections(System.Collections.Generic.IEnumerable<Abstractions.ITestCollection> testCollections);
    }

    [System.CLSCompliant(false)]
    [Sdk.DataDiscoverer("Xunit.Sdk.MemberDataDiscoverer", "xunit.core")]
    [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public sealed partial class MemberDataAttribute : MemberDataAttributeBase
    {
        public MemberDataAttribute(string memberName, params object[] parameters) : base(default!, default!) { }

        protected override object[] ConvertDataItem(System.Reflection.MethodInfo testMethod, object item) { throw null; }
    }

    [System.CLSCompliant(false)]
    [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract partial class MemberDataAttributeBase : Sdk.DataAttribute
    {
        protected MemberDataAttributeBase(string memberName, object[] parameters) { }

        public bool DisableDiscoveryEnumeration { get { throw null; } set { } }

        public string MemberName { get { throw null; } }

        public System.Type MemberType { get { throw null; } set { } }

        public object[] Parameters { get { throw null; } }

        protected abstract object[] ConvertDataItem(System.Reflection.MethodInfo testMethod, object item);
        public override System.Collections.Generic.IEnumerable<object[]> GetData(System.Reflection.MethodInfo testMethod) { throw null; }
    }

    public partial class Record
    {
        public static System.Exception Exception(System.Action testCode) { throw null; }

        public static System.Exception Exception(System.Func<object> testCode) { throw null; }

        [System.Obsolete("You must call Record.ExceptionAsync (and await the result) when testing async code.", true)]
        public static System.Exception Exception(System.Func<System.Threading.Tasks.Task> testCode) { throw null; }

        public static System.Threading.Tasks.Task<System.Exception> ExceptionAsync(System.Func<System.Threading.Tasks.Task> testCode) { throw null; }
    }

    [System.AttributeUsage(System.AttributeTargets.Assembly | System.AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public sealed partial class TestCaseOrdererAttribute : System.Attribute
    {
        public TestCaseOrdererAttribute(string ordererTypeName, string ordererAssemblyName) { }
    }

    [System.AttributeUsage(System.AttributeTargets.Assembly, Inherited = true, AllowMultiple = false)]
    public sealed partial class TestCollectionOrdererAttribute : System.Attribute
    {
        public TestCollectionOrdererAttribute(string ordererTypeName, string ordererAssemblyName) { }
    }

    [Sdk.TestFrameworkDiscoverer("Xunit.Sdk.TestFrameworkTypeDiscoverer", "xunit.execution.{Platform}")]
    [System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = false)]
    public sealed partial class TestFrameworkAttribute : System.Attribute, Sdk.ITestFrameworkAttribute
    {
        public TestFrameworkAttribute(string typeName, string assemblyName) { }
    }

    [Sdk.XunitTestCaseDiscoverer("Xunit.Sdk.TheoryDiscoverer", "xunit.execution.{Platform}")]
    [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
    public partial class TheoryAttribute : FactAttribute
    {
    }

    public abstract partial class TheoryData : System.Collections.Generic.IEnumerable<object[]>, System.Collections.IEnumerable
    {
        protected void AddRow(params object[] values) { }

        public System.Collections.Generic.IEnumerator<object[]> GetEnumerator() { throw null; }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }

    public partial class TheoryData<T> : TheoryData
    {
        public void Add(T p) { }
    }

    public partial class TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : TheoryData
    {
        public void Add(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10) { }
    }

    public partial class TheoryData<T1, T2> : TheoryData
    {
        public void Add(T1 p1, T2 p2) { }
    }

    public partial class TheoryData<T1, T2, T3> : TheoryData
    {
        public void Add(T1 p1, T2 p2, T3 p3) { }
    }

    public partial class TheoryData<T1, T2, T3, T4> : TheoryData
    {
        public void Add(T1 p1, T2 p2, T3 p3, T4 p4) { }
    }

    public partial class TheoryData<T1, T2, T3, T4, T5> : TheoryData
    {
        public void Add(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5) { }
    }

    public partial class TheoryData<T1, T2, T3, T4, T5, T6> : TheoryData
    {
        public void Add(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6) { }
    }

    public partial class TheoryData<T1, T2, T3, T4, T5, T6, T7> : TheoryData
    {
        public void Add(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7) { }
    }

    public partial class TheoryData<T1, T2, T3, T4, T5, T6, T7, T8> : TheoryData
    {
        public void Add(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8) { }
    }

    public partial class TheoryData<T1, T2, T3, T4, T5, T6, T7, T8, T9> : TheoryData
    {
        public void Add(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9) { }
    }

    [Sdk.TraitDiscoverer("Xunit.Sdk.TraitDiscoverer", "xunit.core")]
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class TraitAttribute : System.Attribute, Sdk.ITraitAttribute
    {
        public TraitAttribute(string name, string value) { }
    }
}

namespace Xunit.Extensions
{
    [System.Obsolete("Please replace [PropertyData] with [MemberData]", true)]
    public sealed partial class PropertyDataAttribute : System.Attribute
    {
        public PropertyDataAttribute(string propertyName) { }

        public System.Type PropertyType { get { throw null; } set { } }
    }
}

namespace Xunit.Sdk
{
    public partial class AssemblyTraitDiscoverer : ITraitDiscoverer
    {
        public virtual System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> GetTraits(Abstractions.IAttributeInfo traitAttribute) { throw null; }
    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract partial class BeforeAfterTestAttribute : System.Attribute
    {
        public virtual void After(System.Reflection.MethodInfo methodUnderTest) { }

        public virtual void Before(System.Reflection.MethodInfo methodUnderTest) { }
    }

    [DataDiscoverer("Xunit.Sdk.DataDiscoverer", "xunit.core")]
    [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract partial class DataAttribute : System.Attribute
    {
        public virtual string Skip { get { throw null; } set { } }

        public abstract System.Collections.Generic.IEnumerable<object[]> GetData(System.Reflection.MethodInfo testMethod);
    }

    public partial class DataDiscoverer : IDataDiscoverer
    {
        public virtual System.Collections.Generic.IEnumerable<object[]> GetData(Abstractions.IAttributeInfo dataAttribute, Abstractions.IMethodInfo testMethod) { throw null; }

        public virtual bool SupportsDiscoveryEnumeration(Abstractions.IAttributeInfo dataAttribute, Abstractions.IMethodInfo testMethod) { throw null; }
    }

    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed partial class DataDiscovererAttribute : System.Attribute
    {
        public DataDiscovererAttribute(string typeName, string assemblyName) { }
    }

    public partial class ExceptionAggregator
    {
        public ExceptionAggregator() { }

        public ExceptionAggregator(ExceptionAggregator parent) { }

        public bool HasExceptions { get { throw null; } }

        public void Add(System.Exception ex) { }

        public void Aggregate(ExceptionAggregator aggregator) { }

        public void Clear() { }

        public void Run(System.Action code) { }

        public System.Threading.Tasks.Task RunAsync(System.Func<System.Threading.Tasks.Task> code) { throw null; }

        public System.Threading.Tasks.Task<T> RunAsync<T>(System.Func<System.Threading.Tasks.Task<T>> code) { throw null; }

        public System.Exception ToException() { throw null; }
    }

    public partial interface IDataDiscoverer
    {
        System.Collections.Generic.IEnumerable<object[]> GetData(Abstractions.IAttributeInfo dataAttribute, Abstractions.IMethodInfo testMethod);
        bool SupportsDiscoveryEnumeration(Abstractions.IAttributeInfo dataAttribute, Abstractions.IMethodInfo testMethod);
    }

    public partial interface IMessageBus : System.IDisposable
    {
        bool QueueMessage(Abstractions.IMessageSinkMessage message);
    }

    public partial class InlineDataDiscoverer : IDataDiscoverer
    {
        public virtual System.Collections.Generic.IEnumerable<object[]> GetData(Abstractions.IAttributeInfo dataAttribute, Abstractions.IMethodInfo testMethod) { throw null; }

        public virtual bool SupportsDiscoveryEnumeration(Abstractions.IAttributeInfo dataAttribute, Abstractions.IMethodInfo testMethod) { throw null; }
    }

    public partial interface ITestCaseOrderer
    {
        System.Collections.Generic.IEnumerable<TTestCase> OrderTestCases<TTestCase>(System.Collections.Generic.IEnumerable<TTestCase> testCases)
            where TTestCase : Abstractions.ITestCase;
    }

    public partial interface ITestFrameworkAttribute
    {
    }

    public partial interface ITestFrameworkTypeDiscoverer
    {
        System.Type GetTestFrameworkType(Abstractions.IAttributeInfo attribute);
    }

    public partial interface ITraitAttribute
    {
    }

    public partial interface ITraitDiscoverer
    {
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> GetTraits(Abstractions.IAttributeInfo traitAttribute);
    }

    public partial interface IXunitTestCase : Abstractions.ITestCase, Abstractions.IXunitSerializable
    {
        System.Exception InitializationException { get; }

        Abstractions.IMethodInfo Method { get; }

        int Timeout { get; }

        System.Threading.Tasks.Task<RunSummary> RunAsync(Abstractions.IMessageSink diagnosticMessageSink, IMessageBus messageBus, object[] constructorArguments, ExceptionAggregator aggregator, System.Threading.CancellationTokenSource cancellationTokenSource);
    }

    public partial interface IXunitTestCaseDiscoverer
    {
        System.Collections.Generic.IEnumerable<IXunitTestCase> Discover(Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Abstractions.ITestMethod testMethod, Abstractions.IAttributeInfo factAttribute);
    }

    public partial interface IXunitTestCollectionFactory
    {
        string DisplayName { get; }

        Abstractions.ITestCollection Get(Abstractions.ITypeInfo testClass);
    }

    public partial class MemberDataDiscoverer : DataDiscoverer
    {
        public override bool SupportsDiscoveryEnumeration(Abstractions.IAttributeInfo dataAttribute, Abstractions.IMethodInfo testMethod) { throw null; }
    }

    [System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    public sealed partial class PlatformSpecificAssemblyAttribute : System.Attribute
    {
    }

    public partial class RunSummary
    {
        public int Failed;
        public int Skipped;
        public decimal Time;
        public int Total;
        public void Aggregate(RunSummary other) { }
    }

    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed partial class TestFrameworkDiscovererAttribute : System.Attribute
    {
        public TestFrameworkDiscovererAttribute(string typeName, string assemblyName) { }
    }

    public enum TestMethodDisplay
    {
        ClassAndMethod = 1,
        Method = 2
    }

    [System.Flags]
    public enum TestMethodDisplayOptions
    {
        None = 0,
        ReplaceUnderscoreWithSpace = 1,
        UseOperatorMonikers = 2,
        UseEscapeSequences = 4,
        ReplacePeriodWithComma = 8,
        All = 15
    }

    public partial class TraitDiscoverer : ITraitDiscoverer
    {
        public virtual System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> GetTraits(Abstractions.IAttributeInfo traitAttribute) { throw null; }
    }

    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed partial class TraitDiscovererAttribute : System.Attribute
    {
        public TraitDiscovererAttribute(string typeName, string assemblyName) { }
    }

    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed partial class XunitTestCaseDiscovererAttribute : System.Attribute
    {
        public XunitTestCaseDiscovererAttribute(string typeName, string assemblyName) { }
    }
}