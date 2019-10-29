using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ReversedNumbersSum
{
    class Program
    {
        // 11. Сума на обърнати числа
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().ToList();
            var sum = 0;
            foreach (var item in nums)
            sum += int.Parse(ReverseString(item));
            Console.WriteLine(sum);
        }

        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
