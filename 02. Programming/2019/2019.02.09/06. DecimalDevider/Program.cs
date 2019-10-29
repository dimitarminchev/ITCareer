using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DecimalDevider
{
    class Program
    {
        // 6. Делене на цели числа
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0; 
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                // Console.WriteLine("{0} / {1} = {2} и ост. {3}", a, b, a / b, a % b);
                sum += (a % b);
            }
            Console.WriteLine(sum);
        }
    }
}
