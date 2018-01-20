using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Правоъгълник от 10 x 10 звездички
            for (int i = 0; i < 10; i++)
            Console.WriteLine(new string('*', 10));
        }
    }
}
