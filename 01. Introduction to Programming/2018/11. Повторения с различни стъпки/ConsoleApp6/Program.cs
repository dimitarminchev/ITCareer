using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Число в диапазона от 1 до 100
            int n = 0;
            do
            {                
                n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 100)
                Console.WriteLine("Invalid number!");
            }
            while (n < 1 || n > 100);
            Console.Write(n);
        }
    }
}
