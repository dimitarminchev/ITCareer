using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Task 2.
 Запишете най-малкото и най-голямото двуцифрено число в P-ична 
 бройна система, запишете в същата бройна система на колко 
 е равна тяхната разлика.
*/
namespace Task2
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

        // Функция за намиране на разлика
        static int diff(int p)
        {
            return max(p) - min(p);
        }

        // Главна функция
        static void Main(string[] args)
        {
            int p = 10; 
            Console.WriteLine(" min = {0} ({1})", min(p), p);
            Console.WriteLine(" max = {0} ({1})", max(p), p);
            Console.WriteLine("diff = {0} ({1})", diff(p), p);
        }
    }
}
