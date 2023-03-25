namespace SunGlasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // Top
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));

            // Middle
            for (int i = 0; i < n - 2; i++)
            {
                var glass = "*" + new string('/', 2 * n - 2) + "*";
                Console.WriteLine(glass + new string('|', n) + glass);
            }

            // Bottom
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
        }
    }
}