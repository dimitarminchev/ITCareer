using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StringCounter
{
    class Program
    {
        // String Box Counter
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            // input
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }
            string element = Console.ReadLine();

            // print
            Console.WriteLine(box.BiggerThan(element));
        }
    }
}
