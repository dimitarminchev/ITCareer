using System;
using System.Collections.Generic;

namespace _1._CoinsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int finalSum = 18; // търсената сума на монети
            int currentSum = 0; // ткуща сума монети
            int[] coins = { 10, 10, 5, 5, 2, 2, 1, 1 }; // множество налични монети
            Queue<int> resultCoins = new Queue<int>(); // множество монети за търсената сума

            // Алгоритъм за намиране на минималния брой монети за търсената сума
            for (int i = 0; i < coins.Length; i++)
            {
                if (currentSum + coins[i] > finalSum) continue;

                currentSum += coins[i];
                resultCoins.Enqueue(coins[i]);
                if (currentSum == finalSum)
                { 
                    // Намерили сме търсената сума монети
                    Console.Write("Coins: ");
                    Console.WriteLine(String.Join(", ",resultCoins));
                    Console.Write("Count = {0}",resultCoins.Count);
                    return;
                }
            }
            // Не сме успели да намерим търсената сума
            Console.WriteLine("Sum not found");
        }
    }
}
