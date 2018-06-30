using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class Program
    {
        /* Problem 8.	Най-дълга последователност
           Определете сложността на метод, който намира най-дългата последователност от
           равни числа в даден списък от цели числа List<int> и връща резултата като 
           нов List<int>. Ако няколко поредици имат същата най-дълга дължина, 
           върнете най-лявата от тях.
         */
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = arr[0];
            int br = 1;
            int maxBr = 0, maxNum = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if(num == arr[i]) br++;
                else if(br > maxBr)
                {
                    maxBr = br;
                    br = 1;
                    maxNum = num;
                    num = arr[i];
                }
            }
            if (br > maxBr)
            {
                maxBr = br;
                maxNum = num;
            }
            for(;maxBr>0;maxBr--) Console.Write("{0} ", maxNum);
            // Total: O(N)
        }
    }
}
