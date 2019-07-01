using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        // 2. Цена за транспорт
        static void Main(string[] args)
        {
            // Входни данни
            var km = long.Parse(Console.ReadLine());
            var t = Console.ReadLine();
            double price = 0;
            // Такси (дневна: 0.7 лв (първоначална) + км * 0.79 лв/км)
            if (km < 20 && t == "day") price = 0.7 + km * 0.79;
            // Такси (нощна: 0.7 лв (първоначална) + км * 0.90 лв/км)
            else if (km < 20 && t == "night") price = 0.7 + km * 0.9;
            // Автобус (км * 0.09 лв/км)
            else if (km >= 20 && km < 100) price = km * 0.09;
            // Влак  (км * 0.06 лв/км)
            else if (km >= 100) price = km * 0.06;
            // Отпечаваме цената
            Console.WriteLine( price);
        }
    }
}
