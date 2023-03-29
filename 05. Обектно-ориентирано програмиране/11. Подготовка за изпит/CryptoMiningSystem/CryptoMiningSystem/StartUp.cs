namespace CryptoMiningSystem
{
    using CryptoMiningSystem.Core;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            PCController controller = new PCController();

            Engine engine = new Engine(controller);
            engine.Run();
        }
    }
}
