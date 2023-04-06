namespace NumberDecompositionAsMultiplication
{
    public class Program
    {
        /*
        По дадено естествено число n да се намерят всички възможни не наредени 
        представяния (разбивания) на n като произведение от естествени числа 
        (не непременно различни). От клавиатурата се въвежда едно  цяло число n.
         */

        static List<int> currentSolution = new List<int>();

        private static void Solve(int n, int index)
        {
            if (n <= 1) // diff.1
            {
                for (int i = 0; i < currentSolution.Count - 1; i++)
                {
                    if (currentSolution[i] < currentSolution[i + 1])
                    {
                        return;
                    }
                }
                Console.WriteLine(string.Join(" * ", currentSolution)); // diff.2
                return;
            }
            for (int i = n; i > 1; i--) // dif.3
            {
                if (n % i == 0) // dif.4
                {
                    currentSolution.Add(i);
                    Solve(n / i, index + 1); // diff.5
                    currentSolution.RemoveAt(index);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Solve(n, 0);
        }
    }
}