namespace Sets
{
    public static class Console
    {
        public static void WriteLine<T>(T output)
        {
            var originalColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(output);
            System.Console.ForegroundColor = originalColor;
        }

        public static void Write<T>(T output)
        {
            var originalColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(output);
            System.Console.ForegroundColor = originalColor;
        }

        public static string ReadLine() => System.Console.ReadLine();
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Universe: ");
            var universe = Console.ReadLine().Split
            (
                        new char[] { ',', ' ' },
                        StringSplitOptions.RemoveEmptyEntries
            ).Select(int.Parse).ToList();

            Console.Write("Subsets: ");
            List<List<int>> subsets = new List<List<int>>();
            var n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                subsets.Add
                (
                    Console.ReadLine().Split
                    (
                        new char[] { ',', ' ' },
                        StringSplitOptions.RemoveEmptyEntries
                    ).Select(int.Parse).ToList()
                );
                n--;
            }

            Queue<List<int>> result = new Queue<List<int>>();

            var sortedSubsets = subsets.OrderByDescending(x => x.Count());
            foreach (var subset in sortedSubsets)
            {
                foreach (var item in subset)
                {
                    if (universe.Contains(item))
                    {
                        result.Enqueue(subset);
                        subset.ForEach(x => universe.Remove(x));
                        break;
                    }
                }
            }

            Console.WriteLine("Solution: ");
            foreach (var item in result)
            {
                Console.Write("{ ");
                Console.Write(string.Join(", ", item));
                Console.WriteLine(" }");
            }
        }
    }
}