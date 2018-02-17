using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
/* 2. Средноаритметично по редове
Напишете програма, която въвежда брой редове и брой колони. 
След което въвежда елементите на двумерен масив (матрица) със съответния брой редове и колони. 
Всички елементи на масива ще са цели числа. 
Изведете двумерния масив, като на всеки ред прибавите по 1 елемент в края му, 
който да бъде равен на средноаритметичното от всички елементи в съответния ред. 
При извеждане на масива го форматирайте, така че всеки елемент да заема 10 позиции.

Решение: Валентин Хаджиминов
*/
    class Program
    {
        static void Main(string[] args)
        {
            // Входни данни
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            // Четене на масива
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Изчисляване и отпечатване на средното аритметично
            for (int i = 0; i < rows; i++)
            {
                double avg = 0;
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0,10}", matrix[i, j]);
                    avg += matrix[i, j];
                }
                avg = avg / cols;
                Console.WriteLine("{0, 10}", avg);
            }
        }
    }
}
