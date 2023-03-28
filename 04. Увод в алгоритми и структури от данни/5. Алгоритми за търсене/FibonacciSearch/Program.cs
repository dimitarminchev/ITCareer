namespace FibonacciSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Search:");

            int[] array = { 1, 2, 3, 4, 5 };

            int index = Search.Fibonacci(array, 3, array.Length);
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