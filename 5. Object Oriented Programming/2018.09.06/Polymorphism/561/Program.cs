using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _561
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carLine = Console.ReadLine().Split().ToArray();
            string[] truckLine = Console.ReadLine().Split().ToArray();
            string[] busLine = Console.ReadLine().Split().ToArray();

            Car car = new Car(double.Parse(carLine[1]), double.Parse(carLine[2]), double.Parse(carLine[3]));
            Truck truck = new Truck(double.Parse(truckLine[1]), double.Parse(truckLine[2]), double.Parse(truckLine[3]));
            Bus bus = new Bus(double.Parse(busLine[1]), double.Parse(busLine[2]), double.Parse(busLine[3]));

            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                string[] line = Console.ReadLine().Split().ToArray();
                switch (line[0])
                {
                    case "Drive":
                        if (line[1] == "Car") car.Drive(double.Parse(line[2]));
                        else if (line[1] == "Bus") bus.Drive(double.Parse(line[2]), true);
                        else truck.Drive(double.Parse(line[2]));
                        break;
                    case "DriveEmpty":
                        bus.Drive(double.Parse(line[2]), false);
                        break;
                    default:
                        if (line[1] == "Car") car.Refuel(double.Parse(line[2]));
                        else if (line[1] == "Bus") bus.Refuel(double.Parse(line[2]));
                        else truck.Refuel(double.Parse(line[2]));
                        break;
                }
            }

            Console.WriteLine($"Car: {car.Fuel:f2}");
            Console.WriteLine($"Truck: {truck.Fuel:f2}");
            Console.WriteLine($"Bus: {bus.Fuel:F2}");
        }
    }
}
