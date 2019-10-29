using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _701
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Action<string[]> print = x => {
                foreach (string item in x)
                    Console.WriteLine(item);
            };

            print(input);
        }
    }
}
