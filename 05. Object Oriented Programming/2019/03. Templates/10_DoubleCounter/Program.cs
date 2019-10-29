using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DoubleCounter
{
    class Program
    {
        // Double Box Counter
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();

            // input
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }
            double element = double.Parse(Console.ReadLine());

            // print
            Console.WriteLine(box.BiggerThan(element));
        }
    }
}
