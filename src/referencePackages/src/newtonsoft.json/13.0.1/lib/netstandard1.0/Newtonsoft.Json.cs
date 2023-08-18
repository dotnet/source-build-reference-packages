// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Security.AllowPartiallyTrustedCallers]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Newtonsoft.Json.Schema, PublicKey=0024000004800000940000000602000000240000525341310004000001000100f561df277c6c0b497d629032b410cdcf286e537c054724f7ffa0164345f62b3e642029d7a80cc351918955328c4adc8a048823ef90b0cf38ea7db0d729caf2b633c3babe08b0310198c1081995c19029bc675193744eab9d7345b8a67258ec17d112cebdbbb2a281487dceeafb9d83aa930f32103fbe1d2911425bc5744002c7")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Newtonsoft.Json.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100f561df277c6c0b497d629032b410cdcf286e537c054724f7ffa0164345f62b3e642029d7a80cc351918955328c4adc8a048823ef90b0cf38ea7db0d729caf2b633c3babe08b0310198c1081995c19029bc675193744eab9d7345b8a67258ec17d112cebdbbb2a281487dceeafb9d83aa930f32103fbe1d2911425bc5744002c7")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Newtonsoft.Json.Dynamic, PublicKey=0024000004800000940000000602000000240000525341310004000001000100cbd8d53b9d7de30f1f1278f636ec462cf9c254991291e66ebb157a885638a517887633b898ccbcf0d5c5ff7be85a6abe9e765d0ac7cd33c68dac67e7e64530e8222101109f154ab14a941c490ac155cd1d4fcba0fabb49016b4ef28593b015cab5937da31172f03f67d09edda404b88a60023f062ae71d0b2e4438b74cc11dc9")]
[assembly: System.Reflection.AssemblyTrademark("")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Runtime.Versioning.TargetFramework(".NETStandard,Version=v1.0", FrameworkDisplayName = "")]
[assembly: System.Reflection.AssemblyCompany("Newtonsoft")]
[assembly: System.Reflection.AssemblyConfiguration("Release")]
[assembly: System.Reflection.AssemblyCopyright("Copyright © James Newton-King 2008")]
[assembly: System.Reflection.AssemblyDescription("Json.NET is a popular high-performance JSON framework for .NET")]
[assembly: System.Reflection.AssemblyFileVersion("13.0.1.25517")]
[assembly: System.Reflection.AssemblyInformationalVersion("13.0.1+ae9fe44e1323e91bcbd185ca1a14099fba7c021f")]
[assembly: System.Reflection.AssemblyProduct("Json.NET")]
[assembly: System.Reflection.AssemblyTitle("Json.NET .NET Standard 1.0")]
[assembly: System.Reflection.AssemblyMetadata("RepositoryUrl", "https://github.com/JamesNK/Newtonsoft.Json")]
[assembly: System.Resources.NeutralResourcesLanguage("en-US")]
[assembly: System.Reflection.AssemblyVersionAttribute("13.0.0.0")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace Newtonsoft.Json
{
    public enum ConstructorHandling
    {
        Default = 0,
        AllowNonPublicDefaultConstructor = 1
    }

    public enum DateFormatHandling
    {
        IsoDateFormat = 0,
        MicrosoftDateFormat = 1
    }

    public enum DateParseHandling
    {
        None = 0,
        DateTime = 1,
        DateTimeOffset = 2
    }

    public enum DateTimeZoneHandling
    {
        Local = 0,
        Utc = 1,
        Unspecified = 2,
        RoundtripKind = 3
    }

    public partial class DefaultJsonNameTable : JsonNameTable
    {
        public string Add(string key) { throw null; }

        public override string? Get(char[] key, int start, int length) { throw null; }
    }

    [System.Flags]
    public enum DefaultValueHandling
    {
        Include = 0,
        Ignore = 1,
        Populate = 2,
        IgnoreAndPopulate = 3
    }

    public enum FloatFormatHandling
    {
        String = 0,
        Symbol = 1,
        DefaultValue = 2
    }

    public enum FloatParseHandling
    {
        Double = 0,
        Decimal = 1
    }

    public enum Formatting
    {
        None = 0,
        Indented = 1
    }

    public partial interface IArrayPool<T>
    {
        T[] Rent(int minimumLength);
        void Return(T[]? array);
    }

    public partial interface IJsonLineInfo
    {
        int LineNumber { get; }

        int LinePosition { get; }

        bool HasLineInfo();
    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Interface, AllowMultiple = false)]
    public sealed partial class JsonArrayAttribute : JsonContainerAttribute
    {
        public JsonArrayAttribute() { }

        public JsonArrayAttribute(bool allowNullItems) { }

        public JsonArrayAttribute(string id) { }

        public bool AllowNullItems { get { throw null; } set { } }
    }

    [System.AttributeUsage(System.AttributeTargets.Constructor, AllowMultiple = false)]
    public sealed partial class JsonConstructorAttribute : System.Attribute
    {
    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Interface, AllowMultiple = false)]
    public abstract partial class JsonContainerAttribute : System.Attribute
    {
        protected JsonContainerAttribute() { }

        protected JsonContainerAttribute(string id) { }

        public string? Description { get { throw null; } set { } }

        public string? Id { get { throw null; } set { } }

        public bool IsReference { get { throw null; } set { } }

        public object[]? ItemConverterParameters { get { throw null; } set { } }

        public System.Type? ItemConverterType { get { throw null; } set { } }

        public bool ItemIsReference { get { throw null; } set { } }

        public ReferenceLoopHandling ItemReferenceLoopHandling { get { throw null; } set { } }

        public TypeNameHandling ItemTypeNameHandling { get { throw null; } set { } }

        public object[]? NamingStrategyParameters { get { throw null; } set { } }

        public System.Type? NamingStrategyType { get { throw null; } set { } }

        public string? Title { get { throw null; } set { } }
    }

    public static partial class JsonConvert
    {
        public static readonly string False;
        public static readonly string NaN;
        public static readonly string NegativeInfinity;
        public static readonly string Null;
        public static readonly string PositiveInfinity;
        public static readonly string True;
        public static readonly string Undefined;
        public static System.Func<JsonSerializerSettings>? DefaultSettings { get { throw null; } set { } }

        public static T? DeserializeAnonymousType<T>(string value, T anonymousTypeObject, JsonSerializerSettings settings) { throw null; }

        public static T? DeserializeAnonymousType<T>(string value, T anonymousTypeObject) { throw null; }

        public static object? DeserializeObject(string value, JsonSerializerSettings settings) { throw null; }

        public static object? DeserializeObject(string value, System.Type type, params JsonConverter[] converters) { throw null; }

        public static object? DeserializeObject(string value, System.Type? type, JsonSerializerSettings? settings) { throw null; }

        public static object? DeserializeObject(string value, System.Type type) { throw null; }

        public static object? DeserializeObject(string value) { throw null; }

        public static T? DeserializeObject<T>(string value, params JsonConverter[] converters) { throw null; }

        public static T? DeserializeObject<T>(string value, JsonSerializerSettings? settings) { throw null; }

        public static T? DeserializeObject<T>(string value) { throw null; }

        public static System.Xml.Linq.XDocument? DeserializeXNode(string value, string? deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters) { throw null; }

        public static System.Xml.Linq.XDocument? DeserializeXNode(string value, string? deserializeRootElementName, bool writeArrayAttribute) { throw null; }

        public static System.Xml.Linq.XDocument? DeserializeXNode(string value, string? deserializeRootElementName) { throw null; }

        public static System.Xml.Linq.XDocument? DeserializeXNode(string value) { throw null; }

        public static void PopulateObject(string value, object target, JsonSerializerSettings? settings) { }

        public static void PopulateObject(string value, object target) { }

        public static string SerializeObject(object? value, Formatting formatting, params JsonConverter[] converters) { throw null; }

        public static string SerializeObject(object? value, Formatting formatting, JsonSerializerSettings? settings) { throw null; }

        public static string SerializeObject(object? value, Formatting formatting) { throw null; }

        public static string SerializeObject(object? value, params JsonConverter[] converters) { throw null; }

        public static string SerializeObject(object? value, JsonSerializerSettings? settings) { throw null; }

        public static string SerializeObject(object? value, System.Type? type, Formatting formatting, JsonSerializerSettings? settings) { throw null; }

        public static string SerializeObject(object? value, System.Type? type, JsonSerializerSettings? settings) { throw null; }

        public static string SerializeObject(object? value) { throw null; }

        public static string SerializeXNode(System.Xml.Linq.XObject? node, Formatting formatting, bool omitRootObject) { throw null; }

        public static string SerializeXNode(System.Xml.Linq.XObject? node, Formatting formatting) { throw null; }

        public static string SerializeXNode(System.Xml.Linq.XObject? node) { throw null; }

        public static string ToString(bool value) { throw null; }

        public static string ToString(byte value) { throw null; }

        public static string ToString(char value) { throw null; }

        public static string ToString(System.DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling) { throw null; }

        public static string ToString(System.DateTime value) { throw null; }

        public static string ToString(System.DateTimeOffset value, DateFormatHandling format) { throw null; }

        public static string ToString(System.DateTimeOffset value) { throw null; }

        public static string ToString(decimal value) { throw null; }

        public static string ToString(double value) { throw null; }

        public static string ToString(System.Enum value) { throw null; }

        public static string ToString(System.Guid value) { throw null; }

        public static string ToString(short value) { throw null; }

        public static string ToString(int value) { throw null; }

        public static string ToString(long value) { throw null; }

        public static string ToString(object? value) { throw null; }

        [System.CLSCompliant(false)]
        public static string ToString(sbyte value) { throw null; }

        public static string ToString(float value) { throw null; }

        public static string ToString(string? value, char delimiter, StringEscapeHandling stringEscapeHandling) { throw null; }

        public static string ToString(string? value, char delimiter) { throw null; }

        public static string ToString(string? value) { throw null; }

        public static string ToString(System.TimeSpan value) { throw null; }

        [System.CLSCompliant(false)]
        public static string ToString(ushort value) { throw null; }

        [System.CLSCompliant(false)]
        public static string ToString(uint value) { throw null; }

        [System.CLSCompliant(false)]
        public static string ToString(ulong value) { throw null; }

        public static string ToString(System.Uri? value) { throw null; }
    }

    public abstract partial class JsonConverter
    {
        public virtual bool CanRead { get { throw null; } }

        public virtual bool CanWrite { get { throw null; } }

        public abstract bool CanConvert(System.Type objectType);
        public abstract object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer);
        public abstract void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer);
    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Enum | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Interface | System.AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed partial class JsonConverterAttribute : System.Attribute
    {
        public JsonConverterAttribute(System.Type converterType, params object[] converterParameters) { }

        public JsonConverterAttribute(System.Type converterType) { }

        public object[]? ConverterParameters { get { throw null; } }

        public System.Type ConverterType { get { throw null; } }
    }

    public partial class JsonConverterCollection : System.Collections.ObjectModel.Collection<JsonConverter>
    {
    }

    public abstract partial class JsonConverter<T> : JsonConverter
    {
        public sealed override bool CanConvert(System.Type objectType) { throw null; }

        public abstract T? ReadJson(JsonReader reader, System.Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer);
        public sealed override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer) { throw null; }

        public abstract void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer);
        public sealed override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Interface, AllowMultiple = false)]
    public sealed partial class JsonDictionaryAttribute : JsonContainerAttribute
    {
        public JsonDictionaryAttribute() { }

        public JsonDictionaryAttribute(string id) { }
    }

    public partial class JsonException : System.Exception
    {
        public JsonException() { }

        public JsonException(string message, System.Exception? innerException) { }

        public JsonException(string message) { }
    }

    [System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field, AllowMultiple = false)]
    public partial class JsonExtensionDataAttribute : System.Attribute
    {
        public bool ReadData { get { throw null; } set { } }

        public bool WriteData { get { throw null; } set { } }
    }

    [System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field, AllowMultiple = false)]
    public sealed partial class JsonIgnoreAttribute : System.Attribute
    {
    }

    public abstract partial class JsonNameTable
    {
        public abstract string? Get(char[] key, int start, int length);
    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Interface, AllowMultiple = false)]
    public sealed partial class JsonObjectAttribute : JsonContainerAttribute
    {
        public JsonObjectAttribute() { }

        public JsonObjectAttribute(MemberSerialization memberSerialization) { }

        public JsonObjectAttribute(string id) { }

        public NullValueHandling ItemNullValueHandling { get { throw null; } set { } }

        public Required ItemRequired { get { throw null; } set { } }

        public MemberSerialization MemberSerialization { get { throw null; } set { } }

        public MissingMemberHandling MissingMemberHandling { get { throw null; } set { } }
    }

    [System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed partial class JsonPropertyAttribute : System.Attribute
    {
        public JsonPropertyAttribute() { }

        public JsonPropertyAttribute(string propertyName) { }

        public DefaultValueHandling DefaultValueHandling { get { throw null; } set { } }

        public bool IsReference { get { throw null; } set { } }

        public object[]? ItemConverterParameters { get { throw null; } set { } }

        public System.Type? ItemConverterType { get { throw null; } set { } }

        public bool ItemIsReference { get { throw null; } set { } }

        public ReferenceLoopHandling ItemReferenceLoopHandling { get { throw null; } set { } }

        public TypeNameHandling ItemTypeNameHandling { get { throw null; } set { } }

        public object[]? NamingStrategyParameters { get { throw null; } set { } }

        public System.Type? NamingStrategyType { get { throw null; } set { } }

        public NullValueHandling NullValueHandling { get { throw null; } set { } }

        public ObjectCreationHandling ObjectCreationHandling { get { throw null; } set { } }

        public int Order { get { throw null; } set { } }

        public string? PropertyName { get { throw null; } set { } }

        public ReferenceLoopHandling ReferenceLoopHandling { get { throw null; } set { } }

        public Required Required { get { throw null; } set { } }

        public TypeNameHandling TypeNameHandling { get { throw null; } set { } }
    }

    public abstract partial class JsonReader : System.IDisposable
    {
        public bool CloseInput { get { throw null; } set { } }

        public System.Globalization.CultureInfo Culture { get { throw null; } set { } }

        protected State CurrentState { get { throw null; } }

        public string? DateFormatString { get { throw null; } set { } }

        public DateParseHandling DateParseHandling { get { throw null; } set { } }

        public DateTimeZoneHandling DateTimeZoneHandling { get { throw null; } set { } }

        public virtual int Depth { get { throw null; } }

        public FloatParseHandling FloatParseHandling { get { throw null; } set { } }

        public int? MaxDepth { get { throw null; } set { } }

        public virtual string Path { get { throw null; } }

        public virtual char QuoteChar { get { throw null; } protected internal set { } }

        public bool SupportMultipleContent { get { throw null; } set { } }

        public virtual JsonToken TokenType { get { throw null; } }

        public virtual object? Value { get { throw null; } }

        public virtual System.Type? ValueType { get { throw null; } }

        public virtual void Close() { }

        protected virtual void Dispose(bool disposing) { }

        public abstract bool Read();
        public virtual bool? ReadAsBoolean() { throw null; }

        public virtual System.Threading.Tasks.Task<bool?> ReadAsBooleanAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual byte[]? ReadAsBytes() { throw null; }

        public virtual System.Threading.Tasks.Task<byte[]?> ReadAsBytesAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.DateTime? ReadAsDateTime() { throw null; }

        public virtual System.Threading.Tasks.Task<System.DateTime?> ReadAsDateTimeAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.DateTimeOffset? ReadAsDateTimeOffset() { throw null; }

        public virtual System.Threading.Tasks.Task<System.DateTimeOffset?> ReadAsDateTimeOffsetAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual decimal? ReadAsDecimal() { throw null; }

        public virtual System.Threading.Tasks.Task<decimal?> ReadAsDecimalAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual double? ReadAsDouble() { throw null; }

        public virtual System.Threading.Tasks.Task<double?> ReadAsDoubleAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual int? ReadAsInt32() { throw null; }

        public virtual System.Threading.Tasks.Task<int?> ReadAsInt32Async(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual string? ReadAsString() { throw null; }

        public virtual System.Threading.Tasks.Task<string?> ReadAsStringAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task<bool> ReadAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        protected void SetStateBasedOnCurrent() { }

        protected void SetToken(JsonToken newToken, object? value, bool updateIndex) { }

        protected void SetToken(JsonToken newToken, object? value) { }

        protected void SetToken(JsonToken newToken) { }

        public void Skip() { }

        public System.Threading.Tasks.Task SkipAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        void System.IDisposable.Dispose() { }

        protected internal enum State
        {
            Start = 0,
            Complete = 1,
            Property = 2,
            ObjectStart = 3,
            Object = 4,
            ArrayStart = 5,
            Array = 6,
            Closed = 7,
            PostValue = 8,
            ConstructorStart = 9,
            Constructor = 10,
            Error = 11,
            Finished = 12
        }
    }

    public partial class JsonReaderException : JsonException
    {
        public JsonReaderException() { }

        public JsonReaderException(string message, System.Exception innerException) { }

        public JsonReaderException(string message, string path, int lineNumber, int linePosition, System.Exception? innerException) { }

        public JsonReaderException(string message) { }

        public int LineNumber { get { throw null; } }

        public int LinePosition { get { throw null; } }

        public string? Path { get { throw null; } }
    }

    [System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field, AllowMultiple = false)]
    public sealed partial class JsonRequiredAttribute : System.Attribute
    {
    }

    public partial class JsonSerializationException : JsonException
    {
        public JsonSerializationException() { }

        public JsonSerializationException(string message, System.Exception innerException) { }

        public JsonSerializationException(string message, string path, int lineNumber, int linePosition, System.Exception? innerException) { }

        public JsonSerializationException(string message) { }

        public int LineNumber { get { throw null; } }

        public int LinePosition { get { throw null; } }

        public string? Path { get { throw null; } }
    }

    public partial class JsonSerializer
    {
        [System.Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
        public virtual SerializationBinder Binder { get { throw null; } set { } }

        public virtual bool CheckAdditionalContent { get { throw null; } set { } }

        public virtual ConstructorHandling ConstructorHandling { get { throw null; } set { } }

        public virtual System.Runtime.Serialization.StreamingContext Context { get { throw null; } set { } }

        public virtual Serialization.IContractResolver ContractResolver { get { throw null; } set { } }

        public virtual JsonConverterCollection Converters { get { throw null; } }

        public virtual System.Globalization.CultureInfo Culture { get { throw null; } set { } }

        public virtual DateFormatHandling DateFormatHandling { get { throw null; } set { } }

        public virtual string DateFormatString { get { throw null; } set { } }

        public virtual DateParseHandling DateParseHandling { get { throw null; } set { } }

        public virtual DateTimeZoneHandling DateTimeZoneHandling { get { throw null; } set { } }

        public virtual DefaultValueHandling DefaultValueHandling { get { throw null; } set { } }

        public virtual System.Collections.IEqualityComparer? EqualityComparer { get { throw null; } set { } }

        public virtual FloatFormatHandling FloatFormatHandling { get { throw null; } set { } }

        public virtual FloatParseHandling FloatParseHandling { get { throw null; } set { } }

        public virtual Formatting Formatting { get { throw null; } set { } }

        public virtual int? MaxDepth { get { throw null; } set { } }

        public virtual MetadataPropertyHandling MetadataPropertyHandling { get { throw null; } set { } }

        public virtual MissingMemberHandling MissingMemberHandling { get { throw null; } set { } }

        public virtual NullValueHandling NullValueHandling { get { throw null; } set { } }

        public virtual ObjectCreationHandling ObjectCreationHandling { get { throw null; } set { } }

        public virtual PreserveReferencesHandling PreserveReferencesHandling { get { throw null; } set { } }

        public virtual ReferenceLoopHandling ReferenceLoopHandling { get { throw null; } set { } }

        public virtual Serialization.IReferenceResolver? ReferenceResolver { get { throw null; } set { } }

        public virtual Serialization.ISerializationBinder SerializationBinder { get { throw null; } set { } }

        public virtual StringEscapeHandling StringEscapeHandling { get { throw null; } set { } }

        public virtual Serialization.ITraceWriter? TraceWriter { get { throw null; } set { } }

        [System.Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
        public virtual System.Runtime.Serialization.Formatters.FormatterAssemblyStyle TypeNameAssemblyFormat { get { throw null; } set { } }

        public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get { throw null; } set { } }

        public virtual TypeNameHandling TypeNameHandling { get { throw null; } set { } }

        public virtual event System.EventHandler<Serialization.ErrorEventArgs>? Error { add { } remove { } }

        public static JsonSerializer Create() { throw null; }

        public static JsonSerializer Create(JsonSerializerSettings? settings) { throw null; }

        public static JsonSerializer CreateDefault() { throw null; }

        public static JsonSerializer CreateDefault(JsonSerializerSettings? settings) { throw null; }

        public object? Deserialize(JsonReader reader, System.Type? objectType) { throw null; }

        public object? Deserialize(JsonReader reader) { throw null; }

        public object? Deserialize(System.IO.TextReader reader, System.Type objectType) { throw null; }

        public T? Deserialize<T>(JsonReader reader) { throw null; }

        public void Populate(JsonReader reader, object target) { }

        public void Populate(System.IO.TextReader reader, object target) { }

        public void Serialize(JsonWriter jsonWriter, object? value, System.Type? objectType) { }

        public void Serialize(JsonWriter jsonWriter, object? value) { }

        public void Serialize(System.IO.TextWriter textWriter, object? value, System.Type objectType) { }

        public void Serialize(System.IO.TextWriter textWriter, object? value) { }
    }

    public partial class JsonSerializerSettings
    {
        [System.Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
        public SerializationBinder? Binder { get { throw null; } set { } }

        public bool CheckAdditionalContent { get { throw null; } set { } }

        public ConstructorHandling ConstructorHandling { get { throw null; } set { } }

        public System.Runtime.Serialization.StreamingContext Context { get { throw null; } set { } }

        public Serialization.IContractResolver? ContractResolver { get { throw null; } set { } }

        public System.Collections.Generic.IList<JsonConverter> Converters { get { throw null; } set { } }

        public System.Globalization.CultureInfo Culture { get { throw null; } set { } }

        public DateFormatHandling DateFormatHandling { get { throw null; } set { } }

        public string DateFormatString { get { throw null; } set { } }

        public DateParseHandling DateParseHandling { get { throw null; } set { } }

        public DateTimeZoneHandling DateTimeZoneHandling { get { throw null; } set { } }

        public DefaultValueHandling DefaultValueHandling { get { throw null; } set { } }

        public System.Collections.IEqualityComparer? EqualityComparer { get { throw null; } set { } }

        public System.EventHandler<Serialization.ErrorEventArgs>? Error { get { throw null; } set { } }

        public FloatFormatHandling FloatFormatHandling { get { throw null; } set { } }

        public FloatParseHandling FloatParseHandling { get { throw null; } set { } }

        public Formatting Formatting { get { throw null; } set { } }

        public int? MaxDepth { get { throw null; } set { } }

        public MetadataPropertyHandling MetadataPropertyHandling { get { throw null; } set { } }

        public MissingMemberHandling MissingMemberHandling { get { throw null; } set { } }

        public NullValueHandling NullValueHandling { get { throw null; } set { } }

        public ObjectCreationHandling ObjectCreationHandling { get { throw null; } set { } }

        public PreserveReferencesHandling PreserveReferencesHandling { get { throw null; } set { } }

        public ReferenceLoopHandling ReferenceLoopHandling { get { throw null; } set { } }

        [System.Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
        public Serialization.IReferenceResolver? ReferenceResolver { get { throw null; } set { } }

        public System.Func<Serialization.IReferenceResolver?>? ReferenceResolverProvider { get { throw null; } set { } }

        public Serialization.ISerializationBinder? SerializationBinder { get { throw null; } set { } }

        public StringEscapeHandling StringEscapeHandling { get { throw null; } set { } }

        public Serialization.ITraceWriter? TraceWriter { get { throw null; } set { } }

        [System.Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
        public System.Runtime.Serialization.Formatters.FormatterAssemblyStyle TypeNameAssemblyFormat { get { throw null; } set { } }

        public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get { throw null; } set { } }

        public TypeNameHandling TypeNameHandling { get { throw null; } set { } }
    }

    public partial class JsonTextReader : JsonReader, IJsonLineInfo
    {
        public JsonTextReader(System.IO.TextReader reader) { }

        public IArrayPool<char>? ArrayPool { get { throw null; } set { } }

        public int LineNumber { get { throw null; } }

        public int LinePosition { get { throw null; } }

        public JsonNameTable? PropertyNameTable { get { throw null; } set { } }

        public override void Close() { }

        public bool HasLineInfo() { throw null; }

        public override bool Read() { throw null; }

        public override bool? ReadAsBoolean() { throw null; }

        public override System.Threading.Tasks.Task<bool?> ReadAsBooleanAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override byte[]? ReadAsBytes() { throw null; }

        public override System.Threading.Tasks.Task<byte[]?> ReadAsBytesAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.DateTime? ReadAsDateTime() { throw null; }

        public override System.Threading.Tasks.Task<System.DateTime?> ReadAsDateTimeAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.DateTimeOffset? ReadAsDateTimeOffset() { throw null; }

        public override System.Threading.Tasks.Task<System.DateTimeOffset?> ReadAsDateTimeOffsetAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override decimal? ReadAsDecimal() { throw null; }

        public override System.Threading.Tasks.Task<decimal?> ReadAsDecimalAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override double? ReadAsDouble() { throw null; }

        public override System.Threading.Tasks.Task<double?> ReadAsDoubleAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override int? ReadAsInt32() { throw null; }

        public override System.Threading.Tasks.Task<int?> ReadAsInt32Async(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override string? ReadAsString() { throw null; }

        public override System.Threading.Tasks.Task<string?> ReadAsStringAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task<bool> ReadAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }
    }

    public partial class JsonTextWriter : JsonWriter
    {
        public JsonTextWriter(System.IO.TextWriter textWriter) { }

        public IArrayPool<char>? ArrayPool { get { throw null; } set { } }

        public int Indentation { get { throw null; } set { } }

        public char IndentChar { get { throw null; } set { } }

        public char QuoteChar { get { throw null; } set { } }

        public bool QuoteName { get { throw null; } set { } }

        public override void Close() { }

        public override System.Threading.Tasks.Task CloseAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override void Flush() { }

        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override void WriteComment(string? text) { }

        public override System.Threading.Tasks.Task WriteCommentAsync(string? text, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        protected override void WriteEnd(JsonToken token) { }

        public override System.Threading.Tasks.Task WriteEndArrayAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        protected override System.Threading.Tasks.Task WriteEndAsync(JsonToken token, System.Threading.CancellationToken cancellationToken) { throw null; }

        public override System.Threading.Tasks.Task WriteEndAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteEndConstructorAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteEndObjectAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        protected override void WriteIndent() { }

        protected override System.Threading.Tasks.Task WriteIndentAsync(System.Threading.CancellationToken cancellationToken) { throw null; }

        protected override void WriteIndentSpace() { }

        protected override System.Threading.Tasks.Task WriteIndentSpaceAsync(System.Threading.CancellationToken cancellationToken) { throw null; }

        public override void WriteNull() { }

        public override System.Threading.Tasks.Task WriteNullAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override void WritePropertyName(string name, bool escape) { }

        public override void WritePropertyName(string name) { }

        public override System.Threading.Tasks.Task WritePropertyNameAsync(string name, bool escape, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WritePropertyNameAsync(string name, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override void WriteRaw(string? json) { }

        public override System.Threading.Tasks.Task WriteRawAsync(string? json, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteRawValueAsync(string? json, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override void WriteStartArray() { }

        public override System.Threading.Tasks.Task WriteStartArrayAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override void WriteStartConstructor(string name) { }

        public override System.Threading.Tasks.Task WriteStartConstructorAsync(string name, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override void WriteStartObject() { }

        public override System.Threading.Tasks.Task WriteStartObjectAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override void WriteUndefined() { }

        public override System.Threading.Tasks.Task WriteUndefinedAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override void WriteValue(bool value) { }

        public override void WriteValue(byte value) { }

        public override void WriteValue(byte[]? value) { }

        public override void WriteValue(char value) { }

        public override void WriteValue(System.DateTime value) { }

        public override void WriteValue(System.DateTimeOffset value) { }

        public override void WriteValue(decimal value) { }

        public override void WriteValue(double value) { }

        public override void WriteValue(System.Guid value) { }

        public override void WriteValue(short value) { }

        public override void WriteValue(int value) { }

        public override void WriteValue(long value) { }

        public override void WriteValue(double? value) { }

        public override void WriteValue(float? value) { }

        public override void WriteValue(object? value) { }

        [System.CLSCompliant(false)]
        public override void WriteValue(sbyte value) { }

        public override void WriteValue(float value) { }

        public override void WriteValue(string? value) { }

        public override void WriteValue(System.TimeSpan value) { }

        [System.CLSCompliant(false)]
        public override void WriteValue(ushort value) { }

        [System.CLSCompliant(false)]
        public override void WriteValue(uint value) { }

        [System.CLSCompliant(false)]
        public override void WriteValue(ulong value) { }

        public override void WriteValue(System.Uri? value) { }

        public override System.Threading.Tasks.Task WriteValueAsync(bool value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(byte value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(byte[]? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(char value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(System.DateTime value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(System.DateTimeOffset value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(decimal value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(double value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(System.Guid value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(short value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(int value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(long value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(bool? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(byte? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(char? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(System.DateTime? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(System.DateTimeOffset? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(decimal? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(double? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(System.Guid? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(short? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(int? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(long? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public override System.Threading.Tasks.Task WriteValueAsync(sbyte? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(float? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(System.TimeSpan? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public override System.Threading.Tasks.Task WriteValueAsync(ushort? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public override System.Threading.Tasks.Task WriteValueAsync(uint? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public override System.Threading.Tasks.Task WriteValueAsync(ulong? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(object? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public override System.Threading.Tasks.Task WriteValueAsync(sbyte value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(float value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(string? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(System.TimeSpan value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public override System.Threading.Tasks.Task WriteValueAsync(ushort value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public override System.Threading.Tasks.Task WriteValueAsync(uint value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public override System.Threading.Tasks.Task WriteValueAsync(ulong value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override System.Threading.Tasks.Task WriteValueAsync(System.Uri? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        protected override void WriteValueDelimiter() { }

        protected override System.Threading.Tasks.Task WriteValueDelimiterAsync(System.Threading.CancellationToken cancellationToken) { throw null; }

        public override void WriteWhitespace(string ws) { }

        public override System.Threading.Tasks.Task WriteWhitespaceAsync(string ws, System.Threading.CancellationToken cancellationToken = default) { throw null; }
    }

    public enum JsonToken
    {
        None = 0,
        StartObject = 1,
        StartArray = 2,
        StartConstructor = 3,
        PropertyName = 4,
        Comment = 5,
        Raw = 6,
        Integer = 7,
        Float = 8,
        String = 9,
        Boolean = 10,
        Null = 11,
        Undefined = 12,
        EndObject = 13,
        EndArray = 14,
        EndConstructor = 15,
        Date = 16,
        Bytes = 17
    }

    [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
    public partial class JsonValidatingReader : JsonReader, IJsonLineInfo
    {
        public JsonValidatingReader(JsonReader reader) { }

        public override int Depth { get { throw null; } }

        int IJsonLineInfo.LineNumber { get { throw null; } }

        int IJsonLineInfo.LinePosition { get { throw null; } }

        public override string Path { get { throw null; } }

        public override char QuoteChar { get { throw null; } protected internal set { } }

        public JsonReader Reader { get { throw null; } }

        public Schema.JsonSchema Schema { get { throw null; } set { } }

        public override JsonToken TokenType { get { throw null; } }

        public override object Value { get { throw null; } }

        public override System.Type ValueType { get { throw null; } }

        public event Schema.ValidationEventHandler ValidationEventHandler { add { } remove { } }

        public override void Close() { }

        bool IJsonLineInfo.HasLineInfo() { throw null; }

        public override bool Read() { throw null; }

        public override bool? ReadAsBoolean() { throw null; }

        public override byte[] ReadAsBytes() { throw null; }

        public override System.DateTime? ReadAsDateTime() { throw null; }

        public override System.DateTimeOffset? ReadAsDateTimeOffset() { throw null; }

        public override decimal? ReadAsDecimal() { throw null; }

        public override double? ReadAsDouble() { throw null; }

        public override int? ReadAsInt32() { throw null; }

        public override string ReadAsString() { throw null; }
    }

    public abstract partial class JsonWriter : System.IDisposable
    {
        public bool AutoCompleteOnClose { get { throw null; } set { } }

        public bool CloseOutput { get { throw null; } set { } }

        public System.Globalization.CultureInfo Culture { get { throw null; } set { } }

        public DateFormatHandling DateFormatHandling { get { throw null; } set { } }

        public string? DateFormatString { get { throw null; } set { } }

        public DateTimeZoneHandling DateTimeZoneHandling { get { throw null; } set { } }

        public FloatFormatHandling FloatFormatHandling { get { throw null; } set { } }

        public Formatting Formatting { get { throw null; } set { } }

        public string Path { get { throw null; } }

        public StringEscapeHandling StringEscapeHandling { get { throw null; } set { } }

        protected internal int Top { get { throw null; } }

        public WriteState WriteState { get { throw null; } }

        public virtual void Close() { }

        public virtual System.Threading.Tasks.Task CloseAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        protected virtual void Dispose(bool disposing) { }

        public abstract void Flush();
        public virtual System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        protected void SetWriteState(JsonToken token, object value) { }

        protected System.Threading.Tasks.Task SetWriteStateAsync(JsonToken token, object value, System.Threading.CancellationToken cancellationToken) { throw null; }

        void System.IDisposable.Dispose() { }

        public virtual void WriteComment(string? text) { }

        public virtual System.Threading.Tasks.Task WriteCommentAsync(string? text, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual void WriteEnd() { }

        protected virtual void WriteEnd(JsonToken token) { }

        public virtual void WriteEndArray() { }

        public virtual System.Threading.Tasks.Task WriteEndArrayAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        protected virtual System.Threading.Tasks.Task WriteEndAsync(JsonToken token, System.Threading.CancellationToken cancellationToken) { throw null; }

        public virtual System.Threading.Tasks.Task WriteEndAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual void WriteEndConstructor() { }

        public virtual System.Threading.Tasks.Task WriteEndConstructorAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual void WriteEndObject() { }

        public virtual System.Threading.Tasks.Task WriteEndObjectAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        protected virtual void WriteIndent() { }

        protected virtual System.Threading.Tasks.Task WriteIndentAsync(System.Threading.CancellationToken cancellationToken) { throw null; }

        protected virtual void WriteIndentSpace() { }

        protected virtual System.Threading.Tasks.Task WriteIndentSpaceAsync(System.Threading.CancellationToken cancellationToken) { throw null; }

        public virtual void WriteNull() { }

        public virtual System.Threading.Tasks.Task WriteNullAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual void WritePropertyName(string name, bool escape) { }

        public virtual void WritePropertyName(string name) { }

        public virtual System.Threading.Tasks.Task WritePropertyNameAsync(string name, bool escape, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WritePropertyNameAsync(string name, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual void WriteRaw(string? json) { }

        public virtual System.Threading.Tasks.Task WriteRawAsync(string? json, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual void WriteRawValue(string? json) { }

        public virtual System.Threading.Tasks.Task WriteRawValueAsync(string? json, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual void WriteStartArray() { }

        public virtual System.Threading.Tasks.Task WriteStartArrayAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual void WriteStartConstructor(string name) { }

        public virtual System.Threading.Tasks.Task WriteStartConstructorAsync(string name, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual void WriteStartObject() { }

        public virtual System.Threading.Tasks.Task WriteStartObjectAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public void WriteToken(JsonReader reader, bool writeChildren) { }

        public void WriteToken(JsonReader reader) { }

        public void WriteToken(JsonToken token, object? value) { }

        public void WriteToken(JsonToken token) { }

        public System.Threading.Tasks.Task WriteTokenAsync(JsonReader reader, bool writeChildren, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public System.Threading.Tasks.Task WriteTokenAsync(JsonReader reader, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public System.Threading.Tasks.Task WriteTokenAsync(JsonToken token, object? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public System.Threading.Tasks.Task WriteTokenAsync(JsonToken token, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual void WriteUndefined() { }

        public virtual System.Threading.Tasks.Task WriteUndefinedAsync(System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual void WriteValue(bool value) { }

        public virtual void WriteValue(byte value) { }

        public virtual void WriteValue(byte[]? value) { }

        public virtual void WriteValue(char value) { }

        public virtual void WriteValue(System.DateTime value) { }

        public virtual void WriteValue(System.DateTimeOffset value) { }

        public virtual void WriteValue(decimal value) { }

        public virtual void WriteValue(double value) { }

        public virtual void WriteValue(System.Guid value) { }

        public virtual void WriteValue(short value) { }

        public virtual void WriteValue(int value) { }

        public virtual void WriteValue(long value) { }

        public virtual void WriteValue(bool? value) { }

        public virtual void WriteValue(byte? value) { }

        public virtual void WriteValue(char? value) { }

        public virtual void WriteValue(System.DateTime? value) { }

        public virtual void WriteValue(System.DateTimeOffset? value) { }

        public virtual void WriteValue(decimal? value) { }

        public virtual void WriteValue(double? value) { }

        public virtual void WriteValue(System.Guid? value) { }

        public virtual void WriteValue(short? value) { }

        public virtual void WriteValue(int? value) { }

        public virtual void WriteValue(long? value) { }

        [System.CLSCompliant(false)]
        public virtual void WriteValue(sbyte? value) { }

        public virtual void WriteValue(float? value) { }

        public virtual void WriteValue(System.TimeSpan? value) { }

        [System.CLSCompliant(false)]
        public virtual void WriteValue(ushort? value) { }

        [System.CLSCompliant(false)]
        public virtual void WriteValue(uint? value) { }

        [System.CLSCompliant(false)]
        public virtual void WriteValue(ulong? value) { }

        public virtual void WriteValue(object? value) { }

        [System.CLSCompliant(false)]
        public virtual void WriteValue(sbyte value) { }

        public virtual void WriteValue(float value) { }

        public virtual void WriteValue(string? value) { }

        public virtual void WriteValue(System.TimeSpan value) { }

        [System.CLSCompliant(false)]
        public virtual void WriteValue(ushort value) { }

        [System.CLSCompliant(false)]
        public virtual void WriteValue(uint value) { }

        [System.CLSCompliant(false)]
        public virtual void WriteValue(ulong value) { }

        public virtual void WriteValue(System.Uri? value) { }

        public virtual System.Threading.Tasks.Task WriteValueAsync(bool value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(byte value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(byte[]? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(char value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(System.DateTime value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(System.DateTimeOffset value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(decimal value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(double value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(System.Guid value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(short value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(int value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(long value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(bool? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(byte? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(char? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(System.DateTime? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(System.DateTimeOffset? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(decimal? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(double? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(System.Guid? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(short? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(int? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(long? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public virtual System.Threading.Tasks.Task WriteValueAsync(sbyte? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(float? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(System.TimeSpan? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public virtual System.Threading.Tasks.Task WriteValueAsync(ushort? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public virtual System.Threading.Tasks.Task WriteValueAsync(uint? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public virtual System.Threading.Tasks.Task WriteValueAsync(ulong? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(object? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public virtual System.Threading.Tasks.Task WriteValueAsync(sbyte value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(float value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(string? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(System.TimeSpan value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public virtual System.Threading.Tasks.Task WriteValueAsync(ushort value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public virtual System.Threading.Tasks.Task WriteValueAsync(uint value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        [System.CLSCompliant(false)]
        public virtual System.Threading.Tasks.Task WriteValueAsync(ulong value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public virtual System.Threading.Tasks.Task WriteValueAsync(System.Uri? value, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        protected virtual void WriteValueDelimiter() { }

        protected virtual System.Threading.Tasks.Task WriteValueDelimiterAsync(System.Threading.CancellationToken cancellationToken) { throw null; }

        public virtual void WriteWhitespace(string ws) { }

        public virtual System.Threading.Tasks.Task WriteWhitespaceAsync(string ws, System.Threading.CancellationToken cancellationToken = default) { throw null; }
    }

    public partial class JsonWriterException : JsonException
    {
        public JsonWriterException() { }

        public JsonWriterException(string message, System.Exception innerException) { }

        public JsonWriterException(string message, string path, System.Exception? innerException) { }

        public JsonWriterException(string message) { }

        public string? Path { get { throw null; } }
    }

    public enum MemberSerialization
    {
        OptOut = 0,
        OptIn = 1,
        Fields = 2
    }

    public enum MetadataPropertyHandling
    {
        Default = 0,
        ReadAhead = 1,
        Ignore = 2
    }

    public enum MissingMemberHandling
    {
        Ignore = 0,
        Error = 1
    }

    public enum NullValueHandling
    {
        Include = 0,
        Ignore = 1
    }

    public enum ObjectCreationHandling
    {
        Auto = 0,
        Reuse = 1,
        Replace = 2
    }

    [System.Flags]
    public enum PreserveReferencesHandling
    {
        None = 0,
        Objects = 1,
        Arrays = 2,
        All = 3
    }

    public enum ReferenceLoopHandling
    {
        Error = 0,
        Ignore = 1,
        Serialize = 2
    }

    public enum Required
    {
        Default = 0,
        AllowNull = 1,
        Always = 2,
        DisallowNull = 3
    }

    [System.Obsolete("SerializationBinder is obsolete. Use ISerializationBinder instead.")]
    public abstract partial class SerializationBinder
    {
        public virtual void BindToName(System.Type serializedType, out string? assemblyName, out string? typeName) { throw null; }

        public abstract System.Type BindToType(string? assemblyName, string typeName);
    }

    public enum StringEscapeHandling
    {
        Default = 0,
        EscapeNonAscii = 1,
        EscapeHtml = 2
    }

    public enum TraceLevel
    {
        Off = 0,
        Error = 1,
        Warning = 2,
        Info = 3,
        Verbose = 4
    }

    public enum TypeNameAssemblyFormatHandling
    {
        Simple = 0,
        Full = 1
    }

    [System.Flags]
    public enum TypeNameHandling
    {
        None = 0,
        Objects = 1,
        Arrays = 2,
        All = 3,
        Auto = 4
    }

    public enum WriteState
    {
        Error = 0,
        Closed = 1,
        Object = 2,
        Array = 3,
        Constructor = 4,
        Property = 5,
        Start = 6
    }
}

namespace Newtonsoft.Json.Bson
{
    [System.Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
    public partial class BsonObjectId
    {
        public BsonObjectId(byte[] value) { }

        public byte[] Value { get { throw null; } }
    }

    [System.Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
    public partial class BsonReader : JsonReader
    {
        public BsonReader(System.IO.BinaryReader reader, bool readRootValueAsArray, System.DateTimeKind dateTimeKindHandling) { }

        public BsonReader(System.IO.BinaryReader reader) { }

        public BsonReader(System.IO.Stream stream, bool readRootValueAsArray, System.DateTimeKind dateTimeKindHandling) { }

        public BsonReader(System.IO.Stream stream) { }

        public System.DateTimeKind DateTimeKindHandling { get { throw null; } set { } }

        [System.Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
        public bool JsonNet35BinaryCompatibility { get { throw null; } set { } }

        public bool ReadRootValueAsArray { get { throw null; } set { } }

        public override void Close() { }

        public override bool Read() { throw null; }
    }

    [System.Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
    public partial class BsonWriter : JsonWriter
    {
        public BsonWriter(System.IO.BinaryWriter writer) { }

        public BsonWriter(System.IO.Stream stream) { }

        public System.DateTimeKind DateTimeKindHandling { get { throw null; } set { } }

        public override void Close() { }

        public override void Flush() { }

        public override void WriteComment(string text) { }

        protected override void WriteEnd(JsonToken token) { }

        public override void WriteNull() { }

        public void WriteObjectId(byte[] value) { }

        public override void WritePropertyName(string name) { }

        public override void WriteRaw(string json) { }

        public override void WriteRawValue(string json) { }

        public void WriteRegex(string pattern, string options) { }

        public override void WriteStartArray() { }

        public override void WriteStartConstructor(string name) { }

        public override void WriteStartObject() { }

        public override void WriteUndefined() { }

        public override void WriteValue(bool value) { }

        public override void WriteValue(byte value) { }

        public override void WriteValue(byte[] value) { }

        public override void WriteValue(char value) { }

        public override void WriteValue(System.DateTime value) { }

        public override void WriteValue(System.DateTimeOffset value) { }

        public override void WriteValue(decimal value) { }

        public override void WriteValue(double value) { }

        public override void WriteValue(System.Guid value) { }

        public override void WriteValue(short value) { }

        public override void WriteValue(int value) { }

        public override void WriteValue(long value) { }

        public override void WriteValue(object value) { }

        [System.CLSCompliant(false)]
        public override void WriteValue(sbyte value) { }

        public override void WriteValue(float value) { }

        public override void WriteValue(string value) { }

        public override void WriteValue(System.TimeSpan value) { }

        [System.CLSCompliant(false)]
        public override void WriteValue(ushort value) { }

        [System.CLSCompliant(false)]
        public override void WriteValue(uint value) { }

        [System.CLSCompliant(false)]
        public override void WriteValue(ulong value) { }

        public override void WriteValue(System.Uri value) { }
    }
}

namespace Newtonsoft.Json.Converters
{
    public partial class BinaryConverter : JsonConverter
    {
        public override bool CanConvert(System.Type objectType) { throw null; }

        public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer) { throw null; }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
    }

    [System.Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
    public partial class BsonObjectIdConverter : JsonConverter
    {
        public override bool CanConvert(System.Type objectType) { throw null; }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer) { throw null; }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }
    }

    public abstract partial class CustomCreationConverter<T> : JsonConverter
    {
        public override bool CanWrite { get { throw null; } }

        public override bool CanConvert(System.Type objectType) { throw null; }

        public abstract T Create(System.Type objectType);
        public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer) { throw null; }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
    }

    public abstract partial class DateTimeConverterBase : JsonConverter
    {
        public override bool CanConvert(System.Type objectType) { throw null; }
    }

    public partial class DiscriminatedUnionConverter : JsonConverter
    {
        public override bool CanConvert(System.Type objectType) { throw null; }

        public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer) { throw null; }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
    }

    public partial class ExpandoObjectConverter : JsonConverter
    {
        public override bool CanWrite { get { throw null; } }

        public override bool CanConvert(System.Type objectType) { throw null; }

        public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer) { throw null; }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
    }

    public partial class IsoDateTimeConverter : DateTimeConverterBase
    {
        public System.Globalization.CultureInfo Culture { get { throw null; } set { } }

        public string? DateTimeFormat { get { throw null; } set { } }

        public System.Globalization.DateTimeStyles DateTimeStyles { get { throw null; } set { } }

        public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer) { throw null; }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
    }

    public partial class JavaScriptDateTimeConverter : DateTimeConverterBase
    {
        public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer) { throw null; }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
    }

    public partial class KeyValuePairConverter : JsonConverter
    {
        public override bool CanConvert(System.Type objectType) { throw null; }

        public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer) { throw null; }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
    }

    public partial class RegexConverter : JsonConverter
    {
        public override bool CanConvert(System.Type objectType) { throw null; }

        public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer) { throw null; }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
    }

    public partial class StringEnumConverter : JsonConverter
    {
        public StringEnumConverter() { }

        public StringEnumConverter(Serialization.NamingStrategy namingStrategy, bool allowIntegerValues = true) { }

        [System.Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
        public StringEnumConverter(bool camelCaseText) { }

        public StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues) { }

        public StringEnumConverter(System.Type namingStrategyType, object[] namingStrategyParameters) { }

        public StringEnumConverter(System.Type namingStrategyType) { }

        public bool AllowIntegerValues { get { throw null; } set { } }

        [System.Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
        public bool CamelCaseText { get { throw null; } set { } }

        public Serialization.NamingStrategy? NamingStrategy { get { throw null; } set { } }

        public override bool CanConvert(System.Type objectType) { throw null; }

        public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer) { throw null; }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
    }

    public partial class UnixDateTimeConverter : DateTimeConverterBase
    {
        public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer) { throw null; }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
    }

    public partial class VersionConverter : JsonConverter
    {
        public override bool CanConvert(System.Type objectType) { throw null; }

        public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer) { throw null; }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
    }

    public partial class XmlNodeConverter : JsonConverter
    {
        public string? DeserializeRootElementName { get { throw null; } set { } }

        public bool EncodeSpecialCharacters { get { throw null; } set { } }

        public bool OmitRootObject { get { throw null; } set { } }

        public bool WriteArrayAttribute { get { throw null; } set { } }

        public override bool CanConvert(System.Type valueType) { throw null; }

        public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer) { throw null; }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
    }
}

namespace Newtonsoft.Json.Linq
{
    public enum CommentHandling
    {
        Ignore = 0,
        Load = 1
    }

    public enum DuplicatePropertyNameHandling
    {
        Replace = 0,
        Ignore = 1,
        Error = 2
    }

    public static partial class Extensions
    {
        public static IJEnumerable<JToken> Ancestors<T>(this System.Collections.Generic.IEnumerable<T> source)
            where T : JToken { throw null; }

        public static IJEnumerable<JToken> AncestorsAndSelf<T>(this System.Collections.Generic.IEnumerable<T> source)
            where T : JToken { throw null; }

        public static IJEnumerable<JToken> AsJEnumerable(this System.Collections.Generic.IEnumerable<JToken> source) { throw null; }

        public static IJEnumerable<T> AsJEnumerable<T>(this System.Collections.Generic.IEnumerable<T> source)
            where T : JToken { throw null; }

        public static IJEnumerable<JToken> Children<T>(this System.Collections.Generic.IEnumerable<T> source)
            where T : JToken { throw null; }

        public static System.Collections.Generic.IEnumerable<U?> Children<T, U>(this System.Collections.Generic.IEnumerable<T> source)
            where T : JToken { throw null; }

        public static IJEnumerable<JToken> Descendants<T>(this System.Collections.Generic.IEnumerable<T> source)
            where T : JContainer { throw null; }

        public static IJEnumerable<JToken> DescendantsAndSelf<T>(this System.Collections.Generic.IEnumerable<T> source)
            where T : JContainer { throw null; }

        public static IJEnumerable<JProperty> Properties(this System.Collections.Generic.IEnumerable<JObject> source) { throw null; }

        public static U? Value<U>(this System.Collections.Generic.IEnumerable<JToken> value) { throw null; }

        public static U? Value<T, U>(this System.Collections.Generic.IEnumerable<T> value)
            where T : JToken { throw null; }

        public static IJEnumerable<JToken> Values(this System.Collections.Generic.IEnumerable<JToken> source, object? key) { throw null; }

        public static IJEnumerable<JToken> Values(this System.Collections.Generic.IEnumerable<JToken> source) { throw null; }

        public static System.Collections.Generic.IEnumerable<U?> Values<U>(this System.Collections.Generic.IEnumerable<JToken> source, object key) { throw null; }

        public static System.Collections.Generic.IEnumerable<U?> Values<U>(this System.Collections.Generic.IEnumerable<JToken> source) { throw null; }
    }

    public partial interface IJEnumerable<out T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable where T : JToken
    {
        IJEnumerable<JToken> this[object key] { get; }
    }

    public partial class JArray : JContainer, System.Collections.Generic.IList<JToken>, System.Collections.Generic.ICollection<JToken>, System.Collections.Generic.IEnumerable<JToken>, System.Collections.IEnumerable
    {
        public JArray() { }

        public JArray(JArray other) { }

        public JArray(object content) { }

        public JArray(params object[] content) { }

        protected override System.Collections.Generic.IList<JToken> ChildrenTokens { get { throw null; } }

        public bool IsReadOnly { get { throw null; } }

        public JToken this[int index] { get { throw null; } set { } }

        public override JToken? this[object key] { get { throw null; } set { } }

        public override JTokenType Type { get { throw null; } }

        public void Add(JToken item) { }

        public void Clear() { }

        public bool Contains(JToken item) { throw null; }

        public void CopyTo(JToken[] array, int arrayIndex) { }

        public static JArray FromObject(object o, JsonSerializer jsonSerializer) { throw null; }

        public static JArray FromObject(object o) { throw null; }

        public System.Collections.Generic.IEnumerator<JToken> GetEnumerator() { throw null; }

        public int IndexOf(JToken item) { throw null; }

        public void Insert(int index, JToken item) { }

        public static JArray Load(JsonReader reader, JsonLoadSettings? settings) { throw null; }

        public static JArray Load(JsonReader reader) { throw null; }

        public static System.Threading.Tasks.Task<JArray> LoadAsync(JsonReader reader, JsonLoadSettings? settings, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public static System.Threading.Tasks.Task<JArray> LoadAsync(JsonReader reader, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public static JArray Parse(string json, JsonLoadSettings? settings) { throw null; }

        public static JArray Parse(string json) { throw null; }

        public bool Remove(JToken item) { throw null; }

        public void RemoveAt(int index) { }

        public override void WriteTo(JsonWriter writer, params JsonConverter[] converters) { }

        public override System.Threading.Tasks.Task WriteToAsync(JsonWriter writer, System.Threading.CancellationToken cancellationToken, params JsonConverter[] converters) { throw null; }
    }

    public partial class JConstructor : JContainer
    {
        public JConstructor() { }

        public JConstructor(JConstructor other) { }

        public JConstructor(string name, object content) { }

        public JConstructor(string name, params object[] content) { }

        public JConstructor(string name) { }

        protected override System.Collections.Generic.IList<JToken> ChildrenTokens { get { throw null; } }

        public override JToken? this[object key] { get { throw null; } set { } }

        public string? Name { get { throw null; } set { } }

        public override JTokenType Type { get { throw null; } }

        public static JConstructor Load(JsonReader reader, JsonLoadSettings? settings) { throw null; }

        public static JConstructor Load(JsonReader reader) { throw null; }

        public static System.Threading.Tasks.Task<JConstructor> LoadAsync(JsonReader reader, JsonLoadSettings? settings, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public static System.Threading.Tasks.Task<JConstructor> LoadAsync(JsonReader reader, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override void WriteTo(JsonWriter writer, params JsonConverter[] converters) { }

        public override System.Threading.Tasks.Task WriteToAsync(JsonWriter writer, System.Threading.CancellationToken cancellationToken, params JsonConverter[] converters) { throw null; }
    }

    public abstract partial class JContainer : JToken, System.Collections.Generic.IList<JToken>, System.Collections.Generic.ICollection<JToken>, System.Collections.Generic.IEnumerable<JToken>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, System.Collections.Specialized.INotifyCollectionChanged
    {
        internal JContainer() { }

        protected abstract System.Collections.Generic.IList<JToken> ChildrenTokens { get; }

        public int Count { get { throw null; } }

        public override JToken? First { get { throw null; } }

        public override bool HasValues { get { throw null; } }

        public override JToken? Last { get { throw null; } }

        bool System.Collections.Generic.ICollection<JToken>.IsReadOnly { get { throw null; } }

        JToken System.Collections.Generic.IList<JToken>.this[int index] { get { throw null; } set { } }

        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }

        object System.Collections.ICollection.SyncRoot { get { throw null; } }

        bool System.Collections.IList.IsFixedSize { get { throw null; } }

        bool System.Collections.IList.IsReadOnly { get { throw null; } }

        object System.Collections.IList.this[int index] { get { throw null; } set { } }

        public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged { add { } remove { } }

        public virtual void Add(object? content) { }

        public void AddFirst(object? content) { }

        public override JEnumerable<JToken> Children() { throw null; }

        public JsonWriter CreateWriter() { throw null; }

        public System.Collections.Generic.IEnumerable<JToken> Descendants() { throw null; }

        public System.Collections.Generic.IEnumerable<JToken> DescendantsAndSelf() { throw null; }

        public void Merge(object content, JsonMergeSettings? settings) { }

        public void Merge(object content) { }

        protected virtual void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }

        public void RemoveAll() { }

        public void ReplaceAll(object content) { }

        void System.Collections.Generic.ICollection<JToken>.Add(JToken item) { }

        void System.Collections.Generic.ICollection<JToken>.Clear() { }

        bool System.Collections.Generic.ICollection<JToken>.Contains(JToken item) { throw null; }

        void System.Collections.Generic.ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex) { }

        bool System.Collections.Generic.ICollection<JToken>.Remove(JToken item) { throw null; }

        int System.Collections.Generic.IList<JToken>.IndexOf(JToken item) { throw null; }

        void System.Collections.Generic.IList<JToken>.Insert(int index, JToken item) { }

        void System.Collections.Generic.IList<JToken>.RemoveAt(int index) { }

        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }

        int System.Collections.IList.Add(object value) { throw null; }

        void System.Collections.IList.Clear() { }

        bool System.Collections.IList.Contains(object value) { throw null; }

        int System.Collections.IList.IndexOf(object value) { throw null; }

        void System.Collections.IList.Insert(int index, object value) { }

        void System.Collections.IList.Remove(object value) { }

        void System.Collections.IList.RemoveAt(int index) { }

        public override System.Collections.Generic.IEnumerable<T?> Values<T>()
            where T : default { throw null; }
    }

    public readonly partial struct JEnumerable<T> : IJEnumerable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<JEnumerable<T>> where T : JToken
    {
        private readonly System.Collections.Generic.IEnumerable<T> _enumerable;
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public static readonly JEnumerable<T> Empty;
        public JEnumerable(System.Collections.Generic.IEnumerable<T> enumerable) { }

        public IJEnumerable<JToken> this[object key] { get { throw null; } }

        public readonly bool Equals(JEnumerable<T> other) { throw null; }

        public override readonly bool Equals(object obj) { throw null; }

        public readonly System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }

        public override readonly int GetHashCode() { throw null; }

        readonly System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }

    public partial class JObject : JContainer, System.Collections.Generic.IDictionary<string, JToken?>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, JToken?>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, JToken?>>, System.Collections.IEnumerable, System.ComponentModel.INotifyPropertyChanged
    {
        public JObject() { }

        public JObject(JObject other) { }

        public JObject(object content) { }

        public JObject(params object[] content) { }

        protected override System.Collections.Generic.IList<JToken> ChildrenTokens { get { throw null; } }

        public override JToken? this[object key] { get { throw null; } set { } }

        public JToken? this[string propertyName] { get { throw null; } set { } }

        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, JToken>>.IsReadOnly { get { throw null; } }

        System.Collections.Generic.ICollection<string> System.Collections.Generic.IDictionary<string, JToken>.Keys { get { throw null; } }

        System.Collections.Generic.ICollection<JToken?> System.Collections.Generic.IDictionary<string, JToken>.Values { get { throw null; } }

        public override JTokenType Type { get { throw null; } }

        public event System.ComponentModel.PropertyChangedEventHandler? PropertyChanged { add { } remove { } }

        public void Add(string propertyName, JToken? value) { }

        public bool ContainsKey(string propertyName) { throw null; }

        public static JObject FromObject(object o, JsonSerializer jsonSerializer) { throw null; }

        public static JObject FromObject(object o) { throw null; }

        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, JToken?>> GetEnumerator() { throw null; }

        protected override System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { throw null; }

        public JToken? GetValue(string? propertyName, System.StringComparison comparison) { throw null; }

        public JToken? GetValue(string? propertyName) { throw null; }

        public static JObject Load(JsonReader reader, JsonLoadSettings? settings) { throw null; }

        public static JObject Load(JsonReader reader) { throw null; }

        public static System.Threading.Tasks.Task<JObject> LoadAsync(JsonReader reader, JsonLoadSettings? settings, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public static System.Threading.Tasks.Task<JObject> LoadAsync(JsonReader reader, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        protected virtual void OnPropertyChanged(string propertyName) { }

        public static JObject Parse(string json, JsonLoadSettings? settings) { throw null; }

        public static JObject Parse(string json) { throw null; }

        public System.Collections.Generic.IEnumerable<JProperty> Properties() { throw null; }

        public JProperty? Property(string name, System.StringComparison comparison) { throw null; }

        public JProperty? Property(string name) { throw null; }

        public JEnumerable<JToken> PropertyValues() { throw null; }

        public bool Remove(string propertyName) { throw null; }

        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, JToken>>.Add(System.Collections.Generic.KeyValuePair<string, JToken?> item) { }

        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, JToken>>.Clear() { }

        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, JToken>>.Contains(System.Collections.Generic.KeyValuePair<string, JToken?> item) { throw null; }

        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<string, JToken?>[] array, int arrayIndex) { }

        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, JToken>>.Remove(System.Collections.Generic.KeyValuePair<string, JToken?> item) { throw null; }

        public bool TryGetValue(string propertyName, out JToken? value) { throw null; }

        public bool TryGetValue(string propertyName, System.StringComparison comparison, out JToken? value) { throw null; }

        public override void WriteTo(JsonWriter writer, params JsonConverter[] converters) { }

        public override System.Threading.Tasks.Task WriteToAsync(JsonWriter writer, System.Threading.CancellationToken cancellationToken, params JsonConverter[] converters) { throw null; }
    }

    public partial class JProperty : JContainer
    {
        public JProperty(JProperty other) { }

        public JProperty(string name, object? content) { }

        public JProperty(string name, params object[] content) { }

        protected override System.Collections.Generic.IList<JToken> ChildrenTokens { get { throw null; } }

        public string Name { get { throw null; } }

        public override JTokenType Type { get { throw null; } }

        public JToken Value { get { throw null; } set { } }

        public static JProperty Load(JsonReader reader, JsonLoadSettings? settings) { throw null; }

        public static JProperty Load(JsonReader reader) { throw null; }

        public static System.Threading.Tasks.Task<JProperty> LoadAsync(JsonReader reader, JsonLoadSettings? settings, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public static System.Threading.Tasks.Task<JProperty> LoadAsync(JsonReader reader, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public override void WriteTo(JsonWriter writer, params JsonConverter[] converters) { }

        public override System.Threading.Tasks.Task WriteToAsync(JsonWriter writer, System.Threading.CancellationToken cancellationToken, params JsonConverter[] converters) { throw null; }
    }

    public partial class JRaw : JValue
    {
        public JRaw(JRaw other) : base(default(JValue)!) { }

        public JRaw(object? rawJson) : base(default(JValue)!) { }

        public static JRaw Create(JsonReader reader) { throw null; }

        public static System.Threading.Tasks.Task<JRaw> CreateAsync(JsonReader reader, System.Threading.CancellationToken cancellationToken = default) { throw null; }
    }

    public partial class JsonLoadSettings
    {
        public CommentHandling CommentHandling { get { throw null; } set { } }

        public DuplicatePropertyNameHandling DuplicatePropertyNameHandling { get { throw null; } set { } }

        public LineInfoHandling LineInfoHandling { get { throw null; } set { } }
    }

    public partial class JsonMergeSettings
    {
        public MergeArrayHandling MergeArrayHandling { get { throw null; } set { } }

        public MergeNullValueHandling MergeNullValueHandling { get { throw null; } set { } }

        public System.StringComparison PropertyNameComparison { get { throw null; } set { } }
    }

    public partial class JsonSelectSettings
    {
        public bool ErrorWhenNoMatch { get { throw null; } set { } }

        public System.TimeSpan? RegexMatchTimeout { get { throw null; } set { } }
    }

    public abstract partial class JToken : IJEnumerable<JToken>, System.Collections.Generic.IEnumerable<JToken>, System.Collections.IEnumerable, IJsonLineInfo, System.Dynamic.IDynamicMetaObjectProvider
    {
        internal JToken() { }

        public static JTokenEqualityComparer EqualityComparer { get { throw null; } }

        public virtual JToken? First { get { throw null; } }

        public abstract bool HasValues { get; }

        public virtual JToken? this[object key] { get { throw null; } set { } }

        public virtual JToken? Last { get { throw null; } }

        int IJsonLineInfo.LineNumber { get { throw null; } }

        int IJsonLineInfo.LinePosition { get { throw null; } }

        IJEnumerable<JToken> IJEnumerable<JToken>.this[object key] { get { throw null; } }

        public JToken? Next { get { throw null; } }

        public JContainer? Parent { get { throw null; } }

        public string Path { get { throw null; } }

        public JToken? Previous { get { throw null; } }

        public JToken Root { get { throw null; } }

        public abstract JTokenType Type { get; }

        public void AddAfterSelf(object? content) { }

        public void AddAnnotation(object annotation) { }

        public void AddBeforeSelf(object? content) { }

        public System.Collections.Generic.IEnumerable<JToken> AfterSelf() { throw null; }

        public System.Collections.Generic.IEnumerable<JToken> Ancestors() { throw null; }

        public System.Collections.Generic.IEnumerable<JToken> AncestorsAndSelf() { throw null; }

        public object? Annotation(System.Type type) { throw null; }

        public T? Annotation<T>()
            where T : class { throw null; }

        public System.Collections.Generic.IEnumerable<object> Annotations(System.Type type) { throw null; }

        public System.Collections.Generic.IEnumerable<T> Annotations<T>()
            where T : class { throw null; }

        public System.Collections.Generic.IEnumerable<JToken> BeforeSelf() { throw null; }

        public virtual JEnumerable<JToken> Children() { throw null; }

        public JEnumerable<T> Children<T>()
            where T : JToken { throw null; }

        public JsonReader CreateReader() { throw null; }

        public JToken DeepClone() { throw null; }

        public static bool DeepEquals(JToken? t1, JToken? t2) { throw null; }

        public static JToken FromObject(object o, JsonSerializer jsonSerializer) { throw null; }

        public static JToken FromObject(object o) { throw null; }

        protected virtual System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { throw null; }

        public static JToken Load(JsonReader reader, JsonLoadSettings? settings) { throw null; }

        public static JToken Load(JsonReader reader) { throw null; }

        public static System.Threading.Tasks.Task<JToken> LoadAsync(JsonReader reader, JsonLoadSettings? settings, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public static System.Threading.Tasks.Task<JToken> LoadAsync(JsonReader reader, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        bool IJsonLineInfo.HasLineInfo() { throw null; }

        public static explicit operator bool(JToken value) { throw null; }

        public static explicit operator byte(JToken value) { throw null; }

        public static explicit operator byte[]?(JToken? value) { throw null; }

        [System.CLSCompliant(false)]
        public static explicit operator char(JToken value) { throw null; }

        public static explicit operator System.DateTime(JToken value) { throw null; }

        public static explicit operator System.DateTimeOffset(JToken value) { throw null; }

        public static explicit operator decimal(JToken value) { throw null; }

        public static explicit operator double(JToken value) { throw null; }

        public static explicit operator System.Guid(JToken value) { throw null; }

        public static explicit operator short(JToken value) { throw null; }

        public static explicit operator int(JToken value) { throw null; }

        public static explicit operator long(JToken value) { throw null; }

        public static explicit operator bool?(JToken? value) { throw null; }

        public static explicit operator byte?(JToken? value) { throw null; }

        public static explicit operator char?(JToken? value) { throw null; }

        public static explicit operator System.DateTime?(JToken? value) { throw null; }

        public static explicit operator System.DateTimeOffset?(JToken? value) { throw null; }

        public static explicit operator decimal?(JToken? value) { throw null; }

        public static explicit operator double?(JToken? value) { throw null; }

        public static explicit operator System.Guid?(JToken? value) { throw null; }

        public static explicit operator short?(JToken? value) { throw null; }

        public static explicit operator int?(JToken? value) { throw null; }

        public static explicit operator long?(JToken? value) { throw null; }

        [System.CLSCompliant(false)]
        public static explicit operator sbyte?(JToken? value) { throw null; }

        public static explicit operator float?(JToken? value) { throw null; }

        public static explicit operator System.TimeSpan?(JToken? value) { throw null; }

        [System.CLSCompliant(false)]
        public static explicit operator ushort?(JToken? value) { throw null; }

        [System.CLSCompliant(false)]
        public static explicit operator uint?(JToken? value) { throw null; }

        [System.CLSCompliant(false)]
        public static explicit operator ulong?(JToken? value) { throw null; }

        [System.CLSCompliant(false)]
        public static explicit operator sbyte(JToken value) { throw null; }

        public static explicit operator float(JToken value) { throw null; }

        public static explicit operator string?(JToken? value) { throw null; }

        public static explicit operator System.TimeSpan(JToken value) { throw null; }

        [System.CLSCompliant(false)]
        public static explicit operator ushort(JToken value) { throw null; }

        [System.CLSCompliant(false)]
        public static explicit operator uint(JToken value) { throw null; }

        [System.CLSCompliant(false)]
        public static explicit operator ulong(JToken value) { throw null; }

        public static explicit operator System.Uri?(JToken? value) { throw null; }

        public static implicit operator JToken(bool value) { throw null; }

        public static implicit operator JToken(byte value) { throw null; }

        public static implicit operator JToken(byte[] value) { throw null; }

        public static implicit operator JToken(System.DateTime value) { throw null; }

        public static implicit operator JToken(System.DateTimeOffset value) { throw null; }

        public static implicit operator JToken(decimal value) { throw null; }

        public static implicit operator JToken(double value) { throw null; }

        public static implicit operator JToken(System.Guid value) { throw null; }

        [System.CLSCompliant(false)]
        public static implicit operator JToken(short value) { throw null; }

        public static implicit operator JToken(int value) { throw null; }

        public static implicit operator JToken(long value) { throw null; }

        public static implicit operator JToken(bool? value) { throw null; }

        public static implicit operator JToken(byte? value) { throw null; }

        public static implicit operator JToken(System.DateTime? value) { throw null; }

        public static implicit operator JToken(System.DateTimeOffset? value) { throw null; }

        public static implicit operator JToken(decimal? value) { throw null; }

        public static implicit operator JToken(double? value) { throw null; }

        public static implicit operator JToken(System.Guid? value) { throw null; }

        [System.CLSCompliant(false)]
        public static implicit operator JToken(short? value) { throw null; }

        public static implicit operator JToken(int? value) { throw null; }

        public static implicit operator JToken(long? value) { throw null; }

        [System.CLSCompliant(false)]
        public static implicit operator JToken(sbyte? value) { throw null; }

        public static implicit operator JToken(float? value) { throw null; }

        public static implicit operator JToken(System.TimeSpan? value) { throw null; }

        [System.CLSCompliant(false)]
        public static implicit operator JToken(ushort? value) { throw null; }

        [System.CLSCompliant(false)]
        public static implicit operator JToken(uint? value) { throw null; }

        [System.CLSCompliant(false)]
        public static implicit operator JToken(ulong? value) { throw null; }

        [System.CLSCompliant(false)]
        public static implicit operator JToken(sbyte value) { throw null; }

        public static implicit operator JToken(float value) { throw null; }

        public static implicit operator JToken(string? value) { throw null; }

        public static implicit operator JToken(System.TimeSpan value) { throw null; }

        [System.CLSCompliant(false)]
        public static implicit operator JToken(ushort value) { throw null; }

        [System.CLSCompliant(false)]
        public static implicit operator JToken(uint value) { throw null; }

        [System.CLSCompliant(false)]
        public static implicit operator JToken(ulong value) { throw null; }

        public static implicit operator JToken(System.Uri? value) { throw null; }

        public static JToken Parse(string json, JsonLoadSettings? settings) { throw null; }

        public static JToken Parse(string json) { throw null; }

        public static JToken ReadFrom(JsonReader reader, JsonLoadSettings? settings) { throw null; }

        public static JToken ReadFrom(JsonReader reader) { throw null; }

        public static System.Threading.Tasks.Task<JToken> ReadFromAsync(JsonReader reader, JsonLoadSettings? settings, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public static System.Threading.Tasks.Task<JToken> ReadFromAsync(JsonReader reader, System.Threading.CancellationToken cancellationToken = default) { throw null; }

        public void Remove() { }

        public void RemoveAnnotations(System.Type type) { }

        public void RemoveAnnotations<T>()
            where T : class { }

        public void Replace(JToken value) { }

        public JToken? SelectToken(string path, JsonSelectSettings? settings) { throw null; }

        public JToken? SelectToken(string path, bool errorWhenNoMatch) { throw null; }

        public JToken? SelectToken(string path) { throw null; }

        public System.Collections.Generic.IEnumerable<JToken> SelectTokens(string path, JsonSelectSettings? settings) { throw null; }

        public System.Collections.Generic.IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch) { throw null; }

        public System.Collections.Generic.IEnumerable<JToken> SelectTokens(string path) { throw null; }

        System.Collections.Generic.IEnumerator<JToken> System.Collections.Generic.IEnumerable<JToken>.GetEnumerator() { throw null; }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }

        System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter) { throw null; }

        public object? ToObject(System.Type objectType, JsonSerializer jsonSerializer) { throw null; }

        public object? ToObject(System.Type objectType) { throw null; }

        public T? ToObject<T>() { throw null; }

        public T? ToObject<T>(JsonSerializer jsonSerializer) { throw null; }

        public override string ToString() { throw null; }

        public string ToString(Formatting formatting, params JsonConverter[] converters) { throw null; }

        public virtual T? Value<T>(object key) { throw null; }

        public virtual System.Collections.Generic.IEnumerable<T?> Values<T>() { throw null; }

        public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);
        public System.Threading.Tasks.Task WriteToAsync(JsonWriter writer, params JsonConverter[] converters) { throw null; }

        public virtual System.Threading.Tasks.Task WriteToAsync(JsonWriter writer, System.Threading.CancellationToken cancellationToken, params JsonConverter[] converters) { throw null; }
    }

    public partial class JTokenEqualityComparer : System.Collections.Generic.IEqualityComparer<JToken>
    {
        public bool Equals(JToken x, JToken y) { throw null; }

        public int GetHashCode(JToken obj) { throw null; }
    }

    public partial class JTokenReader : JsonReader, IJsonLineInfo
    {
        public JTokenReader(JToken token, string initialPath) { }

        public JTokenReader(JToken token) { }

        public JToken? CurrentToken { get { throw null; } }

        int IJsonLineInfo.LineNumber { get { throw null; } }

        int IJsonLineInfo.LinePosition { get { throw null; } }

        public override string Path { get { throw null; } }

        bool IJsonLineInfo.HasLineInfo() { throw null; }

        public override bool Read() { throw null; }
    }

    public enum JTokenType
    {
        None = 0,
        Object = 1,
        Array = 2,
        Constructor = 3,
        Property = 4,
        Comment = 5,
        Integer = 6,
        Float = 7,
        String = 8,
        Boolean = 9,
        Null = 10,
        Undefined = 11,
        Date = 12,
        Raw = 13,
        Bytes = 14,
        Guid = 15,
        Uri = 16,
        TimeSpan = 17
    }

    public partial class JTokenWriter : JsonWriter
    {
        public JTokenWriter() { }

        public JTokenWriter(JContainer container) { }

        public JToken? CurrentToken { get { throw null; } }

        public JToken? Token { get { throw null; } }

        public override void Close() { }

        public override void Flush() { }

        public override void WriteComment(string? text) { }

        protected override void WriteEnd(JsonToken token) { }

        public override void WriteNull() { }

        public override void WritePropertyName(string name) { }

        public override void WriteRaw(string? json) { }

        public override void WriteStartArray() { }

        public override void WriteStartConstructor(string name) { }

        public override void WriteStartObject() { }

        public override void WriteUndefined() { }

        public override void WriteValue(bool value) { }

        public override void WriteValue(byte value) { }

        public override void WriteValue(byte[]? value) { }

        public override void WriteValue(char value) { }

        public override void WriteValue(System.DateTime value) { }

        public override void WriteValue(System.DateTimeOffset value) { }

        public override void WriteValue(decimal value) { }

        public override void WriteValue(double value) { }

        public override void WriteValue(System.Guid value) { }

        public override void WriteValue(short value) { }

        public override void WriteValue(int value) { }

        public override void WriteValue(long value) { }

        public override void WriteValue(object? value) { }

        [System.CLSCompliant(false)]
        public override void WriteValue(sbyte value) { }

        public override void WriteValue(float value) { }

        public override void WriteValue(string? value) { }

        public override void WriteValue(System.TimeSpan value) { }

        [System.CLSCompliant(false)]
        public override void WriteValue(ushort value) { }

        [System.CLSCompliant(false)]
        public override void WriteValue(uint value) { }

        [System.CLSCompliant(false)]
        public override void WriteValue(ulong value) { }

        public override void WriteValue(System.Uri? value) { }
    }

    public partial class JValue : JToken, System.IEquatable<JValue>, System.IFormattable, System.IComparable, System.IComparable<JValue>
    {
        public JValue(JValue other) { }

        public JValue(bool value) { }

        public JValue(char value) { }

        public JValue(System.DateTime value) { }

        public JValue(System.DateTimeOffset value) { }

        public JValue(decimal value) { }

        public JValue(double value) { }

        public JValue(System.Guid value) { }

        public JValue(long value) { }

        public JValue(object? value) { }

        public JValue(float value) { }

        public JValue(string? value) { }

        public JValue(System.TimeSpan value) { }

        [System.CLSCompliant(false)]
        public JValue(ulong value) { }

        public JValue(System.Uri? value) { }

        public override bool HasValues { get { throw null; } }

        public override JTokenType Type { get { throw null; } }

        public new object? Value { get { throw null; } set { } }

        public int CompareTo(JValue obj) { throw null; }

        public static JValue CreateComment(string? value) { throw null; }

        public static JValue CreateNull() { throw null; }

        public static JValue CreateString(string? value) { throw null; }

        public static JValue CreateUndefined() { throw null; }

        public bool Equals(JValue? other) { throw null; }

        public override bool Equals(object obj) { throw null; }

        public override int GetHashCode() { throw null; }

        protected override System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { throw null; }

        int System.IComparable.CompareTo(object obj) { throw null; }

        public override string ToString() { throw null; }

        public string ToString(System.IFormatProvider formatProvider) { throw null; }

        public string ToString(string? format, System.IFormatProvider formatProvider) { throw null; }

        public string ToString(string format) { throw null; }

        public override void WriteTo(JsonWriter writer, params JsonConverter[] converters) { }

        public override System.Threading.Tasks.Task WriteToAsync(JsonWriter writer, System.Threading.CancellationToken cancellationToken, params JsonConverter[] converters) { throw null; }
    }

    public enum LineInfoHandling
    {
        Ignore = 0,
        Load = 1
    }

    public enum MergeArrayHandling
    {
        Concat = 0,
        Union = 1,
        Replace = 2,
        Merge = 3
    }

    [System.Flags]
    public enum MergeNullValueHandling
    {
        Ignore = 0,
        Merge = 1
    }
}

namespace Newtonsoft.Json.Schema
{
    [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
    public static partial class Extensions
    {
        [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
        public static bool IsValid(this Linq.JToken source, JsonSchema schema, out System.Collections.Generic.IList<string> errorMessages) { throw null; }

        [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
        public static bool IsValid(this Linq.JToken source, JsonSchema schema) { throw null; }

        [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
        public static void Validate(this Linq.JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler) { }

        [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
        public static void Validate(this Linq.JToken source, JsonSchema schema) { }
    }

    [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
    public partial class JsonSchema
    {
        public JsonSchema AdditionalItems { get { throw null; } set { } }

        public JsonSchema AdditionalProperties { get { throw null; } set { } }

        public bool AllowAdditionalItems { get { throw null; } set { } }

        public bool AllowAdditionalProperties { get { throw null; } set { } }

        public Linq.JToken Default { get { throw null; } set { } }

        public string Description { get { throw null; } set { } }

        public JsonSchemaType? Disallow { get { throw null; } set { } }

        public double? DivisibleBy { get { throw null; } set { } }

        public System.Collections.Generic.IList<Linq.JToken> Enum { get { throw null; } set { } }

        public bool? ExclusiveMaximum { get { throw null; } set { } }

        public bool? ExclusiveMinimum { get { throw null; } set { } }

        public System.Collections.Generic.IList<JsonSchema> Extends { get { throw null; } set { } }

        public string Format { get { throw null; } set { } }

        public bool? Hidden { get { throw null; } set { } }

        public string Id { get { throw null; } set { } }

        public System.Collections.Generic.IList<JsonSchema> Items { get { throw null; } set { } }

        public double? Maximum { get { throw null; } set { } }

        public int? MaximumItems { get { throw null; } set { } }

        public int? MaximumLength { get { throw null; } set { } }

        public double? Minimum { get { throw null; } set { } }

        public int? MinimumItems { get { throw null; } set { } }

        public int? MinimumLength { get { throw null; } set { } }

        public string Pattern { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, JsonSchema> PatternProperties { get { throw null; } set { } }

        public bool PositionalItemsValidation { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, JsonSchema> Properties { get { throw null; } set { } }

        public bool? ReadOnly { get { throw null; } set { } }

        public bool? Required { get { throw null; } set { } }

        public string Requires { get { throw null; } set { } }

        public string Title { get { throw null; } set { } }

        public bool? Transient { get { throw null; } set { } }

        public JsonSchemaType? Type { get { throw null; } set { } }

        public bool UniqueItems { get { throw null; } set { } }

        public static JsonSchema Parse(string json, JsonSchemaResolver resolver) { throw null; }

        public static JsonSchema Parse(string json) { throw null; }

        public static JsonSchema Read(JsonReader reader, JsonSchemaResolver resolver) { throw null; }

        public static JsonSchema Read(JsonReader reader) { throw null; }

        public override string ToString() { throw null; }

        public void WriteTo(JsonWriter writer, JsonSchemaResolver resolver) { }

        public void WriteTo(JsonWriter writer) { }
    }

    [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
    public partial class JsonSchemaException : JsonException
    {
        public JsonSchemaException() { }

        public JsonSchemaException(string message, System.Exception innerException) { }

        public JsonSchemaException(string message) { }

        public int LineNumber { get { throw null; } }

        public int LinePosition { get { throw null; } }

        public string Path { get { throw null; } }
    }

    [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
    public partial class JsonSchemaGenerator
    {
        public Serialization.IContractResolver ContractResolver { get { throw null; } set { } }

        public UndefinedSchemaIdHandling UndefinedSchemaIdHandling { get { throw null; } set { } }

        public JsonSchema Generate(System.Type type, JsonSchemaResolver resolver, bool rootSchemaNullable) { throw null; }

        public JsonSchema Generate(System.Type type, JsonSchemaResolver resolver) { throw null; }

        public JsonSchema Generate(System.Type type, bool rootSchemaNullable) { throw null; }

        public JsonSchema Generate(System.Type type) { throw null; }
    }

    [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
    public partial class JsonSchemaResolver
    {
        public System.Collections.Generic.IList<JsonSchema> LoadedSchemas { get { throw null; } protected set { } }

        public virtual JsonSchema GetSchema(string reference) { throw null; }
    }

    [System.Flags]
    [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
    public enum JsonSchemaType
    {
        None = 0,
        String = 1,
        Float = 2,
        Integer = 4,
        Boolean = 8,
        Object = 16,
        Array = 32,
        Null = 64,
        Any = 127
    }

    [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
    public enum UndefinedSchemaIdHandling
    {
        None = 0,
        UseTypeName = 1,
        UseAssemblyQualifiedName = 2
    }

    [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
    public partial class ValidationEventArgs : System.EventArgs
    {
        internal ValidationEventArgs() { }

        public JsonSchemaException Exception { get { throw null; } }

        public string Message { get { throw null; } }

        public string Path { get { throw null; } }
    }

    [System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
    public delegate void ValidationEventHandler(object sender, ValidationEventArgs e);
}

namespace Newtonsoft.Json.Serialization
{
    public partial class CamelCaseNamingStrategy : NamingStrategy
    {
        public CamelCaseNamingStrategy() { }

        public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

        public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

        protected override string ResolvePropertyName(string name) { throw null; }
    }

    public partial class CamelCasePropertyNamesContractResolver : DefaultContractResolver
    {
        public override JsonContract ResolveContract(System.Type type) { throw null; }
    }

    public partial class DefaultContractResolver : IContractResolver
    {
        public bool DynamicCodeGeneration { get { throw null; } }

        public bool IgnoreIsSpecifiedMembers { get { throw null; } set { } }

        public bool IgnoreShouldSerializeMembers { get { throw null; } set { } }

        public NamingStrategy? NamingStrategy { get { throw null; } set { } }

        public bool SerializeCompilerGeneratedMembers { get { throw null; } set { } }

        protected virtual JsonArrayContract CreateArrayContract(System.Type objectType) { throw null; }

        protected virtual System.Collections.Generic.IList<JsonProperty> CreateConstructorParameters(System.Reflection.ConstructorInfo constructor, JsonPropertyCollection memberProperties) { throw null; }

        protected virtual JsonContract CreateContract(System.Type objectType) { throw null; }

        protected virtual JsonDictionaryContract CreateDictionaryContract(System.Type objectType) { throw null; }

        protected virtual JsonDynamicContract CreateDynamicContract(System.Type objectType) { throw null; }

        protected virtual JsonLinqContract CreateLinqContract(System.Type objectType) { throw null; }

        protected virtual IValueProvider CreateMemberValueProvider(System.Reflection.MemberInfo member) { throw null; }

        protected virtual JsonObjectContract CreateObjectContract(System.Type objectType) { throw null; }

        protected virtual JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType) { throw null; }

        protected virtual System.Collections.Generic.IList<JsonProperty> CreateProperties(System.Type type, MemberSerialization memberSerialization) { throw null; }

        protected virtual JsonProperty CreateProperty(System.Reflection.MemberInfo member, MemberSerialization memberSerialization) { throw null; }

        protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty? matchingMemberProperty, System.Reflection.ParameterInfo parameterInfo) { throw null; }

        protected virtual JsonStringContract CreateStringContract(System.Type objectType) { throw null; }

        public string GetResolvedPropertyName(string propertyName) { throw null; }

        protected virtual System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(System.Type objectType) { throw null; }

        public virtual JsonContract ResolveContract(System.Type type) { throw null; }

        protected virtual JsonConverter? ResolveContractConverter(System.Type objectType) { throw null; }

        protected virtual string ResolveDictionaryKey(string dictionaryKey) { throw null; }

        protected virtual string ResolveExtensionDataName(string extensionDataName) { throw null; }

        protected virtual string ResolvePropertyName(string propertyName) { throw null; }
    }

    public partial class DefaultNamingStrategy : NamingStrategy
    {
        protected override string ResolvePropertyName(string name) { throw null; }
    }

    public partial class DefaultSerializationBinder : SerializationBinder, ISerializationBinder
    {
        public override void BindToName(System.Type serializedType, out string? assemblyName, out string? typeName) { throw null; }

        public override System.Type BindToType(string? assemblyName, string typeName) { throw null; }
    }

    public partial class ErrorContext
    {
        internal ErrorContext() { }

        public System.Exception Error { get { throw null; } }

        public bool Handled { get { throw null; } set { } }

        public object? Member { get { throw null; } }

        public object? OriginalObject { get { throw null; } }

        public string Path { get { throw null; } }
    }

    public partial class ErrorEventArgs : System.EventArgs
    {
        public ErrorEventArgs(object? currentObject, ErrorContext errorContext) { }

        public object? CurrentObject { get { throw null; } }

        public ErrorContext ErrorContext { get { throw null; } }
    }

    public partial class ExpressionValueProvider : IValueProvider
    {
        public ExpressionValueProvider(System.Reflection.MemberInfo memberInfo) { }

        public object? GetValue(object target) { throw null; }

        public void SetValue(object target, object? value) { }
    }

    public delegate System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>>? ExtensionDataGetter(object o);
    public delegate void ExtensionDataSetter(object o, string key, object? value);
    public partial interface IAttributeProvider
    {
        System.Collections.Generic.IList<System.Attribute> GetAttributes(bool inherit);
        System.Collections.Generic.IList<System.Attribute> GetAttributes(System.Type attributeType, bool inherit);
    }

    public partial interface IContractResolver
    {
        JsonContract ResolveContract(System.Type type);
    }

    public partial interface IReferenceResolver
    {
        void AddReference(object context, string reference, object value);
        string GetReference(object context, object value);
        bool IsReferenced(object context, object value);
        object ResolveReference(object context, string reference);
    }

    public partial interface ISerializationBinder
    {
        void BindToName(System.Type serializedType, out string? assemblyName, out string? typeName);
        System.Type BindToType(string? assemblyName, string typeName);
    }

    public partial interface ITraceWriter
    {
        TraceLevel LevelFilter { get; }

        void Trace(TraceLevel level, string message, System.Exception? ex);
    }

    public partial interface IValueProvider
    {
        object? GetValue(object target);
        void SetValue(object target, object? value);
    }

    public partial class JsonArrayContract : JsonContainerContract
    {
        public JsonArrayContract(System.Type underlyingType) { }

        public System.Type? CollectionItemType { get { throw null; } }

        public bool HasParameterizedCreator { get { throw null; } set { } }

        public bool IsMultidimensionalArray { get { throw null; } }

        public ObjectConstructor<object>? OverrideCreator { get { throw null; } set { } }
    }

    public partial class JsonContainerContract : JsonContract
    {
        internal JsonContainerContract() { }

        public JsonConverter? ItemConverter { get { throw null; } set { } }

        public bool? ItemIsReference { get { throw null; } set { } }

        public ReferenceLoopHandling? ItemReferenceLoopHandling { get { throw null; } set { } }

        public TypeNameHandling? ItemTypeNameHandling { get { throw null; } set { } }
    }

    public abstract partial class JsonContract
    {
        internal JsonContract() { }

        public JsonConverter? Converter { get { throw null; } set { } }

        public System.Type CreatedType { get { throw null; } set { } }

        public System.Func<object>? DefaultCreator { get { throw null; } set { } }

        public bool DefaultCreatorNonPublic { get { throw null; } set { } }

        public JsonConverter? InternalConverter { get { throw null; } }

        public bool? IsReference { get { throw null; } set { } }

        public System.Collections.Generic.IList<SerializationCallback> OnDeserializedCallbacks { get { throw null; } }

        public System.Collections.Generic.IList<SerializationCallback> OnDeserializingCallbacks { get { throw null; } }

        public System.Collections.Generic.IList<SerializationErrorCallback> OnErrorCallbacks { get { throw null; } }

        public System.Collections.Generic.IList<SerializationCallback> OnSerializedCallbacks { get { throw null; } }

        public System.Collections.Generic.IList<SerializationCallback> OnSerializingCallbacks { get { throw null; } }

        public System.Type UnderlyingType { get { throw null; } }
    }

    public partial class JsonDictionaryContract : JsonContainerContract
    {
        public JsonDictionaryContract(System.Type underlyingType) { }

        public System.Func<string, string>? DictionaryKeyResolver { get { throw null; } set { } }

        public System.Type? DictionaryKeyType { get { throw null; } }

        public System.Type? DictionaryValueType { get { throw null; } }

        public bool HasParameterizedCreator { get { throw null; } set { } }

        public ObjectConstructor<object>? OverrideCreator { get { throw null; } set { } }
    }

    public partial class JsonDynamicContract : JsonContainerContract
    {
        public JsonDynamicContract(System.Type underlyingType) { }

        public JsonPropertyCollection Properties { get { throw null; } }

        public System.Func<string, string>? PropertyNameResolver { get { throw null; } set { } }
    }

    public partial class JsonLinqContract : JsonContract
    {
        public JsonLinqContract(System.Type underlyingType) { }
    }

    public partial class JsonObjectContract : JsonContainerContract
    {
        public JsonObjectContract(System.Type underlyingType) { }

        public JsonPropertyCollection CreatorParameters { get { throw null; } }

        public ExtensionDataGetter? ExtensionDataGetter { get { throw null; } set { } }

        public System.Func<string, string>? ExtensionDataNameResolver { get { throw null; } set { } }

        public ExtensionDataSetter? ExtensionDataSetter { get { throw null; } set { } }

        public System.Type? ExtensionDataValueType { get { throw null; } set { } }

        public NullValueHandling? ItemNullValueHandling { get { throw null; } set { } }

        public Required? ItemRequired { get { throw null; } set { } }

        public MemberSerialization MemberSerialization { get { throw null; } set { } }

        public MissingMemberHandling? MissingMemberHandling { get { throw null; } set { } }

        public ObjectConstructor<object>? OverrideCreator { get { throw null; } set { } }

        public JsonPropertyCollection Properties { get { throw null; } }
    }

    public partial class JsonPrimitiveContract : JsonContract
    {
        public JsonPrimitiveContract(System.Type underlyingType) { }
    }

    public partial class JsonProperty
    {
        public IAttributeProvider? AttributeProvider { get { throw null; } set { } }

        public JsonConverter? Converter { get { throw null; } set { } }

        public System.Type? DeclaringType { get { throw null; } set { } }

        public object? DefaultValue { get { throw null; } set { } }

        public DefaultValueHandling? DefaultValueHandling { get { throw null; } set { } }

        public System.Predicate<object>? GetIsSpecified { get { throw null; } set { } }

        public bool HasMemberAttribute { get { throw null; } set { } }

        public bool Ignored { get { throw null; } set { } }

        public bool? IsReference { get { throw null; } set { } }

        public bool IsRequiredSpecified { get { throw null; } }

        public JsonConverter? ItemConverter { get { throw null; } set { } }

        public bool? ItemIsReference { get { throw null; } set { } }

        public ReferenceLoopHandling? ItemReferenceLoopHandling { get { throw null; } set { } }

        public TypeNameHandling? ItemTypeNameHandling { get { throw null; } set { } }

        [System.Obsolete("MemberConverter is obsolete. Use Converter instead.")]
        public JsonConverter? MemberConverter { get { throw null; } set { } }

        public NullValueHandling? NullValueHandling { get { throw null; } set { } }

        public ObjectCreationHandling? ObjectCreationHandling { get { throw null; } set { } }

        public int? Order { get { throw null; } set { } }

        public string? PropertyName { get { throw null; } set { } }

        public System.Type? PropertyType { get { throw null; } set { } }

        public bool Readable { get { throw null; } set { } }

        public ReferenceLoopHandling? ReferenceLoopHandling { get { throw null; } set { } }

        public Required Required { get { throw null; } set { } }

        public System.Action<object, object?>? SetIsSpecified { get { throw null; } set { } }

        public System.Predicate<object>? ShouldDeserialize { get { throw null; } set { } }

        public System.Predicate<object>? ShouldSerialize { get { throw null; } set { } }

        public TypeNameHandling? TypeNameHandling { get { throw null; } set { } }

        public string? UnderlyingName { get { throw null; } set { } }

        public IValueProvider? ValueProvider { get { throw null; } set { } }

        public bool Writable { get { throw null; } set { } }

        public override string ToString() { throw null; }
    }

    public partial class JsonPropertyCollection : System.Collections.ObjectModel.KeyedCollection<string, JsonProperty>
    {
        public JsonPropertyCollection(System.Type type) { }

        public void AddProperty(JsonProperty property) { }

        public JsonProperty? GetClosestMatchProperty(string propertyName) { throw null; }

        protected override string GetKeyForItem(JsonProperty item) { throw null; }

        public JsonProperty? GetProperty(string propertyName, System.StringComparison comparisonType) { throw null; }
    }

    public partial class JsonStringContract : JsonPrimitiveContract
    {
        public JsonStringContract(System.Type underlyingType) : base(default!) { }
    }

    public partial class KebabCaseNamingStrategy : NamingStrategy
    {
        public KebabCaseNamingStrategy() { }

        public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

        public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

        protected override string ResolvePropertyName(string name) { throw null; }
    }

    public partial class MemoryTraceWriter : ITraceWriter
    {
        public TraceLevel LevelFilter { get { throw null; } set { } }

        public System.Collections.Generic.IEnumerable<string> GetTraceMessages() { throw null; }

        public override string ToString() { throw null; }

        public void Trace(TraceLevel level, string message, System.Exception? ex) { }
    }

    public abstract partial class NamingStrategy
    {
        public bool OverrideSpecifiedNames { get { throw null; } set { } }

        public bool ProcessDictionaryKeys { get { throw null; } set { } }

        public bool ProcessExtensionDataNames { get { throw null; } set { } }

        protected bool Equals(NamingStrategy? other) { throw null; }

        public override bool Equals(object obj) { throw null; }

        public virtual string GetDictionaryKey(string key) { throw null; }

        public virtual string GetExtensionDataName(string name) { throw null; }

        public override int GetHashCode() { throw null; }

        public virtual string GetPropertyName(string name, bool hasSpecifiedName) { throw null; }

        protected abstract string ResolvePropertyName(string name);
    }

    public delegate object ObjectConstructor<T>(params object?[] args);
    [System.AttributeUsage(System.AttributeTargets.Method, Inherited = false)]
    public sealed partial class OnErrorAttribute : System.Attribute
    {
    }

    public partial class ReflectionAttributeProvider : IAttributeProvider
    {
        public ReflectionAttributeProvider(object attributeProvider) { }

        public System.Collections.Generic.IList<System.Attribute> GetAttributes(bool inherit) { throw null; }

        public System.Collections.Generic.IList<System.Attribute> GetAttributes(System.Type attributeType, bool inherit) { throw null; }
    }

    public partial class ReflectionValueProvider : IValueProvider
    {
        public ReflectionValueProvider(System.Reflection.MemberInfo memberInfo) { }

        public object? GetValue(object target) { throw null; }

        public void SetValue(object target, object? value) { }
    }

    public delegate void SerializationCallback(object o, System.Runtime.Serialization.StreamingContext context);
    public delegate void SerializationErrorCallback(object o, System.Runtime.Serialization.StreamingContext context, ErrorContext errorContext);
    public partial class SnakeCaseNamingStrategy : NamingStrategy
    {
        public SnakeCaseNamingStrategy() { }

        public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

        public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

        protected override string ResolvePropertyName(string name) { throw null; }
    }
}

namespace System.Runtime.Serialization.Formatters
{
    [Obsolete("FormatterAssemblyStyle is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
    public enum FormatterAssemblyStyle
    {
        Simple = 0,
        Full = 1
    }
}