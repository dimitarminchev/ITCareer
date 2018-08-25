using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem42
{
    class Sorting
    {
        public static void SortBy<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (Less(array[j], array[min]))
                        min = j;
                Swap(array, i, min);
            }
        }

        public static void SortByDescending<T>(T[] arr) where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (!Less(arr[j], arr[min]))
                        min = j;
                Swap(arr, i, min);
            }
        }

        private static void Swap<T>(T[] arr, int i, int min) where T : IComparable<T>
        {
            var num = arr[min];
            arr[min] = arr[i];
            arr[i] = num;
        }

        private static bool Less<T>(T t1, T t2) where T : IComparable<T>
        {
            return t1.CompareTo(t2) < 0;
        }

        public static void Sort2D<T>(T[][] arr, int pos) where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (Less(arr[j][pos], arr[min][pos]))
                        min = j;
                Swap2D(arr, i, min);
            }
        }

        private static void Swap2D<T>(T[][] arr, int i, int min) where T : IComparable<T>
        {
            var num = arr[min];
            arr[min] = arr[i];
            arr[i] = num;
        }
    }
}
