// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Reflection.AssemblyTitle("System.Reflection.TypeExtensions")]
[assembly: System.Reflection.AssemblyDescription("System.Reflection.TypeExtensions")]
[assembly: System.Reflection.AssemblyDefaultAlias("System.Reflection.TypeExtensions")]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyProduct("Microsoft® .NET Framework")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: System.Reflection.AssemblyFileVersion("4.6.23123.00")]
[assembly: System.Reflection.AssemblyInformationalVersion("4.6.23123.00 built by: PROJECTKREL")]
[assembly: System.Resources.NeutralResourcesLanguage("en-US")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Reflection.AssemblyMetadata(".NETFrameworkAssembly", "")]
[assembly: System.Reflection.AssemblyMetadata("Serviceable", "True")]
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Reflection.BindingFlags))]
namespace System.Reflection
{
    public static partial class AssemblyExtensions
    {
        public static Type[] GetExportedTypes(Assembly assembly) { throw null; }

        public static Module[] GetModules(Assembly assembly) { throw null; }

        public static Type[] GetTypes(Assembly assembly) { throw null; }
    }

    public static partial class EventInfoExtensions
    {
        public static MethodInfo GetAddMethod(EventInfo eventInfo, bool nonPublic) { throw null; }

        public static MethodInfo GetAddMethod(EventInfo eventInfo) { throw null; }

        public static MethodInfo GetRaiseMethod(EventInfo eventInfo, bool nonPublic) { throw null; }

        public static MethodInfo GetRaiseMethod(EventInfo eventInfo) { throw null; }

        public static MethodInfo GetRemoveMethod(EventInfo eventInfo, bool nonPublic) { throw null; }

        public static MethodInfo GetRemoveMethod(EventInfo eventInfo) { throw null; }
    }

    public static partial class MethodInfoExtensions
    {
        public static MethodInfo GetBaseDefinition(MethodInfo method) { throw null; }
    }

    public static partial class PropertyInfoExtensions
    {
        public static MethodInfo[] GetAccessors(PropertyInfo property, bool nonPublic) { throw null; }

        public static MethodInfo[] GetAccessors(PropertyInfo property) { throw null; }

        public static MethodInfo GetGetMethod(PropertyInfo property, bool nonPublic) { throw null; }

        public static MethodInfo GetGetMethod(PropertyInfo property) { throw null; }

        public static MethodInfo GetSetMethod(PropertyInfo property, bool nonPublic) { throw null; }

        public static MethodInfo GetSetMethod(PropertyInfo property) { throw null; }
    }

    public static partial class TypeExtensions
    {
        public static ConstructorInfo GetConstructor(Type type, Type[] types) { throw null; }

        public static ConstructorInfo[] GetConstructors(Type type, BindingFlags bindingAttr) { throw null; }

        public static ConstructorInfo[] GetConstructors(Type type) { throw null; }

        public static MemberInfo[] GetDefaultMembers(Type type) { throw null; }

        public static EventInfo GetEvent(Type type, string name, BindingFlags bindingAttr) { throw null; }

        public static EventInfo GetEvent(Type type, string name) { throw null; }

        public static EventInfo[] GetEvents(Type type, BindingFlags bindingAttr) { throw null; }

        public static EventInfo[] GetEvents(Type type) { throw null; }

        public static FieldInfo GetField(Type type, string name, BindingFlags bindingAttr) { throw null; }

        public static FieldInfo GetField(Type type, string name) { throw null; }

        public static FieldInfo[] GetFields(Type type, BindingFlags bindingAttr) { throw null; }

        public static FieldInfo[] GetFields(Type type) { throw null; }

        public static Type[] GetGenericArguments(Type type) { throw null; }

        public static Type[] GetInterfaces(Type type) { throw null; }

        public static MemberInfo[] GetMember(Type type, string name, BindingFlags bindingAttr) { throw null; }

        public static MemberInfo[] GetMember(Type type, string name) { throw null; }

        public static MemberInfo[] GetMembers(Type type, BindingFlags bindingAttr) { throw null; }

        public static MemberInfo[] GetMembers(Type type) { throw null; }

        public static MethodInfo GetMethod(Type type, string name, BindingFlags bindingAttr) { throw null; }

        public static MethodInfo GetMethod(Type type, string name, Type[] types) { throw null; }

        public static MethodInfo GetMethod(Type type, string name) { throw null; }

        public static MethodInfo[] GetMethods(Type type, BindingFlags bindingAttr) { throw null; }

        public static MethodInfo[] GetMethods(Type type) { throw null; }

        public static Type GetNestedType(Type type, string name, BindingFlags bindingAttr) { throw null; }

        public static Type[] GetNestedTypes(Type type, BindingFlags bindingAttr) { throw null; }

        public static PropertyInfo[] GetProperties(Type type, BindingFlags bindingAttr) { throw null; }

        public static PropertyInfo[] GetProperties(Type type) { throw null; }

        public static PropertyInfo GetProperty(Type type, string name, BindingFlags bindingAttr) { throw null; }

        public static PropertyInfo GetProperty(Type type, string name, Type returnType, Type[] types) { throw null; }

        public static PropertyInfo GetProperty(Type type, string name, Type returnType) { throw null; }

        public static PropertyInfo GetProperty(Type type, string name) { throw null; }

        public static bool IsAssignableFrom(Type type, Type c) { throw null; }

        public static bool IsInstanceOfType(Type type, object o) { throw null; }
    }
}