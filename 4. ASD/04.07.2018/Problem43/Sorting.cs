using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem43 {
    class Sorting {
        public static void SortCount<T>(T[] array) where T : IComparable<T> {
            int count = 0;
            for (int i = 0; i < array.Length; i++) {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (Less(array[j], array[min])) {
                        Console.WriteLine(array[i] + " " + array[j]);
                        count++;
                    }
            }
            Console.WriteLine(count);
        }

        private static bool Less<T>(T t1, T t2) where T : IComparable<T> {
            return t1.CompareTo(t2) < 0;
        }

        public static void SortMerge<T>(T[] arr) where T : IComparable<T> {
            MergeAlgo(arr, 0, arr.Length);
        }

        private static void MergeAlgo<T>(T[] array, int left, int right) where T : IComparable<T> {
            int N = right - left;
            if (N <= 1) return;
            int mid = left + N / 2;
            MergeAlgo(array, left, mid);
            MergeAlgo(array, mid, right);
            T[] temp = new T[N];
            int i = left, j = mid;
            for (int k = 0; k < N; k++) {
                if (i == mid) temp[k] = array[j++];
                else if (j == right) temp[k] = array[i++];
                else if (Less(array[j], array[i])) temp[k] = array[j++];
                else temp[k] = array[i++];
            }
            for (int k = 0; k < N; k++) array[left + k] = temp[k];
        }
    }
}
