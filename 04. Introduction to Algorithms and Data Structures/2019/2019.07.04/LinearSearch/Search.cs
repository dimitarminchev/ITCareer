using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class Search
    {
        // LinearSearch = Линейно търсене = O(n)
        public static int Linear<T> (T[] elements, T key) where T : IComparable
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
    }
}
