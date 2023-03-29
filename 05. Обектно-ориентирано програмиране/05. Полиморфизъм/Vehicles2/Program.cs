namespace Vehicles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car [initial fuel quantity] [liters per km] [tank capacity]
            var input = System.Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            Car car = new Car(input[0], input[1], input[2]);

            // Truck [initial fuel quantity] [liters per km] [tank capacity]
            input = System.Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            Truck truck = new Truck(input[0], input[1], input[2]);

            // Bus [initial fuel quantity] [liters per km] [tank capacity]
            input = System.Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            Bus bus = new Bus(input[0], input[1], input[2]);

            // N команди 
            int N = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                var cmd = System.Console.ReadLine().Split().ToArray();

                if (cmd[0] == "Drive")
                {
                    var distance = double.Parse(cmd[2]);
                    if (cmd[1] == "Car")
                    {
                        car.Drive(distance);
                    }
                    if (cmd[1] == "Truck")
                    {
                        truck.Drive(distance);
                    }
                    if (cmd[1] == "Bus")
                    {
                        bus.Drive(distance);
                    }
                }

                else if (cmd[0] == "Refuel")
                {
                    var liters = double.Parse(cmd[2]);
                    if (cmd[1] == "Car")
                    {
                        car.Refuel(liters);
                    }
                    if (cmd[1] == "Truck")
                    {
                        truck.Refuel(liters);
                    }
                    if (cmd[1] == "Bus")
                    {
                        bus.Refuel(liters);
                    }
                }

                // DriveEmpty Bus [distance]
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