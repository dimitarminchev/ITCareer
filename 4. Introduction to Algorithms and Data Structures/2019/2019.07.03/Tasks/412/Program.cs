using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _412
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 5, 4, 3, 2, 1 };
            Console.WriteLine(string.Join(" ",a));
            Sort.Selection(a);
            Console.WriteLine(string.Join(" ", a));
        }
    }
}
