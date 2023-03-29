namespace Vehicles
{
    public class Car : IVehicle
    {
        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
        private double fuel;

        public double LitersPerKm
        {
            get { return litersperkm; }
            set { litersperkm = value; }
        }
        private double litersperkm;

        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        private double distance;

        public Car(double fuel, double litersPerKm)
        {
            Fuel = fuel;
            LitersPerKm = litersPerKm + 0.9;
            Distance = 0;
        }

        public void Drive(double km)
        {
            var travel = litersperkm * km;
            if (travel <= fuel)
            {
                Fuel -= travel;
                Console.WriteLine("Car traveled " + km + " km");
                Distance += km;
            }
            else
            {
                Console.WriteLine("Car needs refueling.");
            }
        }

        public void Refuel(double litres)
        {
            Fuel += litres; // 100%
        }
    }
}