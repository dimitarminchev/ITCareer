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
            if (end < start) return -1; // not found

            // middle
            int mid = (start + end) / 2;

            if (elements[mid].CompareTo(key) > 0)
            {
                // left part
                return RecursiveBinary(elements, key, start, mid - 1);
            }
            else if (elements[mid].CompareTo(key) < 0)
            {
                // right part
                return RecursiveBinary(elements, key, mid + 1, end);
            }
            else
            {                
                return mid; // found
            }
        }
    }
}
