using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Числа до 1000, завършващи на 7
            for (int i = 1; i <= 1000; i++)
            {
                if(i%10 == 7)
                Console.Write(i+" ");
            }
        }
    }
}
