namespace QuickSort
{
    /// <summary>
    /// Бързо сортиране
    /// </summary>
    public class QuickSort
    {
        /// <summary>
        /// Бързо сортиране
        /// </summary>
        public static void Sort<T>(T[] collection) where T : IComparable
        {
            QuickAlgo(collection, 0, collection.Length - 1);
        }

        // Quick Algo
        private static void QuickAlgo<T>(T[] collection, int left, int right) where T : IComparable
        {
            if (left > right || left < 0 || right < 0) return;
            int pivot = QuickPartitionSort(collection, left, right);
            if (pivot != -1)
            {
                QuickAlgo(collection, left, pivot - 1);
                QuickAlgo(collection, pivot + 1, right);
            }
        }

        // Quick Partition Sort
        private static int QuickPartitionSort<T>(T[] collection, int left, int right) where T : IComparable
        {
            if (left > right) return -1;
            int end = left;
            T pivot = collection[right];
            for (int i = left; i < right; i++)
            {
                if (Help.IsLess(collection[i], pivot))
                {
                    Help.Swap(collection, i, end);
                    end++;
                }
            }
            Help.Swap(collection, end, right);
            return end;
        }
    }
}
