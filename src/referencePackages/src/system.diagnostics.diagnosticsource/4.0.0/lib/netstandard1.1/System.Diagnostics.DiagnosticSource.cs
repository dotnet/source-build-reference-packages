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
[assembly: AssemblyTitle("System.Diagnostics.DiagnosticSource")]
[assembly: AssemblyDescription("System.Diagnostics.DiagnosticSource")]
[assembly: AssemblyDefaultAlias("System.Diagnostics.DiagnosticSource")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("1.0.24212.01")]
[assembly: AssemblyInformationalVersion("1.0.24212.01 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("4.0.0.0")]




namespace System.Diagnostics
{
    public partial class DiagnosticListener : System.Diagnostics.DiagnosticSource, System.IDisposable, System.IObservable<System.Collections.Generic.KeyValuePair<string, object>>
    {
        public DiagnosticListener(string name) { }
        public static System.IObservable<System.Diagnostics.DiagnosticListener> AllListeners { get { throw null; } }
        public string Name { get { throw null; } }
        public virtual void Dispose() { }
        public override bool IsEnabled(string name) { throw null; }
        public System.IDisposable Subscribe(System.IObserver<System.Collections.Generic.KeyValuePair<string, object>> observer) { throw null; }
        public virtual System.IDisposable Subscribe(System.IObserver<System.Collections.Generic.KeyValuePair<string, object>> observer, System.Predicate<string> isEnabled) { throw null; }
        public override string ToString() { throw null; }
        public override void Write(string name, object value) { }
    }
    public abstract partial class DiagnosticSource
    {
        protected DiagnosticSource() { }
        public abstract bool IsEnabled(string name);
        public abstract void Write(string name, object value);
    }
}
