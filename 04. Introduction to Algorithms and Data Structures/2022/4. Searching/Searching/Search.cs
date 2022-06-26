namespace Searching
{
    public class Search
    {
        /// <summary>
        /// Линейно търсене
        /// </summary>
        public static int Linear<T>(T[] collection, T key) where T : IComparable
        {
            for (int index = 0; index < collection.Count(); index++)
            {
                if (collection[index].CompareTo(key) == 0)
                {
                    return index; // Found
                }
            }
            return -1; // Not Found
        }

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

        /// <summary>
        /// Рекурсивно двоично търсене
        /// </summary>
        public static int RecursiveBinary<T>(T[] collection, T key, int start, int end) where T : IComparable
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

        /// <summary>
        /// Интерполационно търсене
        /// </summary>
        public static int Interpolation<T>(T[] collection, T key) where T : IComparable
        {
            int low = 0, high = collection.Count() - 1;

            // algo
            while (collection[low].CompareTo(key) <= 0 && collection[high].CompareTo(key) >= 0)
            {
                int mid = low + (((dynamic)key - (dynamic)collection[low]) * (high - low)) /
                                 ((dynamic)collection[high] - (dynamic)collection[low]);

                // compare
                if (collection[mid].CompareTo(key) > 0)
                {
                    // (mid > key) -> key must be on left
                    low = mid + 1;
                }
                else if (collection[mid].CompareTo(key) < 0)
                {
                    // (mid < key) -> key must be on right
                    high = mid - 1;
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

        /// <summary>
        /// Лесно търсене
        /// </summary>
        public static int Easy<T>(T[] collection, T key) where T : IComparable
        {
            for (int index = collection.Count() - 1; index != 0; index--)
            {
                if (collection[index].Equals(key))
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
