using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        // 26. Фирма 
        static void Main(string[] args)
        {
            // Входни данни
            int neobhodimichasove = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int brizvynrednorboteshti = int.Parse(Console.ReadLine());

            // Математически операции
            var chasovezarabota = (days - (0.1 * days)) * 8;
            var chasovezaizvynrednoraboteshti = brizvynrednorboteshti * 2 * days;
            var obshtochasove = Math.Floor(chasovezarabota + chasovezaizvynrednoraboteshti);

            // Изходни данни
            if (obshtochasove >= neobhodimichasove)
            {
                var ostatyk = obshtochasove - neobhodimichasove;
                Console.WriteLine("Yes!{0} hours left.", ostatyk);
            }
            else
            {
                var ostatyk = neobhodimichasove - obshtochasove;
                Console.WriteLine("Not enough time!{0} hours needed.", ostatyk);
            }
        }
    }
}
