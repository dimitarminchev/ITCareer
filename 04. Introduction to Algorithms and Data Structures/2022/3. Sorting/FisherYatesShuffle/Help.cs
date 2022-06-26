namespace FisherYatesShuffle
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

        /// <summary>
        /// Разбъркване на елементите
        /// </summary>
        public static void Shuffle<T>(T[] collection)
        {
            Random rnd = new Random();
            for (int index = 0; index < collection.Length; index++)
            {
                int random = index + rnd.Next(0, collection.Length - index);
                Swap(collection, index, random);
            }
        }
    }
}
