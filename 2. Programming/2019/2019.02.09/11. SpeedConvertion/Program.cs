using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SpeedConvertion
{
    class Program
    {
        // 11. Преобразуване на скорост
        static void Main(string[] args)
        {
            // Входни данни: метри, часове, минути, секунди
            double meters = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());
            // сметки
            double time = h * 3600.0 + m * 60.0 + s;
            // скоростта в метри в секунди (m/s)
            Console.WriteLine(Math.Round(meters / time,6));
            // скоростта в километри в час(km / h)
            Console.WriteLine(Math.Round((meters / 1000.0) / (time/3600.0),6));
            // скоростта в мили в час(mp / h)
            Console.WriteLine(Math.Round((meters / 1609.0) / (time/3600.0),6));
        }
    }
}
