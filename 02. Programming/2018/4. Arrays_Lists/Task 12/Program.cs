using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
/* 12. Списък от имена II
Въведете списък от имена на хора и го изведете в конзолата в обратен ред. 
Елементите на списъка ще получите от единствен ред, разделени със запетаи. 
Всеки елемент ще представлява име и фамилия. Изведете имената на всеки човек на отделен ред, 
като първо трябва да изведете фамилията, след което личното име.
*/
    class Program
    {
        // Решение: Митко Недялков
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(',').ToList();
            foreach (var name in names)
            {
                Console.WriteLine(String.Join(" ", name.Split(' ').Reverse()));
            }
        }
    }
}
