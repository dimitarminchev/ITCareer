using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayToNumber
{
    class Program
    {
        // 04. Преобразуване на масив в число
        static void Main(string[] args)
        {
            // Въвеждане на масив
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length - 1];            

            // Компресиран масив
            int n = nums.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                  condensed[i] = nums[i] + nums[i + 1];
                nums = condensed;
                n--;
            } while (n != 1);

            // Резултат
            Console.WriteLine(condensed[n - 1]);

        }
    }
}
