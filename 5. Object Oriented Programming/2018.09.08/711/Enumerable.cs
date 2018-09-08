using System;
using System.Collections.Generic;

namespace _711
{
    static class Enumerable
    {
        public static void Action<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
                action.Invoke(item);
        }
    }
}
