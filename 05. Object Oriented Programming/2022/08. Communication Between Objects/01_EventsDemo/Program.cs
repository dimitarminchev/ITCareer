namespace _01_EventsDemo
{
    /// <summary>
    /// Главна програма
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dp = new Dispatcher();

            var line = System.Console.ReadLine();
            while (line != "End")
            {
                dp.Name = line;
                line = System.Console.ReadLine();
            }
        }
    }
}