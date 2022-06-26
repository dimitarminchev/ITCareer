namespace EasySearch
{
    public class Search
    {
        /// <summary>
        /// Лесно търсене
        /// </summary>
        public static int Easy<T>(T[] collection, T key) where T : IComparable
        {
            for (int index = collection.Count() - 1; index!=0; index--)
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
