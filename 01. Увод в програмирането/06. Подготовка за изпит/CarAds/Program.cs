namespace CarAds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int gasolineCarsCount = 0;
            int dieselCarsCount = 0;

            for (int i = 0; i < n; i++)
            {
                String carModel = Console.ReadLine().ToLower();
                String carType = Console.ReadLine().ToLower(); // coupe or sedan
                String fuelType = Console.ReadLine().ToLower(); // gasoline or diesel
                String adStatus = Console.ReadLine().ToLower(); // normal or vip
                double price = double.Parse(Console.ReadLine());
                int kilometers = int.Parse(Console.ReadLine());

                String category = "";

                if (carType == "coupe")
                {
                    if (fuelType == "gasoline")
                    {
                        category = "sport";
                        if (price > 100000)
                        {
                            category = "supersport";
                        }
                        gasolineCarsCount++;
                    }
                    else
                    {
                        category = "ecosport";
                        dieselCarsCount++;
                    }
                }
                else
                {
                    if (fuelType == "gasoline")
                    {
                        category = "executive";
                        if (price > 80000)
                        {
                            category = "limousine";
                        }
                        gasolineCarsCount++;

                    }
                    else
                    {
                        category = "economic";
                        dieselCarsCount++;
                    }
                }

                if (adStatus == "vip")
                {
                    price += 200;
                }

                Console.WriteLine("Car model - {0}", carModel);
                Console.WriteLine("Category - {0}", category);
                Console.WriteLine("Type - {0}", carType);
                Console.WriteLine("Fuel - {0}", fuelType);
                Console.WriteLine("Kilometers - {0}", kilometers);
                Console.WriteLine("Price - {0:f2}", price);

            }

            Console.WriteLine("Gasoline cars: {0:f2}", ((double)gasolineCarsCount / n) * 100);
            Console.WriteLine("Diesel cars: {0:f2}", ((double)dieselCarsCount / n) * 100);
        }
    }
}