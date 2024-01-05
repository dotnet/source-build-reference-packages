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
[assembly: System.Reflection.AssemblyTitle("xUnit.net Assertion Library")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Runtime.Versioning.TargetFramework(".NETStandard,Version=v1.1", FrameworkDisplayName = "")]
[assembly: System.Reflection.AssemblyConfiguration("Release")]
[assembly: System.Reflection.AssemblyVersionAttribute("2.6.1.0")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace Xunit
{
    public partial class Assert
    {
        protected Assert() { }

        public static void All<T>(System.Collections.Generic.IEnumerable<T> collection, System.Action<T, int> action) { }

        public static void All<T>(System.Collections.Generic.IEnumerable<T> collection, System.Action<T> action) { }

        public static System.Threading.Tasks.Task AllAsync<T>(System.Collections.Generic.IEnumerable<T> collection, System.Func<T, int, System.Threading.Tasks.Task> action) { throw null; }

        public static System.Threading.Tasks.Task AllAsync<T>(System.Collections.Generic.IEnumerable<T> collection, System.Func<T, System.Threading.Tasks.Task> action) { throw null; }

        public static void Collection<T>(System.Collections.Generic.IEnumerable<T> collection, params System.Action<T>[] elementInspectors) { }

        public static System.Threading.Tasks.Task CollectionAsync<T>(System.Collections.Generic.IEnumerable<T> collection, params System.Func<T, System.Threading.Tasks.Task>[] elementInspectors) { throw null; }

        public static void Contains(string expectedSubstring, string? actualString, System.StringComparison comparisonType) { }

        public static void Contains(string expectedSubstring, string? actualString) { }

        public static void Contains<T>(T expected, System.Collections.Generic.HashSet<T> set) { }

        public static void Contains<T>(T expected, System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IEqualityComparer<T> comparer) { }

        public static void Contains<T>(T expected, System.Collections.Generic.IEnumerable<T> collection) { }

        public static void Contains<T>(T expected, System.Collections.Generic.ISet<T> set) { }

        public static void Contains<T>(System.Collections.Generic.IEnumerable<T> collection, System.Predicate<T> filter) { }

        public static TValue Contains<TKey, TValue>(TKey expected, System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue> collection) { throw null; }

        public static TValue Contains<TKey, TValue>(TKey expected, System.Collections.Generic.Dictionary<TKey, TValue> collection) { throw null; }

        public static TValue Contains<TKey, TValue>(TKey expected, System.Collections.Generic.IDictionary<TKey, TValue> collection) { throw null; }

        public static TValue Contains<TKey, TValue>(TKey expected, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> collection) { throw null; }

        public static TValue Contains<TKey, TValue>(TKey expected, System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue> collection) { throw null; }

        public static void Distinct<T>(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IEqualityComparer<T> comparer) { }

        public static void Distinct<T>(System.Collections.Generic.IEnumerable<T> collection) { }

        public static void DoesNotContain(string expectedSubstring, string? actualString, System.StringComparison comparisonType) { }

        public static void DoesNotContain(string expectedSubstring, string? actualString) { }

        public static void DoesNotContain<T>(T expected, System.Collections.Generic.HashSet<T> set) { }

        public static void DoesNotContain<T>(T expected, System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IEqualityComparer<T> comparer) { }

        public static void DoesNotContain<T>(T expected, System.Collections.Generic.IEnumerable<T> collection) { }

        public static void DoesNotContain<T>(T expected, System.Collections.Generic.ISet<T> set) { }

        public static void DoesNotContain<T>(System.Collections.Generic.IEnumerable<T> collection, System.Predicate<T> filter) { }

        public static void DoesNotContain<TKey, TValue>(TKey expected, System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue> collection) { }

        public static void DoesNotContain<TKey, TValue>(TKey expected, System.Collections.Generic.Dictionary<TKey, TValue> collection) { }

        public static void DoesNotContain<TKey, TValue>(TKey expected, System.Collections.Generic.IDictionary<TKey, TValue> collection) { }

        public static void DoesNotContain<TKey, TValue>(TKey expected, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> collection) { }

        public static void DoesNotContain<TKey, TValue>(TKey expected, System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue> collection) { }

        public static void DoesNotMatch(string expectedRegexPattern, string? actualString) { }

        public static void DoesNotMatch(System.Text.RegularExpressions.Regex expectedRegex, string? actualString) { }

        public static void Empty(System.Collections.IEnumerable collection) { }

        public static void Empty(string value) { }

        public static void EndsWith(string? expectedEndString, string? actualString, System.StringComparison comparisonType) { }

        public static void EndsWith(string? expectedEndString, string? actualString) { }

        public static void Equal(System.DateTime expected, System.DateTime actual, System.TimeSpan precision) { }

        public static void Equal(System.DateTime expected, System.DateTime actual) { }

        public static void Equal(System.DateTimeOffset expected, System.DateTimeOffset actual, System.TimeSpan precision) { }

        public static void Equal(System.DateTimeOffset expected, System.DateTimeOffset actual) { }

        public static void Equal(decimal expected, decimal actual, int precision) { }

        public static void Equal(double expected, double actual, double tolerance) { }

        public static void Equal(double expected, double actual, int precision, System.MidpointRounding rounding) { }

        public static void Equal(double expected, double actual, int precision) { }

        public static void Equal(float expected, float actual, int precision, System.MidpointRounding rounding) { }

        public static void Equal(float expected, float actual, int precision) { }

        public static void Equal(float expected, float actual, float tolerance) { }

        public static void Equal(string? expected, string? actual, bool ignoreCase = false, bool ignoreLineEndingDifferences = false, bool ignoreWhiteSpaceDifferences = false, bool ignoreAllWhiteSpace = false) { }

        public static void Equal(string? expected, string? actual) { }

        public static void Equal<T>(T expected, T actual, System.Collections.Generic.IEqualityComparer<T> comparer) { }

        public static void Equal<T>(T expected, T actual, System.Func<T, T, bool> comparer) { }

        public static void Equal<T>(T expected, T actual) { }

        public static void Equal<T>(System.Collections.Generic.IEnumerable<T>? expected, System.Collections.Generic.IEnumerable<T>? actual, System.Collections.Generic.IEqualityComparer<T> comparer) { }

        public static void Equal<T>(System.Collections.Generic.IEnumerable<T>? expected, System.Collections.Generic.IEnumerable<T>? actual, System.Func<T, T, bool> comparer) { }

        public static void Equal<T>(System.Collections.Generic.IEnumerable<T>? expected, System.Collections.Generic.IEnumerable<T>? actual) { }

        [System.Obsolete("This is an override of Object.Equals(). Call Assert.Equal() instead.", true)]
        public new static bool Equals(object a, object b) { throw null; }

        public static void Equivalent(object? expected, object? actual, bool strict = false) { }

        public static void Fail(string? message = null) { }

        public static void False(bool condition, string? userMessage) { }

        public static void False(bool condition) { }

        public static void False(bool? condition, string? userMessage) { }

        public static void False(bool? condition) { }

        public static void InRange<T>(T actual, T low, T high, System.Collections.Generic.IComparer<T> comparer) { }

        public static void InRange<T>(T actual, T low, T high)
            where T : System.IComparable { }

        public static void IsAssignableFrom(System.Type expectedType, object? @object) { }

        public static T IsAssignableFrom<T>(object? @object) { throw null; }

        public static void IsNotAssignableFrom(System.Type expectedType, object? @object) { }

        public static void IsNotAssignableFrom<T>(object? @object) { }

        public static void IsNotType(System.Type expectedType, object? @object) { }

        public static void IsNotType<T>(object? @object) { }

        public static void IsType(System.Type expectedType, object? @object) { }

        public static T IsType<T>(object? @object) { throw null; }

        public static void Matches(string expectedRegexPattern, string? actualString) { }

        public static void Matches(System.Text.RegularExpressions.Regex expectedRegex, string? actualString) { }

        public static void Multiple(params System.Action[] checks) { }

        public static void NotEmpty(System.Collections.IEnumerable collection) { }

        public static void NotEqual(decimal expected, decimal actual, int precision) { }

        public static void NotEqual(double expected, double actual, double tolerance) { }

        public static void NotEqual(double expected, double actual, int precision, System.MidpointRounding rounding) { }

        public static void NotEqual(double expected, double actual, int precision) { }

        public static void NotEqual(float expected, float actual, int precision, System.MidpointRounding rounding) { }

        public static void NotEqual(float expected, float actual, int precision) { }

        public static void NotEqual(float expected, float actual, float tolerance) { }

        public static void NotEqual<T>(T expected, T actual, System.Collections.Generic.IEqualityComparer<T> comparer) { }

        public static void NotEqual<T>(T expected, T actual, System.Func<T, T, bool> comparer) { }

        public static void NotEqual<T>(T expected, T actual) { }

        public static void NotEqual<T>(System.Collections.Generic.IEnumerable<T>? expected, System.Collections.Generic.IEnumerable<T>? actual, System.Collections.Generic.IEqualityComparer<T> comparer) { }

        public static void NotEqual<T>(System.Collections.Generic.IEnumerable<T>? expected, System.Collections.Generic.IEnumerable<T>? actual, System.Func<T, T, bool> comparer) { }

        public static void NotEqual<T>(System.Collections.Generic.IEnumerable<T>? expected, System.Collections.Generic.IEnumerable<T>? actual) { }

        public static void NotInRange<T>(T actual, T low, T high, System.Collections.Generic.IComparer<T> comparer) { }

        public static void NotInRange<T>(T actual, T low, T high)
            where T : System.IComparable { }

        public static void NotNull(object? @object) { }

        public static T NotNull<T>(T? value)
            where T : struct { throw null; }

        public static void NotSame(object? expected, object? actual) { }

        public static void NotStrictEqual<T>(T expected, T actual) { }

        public static void Null(object? @object) { }

        public static void Null<T>(T? value)
            where T : struct { }

        public static void ProperSubset<T>(System.Collections.Generic.ISet<T> expectedSubset, System.Collections.Generic.ISet<T>? actual) { }

        public static void ProperSuperset<T>(System.Collections.Generic.ISet<T> expectedSuperset, System.Collections.Generic.ISet<T>? actual) { }

        public static void PropertyChanged(System.ComponentModel.INotifyPropertyChanged @object, string propertyName, System.Action testCode) { }

        [System.Obsolete("You must call Assert.PropertyChangedAsync (and await the result) when testing async code.", true)]
        public static void PropertyChanged(System.ComponentModel.INotifyPropertyChanged @object, string propertyName, System.Func<System.Threading.Tasks.Task> testCode) { }

        public static System.Threading.Tasks.Task PropertyChangedAsync(System.ComponentModel.INotifyPropertyChanged @object, string propertyName, System.Func<System.Threading.Tasks.Task> testCode) { throw null; }

        public static RaisedEvent<T> Raises<T>(System.Action<System.EventHandler<T>> attach, System.Action<System.EventHandler<T>> detach, System.Action testCode) { throw null; }

        public static RaisedEvent<System.EventArgs> RaisesAny(System.Action<System.EventHandler> attach, System.Action<System.EventHandler> detach, System.Action testCode) { throw null; }

        public static RaisedEvent<T> RaisesAny<T>(System.Action<System.EventHandler<T>> attach, System.Action<System.EventHandler<T>> detach, System.Action testCode) { throw null; }

        public static System.Threading.Tasks.Task<RaisedEvent<System.EventArgs>> RaisesAnyAsync(System.Action<System.EventHandler> attach, System.Action<System.EventHandler> detach, System.Func<System.Threading.Tasks.Task> testCode) { throw null; }

        public static System.Threading.Tasks.Task<RaisedEvent<T>> RaisesAnyAsync<T>(System.Action<System.EventHandler<T>> attach, System.Action<System.EventHandler<T>> detach, System.Func<System.Threading.Tasks.Task> testCode) { throw null; }

        public static System.Threading.Tasks.Task<RaisedEvent<T>> RaisesAsync<T>(System.Action<System.EventHandler<T>> attach, System.Action<System.EventHandler<T>> detach, System.Func<System.Threading.Tasks.Task> testCode) { throw null; }

        protected static System.Exception? RecordException(System.Action testCode) { throw null; }

        protected static System.Exception? RecordException(System.Func<object?> testCode, string asyncMethodName) { throw null; }

        [System.Obsolete("You must call Assert.RecordExceptionAsync (and await the result) when testing async code.", true)]
        protected static System.Exception RecordException(System.Func<System.Threading.Tasks.Task> testCode) { throw null; }

        protected static System.Threading.Tasks.Task<System.Exception?> RecordExceptionAsync(System.Func<System.Threading.Tasks.Task> testCode) { throw null; }

        [System.Obsolete("This is an override of Object.ReferenceEquals(). Call Assert.Same() instead.", true)]
        public new static bool ReferenceEquals(object a, object b) { throw null; }

        public static void Same(object? expected, object? actual) { }

        public static void Single(System.Collections.IEnumerable collection, object? expected) { }

        public static object? Single(System.Collections.IEnumerable collection) { throw null; }

        public static T Single<T>(System.Collections.Generic.IEnumerable<T> collection, System.Predicate<T> predicate) { throw null; }

        public static T Single<T>(System.Collections.Generic.IEnumerable<T> collection) { throw null; }

        public static void StartsWith(string? expectedStartString, string? actualString, System.StringComparison comparisonType) { }

        public static void StartsWith(string? expectedStartString, string? actualString) { }

        public static void StrictEqual<T>(T expected, T actual) { }

        public static void Subset<T>(System.Collections.Generic.ISet<T> expectedSubset, System.Collections.Generic.ISet<T>? actual) { }

        public static void Superset<T>(System.Collections.Generic.ISet<T> expectedSuperset, System.Collections.Generic.ISet<T>? actual) { }

        public static System.Exception Throws(System.Type exceptionType, System.Action testCode) { throw null; }

        public static System.Exception Throws(System.Type exceptionType, System.Func<object?> testCode) { throw null; }

        [System.Obsolete("You must call Assert.ThrowsAsync (and await the result) when testing async code.", true)]
        public static System.Exception Throws(System.Type exceptionType, System.Func<System.Threading.Tasks.Task> testCode) { throw null; }

        public static T Throws<T>(System.Action testCode)
            where T : System.Exception { throw null; }

        public static T Throws<T>(System.Func<object?> testCode)
            where T : System.Exception { throw null; }

        [System.Obsolete("You must call Assert.ThrowsAsync<T> (and await the result) when testing async code.", true)]
        public static T Throws<T>(System.Func<System.Threading.Tasks.Task> testCode)
            where T : System.Exception { throw null; }

        public static T Throws<T>(string? paramName, System.Action testCode)
            where T : System.ArgumentException { throw null; }

        public static T Throws<T>(string? paramName, System.Func<object?> testCode)
            where T : System.ArgumentException { throw null; }

        [System.Obsolete("You must call Assert.ThrowsAsync<T> (and await the result) when testing async code.", true)]
        public static T Throws<T>(string? paramName, System.Func<System.Threading.Tasks.Task> testCode)
            where T : System.ArgumentException { throw null; }

        public static T ThrowsAny<T>(System.Action testCode)
            where T : System.Exception { throw null; }

        public static T ThrowsAny<T>(System.Func<object?> testCode)
            where T : System.Exception { throw null; }

        [System.Obsolete("You must call Assert.ThrowsAnyAsync<T> (and await the result) when testing async code.", true)]
        public static T ThrowsAny<T>(System.Func<System.Threading.Tasks.Task> testCode)
            where T : System.Exception { throw null; }

        public static System.Threading.Tasks.Task<T> ThrowsAnyAsync<T>(System.Func<System.Threading.Tasks.Task> testCode)
            where T : System.Exception { throw null; }

        public static System.Threading.Tasks.Task<System.Exception> ThrowsAsync(System.Type exceptionType, System.Func<System.Threading.Tasks.Task> testCode) { throw null; }

        public static System.Threading.Tasks.Task<T> ThrowsAsync<T>(System.Func<System.Threading.Tasks.Task> testCode)
            where T : System.Exception { throw null; }

        public static System.Threading.Tasks.Task<T> ThrowsAsync<T>(string? paramName, System.Func<System.Threading.Tasks.Task> testCode)
            where T : System.ArgumentException { throw null; }

        public static void True(bool condition, string? userMessage) { }

        public static void True(bool condition) { }

        public static void True(bool? condition, string? userMessage) { }

        public static void True(bool? condition) { }

        public partial class RaisedEvent<T>
        {
            public RaisedEvent(object? sender, T args) { }

            public T Arguments { get { throw null; } }

            public object? Sender { get { throw null; } }
        }
    }
}

namespace Xunit.Sdk
{
    public partial class AllException : XunitException
    {
        internal AllException() : base(default) { }

        public static AllException ForFailures(int totalItems, System.Collections.Generic.IReadOnlyList<System.Tuple<int, string, System.Exception>> errors) { throw null; }
    }

    public static partial class ArgumentFormatter
    {
        public const int MAX_DEPTH = 3;
        public const int MAX_ENUMERABLE_LENGTH = 5;
        public const int MAX_OBJECT_ITEM_COUNT = 5;
        public const int MAX_STRING_LENGTH = 50;
        public static string Ellipsis { get { throw null; } }

        public static string EscapeString(string s) { throw null; }

        public static string Format(object? value, int depth = 1) { throw null; }

        public static string FormatTypeName(System.Type type, bool fullTypeName = false) { throw null; }
    }

    public partial class CollectionException : XunitException
    {
        internal CollectionException() : base(default) { }

        public static CollectionException ForMismatchedItem(System.Exception exception, int indexFailurePoint, int? failurePointerIndent, string formattedCollection) { throw null; }

        public static CollectionException ForMismatchedItemCount(int expectedCount, int actualCount, string formattedCollection) { throw null; }
    }

    public abstract partial class CollectionTracker : System.IDisposable
    {
        protected CollectionTracker(System.Collections.IEnumerable innerEnumerable) { }

        protected internal System.Collections.IEnumerable InnerEnumerable { get { throw null; } protected set { } }

        public static bool AreCollectionsEqual(CollectionTracker? x, CollectionTracker? y, System.Collections.IEqualityComparer itemComparer, bool isDefaultItemComparer, out int? mismatchedIndex) { throw null; }

        public abstract void Dispose();
        public abstract string FormatIndexedMismatch(int startIndex, int endIndex, int? mismatchedIndex, out int? pointerIndent, int depth = 1);
        public abstract string FormatIndexedMismatch(int? mismatchedIndex, out int? pointerIndent, int depth = 1);
        public abstract string FormatStart(int depth = 1);
        public abstract void GetMismatchExtents(int? mismatchedIndex, out int startIndex, out int endIndex);
        protected internal abstract System.Collections.IEnumerator GetSafeEnumerator();
        public abstract string? TypeAt(int? index);
        public static CollectionTracker<object> Wrap(System.Collections.IEnumerable enumerable) { throw null; }
    }

    public static partial class CollectionTrackerExtensions
    {
        public static CollectionTracker? AsTracker(this System.Collections.IEnumerable? enumerable) { throw null; }

        public static CollectionTracker<T>? AsTracker<T>(this System.Collections.Generic.IEnumerable<T>? enumerable) { throw null; }

        public static System.Collections.IEnumerator GetEnumerator(this CollectionTracker tracker) { throw null; }
    }

    public sealed partial class CollectionTracker<T> : CollectionTracker, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        internal CollectionTracker() : base(default!) { }

        public int IterationCount { get { throw null; } }

        public override void Dispose() { }

        public override string FormatIndexedMismatch(int startIndex, int endIndex, int? mismatchedIndex, out int? pointerIndent, int depth = 1) { throw null; }

        public override string FormatIndexedMismatch(int? mismatchedIndex, out int? pointerIndent, int depth = 1) { throw null; }

        public static string FormatStart(System.Collections.Generic.IEnumerable<T> collection, int depth = 1) { throw null; }

        public override string FormatStart(int depth = 1) { throw null; }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }

        public override void GetMismatchExtents(int? mismatchedIndex, out int startIndex, out int endIndex) { throw null; }

        protected internal override System.Collections.IEnumerator GetSafeEnumerator() { throw null; }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }

        public override string? TypeAt(int? index) { throw null; }

        public static CollectionTracker<T> Wrap(System.Collections.Generic.IEnumerable<T> collection) { throw null; }
    }

    public partial class ContainsException : XunitException
    {
        internal ContainsException() : base(default) { }

        public static ContainsException ForCollectionFilterNotMatched(string collection) { throw null; }

        public static ContainsException ForCollectionItemNotFound(string item, string collection) { throw null; }

        public static ContainsException ForKeyNotFound(string expectedKey, string keys) { throw null; }

        public static ContainsException ForSetItemNotFound(string item, string set) { throw null; }

        public static ContainsException ForSubMemoryNotFound(string expectedSubMemory, string memory) { throw null; }

        public static ContainsException ForSubSpanNotFound(string expectedSubSpan, string span) { throw null; }

        public static ContainsException ForSubStringNotFound(string expectedSubString, string? @string) { throw null; }
    }

    public partial class DistinctException : XunitException
    {
        internal DistinctException() : base(default) { }

        public static DistinctException ForDuplicateItem(string item, string collection) { throw null; }
    }

    public partial class DoesNotContainException : XunitException
    {
        internal DoesNotContainException() : base(default) { }

        public static DoesNotContainException ForCollectionFilterMatched(int indexFailurePoint, int? failurePointerIndent, string collection) { throw null; }

        public static DoesNotContainException ForCollectionItemFound(string item, int indexFailurePoint, int? failurePointerIndent, string collection) { throw null; }

        public static DoesNotContainException ForKeyFound(string expectedKey, string keys) { throw null; }

        public static DoesNotContainException ForSetItemFound(string item, string set) { throw null; }

        public static DoesNotContainException ForSubMemoryFound(string expectedSubMemory, int indexFailurePoint, int? failurePointerIndent, string memory) { throw null; }

        public static DoesNotContainException ForSubSpanFound(string expectedSubSpan, int indexFailurePoint, int? failurePointerIndent, string span) { throw null; }

        public static DoesNotContainException ForSubStringFound(string expectedSubString, int indexFailurePoint, string @string) { throw null; }
    }

    public partial class DoesNotMatchException : XunitException
    {
        internal DoesNotMatchException() : base(default) { }

        public static DoesNotMatchException ForMatch(string expectedRegexPattern, int indexFailurePoint, int failurePointerIndent, string @string) { throw null; }
    }

    public partial class EmptyException : XunitException
    {
        internal EmptyException() : base(default) { }

        public static EmptyException ForNonEmptyCollection(string collection) { throw null; }

        public static EmptyException ForNonEmptyString(string value) { throw null; }
    }

    public partial class EndsWithException : XunitException
    {
        internal EndsWithException() : base(default) { }

        public static EndsWithException ForStringNotFound(string? expected, string? actual) { throw null; }
    }

    public partial class EqualException : XunitException
    {
        internal EqualException() : base(default) { }

        public static EqualException ForMismatchedCollections(int? mismatchedIndex, string expected, int? expectedPointer, string? expectedType, string actual, int? actualPointer, string? actualType, string? collectionDisplay = null) { throw null; }

        public static EqualException ForMismatchedCollectionsWithError(int? mismatchedIndex, string expected, int? expectedPointer, string? expectedType, string actual, int? actualPointer, string? actualType, System.Exception? error, string? collectionDisplay = null) { throw null; }

        public static EqualException ForMismatchedStrings(string? expected, string? actual, int expectedIndex, int actualIndex) { throw null; }

        public static EqualException ForMismatchedValues(object? expected, object? actual, string? banner = null) { throw null; }

        public static EqualException ForMismatchedValuesWithError(object? expected, object? actual, System.Exception? error = null, string? banner = null) { throw null; }
    }

    public partial class EquivalentException : XunitException
    {
        internal EquivalentException() : base(default) { }

        public static EquivalentException ForCircularReference(string memberName) { throw null; }

        public static EquivalentException ForExceededDepth(int depth, string memberName) { throw null; }

        public static EquivalentException ForExtraCollectionValue(System.Collections.Generic.IEnumerable<object?> expected, System.Collections.Generic.IEnumerable<object?> actual, System.Collections.Generic.IEnumerable<object?> actualLeftovers, string memberName) { throw null; }

        public static EquivalentException ForMemberListMismatch(System.Collections.Generic.IEnumerable<string> expectedMemberNames, System.Collections.Generic.IEnumerable<string> actualMemberNames, string prefix) { throw null; }

        public static EquivalentException ForMemberValueMismatch(object? expected, object? actual, string memberName, System.Exception? innerException = null) { throw null; }

        public static EquivalentException ForMismatchedTypes(System.Type expectedType, System.Type actualType, string memberName) { throw null; }

        public static EquivalentException ForMissingCollectionValue(object? expected, System.Collections.Generic.IEnumerable<object?> actual, string memberName) { throw null; }
    }

    public partial class FailException : XunitException
    {
        internal FailException() : base(default) { }

        public static FailException ForFailure(string? message) { throw null; }
    }

    public partial class FalseException : XunitException
    {
        internal FalseException() : base(default) { }

        public static FalseException ForNonFalseValue(string? message, bool? value) { throw null; }
    }

    public partial interface IAssertionException
    {
    }

    public partial class InRangeException : XunitException
    {
        internal InRangeException() : base(default) { }

        public static InRangeException ForValueNotInRange(object actual, object low, object high) { throw null; }
    }

    public partial class IsAssignableFromException : XunitException
    {
        internal IsAssignableFromException() : base(default) { }

        public static IsAssignableFromException ForIncompatibleType(System.Type expected, object? actual) { throw null; }
    }

    public partial class IsNotAssignableFromException : XunitException
    {
        internal IsNotAssignableFromException() : base(default) { }

        public static IsNotAssignableFromException ForCompatibleType(System.Type expected, object actual) { throw null; }
    }

    public partial class IsNotTypeException : XunitException
    {
        internal IsNotTypeException() : base(default) { }

        public static IsNotTypeException ForExactType(System.Type type) { throw null; }
    }

    public partial class IsTypeException : XunitException
    {
        internal IsTypeException() : base(default) { }

        public static IsTypeException ForMismatchedType(string expectedTypeName, string? actualTypeName) { throw null; }
    }

    public partial class MatchesException : XunitException
    {
        internal MatchesException() : base(default) { }

        public static MatchesException ForMatchNotFound(string expectedRegexPattern, string? actual) { throw null; }
    }

    public partial class MultipleException : XunitException
    {
        internal MultipleException() : base(default) { }

        public System.Collections.Generic.IReadOnlyCollection<System.Exception> InnerExceptions { get { throw null; } }

        public override string? StackTrace { get { throw null; } }

        public static MultipleException ForFailures(System.Collections.Generic.IReadOnlyCollection<System.Exception> innerExceptions) { throw null; }
    }

    public partial class NotEmptyException : XunitException
    {
        internal NotEmptyException() : base(default) { }

        public static NotEmptyException ForNonEmptyCollection() { throw null; }
    }

    public partial class NotEqualException : XunitException
    {
        internal NotEqualException() : base(default) { }

        public static NotEqualException ForEqualCollections(string expected, string actual, string? collectionDisplay = null) { throw null; }

        public static NotEqualException ForEqualCollectionsWithError(int? mismatchedIndex, string expected, int? expectedPointer, string actual, int? actualPointer, System.Exception? error = null, string? collectionDisplay = null) { throw null; }

        public static NotEqualException ForEqualValues(string expected, string actual, string? banner = null) { throw null; }

        public static NotEqualException ForEqualValuesWithError(string expected, string actual, System.Exception? error = null, string? banner = null) { throw null; }
    }

    public partial class NotInRangeException : XunitException
    {
        internal NotInRangeException() : base(default) { }

        public static NotInRangeException ForValueInRange(object actual, object low, object high) { throw null; }
    }

    public partial class NotNullException : XunitException
    {
        internal NotNullException() : base(default) { }

        public static System.Exception ForNullStruct(System.Type type) { throw null; }

        public static NotNullException ForNullValue() { throw null; }
    }

    public partial class NotSameException : XunitException
    {
        internal NotSameException() : base(default) { }

        public static NotSameException ForSameValues() { throw null; }
    }

    public partial class NotStrictEqualException : XunitException
    {
        internal NotStrictEqualException() : base(default) { }

        public static NotStrictEqualException ForEqualValues(string expected, string actual) { throw null; }
    }

    public partial class NullException : XunitException
    {
        internal NullException() : base(default) { }

        public static System.Exception ForNonNullStruct<T>(System.Type type, T? actual)
            where T : struct { throw null; }

        public static NullException ForNonNullValue(object actual) { throw null; }
    }

    public partial class ProperSubsetException : XunitException
    {
        internal ProperSubsetException() : base(default) { }

        public static ProperSubsetException ForFailure(string expected, string actual) { throw null; }
    }

    public partial class ProperSupersetException : XunitException
    {
        internal ProperSupersetException() : base(default) { }

        public static ProperSupersetException ForFailure(string expected, string actual) { throw null; }
    }

    public partial class PropertyChangedException : XunitException
    {
        internal PropertyChangedException() : base(default) { }

        public static PropertyChangedException ForUnsetProperty(string propertyName) { throw null; }
    }

    public partial class RaisesAnyException : XunitException
    {
        internal RaisesAnyException() : base(default) { }

        public static RaisesAnyException ForNoEvent(System.Type expected) { throw null; }
    }

    public partial class RaisesException : XunitException
    {
        internal RaisesException() : base(default) { }

        public static RaisesException ForIncorrectType(System.Type expected, System.Type actual) { throw null; }

        public static RaisesException ForNoEvent(System.Type expected) { throw null; }
    }

    public partial class SameException : XunitException
    {
        internal SameException() : base(default) { }

        public static SameException ForFailure(string expected, string actual) { throw null; }
    }

    public partial class SingleException : XunitException
    {
        internal SingleException() : base(default) { }

        public static SingleException Empty(string? expected, string collection) { throw null; }

        public static SingleException MoreThanOne(int count, string? expected, string collection, System.Collections.Generic.ICollection<int> matchIndices) { throw null; }
    }

    public partial class SkipException : XunitException
    {
        internal SkipException() : base(default) { }

        public static SkipException ForSkip(string message) { throw null; }
    }

    public partial class StartsWithException : XunitException
    {
        internal StartsWithException() : base(default) { }

        public static StartsWithException ForStringNotFound(string? expected, string? actual) { throw null; }
    }

    public partial class StrictEqualException : XunitException
    {
        internal StrictEqualException() : base(default) { }

        public static StrictEqualException ForEqualValues(string expected, string actual) { throw null; }
    }

    public partial class SubsetException : XunitException
    {
        internal SubsetException() : base(default) { }

        public static SubsetException ForFailure(string expected, string actual) { throw null; }
    }

    public partial class SupersetException : XunitException
    {
        internal SupersetException() : base(default) { }

        public static SupersetException ForFailure(string expected, string actual) { throw null; }
    }

    public partial class ThrowsAnyException : XunitException
    {
        internal ThrowsAnyException() : base(default) { }

        public static ThrowsAnyException ForIncorrectExceptionType(System.Type expected, System.Exception actual) { throw null; }

        public static ThrowsAnyException ForNoException(System.Type expected) { throw null; }
    }

    public partial class ThrowsException : XunitException
    {
        internal ThrowsException() : base(default) { }

        public static ThrowsException ForIncorrectExceptionType(System.Type expected, System.Exception actual) { throw null; }

        public static ThrowsException ForIncorrectParameterName(System.Type expected, string? expectedParamName, string? actualParamName) { throw null; }

        public static ThrowsException ForNoException(System.Type expected) { throw null; }
    }

    public partial class TrueException : XunitException
    {
        internal TrueException() : base(default) { }

        public static TrueException ForNonTrueValue(string? message, bool? value) { throw null; }
    }

    public partial class XunitException : System.Exception, IAssertionException
    {
        public XunitException(string? userMessage, System.Exception? innerException) { }

        public XunitException(string? userMessage) { }

        public override string ToString() { throw null; }
    }
}