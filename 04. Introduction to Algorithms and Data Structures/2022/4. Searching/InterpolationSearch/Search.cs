namespace InterpolationSearch
{
    public class Search
    {
        /// <summary>
        /// Интерполационно търсене
        /// </summary>
        public static int Interpolation<T>(T[] collection, T key) where T : IComparable
        {
            int low = 0,high = collection.Count() - 1;

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

    }
}
