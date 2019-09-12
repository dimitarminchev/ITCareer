using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Vehicles2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var input = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
                Car car = new Car(input[0], input[1], input[2]);
                input = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
                Truck truck = new Truck(input[0], input[1], input[2]);
                input = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
                Bus bus = new Bus(input[0], input[1], input[2]);
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    var cmd = Console.ReadLine().Split().ToArray();
                    if (cmd[0] == "Drive")
                    {
                        if (cmd[1] == "Car")
                        {
                            car.Drive(double.Parse(cmd[2]));
                        }
                        else if (cmd[1] == "Truck")
                        {
                            truck.Drive(double.Parse(cmd[2]));
                        }
                        else
                        {
                            bus.Passangers = true;
                            bus.Drive(double.Parse(cmd[2]));
                        }
                    }
                    else if (cmd[0] == "Refuel")
                    {
                        if (cmd[1] == "Car")
                        {
                            car.Refuel(double.Parse(cmd[2]));
                        }
                        else if (cmd[1] == "Truck")
                        {
                            truck.Refuel(double.Parse(cmd[2]));
                        }
                        else
                        {
                            truck.Refuel(double.Parse(cmd[2]));
                        }
                    }
                    else
                    {
                        bus.Passangers = false;
                        bus.Drive(double.Parse(cmd[2]));
                    }

                }
                Console.WriteLine($"Car: {car.Fuel:F2}");
                Console.WriteLine($"Truck: {truck.Fuel:f2}");
                Console.WriteLine($"Bus: {bus.Fuel:f2}");
            }
        }
    }
}
