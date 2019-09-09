using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SumRepresentatioun
{
    class Program
    {
        // Представяне на сума
        static void Main(string[] args)
        {
            int finalSum = 18;
            int currentSum = 0;
            int[] coins = { 10, 10, 5, 5, 2, 2, 1, 1 }; // Note: Previously Sorted

            Queue<int> resultCoins = new Queue<int>();

            for (int i = 0; i < coins.Length; i++)
            {
                if (currentSum + coins[i] > finalSum) continue;

                currentSum += coins[i];
                resultCoins.Enqueue(coins[i]);
                if (currentSum == finalSum)
                {
                    // Sum Found
                    Console.WriteLine("Coins Count = {0}", resultCoins.Count);
                    Console.WriteLine("Coins: " + string.Join(", ", resultCoins));
                    return;
                }
            }

            Console.WriteLine("Sum Not Found");
        }
    }
}
