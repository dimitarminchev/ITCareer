namespace MergeSort
{
    /// <summary>
    /// Сортиране чрез сливане
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// Сортиране чрез сливане
        /// </summary>
        public static void Sort<T>(T[] collection) where T : IComparable
        {
            MergeAlgo(collection, 0, collection.Length);
        }

        // Merge Algorithm
        private static void MergeAlgo<T>(T[] collection, int left, int right) where T : IComparable
        {
            // Difference
            int diff = right - left;

            // Recursion Exit Clause
            if (diff <= 1) return;

            // Recurrsion
            int mid = left + diff / 2;
            MergeAlgo(collection, left, mid);
            MergeAlgo(collection, mid, right);

            // Post-Recurrsion
            T[] temp = new T[diff];
            int i = left, j = mid;
            for (int k = 0; k < diff; k++)
            {
                if (i == mid) temp[k] = collection[j++];
                else if (j == right) temp[k] = collection[i++];
                else if (Help.IsLess(collection[j], collection[i])) temp[k] = collection[j++];
                else temp[k] = collection[i++];
            }
            for (int k = 0; k < diff; k++)
            {
                collection[left + k] = temp[k];
            }
        }
    }
}
