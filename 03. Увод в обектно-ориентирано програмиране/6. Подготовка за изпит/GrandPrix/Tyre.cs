namespace GrandPrix
{
    public abstract class Tyre
    {
        private const int DefaultDegradationMinimum = 0;
        private const int DegradationInitialValue = 100;

        private double degradation;
        private double degradationMinimum;

        protected Tyre(string name, double hardness, int degradationMinimum = DefaultDegradationMinimum)
        {
            this.Name = name;
            this.degradationMinimum = degradationMinimum;
            this.Hardness = hardness;
            this.Degradation = DegradationInitialValue;
        }

        public string Name { get; }

        public double Hardness { get; }

        public double Degradation
        {
            get => this.degradation;
            protected set
            {
                if (value < this.degradationMinimum)
                {
                    throw new ArgumentException(DriverFailiures.BlownTyre);
                }

                this.degradation = value;
            }
        }

        public virtual void Degradate() => this.Degradation -= this.Hardness;
    }
}
