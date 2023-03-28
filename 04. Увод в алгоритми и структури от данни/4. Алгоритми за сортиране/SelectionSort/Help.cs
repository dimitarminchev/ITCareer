namespace SelectionSort
{
    public class Help
    {
        public static void Swap<T>(T[] collection, int from, int to)
        {
            T temp = collection[from];
            collection[from] = collection[to];
            collection[to] = temp;
        }

        public static bool IsLess(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}