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
        public static bool IsSorted<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
                if (!IsLess(array[i - 1], array[i])) return false;
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
        public static void SelectionSort<T>(T[] array) where T : IComparable
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

        // 7. Сортиране чрез вмъкване = O(N^2)
        public static void InsertionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                int prev = i - 1;
                int curr = i;
                while (true)
                {
                    if (prev < 0 || IsLess(array[prev], array[curr])) break;
                    Swap(array, curr, prev);
                    prev--;
                    curr--;
                }
            }
        }

        // 7. Сортиране чрез смесване = O(N * log(N))
        public static void MergeSort<T>(T[] array) where T : IComparable
        {
            MergeAlgo(array, 0, array.Length);
        }
        private static void MergeAlgo<T> (T[] array, int left, int right) where T : IComparable
        {
            int N = right - left;
            if (N <= 1) return; // Условие за изход от рекурсията
            int mid = left + N / 2; // Среда

            // Рекурсия
            MergeAlgo(array, left, mid);  
            MergeAlgo(array, mid, right);

            // Обратен ход на рекурсията
            T[] temp = new T[N];
            int i = left, j = mid;
            for(int k = 0;k < N;k++)
            {
                if (i == mid) temp[k] = array[j++];
                else if (j == right) temp[k] = array[i++];
                else if (IsLess(array[j], array[i])) temp[k] = array[j++];
                else temp[k] = array[i++];
            }
            for (int k = 0; k < N; k++) array[left + k] = temp[k];
        }

        // 8. Бързо сортиране = O(N * log(N))
        public static void QuickSort<T>(T[] array) where T : IComparable
        {
            QuickAlgo(array, 0, array.Length - 1);
        }
        private static void QuickAlgo<T>(T[] array, int left, int right) where T : IComparable
        {
            if (left > right || left < 0 || right < 0) return; // Изход
            int pivot = QuickPart(array, left, right);
            if (pivot != -1)
            {
                QuickAlgo(array, left, pivot - 1); // 1
                QuickAlgo(array, pivot + 1, right); // 2
            }
        }
        private static int QuickPart<T>(T[] array, int left, int right) where T : IComparable
        {
            if (left > right) return -1;
            int end = left;
            T pivot = array[right];
            for (int i = left; i < right; i++)
                if (IsLess(array[i], pivot))
                {
                    Swap(array, i, end);
                    end++;
                }
            return end;
        }
    }
}
