using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        // Алгоритъм за "Прости" числа
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            // Алгоритъм за намиране на прости числа
            for(int k=2;k<=n;k++)
            {
                bool prime = true; // Първоначална хипотеза: К е просто!
                for (int j = 2; j <= Math.Sqrt(k); j++) if (k % j == 0) prime = false;
                // Проверка?
                if (prime) Console.Write(k + " ");
            }
            
        }
    }
}
