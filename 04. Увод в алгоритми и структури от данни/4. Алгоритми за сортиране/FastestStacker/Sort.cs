namespace FastestStacker
{
    public static class Sort
    {
        public static void Bubble<T>(T[] elements) where T : IComparable
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length; j++)
                {
                    if (Help.IsLess(elements[i], elements[j]))
                    {
                        Help.Swap(elements, i, j);
                    }
                }
            }
        }

        public static void Insertion<T>(T[] elements) where T : IComparable
        {
            for (int i = 0; i < elements.Length; i++)
            {
                int prev = i - 1;
                int curr = i;
                while (true)
                {
                    if (prev < 0 || Help.IsLess(elements[prev], elements[curr]))
                    {
                        break;
                    }
                    Help.Swap(elements, curr, prev);
                    curr--;
                    prev--;
                }
            }
        }

        // TODO: Add more sorting algorithms ....
    }
}