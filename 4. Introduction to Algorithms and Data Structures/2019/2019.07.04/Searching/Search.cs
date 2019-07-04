using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class Search
    {
        /// <summary>
        /// LinearSearch = Линейно търсене = O(n)
        /// </summary>
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
        /// RecursiveBinarySearch = Рекурсивно двоично търсене = O(log(N))
        /// </summary>
        public static int RecursiveBinary<T>(T[] elements, T key, int start, int end) where T : IComparable
        {
            // not found
            if (end < start) return -1;

            // middle
            int mid = (start + end) / 2;

            // compare
            if (elements[mid].CompareTo(key) > 0)
            {
                // (mid > key) => key must be on left 
                return RecursiveBinary(elements, key, start, mid - 1);
            }
            else if (elements[mid].CompareTo(key) < 0)
            {
                // (mid < key) => key must be on right 
                return RecursiveBinary(elements, key, mid + 1, end);
            }
            else
            {
                // (mid == key) => found
                return mid;
            }
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
                else  return mid;
            }
            if (sortedArray[low] == key) return low;
            else return -1;
        }

        /// <summary>
        /// EasySearch = Лесно търсене = O(N)
        /// </summary>
        public static int Easy<T>(T[] elements, T key) where T : IComparable
        {
            for (int index = elements.Count() - 1; index != 0; index--)
            {
                if (elements[index].Equals(key))
                {
                    // found
                    return index;
                }
            }
            // not found
            return -1;
        }
    }
}
