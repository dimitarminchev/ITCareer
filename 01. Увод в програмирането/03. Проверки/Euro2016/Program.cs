namespace Euro2016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());

            double tikets = 0;
            if (type == "VIP") tikets = people * 499.99;
            else tikets = people * 249.99;

            double transport = 0;
            if (people < 5) transport = budget * 0.75;
            else if (people < 10) transport = budget * 0.60;
            else if (people < 25) transport = budget * 0.50;
            else if (people < 50) transport = budget * 0.40;
            else transport = budget * 0.25;

            if (budget < (tikets + transport))
            {
                Console.WriteLine($"Not enough money! You need {((tikets + transport) - budget):f2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {(budget - (tikets + transport)):f2} leva left.");
            }
        }

    }
}