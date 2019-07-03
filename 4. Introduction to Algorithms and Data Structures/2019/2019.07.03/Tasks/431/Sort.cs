using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _431
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
    }
}
