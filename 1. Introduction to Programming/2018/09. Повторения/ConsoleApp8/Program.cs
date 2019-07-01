using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8.	Четна и нечетна сума
            int n = int.Parse(Console.ReadLine());
            // Суми
            double even = 0, odd = 0;
            // Четем N на брой числа
            for (int i = 0; i < n; i++)
            {
                var k = int.Parse(Console.ReadLine());
                if (i % 2 == 0) even += k;
                else odd += k;
            }
            if (odd == even)
                Console.WriteLine("Yes\nSum = {0}", odd);
            else
                Console.WriteLine("No\nDiff = {0}",
                    Math.Abs(odd - even));
        }
    }
}
