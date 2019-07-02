using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        //  Задача: Съответстващи си квадратни скоби
        static void Main(string[] args)
        {
            // Stack
            Stack<int> stack = new Stack<int>();

            // Input
            // 1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5

            string expression = Console.ReadLine();

            // Process
            for (int index = 0; index < expression.Length; index++)
            {
                char ch = expression[index];
                if (ch == '(')
                    stack.Push(index);
                else if (ch == ')')
                {
                    int startIndex = stack.Pop();
                    int length = index - startIndex + 1;
                    string contents = expression.Substring(startIndex, length);
                    Console.WriteLine(contents);
                }
            }

        }
    }
}
