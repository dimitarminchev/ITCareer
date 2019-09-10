using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fibonacci
{
    // Fibonacii
    class Program
    {
        public static int Fib(int n)
        {
            if (n == 1 || n == 2) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        static void Main(string[] args)
        {
            int n = 5;
            int fibN = Fib(n);
            Console.WriteLine(fibN);
        }
       
    }
}
