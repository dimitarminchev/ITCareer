namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort:");

            int[] array = { -1, 9, 2, -8, 7, 6, -3, 5, 4, 1, 3 };

            Console.WriteLine(String.Join(" ", array));

            Sort.Bubble(array);

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
