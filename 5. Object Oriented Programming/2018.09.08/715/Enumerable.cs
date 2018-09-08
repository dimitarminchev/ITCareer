using System;
using System.Collections.Generic;

namespace _715
{
    static class Enumerable
    {
        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> collection, Func<TSource, TResult> func)
        {
            foreach (var item in collection)
                yield return func.Invoke(item);
        }
    }
}
