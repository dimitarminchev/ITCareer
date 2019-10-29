using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Информация за скоростта
            var n = double.Parse(Console.ReadLine());
            if (n <= 10) Console.WriteLine("slow");
            else if (n <= 50) Console.WriteLine("average");
            else if (n <= 150) Console.WriteLine("fast");
            else if (n <= 1000) Console.WriteLine("ultra fast");
            else Console.WriteLine("extremely fast");
        }
    }
}
