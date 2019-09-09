using System;
using System.Collections.Generic;

namespace _7113
{
    static class Enumerable
    {
        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> collection, Func<TSource, TResult> func)
        {
            foreach (var item in collection)
                yield return func.Invoke(item);
        }

        public static T FirstOrDefault<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            foreach (var item in collection)
                if (predicate.Invoke(item))
                    return item;
            return default(T);
        }

        public static int Sum(this IEnumerable<int> collection)
        {
            int sum = 0;
            foreach (var item in collection)
                sum += item;
            return sum;
        }
    }
}
