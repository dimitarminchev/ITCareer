namespace PrintTriangle
{
    internal class Program
    {
        static void Print(int n)
        {
            for (int k = 1; k <= n; k++)
            {
                for (int j = 1; j <= k; j++)
                    Console.Write("{0} ", j);
                Console.WriteLine();
            }

            for (int k = n - 1; k > 0; k--)
            {
                for (int j = 1; j <= k; j++)
                    Console.Write("{0} ", j);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Print(n);
        }
    }
}