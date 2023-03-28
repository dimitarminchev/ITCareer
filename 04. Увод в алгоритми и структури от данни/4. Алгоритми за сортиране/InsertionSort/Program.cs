namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort:");

            int[] array = { -1, 9, 2, -8, 7, 6, -3, 5, 4, 1, 3 };

            Console.WriteLine(String.Join(" ", array));

            Sort.Insertion(array);

            Console.WriteLine(String.Join(" ", array));
        }
    }
}