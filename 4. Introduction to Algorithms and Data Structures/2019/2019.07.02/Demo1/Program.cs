using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        // Cмяна на цвета на конзолата
        private static void WriteLine(string text)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = color;
        }

        // Задача: Undo списък от адреси
        static void Main(string[] args)
        {
            // .NET Stack
            Stack<string> stack = new Stack<string>();

            // Input
/*
www.softuni.bg
www.judge.softuni.bg
www.kids.softuni.bg
back
back
exit
*/
            string previous = null;
            string command = Console.ReadLine();
            while (true)
            {
                if (command == "exit") break;
                if (command == "back")
                {
                    if (stack.Count != 0)
                    {
                        WriteLine(stack.Pop());
                    }
                    previous = null;
                }
                else
                {
                    if (previous != null)
                    {
                        stack.Push(previous);
                    }
                    previous = command;
                }
                command = Console.ReadLine();
            }
        }
    }
}
