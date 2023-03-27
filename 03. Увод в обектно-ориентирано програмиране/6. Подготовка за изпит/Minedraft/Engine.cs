namespace Minedraft
{
    public class Engine
    {
        private bool isRunning;
        private DraftManager draftManager;

        public Engine()
        {
            this.isRunning = true;
            this.draftManager = new DraftManager();
        }

        public void Run()
        {
            while (this.isRunning)
            {
                string inputLine = this.ReadInput();
                List<string> commandArgs = this.ParseInput(inputLine);
                this.DistributeCommand(commandArgs);
            }
        }

        private void DistributeCommand(List<string> commandArgs)
        {
            string command = commandArgs[0];
            commandArgs.Remove(command);

            switch (command)
            {
                case "RegisterHarvester":
                    this.OutputWriter(this.draftManager.RegisterHarvester(commandArgs));
                    break;
                case "RegisterProvider":
                    this.OutputWriter(this.draftManager.RegisterProvider(commandArgs));
                    break;
                case "Day":
                    this.OutputWriter(this.draftManager.Day());
                    break;
                case "Mode":
                    this.OutputWriter(this.draftManager.Mode(commandArgs));
                    break;
                case "Check":
                    this.OutputWriter(this.draftManager.Check(commandArgs));
                    break;
                case "Shutdown":
                    this.OutputWriter(this.draftManager.ShutDown());
                    this.isRunning = false;
                    break;
            }
        }

        private void OutputWriter(string status) => Console.WriteLine(status);
        private List<string> ParseInput(string inputCommand) => inputCommand.Split(' ').ToList();
        private string ReadInput() => Console.ReadLine();
    }

}
