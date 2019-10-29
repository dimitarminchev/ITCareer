using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class Help
    {
        // Размяна на два елемента = O(1)
        public static void Swap<T>(T[] elements, int first, int second)
        {
            T temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }

        // Дали даден елемент е по малък от друг = O(1)
        public static bool IsLess(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

        // Проверка дали структурата е сортирана = O(N)
        public static bool IsSorted<T>(T[] elements) where T : IComparable
        {
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i - 1].CompareTo(elements[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

    public static class Sort
    {
        // Случайно число
        public static Random random = new Random();

        /// <summary>
        /// Разбъркване = O(N)
        /// </summary>
        public static void Shuffle<T>(T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                int r = i + random.Next(0, elements.Length - i);
                Help.Swap(elements, i, r);
            }
        }

        /// <summary>
        /// Сортиране по метода мехурчето = O(N^2)
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
        /// Сортиране чрез вмъкване = О(N^2))
        /// </summary>
        public static void Insertion<T>(T[] elements) where T : IComparable
        {
            for (int i = 1; i < elements.Length; i++)
            {
                int prev = i - 1;
                int curr = i;
                while (true)
                {
                    if (prev < 0 || Help.IsLess(elements[prev], elements[curr]))
                    {
                        break;
                    }
                    Help.Swap(elements, curr, prev);
                    prev--;
                    curr--;
                }
            }
        }

        /// <summary>
        /// Сортиране по метода на пряката селекция = O(N^2)
        /// </summary>
        public static void Selection<T>(T[] elements) where T : IComparable
        {
            for (int i = 0; i < elements.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (Help.IsLess(elements[j], elements[min]))
                    {
                        min = j;
                    }
                }
                Help.Swap(elements, min, i);
            }
        }

        /// <summary>
        /// Сортиране чрез сливане = O(N*log(N))
        /// </summary>
        public static void Merge<T>(T[] elements) where T : IComparable
        {
            MergeAlgo(elements, 0, elements.Length);
        }

        // Merge Algorithm
        private static void MergeAlgo<T>(T[] elements, int left, int right) where T : IComparable
        {
            // Difference
            int diff = right - left;

            // Recursion Exit Clause
            if (diff <= 1) return;

            // Recurrsion
            int mid = left + diff / 2;
            MergeAlgo(elements, left, mid);
            MergeAlgo(elements, mid, right);

            // Post-Recurrsion
            T[] temp = new T[diff];
            int i = left, j = mid;
            for (int k = 0; k < diff; k++)
            {
                if (i == mid) temp[k] = elements[j++];
                else if (j == right) temp[k] = elements[i++];
                else if (Help.IsLess(elements[j], elements[i])) temp[k] = elements[j++];
                else temp[k] = elements[i++];
            }
            for (int k = 0; k < diff; k++)
            {
                elements[left + k] = temp[k];
            }
        }


        /// <summary>
        /// Бързо сортиране = O(N*log(N))
        /// </summary>
        public static void Quick<T>(T[] elements) where T : IComparable
        {
            QuickAlgo(elements, 0, elements.Length - 1);
        }

        // Quick Algo
        private static void QuickAlgo<T>(T[] elements, int left, int right) where T : IComparable
        {
            if (left > right || left < 0 || right < 0) return;
            int pivot = QuickPartitionSort(elements, left, right);
            if (pivot != -1)
            {
                QuickAlgo(elements, left, pivot - 1);
                QuickAlgo(elements, pivot + 1, right);
            }
        }

        // Quick Partition Sort
        private static int QuickPartitionSort<T>(T[] elements, int left, int right) where T : IComparable
        {
            if (left > right) return -1;
            int end = left;
            T pivot = elements[right];
            for (int i = left; i < right; i++)
            {
                if (Help.IsLess(elements[i], pivot))
                {
                    Help.Swap(elements, i, end);
                    end++;
                }
            }
            Help.Swap(elements, end, right);
            return end;
        }
    }
}
