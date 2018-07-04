using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    static class Sorting
    {
        // 1. Размяна на елементи
        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        // 2. Сравнение на два елемента
        public static bool IsLess(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

        // 3. Проверка дали структурата е сортирана = O(N)
        public static bool IsSorted<T> (T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            if (!IsLess(array[i-1],array[i])) return false;
            return true;
        }

        // 4. Разбъркване на елементите = O(N)
        private static Random random = new Random();
        public static void Shifting<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int r = i + random.Next(0, array.Length - i);
                Swap(array, i, r);
            }
        }

        // 5. Сортиране по метода на пряката селеция = O(N^2)
        public static void SelectionSort<T> (T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (IsLess(array[j], array[min]))
                        min = j;
                Swap(array, i, min);
            }
        }

        // 6. Сортиране по метода на мехурчето = O(N^2)
        public static void BubbleSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)           
                for (int j = 0; j < array.Length; j++)              
                    if (IsLess(array[i], array[j]))
                        Swap(array, i, j);
        }


    }
}
