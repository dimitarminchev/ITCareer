using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
/*  11. Сортиране на часове
Напишете програма, която получава списък от часове (разделени с интервал, 24-часове формат) и ги сортира в нарастващ ред. Изведете сортираните часове разделени с интервали.
Примери: 06:55, 02:30, 23:11 -> 02:30, 06:55, 21:11
Решение: Живко Колев
*/
    class Program
    {
        static void Main(string[] args)
        {
            string[] item = Console.ReadLine().Split(' ');
            item = item.OrderBy(x => x).Distinct().ToArray();
            Console.WriteLine(string.Join(" ", item));
        }
    }
}
