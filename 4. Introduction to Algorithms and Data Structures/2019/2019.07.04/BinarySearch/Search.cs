using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Search
    {
        // BinarySearch = O(log(n))
        public static int Binary<T>(T[] elements, T key) where T : IComparable
        {
            int start = 0, end = elements.Count() - 1;
            while (end >= start)
            {
                int mid = (start + end) / 2; // middle

                // Comparing
                if (elements[mid].CompareTo(key) < 0)
                {
                    start = mid + 1; // mid < key
                }
                else if (elements[mid].CompareTo(key) > 0)
                {
                    end = mid - 1; // mid > key
                }
                else
                {
                    return mid; // found
                }
            }
            return -1; // not found
        }
    }
}
