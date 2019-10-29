using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        // 04. Умножение на четна и нечетна сума

        // Умножение на четни и нечетни
        static double Multiply(double even, double odd)
        {
            return even * odd;
        }

        // Намира сума на четните числа
        static double EvenSum(int number)
        {
            double sum = 0;
            while(number>0)
            {
                int next = number % 10;
                number /= 10;
                if (next % 2 == 0) sum += next;
            }
            return sum;
        }

        // Намира сума на нечетните числа
        static double OddSum(int number)
        {
            double sum = 0;
            while (number > 0)
            {
                int next = number % 10;
                number /= 10;
                if (next % 2 != 0) sum += next;
            }
            return sum;
        }
        // Главен метод
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(Multiply(EvenSum(n), OddSum(n)));
        }
    }
}
