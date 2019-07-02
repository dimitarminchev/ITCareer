using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStack
{
    class Program
    {
        // LinkedStack = Свързан стек
        static void Main(string[] args)
        {
            // Create
            var stack = new LinkedStack<int>();

            // Input
            stack.Push(112);
            stack.Push(911);
            stack.Push(166);
            stack.Push(160);
            stack.Push(150);

            // Print
            Console.WriteLine(string.Join(" ", stack));
            Console.WriteLine("Count = {0}", stack.Count); 
        }
    }
}
