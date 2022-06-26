using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _331
{
    class Program
    {
        static void Main(string[] args)
        {
			// 3.3.1. Обръщане на числа със стека
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                stack.Push(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
