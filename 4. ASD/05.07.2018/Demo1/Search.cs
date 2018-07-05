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
        public static int RecursiveBinarySearch<T>(T[] array, T key, int start, int end) where T : IComparable
        {
            if (end < start) return -1; 
            int mid = (start + end) / 2;
            if (array[mid].CompareTo(key) > 0) return RecursiveBinarySearch(array, key, start, mid - 1);
            else if (array[mid].CompareTo(key) < 0) return RecursiveBinarySearch(array, key, mid + 1, end);
            else return mid; 
        }

        // 3. BinarySearch = O(log(N))
        public static int BinarySearch<T>(T[] array, T key, int start, int end) where T : IComparable
        {
            while (end >= start)
            {
                int mid = (start + end) / 2;
                if (array[mid].CompareTo(key) > 0)  end = mid - 1;
                else if (array[mid].CompareTo(key) < 0) start = mid + 1;
                else return mid; 
            }
            return -1; 
        }

        // 4. InterpolationSearch = O(log(log(N)))
        public static int InterpolationSearch<T>(T[] array, T key) where T : IComparable
        {
            int low = 0;
            int high = array.Length - 1;
            while (array[low].CompareTo(key) <= 0 && array[high].CompareTo(key) >= 0)
            {
                int mid = low + (((dynamic)key - (dynamic)array[low]) * (high - low)) / ((dynamic)array[high] - (dynamic)array[low]);
                if (array[mid].CompareTo(key) < 0) low = mid + 1;
                else if (array[mid].CompareTo(key) > 0) high = mid - 1;
                else return mid; 
            }
            return -1; 
        }
		
		// 5. GoodSearch = O(N)
        public static int MySearch<T>(T[] array, T key) where T : IComparable
        {
            for (int index = array.Length - 1; index != 0; index--)
            {
                if (array[index].CompareTo(key) == 0)
                {
                    return index;
                }
            }
            return -1;
        }
    }
}
