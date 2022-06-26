namespace InsertionSort
{
    /// <summary>
    /// Сортиране чрез вмъкване
    /// </summary>
    public class InsertionSort
    {
        /// <summary>
        /// Сортиране чрез вмъкване
        /// </summary>
        public static void Sort<T>(T[] collection) where T : IComparable
        {
            for (int i = 1; i < collection.Length; i++)
            {
                int prev = i - 1;
                int curr = i;
                while (true)
                {
                    if (prev < 0 || Help.IsLess(collection[prev], collection[curr]))
                    {
                        break;
                    }
                    Help.Swap(collection, curr, prev);
                    prev--;
                    curr--;
                }
            }
        }
    }
}
