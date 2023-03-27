namespace GrandPrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            Writer writer = new Writer();

            Engine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}