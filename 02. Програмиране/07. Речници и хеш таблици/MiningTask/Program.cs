namespace MiningTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var goldMiners = new Dictionary<string, int>();

            while (true)
            {
                string key = Console.ReadLine();
                if (key == "stop") break;
                int value = int.Parse(Console.ReadLine());
                goldMiners.Add(key, value);
            }

            foreach (var pair in goldMiners)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}