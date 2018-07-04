using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    static class Recursion
    {
        // 1. Факториел
        public static ulong Fak(int n)
        {
            if (n <= 1) return 1;
            else return (ulong)n * Fak(n - 1);
        }

        // 2. Фибоначи
        public static ulong Fib(int n)
        {
            if (n <= 2)  return 1;
            else return Fib(n - 2) + Fib(n - 1);
        }

        // 3. Графика
        public static void Draw(int n)
        {
            // 1. Условие за изход от рекурсията
            if (n == 0) return;

            // 2. Прав ход на рекурсията
            Console.WriteLine(new string('*',n));

            // 3. Рекурсивно извикване
            Draw(n - 1);

            // 4. Обратен ход на рекурсията
            Console.WriteLine(new string('#', n));
        }
        
    }
}
