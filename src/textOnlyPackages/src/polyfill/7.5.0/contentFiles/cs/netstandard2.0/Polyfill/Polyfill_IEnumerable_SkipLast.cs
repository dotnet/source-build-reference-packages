// <auto-generated />
#pragma warning disable

#if NETFRAMEWORK || NETSTANDARD2_0

namespace Polyfills;

using System.Collections;
using System.Collections.Generic;
using System.Linq;

static partial class Polyfill
{
    /// <summary>
    /// Returns a new enumerable collection that contains the elements from source with the last count elements of the
    /// source collection omitted.
    /// </summary>
    /// <param name="source">An enumerable collection instance.</param>
    /// <param name="count">The number of elements to omit from the end of the collection.</param>
    /// <typeparam name="TSource">The type of the elements in the enumerable collection.</typeparam>
    /// <returns>A new enumerable collection that contains the elements from source minus count elements from the end
    /// of the collection.</returns>
    //Link: https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.skiplast
    public static IEnumerable<TSource> SkipLast<TSource>(
        this IEnumerable<TSource> target,
        int count) =>
        target.Reverse().Skip(count).Reverse();
}
#endif