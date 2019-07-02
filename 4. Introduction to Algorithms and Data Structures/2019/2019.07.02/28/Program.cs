using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Program
    {
        // 28. LinkedStack
        static void Main(string[] args)
        {
            // FILO or LIFO
            LinkedStack<int> stack = new LinkedStack<int>();

            Console.WriteLine("Count = {0}", stack.Count); // 0

            stack.Push(112);
            stack.Push(911);
            stack.Push(166);
            stack.Push(160);
            stack.Push(150);

            foreach (var item in stack)
                Console.Write("{0} ", item);
            Console.WriteLine();

            Console.WriteLine("Count = {0}", stack.Count); // 5
        }
    }
}
