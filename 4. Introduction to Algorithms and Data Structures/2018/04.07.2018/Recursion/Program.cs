using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        // Измерване на време на работа на алгоритъма
        private static Stopwatch timer = new Stopwatch();

        // Рекурсия
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            // 1. Факториел
            Console.WriteLine("Factoriel ...");
            timer.Start();
            Console.WriteLine("{0}", Recursion.Fak(n));
            timer.Stop();
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            // 2. Фибоначи
            Console.WriteLine("Fibonacci ...");
            timer.Start();
            Console.WriteLine("{0}", Recursion.Fib(n));
            timer.Stop();
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);
            // for (int i = 0; i < n; i++) Console.Write("{0}, ", Recursion.Fib(i+1));

            // 3. Графика
            Console.WriteLine("Draw ...");
            timer.Start();
            Recursion.Draw(n);
            timer.Stop();
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);
        }
    }
}
