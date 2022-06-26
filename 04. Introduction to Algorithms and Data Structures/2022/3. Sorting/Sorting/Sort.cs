using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// Методи за сортиране
    /// </summary>
    public class Sort
    {
        /// <summary>
        /// Сортиране чрез метода мехурчето
        /// </summary>
        public static void Bubble<T>(T[] elements) where T : IComparable
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length; j++)
                {
                    if (Help.IsLess(elements[i], elements[j]))
                    {
                        Help.Swap(elements, i, j);
                    }
                }
            }
        }

        /// <summary>
        /// Сортиране чрез вмъкване
        /// </summary>
        public static void Insertion<T>(T[] collection) where T : IComparable
        {
            for (int i = 1; i < collection.Length; i++)
            {
                int prev = i - 1;
                int curr = i;
                while (true)
                {
                    if (prev < 0 || Help.IsLess(collection[prev], collection[curr]))
                    {
                        break;
                    }
                    Help.Swap(collection, curr, prev);
                    prev--;
                    curr--;
                }
            }
        }

        /// <summary>
        /// Сортиране чрез пряка селекция
        /// </summary>
        public static void Selection<T>(T[] collection) where T : IComparable
        {
            for (int index = 0; index < collection.Length; index++)
            {
                int min = index;
                for (int curr = index + 1; curr < collection.Length; curr++)
                {
                    if (Help.IsLess(collection[curr], collection[min]))
                    {
                        min = curr;
                    }
                }
                Help.Swap(collection, index, min);
            }
        }

        /// <summary>
        /// Сортиране чрез сливане
        /// </summary>
        public static void Merge<T>(T[] collection) where T : IComparable
        {
            MergeAlgo(collection, 0, collection.Length);
        }

        // Merge Algorithm
        private static void MergeAlgo<T>(T[] collection, int left, int right) where T : IComparable
        {
            // Difference
            int diff = right - left;

            // Recursion Exit Clause
            if (diff <= 1) return;

            // Recurrsion
            int mid = left + diff / 2;
            MergeAlgo(collection, left, mid);
            MergeAlgo(collection, mid, right);

            // Post-Recurrsion
            T[] temp = new T[diff];
            int i = left, j = mid;
            for (int k = 0; k < diff; k++)
            {
                if (i == mid) temp[k] = collection[j++];
                else if (j == right) temp[k] = collection[i++];
                else if (Help.IsLess(collection[j], collection[i])) temp[k] = collection[j++];
                else temp[k] = collection[i++];
            }
            for (int k = 0; k < diff; k++)
            {
                collection[left + k] = temp[k];
            }
        }

        /// <summary>
        /// Бързо сортиране
        /// </summary>
        public static void Quick<T>(T[] collection) where T : IComparable
        {
            QuickAlgo(collection, 0, collection.Length - 1);
        }

        // Quick Algo
        private static void QuickAlgo<T>(T[] collection, int left, int right) where T : IComparable
        {
            if (left > right || left < 0 || right < 0) return;
            int pivot = QuickPartitionSort(collection, left, right);
            if (pivot != -1)
            {
                QuickAlgo(collection, left, pivot - 1);
                QuickAlgo(collection, pivot + 1, right);
            }
        }

        // Quick Partition Sort
        private static int QuickPartitionSort<T>(T[] collection, int left, int right) where T : IComparable
        {
            if (left > right) return -1;
            int end = left;
            T pivot = collection[right];
            for (int i = left; i < right; i++)
            {
                if (Help.IsLess(collection[i], pivot))
                {
                    Help.Swap(collection, i, end);
                    end++;
                }
            }
            Help.Swap(collection, end, right);
            return end;
        }


    }
}
