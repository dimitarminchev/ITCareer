namespace BubbleSort
{
    /// <summary>
    /// Сортиране чрез метода на мехурчето 
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Сортиране по метода мехурчето = O(N^2)
        /// </summary>
        public static void Sort<T>(T[] elements) where T : IComparable
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
    }
}
