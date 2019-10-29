using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StringSwap
{
    class Program
    {
        // Strings Swap
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());
            StringSwap<string> strings = new StringSwap<string>(n);
            for (int i = 0; i < n; i++)
            {
                strings.Add(Console.ReadLine());               
            }
            var pos = Console.ReadLine().Split().ToArray();
            int first = int.Parse(pos[0]);
            int second = int.Parse(pos[1]);

            // output
            strings.Swap(first, second);
            strings.Print();
        }
    }
}
