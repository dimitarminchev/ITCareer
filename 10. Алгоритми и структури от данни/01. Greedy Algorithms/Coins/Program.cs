namespace Coins
{
    public class Program
    {
        // Задача: Представяне на сума
        static void Main(string[] args)
        {
            // Търсена сума
            int finalSum = 18;

            // Налична сума
            int currentSum = 0;

            // Налични монети
            int[] coins = { 10, 10, 5, 5, 2, 2, 1, 1 };

            // Избрани монети
            Queue<int> selectedCoins = new Queue<int>();

            // Алгоритъм за намиране на минималния брой монети за търсената сума
            for (int i = 0; i < coins.Length; i++)
            {
                // Наличната сума и текущата монета надхвърлят търсената сума
                if (currentSum + coins[i] > finalSum) continue;

                // Нарастваме наличната сума с монетата
                currentSum += coins[i];

                // Добавяме монетата към избраните монети
                selectedCoins.Enqueue(coins[i]);

                // Дали достигнахме търсената сума
                if (currentSum == finalSum)
                {
                    Console.WriteLine("Minimal Coins Count = " + selectedCoins.Count);
                    Console.WriteLine("Selected Coins: " + string.Join(", ", selectedCoins));
                    return; // Изход
                }
            }

            // Не сме намерили търсената сума
            Console.WriteLine("Sum Not Found!");
        }
    }
}