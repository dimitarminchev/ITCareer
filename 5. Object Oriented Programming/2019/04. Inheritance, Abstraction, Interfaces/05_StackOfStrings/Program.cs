using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_StackOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the stack
            StackOfStrings<string> stack = new StackOfStrings<string>();

            // Add to the stack
            stack.Push("112");
            stack.Push("911");
            stack.Push("166");

            // Print the stack
            Console.WriteLine("Print: {0}", string.Join(", ",stack));

            // Remove fromm the stack
            while (!stack.IsEmpty())
            {
                Console.WriteLine("Remove: {0}", stack.Pop());
            }
        }
    }
}
