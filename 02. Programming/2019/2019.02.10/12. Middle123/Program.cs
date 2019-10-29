using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Middle123
{
    class Program
    {
        // 12. Извличане на средните 1, 2 или 3 елемента
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int len = nums.Length;

            // Take 1,2 or 3
            if (len == 1) nums = nums.Take(1).ToArray();
            else if (len % 2 == 0) nums = nums.Skip(len / 2 - 1).Take(2).ToArray();
            else nums = nums.Skip(len / 2 - 1).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
