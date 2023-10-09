namespace GraphCycle
{
    public class Program
    {
        private static Dictionary<char, List<char>> nodes = new Dictionary<char, List<char>>();
        private static List<char> currentSolution = new List<char>();
        private static List<char> visited = new List<char>();
        private static bool flag = false;

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-').Select(char.Parse).ToArray();
                if (!nodes.ContainsKey(input[0]))
                {
                    nodes[input[0]] = new List<char>();
                }
                if (!nodes.ContainsKey(input[1]))
                {
                    nodes[input[1]] = new List<char>();
                }
                nodes[input[0]].Add(input[1]);
                nodes[input[1]].Add(input[0]);
            }

            currentSolution.Add(nodes.First().Key);
            visited.Add(nodes.First().Key);
            Solve(nodes.First().Key);

            Console.WriteLine("Cycled: " + (flag ? "No" : "Yes"));
        }

        private static void Solve(char start)
        {
            if (currentSolution.Count != currentSolution.Distinct().Count())
            {
                flag = true;
                return;
            }
            
            var copy = nodes[start];
            if (currentSolution.Count > 1)
            {
                copy.Remove(currentSolution[currentSolution.Count - 2]);
            }

            var toVisit = copy.ToList();
            foreach (var node in toVisit)
            {
                visited.Add(node);
                currentSolution.Add(node);
                Solve(node);
                currentSolution.Remove(node);
                visited.Remove(node);
            }
        }
    }
}