namespace AnonymousCache
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<String, Dictionary<String, long>>();
            var cache = new Dictionary<String, Dictionary<String, long>>();

            string line = Console.ReadLine();
            while (line != "thetinggoesskrra")
            {
                var parts = line.Replace(" -> ", ";").Replace(" | ", ";").Split(';');
                if (parts.Count() > 1)
                {
                    String dataKey = parts[0];
                    long dataSize = long.Parse(parts[1]);
                    String dataSet = parts[2];

                    if (data.ContainsKey(dataSet))
                    {
                        data[dataSet].Add(dataKey, dataSize);
                    }
                    else if (!cache.ContainsKey(dataSet))
                    {
                        cache.Add(dataSet, new Dictionary<string, long>() { { dataKey, dataSize } });
                    }
                    else
                    {
                        cache[dataSet].Add(dataKey, dataSize);
                    }

                }
                else if (parts[0] != "thetinggoesskrra")
                {
                    String dataSet = parts[0];
                    if (cache.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, cache[dataSet]);
                        cache.Remove(dataSet);
                    }
                    else
                    {
                        data.Add(dataSet, new Dictionary<string, long>());
                    }
                }
                line = Console.ReadLine();
            }

            long max = data.Values.Max(x => x.Values.Sum());

            foreach (var dataSet in data)
            {
                long sum = dataSet.Value.Sum(x => x.Value);
                if (sum == max)
                {
                    Console.WriteLine("Data Set: {0}, Total Size: {1}", dataSet.Key, sum);
                    foreach (var dataKey in dataSet.Value)
                    {
                        Console.WriteLine("$.{0}", dataKey.Key);
                    }
                }
            }
        }
    }
}