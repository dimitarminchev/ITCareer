using System;
using System.Collections.Generic;

namespace _713 {
    static class Enumerable {
        public static TSource Min<TSource, TResult>(this IEnumerable<TSource> collection,
            Func<TSource, TResult> func) where TSource : IComparable<TSource> {
            var smallest = default(TSource);
            using(var enumer = collection.GetEnumerator())
                if(enumer.MoveNext())
                    smallest = enumer.Current;
            foreach(var item in collection)
                if(item.CompareTo(smallest) < 0)
                    smallest = item;
            return smallest;
        }
    }
}
