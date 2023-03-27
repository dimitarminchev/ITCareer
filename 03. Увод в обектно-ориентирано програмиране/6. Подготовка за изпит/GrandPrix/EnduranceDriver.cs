namespace GrandPrix
{
    public class EnduranceDriver : Driver
    {
        private const double EnduranceDriverFuelConsumption = 1.5;
        private const int EnduranceOvertakeTimeWindow = 3;

        public EnduranceDriver(string name, Car car) : base(name, car, EnduranceDriverFuelConsumption)
        {
        }

        public override bool TryOvertake(Driver driverAhead, string trackWeather)
        {
            if (this.Car.Tyre is HardTyre)
            {
                if (trackWeather == "Rainy")
                {
                    this.Dnf = DriverFailiures.Crashed;
                    return false;
                }

                return base.Overtake(driverAhead, EnduranceOvertakeTimeWindow);
            }

            return base.Overtake(driverAhead);
        }
    }
}
