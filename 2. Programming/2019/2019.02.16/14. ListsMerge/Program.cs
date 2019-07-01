using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ListsMerge
{
    class Program
    {
        // 14. Сливане на списъци
        static void Main(string[] args)
        {
            var lists = Console.ReadLine().Split('|').ToList();
            List<int> result = new List<int>(); // създаваме празен списък за резултата

            // обождаме списъка от числовите списъци отзад напред:
            for (int index = lists.Count - 1; index >= 0; index--)
            {
                List<string> nums = lists[index].Split(' ').ToList();
                // отделяме списъка използвайки интервалите
                for (int index2 = 0; index2 < nums.Count; index2++)
                    if (nums[index2] != "")
                        result.Add(int.Parse(nums[index2]));
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
