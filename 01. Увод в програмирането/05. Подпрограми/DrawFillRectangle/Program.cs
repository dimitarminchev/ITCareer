namespace DrawFillRectangle
{
    internal class Program
    {
        static void Print(int n)
        {
            Console.WriteLine(new string('-', n * 2));
            for (int i = 0; i <= n - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j <= (n - 2); j++)
                    Console.Write("\\/");
                Console.WriteLine("-");
            }
            Console.WriteLine(new string('-', n * 2));
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Print(n);
        }
    }
}