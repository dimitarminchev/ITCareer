using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IntegerBox
{
    class Program
    {
        // Integer Box
        static void Main(string[] args)
        {
            Box<int> intBox = new Box<int>();

            // input
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                intBox.Add(int.Parse(Console.ReadLine()));
                n--;
            }

            // output
            intBox.Print();
        }
    }
}
