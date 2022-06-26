namespace EasySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Structures
            var numbers = new int[] { -5, 5, -4, 4, -3, 3, -2, 2, -1, 1 };
            var alphas = new char[] { 'm', 'a', 'g', 'g', 'i', 'c', 'h', 'a', 'p', 'p', 'e', 'n', 'd' };

            // Serach by Number
            Console.WriteLine("Search for [-3] ...");
            int pos = Search.Easy(numbers, -3);
            if (pos >= 0)
            {
                Console.WriteLine("Found at pos {0}", pos);
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            // Search by Alphas
            Console.WriteLine("Search for ['h'] ...");
            pos = Search.Easy(alphas, 'h');
            if (pos >= 0)
            {
                Console.WriteLine("Found at pos {0}", pos);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}