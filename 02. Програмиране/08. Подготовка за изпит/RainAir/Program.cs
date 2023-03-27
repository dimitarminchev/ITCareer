namespace RainAir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var RainAir = new Dictionary<String, List<int>>();
            var line = Console.ReadLine();

            while (line != "I believe I can fly!")
            {
                if (line.IndexOf('=') == -1)
                {
                    var parts = line.Split(' ');
                    string customerName = parts[0];
                    List<int> customerFlights;

                    if (RainAir.ContainsKey(customerName))
                    {
                        customerFlights = RainAir[customerName];
                    }
                    else
                    {
                        customerFlights = new List<int>();
                    }

                    for (int i = 1; i < parts.Count(); i++)
                    {
                        customerFlights.Add(int.Parse(parts[i]));
                    }

                    if (RainAir.ContainsKey(customerName))
                    {
                        RainAir[customerName] = customerFlights;
                    }
                    else
                    {
                        RainAir.Add(customerName, customerFlights);
                    }
                }
                else
                {
                    var parts = line.Replace(" = ", "=").Split('=');
                    if (RainAir.ContainsKey(parts[0]))
                    {
                        RainAir[parts[0]] = RainAir[parts[1]];
                    }
                }
                line = Console.ReadLine();
            }

            foreach (var customer in RainAir.OrderByDescending(c => c.Value.Count).ThenBy(c => c.Key))
            {
                Console.Write("#{0} ::: ", customer.Key);
                Console.WriteLine(String.Join(", ", customer.Value.OrderBy(a => a)));
            }
        }
    }
}