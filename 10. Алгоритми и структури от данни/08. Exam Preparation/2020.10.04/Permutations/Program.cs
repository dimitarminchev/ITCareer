namespace Permutations
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            while (!(n > 0 && n < 101))
            {
                n = int.Parse(Console.ReadLine());
            }

            Permute(0, n);
        }

        static List<int> currentSolution = new List<int>();

        private static void Permute(int ind, int n)
        {
            if (currentSolution.Count == n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0,2}", currentSolution[i]);
                }
                Console.WriteLine();
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (!currentSolution.Contains(i))
                {
                    currentSolution.Add(i);
                    Permute(ind + 1, n);
                    currentSolution.Remove(i);
                }
            }

        }
    }
}