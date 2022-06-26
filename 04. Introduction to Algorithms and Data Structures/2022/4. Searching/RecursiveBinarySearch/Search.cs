
namespace RecursiveBinarySearch
{
    public class Search
    {
        /// <summary>
        /// Рекурсивно двоично търсене
        /// </summary>
        public static int RecursiveBinary<T>(T[] collection, T key, int start, int end) where T: IComparable
        {
            // not found
            if (end < start) return -1;

            // middle
            int mid = (start + end) / 2;

            // compare
            if (collection[mid].CompareTo(key) > 0)
            {
                // (mid > key) => the key must be on the left
                return RecursiveBinary(collection, key, start, mid - 1);
            }
            else if (collection[mid].CompareTo(key) < 0)
            {
                // (mid < key) => the key must be on the right
                return RecursiveBinary(collection, key, mid + 1, end);
            }
            else
            {
                // (mid == key) => found
                return mid;
            }
        }
    }
}
