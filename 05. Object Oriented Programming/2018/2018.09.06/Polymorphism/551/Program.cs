using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _551
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Split().ToArray();
            Car car = new Car(double.Parse(line1[1]), double.Parse(line1[2]));

            var line2 = Console.ReadLine().Split().ToArray();
            Truck truck = new Truck(double.Parse(line2[1]), double.Parse(line2[2]));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().ToArray();
                if(line[0] ==  "Drive")
                {
                    if(line[1] == "Car") car.Drive(double.Parse(line[2]));
                    if(line[1] == "Truck") truck.Drive(double.Parse(line[2]));
                }
                if(line[0] == "Refuel")
                {
                    if (line[1] == "Car") car.Refuel(double.Parse(line[2]));
                    if (line[1] == "Truck") truck.Refuel(double.Parse(line[2]));
                }
            }
            Helper.WriteLine($"Car: {car.Fuel:f2}");
            Helper.WriteLine($"Truck: {truck.Fuel:f2}");
        }
    }
}
