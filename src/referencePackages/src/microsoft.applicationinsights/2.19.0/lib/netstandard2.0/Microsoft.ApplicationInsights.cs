// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Microsoft.ApplicationInsights.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Microsoft.ApplicationInsights.TelemetryChannel.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Microsoft.ApplicationInsights.AspNetCore.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Microsoft.ApplicationInsights.WorkerService.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Microsoft.AI.ServerTelemetryChannel, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Microsoft.AI.PerfCounterCollector, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETStandard,Version=v2.0", FrameworkDisplayName = "")]
[assembly: System.Reflection.AssemblyCompany("Microsoft")]
[assembly: System.Reflection.AssemblyConfiguration("Release")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
[assembly: System.Reflection.AssemblyDescription("Application Insights Base API. This package provides core functionality for transmission of all Application Insights Telemetry Types and is a dependent package for all other Application Insights packages. Please install the platform specific package for the best experience. Privacy statement: https://go.microsoft.com/fwlink/?LinkId=512156")]
[assembly: System.Reflection.AssemblyFileVersion("2.19.0.00227")]
[assembly: System.Reflection.AssemblyInformationalVersion("2.19.0+93f745cfef8541f09862aae9bc8c04554bca38c7")]
[assembly: System.Reflection.AssemblyProduct("Microsoft.ApplicationInsights")]
[assembly: System.Reflection.AssemblyTitle("Microsoft.ApplicationInsights")]
[assembly: System.Reflection.AssemblyMetadata("RepositoryUrl", "https://github.com/Microsoft/ApplicationInsights-dotnet")]
[assembly: System.Reflection.AssemblyVersionAttribute("2.19.0.227")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace Microsoft.ApplicationInsights
{
    public sealed partial class Metric
    {
        public Metrics.MetricIdentifier Identifier { get { throw null; } }

        public int SeriesCount { get { throw null; } }

        public System.Collections.Generic.IReadOnlyList<System.Collections.Generic.KeyValuePair<string[], Metrics.MetricSeries>> GetAllSeries() { throw null; }

        public System.Collections.Generic.IReadOnlyCollection<string> GetDimensionValues(int dimensionNumber) { throw null; }

        public bool TrackValue(double metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value, string dimension7Value, string dimension8Value, string dimension9Value, string dimension10Value) { throw null; }

        public bool TrackValue(double metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value, string dimension7Value, string dimension8Value, string dimension9Value) { throw null; }

        public bool TrackValue(double metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value, string dimension7Value, string dimension8Value) { throw null; }

        public bool TrackValue(double metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value, string dimension7Value) { throw null; }

        public bool TrackValue(double metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value) { throw null; }

        public bool TrackValue(double metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value) { throw null; }

        public bool TrackValue(double metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value) { throw null; }

        public bool TrackValue(double metricValue, string dimension1Value, string dimension2Value, string dimension3Value) { throw null; }

        public bool TrackValue(double metricValue, string dimension1Value, string dimension2Value) { throw null; }

        public bool TrackValue(double metricValue, string dimension1Value) { throw null; }

        public void TrackValue(double metricValue) { }

        public bool TrackValue(object metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value, string dimension7Value, string dimension8Value, string dimension9Value, string dimension10Value) { throw null; }

        public bool TrackValue(object metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value, string dimension7Value, string dimension8Value, string dimension9Value) { throw null; }

        public bool TrackValue(object metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value, string dimension7Value, string dimension8Value) { throw null; }

        public bool TrackValue(object metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value, string dimension7Value) { throw null; }

        public bool TrackValue(object metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value) { throw null; }

        public bool TrackValue(object metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value) { throw null; }

        public bool TrackValue(object metricValue, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value) { throw null; }

        public bool TrackValue(object metricValue, string dimension1Value, string dimension2Value, string dimension3Value) { throw null; }

        public bool TrackValue(object metricValue, string dimension1Value, string dimension2Value) { throw null; }

        public bool TrackValue(object metricValue, string dimension1Value) { throw null; }

        public void TrackValue(object metricValue) { }

        public bool TryGetDataSeries(out Metrics.MetricSeries series, bool createIfNotExists, params string[] dimensionValues) { throw null; }

        public bool TryGetDataSeries(out Metrics.MetricSeries series, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value, string dimension7Value, string dimension8Value, string dimension9Value, string dimension10Value) { throw null; }

        public bool TryGetDataSeries(out Metrics.MetricSeries series, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value, string dimension7Value, string dimension8Value, string dimension9Value) { throw null; }

        public bool TryGetDataSeries(out Metrics.MetricSeries series, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value, string dimension7Value, string dimension8Value) { throw null; }

        public bool TryGetDataSeries(out Metrics.MetricSeries series, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value, string dimension7Value) { throw null; }

        public bool TryGetDataSeries(out Metrics.MetricSeries series, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value, string dimension6Value) { throw null; }

        public bool TryGetDataSeries(out Metrics.MetricSeries series, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value, string dimension5Value) { throw null; }

        public bool TryGetDataSeries(out Metrics.MetricSeries series, string dimension1Value, string dimension2Value, string dimension3Value, string dimension4Value) { throw null; }

        public bool TryGetDataSeries(out Metrics.MetricSeries series, string dimension1Value, string dimension2Value, string dimension3Value) { throw null; }

        public bool TryGetDataSeries(out Metrics.MetricSeries series, string dimension1Value, string dimension2Value) { throw null; }

        public bool TryGetDataSeries(out Metrics.MetricSeries series, string dimension1Value) { throw null; }

        public bool TryGetDataSeries(out Metrics.MetricSeries series) { throw null; }
    }

    public enum MetricAggregationScope
    {
        TelemetryConfiguration = 0,
        TelemetryClient = 1
    }

    public sealed partial class MetricConfigurations
    {
        public static readonly MetricConfigurations Common;
    }

    public static partial class MetricConfigurationsExtensions
    {
        public static Metrics.MetricConfigurationForMeasurement Measurement(this MetricConfigurations metricConfigPresets) { throw null; }

        public static void SetDefaultForMeasurement(this MetricConfigurations metricConfigPresets, Metrics.MetricConfigurationForMeasurement defaultConfigurationForMeasurement) { }
    }

    public static partial class MetricDimensionNames
    {
        public static partial class TelemetryContext
        {
            public const string InstrumentationKey = "TelemetryContext.InstrumentationKey";
            public static partial class Cloud
            {
                public const string RoleInstance = "TelemetryContext.Cloud.RoleInstance";
                public const string RoleName = "TelemetryContext.Cloud.RoleName";
            }

            public static partial class Component
            {
                public const string Version = "TelemetryContext.Component.Version";
            }

            public static partial class Device
            {
                public const string Id = "TelemetryContext.Device.Id";
                public const string Language = "TelemetryContext.Device.Language";
                public const string Model = "TelemetryContext.Device.Model";
                public const string NetworkType = "TelemetryContext.Device.NetworkType";
                public const string OemName = "TelemetryContext.Device.OemName";
                public const string OperatingSystem = "TelemetryContext.Device.OperatingSystem";
                public const string ScreenResolution = "TelemetryContext.Device.ScreenResolution";
                public const string Type = "TelemetryContext.Device.Type";
            }

            public static partial class Location
            {
                public const string Ip = "TelemetryContext.Location.Ip";
            }

            public static partial class Operation
            {
                public const string CorrelationVector = "TelemetryContext.Operation.CorrelationVector";
                public const string Id = "TelemetryContext.Operation.Id";
                public const string Name = "TelemetryContext.Operation.Name";
                public const string ParentId = "TelemetryContext.Operation.ParentId";
                public const string SyntheticSource = "TelemetryContext.Operation.SyntheticSource";
            }

            public static partial class Session
            {
                public const string Id = "TelemetryContext.Session.Id";
                public const string IsFirst = "TelemetryContext.Session.IsFirst";
            }

            public static partial class User
            {
                public const string AccountId = "TelemetryContext.User.AccountId";
                public const string AuthenticatedUserId = "TelemetryContext.User.AuthenticatedUserId";
                public const string Id = "TelemetryContext.User.Id";
                public const string UserAgent = "TelemetryContext.User.UserAgent";
            }
        }
    }

    public static partial class OperationTelemetryExtensions
    {
        public static void GenerateOperationId(this Extensibility.Implementation.OperationTelemetry telemetry) { }

        public static void Start(this Extensibility.Implementation.OperationTelemetry telemetry, long timestamp) { }

        public static void Start(this Extensibility.Implementation.OperationTelemetry telemetry) { }

        public static void Stop(this Extensibility.Implementation.OperationTelemetry telemetry, long timestamp) { }

        public static void Stop(this Extensibility.Implementation.OperationTelemetry telemetry) { }
    }

    public sealed partial class TelemetryClient
    {
        [System.Obsolete("We do not recommend using TelemetryConfiguration.Active on .NET Core. See https://github.com/microsoft/ApplicationInsights-dotnet/issues/1152 for more details")]
        public TelemetryClient() { }

        public TelemetryClient(Extensibility.TelemetryConfiguration configuration) { }

        public DataContracts.TelemetryContext Context { get { throw null; } }

        public string InstrumentationKey { get { throw null; } set { } }

        public Extensibility.TelemetryConfiguration TelemetryConfiguration { get { throw null; } }

        public void Flush() { }

        public System.Threading.Tasks.Task<bool> FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }

        public Metric GetMetric(Metrics.MetricIdentifier metricIdentifier, Metrics.MetricConfiguration metricConfiguration, MetricAggregationScope aggregationScope) { throw null; }

        public Metric GetMetric(Metrics.MetricIdentifier metricIdentifier, Metrics.MetricConfiguration metricConfiguration) { throw null; }

        public Metric GetMetric(Metrics.MetricIdentifier metricIdentifier) { throw null; }

        public Metric GetMetric(string metricId, Metrics.MetricConfiguration metricConfiguration, MetricAggregationScope aggregationScope) { throw null; }

        public Metric GetMetric(string metricId, Metrics.MetricConfiguration metricConfiguration) { throw null; }

        public Metric GetMetric(string metricId, string dimension1Name, Metrics.MetricConfiguration metricConfiguration, MetricAggregationScope aggregationScope) { throw null; }

        public Metric GetMetric(string metricId, string dimension1Name, Metrics.MetricConfiguration metricConfiguration) { throw null; }

        public Metric GetMetric(string metricId, string dimension1Name, string dimension2Name, Metrics.MetricConfiguration metricConfiguration, MetricAggregationScope aggregationScope) { throw null; }

        public Metric GetMetric(string metricId, string dimension1Name, string dimension2Name, Metrics.MetricConfiguration metricConfiguration) { throw null; }

        public Metric GetMetric(string metricId, string dimension1Name, string dimension2Name, string dimension3Name, Metrics.MetricConfiguration metricConfiguration, MetricAggregationScope aggregationScope) { throw null; }

        public Metric GetMetric(string metricId, string dimension1Name, string dimension2Name, string dimension3Name, Metrics.MetricConfiguration metricConfiguration) { throw null; }

        public Metric GetMetric(string metricId, string dimension1Name, string dimension2Name, string dimension3Name, string dimension4Name, Metrics.MetricConfiguration metricConfiguration, MetricAggregationScope aggregationScope) { throw null; }

        public Metric GetMetric(string metricId, string dimension1Name, string dimension2Name, string dimension3Name, string dimension4Name, Metrics.MetricConfiguration metricConfiguration) { throw null; }

        public Metric GetMetric(string metricId, string dimension1Name, string dimension2Name, string dimension3Name, string dimension4Name) { throw null; }

        public Metric GetMetric(string metricId, string dimension1Name, string dimension2Name, string dimension3Name) { throw null; }

        public Metric GetMetric(string metricId, string dimension1Name, string dimension2Name) { throw null; }

        public Metric GetMetric(string metricId, string dimension1Name) { throw null; }

        public Metric GetMetric(string metricId) { throw null; }

        public void Initialize(Channel.ITelemetry telemetry) { }

        public void InitializeInstrumentationKey(Channel.ITelemetry telemetry) { }

        public bool IsEnabled() { throw null; }

        public void Track(Channel.ITelemetry telemetry) { }

        public void TrackAvailability(DataContracts.AvailabilityTelemetry telemetry) { }

        public void TrackAvailability(string name, System.DateTimeOffset timeStamp, System.TimeSpan duration, string runLocation, bool success, string message = null, System.Collections.Generic.IDictionary<string, string> properties = null, System.Collections.Generic.IDictionary<string, double> metrics = null) { }

        public void TrackDependency(DataContracts.DependencyTelemetry telemetry) { }

        [System.Obsolete("Please use a different overload of TrackDependency")]
        public void TrackDependency(string dependencyName, string data, System.DateTimeOffset startTime, System.TimeSpan duration, bool success) { }

        public void TrackDependency(string dependencyTypeName, string dependencyName, string data, System.DateTimeOffset startTime, System.TimeSpan duration, bool success) { }

        public void TrackDependency(string dependencyTypeName, string target, string dependencyName, string data, System.DateTimeOffset startTime, System.TimeSpan duration, string resultCode, bool success) { }

        public void TrackEvent(DataContracts.EventTelemetry telemetry) { }

        public void TrackEvent(string eventName, System.Collections.Generic.IDictionary<string, string> properties = null, System.Collections.Generic.IDictionary<string, double> metrics = null) { }

        public void TrackException(DataContracts.ExceptionTelemetry telemetry) { }

        public void TrackException(System.Exception exception, System.Collections.Generic.IDictionary<string, string> properties = null, System.Collections.Generic.IDictionary<string, double> metrics = null) { }

        public void TrackMetric(DataContracts.MetricTelemetry telemetry) { }

        public void TrackMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> properties = null) { }

        public void TrackPageView(DataContracts.PageViewTelemetry telemetry) { }

        public void TrackPageView(string name) { }

        public void TrackRequest(DataContracts.RequestTelemetry request) { }

        public void TrackRequest(string name, System.DateTimeOffset startTime, System.TimeSpan duration, string responseCode, bool success) { }

        public void TrackTrace(DataContracts.TraceTelemetry telemetry) { }

        public void TrackTrace(string message, DataContracts.SeverityLevel severityLevel, System.Collections.Generic.IDictionary<string, string> properties) { }

        public void TrackTrace(string message, DataContracts.SeverityLevel severityLevel) { }

        public void TrackTrace(string message, System.Collections.Generic.IDictionary<string, string> properties) { }

        public void TrackTrace(string message) { }
    }

    public static partial class TelemetryClientExtensions
    {
        public static Extensibility.IOperationHolder<T> StartOperation<T>(this TelemetryClient telemetryClient, T operationTelemetry)
            where T : Extensibility.Implementation.OperationTelemetry { throw null; }

        public static Extensibility.IOperationHolder<T> StartOperation<T>(this TelemetryClient telemetryClient, System.Diagnostics.Activity activity)
            where T : Extensibility.Implementation.OperationTelemetry, new() { throw null; }

        public static Extensibility.IOperationHolder<T> StartOperation<T>(this TelemetryClient telemetryClient, string operationName, string operationId, string parentOperationId = null)
            where T : Extensibility.Implementation.OperationTelemetry, new() { throw null; }

        public static Extensibility.IOperationHolder<T> StartOperation<T>(this TelemetryClient telemetryClient, string operationName)
            where T : Extensibility.Implementation.OperationTelemetry, new() { throw null; }

        public static void StopOperation<T>(this TelemetryClient telemetryClient, Extensibility.IOperationHolder<T> operation)
            where T : Extensibility.Implementation.OperationTelemetry { }
    }
}

namespace Microsoft.ApplicationInsights.Channel
{
    public partial interface IAsyncFlushable : System.IDisposable
    {
        System.Threading.Tasks.Task<bool> FlushAsync(System.Threading.CancellationToken cancellationToken);
    }

    public partial class InMemoryChannel : ITelemetryChannel, System.IDisposable, IAsyncFlushable
    {
        public InMemoryChannel() { }

        public int BacklogSize { get { throw null; } set { } }

        public bool? DeveloperMode { get { throw null; } set { } }

        public string EndpointAddress { get { throw null; } set { } }

        public int MaxTelemetryBufferCapacity { get { throw null; } set { } }

        public System.TimeSpan SendingInterval { get { throw null; } set { } }

        public void Dispose() { }

        protected virtual void Dispose(bool disposing) { }

        public void Flush() { }

        public void Flush(System.TimeSpan timeout) { }

        public System.Threading.Tasks.Task<bool> FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }

        public void Send(ITelemetry item) { }
    }

    public partial interface ITelemetry
    {
        DataContracts.TelemetryContext Context { get; }

        Extensibility.IExtension Extension { get; set; }

        string Sequence { get; set; }

        System.DateTimeOffset Timestamp { get; set; }

        ITelemetry DeepClone();
        void Sanitize();
        void SerializeData(Extensibility.ISerializationWriter serializationWriter);
    }

    public partial interface ITelemetryChannel : System.IDisposable
    {
        bool? DeveloperMode { get; set; }

        string EndpointAddress { get; set; }

        void Flush();
        void Send(ITelemetry item);
    }

    public static partial class SamplingScoreGenerator
    {
        public static double GetSamplingScore(ITelemetry telemetry) { throw null; }

        public static double GetSamplingScore(string value) { throw null; }
    }

    public partial class Transmission
    {
        protected internal Transmission() { }

        public Transmission(System.Uri address, byte[] content, string contentType, string contentEncoding, System.TimeSpan timeout = default) { }

        public Transmission(System.Uri address, System.Collections.Generic.ICollection<ITelemetry> telemetryItems, System.TimeSpan timeout = default) { }

        public byte[] Content { get { throw null; } }

        public string ContentEncoding { get { throw null; } }

        public string ContentType { get { throw null; } }

        public System.Uri EndpointAddress { get { throw null; } }

        public string Id { get { throw null; } }

        public System.Collections.Generic.ICollection<ITelemetry> TelemetryItems { get { throw null; } }

        public System.TimeSpan Timeout { get { throw null; } }

        public System.EventHandler<TransmissionStatusEventArgs> TransmissionStatusEvent { get { throw null; } set { } }

        [System.Obsolete("Use CreateRequestMessage instead as SendAsync is now using HttpClient to send HttpRequest.")]
        protected virtual System.Net.WebRequest CreateRequest(System.Uri address) { throw null; }

        protected virtual System.Net.Http.HttpRequestMessage CreateRequestMessage(System.Uri address, System.IO.Stream contentStream) { throw null; }

        public virtual System.Threading.Tasks.Task<Extensibility.Implementation.HttpWebResponseWrapper> SendAsync() { throw null; }

        public virtual System.Tuple<Transmission, Transmission> Split(System.Func<int, int> calculateLength) { throw null; }
    }

    public partial class TransmissionStatusEventArgs : System.EventArgs
    {
        public TransmissionStatusEventArgs(Extensibility.Implementation.HttpWebResponseWrapper response, long responseDurationInMs) { }

        [System.Obsolete("This constructor is deprecated. Please use a constructor that accepts response and responseDurationInMs instead.", false)]
        public TransmissionStatusEventArgs(Extensibility.Implementation.HttpWebResponseWrapper response) { }

        public Extensibility.Implementation.HttpWebResponseWrapper Response { get { throw null; } }

        public long ResponseDurationInMs { get { throw null; } }
    }
}

namespace Microsoft.ApplicationInsights.DataContracts
{
    public sealed partial class AvailabilityTelemetry : Channel.ITelemetry, ISupportProperties, ISupportMetrics
    {
        public AvailabilityTelemetry() { }

        public AvailabilityTelemetry(string name, System.DateTimeOffset timeStamp, System.TimeSpan duration, string runLocation, bool success, string message = null) { }

        public TelemetryContext Context { get { throw null; } }

        public System.TimeSpan Duration { get { throw null; } set { } }

        public Extensibility.IExtension Extension { get { throw null; } set { } }

        public string Id { get { throw null; } set { } }

        public string Message { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, double> Metrics { get { throw null; } }

        public string Name { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }

        public string RunLocation { get { throw null; } set { } }

        public string Sequence { get { throw null; } set { } }

        public bool Success { get { throw null; } set { } }

        public System.DateTimeOffset Timestamp { get { throw null; } set { } }

        public Channel.ITelemetry DeepClone() { throw null; }

        void Channel.ITelemetry.Sanitize() { }

        public void SerializeData(Extensibility.ISerializationWriter serializationWriter) { }
    }

    public sealed partial class DependencyTelemetry : Extensibility.Implementation.OperationTelemetry, Channel.ITelemetry, ISupportProperties, ISupportAdvancedSampling, ISupportSampling, ISupportMetrics
    {
        public DependencyTelemetry() { }

        [System.Obsolete("Use other constructors which allows to define dependency call with all the properties.")]
        public DependencyTelemetry(string dependencyName, string data, System.DateTimeOffset startTime, System.TimeSpan duration, bool success) { }

        public DependencyTelemetry(string dependencyTypeName, string target, string dependencyName, string data, System.DateTimeOffset startTime, System.TimeSpan duration, string resultCode, bool success) { }

        public DependencyTelemetry(string dependencyTypeName, string target, string dependencyName, string data) { }

        [System.Obsolete("Renamed to Data")]
        public string CommandName { get { throw null; } set { } }

        public override TelemetryContext Context { get { throw null; } }

        public string Data { get { throw null; } set { } }

        [System.Obsolete("Use Type")]
        public string DependencyKind { get { throw null; } set { } }

        [System.Obsolete("Renamed to Type")]
        public string DependencyTypeName { get { throw null; } set { } }

        public override System.TimeSpan Duration { get { throw null; } set { } }

        public override Extensibility.IExtension Extension { get { throw null; } set { } }

        public override string Id { get { throw null; } set { } }

        public SamplingTelemetryItemTypes ItemTypeFlag { get { throw null; } }

        public override System.Collections.Generic.IDictionary<string, double> Metrics { get { throw null; } }

        double? ISupportSampling.SamplingPercentage { get { throw null; } set { } }

        public override string Name { get { throw null; } set { } }

        public SamplingDecision ProactiveSamplingDecision { get { throw null; } set { } }

        public override System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }

        public string ResultCode { get { throw null; } set { } }

        public override string Sequence { get { throw null; } set { } }

        public override bool? Success { get { throw null; } set { } }

        public string Target { get { throw null; } set { } }

        public override System.DateTimeOffset Timestamp { get { throw null; } set { } }

        public string Type { get { throw null; } set { } }

        public override Channel.ITelemetry DeepClone() { throw null; }

        new void Channel.ITelemetry.Sanitize() { }

        public override void SerializeData(Extensibility.ISerializationWriter serializationWriter) { }

        public void SetOperationDetail(string key, object detail) { }

        public bool TryGetOperationDetail(string key, out object detail) { throw null; }
    }

    public sealed partial class EventTelemetry : Channel.ITelemetry, ISupportProperties, ISupportAdvancedSampling, ISupportSampling, ISupportMetrics
    {
        public EventTelemetry() { }

        public EventTelemetry(string name) { }

        public TelemetryContext Context { get { throw null; } }

        public Extensibility.IExtension Extension { get { throw null; } set { } }

        public SamplingTelemetryItemTypes ItemTypeFlag { get { throw null; } }

        public System.Collections.Generic.IDictionary<string, double> Metrics { get { throw null; } }

        double? ISupportSampling.SamplingPercentage { get { throw null; } set { } }

        public string Name { get { throw null; } set { } }

        public SamplingDecision ProactiveSamplingDecision { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }

        public string Sequence { get { throw null; } set { } }

        public System.DateTimeOffset Timestamp { get { throw null; } set { } }

        public Channel.ITelemetry DeepClone() { throw null; }

        void Channel.ITelemetry.Sanitize() { }

        public void SerializeData(Extensibility.ISerializationWriter serializationWriter) { }
    }

    public sealed partial class ExceptionDetailsInfo
    {
        public ExceptionDetailsInfo(int id, int outerId, string typeName, string message, bool hasFullStack, string stack, System.Collections.Generic.IEnumerable<StackFrame> parsedStack) { }

        public string Message { get { throw null; } set { } }

        public string TypeName { get { throw null; } set { } }
    }

    [System.Obsolete("Use custom properties to report exception handling layer")]
    public enum ExceptionHandledAt
    {
        Unhandled = 0,
        UserCode = 1,
        Platform = 2
    }

    public sealed partial class ExceptionTelemetry : Channel.ITelemetry, ISupportProperties, ISupportAdvancedSampling, ISupportSampling, ISupportMetrics
    {
        public ExceptionTelemetry() { }

        public ExceptionTelemetry(System.Collections.Generic.IEnumerable<ExceptionDetailsInfo> exceptionDetailsInfoList, SeverityLevel? severityLevel, string problemId, System.Collections.Generic.IDictionary<string, string> properties, System.Collections.Generic.IDictionary<string, double> measurements) { }

        public ExceptionTelemetry(System.Exception exception) { }

        public TelemetryContext Context { get { throw null; } }

        public System.Exception Exception { get { throw null; } set { } }

        public System.Collections.Generic.IReadOnlyList<ExceptionDetailsInfo> ExceptionDetailsInfoList { get { throw null; } }

        public Extensibility.IExtension Extension { get { throw null; } set { } }

        [System.Obsolete("Use custom properties to report exception handling layer")]
        public ExceptionHandledAt HandledAt { get { throw null; } set { } }

        public SamplingTelemetryItemTypes ItemTypeFlag { get { throw null; } }

        public string Message { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, double> Metrics { get { throw null; } }

        double? ISupportSampling.SamplingPercentage { get { throw null; } set { } }

        public SamplingDecision ProactiveSamplingDecision { get { throw null; } set { } }

        public string ProblemId { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }

        public string Sequence { get { throw null; } set { } }

        public SeverityLevel? SeverityLevel { get { throw null; } set { } }

        public System.DateTimeOffset Timestamp { get { throw null; } set { } }

        public Channel.ITelemetry DeepClone() { throw null; }

        void Channel.ITelemetry.Sanitize() { }

        public void SerializeData(Extensibility.ISerializationWriter serializationWriter) { }

        public void SetParsedStack(System.Diagnostics.StackFrame[] frames) { }
    }

    public partial interface IJsonWriter
    {
        void WriteComma();
        void WriteEndArray();
        void WriteEndObject();
        void WriteProperty(string name, System.Collections.Generic.IDictionary<string, double> values);
        void WriteProperty(string name, System.Collections.Generic.IDictionary<string, string> values);
        void WriteProperty(string name, bool? value);
        void WriteProperty(string name, System.DateTimeOffset? value);
        void WriteProperty(string name, double? value);
        void WriteProperty(string name, int? value);
        void WriteProperty(string name, System.TimeSpan? value);
        void WriteProperty(string name, string value);
        void WritePropertyName(string name);
        void WriteRawValue(object value);
        void WriteStartArray();
        void WriteStartObject();
    }

    public partial interface ISupportAdvancedSampling : ISupportSampling
    {
        SamplingTelemetryItemTypes ItemTypeFlag { get; }

        SamplingDecision ProactiveSamplingDecision { get; set; }
    }

    public partial interface ISupportMetrics
    {
        System.Collections.Generic.IDictionary<string, double> Metrics { get; }
    }

    public partial interface ISupportProperties
    {
        System.Collections.Generic.IDictionary<string, string> Properties { get; }
    }

    public partial interface ISupportSampling
    {
        double? SamplingPercentage { get; set; }
    }

    public sealed partial class MetricTelemetry : Channel.ITelemetry, ISupportProperties
    {
        public MetricTelemetry() { }

        public MetricTelemetry(string metricName, double metricValue) { }

        public MetricTelemetry(string name, int count, double sum, double min, double max, double standardDeviation) { }

        public MetricTelemetry(string metricNamespace, string name, int count, double sum, double min, double max, double standardDeviation) { }

        public TelemetryContext Context { get { throw null; } }

        public int? Count { get { throw null; } set { } }

        public Extensibility.IExtension Extension { get { throw null; } set { } }

        public double? Max { get { throw null; } set { } }

        public string MetricNamespace { get { throw null; } set { } }

        public double? Min { get { throw null; } set { } }

        public string Name { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }

        public string Sequence { get { throw null; } set { } }

        public double? StandardDeviation { get { throw null; } set { } }

        public double Sum { get { throw null; } set { } }

        public System.DateTimeOffset Timestamp { get { throw null; } set { } }

        [System.Obsolete("This property is obsolete. Use Sum property instead.")]
        public double Value { get { throw null; } set { } }

        public Channel.ITelemetry DeepClone() { throw null; }

        void Channel.ITelemetry.Sanitize() { }

        public void SerializeData(Extensibility.ISerializationWriter serializationWriter) { }
    }

    public sealed partial class PageViewPerformanceTelemetry : Channel.ITelemetry, ISupportProperties, ISupportAdvancedSampling, ISupportSampling
    {
        public PageViewPerformanceTelemetry() { }

        public PageViewPerformanceTelemetry(string pageName) { }

        public TelemetryContext Context { get { throw null; } }

        public System.TimeSpan DomProcessing { get { throw null; } set { } }

        public System.TimeSpan Duration { get { throw null; } set { } }

        public Extensibility.IExtension Extension { get { throw null; } set { } }

        public string Id { get { throw null; } set { } }

        public SamplingTelemetryItemTypes ItemTypeFlag { get { throw null; } }

        public System.Collections.Generic.IDictionary<string, double> Metrics { get { throw null; } }

        double? ISupportSampling.SamplingPercentage { get { throw null; } set { } }

        public string Name { get { throw null; } set { } }

        public System.TimeSpan NetworkConnect { get { throw null; } set { } }

        public System.TimeSpan PerfTotal { get { throw null; } set { } }

        public SamplingDecision ProactiveSamplingDecision { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }

        public System.TimeSpan ReceivedResponse { get { throw null; } set { } }

        public System.TimeSpan SentRequest { get { throw null; } set { } }

        public string Sequence { get { throw null; } set { } }

        public System.DateTimeOffset Timestamp { get { throw null; } set { } }

        public System.Uri Url { get { throw null; } set { } }

        public Channel.ITelemetry DeepClone() { throw null; }

        void Channel.ITelemetry.Sanitize() { }

        public void SerializeData(Extensibility.ISerializationWriter serializationWriter) { }
    }

    public sealed partial class PageViewTelemetry : Channel.ITelemetry, ISupportProperties, ISupportAdvancedSampling, ISupportSampling, ISupportMetrics
    {
        public PageViewTelemetry() { }

        public PageViewTelemetry(string pageName) { }

        public TelemetryContext Context { get { throw null; } }

        public System.TimeSpan Duration { get { throw null; } set { } }

        public Extensibility.IExtension Extension { get { throw null; } set { } }

        public string Id { get { throw null; } set { } }

        public SamplingTelemetryItemTypes ItemTypeFlag { get { throw null; } }

        public System.Collections.Generic.IDictionary<string, double> Metrics { get { throw null; } }

        double? ISupportSampling.SamplingPercentage { get { throw null; } set { } }

        public string Name { get { throw null; } set { } }

        public SamplingDecision ProactiveSamplingDecision { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }

        public string Sequence { get { throw null; } set { } }

        public System.DateTimeOffset Timestamp { get { throw null; } set { } }

        public System.Uri Url { get { throw null; } set { } }

        public Channel.ITelemetry DeepClone() { throw null; }

        void Channel.ITelemetry.Sanitize() { }

        public void SerializeData(Extensibility.ISerializationWriter serializationWriter) { }
    }

    [System.Obsolete("Use MetricTelemetry instead.")]
    public sealed partial class PerformanceCounterTelemetry : Channel.ITelemetry, ISupportProperties
    {
        public PerformanceCounterTelemetry() { }

        public PerformanceCounterTelemetry(string categoryName, string counterName, string instanceName, double value) { }

        public string CategoryName { get { throw null; } set { } }

        public TelemetryContext Context { get { throw null; } }

        public string CounterName { get { throw null; } set { } }

        public Extensibility.IExtension Extension { get { throw null; } set { } }

        public string InstanceName { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }

        public string Sequence { get { throw null; } set { } }

        public System.DateTimeOffset Timestamp { get { throw null; } set { } }

        public double Value { get { throw null; } set { } }

        public Channel.ITelemetry DeepClone() { throw null; }

        void Channel.ITelemetry.Sanitize() { }

        public void SerializeData(Extensibility.ISerializationWriter serializationWriter) { }
    }

    public sealed partial class RequestTelemetry : Extensibility.Implementation.OperationTelemetry, Channel.ITelemetry, ISupportProperties, ISupportMetrics, ISupportAdvancedSampling, ISupportSampling
    {
        public RequestTelemetry() { }

        public RequestTelemetry(string name, System.DateTimeOffset startTime, System.TimeSpan duration, string responseCode, bool success) { }

        public override TelemetryContext Context { get { throw null; } }

        public override System.TimeSpan Duration { get { throw null; } set { } }

        public override Extensibility.IExtension Extension { get { throw null; } set { } }

        [System.Obsolete("Include http verb into request telemetry name and use custom properties to report http method as a dimension.")]
        public string HttpMethod { get { throw null; } set { } }

        public override string Id { get { throw null; } set { } }

        public SamplingTelemetryItemTypes ItemTypeFlag { get { throw null; } }

        public override System.Collections.Generic.IDictionary<string, double> Metrics { get { throw null; } }

        double? ISupportSampling.SamplingPercentage { get { throw null; } set { } }

        public override string Name { get { throw null; } set { } }

        public SamplingDecision ProactiveSamplingDecision { get { throw null; } set { } }

        public override System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }

        public string ResponseCode { get { throw null; } set { } }

        public override string Sequence { get { throw null; } set { } }

        public string Source { get { throw null; } set { } }

        public override bool? Success { get { throw null; } set { } }

        public override System.DateTimeOffset Timestamp { get { throw null; } set { } }

        public System.Uri Url { get { throw null; } set { } }

        public override Channel.ITelemetry DeepClone() { throw null; }

        new void Channel.ITelemetry.Sanitize() { }

        public override void SerializeData(Extensibility.ISerializationWriter serializationWriter) { }
    }

    public enum SamplingDecision
    {
        None = 0,
        SampledIn = 1,
        SampledOut = 2
    }

    [System.Flags]
    public enum SamplingTelemetryItemTypes
    {
        None = 0,
        Event = 1,
        Exception = 2,
        Message = 4,
        Metric = 8,
        PageView = 16,
        PageViewPerformance = 32,
        PerformanceCounter = 64,
        RemoteDependency = 128,
        Request = 256,
        SessionState = 512,
        Availability = 1024
    }

    [System.Obsolete("Session state events are no longer used.")]
    public enum SessionState
    {
        Start = 0,
        End = 1
    }

    [System.Obsolete("Session state events are no longer used. This telemetry item will be sent as EventTelemetry.")]
    public sealed partial class SessionStateTelemetry : Channel.ITelemetry
    {
        public SessionStateTelemetry() { }

        public SessionStateTelemetry(SessionState state) { }

        public TelemetryContext Context { get { throw null; } }

        public Extensibility.IExtension Extension { get { throw null; } set { } }

        public string Sequence { get { throw null; } set { } }

        public SessionState State { get { throw null; } set { } }

        public System.DateTimeOffset Timestamp { get { throw null; } set { } }

        public Channel.ITelemetry DeepClone() { throw null; }

        void Channel.ITelemetry.Sanitize() { }

        public void SerializeData(Extensibility.ISerializationWriter serializationWriter) { }
    }

    public enum SeverityLevel
    {
        Verbose = 0,
        Information = 1,
        Warning = 2,
        Error = 3,
        Critical = 4
    }

    public sealed partial class StackFrame
    {
        public StackFrame(string assembly, string fileName, int level, int line, string method) { }
    }

    public sealed partial class TelemetryContext
    {
        public const long FlagDropIdentifiers = 2097152L;
        public TelemetryContext() { }

        public Extensibility.Implementation.CloudContext Cloud { get { throw null; } }

        public Extensibility.Implementation.ComponentContext Component { get { throw null; } }

        public Extensibility.Implementation.DeviceContext Device { get { throw null; } }

        public long Flags { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, string> GlobalProperties { get { throw null; } }

        public string InstrumentationKey { get { throw null; } set { } }

        public Extensibility.Implementation.LocationContext Location { get { throw null; } }

        public Extensibility.Implementation.OperationContext Operation { get { throw null; } }

        [System.Obsolete("Use GlobalProperties to set global level properties. For properties at item level, use ISupportProperties.Properties.")]
        public System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }

        public Extensibility.Implementation.SessionContext Session { get { throw null; } }

        public Extensibility.Implementation.UserContext User { get { throw null; } }

        public void StoreRawObject(string key, object rawObject, bool keepForInitializationOnly = true) { }

        public bool TryGetRawObject(string key, out object rawObject) { throw null; }
    }

    public sealed partial class TraceTelemetry : Channel.ITelemetry, ISupportProperties, ISupportAdvancedSampling, ISupportSampling
    {
        public TraceTelemetry() { }

        public TraceTelemetry(string message, SeverityLevel severityLevel) { }

        public TraceTelemetry(string message) { }

        public TelemetryContext Context { get { throw null; } }

        public Extensibility.IExtension Extension { get { throw null; } set { } }

        public SamplingTelemetryItemTypes ItemTypeFlag { get { throw null; } }

        public string Message { get { throw null; } set { } }

        double? ISupportSampling.SamplingPercentage { get { throw null; } set { } }

        public SamplingDecision ProactiveSamplingDecision { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }

        public string Sequence { get { throw null; } set { } }

        public SeverityLevel? SeverityLevel { get { throw null; } set { } }

        public System.DateTimeOffset Timestamp { get { throw null; } set { } }

        public Channel.ITelemetry DeepClone() { throw null; }

        void Channel.ITelemetry.Sanitize() { }

        public void SerializeData(Extensibility.ISerializationWriter serializationWriter) { }
    }
}

namespace Microsoft.ApplicationInsights.Extensibility
{
    public sealed partial class AutocollectedMetricsExtractor : ITelemetryProcessor, ITelemetryModule, System.IDisposable
    {
        public AutocollectedMetricsExtractor(ITelemetryProcessor nextProcessorInPipeline) { }

        public int MaxDependencyCloudRoleInstanceValuesToDiscover { get { throw null; } set { } }

        public int MaxDependencyCloudRoleNameValuesToDiscover { get { throw null; } set { } }

        public int MaxDependencyResultCodesToDiscover { get { throw null; } set { } }

        public int MaxDependencyTargetValuesToDiscover { get { throw null; } set { } }

        public int MaxDependencyTypesToDiscover { get { throw null; } set { } }

        public int MaxExceptionCloudRoleInstanceValuesToDiscover { get { throw null; } set { } }

        public int MaxExceptionCloudRoleNameValuesToDiscover { get { throw null; } set { } }

        public int MaxRequestCloudRoleInstanceValuesToDiscover { get { throw null; } set { } }

        public int MaxRequestCloudRoleNameValuesToDiscover { get { throw null; } set { } }

        public int MaxRequestResponseCodeValuesToDiscover { get { throw null; } set { } }

        public int MaxTraceCloudRoleInstanceValuesToDiscover { get { throw null; } set { } }

        public int MaxTraceCloudRoleNameValuesToDiscover { get { throw null; } set { } }

        public void Dispose() { }

        public void Initialize(TelemetryConfiguration configuration) { }

        public void Process(Channel.ITelemetry item) { }
    }

    public partial interface IApplicationIdProvider
    {
        bool TryGetApplicationId(string instrumentationKey, out string applicationId);
    }

    public partial interface IExtension : ISerializableWithWriter
    {
        IExtension DeepClone();
    }

    public partial interface IOperationHolder<T> : System.IDisposable
    {
        T Telemetry { get; }
    }

    public partial interface ISerializableWithWriter
    {
        void Serialize(ISerializationWriter serializationWriter);
    }

    public partial interface ISerializationWriter
    {
        void WriteEndObject();
        void WriteProperty(ISerializableWithWriter value);
        void WriteProperty(string name, ISerializableWithWriter value);
        void WriteProperty(string name, System.Collections.Generic.IDictionary<string, double> items);
        void WriteProperty(string name, System.Collections.Generic.IDictionary<string, string> items);
        void WriteProperty(string name, System.Collections.Generic.IList<ISerializableWithWriter> items);
        void WriteProperty(string name, System.Collections.Generic.IList<string> items);
        void WriteProperty(string name, bool? value);
        void WriteProperty(string name, System.DateTimeOffset? value);
        void WriteProperty(string name, double? value);
        void WriteProperty(string name, int? value);
        void WriteProperty(string name, System.TimeSpan? value);
        void WriteProperty(string name, string value);
        void WriteStartObject();
        void WriteStartObject(string name);
    }

    public partial interface ITelemetryInitializer
    {
        void Initialize(Channel.ITelemetry telemetry);
    }

    public partial interface ITelemetryModule
    {
        void Initialize(TelemetryConfiguration configuration);
    }

    public partial interface ITelemetryProcessor
    {
        void Process(Channel.ITelemetry item);
    }

    public partial class OperationCorrelationTelemetryInitializer : ITelemetryInitializer
    {
        public OperationCorrelationTelemetryInitializer() { }

        public void Initialize(Channel.ITelemetry telemetryItem) { }
    }

    public static partial class SdkInternalOperationsMonitor
    {
        public static void Enter() { }

        public static void Exit() { }

        public static bool IsEntered() { throw null; }
    }

    public sealed partial class SequencePropertyInitializer : ITelemetryInitializer
    {
        public SequencePropertyInitializer() { }

        public void Initialize(Channel.ITelemetry telemetry) { }
    }

    public sealed partial class TelemetryConfiguration : System.IDisposable
    {
        public TelemetryConfiguration() { }

        public TelemetryConfiguration(string instrumentationKey, Channel.ITelemetryChannel channel) { }

        public TelemetryConfiguration(string instrumentationKey) { }

        [System.Obsolete("We do not recommend using TelemetryConfiguration.Active on .NET Core. See https://github.com/microsoft/ApplicationInsights-dotnet/issues/1152 for more details")]
        public static TelemetryConfiguration Active { get { throw null; } }

        public IApplicationIdProvider ApplicationIdProvider { get { throw null; } set { } }

        public string ConnectionString { get { throw null; } set { } }

        public TelemetrySink DefaultTelemetrySink { get { throw null; } }

        public bool DisableTelemetry { get { throw null; } set { } }

        public Implementation.Endpoints.EndpointContainer EndpointContainer { get { throw null; } }

        public System.Collections.Generic.IList<string> ExperimentalFeatures { get { throw null; } }

        public string InstrumentationKey { get { throw null; } set { } }

        public Channel.ITelemetryChannel TelemetryChannel { get { throw null; } set { } }

        public System.Collections.Generic.IList<ITelemetryInitializer> TelemetryInitializers { get { throw null; } }

        public Implementation.TelemetryProcessorChainBuilder TelemetryProcessorChainBuilder { get { throw null; } }

        public System.Collections.ObjectModel.ReadOnlyCollection<ITelemetryProcessor> TelemetryProcessors { get { throw null; } }

        public System.Collections.Generic.IList<TelemetrySink> TelemetrySinks { get { throw null; } }

        public static TelemetryConfiguration CreateDefault() { throw null; }

        public static TelemetryConfiguration CreateFromConfiguration(string config) { throw null; }

        public void Dispose() { }

        public void SetAzureTokenCredential(object tokenCredential) { }
    }

    public sealed partial class TelemetrySink : System.IDisposable, ITelemetryModule
    {
        public static readonly string DefaultSinkName;
        public TelemetrySink() { }

        public TelemetrySink(TelemetryConfiguration telemetryConfiguration, Channel.ITelemetryChannel telemetryChannel = null) { }

        public string Name { get { throw null; } set { } }

        public Channel.ITelemetryChannel TelemetryChannel { get { throw null; } set { } }

        public Implementation.TelemetryProcessorChainBuilder TelemetryProcessorChainBuilder { get { throw null; } set { } }

        public System.Collections.ObjectModel.ReadOnlyCollection<ITelemetryProcessor> TelemetryProcessors { get { throw null; } }

        public void Dispose() { }

        public void Initialize(TelemetryConfiguration configuration) { }

        public void Process(Channel.ITelemetry item) { }
    }
}

namespace Microsoft.ApplicationInsights.Extensibility.Implementation
{
    public sealed partial class CloudContext
    {
        public string RoleInstance { get { throw null; } set { } }

        public string RoleName { get { throw null; } set { } }
    }

    public sealed partial class ComponentContext
    {
        public string Version { get { throw null; } set { } }
    }

    public sealed partial class DeviceContext
    {
        public string Id { get { throw null; } set { } }

        [System.Obsolete("Use custom properties.")]
        public string Language { get { throw null; } set { } }

        public string Model { get { throw null; } set { } }

        [System.Obsolete("Use custom properties.")]
        public string NetworkType { get { throw null; } set { } }

        public string OemName { get { throw null; } set { } }

        public string OperatingSystem { get { throw null; } set { } }

        [System.Obsolete("Use custom properties.")]
        public string ScreenResolution { get { throw null; } set { } }

        public string Type { get { throw null; } set { } }
    }

    public partial class HttpWebResponseWrapper
    {
        public HttpWebResponseWrapper() { }

        public string Content { get { throw null; } set { } }

        public string RetryAfterHeader { get { throw null; } set { } }

        public int StatusCode { get { throw null; } set { } }

        public string StatusDescription { get { throw null; } set { } }
    }

    public sealed partial class InternalContext
    {
        public string AgentVersion { get { throw null; } set { } }

        public string NodeName { get { throw null; } set { } }

        public string SdkVersion { get { throw null; } set { } }
    }

    public static partial class JsonSerializer
    {
        public static string CompressionType { get { throw null; } }

        public static string ContentType { get { throw null; } }

        public static byte[] ConvertToByteArray(string telemetryItems, bool compress = true) { throw null; }

        public static string Deserialize(byte[] telemetryItemsData, bool compress = true) { throw null; }

        public static byte[] Serialize(System.Collections.Generic.IEnumerable<Channel.ITelemetry> telemetryItems, bool compress = true) { throw null; }
    }

    public sealed partial class LocationContext
    {
        public string Ip { get { throw null; } set { } }
    }

    public sealed partial class OperationContext
    {
        public string CorrelationVector { get { throw null; } set { } }

        public string Id { get { throw null; } set { } }

        public string Name { get { throw null; } set { } }

        public string ParentId { get { throw null; } set { } }

        public string SyntheticSource { get { throw null; } set { } }
    }

    public abstract partial class OperationTelemetry : Channel.ITelemetry, DataContracts.ISupportMetrics, DataContracts.ISupportProperties
    {
        protected OperationTelemetry() { }

        public abstract DataContracts.TelemetryContext Context { get; }
        public abstract System.TimeSpan Duration { get; set; }
        public abstract IExtension Extension { get; set; }
        public abstract string Id { get; set; }
        public abstract System.Collections.Generic.IDictionary<string, double> Metrics { get; }
        public abstract string Name { get; set; }
        public abstract System.Collections.Generic.IDictionary<string, string> Properties { get; }
        public abstract string Sequence { get; set; }

        [System.Obsolete("Use Timestamp")]
        public System.DateTimeOffset StartTime { get { throw null; } set { } }

        public abstract bool? Success { get; set; }
        public abstract System.DateTimeOffset Timestamp { get; set; }

        public abstract Channel.ITelemetry DeepClone();
        void Channel.ITelemetry.Sanitize() { }

        protected void Sanitize() { }

        public abstract void SerializeData(ISerializationWriter serializationWriter);
    }

    public sealed partial class SessionContext
    {
        public string Id { get { throw null; } set { } }

        public bool? IsFirst { get { throw null; } set { } }
    }

    [System.Obsolete("This class will be removed in the next major version. Application Insights base library wouldn't provide this functionality any longer.")]
    public partial class TaskTimer : System.IDisposable
    {
        public static readonly System.TimeSpan InfiniteTimeSpan;
        public TaskTimer() { }

        public System.TimeSpan Delay { get { throw null; } set { } }

        public bool IsStarted { get { throw null; } }

        public void Cancel() { }

        public void Dispose() { }

        protected virtual void Dispose(bool disposing) { }

        public void Start(System.Func<System.Threading.Tasks.Task> elapsed) { }
    }

    public static partial class TelemetryConfigurationExtensions
    {
        public static double GetLastObservedSamplingPercentage(this TelemetryConfiguration configuration, DataContracts.SamplingTelemetryItemTypes samplingItemType) { throw null; }

        public static void SetLastObservedSamplingPercentage(this TelemetryConfiguration configuration, DataContracts.SamplingTelemetryItemTypes samplingItemType, double value) { }
    }

    public static partial class TelemetryContextExtensions
    {
        public static InternalContext GetInternalContext(this DataContracts.TelemetryContext context) { throw null; }
    }

    public partial class TelemetryDebugWriter
    {
        public TelemetryDebugWriter() { }

        public static bool IsTracingDisabled { get { throw null; } set { } }

        public static void WriteTelemetry(Channel.ITelemetry telemetry, string filteredBy = null) { }
    }

    public static partial class TelemetryExtensions
    {
        public static string GetEnvelopeName(this Channel.ITelemetry telemetry) { throw null; }

        public static bool TrySetEnvelopeName(this Channel.ITelemetry telemetry, string envelopeName) { throw null; }
    }

    public partial class TelemetryModules
    {
        protected TelemetryModules() { }

        public static TelemetryModules Instance { get { throw null; } }

        public System.Collections.Generic.IList<ITelemetryModule> Modules { get { throw null; } }
    }

    public sealed partial class TelemetryProcessorChain : System.IDisposable
    {
        public void Dispose() { }

        public void Process(Channel.ITelemetry item) { }
    }

    public sealed partial class TelemetryProcessorChainBuilder
    {
        public TelemetryProcessorChainBuilder(TelemetryConfiguration configuration, TelemetrySink telemetrySink) { }

        public TelemetryProcessorChainBuilder(TelemetryConfiguration configuration) { }

        public void Build() { }

        public TelemetryProcessorChainBuilder Use(System.Func<ITelemetryProcessor, ITelemetryProcessor> telemetryProcessorFactory) { throw null; }
    }

    public sealed partial class UserContext
    {
        public string AccountId { get { throw null; } set { } }

        public string AuthenticatedUserId { get { throw null; } set { } }

        public string Id { get { throw null; } set { } }

        public string UserAgent { get { throw null; } set { } }
    }
}

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.ApplicationId
{
    public sealed partial class ApplicationInsightsApplicationIdProvider : IApplicationIdProvider, System.IDisposable
    {
        public ApplicationInsightsApplicationIdProvider() { }

        public string ProfileQueryEndpoint { get { throw null; } set { } }

        public void Dispose() { }

        public bool TryGetApplicationId(string instrumentationKey, out string applicationId) { throw null; }
    }

    public partial class DictionaryApplicationIdProvider : IApplicationIdProvider
    {
        public DictionaryApplicationIdProvider() { }

        public System.Collections.Generic.IReadOnlyDictionary<string, string> Defined { get { throw null; } set { } }

        public IApplicationIdProvider Next { get { throw null; } set { } }

        public bool TryGetApplicationId(string instrumentationKey, out string applicationId) { throw null; }
    }
}

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Endpoints
{
    public partial class EndpointContainer
    {
        public System.Uri Ingestion { get { throw null; } }

        public System.Uri Live { get { throw null; } }

        public System.Uri Profiler { get { throw null; } }

        public System.Uri Snapshot { get { throw null; } }
    }
}

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Experimental
{
    public static partial class ExperimentalFeaturesExtension
    {
        public static bool EvaluateExperimentalFeature(this TelemetryConfiguration telemetryConfiguration, string featureName) { throw null; }
    }
}

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing
{
    public sealed partial class DiagnosticsTelemetryModule : ITelemetryModule, IHeartbeatPropertyManager, System.IDisposable
    {
        public DiagnosticsTelemetryModule() { }

        public string DiagnosticsInstrumentationKey { get { throw null; } set { } }

        public System.Collections.Generic.IList<string> ExcludedHeartbeatProperties { get { throw null; } }

        public System.Collections.Generic.IList<string> ExcludedHeartbeatPropertyProviders { get { throw null; } }

        public System.TimeSpan HeartbeatInterval { get { throw null; } set { } }

        public bool IsHeartbeatEnabled { get { throw null; } set { } }

        public string Severity { get { throw null; } set { } }

        public bool AddHeartbeatProperty(string propertyName, string propertyValue, bool isHealthy) { throw null; }

        public void Dispose() { }

        ~DiagnosticsTelemetryModule() {
        }

        public void Initialize(TelemetryConfiguration configuration) { }

        public bool SetHeartbeatProperty(string propertyName, string propertyValue = null, bool? isHealthy = null) { throw null; }
    }

    public static partial class Extensions
    {
        public static string ToInvariantString(this System.Exception exception) { throw null; }
    }

    public partial class FileDiagnosticsTelemetryModule : System.IDisposable, ITelemetryModule
    {
        public FileDiagnosticsTelemetryModule() { }

        public string LogFileName { get { throw null; } set { } }

        public string LogFilePath { get { throw null; } set { } }

        public string Severity { get { throw null; } set { } }

        public void Dispose() { }

        protected virtual void Dispose(bool disposeManaged = true) { }

        public void Initialize(TelemetryConfiguration configuration) { }
    }

    public partial interface IHeartbeatPropertyManager
    {
        System.Collections.Generic.IList<string> ExcludedHeartbeatProperties { get; }

        System.Collections.Generic.IList<string> ExcludedHeartbeatPropertyProviders { get; }

        System.TimeSpan HeartbeatInterval { get; set; }

        bool IsHeartbeatEnabled { get; set; }

        bool AddHeartbeatProperty(string propertyName, string propertyValue, bool isHealthy);
        bool SetHeartbeatProperty(string propertyName, string propertyValue = null, bool? isHealthy = null);
    }
}

namespace Microsoft.ApplicationInsights.Extensibility.W3C
{
    [System.Obsolete("Activity from System.Diagnostics.DiagnosticSource 4.6.0 onwards natively support W3C making extension methods in this class no longer required.")]
    public static partial class W3CActivityExtensions
    {
        [System.Obsolete("Activity from System.Diagnostics.DiagnosticSource 4.6.0 onwards natively support W3C.")]
        public static System.Diagnostics.Activity GenerateW3CContext(this System.Diagnostics.Activity activity) { throw null; }

        [System.Obsolete("Activity from System.Diagnostics.DiagnosticSource 4.6.0 onwards natively support W3C. Use Activity.ParentSpanId to get ParentSpan ID")]
        public static string GetParentSpanId(this System.Diagnostics.Activity activity) { throw null; }

        [System.Obsolete("Activity from System.Diagnostics.DiagnosticSource 4.6.0 onwards natively support W3C. Use Activity.SpanId to get Span ID")]
        public static string GetSpanId(this System.Diagnostics.Activity activity) { throw null; }

        [System.Obsolete("Activity from System.Diagnostics.DiagnosticSource 4.6.0 onwards natively support W3C. Use Activity.TraceId to get Trace ID")]
        public static string GetTraceId(this System.Diagnostics.Activity activity) { throw null; }

        [System.Obsolete("Activity from System.Diagnostics.DiagnosticSource 4.6.0 onwards natively support W3C.")]
        public static string GetTraceparent(this System.Diagnostics.Activity activity) { throw null; }

        [System.Obsolete("Activity from System.Diagnostics.DiagnosticSource 4.6.0 onwards natively support W3C.")]
        public static string GetTracestate(this System.Diagnostics.Activity activity) { throw null; }

        [System.Obsolete("Activity from System.Diagnostics.DiagnosticSource 4.6.0 onwards natively support W3C.")]
        public static bool IsW3CActivity(this System.Diagnostics.Activity activity) { throw null; }

        [System.Obsolete("Activity from System.Diagnostics.DiagnosticSource 4.6.0 onwards natively support W3C.")]
        public static void SetTraceparent(this System.Diagnostics.Activity activity, string value) { }

        [System.Obsolete("Activity from System.Diagnostics.DiagnosticSource 4.6.0 onwards natively support W3C.")]
        public static void SetTracestate(this System.Diagnostics.Activity activity, string value) { }

        [System.Obsolete("Activity from System.Diagnostics.DiagnosticSource 4.6.0 onwards natively support W3C.")]
        public static System.Diagnostics.Activity UpdateContextOnActivity(this System.Diagnostics.Activity activity) { throw null; }

        [System.Obsolete("Activity from System.Diagnostics.DiagnosticSource 4.6.0 onwards natively support W3C. OperationCorrelationTelemetryInitializer is W3C aware and is recommended to update telemetry from current Activity.")]
        public static void UpdateTelemetry(this System.Diagnostics.Activity activity, Channel.ITelemetry telemetry, bool forceUpdate) { }
    }

    [System.Obsolete("Obsolete in favor of OperationCorrelationTelemetryInitializer which is now W3C aware.")]
    public partial class W3COperationCorrelationTelemetryInitializer : ITelemetryInitializer
    {
        public W3COperationCorrelationTelemetryInitializer() { }

        public void Initialize(Channel.ITelemetry telemetry) { }
    }

    public static partial class W3CUtilities
    {
        [System.Obsolete("Use ActivityTraceId.CreateRandom().ToHexString() instead.")]
        public static string GenerateTraceId() { throw null; }
    }
}

namespace Microsoft.ApplicationInsights.Metrics
{
    public partial interface IMetricSeriesConfiguration : System.IEquatable<IMetricSeriesConfiguration>
    {
        bool RequiresPersistentAggregation { get; }

        Extensibility.IMetricSeriesAggregator CreateNewAggregator(MetricSeries dataSeries, Extensibility.MetricAggregationCycleKind aggregationCycleKind);
    }

    public partial class MetricAggregate
    {
        public MetricAggregate(string metricNamespace, string metricId, string aggregationKindMoniker) { }

        public string AggregationKindMoniker { get { throw null; } }

        public System.TimeSpan AggregationPeriodDuration { get { throw null; } set { } }

        public System.DateTimeOffset AggregationPeriodStart { get { throw null; } set { } }

        public System.Collections.Generic.IDictionary<string, object> Data { get { throw null; } }

        public System.Collections.Generic.IDictionary<string, string> Dimensions { get { throw null; } }

        public string MetricId { get { throw null; } }

        public string MetricNamespace { get { throw null; } }

        public T GetDataValue<T>(string dataKey, T defaultValue) { throw null; }
    }

    public partial class MetricConfiguration : System.IEquatable<MetricConfiguration>
    {
        public MetricConfiguration(int seriesCountLimit, System.Collections.Generic.IEnumerable<int> valuesPerDimensionLimits, IMetricSeriesConfiguration seriesConfig) { }

        public MetricConfiguration(int seriesCountLimit, int valuesPerDimensionLimit, IMetricSeriesConfiguration seriesConfig) { }

        public IMetricSeriesConfiguration SeriesConfig { get { throw null; } }

        public int SeriesCountLimit { get { throw null; } }

        public virtual bool Equals(MetricConfiguration other) { throw null; }

        public override bool Equals(object obj) { throw null; }

        public override int GetHashCode() { throw null; }

        public int GetValuesPerDimensionLimit(int dimensionNumber) { throw null; }
    }

    public sealed partial class MetricConfigurationForMeasurement : MetricConfiguration
    {
        public MetricConfigurationForMeasurement(int seriesCountLimit, System.Collections.Generic.IEnumerable<int> valuesPerDimensionLimits, MetricSeriesConfigurationForMeasurement seriesConfig) : base(default, default, default!) { }

        public MetricConfigurationForMeasurement(int seriesCountLimit, int valuesPerDimensionLimit, MetricSeriesConfigurationForMeasurement seriesConfig) : base(default, default, default!) { }
    }

    public sealed partial class MetricIdentifier : System.IEquatable<MetricIdentifier>
    {
        public const int MaxDimensionsCount = 10;
        public MetricIdentifier(string metricNamespace, string metricId, System.Collections.Generic.IList<string> dimensionNames) { }

        public MetricIdentifier(string metricNamespace, string metricId, string dimension1Name, string dimension2Name, string dimension3Name, string dimension4Name, string dimension5Name, string dimension6Name, string dimension7Name, string dimension8Name, string dimension9Name, string dimension10Name) { }

        public MetricIdentifier(string metricNamespace, string metricId, string dimension1Name, string dimension2Name, string dimension3Name, string dimension4Name, string dimension5Name, string dimension6Name, string dimension7Name, string dimension8Name, string dimension9Name) { }

        public MetricIdentifier(string metricNamespace, string metricId, string dimension1Name, string dimension2Name, string dimension3Name, string dimension4Name, string dimension5Name, string dimension6Name, string dimension7Name, string dimension8Name) { }

        public MetricIdentifier(string metricNamespace, string metricId, string dimension1Name, string dimension2Name, string dimension3Name, string dimension4Name, string dimension5Name, string dimension6Name, string dimension7Name) { }

        public MetricIdentifier(string metricNamespace, string metricId, string dimension1Name, string dimension2Name, string dimension3Name, string dimension4Name, string dimension5Name, string dimension6Name) { }

        public MetricIdentifier(string metricNamespace, string metricId, string dimension1Name, string dimension2Name, string dimension3Name, string dimension4Name, string dimension5Name) { }

        public MetricIdentifier(string metricNamespace, string metricId, string dimension1Name, string dimension2Name, string dimension3Name, string dimension4Name) { }

        public MetricIdentifier(string metricNamespace, string metricId, string dimension1Name, string dimension2Name, string dimension3Name) { }

        public MetricIdentifier(string metricNamespace, string metricId, string dimension1Name, string dimension2Name) { }

        public MetricIdentifier(string metricNamespace, string metricId, string dimension1Name) { }

        public MetricIdentifier(string metricNamespace, string metricId) { }

        public MetricIdentifier(string metricId) { }

        public static string DefaultMetricNamespace { get { throw null; } set { } }

        public int DimensionsCount { get { throw null; } }

        public string MetricId { get { throw null; } }

        public string MetricNamespace { get { throw null; } }

        public bool Equals(MetricIdentifier otherMetricIdentifier) { throw null; }

        public override bool Equals(object otherObj) { throw null; }

        public string GetDimensionName(int dimensionNumber) { throw null; }

        public System.Collections.Generic.IEnumerable<string> GetDimensionNames() { throw null; }

        public override int GetHashCode() { throw null; }

        public override string ToString() { throw null; }
    }

    public sealed partial class MetricManager
    {
        public MetricManager(Extensibility.IMetricTelemetryPipeline telemetryPipeline) { }

        public MetricsCollection Metrics { get { throw null; } }

        public MetricSeries CreateNewSeries(MetricIdentifier metricIdentifier, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> dimensionNamesAndValues, IMetricSeriesConfiguration config) { throw null; }

        public MetricSeries CreateNewSeries(string metricNamespace, string metricId, IMetricSeriesConfiguration config) { throw null; }

        public MetricSeries CreateNewSeries(string metricNamespace, string metricId, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> dimensionNamesAndValues, IMetricSeriesConfiguration config) { throw null; }

        ~MetricManager() {
        }

        public void Flush() { }
    }

    public sealed partial class MetricsCollection : System.Collections.Generic.ICollection<Metric>, System.Collections.Generic.IEnumerable<Metric>, System.Collections.IEnumerable
    {
        public int Count { get { throw null; } }

        public bool IsReadOnly { get { throw null; } }

        public void Clear() { }

        public bool Contains(Metric metric) { throw null; }

        public bool Contains(MetricIdentifier metricIdentifier) { throw null; }

        public void CopyTo(Metric[] array, int arrayIndex) { }

        public System.Collections.Generic.IEnumerator<Metric> GetEnumerator() { throw null; }

        public Metric GetOrCreate(MetricIdentifier metricIdentifier, MetricConfiguration metricConfiguration) { throw null; }

        public bool Remove(Metric metric) { throw null; }

        public bool Remove(MetricIdentifier metricIdentifier, out Metric removedMetric) { throw null; }

        public bool Remove(MetricIdentifier metricIdentifier) { throw null; }

        void System.Collections.Generic.ICollection<Metric>.Add(Metric unsupported) { }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }

        public bool TryGet(MetricIdentifier metricIdentifier, out Metric metric) { throw null; }
    }

    public sealed partial class MetricSeries
    {
        public System.Collections.Generic.IReadOnlyDictionary<string, string> DimensionNamesAndValues { get { throw null; } }

        public MetricIdentifier MetricIdentifier { get { throw null; } }

        public void TrackValue(double metricValue) { }

        public void TrackValue(object metricValue) { }
    }

    public partial class MetricSeriesConfigurationForMeasurement : IMetricSeriesConfiguration, System.IEquatable<IMetricSeriesConfiguration>
    {
        public MetricSeriesConfigurationForMeasurement(bool restrictToUInt32Values) { }

        public bool RequiresPersistentAggregation { get { throw null; } }

        public bool RestrictToUInt32Values { get { throw null; } }

        public Extensibility.IMetricSeriesAggregator CreateNewAggregator(MetricSeries dataSeries, Extensibility.MetricAggregationCycleKind aggregationCycleKind) { throw null; }

        public bool Equals(IMetricSeriesConfiguration other) { throw null; }

        public bool Equals(MetricSeriesConfigurationForMeasurement other) { throw null; }

        public override bool Equals(object obj) { throw null; }

        public override int GetHashCode() { throw null; }

        public sealed partial class AggregateKindConstants
        {
            public DataKeysConstants AggregateKindDataKeys { get { throw null; } }

            public string AggregateKindMoniker { get { throw null; } }

            public sealed partial class DataKeysConstants
            {
                public string Count { get { throw null; } }

                public string Max { get { throw null; } }

                public string Min { get { throw null; } }

                public string StdDev { get { throw null; } }

                public string Sum { get { throw null; } }
            }
        }
    }

    public static partial class TelemetryConfigurationExtensions
    {
        public static MetricManager GetMetricManager(this ApplicationInsights.Extensibility.TelemetryConfiguration telemetryPipeline) { throw null; }
    }
}

namespace Microsoft.ApplicationInsights.Metrics.Extensibility
{
    public partial interface IMetricSeriesAggregator
    {
        MetricSeries DataSeries { get; }

        MetricAggregate CompleteAggregation(System.DateTimeOffset periodEnd);
        MetricAggregate CreateAggregateUnsafe(System.DateTimeOffset periodEnd);
        void Reset(System.DateTimeOffset periodStart, IMetricValueFilter valueFilter);
        void Reset(System.DateTimeOffset periodStart);
        void TrackValue(double metricValue);
        void TrackValue(object metricValue);
        bool TryRecycle();
    }

    public partial interface IMetricTelemetryPipeline
    {
        System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancelToken);
        System.Threading.Tasks.Task TrackAsync(MetricAggregate metricAggregate, System.Threading.CancellationToken cancelToken);
    }

    public partial interface IMetricValueFilter
    {
        bool WillConsume(MetricSeries dataSeries, double metricValue);
        bool WillConsume(MetricSeries dataSeries, object metricValue);
    }

    public enum MetricAggregationCycleKind
    {
        Default = 0,
        QuickPulse = 1,
        Custom = 2
    }

    public static partial class MetricConfigurationExtensions
    {
        public static MetricSeriesConfigurationForMeasurement.AggregateKindConstants Constants(this MetricConfigurationForMeasurement measurementConfig) { throw null; }

        public static MetricSeriesConfigurationForMeasurement.AggregateKindConstants Constants(this MetricSeriesConfigurationForMeasurement measurementConfig) { throw null; }
    }

    public static partial class MetricExtensions
    {
        public static MetricConfiguration GetConfiguration(this Metric metric) { throw null; }
    }

    public static partial class MetricSeriesExtensions
    {
        public static IMetricSeriesConfiguration GetConfiguration(this MetricSeries metricSeries) { throw null; }
    }

    public static partial class TelemetryClientExtensions
    {
        public static MetricManager GetMetricManager(this TelemetryClient telemetryClient, MetricAggregationScope aggregationScope) { throw null; }
    }
}