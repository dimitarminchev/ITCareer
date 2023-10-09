namespace VertexDistances
{
    public class Program
    {
        private static Dictionary<int, List<int>> graphNodes = new Dictionary<int, List<int>>();

        private static new List<int> currentSolution = null;

        private static new List<List<int>> allSolution = null;

        private static new List<int> visitedNodes = null;

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var values = Console.ReadLine()
                            .Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

                graphNodes[values[0]] = values.Skip(1).ToList(); // 0 => key <int>, 1 = nodes <List<int>>
            }

            for (int i = 0; i < p; i++)
            {
                currentSolution = new List<int>();
                allSolution = new List<List<int>>();
                visitedNodes = new List<int>();

                var values = Console.ReadLine()
                            .Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

                Solve(values[0], values[1]); // 0 => start, 1 => finish

                var min = (allSolution.Count > 0) ? allSolution.Select(x => x.Count).Min() : -1;
                Console.WriteLine($"{{{values[0]},{values[1]}}} -> {min}");
            }
        }

        private static void Solve(int start, int finish)
        {
            if (start == finish)
            {
                allSolution.Add(currentSolution.ToList());
                return;
            }

            var nodesToVisit = graphNodes[start].Where(x => !visitedNodes.Contains(x));

            foreach (var node in nodesToVisit)
            {
                visitedNodes.Add(start);
                currentSolution.Add(node);

                Solve(node, finish);

                visitedNodes.Remove(start);
                currentSolution.Remove(node);
            }
        }

    }
}