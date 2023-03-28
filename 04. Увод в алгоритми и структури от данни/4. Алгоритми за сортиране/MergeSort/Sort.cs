namespace MergeSort
{
    public static class Sort
    {
        public static void Merge<T>(T[] elements) where T : IComparable
        {
            MergeAlgo(elements, 0, elements.Length);
        }

        private static void MergeAlgo<T>(T[] elements, int left, int right) where T : IComparable
        {
            int diff = right - left;

            if (diff <= 1) return;

            int mid = left + diff / 2;
            MergeAlgo(elements, left, mid);
            MergeAlgo(elements, mid, right);

            T[] temp = new T[diff];
            int i = left, j = mid;
            for (int k = 0; k < diff; k++)
            {
                if (i == mid) temp[k] = elements[j++];
                else if (j == right) temp[k] = elements[i++];
                else if (Help.IsLess(elements[j], elements[i])) temp[k] = elements[j++];
                else temp[k] = elements[i++];
            }
            for (int k = 0; k < diff; k++)
            {
                elements[left + k] = temp[k];
            }
        }
    }
}