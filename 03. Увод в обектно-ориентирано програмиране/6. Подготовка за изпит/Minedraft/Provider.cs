using System.Text;

namespace Minedraft
{
    public abstract class Provider : Worker
    {
        private string id;
        private double energyOutput;

        protected Provider(string id, double energyOutput) : base(id)
        {
            this.EnergyOutput = energyOutput;
        }

        public double EnergyOutput
        {
            get => this.energyOutput;
            protected set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException($"Provider is not registered, because of it's EnergyOutput");
                }
                this.energyOutput = value;
            }
        }

        public override string ToString()
        {
            var endIndex = this.GetType().Name.IndexOf("Provider");
            var providerType = this.GetType().Name.Substring(0, endIndex);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{providerType} Provider - {this.Id}")
                .Append($"Energy Output: {this.EnergyOutput}");

            return sb.ToString();
        }
    }

}
