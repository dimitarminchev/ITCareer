using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_TriangleOfNumbers
{
    class Program
    {
        static int[,] matrix;
        static int[,] maxSums;

        static void Main(string[] args)
        {
            // Input
            int n = int.Parse(Console.ReadLine());
            List<int[]> rowList = new List<int[]>();
            for (int i = 0; i < n; i++)
            {
                rowList.Add(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }

            // Convert 
            matrix = new int[n, n + 1];
            maxSums = new int[n, n + 1];
            for (int i = 0; i < n; i++)
            {
                matrix[i, 0] = 0;
                maxSums[i, 0] = 0;
                for (int j = 0; j < n; j++)
                {
                    try
                    {
                        matrix[i, j + 1] = rowList[i][j];
                    }
                    catch
                    {
                        matrix[i, j + 1] = 0;
                    }
                }
            }

            // Process
            maxSums[0, 1] = matrix[0, 1];
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    maxSums[i, j] = matrix[i, j] + Math.Max(maxSums[i - 1, j - 1], maxSums[i - 1, j]);
                }
            }

            // Display
            int[] lastRow = new int[n];
            for (int i = 0; i < n; i++)
            {
                lastRow[i] = maxSums[n - 1, i + 1];
            }
            Console.WriteLine(lastRow.Max());
        }
    }
}