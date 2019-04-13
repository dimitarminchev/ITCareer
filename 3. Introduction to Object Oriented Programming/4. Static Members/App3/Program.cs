using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(SquareRoot.Sqrt(number));
                n--;
            }
        }
    }
}
