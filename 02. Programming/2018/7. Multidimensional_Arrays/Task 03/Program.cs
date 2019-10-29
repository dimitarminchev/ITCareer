using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
/* 3. Минимум по колони
Напишете програма, която въвежда брой редове и брой колони. 
След което въвежда елементите на двумерен масив (матрица) със съответния брой редове и колони, 
елементите на всеки ред от масива ще са на отделен ред. 
Всички елементи на масива ще са цели числа. Изведете двумерния масив, 
като накрая добавите един нов ред – всеки елемент в този ред показва минималния елемент от колоната, 
която стои над него. При извеждане на масива го форматирайте, 
така че всеки елемент да заема 5 позиции.

Решение: Живко Колев
*/
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            // Входни данни
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            // Печат на масива
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            // Намиране на минимумите по пколони
            for (int col = 0; col < cols; col++)
            {
                int min = 1000;
                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row, col] < min) min = matrix[row, col];
                }
                Console.Write("{0} ", min);
            }
        }
    }
}
