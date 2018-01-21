using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
/* Задача.4.	
   Колко са двуцифрените числа в p-ична бройна система. 
   Едноцифрените да не се броят като двуцифрени с първа цифра 0!
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("System = ");
            int P = int.Parse(Console.ReadLine());
            var MIN = P;
            var MAX = Math.Pow(P, 2f) - 1f;
            var COUNT = MAX - MIN;
            Console.WriteLine("COUNT = {0}", COUNT);
        }
    }
}
