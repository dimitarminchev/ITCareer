namespace BarracksWars.CommandsStrikeBack
{
    public abstract class Command : IExecutable
    {
        private string[] data;

        private IRepository repository;

        private IUnitFactory unitFactory;

        protected Command(string[] data, IRepository repo, IUnitFactory fatory)
        {
            this.unitFactory = fatory;
            this.repository = repo;
            this.data = data;
        }

        protected IRepository Repository { get { return repository; } }

        protected IUnitFactory UnitFactory { get { return unitFactory; } }

        protected string[] Data { get { return data; } }

        public abstract string Execute();
    }
}