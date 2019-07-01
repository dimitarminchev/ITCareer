using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OddFilter
{
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
