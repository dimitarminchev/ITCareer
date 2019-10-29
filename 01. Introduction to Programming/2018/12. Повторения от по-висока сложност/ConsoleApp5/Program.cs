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
            // 5. Числа на Фибоначи
            int n = int.Parse(Console.ReadLine());
            if(n<2)
            {
                Console.WriteLine("1");
                return;
            }
            // Метод на плаващият прозорец
            int a = 1, b = 1, c = a + b;
            while(n-2 > 0)
            {               
                a = b;
                b = c;
                c = a + b;
                n--;
            }
            Console.WriteLine(c);
        }
    }
}
