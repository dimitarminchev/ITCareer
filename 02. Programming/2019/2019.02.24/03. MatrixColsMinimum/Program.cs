using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatrixColsMinimum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                    matrix[row, col] = line[col];
            }

            // Minimum Matrix
            int[] min = new int[cols];            
            for (int col = 0; col < cols; col++)                
            {
                min[col] = matrix[0, col];
                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row, col] < min[col])
                        min[col] = matrix[row, col];
                }
            }

            // Output
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)          
                    Console.Write("{0, 8}", matrix[row, col]);              
                Console.WriteLine();
            }
            Console.WriteLine("Minimum:");
            for (int col = 0; col < cols; col++)
                Console.Write("{0, 8}", min[col]);
            Console.WriteLine();
        }
    }
}
