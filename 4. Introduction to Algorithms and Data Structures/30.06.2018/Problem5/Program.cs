using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        /* Problem 5.	Намиране на най-малко число 
           Определете сложността (максимания брой стъпки) на програма, 
           която чете от конзолата последователност от цели числа на един ред, 
           разделени с интервал. Намерете най-малкото от тях и го изведете.
        */
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int min = int.MaxValue;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine(min); 
            // Total: O(N)
        }
    }
}
