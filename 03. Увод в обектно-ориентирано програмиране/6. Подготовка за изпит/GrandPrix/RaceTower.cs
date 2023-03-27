using System.Reflection;
using System.Text;

namespace GrandPrix
{
    public class RaceTower
    {
        private TyreFactory tyreFactory;
        private DriverFactory driverFactory;
        private Track track;
        private Func<Driver, double> OrderDriversByTotalTime = d => d.TotalTime;
        private IDictionary<string, Driver> racingDrivers;
        private IList<Driver> dnfDrivers;

        public RaceTower()
        {
            this.racingDrivers = new Dictionary<string, Driver>();
            this.dnfDrivers = new List<Driver>();
            this.tyreFactory = new TyreFactory();
            this.driverFactory = new DriverFactory();
        }

        private Tyre GetTyre(IList<string> tyreArgs)
        {
            string tyreType = tyreArgs[0];
            double tyreHardness = double.Parse(tyreArgs[1]);

            if (tyreType == "Hard")
            {
                return this.tyreFactory.CreateTyre(tyreHardness);
            }

            double tyreGrip = double.Parse(tyreArgs[2]);
            return this.tyreFactory.CreateTyre(tyreHardness, tyreGrip);
        }

        private void Refuel(List<string> args)
        {
            string driverName = args[0];
            double fuelAmount = double.Parse(args[1]);
            this.racingDrivers[driverName].RefuelWithGas(fuelAmount);
        }

        private void ChangeTyres(List<string> args)
        {
            string driversName = args[0];
            args.RemoveAt(0);
            this.racingDrivers[driversName].BoxForTyres(this.GetTyre(args));
        }

        private string CheckForOvertaking()
        {
            StringBuilder sb = new StringBuilder();
            List<string> orderedDriversNames = this.racingDrivers.Values
                .OrderByDescending(kvp => kvp.TotalTime)
                .Select(d => d.Name)
                .ToList();

            for (int i = 1; i < orderedDriversNames.Count; i++)
            {
                string driverNameBehind = orderedDriversNames[i - 1];
                string driverNameAhead = orderedDriversNames[i];
                if (this.racingDrivers[driverNameBehind]
                    .TryOvertake(this.racingDrivers[driverNameAhead], this.track.Weather))
                {
                    sb.AppendLine(string.Format(OutputMessages.SuccessfulOvertake, driverNameBehind, driverNameAhead,
                        this.track.LapsCompleted));
                    i++;
                }

                if (this.racingDrivers[driverNameBehind].IsDnf())
                {
                    this.dnfDrivers.Insert(0, this.racingDrivers[driverNameBehind]);
                    this.racingDrivers.Remove(driverNameBehind);
                }
            }

            return sb.ToString().Trim();
        }

        public void SetTrackInfo(int lapsNumber, int trackLength)
        {
            this.track = new Track(lapsNumber, trackLength);
        }

        public void RegisterDriver(List<string> commandArgs)
        {
            try
            {
                string driverType = commandArgs[0];
                string name = commandArgs[1];
                int hp = int.Parse(commandArgs[2]);
                double fuelAmount = double.Parse(commandArgs[3]);

                Tyre tyre = this.GetTyre(commandArgs.Skip(4).ToList());
                Car car = new Car(hp, fuelAmount, tyre);
                Driver driver = this.driverFactory.CreateDriver(driverType, name, car);

                this.racingDrivers.Add(name, driver);
            }
            catch (Exception)
            {
            }
        }

        public void DriverBoxes(List<string> commandArgs)
        {
            if (!this.racingDrivers.ContainsKey(commandArgs[1]))
            {
                return;
            }

            string reason = commandArgs[0];
            commandArgs.RemoveAt(0);

            MethodInfo boxMethod = this.GetType().GetMethod(reason, BindingFlags.Instance | BindingFlags.NonPublic);
            boxMethod.Invoke(this, new object[] { commandArgs });
        }

        public string CompleteLaps(List<string> commandArgs)
        {
            StringBuilder sb = new StringBuilder();
            int numberOfLaps = int.Parse(commandArgs[0]);

            try
            {
                this.track.CheckEnoughRemainingLaps(numberOfLaps);
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
            }

            for (int i = 0; i < numberOfLaps; i++)
            {
                IEnumerable<string> racingDriversNames = this.racingDrivers.Keys.ToList();
                foreach (string driversName in racingDriversNames)
                {
                    this.racingDrivers[driversName].ProgressOneLap(this.track.Length);
                    if (this.racingDrivers[driversName].IsDnf())
                    {
                        this.dnfDrivers.Insert(0, this.racingDrivers[driversName]);
                        this.racingDrivers.Remove(driversName);
                    }
                }

                this.track.LapsCompleted++;

                string overtakeInfo = this.CheckForOvertaking();
                if (overtakeInfo != string.Empty)
                {
                    sb.AppendLine(overtakeInfo);
                }
            }

            return sb.ToString().Trim();
        }

        public string GetLeaderboard()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format(OutputMessages.LapsCompleted, this.track.LapsCompleted, this.track.LapsNumber));
            int counter = 1;
            IEnumerable<Driver> allDriversOrdered = this.racingDrivers.Values
                .OrderBy(this.OrderDriversByTotalTime)
                .Concat(this.dnfDrivers);

            foreach (Driver driver in allDriversOrdered)
            {
                sb.AppendLine($"{counter} {driver}");
                counter++;
            }

            return sb.ToString().Trim();
        }

        public void ChangeWeather(List<string> commandArgs) => this.track.Weather = commandArgs[0];

        public bool IsRaceOver() => this.track.HaveMoreLaps();

        public string GetWinner()
        {
            Driver winner = this.racingDrivers.Values.OrderBy(this.OrderDriversByTotalTime).First();
            return string.Format(OutputMessages.Winner, winner.Name, winner.TotalTime);
        }
    }
}
