namespace SelectionSort
{
    public class Sort
    {
        public static void Selection<T>(T[] collection) where T : IComparable
        {
            for (int index = 0; index < collection.Length; index++)
            {
                int min = index;
                for (int curr = index + 1; curr < collection.Length; curr++)
                {
                    if (Help.IsLess(collection[curr], collection[min]))
                    {
                        min = curr;
                    }
                }
                Help.Swap(collection, index, min);
            }
        }
    }
}