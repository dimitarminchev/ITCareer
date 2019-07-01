using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        // 14. Поспаливата котка Том 
        static void Main(string[] args)
        {
            // Вход
            int days = int.Parse(Console.ReadLine());            
            // Математика
            int playtime = (365 - days) * 63 + days * 127;
            int h = Math.Abs((30000 - playtime) / 60);
            int m = Math.Abs((30000 - playtime) % 60);
            // Изход
            if (playtime < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",h,m);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",h,m);
            }
        }
    }
}
