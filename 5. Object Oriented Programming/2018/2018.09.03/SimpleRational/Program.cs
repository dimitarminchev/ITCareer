using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRational
{
    class Program
    {
        static void Main(string[] args)
        {
            // Въвеждаме броя на числа за обработка
            int n = int.Parse(Console.ReadLine());

            // Списък с рационални числа
            List<RacionalNumber> rn = new List<RacionalNumber>();

            // Въвеждаме по 2 числа на ред от които формулираме рационални числа
            while (n > 0)
            {
                var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                rn.Add( new RacionalNumber(nums[0], nums[1]));
                n--;
            }

            // Отпечатваме листа
            foreach (var item in rn) Console.WriteLine(item);

        }
    }
}
