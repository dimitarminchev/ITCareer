namespace VertexDistances
{
    public class Program
    {
        private static Dictionary<int, List<int>> nodes;
        private static List<int> currentSolution = new List<int>();
        private static List<List<int>> allSolutions = new List<List<int>>();
        private static List<int> visited = new List<int>();

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            nodes = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                nodes[line[0]] = line.Skip(1).ToList();
            }

            var searchedPaths = new List<(int start, int finish)>();
            for (int i = 0; i < m; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                searchedPaths.Add((line[0], line[1]));
            }

            for (int i = 0; i < m; i++)
            {
                currentSolution = new List<int>();
                allSolutions = new List<List<int>>();
                visited = new List<int>();
                Solve(searchedPaths[i].start, searchedPaths[i].finish);

                var min = (allSolutions.Count > 0) ? allSolutions.Select(x => x.Count).Min() : -1;
                Console.WriteLine($"{{{searchedPaths[0].start},{searchedPaths[0].finish}}} -> {min}");
            }

        }

        private static void Solve(int start, int finish)
        {
            if (start == finish)
            {
                allSolutions.Add(currentSolution.ToList());
                return;
            }

            var toVisit = nodes[start].Where(x => !visited.Contains(x));
            foreach (var node in toVisit)
            {
                visited.Add(start);
                currentSolution.Add(node);
                Solve(node, finish);
                currentSolution.Remove(node);
                visited.Remove(start);
            }
        }
    }
}