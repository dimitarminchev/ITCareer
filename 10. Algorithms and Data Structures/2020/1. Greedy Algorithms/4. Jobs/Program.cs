using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Jobs
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 4; // Брой елементи
            int minSum = 1000000; // Минимална сума за свършване на работата

            // 4х4 = Цена за извършване на работа на работниците
            int[,] jobs =
            {
                { 9,2,7,8 },
                { 6,4,3,7 },
                { 5,8,1,8 },
                { 7,6,9,4 }
            };

            // Пермутации на елементите
            List<List<int>> permutations = new List<List<int>>();
            for (int a = 0; a < MAX; a++)
                for (int b = 0; b < MAX; b++)
                    for (int c = 0; c < MAX; c++)
                        for (int d = 0; d < MAX; d++)
                            if (a != b && a != c && a != d && b != c && b != d && c != d)
                            {
                                var next = new List<int>();
                                next.Add(jobs[a, 0]); // next.Add(a);
                                next.Add(jobs[b, 1]); // next.Add(b);
                                next.Add(jobs[c, 2]); // next.Add(c);
                                next.Add(jobs[d, 3]); // next.Add(d);
                                permutations.Add(next);
                            }

            // Отпечатване на пермутациите
            foreach (var next in permutations)
            {
                // НАмиране на сумата
                int currentSum = next.Sum();
                if (currentSum < minSum) minSum = currentSum;
                // Отпечаване
                Console.Write(string.Join(" + ", next));
                Console.WriteLine(" = {0}$", currentSum);
            }
            Console.WriteLine("Minimum value: {0}$", minSum);
        }
    }
}
