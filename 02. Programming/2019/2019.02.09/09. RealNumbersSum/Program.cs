using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RealNumbersSum
{
    class Program
    {
        // 9. Точна сума на реални числа
        static void Main(string[] args)
        {
            // Въвеждане колко числа ще сумираме
            int n = int.Parse(Console.ReadLine());
            
            // Число с плаваща запетая с голяма точност 
            decimal sum = 0.0M;

            // Цикъл за въвеждане на N на брой числа и намиране на тяхната сума
            while (n > 0)
            {
                sum += decimal.Parse(Console.ReadLine());
                n--;
            }

            // Отпечата намераната сума на числата с голяма точност
            Console.WriteLine(sum);
        }
    }
}
