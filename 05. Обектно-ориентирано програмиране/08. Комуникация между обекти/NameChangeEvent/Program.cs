namespace NameChangeEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dp = new Dispatcher();
            string input = Console.ReadLine();
            while (input != "End")
            {
                dp.Name = input;
                input = Console.ReadLine();
            }
        }
    }
}
