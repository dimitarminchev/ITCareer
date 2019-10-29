using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Max3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // print
            Console.WriteLine(String.Join(" ", nums.OrderByDescending(x => x).Take(3)));
        }
    }
}
