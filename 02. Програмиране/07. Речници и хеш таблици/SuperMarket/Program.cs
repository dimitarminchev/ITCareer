namespace SuperMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Market = new Dictionary<string, Tuple<float, int>>();

            while (true)
            {
                var line = Console.ReadLine().Split(' ');
                if (line[0] == "stocked") break;

                float key = float.Parse(line[1]);
                int value = int.Parse(line[2]);
                Market.Add(line[0], new Tuple<float, int>(key, value));
            }

            double total = 0;
            foreach (var pair in Market)
            {
                float sum = pair.Value.Item1 * pair.Value.Item2;
                Console.WriteLine("{0}: ${1:f2} * {2} = ${3:f2}",
                                   pair.Key, pair.Value.Item1, pair.Value.Item2, sum);
                total += sum;
            }

            Console.WriteLine(new String('-', 30));
            Console.WriteLine("Grand Total: ${0:f2}", total);
        }
    }
}