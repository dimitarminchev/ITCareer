namespace BinarySearch
{
    static class Search
    {
        public static int Binary<T>(T[] elements, T item) where T : IComparable
        {
            int low = 0;
            int high = elements.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (IsLess(item, elements[mid]))
                    high = mid - 1;
                else if (IsLess(elements[mid], item))
                    low = mid + 1;
                else
                    return mid;
            }

            return -1;
        }

        private static bool IsLess(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}