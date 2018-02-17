using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
/* 7. Триъгълник на Паскал
Генерирайте и изпечатайте Триъгълника на Паскал по зададена височина h.
Решение: Димитър Минчев
*/
    class Program
    {
        static void Main(string[] args)
        {
            // Входни данни
            int h = int.Parse(Console.ReadLine());

            // Триъгълник на паскал
            long[][] triangle = new long[h + 1][];
            for (int row = 0; row < h; row++)
            {
                triangle[row] = new long[row + 1];
            }
            triangle[0][0] = 1;
            for (int row = 0; row < h - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            // Форматиране и извеждане
            for (int row = 0; row < h; row++)
            {
                Console.Write(new String(' ', h - row - 1));
                foreach (var item in triangle[row])
                Console.Write(item + " ");
                Console.WriteLine();
            }
        }
    }
}
