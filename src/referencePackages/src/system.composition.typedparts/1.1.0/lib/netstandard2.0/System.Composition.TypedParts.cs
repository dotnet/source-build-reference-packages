// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Reflection.AssemblyTitle("System.Composition.TypedParts")]
[assembly: System.Reflection.AssemblyDescription("System.Composition.TypedParts")]
[assembly: System.Reflection.AssemblyDefaultAlias("System.Composition.TypedParts")]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyProduct("Microsoft® .NET Framework")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: System.Reflection.AssemblyFileVersion("4.6.25519.03")]
[assembly: System.Reflection.AssemblyInformationalVersion("4.6.25519.03 built by: dlab-DDVSOWINAGE013. Commit Hash: 8321c729934c0f8be754953439b88e6e1c120c24")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Reflection.AssemblyMetadata(".NETFrameworkAssembly", "")]
[assembly: System.Reflection.AssemblyMetadata("Serviceable", "True")]
[assembly: System.Reflection.AssemblyMetadata("PreferInbox", "True")]
[assembly: System.Reflection.AssemblyVersionAttribute("1.0.32.0")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace System.Composition
{
    public static partial class CompositionContextExtensions
    {
        public static void SatisfyImports(this CompositionContext compositionContext, object objectWithLooseImports, Convention.AttributedModelProvider conventions) { }

        public static void SatisfyImports(this CompositionContext compositionContext, object objectWithLooseImports) { }
    }
}

namespace System.Composition.Hosting
{
    public partial class ContainerConfiguration
    {
        public CompositionHost CreateContainer() { throw null; }

        public ContainerConfiguration WithAssemblies(Collections.Generic.IEnumerable<Reflection.Assembly> assemblies, Convention.AttributedModelProvider conventions) { throw null; }

        public ContainerConfiguration WithAssemblies(Collections.Generic.IEnumerable<Reflection.Assembly> assemblies) { throw null; }

        public ContainerConfiguration WithAssembly(Reflection.Assembly assembly, Convention.AttributedModelProvider conventions) { throw null; }

        public ContainerConfiguration WithAssembly(Reflection.Assembly assembly) { throw null; }

        public ContainerConfiguration WithDefaultConventions(Convention.AttributedModelProvider conventions) { throw null; }

        public ContainerConfiguration WithPart(Type partType, Convention.AttributedModelProvider conventions) { throw null; }

        public ContainerConfiguration WithPart(Type partType) { throw null; }

        public ContainerConfiguration WithPart<TPart>() { throw null; }

        public ContainerConfiguration WithPart<TPart>(Convention.AttributedModelProvider conventions) { throw null; }

        public ContainerConfiguration WithParts(Collections.Generic.IEnumerable<Type> partTypes, Convention.AttributedModelProvider conventions) { throw null; }

        public ContainerConfiguration WithParts(Collections.Generic.IEnumerable<Type> partTypes) { throw null; }

        public ContainerConfiguration WithParts(params Type[] partTypes) { throw null; }

        public ContainerConfiguration WithProvider(Core.ExportDescriptorProvider exportDescriptorProvider) { throw null; }
    }
}