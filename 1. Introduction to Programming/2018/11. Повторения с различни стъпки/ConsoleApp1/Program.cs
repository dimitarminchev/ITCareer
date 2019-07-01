using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Числата от 1 до N през 3
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
