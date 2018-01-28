using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
/* 7. Завъртане и сумиране
"Завъртане на масив на дясно" означава да преместим неговия последен елемент на първо място: {1, 2, 3} -> {3, 1, 2}. Напишете програма, която въвежда масив от n цели числа (разделени с интервал на един ред) и цяло число k, завърта k пъти надясно и сумира получените масиви след всяко завъртане както е показано по-долу:
*/
    class Program
    {
        // Решение: Димитър Минчев
        static void Main(string[] args)
        {
            // Въвеждане на масив
            int n = 0;
            int[] nums = new int[100];
            var line = Console.ReadLine().Split(' ');
            foreach (var item in line) nums[n++] = int.Parse(item);

            int[] rotated = new int[n];
            int[] sum = new int[n];

            // Брой ротации
            int rotate = int.Parse(Console.ReadLine());
            do
            {
                // Едно завъртане
                rotated[0] = nums[n - 1];
                for (int i = 0; i < n-1; i++) rotated[i+1] = nums[i];

                // За успешно следващо завъртане, оригиналният масив става завъртяния
                for (int i = 0; i < n; i++) nums[i] = rotated[i];

                // Добавяме завъртяния кум сумата
                for (int i = 0; i < n; i++) sum[i] += rotated[i];

                rotate--;
            }
            while (rotate >= 1);

            // Отпечатваме сумата
            for (int i = 0; i < n; i++) Console.Write("{0} ", sum[i]);
        }
    }
}
