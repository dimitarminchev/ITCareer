namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search:");

            int[] array = { 1, 2, 3, 4, 5 };

            int index = Search.Binary<int>(array, 3);
            if (index > 0)
            {
                Console.WriteLine("Element [3] found at index [{0}].", index);
            }
            else
            {
                Console.WriteLine("Element [3] not found.");
            }
        }
    }
}