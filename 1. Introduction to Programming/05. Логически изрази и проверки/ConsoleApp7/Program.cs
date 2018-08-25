using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Време плюс 15 минути
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            m = m + 15;
            // Надхвърляме ли 60 минути
            if (m >= 60)
            {
                h += 1;  // h = h + 1;
                m -= 60; // m = m - 60;
            }
            // Надхвърляме ли денонощие
            if (h > 23) h -= 24;
            // Проверка за водеща нула при минути по-малки от 10
            if(m < 10) Console.WriteLine("{0}:0{1}", h, m);
            else Console.WriteLine("{0}:{1}",h,m);
        }
    }
}
