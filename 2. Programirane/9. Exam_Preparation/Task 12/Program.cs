using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_12
{
    /// <summary>
    /// Task 12. RainAir (Result: 0/100)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            var RainAir = new SortedDictionary<String, List<int>>();
            var line = Console.ReadLine();
            while (line != "I believe I can fly!")
            {
                if (line.IndexOf('=') == -1)
                {
                    // Add customer flights
                    var parts = line.Split(' ');
                    String customerName = parts[0].ToString();
                    List<int> customerFlights;

                    if (RainAir.ContainsKey(customerName)) customerFlights = RainAir[customerName];
                    else customerFlights = new List<int>();

                    for (int i = 1; i < parts.Count(); i++) customerFlights.Add(int.Parse(parts[i]));
                    customerFlights.Sort();

                    if (RainAir.ContainsKey(customerName)) RainAir[customerName] = customerFlights;
                    else RainAir.Add(customerName, customerFlights);
                }
                else
                {
                    // Change Customer Name
                    var parts = line.Replace(" = ", "=").Split('=');
                    if (RainAir.ContainsKey(parts[0])) RainAir[parts[0]] = RainAir[parts[1]];
                }
                // Next Line
                line = Console.ReadLine();
            }
            // Print
            foreach (var customer in RainAir)
            {
                Console.Write("#{0} ::: ", customer.Key);
                Console.WriteLine(String.Join(", ", customer.Value));
            }
        }
    }
}
