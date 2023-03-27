namespace PopulationCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Dictionary<string, Dictionary<string, int>> items = new Dictionary<string, Dictionary<string, int>>();

                while (true)
                {
                    var line = Console.ReadLine().Split("|");
                    if (line[0] == "report") break;

                    var city = line[0];
                    var country = line[1];
                    var population = int.Parse(line[2]);

                    if (items.ContainsKey(country))
                    {
                        var towns = items[country];
                        towns.Add(city, population);
                    }
                    else
                    {
                        var town = new Dictionary<string, int>();
                        town.Add(city, population);
                        items.Add(country, town);
                    }
                }

                foreach (var item in items)
                {
                    Console.WriteLine($"{item.Key} (total population: {item.Value.Sum(x => x.Value)})");
                    foreach (var town in item.Value)
                    {
                        Console.WriteLine($"=>{town.Key}: {town.Value}");
                    }
                }

            }
        }
    }