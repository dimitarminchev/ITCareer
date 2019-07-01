using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Сумиране на секунди
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int s = a + b + c;
            // общо време
            if (s < 60) Console.Write("0:");
            else if (s < 120)
            {
                Console.Write("1:");
                s -= 60;
            }
            else
            {
                Console.Write("2:");
                s -= 120;
            }
            if (s < 10) Console.WriteLine("0" + s);
            else Console.WriteLine(s);

        }
    }
}
