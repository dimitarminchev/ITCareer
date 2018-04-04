using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car
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

            // Commands
            var dik = new Dictionary<string, int>();
            var line = "";
            do
            {
                line = Console.ReadLine();
                if (line != "End")
                {
                    var split = line.Split();
                    if (dik.ContainsKey(split[1]))
                    {
                        var km = dik[split[1]] + int.Parse(split[2]);
                        dik[split[1]] = km;

                    }
                    else dik.Add(split[1], int.Parse(split[2]));
                }
            }
            while (line != "End");

            // Process
            foreach (var item in dik)
            {
                var currentCar = cars.Where(a => a.Name == item.Key).First();
                currentCar.TheMagic(item.Value);
            }
        }
    }
}
