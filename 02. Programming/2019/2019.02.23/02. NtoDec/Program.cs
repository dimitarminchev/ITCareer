using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NtoDec
{
    class Program
    {
        static string Convert(int number, int target)
        {
            double sum = 0, pow = 0;
            while (number > 0)
            {
                var current = number % 10;
                sum += current * Math.Pow(target, pow);
                pow++;
                number /= 10;
            }
            return sum.ToString();
        }

        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int target = line[0]; // бройна система
            int number = line[1]; // число за коонвертиране

            Console.WriteLine(Convert(number, target));
        }
    }
}
