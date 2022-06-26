using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    /// <summary>
    /// Сортиране чрез пряка селекция
    /// </summary>
    public class SelectionSort
    {
        /// <summary>
        /// Сортиране чрез пряка селекция
        /// </summary>
        public static void Sort<T>(T[] collection) where T : IComparable
        {
            for (int index = 0; index < collection.Length; index++)
            {
                int min = index;
                for (int curr = index + 1; curr < collection.Length; curr++)
                {
                    if (Help.IsLess(collection[curr], collection[min]))
                    {
                        min = curr;
                    }
                }
                Help.Swap(collection, index, min);
            }
        }
    }
}
