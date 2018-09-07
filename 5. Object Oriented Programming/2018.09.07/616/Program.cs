using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _616
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            var rocks = Console.ReadLine()
                        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
            // The Lake
            Lake lake = new Lake(rocks);

            // Output
            Console.WriteLine(string.Join(", ", lake));
            Console.ReadKey();
        }
    }
}
