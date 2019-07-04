using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveBinarySearch
{
    public class Search
    {
        // RecursiveBinarySearch = O(log(N))
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
    }
}
