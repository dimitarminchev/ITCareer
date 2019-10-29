using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EvenNumbers
{
    class Program
    {
        // 08. Списък от честни числа
        static void Main(string[] args)
        {
            List<int> nums =  Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int index = 0; index < nums.Count; index++)
            {
                if (nums[index] % 2 == 0)
                    Console.Write("{0} ", nums[index]);
            }
        }
    }
}
