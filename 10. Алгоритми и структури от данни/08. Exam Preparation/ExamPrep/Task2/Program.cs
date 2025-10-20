namespace Task2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    public class Program
    {
        private static int n, m;
        private static int[,] matrix;
        private static bool[,] visited;

        private static void DFS(int x, int y)
        {
            visited[x, y] = true;

            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    int nx = x + dx;
                    int ny = y + dy;

                    if (nx >= 0 && nx < n && ny >= 0 && ny < m)
                    {
                        if (matrix[nx, ny] == 1 && !visited[nx, ny])
                        {
                            DFS(nx, ny);
                        }
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            n = int.Parse(input[0]);
            m = int.Parse(input[1]);

            matrix = new int[n, m];
            visited = new bool[n, m];

            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }

            int fireCount = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == 1 && !visited[i, j])
                    {
                        DFS(i, j);
                        fireCount++;
                    }
                }
            }

            Console.WriteLine(fireCount);
        }
       
    }
}
