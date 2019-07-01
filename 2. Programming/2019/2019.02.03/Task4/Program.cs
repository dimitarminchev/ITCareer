using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Task 4.
Колко са двуцифрените числа в p-ична бройна система.
*/
namespace Task4
{
    class Program
    {
        // Функция за намиране на минимално двуцифрено
        static int min(int p)
        {
            return (1 * p) + (0 * p);
        }

        // Функция за намиране на максималното двуцифрено
        static int max(int p)
        {
            return (p * p) - 1;
        }

        // Функция за намиране на брой двуцифрени
        static int count(int p)
        {
            return max(p) - min(p) + 1;
        }

        // Главна функция
        static void Main(string[] args)
        {
            int p = 16;
            Console.WriteLine("  min = {0} ({1})", min(p), p);
            Console.WriteLine("  max = {0} ({1})", max(p), p);
            Console.WriteLine("count = {0} ({1})", count(p), p);
        }
    }
}
