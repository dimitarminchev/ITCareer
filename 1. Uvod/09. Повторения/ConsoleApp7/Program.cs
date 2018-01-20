using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Лява и дясна сума
            int n = int.Parse(Console.ReadLine());

            // Лява сума
            double left = 0;
            for(int i=0;i<n;i++)
            left += int.Parse(Console.ReadLine());

            // Дясна сума
            double right = 0;
            for (int i = 0; i < n; i++)
            right += int.Parse(Console.ReadLine());

            if (left == right)
                Console.WriteLine("Yes, sum = {0}", left);
            else
                Console.WriteLine("No, diff = {0}", 
                    Math.Abs(left - right));
        }
    }
}
