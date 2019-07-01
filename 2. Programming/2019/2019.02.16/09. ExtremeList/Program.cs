using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtremeList
{
    class Program
    {
        // 9. Списък от крайности
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            
            // Намираме най-малкото и най-голямото число
            int min = nums[0], max = nums[0];
            foreach (var item in nums)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }

            for (int index = 0; index < nums.Count; index++)
            {
                // Добавяме стойността към списъка result
                if (nums[index] == min || nums[index] == max)
                    result.Add(nums[index]);
            }

            // Сортираме и отпечатваме списъка 
            result.Sort();                
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
