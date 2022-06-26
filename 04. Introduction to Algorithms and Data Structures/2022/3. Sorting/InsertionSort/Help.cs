namespace InsertionSort
{
    /// <summary>
    /// Помощен клас
    /// </summary>
    public class Help
    {
        /// <summary>
        /// Размяна на два елемента 
        /// </summary>
        public static void Swap<T>(T[] collection, int from, int to)
        {
            T temp = collection[from];
            collection[from] = collection[to];
            collection[to] = temp;
        }

        /// <summary>
        /// Сравняване на два елемента
        /// </summary>
        public static bool IsLess(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}
