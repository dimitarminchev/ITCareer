using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
/* 5. Десетично към шестнадесетично и двоично
Напишете програма, която преобразува десетично число в шестнадесетично и двоично число и го извежда.
*/
    class Program
    {
        // Решение: Божидар Андонов
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            string b = Convert.ToString(a, 16).ToUpper();
            string c = Convert.ToString(a, 2).ToUpper();
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
