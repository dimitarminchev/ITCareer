namespace Sets
{
    /// <summary>
    /// Програма
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // Вселената
            List<int> universe = new List<int>();

            // Подмножества
            List<List<int>> sets = new List<List<int>>();

            // Входни данни: Input.txt
            using (StreamReader input = new StreamReader("Input.txt"))
            {
                // Вселената
                string line = input.ReadLine();
                System.Console.WriteLine(line);
                universe = line.Split(",").Select(int.Parse).ToList();

                // Брой подмножества
                line = input.ReadLine();
                System.Console.WriteLine(line);
                int n = int.Parse(line);

                // Подмножества
                for (int i = 0; i < n; i++)
                {
                    line = input.ReadLine();
                    System.Console.WriteLine(line);
                    sets.Add(line.Split(",").Select(int.Parse).ToList());
                }
            }

            // Сортирани подмножества
            var sortedSets = sets.OrderByDescending(x => x.Count());

            // Резултат
            Queue<List<int>> result = new Queue<List<int>>();

            // Обхождане
            foreach (var subSets in sortedSets)
            {
                foreach (var sub in subSets)
                {
                    if (universe.Contains(sub))
                    {
                        result.Enqueue(subSets);
                        subSets.ForEach(x => universe.Remove(x));
                        break;
                    }
                }
            }

            // Печат
            Console.WriteLine("(" + result.Count() + ")");
            foreach (var item in result)
            {
                Console.WriteLine("{ " + string.Join(", ", item) + " }");
            }
        }
    }
}