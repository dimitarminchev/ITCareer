using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
/* 6. Морски шах
Напишете програма, която въвежда конфигурация (3х3) на играта Морски Шах. 
По зададената конфигурация трябва да определите дали има победител и ако има – да изведете кой е той. 
Символите в конфигурацията ще са следните: X, O, -, където – отбелязва позиция, на която НЕ Е поставен знак. 
Тестовите примери ще са такива, че да представляват завършена игра.

Решения: Божидар Андонов
*/
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arr = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                string[] temparray = Console.ReadLine().Split(' ').ToArray();
                for (int j = 0; j < 3; j++)
                    arr[i, j] = temparray[j];
            }
            string winner = "-";
            if ((arr[0, 0] == "X" && arr[0, 1] == "X" && arr[0, 2] == "X") ||
                (arr[0, 0] == "X" && arr[1, 0] == "X" && arr[2, 0] == "X") ||
                (arr[0, 0] == "X" && arr[1, 1] == "X" && arr[2, 2] == "X") ||
                (arr[1, 0] == "X" && arr[1, 1] == "X" && arr[1, 2] == "X") ||
                (arr[2, 0] == "X" && arr[2, 1] == "X" && arr[2, 2] == "X") ||
                (arr[0, 1] == "X" && arr[1, 1] == "X" && arr[2, 1] == "X") ||
                (arr[0, 2] == "X" && arr[1, 2] == "X" && arr[2, 2] == "X") ||
                (arr[2, 0] == "X" && arr[1, 1] == "X" && arr[0, 2] == "X")) winner = "X";

            else if ((arr[0, 0] == "O" && arr[0, 1] == "O" && arr[0, 2] == "O") ||
                     (arr[0, 0] == "O" && arr[1, 0] == "O" && arr[2, 0] == "O") ||
                     (arr[0, 0] == "O" && arr[1, 1] == "O" && arr[2, 2] == "O") ||
                     (arr[1, 0] == "O" && arr[1, 1] == "O" && arr[1, 2] == "O") ||
                     (arr[2, 0] == "O" && arr[2, 1] == "O" && arr[2, 2] == "O") ||
                     (arr[0, 1] == "O" && arr[1, 1] == "O" && arr[2, 1] == "O") ||
                     (arr[0, 2] == "O" && arr[1, 2] == "O" && arr[2, 2] == "O") ||
                     (arr[2, 0] == "O" && arr[1, 1] == "O" && arr[0, 2] == "O")) winner = "O";
            else winner = "No one";

            if (winner == "No one") Console.WriteLine("There is no winner");
            else Console.WriteLine($"The winner is: {winner}");
        }
    }
}
