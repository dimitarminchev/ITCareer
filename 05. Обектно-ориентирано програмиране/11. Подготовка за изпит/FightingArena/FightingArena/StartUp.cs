namespace HeroFight
{
    using HeroFight.Core;

    public class StartUp
    {
        static void Main(string[] args)
        {
            ArenaController controller = new ArenaController();
            Engine engine = new Engine(controller);
            engine.Run();
        }
    }
}
