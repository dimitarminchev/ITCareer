namespace PredicatesList
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 1; i <= N; i++)
            {
                bool isDiv = true;
                foreach (var item in dividers)
                {
                    if (i % item != 0) { isDiv = false; break; }
                }
                if (isDiv)
                    Console.Write(i + " ");
            }
        }
    }
}