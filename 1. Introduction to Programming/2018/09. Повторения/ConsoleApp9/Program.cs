using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9. Еднакви двойки
            var currentSum = 0;
            var currentDiff = 0;
            var previousSum = 0;
            var previousDiff = 0;
            var maxDiff = int.MinValue;
            var numsCount = int.Parse(Console.ReadLine());
            for (int i = numsCount; i > 0; i--)
            {
                var n1 = int.Parse(Console.ReadLine());
                var n2 = int.Parse(Console.ReadLine());
                currentSum = n1 + n2;
                if (currentSum != previousSum && i != numsCount)
                {
                    currentDiff = Math.Abs(currentSum - previousSum);
                    currentDiff = currentDiff > previousDiff ? currentDiff : previousDiff;
                    maxDiff = currentDiff > maxDiff ? currentDiff : maxDiff;
                }
                previousSum = currentSum;
            }
            Console.WriteLine(maxDiff == int.MinValue ? $"Yes, value={currentSum}" : $"No, maxdiff={maxDiff}");

        }
    }
}
