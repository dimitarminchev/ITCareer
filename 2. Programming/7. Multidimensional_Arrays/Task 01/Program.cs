using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
/* 1. Вход и изход на матрица
Напишете програма, която въвежда брой редове и брой колони. 
След което въвежда елементите на двумерен масив (матрица) със съответния брой редове и колони. 
Всички елементи на масива ще са цели числа. Изведете получения двумерен масив.

Решение: Петър Колев
 */
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[,] matrix = new int[r, c];
            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
