namespace LinearSearch
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
    }
}
