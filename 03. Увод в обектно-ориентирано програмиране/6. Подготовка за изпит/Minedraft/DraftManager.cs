using System.Text;

namespace Minedraft
{
    public class DraftManager
    {
        private List<Harvester> harvesters;
        private List<Provider> providers;
        private string currentMode;
        private double totalMinedOre;
        private double totalEnergyStored;
        private HarvesterFactory harvesterFactory;
        private ProviderFactory providerFactory;

        public DraftManager()
        {
            this.harvesters = new List<Harvester>();
            this.providers = new List<Provider>();
            this.currentMode = "";
            this.totalMinedOre = 0;
            this.totalEnergyStored = 0;
            this.harvesterFactory = new HarvesterFactory();
            this.providerFactory = new ProviderFactory();
        }

        public string RegisterHarvester(List<string> arguments)
        {
            string harvesterType = arguments[0];
            string id = arguments[1];
            try
            {
                Harvester harvester = this.harvesterFactory.GetHarvester(arguments);
                this.harvesters.Add(harvester);
                return $"Successfully registered {harvesterType} Harvester - {id}";
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
        }

        public string RegisterProvider(List<string> arguments)
        {
            string providerType = arguments[0];
            string id = arguments[1];

            try
            {
                Provider provider = this.providerFactory.GetProvider(arguments);
                this.providers.Add(provider);
                return $"Successfully registered {providerType} Provider - {id}";
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
        }

        public string Day()
        {
            double currentEnergyProvided = this.providers.Sum(p => p.EnergyOutput);
            this.totalEnergyStored += currentEnergyProvided;

            var energyRequirement = this.GetEnergyRequirement();
            var currentOreMined = this.GetOreMined();

            if (energyRequirement <= this.totalEnergyStored)
            {
                this.totalEnergyStored -= energyRequirement;
                this.totalMinedOre += currentOreMined;
            }
            else
            {
                currentOreMined = 0;
            }

            var sb = new StringBuilder();
            sb.AppendLine($"A day has passed.")
                .AppendLine($"Energy Provided: {currentEnergyProvided}")
                .Append($"Plumbus Ore Mined: {currentOreMined}");

            return sb.ToString();
        }

        private double GetOreMined()
        {
            if (this.currentMode == "Energy")
                return 0;

            double oreOutputSum = this.harvesters.Sum(h => h.OreOutput);

            if (this.currentMode == "Half")
                return oreOutputSum * 50 / 100;

            return oreOutputSum; //Full Mode
        }

        private double GetEnergyRequirement()
        {
            if (this.currentMode == "Energy")
                return 0;

            var energyRequired = this.harvesters.Sum(h => h.EnergyRequirement);

            if (this.currentMode == "Half")
                return energyRequired * 60 / 100;

            return energyRequired; //Full Mode
        }

        public string Mode(List<string> arguments)
        {
            this.currentMode = arguments[0];
            return $"Successfully changed working mode to {arguments[0]} Mode";
        }

        public string Check(List<string> arguments)
        {
            var id = arguments[0];
            var harvester = this.harvesters.FirstOrDefault(h => h.Id == id);
            if (harvester != null)
            {
                return harvester.ToString();
            }

            var provider = this.providers.FirstOrDefault(p => p.Id == id);
            if (provider != null)
            {
                return provider.ToString();
            }

            return $"No element found with id - {id}";
        }

        public string ShutDown()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"System Shutdown")
                .AppendLine($"Total Energy Stored: {this.totalEnergyStored}")
                .Append($"Total Mined Plumbus Ore: {this.totalMinedOre}");

            return sb.ToString();
        }
    }

}
