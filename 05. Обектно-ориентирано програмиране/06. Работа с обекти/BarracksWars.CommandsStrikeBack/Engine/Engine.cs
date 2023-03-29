namespace BarracksWars.CommandsStrikeBack
{
    public class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private string InterpredCommand(string[] data, string commandName)
        {
            Command addCmd = new AddCommand(data, repository, unitFactory);
            Command reportcmd = new ReportCommand(data, repository, unitFactory);
            Command removecmd = new RemoveCommand(data, repository, unitFactory);
            string result = string.Empty;
            if (commandName == "fight") Environment.Exit(0);
            switch (commandName)
            {
                case "add":
                    return addCmd.Execute();
                case "report":
                    return reportcmd.Execute();
                case "fight":
                    Environment.Exit(0);
                    break;
                case "retire":
                    return removecmd.Execute();
                default:
                    throw new InvalidOperationException("Invalid command!");
            }
            return result;
        }
    }
}