using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.RemoveNegativeNumbers
{
    class Program
    {
        // 13. Изтриване на отрицателни елементи
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int index = 0; index < nums.Count; index++)
                if (nums[index] < 0)
                {
                    nums.RemoveAt(index);
                    index--; // връщаме индекса назад, понеже намаляме броя на елементите с единица и следващия елемент се е мръднал наляво
                }
            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
