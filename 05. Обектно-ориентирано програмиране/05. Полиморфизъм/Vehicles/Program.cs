namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car [fuel quantity] [liters per km]
            var input = System.Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            Car car = new Car(input[0], input[1]);

            // Truck [fuel quantity] [liters per km]
            input = System.Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            Truck truck = new Truck(input[0], input[1]);

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
                }

                if (cmd[0] == "Refuel")
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
                }
            }

            Console.WriteLine($"Car: {car.Fuel:F2}");
            Console.WriteLine($"Truck: {truck.Fuel:f2}");
        }
    }
}