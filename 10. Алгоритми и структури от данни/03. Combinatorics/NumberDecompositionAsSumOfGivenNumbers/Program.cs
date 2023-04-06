namespace NumberDecompositionAsSumOfGivenNumbers
{
    public class Program
    {
        /*
        Нека са дадени пощенски марки от 2, 5 и 10 лева.
        Трябва да се изпратим колет на стойност 20 лева. 
        Всички възможности (общо 6 на брой) за образуване на тази сума са:
        20 = 10 + 10
        20 = 10 + 5 + 5
        20 = 10 + 2 + 2 + 2 + 2 + 2
        20 = 5 + 5 + 5 + 5
        20 = 5 + 5 + 2 + 2 + 2 + 2 + 2
        20 = 2 + 2 + 2 + 2 + 2 + 2 + 2 + 2 + 2 + 2
        От клавиатурата последователно се въвеждат  числата n,
        стойността на колета, m - броя на наличните марки, и m на брой числа,
        стойностите на марките. Всички числа са цели числа.
         */

        static int[] given;
        static List<int> currentSolution = new List<int>();

        private static void Solve(int n, int index)
        {
            if (n < 0)
            {
                return;
            }
            if (n == 0)
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
            for (int i = 0; i < given.Length; i++)
            {
                currentSolution.Add(given[i]);
                Solve(n - given[i], index + 1);
                currentSolution.RemoveAt(index);
            }
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            given = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Solve(input[0], 0);
        }
    }
}