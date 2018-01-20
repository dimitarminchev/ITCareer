using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        // 25. Дневна печалба 
        static void Main(string[] args)
        {
            // Входни данни
            int daysinmonth = int.Parse(Console.ReadLine());
            double moneyinday = double.Parse(Console.ReadLine());
            double dollarstoleva = double.Parse(Console.ReadLine());

            // Математическо операции
            var meschnazaplata = daysinmonth * moneyinday;
            var godishendohod = (meschnazaplata * 12) + (meschnazaplata * 2.5);
            var danyk = 0.25 * godishendohod;
            var godishendanyk = godishendohod - danyk;
            var chistgodishendohod = godishendanyk * dollarstoleva;
            var srednapechalbanaden = chistgodishendohod / 365;

            // Изходни данни
            Console.WriteLine("{0:f2}", srednapechalbanaden);
        }
    }
    }
}
