using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Статична имплементация на стек (FILO or LIFO)
            var stack = new ArrayStack<int>();

            // Добавяме
            var items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (var item in items)
            {
                stack.Push(item);
            }

            // Печат
            while (stack.Count > 0)
            {
                Console.Write("{0} ", stack.Pop());
            }
        }
    }
}
