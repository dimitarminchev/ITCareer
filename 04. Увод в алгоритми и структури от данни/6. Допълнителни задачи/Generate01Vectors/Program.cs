namespace Generate01Vectors
{
    internal class Program
    {
        private static void Print(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }

        private static void Gen01(int n, int[] a, int i)
        {
            if (i == n)
            {
                Print(a, n);
                return;
            }
            a[i] = 0;
            Gen01(n, a, i + 1);
            a[i] = 1;
            Gen01(n, a, i + 1);
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Gen01(n, a, 0);
        }
    }
}