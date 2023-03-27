namespace GrandPrix
{
    public abstract class Driver
    {
        private const int BoxTimeLoss = 20;
        private const int DefaultOvertakeTimeWindow = 2;

        private double fuelConsumptionPerKm;

        protected Driver(string name, Car car, double fuelConsumption)
        {
            this.Dnf = string.Empty;

            this.Name = name;
            this.Car = car;
            this.fuelConsumptionPerKm = fuelConsumption;
        }

        protected Car Car { get; }

        protected string Dnf { get; set; }

        public string Name { get; }

        public double TotalTime { get; set; }

        public virtual double Speed => this.Car.Speed;

        public void BoxForTyres(Tyre freshTyre)
        {
            this.Car.ChangeTyres(freshTyre);
            this.TotalTime += BoxTimeLoss;
        }

        public void RefuelWithGas(double fuelAmount)
        {
            this.Car.Refuel(fuelAmount);
            this.TotalTime += BoxTimeLoss;
        }

        public bool IsDnf() => this.Dnf != string.Empty;

        public void ProgressOneLap(double trackLength)
        {
            try
            {
                double lapTime = 60 / (trackLength / this.Speed);
                this.TotalTime += lapTime;
                this.Car.DriveOneLap(trackLength * this.fuelConsumptionPerKm);
            }
            catch (ArgumentException argumentException)
            {
                this.Dnf = argumentException.Message;
            }
        }

        public abstract bool TryOvertake(Driver driverAhead, string trackWeather);

        protected bool Overtake(Driver driverAhead, int overtakeTimeWindow = DefaultOvertakeTimeWindow)
        {

            if (this.TotalTime - driverAhead.TotalTime <= overtakeTimeWindow)
            {
                this.TotalTime -= overtakeTimeWindow;
                driverAhead.TotalTime += overtakeTimeWindow;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            if (this.IsDnf())
            {
                return $"{this.Name} {this.Dnf}";
            }

            //return $"{this.Name} {this.TotalTime:f3} degr {this.Car.Tyre.Degradation} speed {this.Speed}";
            return $"{this.Name} {this.TotalTime:f3}";
        }
    }
}
