using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySearch
{
    public class Search
    {

        // EasySearch = O(N)
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
