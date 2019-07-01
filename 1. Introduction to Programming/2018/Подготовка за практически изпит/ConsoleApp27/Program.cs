using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        // 27. Хотелска стая
        static void Main(string[] args)
        {
            var m = Console.ReadLine();
            var d = int.Parse(Console.ReadLine());
            double price1 = 0, price2 = 0;
            // Проверки 
            if (m == "May" || m == "October")
            {
                price1 = d * 50.0;
                price2 = d * 65.0;
                if (d > 7 && d <= 14) price1 -= (price1*0.05);
                else if(d>14) price1 -= (price1 * 0.3);
            }
            if (m == "June" || m == "September")
            {
                price1 = d * 75.2;
                price2 = d * 68.7;
                if (d > 14) price1 -= (price1 * 0.2);
            }
            if (m == "July" || m =="August")
            {
                price1 = d * 76.0;
                price2 = d * 77.0;
            }
            if(d>14) price2 -= (price2 * 0.1);
            // Изходни данни
            Console.WriteLine("Apartment: {0:f2} lv.", price2);
            Console.WriteLine("Studio: {0:f2} lv.", price1);
        }
    }
}
