namespace GrandPrix
{
    public class UltrasoftTyre : Tyre
    {
        private const int DegradationMinimum = 30;
        private const string UltrasoftName = "Ultrasoft";

        public UltrasoftTyre(double hardness, double grip) : base(UltrasoftName, hardness, DegradationMinimum)
        {
            this.Grip = grip;
        }

        public double Grip { get; }

        public override void Degradate() => this.Degradation -= this.Hardness + this.Grip;
    }
}
