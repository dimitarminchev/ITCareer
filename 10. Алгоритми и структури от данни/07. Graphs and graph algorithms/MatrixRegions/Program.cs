namespace MatrixRegions
{
    public class Program
    {
        private static int n;
        private static int m;
        private static char[][] matrix;
        private static bool[,] visited;
        private static Dictionary<char, int> regions = new Dictionary<char, int>();
       
        public static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            matrix = new char[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }
            m = matrix[0].Length;
            visited = new bool[n, m];

            (int i, int j) coords = (0, 0);
            while (!IsAllVisited(ref coords))
            {
                if (regions.ContainsKey(matrix[coords.i][coords.j]))
                {
                    regions[matrix[coords.i][coords.j]] = regions[matrix[coords.i][coords.j]] + 1;
                }
                else
                {
                    regions[matrix[coords.i][coords.j]] = 1;

                }
                Solve(coords.i, coords.j, matrix[coords.i][coords.j]);
            }

            Console.WriteLine($"Total: {regions.Values.Sum()}");
            foreach (var record in regions.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{record.Key} -> {record.Value}");
            }
        }

        private static bool IsAllVisited(ref (int x, int y) newCoords)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!visited[i, j])
                    {
                        newCoords.x = i;
                        newCoords.y = j;
                        return false;
                    }
                }
            }
            return true;
        }

        private static void Solve(int i, int j, char currentChar)
        {
            if (i >= 0 && i < n && j >= 0 && j < m && !visited[i, j] && matrix[i][j] == currentChar)
            {
                visited[i, j] = true;
                Solve(i + 1, j, currentChar);
                Solve(i - 1, j, currentChar);
                Solve(i, j + 1, currentChar);
                Solve(i, j - 1, currentChar);
            }
            else
            {
                return;
            }
        }
    }
}