using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _521
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mo = new MathOperations();
            Console.WriteLine("{0}", mo.Add(1, 2));
            Console.WriteLine("{0}", mo.Add(1.1, 2.2, 3.3));
            Console.WriteLine("{0}", mo.Add(1m, 2m, 3m));
        }

    }
}
