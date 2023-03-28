namespace LinearSearch
{
    public class Search
    {
        public static int Linear<T>(T[] elements, T key) where T : IComparable
        {
            for (int index = 0; index < elements.Count(); index++)
            {
                if (elements[index].CompareTo(key) == 0)
                {
                    return index;
                }
            }
            return -1;
        }
    }
}