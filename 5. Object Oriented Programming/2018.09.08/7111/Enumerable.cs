using System;
using System.Collections.Generic;

namespace _7111
{
    static class Enumerable
    {
        public static T[] ToArray<T>(this IEnumerable<T> collection)
        {
            return new List<T>(collection).ToArray();
        }

        public static List<T> ToList<T>(this IEnumerable<T> collection)
        {
            return new List<T>(collection);
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            foreach (var item in collection)
                if (predicate.Invoke(item))
                    yield return item;
        }
    }
}
