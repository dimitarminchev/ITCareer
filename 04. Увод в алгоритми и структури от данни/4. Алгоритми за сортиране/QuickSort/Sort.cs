namespace QuickSort
{
    public static class Sort
    {
        public static void Quick<T>(T[] elements) where T : IComparable
        {
            QuickAlgo(elements, 0, elements.Length - 1);
        }

        private static void QuickAlgo<T>(T[] elements, int left, int right) where T : IComparable
        {
            if (left > right || left < 0 || right < 0) return;
            int pivot = QuickPartitionSort(elements, left, right);
            if (pivot != -1)
            {
                QuickAlgo(elements, left, pivot - 1);
                QuickAlgo(elements, pivot + 1, right);
            }
        }

        private static int QuickPartitionSort<T>(T[] elements, int left, int right) where T : IComparable
        {
            if (left > right) return -1;
            int end = left;
            T pivot = elements[right];
            for (int i = left; i < right; i++)
            {
                if (Help.IsLess(elements[i], pivot))
                {
                    Help.Swap(elements, i, end);
                    end++;
                }
            }
            Help.Swap(elements, end, right);
            return end;
        }
    }
}