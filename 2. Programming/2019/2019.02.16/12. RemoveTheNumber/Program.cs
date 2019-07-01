using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RemoveTheNumber
{
    class Program
    {
        // 12. Премахни числото
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int number = nums[nums.Count - 1];
            while (nums.Contains(number))
            {       
                nums.Remove(number);
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
