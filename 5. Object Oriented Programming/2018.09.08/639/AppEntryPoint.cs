namespace _639
{

    using _03BarracksFactory.Contracts;
    using _03BarracksFactory.Core;
    using _03BarracksFactory.Core.Factories;
    using _03BarracksFactory.Data;
    using _6._3._7.Core;

    class AppEntryPoint
    {
        static void Main(string[] args)
        {
            
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            ICommandInterpreter commandInterpreter = new CommandInterpretator(repository, unitFactory);
            IRunnable engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
