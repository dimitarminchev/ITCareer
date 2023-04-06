namespace NumberDecompositionAsSum
{
    public class Program
    {
        /*
        По дадено естествено число n да се намерят всички възможни не наредени 
        представяния (разбивания) на n като сума от естествени числа
        (не непременно различни). Така например, числото 5 може да се разбие 
        по следните 7 начина:
        5 = 5
        5 = 4 + 1
        5 = 3 + 2
        5 = 3 + 1 + 1
        5 = 2 + 2 + 1
        5 = 2 + 1 + 1 + 1
        5 = 1 + 1 + 1 + 1 + 1
        От клавиатурата се въвежда едно  цяло число n - числото за разбиване.
        */

        static List<int> currentSolution = new List<int>();

        private static void Solve(int n, int index)
        {
            if (n <= 0)
            {
                for (int i = 0; i < currentSolution.Count - 1; i++)
                {
                    if (currentSolution[i] < currentSolution[i + 1])
                    {
                        return;
                    }
                }
                Console.WriteLine(string.Join(" + ", currentSolution));
                return;
            }
            for (int i = n; i > 0; i--)
            {
                currentSolution.Add(i);
                Solve(n - i, index + 1);
                currentSolution.RemoveAt(index);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Solve(n, 0);
        }
    }
}