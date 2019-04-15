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
[assembly: AssemblyTitle("System.Xml.XPath.XmlDocument")]
[assembly: AssemblyDescription("System.Xml.XPath.XmlDocument")]
[assembly: AssemblyDefaultAlias("System.Xml.XPath.XmlDocument")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("1.0.24212.01")]
[assembly: AssemblyInformationalVersion("1.0.24212.01 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("4.0.1.0")]




namespace System.Xml
{
    public static partial class XmlDocumentXPathExtensions
    {
        public static System.Xml.XPath.XPathNavigator CreateNavigator(this System.Xml.XmlDocument document) { throw null; }
        public static System.Xml.XPath.XPathNavigator CreateNavigator(this System.Xml.XmlDocument document, System.Xml.XmlNode node) { throw null; }
        public static System.Xml.XPath.XPathNavigator CreateNavigator(this System.Xml.XmlNode node) { throw null; }
        public static System.Xml.XmlNodeList SelectNodes(this System.Xml.XmlNode node, string xpath) { throw null; }
        public static System.Xml.XmlNodeList SelectNodes(this System.Xml.XmlNode node, string xpath, System.Xml.XmlNamespaceManager nsmgr) { throw null; }
        public static System.Xml.XmlNode SelectSingleNode(this System.Xml.XmlNode node, string xpath) { throw null; }
        public static System.Xml.XmlNode SelectSingleNode(this System.Xml.XmlNode node, string xpath, System.Xml.XmlNamespaceManager nsmgr) { throw null; }
        public static System.Xml.XPath.IXPathNavigable ToXPathNavigable(this System.Xml.XmlNode node) { throw null; }
    }
}
