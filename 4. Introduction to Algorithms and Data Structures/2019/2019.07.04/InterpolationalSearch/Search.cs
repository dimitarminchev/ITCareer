using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolationalSearch
{
    public class Search
    {

        // Interpolation Search = O(log(log(N))
        public static int Interpolational<T>(T[] elements, T key) where T : IComparable
        {
            int low = 0, high = elements.Count() - 1;
            // algo
            while (elements[low].CompareTo(key) <= 0 && elements[high].CompareTo(key) >= 0)
            {
                int mid = low + (((dynamic)key - (dynamic)elements[low])*(high-low)) / 
                                 ((dynamic)elements[high] - (dynamic)elements[low]);

                // compare
                if (elements[mid].CompareTo(key) > 0)
                {
                    // (mid > key) => key must be on left 
                    high = mid - 1;
                }
                else if (elements[mid].CompareTo(key) < 0)
                {
                    // (mid < key) => key must be on right 
                    low = mid + 1;
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
    }
}
