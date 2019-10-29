using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5*. Междувалутен конвертор
            var s = double.Parse(Console.ReadLine());
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            // Проверки
            if (a == "BGN" && b == "USD") Console.WriteLine("{0:f2} USD", s / 1.79549);
            if (a == "BGN" && b == "EUR") Console.WriteLine("{0:f2} EUR", s / 1.95583);
            if (a == "BGN" && b == "GBP") Console.WriteLine("{0:f2} GBP", s / 2.53405);
            if (a == "USD" && b == "BGN") Console.WriteLine("{0:f2} BGN", s * 1.79549);
            if (a == "EUR" && b == "BGN") Console.WriteLine("{0:f2} BGN", s * 1.95583);
            if (a == "GBP" && b == "BGN") Console.WriteLine("{0:f2} BGN", s * 2.53405);
            if (a == "USD" && b == "EUR") Console.WriteLine("{0:f2} EUR", (s * 1.79549) / 1.95583);
            if (a == "USD" && b == "GBP") Console.WriteLine("{0:f2} GBP", (s * 1.79549) / 2.53405);
            if (a == "EUR" && b == "USD") Console.WriteLine("{0:f2} EUR", (s * 1.95583) / 1.79549);
            if (a == "EUR" && b == "GBP") Console.WriteLine("{0:f2} GBP", (s * 1.95583) / 2.53405);
            if (a == "GBP" && b == "USD") Console.WriteLine("{0:f2} EUR", (s * 2.53405) / 1.79549);
            if (a == "GBP" && b == "EUR") Console.WriteLine("{0:f2} GBP", (s * 2.53405) / 1.95583);
        }
    }
}
