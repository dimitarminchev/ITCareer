using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _615
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            var line = Console.ReadLine().Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (line[0] != "END")
            {
                switch (line[0])
                {
                    case "Push":
                        stack.Push(line.Skip(1).Select(int.Parse).ToArray());
                        break;
                    case "Pop":
                        Helper.WriteLine(stack.Pop());
                        break;
                }
                line = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            // TODO: Print The Collection 2 Times
        }
    }
}
