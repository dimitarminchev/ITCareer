using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsStack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            stack.Push("Иванчо");
            stack.Push("Марийка");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
        }
    }
}
