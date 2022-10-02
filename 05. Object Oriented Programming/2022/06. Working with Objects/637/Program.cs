namespace _637
{
    internal class Program
    {
        // 637
        static void Main(string[] args)
        {
            IRepository repository = new UnitRepository();

            IUnitFactory unitFactory = new UnitFactory();

            IRunnable engine = new Engine(repository, unitFactory);

            engine.Run();
        }
    }
}