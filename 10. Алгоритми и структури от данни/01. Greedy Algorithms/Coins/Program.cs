namespace Coins
{
    public class Program
    {
        // Задача: Представяне на сума
        static void Main(string[] args)
        {
            // търсената сума на монети
            int finalSum = 18;

            // текуща сума монети
            int currentSum = 0;

            // множество налични монети
            int[] coins = { 10, 10, 5, 5, 2, 2, 1, 1 };

            // множество монети за търсената сума
            Queue<int> resultCoins = new Queue<int>(); 

            // Алгоритъм за намиране на минималния брой монети за търсената сума
            for (int i = 0; i < coins.Length; i++)
            {
                if (currentSum + coins[i] > finalSum) continue;

                currentSum += coins[i];
                resultCoins.Enqueue(coins[i]);
                if (currentSum == finalSum)
                {
                    // Намерили сме търсената сума монети
                    Console.WriteLine("Coins Count = {0}", resultCoins.Count);
                    Console.WriteLine("Coins: " + string.Join(", ", resultCoins));
                    return;
                }
            }

            // Не сме успели да намерим търсената сума
            Console.WriteLine("Sum Not Found");
        }
    }
}