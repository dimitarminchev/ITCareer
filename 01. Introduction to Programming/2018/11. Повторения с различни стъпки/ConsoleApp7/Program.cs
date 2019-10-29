using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Най-голям общ делител (НОД)
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            // Алгоритъм на Евклид за намиране на НОД
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            Console.WriteLine(a);
        }
    }
}
