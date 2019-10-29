using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem24
{
    class Program
    {
        /* Problem 24. ArrayStack */
        static void Main(string[] args)
        {
            // Създаване на стека
            ArrayStack<int> stack = new ArrayStack<int>();

            // Добаване на елементи
            stack.Push(300);
            stack.Push(4400);
            stack.Push(100);

            // Информация
            Console.WriteLine("Count = {0}", stack.Count);
            Console.WriteLine("Remove = {0}", stack.Pop());
            Console.WriteLine("Count = {0}", stack.Count);

        }
    }
}
