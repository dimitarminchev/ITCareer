using System;
using System.Collections.Generic;

namespace _7112 {
    static class Enumerable {
        public static T[] ToArray<T>(this IEnumerable<T> collection) {
            return new List<T>(collection).ToArray();
        }

        public static List<T> ToList<T>(this IEnumerable<T> collection) {
            return new List<T>(collection);
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

        public static IEnumerable<T> Concat<T>(this IEnumerable<T> collection, IEnumerable<T> add) {
            foreach(var item in collection)
                yield return item;
            foreach(var item in add)
                yield return item;
        }

        public static IEnumerable<int> SumLeft(this IEnumerable<int> collection, int index) {
            var list = new int[] { 0 }.Concat(collection).ToArray();
            for(int i = 1; i < list.Length; i++)
                if(list[i] + list[i - 1] != index)
                    yield return list[i];
        }

        public static IEnumerable<int> ReversedSumLeft(this IEnumerable<int> collection, int index) {
            var list = new int[] { 0 }.Concat(collection).ToArray();
            for(int i = 1; i < list.Length; i++)
                if(list[i] + list[i - 1] == index)
                    yield return list[i];
        }

        public static IEnumerable<int> SumLeftRight(this IEnumerable<int> collection, int index) {
            var list = new int[] { 0 }.Concat(collection).Concat(new int[] { 0 }).ToArray();
            for(int i = 1; i < list.Length - 1; i++)
                if(list[i] + list[i - 1] + list[i + 1] != index)
                    yield return list[i];
        }
    }
}
