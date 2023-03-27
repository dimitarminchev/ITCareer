namespace Minedraft
{
    public class HarvesterFactory
    {
        public Harvester GetHarvester(List<string> arguments)
        {
            string harvesterType = arguments[0];
            string id = arguments[1];
            double oreOutput = double.Parse(arguments[2]);
            double energyRequirement = double.Parse(arguments[3]);

            if (harvesterType == "Sonic")
            {
                return new SonicHarvester(id, oreOutput, energyRequirement, int.Parse(arguments[4]));
            }
            else if (harvesterType == "Hammer")
            {
                return new HammerHarvester(id, oreOutput, energyRequirement);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

}
