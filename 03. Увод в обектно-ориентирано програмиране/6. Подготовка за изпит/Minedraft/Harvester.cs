using System.Text;

namespace Minedraft
{
    public abstract class Harvester : Worker
    {
        private double oreOutput;
        private double energyRequirement;

        public Harvester(string id, double oreOutput, double energyRequirement) : base(id)
        {
            this.OreOutput = oreOutput;
            this.EnergyRequirement = energyRequirement;
        }

        public double EnergyRequirement
        {
            get => this.energyRequirement;
            protected set
            {
                if (value < 0 || value > 20000)
                {
                    throw new ArgumentException($"Harvester is not registered, because of it's EnergyRequirement");
                }
                this.energyRequirement = value;
            }
        }

        public double OreOutput
        {
            get => this.oreOutput;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Harvester is not registered, because of it's OreOutput");
                }

                this.oreOutput = value;
            }
        }

        public override string ToString()
        {
            var endIndex = this.GetType().Name.IndexOf("Harvester");
            var harvesterType = this.GetType().Name.Substring(0, endIndex);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{harvesterType} Harvester - {this.Id}")
                .AppendLine($"Ore Output: {this.OreOutput}")
                .Append($"Energy Requirement: {this.EnergyRequirement}");

            return sb.ToString();
        }
    }

}
