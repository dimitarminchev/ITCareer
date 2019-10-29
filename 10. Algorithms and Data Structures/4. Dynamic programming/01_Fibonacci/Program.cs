using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fibonacci
{
    // Task 1. Fibonacci
    class Program
    {
        // fibonnacci Numbers List
        public static List<int> fib = new List<int>();

        static void Main(string[] args)
        {
            // Solution
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int a = 1, b = 1, c = a + b;
            fib.Add(a);
            fib.Add(b);
            fib.Add(c);
            for (int i = 0; i < n - 3; i++)
            {
                a = b;
                b = c;
                c = a + b;
                fib.Add(c);
            }

            // Print
            Console.WriteLine(string.Join(", ",fib));
        }
    }
}
