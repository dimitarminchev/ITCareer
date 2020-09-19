using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._ZeroSum
{
    class Program
    {
        /*
         Нека са дадени числата a1, a2, ..., an. 
        Да се поставят операции "+" и "–" между числата ai и ai+1, 
        за i = 1,2, …, n–1 така, че резултатът след пресмятане на 
        получения израз да бъде равен на 0.
        Например, ако са дадени естествените числа от 1 до 8, 
        то няколко възможни решения на задачата са:
        1 + 2 + 3 + 4 – 5 – 6 – 7 + 8 = 0
        1 + 2 + 3 – 4 + 5 – 6 + 7 – 8 = 0
        1 + 2 – 3 + 4 + 5 + 6 – 7 – 8 = 0
        1 + 2 – 3 – 4 – 5 – 6 + 7 + 8 = 0
        От клавиатурата се въвежда цяло число n,
        броя на числата и след него n на брой числа.
         */

        // Применливи
        static List<bool[]> sign = new List<bool[]>();
        static bool[] currentSolution;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            currentSolution = new bool[n];
            Permute(n, 0);
            foreach (var guess in sign)
            {
                var numGuess = new int[n];
                for (int i = 0; i < n; i++)
                {
                    numGuess[i] = (guess[i] ? -1 : 1) * numbers[i];
                }
                if (numGuess.Sum() == 0)
                {
                    Console.WriteLine($"{string.Join(" ", numGuess.Select(x => x > 0 ? $"+{x}" : $"{x}"))} = 0");
                }
            }
        }

        // Метод за генериране на пермутации
        static void Permute(int n, int index)
        {
            if (n == index)
            {
                sign.Add(currentSolution.Clone() as bool[]);
                return;
            }

            currentSolution[index] = true;
            Permute(n, index + 1);
            currentSolution[index] = false;
            Permute(n, index + 1);
        }
    }
}
