using System;

namespace _1._Fibonacii
{
    class Program
    {
        // Рекурсивен метод за намиране на фибоначи
        static int fib(int n)
        {
            if (n == 1 || n == 2) return 1;
            else return fib(n - 2) + fib(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine( fib(n) );
        }
    }
}
