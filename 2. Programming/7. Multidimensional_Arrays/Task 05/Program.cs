using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
/* 5. Максимална площадкa
Напишете програма, която въвежда квадратна матрица с цели числа. 
Намерете максималната подматрица с размери 2х2 и я отпечайте в конзолата. 
Под максимална площадка се разбира такава подматрица с размер 2х2, 
така че сумата от нейните елементи да е максимална.

Решение: Димитър Минчев
*/
    class Program
    {
        static void Main(string[] args)
        {
            // Входни данни
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows,cols];
            for (int row = 0; row < rows; row++)
            {
                var line = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                for (int col = 0; col < cols; col++) matrix[row, col] = line[col];
            }

            // Необходими променливи
            int maxSum = 0, maxRow = -1, maxCol = -1;

            // Намиране на максимална площадка 2x2
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int tempSum = matrix[row, col] + matrix[row + 1, col] + 
                                  matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        maxRow = row;
                        maxCol = col;
                        Console.WriteLine("Sum {0} at [{1},{2}]", maxSum, maxRow, maxCol);
                    }
                }
            }

            // Отпечатване на максималната пощадка
            for (int row = maxRow; row < maxRow + 2; row++)
            {
                for (int col = maxCol; col < maxCol + 2; col++)
                Console.Write(matrix[row, col] + " ");
                Console.WriteLine();
            }
        }
    }
}
