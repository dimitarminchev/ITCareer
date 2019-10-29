using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IntegerNumberSign
{
    // 02. Знак на цяло число
    class Program
    {
        static void PrintSign(int number)
        {
            if (number > 0)
                Console.WriteLine("The number {0} is positive", number);
            else if (number < 0)
                Console.WriteLine("The number {0} is negative.", number);
            else
                Console.WriteLine("The number {0} is zero.", number);
        }

        static void Main(string[] args)
        {
            PrintSign(int.Parse(Console.ReadLine()));
        }
    }
}
