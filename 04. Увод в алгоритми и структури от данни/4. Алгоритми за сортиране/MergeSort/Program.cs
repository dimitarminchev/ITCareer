namespace MergeSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Merge Sort:");

            int[] array = { -1, 9, 2, -8, 7, 6, -3, 5, 4, 1, 3 };

            Console.WriteLine(String.Join(" ", array));

            Sort.Merge(array);

            Console.WriteLine(String.Join(" ", array));
        }
    }
}