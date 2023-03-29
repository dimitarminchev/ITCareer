namespace Vehicles2
{
    public class Bus : IVehicle
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

        public double FuelCapacity
        {
            get { return fuelCapacity; }
            set { fuelCapacity = value; }
        }
        private double fuelCapacity;

        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        private double distance;

        public bool Passangers { get; set; }

        public Bus(double fuel, double liters, double capacity)
        {
            Fuel = fuel;
            LitersPerKm = liters;
            FuelCapacity = capacity;
            Distance = 0;
            Passangers = false;
        }

        public void Drive(double km)
        {
            var travel = litersperkm * km;
            if (travel <= fuel)
            {
                Fuel -= travel;
                Console.WriteLine("Bus traveled " + km + " km");
                Distance += km;
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public void Refuel(double litres)
        {
            if (litres < 0 || litres > fuelCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else Fuel += litres;
        }
    }
}