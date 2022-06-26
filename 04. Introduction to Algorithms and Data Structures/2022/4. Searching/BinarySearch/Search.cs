namespace BinarySearch
{
    public class Search
    {
        /// <summary>
        /// Итеративно двоично търсене
        /// </summary>
        public static int Binary<T>(T[] collection, T key, int start, int end) where T : IComparable
        {
            while (end >= start)
            {
                // middle
                int mid = (start + end) / 2;

                // compare
                if (collection[mid].CompareTo(key) > 0)
                {
                    // (mid > key) => key must be on left
                    start = mid + 1;
                }
                else if (collection[mid].CompareTo(key) < 0)
                {
                    // (mid < key) => key must be on the right
                    end = mid - 1;
                }
                else
                {
                    // (mid == key) =? found
                    return mid;
                }
            }

            // not found
            return -1;
        }
    }
}
