using System;
using System.Collections.Generic;

namespace _717
{
    static class Enumerable
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            foreach (var item in collection)
            {
                if (predicate.Invoke(item))
                {
                    yield return item;
                }
            }
        }
    }
}
