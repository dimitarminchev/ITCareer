namespace ResellProfitValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carModel = Console.ReadLine();
            var initialCarPrice = double.Parse(Console.ReadLine());
            var daysStayedInTheLot = int.Parse(Console.ReadLine());

            // 20% tax + 275 flat tax
            var additionalExpenses = (initialCarPrice * 0.2) + 275;

            // 20 per day
            var carPriceWithExpenses = initialCarPrice + additionalExpenses + (daysStayedInTheLot * 20);

            // We want 15% profit
            var profit = carPriceWithExpenses * 0.15;

            Console.WriteLine("The {0} with initial price of {1:f2} BGN will sell for {2:f2} BGN",
                              carModel, initialCarPrice, carPriceWithExpenses + profit);
            Console.WriteLine("Profit: {0:f2} BGN", profit);
        }
    }
}