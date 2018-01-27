using System;

namespace Task_9
{
/* 9. Точна сума на реални числа
Напишете програма, която въвежда n числа и изчислява и извежда тяхната точна сума (без закръгляне).
*/
    class Program
    {
        // Решение: Живко Колев
        static void Main(string[] args)
        {
            var n1 = decimal.Parse(Console.ReadLine());
            var n2 = decimal.Parse(Console.ReadLine());
            var n3 = decimal.Parse(Console.ReadLine());
            var n4 = decimal.Parse(Console.ReadLine());
            Console.WriteLine(n1 + n2 + n3 + n4); 
        }
    }
}
