using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class RaceTower
    {
        private int currentLap;
        private int totalLaps;
        private int trackLength;
        private string weather;
        private List<Driver> drivers = new List<Driver>();


        public void SetTrackInfo(int lapsNumber, int trackLength)
        {
            totalLaps = lapsNumber;
            this.trackLength = trackLength;
            weather = "Sunny";
        }
        public void RegisterDriver(List<string> commandArgs)
        {
            double grip = commandArgs.Count == 7 ? 0 : double.Parse(commandArgs[7]);
            drivers.Add
            (
                new Driver
                (
                    commandArgs[1],
                    commandArgs[2],
                    int.Parse(commandArgs[3]),
                    double.Parse(commandArgs[4]),
                    commandArgs[5],
                    double.Parse(commandArgs[6]),
                    grip
                )
            );
        }

        public void DriverBoxes(List<string> commandArgs)
        {
            var who = drivers.Where(x => x.Name == commandArgs[2]).First();
            if (commandArgs[1] == "Refuel")
            {
                who.Car.FuelAmount += double.Parse(commandArgs[3]);
                if (who.Car.FuelAmount > 160) who.Car.FuelAmount = 160;
            }
            if (commandArgs[2] == "ChangeTyres")
            {
                double grip = commandArgs[3] == "Ultrasoft" ? double.Parse(commandArgs[5]) : 0;
                who.Car.Tyre.Hardness = double.Parse(commandArgs[4]);
                who.Car.Tyre.Grip = grip;
                who.Car.Tyre.Degradation = 100;
            }
        }

        public string CompleteLaps(List<string> commandArgs)
        {
            // Number of Laps
            int requestedLaps = int.Parse(commandArgs[1]);
            if (requestedLaps + currentLap > totalLaps) return $"There is no time!On lap {currentLap}.";

            for (int i = 1; i < requestedLaps; i++)
            {
                // Processing Single Lap
                foreach (var driver in drivers)
                {
                    driver.TotalTime += 60 / (trackLength / driver.Speed);
                    driver.Car.FuelAmount -= trackLength * driver.FuelConsumptionPerKm;
                    driver.Car.Tyre.Degradation -= driver.Car.Tyre.Hardness + driver.Car.Tyre.Grip;
                    driver.Speed = (driver.Car.HP + driver.Car.Tyre.Degradation) / driver.Car.FuelAmount;
                }
                //OverTake
                var sortedDrivers = drivers.OrderBy(x => x.TotalTime).ToList();
                for (int j = 0; j < drivers.Count - 1; j++)
                {
                    int allowedTime = 2;
                    if (sortedDrivers[j].Type == "Aggressive" && sortedDrivers[j].Car.Tyre.Name == "Ultrasoft" ||
                       sortedDrivers[j].Type == "Endurance" && sortedDrivers[j].Car.Tyre.Name == "Hard")
                    {
                        allowedTime = 3;
                        //if (weather == "Foggy") hasCrashed = true;
                    }
                    if (sortedDrivers[j + 1].TotalTime - sortedDrivers[j].TotalTime <= allowedTime)
                    {
                        sortedDrivers[j + 1].TotalTime += 2;
                        sortedDrivers[j].TotalTime -= 2;
                    }
                }
                if (requestedLaps + currentLap == totalLaps)
                {
                    var temp = drivers.OrderBy(x => x.TotalTime).First();
                    return $"{temp.Name} wins the race for {temp.TotalTime:f3} seconds";
                }

            }
            currentLap += requestedLaps;
            return string.Empty;
        }

        public string GetLeaderboard()
        {
            string leaderboard = $"Lap {currentLap}/{totalLaps} \n";
            List<Driver> sortedDrivers = drivers.OrderBy(x => x.TotalTime).ToList();
            for (int i = 0; i < drivers.Count; i++)
            {
                leaderboard += $"{i + 1} {sortedDrivers[i].Name} {sortedDrivers[i].TotalTime:f3} \n";
            }
            return leaderboard;
            //TODO FAILURES
        }

        public void ChangeWeather(List<string> commandArgs)
        {
            weather = commandArgs[1];
        }

    }
}
