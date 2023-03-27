namespace GrandPrix
{
    public class AggressiveDriver : Driver
    {
        private const double AggresiveDriverFuelConsumption = 2.7;
        private const double AggresiveDriverSpeedBonus = 1.3;
        private const int AggressiveOvertakeTimeWindow = 3;

        public AggressiveDriver(string name, Car car) : base(name, car, AggresiveDriverFuelConsumption)
        {
        }

        public override double Speed => base.Speed * AggresiveDriverSpeedBonus;

        public override bool TryOvertake(Driver driverAhead, string trackWeather)
        {
            if (this.Car.Tyre is UltrasoftTyre)
            {
                if (trackWeather == "Foggy")
                {
                    this.Dnf = DriverFailiures.Crashed;
                    return false;
                }

                return base.Overtake(driverAhead, AggressiveOvertakeTimeWindow);
            }

            return base.Overtake(driverAhead);
        }
    }
}
