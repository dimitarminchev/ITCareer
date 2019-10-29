using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        // Odd/Even Sample
        static void Main(string[] args)
        {
            OddEven sample = new OddEven();
            Console.WriteLine("Is (1) Odd? \t{0}", sample.IsOdd(1));
            Console.WriteLine("Is (1) Even? \t{0}", sample.IsEven(1));
            Console.WriteLine("Is (2) Odd? \t{0}", sample.IsOdd(2));
            Console.WriteLine("Is (2) Even? \t{0}", sample.IsEven(2));
        }
    }
}
