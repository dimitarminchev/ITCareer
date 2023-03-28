namespace OccurrencesFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<int, int> counter = new SortedDictionary<int, int>();
            foreach (var item in list)
            {
                if (counter.ContainsKey(item))
                {
                    counter[item]++;
                }
                else
                {
                    counter.Add(item, 1);
                }
            }

            foreach (var item in counter.Keys)
            {
                Console.WriteLine("{0} -> {1}", item, counter[item]);
            }
        }
    }
}