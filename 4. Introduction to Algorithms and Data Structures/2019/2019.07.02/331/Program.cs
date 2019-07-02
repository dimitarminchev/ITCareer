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
