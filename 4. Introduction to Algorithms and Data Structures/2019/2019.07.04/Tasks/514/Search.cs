using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _515
{
    class Search
    {
        public static int Linear<T>(T[] elements, T key) where T : IComparable
        {
            for (int index = 0; index < elements.Count(); index++)
            {
                if (elements[index].CompareTo(key) == 0)
                {
                    return index; // Found
                }
            }
            return -1; // Not Found
        }

        /// <summary>
        /// BinarySearch = Рекурсивно двоично търсене = O(log(n))
        /// </summary>
        public static int Binary<T>(T[] elements, T key) where T : IComparable
        {
            int start = 0, end = elements.Count() - 1;
            while (end >= start)
            {
                // middle
                int mid = (start + end) / 2;

                // compare
                if (elements[mid].CompareTo(key) > 0)
                {
                    // (mid > key) => key must be on left 
                    end = mid - 1;
                }
                else if (elements[mid].CompareTo(key) < 0)
                {
                    // (mid < key) => key must be on right 
                    start = mid + 1;
                }
                else
                {
                    // (mid == key) => found
                    return mid;
                }
            }
            // not found
            return -1;
        }

        /// <summary>
        /// Interpolation Search = Интерполационно търсене = O(log(log(N))
        /// </summary>
        public static int Interpolational(int[] sortedArray, int key)
        {
            // TODO: MUST BE FIXED ...
            int low = 0;
            int high = sortedArray.Length - 1;
            while (sortedArray[low] <= key && sortedArray[high] >= key)
            {
                int mid = (int)(low + ((double)(key - sortedArray[low]) * (high - low)) / (sortedArray[high] - sortedArray[low]));
                if (sortedArray[mid] < key) low = mid + 1;
                else if (sortedArray[mid] > key) high = mid - 1;
                else return mid;
            }
            if (sortedArray[low] == key) return low;
            else return -1;
        }
        //Fibonacci
        public static int Fibonacci(int[] arr, int x, int n)
        {
            int fibMMm2 = 0;
            int fibMMm1 = 1; 
            int fibM = fibMMm2 + fibMMm1;
            while (fibM < n)
            {
                fibMMm2 = fibMMm1;
                fibMMm1 = fibM;
                fibM = fibMMm2 + fibMMm1;
            }
            int offset = -1;
            while (fibM > 1)
            {
                int i = Math.Min(offset + fibMMm2, n - 1);
                if (arr[i] < x)
                {
                    fibM = fibMMm1;
                    fibMMm1 = fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                    offset = i;
                }
                else if (arr[i] > x)
                {
                    fibM = fibMMm2;
                    fibMMm1 = fibMMm1 - fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                }
                else return i;
            }
            if (fibMMm1 != 0 && arr[offset + 1] == x) return offset + 1;
            return -1;
        }
    }
}
