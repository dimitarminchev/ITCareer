namespace Minedraft
{
    public class ProviderFactory
    {
        public Provider GetProvider(List<string> arguments)
        {
            string providerType = arguments[0];
            string id = arguments[1];
            double energyOutput = double.Parse(arguments[2]);

            if (providerType == "Solar")
            {
                return new SolarProvider(id, energyOutput);
            }
            else if (providerType == "Pressure")
            {
                return new PressureProvider(id, energyOutput);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

}
