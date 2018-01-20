using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Факториел
            int n = int.Parse(Console.ReadLine());
            int fak = 1;
            while(n>0)
            {
                fak *= n;
                n--;
            }
            Console.WriteLine(fak);
        }
    }
}
