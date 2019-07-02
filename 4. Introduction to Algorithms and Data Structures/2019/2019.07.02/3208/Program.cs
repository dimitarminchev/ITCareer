using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3208
{
    class Program
    {
        // Problem 8. Обръщане на последователността 
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            // Input
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var number = int.Parse(Console.ReadLine());
                stack.Push(number);
                n--;
            }

            // Print
            foreach (var item in stack)
            {
                Console.Write("{0} ", item);
            }

        }
    }
}
