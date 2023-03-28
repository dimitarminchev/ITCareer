namespace AdmissionRanking
{
    public static class Sort
    {
        public static void Selection<T>(T[] elements) where T : IComparable
        {
            for (int i = 0; i < elements.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (Help.IsLess(elements[min], elements[j]))
                    {
                        min = j;
                    }
                }
                Help.Swap(elements, min, i);
            }
        }
    }
}