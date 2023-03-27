namespace GrandPrix
{
    public class DriverFactory
    {
        public Driver CreateDriver(string driverType, string name, Car car)
        {
            switch (driverType)
            {
                case "Aggressive":
                    return new AggressiveDriver(name, car);
                case "Endurance":
                    return new EnduranceDriver(name, car);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
