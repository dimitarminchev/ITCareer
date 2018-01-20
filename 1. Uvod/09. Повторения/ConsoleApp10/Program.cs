using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10. Елемент, равен на сумата на останалите
            int n = int.Parse(Console.ReadLine());
            int sum = 0, max = -1000000;
            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                if (k > max) max = k;
                sum = sum + k;
            }
            sum = sum - max;
            if (sum  == max)
            Console.WriteLine("Yes\nSum = {0}", sum);
            else Console.WriteLine("No\nDiff = {0}",
                 Math.Abs(sum - max));

        }
    }
}
