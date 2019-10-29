using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        // 02. Степен на число
        static double RiseNumber(double a, int b)
        {
            double result = a;
            for (int i = 1; i < b; i++) result *= a;
            return result;
        }

        // Главен метод
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine(RiseNumber(a,b));
        }
    }
}
