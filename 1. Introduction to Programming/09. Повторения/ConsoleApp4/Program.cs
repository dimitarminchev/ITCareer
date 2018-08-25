using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Сумиране на числа
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                sum = sum + k; // sum += k;
            }
            Console.WriteLine(sum);
        }
    }
}
