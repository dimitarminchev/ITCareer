namespace CarsTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var fuk = Console.ReadLine().Split();
                cars.Add
                (
                    new Car()
                    {
                        Name = fuk[0],
                        Fuel = float.Parse(fuk[1]),
                        Perkm = float.Parse(fuk[2])
                    }
                );
            }

            var items = new Dictionary<string, int>();
            var line = "";
            do
            {
                line = Console.ReadLine();
                if (line != "End")
                {
                    var split = line.Split();
                    if (items.ContainsKey(split[1]))
                    {
                        var km = items[split[1]] + int.Parse(split[2]);
                        items[split[1]] = km;

                    }
                    else items.Add(split[1], int.Parse(split[2]));
                }
            }
            while (line != "End");

            foreach (var item in items)
            {
                var currentCar = cars.Where(a => a.Name == item.Key).First();
                currentCar.TheMagic(item.Value);
            }
        }
    }
}