using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Правоъгълник от N x N звездички
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            Console.WriteLine(new string('*', n));
        }
    }
}
