using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
/* 12. Нечетен филтър
Напишете програма, която получава масив от цели числа (раздели с интервал), премахва всички нечетни числа, след което превръща останалите числа в недчетни числа, според:
- Ако числото е по-голямо от средното от колекцията оставащи числа, добавяме 1 
- Ако числото е по-малко от средното от колекцията оставащи числа, то намаляме с 1.
След като превърнете всички елементи към нечетни числа, изведете масива.
Решение: Живко Колев
*/
    class Program
    {
        static void Main(string[] args)
        {
            // Въвеждаме числата в колекция
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // Четните числа
            var even = num.Where(x => x % 2 == 0).ToArray();
            var avg = even.Average();

            // Намираме числата по-малко от средното
            var num1 = even.Where(x => x <= avg).Select(y => y = y - 1).ToArray();

            // Намираме числата по-големи от средното
            var num2 = even.Where(x => x > avg).Select(y => y = y + 1).ToArray();

            // Залепяме двете части
            var num3 = num1.Concat(num2);

            // Извеждаме резултата
            Console.WriteLine(string.Join(" ", num3));
        }
    }
}
