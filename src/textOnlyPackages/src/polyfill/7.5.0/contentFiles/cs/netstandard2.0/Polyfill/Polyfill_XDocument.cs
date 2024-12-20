// <auto-generated />
#pragma warning disable

#if NETFRAMEWORK || NETSTANDARD2_0

namespace Polyfills;

using System.Xml;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

static partial class Polyfill
{
    /// <summary>
    /// Output this <see cref="XDocument"/> to an <see cref="XmlWriter"/>.
    /// </summary>
    /// <param name="writer">
    /// The <see cref="XmlWriter"/> to output the XML to.
    /// </param>
    /// <param name="cancellationToken">
    /// A cancellation token.
    /// </param>
    //Link: https://learn.microsoft.com/en-us/dotnet/api/system.xml.linq.xdocument.saveasync#system-xml-linq-xdocument-saveasync(system-xml-xmlwriter-system-threading-cancellationtoken)
    public static Task SaveAsync(
        this XDocument target,
        XmlWriter writer,
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        target.Save(writer);
        return Task.CompletedTask;
    }

    /// <summary>
    /// Output this <see cref="XDocument"/> to a <see cref="Stream"/>.
    /// </summary>
    /// <param name="stream">
    /// The <see cref="Stream"/> to output the XML to.
    /// </param>
    /// <param name="options">
    /// If SaveOptions.DisableFormatting is enabled the output is not indented.
    /// If SaveOptions.OmitDuplicateNamespaces is enabled duplicate namespace declarations will be removed.
    /// </param>
    /// <param name="cancellationToken">A cancellation token.</param>
    //Link: https://learn.microsoft.com/en-us/dotnet/api/system.xml.linq.xdocument.saveasync#system-xml-linq-xdocument-saveasync(system-io-stream-system-xml-linq-saveoptions-system-threading-cancellationtoken)
    public static Task SaveAsync(
        this XDocument target,
        Stream stream,
        SaveOptions options,
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        target.Save(stream, options);
        return Task.CompletedTask;
    }

    /// <summary>
    /// Output this <see cref="XDocument"/> to a <see cref="TextWriter"/>.
    /// </summary>
    /// <param name="textWriter">
    /// The <see cref="TextWriter"/> to output the XML to.
    /// </param>
    /// <param name="options">
    /// If SaveOptions.DisableFormatting is enabled the output is not indented.
    /// If SaveOptions.OmitDuplicateNamespaces is enabled duplicate namespace declarations will be removed.
    /// </param>
    /// <param name="cancellationToken">A cancellation token.</param>
    //Link: https://learn.microsoft.com/en-us/dotnet/api/system.xml.linq.xdocument.saveasync#system-xml-linq-xdocument-saveasync(system-io-textwriter-system-xml-linq-saveoptions-system-threading-cancellationtoken)
    public static Task SaveAsync(
        this XDocument target,
        TextWriter textWriter,
        SaveOptions options,
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        target.Save(textWriter, options);
        return Task.CompletedTask;
    }
}
#endif