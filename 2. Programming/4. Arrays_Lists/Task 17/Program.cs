using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
/* 17. Сума на обърнати числа
 Напишете програма, която прочита поредица от цели числа, преобръща техните цифри и ги сумира.
*/
    class Program
    {
        // Решение: Митко Недялков
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ');
            for (int i = 0; i < nums.Count(); i++)
            {
                nums[i] = String.Join("", nums[i].Reverse());
            }
            Console.WriteLine(nums.Select(int.Parse).Sum());
        }
    }
}
