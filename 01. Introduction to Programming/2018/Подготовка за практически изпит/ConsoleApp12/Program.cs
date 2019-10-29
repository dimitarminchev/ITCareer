using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        // 12. Магически числа 
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            for (long magic = 111111; magic <= 999999; magic++)
            {
                long pro = 1, part = magic;
                while(part > 0)
                {
                    pro *= part % 10;
                    part /= 10;
                }
                if (pro == n) Console.Write("{0} ", magic);
            }
        }
    }
}
