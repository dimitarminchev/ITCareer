using System;
using System.Collections.Generic;

namespace _719 {
    static class Enumerable {
        public static T[] ToArray<T>(this IEnumerable<T> collection) {
            return new List<T>(collection).ToArray();
        }

        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> collection, Func<TSource, TResult> func) {
            foreach(var item in collection)
                yield return func.Invoke(item);
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> collection, Predicate<T> predicate) {
            foreach(var item in collection)
                if(predicate.Invoke(item))
                    yield return item;
        }

        public static IEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector, IComparer<TKey> comparer = null) {
            if(comparer is null)
                comparer = Comparer<TKey>.Default;
            var arr = source.ToArray();
            for(int i = 0; i < arr.Length; i++) {
                int prev = i - 1;
                int curr = i;
                while(true) {
                    if(prev < 0 || comparer.Compare(keySelector(arr[curr]), keySelector(arr[prev])) > 0) break;
                    var temp = arr[curr];
                    arr[curr] = arr[prev];
                    arr[prev] = temp;
                    prev--;
                    curr--;
                }
            }
            return arr;
        }

        public static IEnumerable<int> Range(int start, int end) {
            for(int i = start; i <= end; i++)
                yield return i;
        }
    }
}
