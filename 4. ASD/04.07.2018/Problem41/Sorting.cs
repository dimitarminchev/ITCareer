using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem41
{
    class Sorting
    {
        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        public static bool IsLess(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }


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

        public static void ReversedSelectionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (!IsLess(array[j], array[min]))
                        min = j;
                Swap(array, i, min);
            }
        }
    }
}
