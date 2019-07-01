using System;

namespace Task_19
{
/* 19. Обръщане на знаци
Напишете програма, която въвежда 3 знака и ги изведете в обратен ред.
*/
    class Program
    {
        // Решение: Павел Недков 
        static void Main(string[] args)
        {
            string symbol1 = Console.ReadLine();
            string symbol2 = Console.ReadLine();
            string symbol3 = Console.ReadLine();
            Console.Write($"{symbol3}{symbol2}{symbol1}");
        }
    }
}
