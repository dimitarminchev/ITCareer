using System;
using System.Collections.Generic;

namespace _716
{
    static class Enumerable
    {
        public static T[] ToArray<T>(this IEnumerable<T> collection)
        {
            return new List<T>(collection).ToArray();
        }

        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> collection, Func<TSource, TResult> func)
        {
            foreach (var item in collection)
                yield return func.Invoke(item);
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            foreach (var item in collection)
                if (predicate.Invoke(item))
                    yield return item;
        }

        public static IEnumerable<T> Reverse<T>(this IEnumerable<T> collection)
        {
            var list = collection.ToArray();
            for (int i = list.Length - 1; i >= 0; i--)
                yield return list[i];
        }
    }
}
