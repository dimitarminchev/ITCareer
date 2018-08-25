using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9. Къщата
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0) stars++;
            for (int i = 0; i < (n + 1) / 2; i++)
            { 
                // Покрив на къщата
                var padding = (n - stars) / 2;
                Console.Write(new string('-', padding));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', padding));
                stars = stars + 2;
            }
            for (int i = 0; i< n / 2; i++)
            {
                // Тяло на къщата
                Console.Write("|");
                Console.Write(new string('*', n-2));
                Console.WriteLine("|");
            }

        }
    }
}
