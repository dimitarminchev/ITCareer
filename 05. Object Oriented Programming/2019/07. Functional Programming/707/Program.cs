using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _707
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] ime = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(string.Join("\n",ime.Where(x=>x.Length<=n)));
        }
    }
}
