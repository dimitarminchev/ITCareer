using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_MatrixRegions
{
    class Program
    {
        static char[,] board;
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = 0;
            for (int i = 0; i < rows; i++)
            {
                string row = Console.ReadLine();
                if (board == null)
                {
                    cols = row.Length;
                    board = new char[rows, cols];
                }
                for (int j = 0; j < row.Length; j++)
                {
                    board[i, j] = row[j];
                }
            }

            bool[,] visited = new bool[rows, cols];
            Dictionary<char, int> regions = new Dictionary<char, int>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!visited[i, j])
                    {
                        if (!regions.ContainsKey(board[i, j]))
                        {
                            regions.Add(board[i, j], 0);
                        }
                        regions[board[i, j]]++;
                        TraverseRegion(board[i, j], i, j, visited);
                    }
                }
            }

            Console.WriteLine("Regions: {0}", regions.Sum(x => x.Value));
            foreach (var valuePair in regions.OrderBy(x => x.Key))
            {
                Console.WriteLine("Letter '{0}': {1} regions", valuePair.Key, valuePair.Value);
            }
        }

        static void TraverseRegion(char currentChar, int row, int col, bool[,] visited)
        {
            visited[row, col] = true;
            List<Tuple<int, int>> possibleDirections = GetPossibleDirections(currentChar, row, col, visited);
            foreach (var direction in possibleDirections)
            {
                TraverseRegion(currentChar, direction.Item1, direction.Item2, visited);
            }
        }

        static List<Tuple<int, int>> GetPossibleDirections(char currentChar, int row, int col, bool[,] visited)
        {
            List<Tuple<int, int>> possibleDirections = new List<Tuple<int, int>>();
            if (row - 1 >= 0)
            {
                if (!visited[row - 1, col] && board[row - 1, col] == currentChar)
                {
                    possibleDirections.Add(new Tuple<int, int>(row - 1, col));
                }
            }
            if (row + 1 < board.GetLength(0))
            {
                if (!visited[row + 1, col] && board[row + 1, col] == currentChar)
                {
                    possibleDirections.Add(new Tuple<int, int>(row + 1, col));
                }
            }
            if (col - 1 >= 0)
            {
                if (!visited[row, col - 1] && board[row, col - 1] == currentChar)
                {
                    possibleDirections.Add(new Tuple<int, int>(row, col - 1));
                }
            }
            if (col + 1 < board.GetLength(1))
            {
                if (!visited[row, col + 1] && board[row, col + 1] == currentChar)
                {
                    possibleDirections.Add(new Tuple<int, int>(row, col + 1));
                }
            }
            return possibleDirections;
        }
    }
}
