namespace _638
{

    using _03BarracksFactory.Contracts;
    using _03BarracksFactory.Core;
    using _03BarracksFactory.Core.Factories;
    using _03BarracksFactory.Data;
    class AppEntryPoint
    {
        static void Main(string[] args)
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            IRunnable engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}
