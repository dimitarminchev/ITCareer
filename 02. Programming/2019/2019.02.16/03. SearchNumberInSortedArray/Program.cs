using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchNumberInSortedArray
{
    class Program
    {
        // 3. Търсене на елемент в сортиран масив
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == n)
                {
                    found = true;
                    break;
                }
            }
            Console.WriteLine(found ? "Yes" : "No");
        }
    }
}
