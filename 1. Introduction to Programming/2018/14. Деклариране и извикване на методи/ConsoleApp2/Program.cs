using System;

namespace ConsoleApp2
{
    class Program
    {
        // 02. Знак на цяло число
        static void PrintSign(int number)
        {
            if (number > 0) Console.WriteLine("The number {0} is positive.", number);
            else if (number < 0) Console.WriteLine("The number {0} is negative.", number);
            else Console.WriteLine("The number {0} is zero.", number);
        }

        // Главен метод
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}
