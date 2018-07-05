using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Search
    {
        // 1. LinearSearch = O(N)
        public static int LinearSearch<T> (T[] array, T key) where T : IComparable
        {
            for(int index = 0; index < array.Count(); index++)
            {
                if (array[index].CompareTo(key) == 0)
                {
                    return index;
                }
            }
            return -1; 
        }

        // 2. RecursiveBinarySearch = O(log(N))
        public static int RecursiveBinarySearch(int[] array, int key, int start, int end)
        {
            if (end < start) return -1; 
            int mid = (start + end) / 2;
            if (array[mid] < key) return RecursiveBinarySearch(array, key, start, mid - 1);
            else if (array[mid] > key) return RecursiveBinarySearch(array, key, mid + 1, end);
            else return mid; 
        }

        // 3. BinarySearch = O(log(N))
    }
}
