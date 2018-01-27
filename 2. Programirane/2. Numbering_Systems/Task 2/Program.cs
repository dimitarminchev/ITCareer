using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
/* Задача 2.	
   Запишете най-малкото и най-голямото двуцифрено число в P-ична бройна система, 
   запишете в същата бройна система на колко е равна тяхната разлика.
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("System = ");
            int P = int.Parse(Console.ReadLine());
            var MIN = P;
            var MAX = Math.Pow(P, 2f) - 1f;
            var DIFF = MAX - MIN;
            Console.WriteLine("MIN = {0}", MIN);
            Console.WriteLine("MAX = {0}", MAX);
            Console.WriteLine("DIFF = {0}", DIFF);
        }
    }
}
