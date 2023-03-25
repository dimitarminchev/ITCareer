namespace CarDiscount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carModel = Console.ReadLine();
            var vinNumber = int.Parse(Console.ReadLine());
            var condition = Console.ReadLine().ToLower();
            var priceOfCar = double.Parse(Console.ReadLine());

            double profit = priceOfCar * 0.15;

            bool isGoodCondition = false;
            bool isCorrectVin = false;
            bool canMakeDiscount = false;

            if (condition == "good")
            {
                isGoodCondition = true;
            }
            if (vinNumber < 90000 && vinNumber % 2 == 0)
            {
                isCorrectVin = true;
            }
            if (profit > 400)
            {
                canMakeDiscount = true;
            }

            if (isGoodCondition && isCorrectVin && canMakeDiscount)
            {
                Console.WriteLine("yes - {0}", carModel);
                Console.WriteLine("profit - {0:f2}", profit);
            }
            else
            {
                Console.WriteLine("no");
                if (!isGoodCondition)
                {
                    Console.WriteLine("The car is in bad condition");
                }
                if (!isCorrectVin)
                {
                    Console.WriteLine("VIN {0} is not valid", vinNumber);
                }
                if (!canMakeDiscount)
                {
                    Console.WriteLine("Cannot make discount, profit too low - {0:f2}", profit);
                }
            }
        }
    }
}