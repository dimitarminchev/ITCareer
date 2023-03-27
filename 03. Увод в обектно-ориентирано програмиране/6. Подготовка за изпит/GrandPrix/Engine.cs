namespace GrandPrix
{
    public class Engine
    {
        private bool isRunning;
        private Reader reader;
        public Writer writer;
        private RaceTower raceTower;

        public Engine(Reader reader, Writer writer)
        {
            this.isRunning = false;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            this.isRunning = true;
            this.InitilizeRaceTower();

            while (this.isRunning)
            {
                string command = this.reader.ReadLine();
                try
                {
                    this.InterpredCommand(command);
                }
                catch (ArgumentException e)
                {
                    this.writer.WriteLine(e.Message);
                }

                if (this.raceTower.IsRaceOver())
                {
                    this.writer.WriteLine(this.raceTower.GetWinner());
                    this.isRunning = false;
                }
            }
        }

        private void InitilizeRaceTower()
        {
            int lapsNumber = int.Parse(this.reader.ReadLine());
            int trackLength = int.Parse(this.reader.ReadLine());
            this.raceTower = new RaceTower();
            this.raceTower.SetTrackInfo(lapsNumber, trackLength);
        }

        private void InterpredCommand(string command)
        {
            string collectedOutput = String.Empty;
            List<string> commandArgs = command.Split().ToList();
            string commandType = commandArgs[0];
            commandArgs.RemoveAt(0);

            switch (commandType)
            {
                case "RegisterDriver":
                    this.raceTower.RegisterDriver(commandArgs);
                    break;
                case "CompleteLaps":
                    collectedOutput = this.raceTower.CompleteLaps(commandArgs);
                    break;
                case "Box":
                    this.raceTower.DriverBoxes(commandArgs);
                    break;
                case "ChangeWeather":
                    this.raceTower.ChangeWeather(commandArgs);
                    break;
                case "Leaderboard":
                    collectedOutput = this.raceTower.GetLeaderboard();
                    break;
            }

            if (collectedOutput != string.Empty)
            {
                this.writer.WriteLine(collectedOutput);
            }
        }
    }
}
