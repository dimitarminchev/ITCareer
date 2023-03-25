namespace SeasonSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carModel = Console.ReadLine();
            var carType = Console.ReadLine().ToLower(); // sedan or suv
            var season = Console.ReadLine().ToLower(); // winter or summer
            var condition = Console.ReadLine().ToLower(); // perfect, good or bad
            var initialPrice = double.Parse(Console.ReadLine());
            var profitWanted = double.Parse(Console.ReadLine());

            var profit = 0.0;

            if (carType == "suv")
            {
                if (condition == "perfect")
                {
                    profit = initialPrice * 0.3; // perfect condition suv
                }
                else if (condition == "good")
                {
                    profit = initialPrice * 0.2; // good condition suv
                }
                else
                {
                    profit = initialPrice * 0.1; // bad condition suv
                }
            }
            else
            {
                if (condition == "perfect")
                {
                    profit = initialPrice * 0.25; //perfect condition sedan
                }
                else if (condition == "good")
                {
                    profit = initialPrice * 0.15; // good condition sedan
                }
                else
                {
                    profit = initialPrice * 0.10; // bad condition sedan
                }
            }
            if (season == "winter")
            {
                profit -= 200; // winter tires
            }
            if (profit >= profitWanted)
            {
                Console.WriteLine("The profit on {0} will be good - {1:2f} BGN", carModel, profit);
            }
            else
            {
                Console.WriteLine("The car is not worth selling now");
                Console.WriteLine("Need {0:f2} more profit", profitWanted - profit);
            }
        }
    }
}