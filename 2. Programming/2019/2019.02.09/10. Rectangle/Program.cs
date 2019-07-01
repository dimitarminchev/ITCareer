using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rectangle
{
    class Program
    {
        // 10. Правоъгълник
        static void Main(string[] args)
        {
            // Входни данни
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            // Сметки
            double p = 2 * (a + b);
            double s = a * b;
            decimal d = (decimal)Math.Sqrt(Math.Pow(a, 2.0) + Math.Pow(b, 2.0));
            // Отпечатаме резилтата
            Console.WriteLine("p = {0}", p);
            Console.WriteLine("s = {0}", s);
            Console.WriteLine("d = {0}", d);
        }
    }
}
