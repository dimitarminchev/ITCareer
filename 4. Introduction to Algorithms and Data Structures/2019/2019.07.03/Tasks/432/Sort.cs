using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _432
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
