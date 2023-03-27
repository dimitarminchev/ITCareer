namespace GrandPrix
{
    public class Car
    {
        private const double FuelTankMaxCapacity = 160;

        private double fuelAmount;
        private int hp;

        public Car(int hp, double fuelAmount, Tyre tyreType)
        {
            this.hp = hp;
            this.Tyre = tyreType;
            this.FuelAmount = fuelAmount;
        }

        protected double FuelAmount
        {
            get => this.fuelAmount;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(DriverFailiures.OutOfFuel);
                }

                this.fuelAmount = Math.Min(value, Car.FuelTankMaxCapacity);
            }
        }

        public Tyre Tyre { get; private set; }

        public double Speed => (this.hp + this.Tyre.Degradation) / this.FuelAmount;

        public void ChangeTyres(Tyre freshTyre) => this.Tyre = freshTyre;

        public void Refuel(double fuelAmount) => this.FuelAmount += fuelAmount;

        public void DriveOneLap(double fuelConsumptionPerLap)
        {
            this.FuelAmount -= fuelConsumptionPerLap;
            this.Tyre.Degradate();
        }
    }
}
