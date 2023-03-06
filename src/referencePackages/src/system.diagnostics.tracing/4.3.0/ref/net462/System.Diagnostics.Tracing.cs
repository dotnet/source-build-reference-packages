// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Resources.NeutralResourcesLanguage("en-US")]
[assembly: System.Reflection.AssemblyTitle("System.Diagnostics.Tracing")]
[assembly: System.Reflection.AssemblyDescription("System.Diagnostics.Tracing")]
[assembly: System.Reflection.AssemblyDefaultAlias("System.Diagnostics.Tracing")]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyProduct("Microsoft® .NET Framework")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: System.Reflection.AssemblyFileVersion("4.6.24705.01")]
[assembly: System.Reflection.AssemblyInformationalVersion("4.6.24705.01. Commit Hash: 4d1af962ca0fede10beb01d197367c2f90e92c97")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Reflection.AssemblyMetadata(".NETFrameworkAssembly", "")]
[assembly: System.Reflection.AssemblyMetadata("Serviceable", "True")]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventActivityOptions))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventAttribute))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventChannel))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventCommand))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventCommandEventArgs))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventDataAttribute))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventFieldAttribute))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventFieldFormat))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventFieldTags))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventIgnoreAttribute))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventKeywords))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventLevel))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventListener))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventManifestOptions))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventOpcode))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventSource))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventSourceAttribute))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventSourceException))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventSourceOptions))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventSourceSettings))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventTags))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventTask))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.EventWrittenEventArgs))]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Diagnostics.Tracing.NonEventAttribute))]
namespace System.Diagnostics.Tracing
{
    public partial class EventCounter
    {
        public EventCounter(string name, EventSource eventSource) { }

        public void WriteMetric(float value) { }
    }
}