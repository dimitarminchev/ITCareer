using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        // 28. Болница 
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int tr = 0, unt = 0, doctors = 7;
            for (int i = 1; i <= n; i++)
            {
                var day = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && unt > tr) doctors++;
                if (day <= doctors)
                {
                    tr += day;
                }
                else
                {
                    tr += doctors;
                    unt += (day - doctors);
                }   
            }
            Console.WriteLine("Treated patients: {0}", tr);
            Console.WriteLine("Untreated patients: {0}", unt);
        }
    }
}
