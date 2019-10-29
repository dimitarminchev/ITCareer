using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_08
{
    /// <summary>
    /// Task 08. Anonymous Cache (Result: 80/100)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Речник и кеш
            var data = new Dictionary<String, Dictionary<String, long>>();
            var cache = new Dictionary<String, Dictionary<String, long>>();

            // Обработка на входните данни
            string line = Console.ReadLine();
            while (line != "thetinggoesskrra")
            {
                var parts = line.Replace(" -> ", ";").Replace(" | ", ";").Split(';');
                if (parts.Count() > 1)
                {
                    String dataKey = parts[0];
                    long dataSize = long.Parse(parts[1]);
                    String dataSet = parts[2];

                    // Добавяне към речника
                    if (data.ContainsKey(dataSet)) data[dataSet].Add(dataKey, dataSize);
                    // Добаввяне към кеша
                    else if (!cache.ContainsKey(dataSet)) cache.Add(dataSet, new Dictionary<string, long>() { { dataKey, dataSize } });
                    else cache[dataSet].Add(dataKey, dataSize);

                }
                else if(parts[0] != "thetinggoesskrra")
                {
                    String dataSet = parts[0];
                    // Има ли го това множеството в кеша?
                    if (cache.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, cache[dataSet]);
                        cache.Remove(dataSet);
                    }
                    // Ново множество
                    else data.Add(dataSet, new Dictionary<string, long>());
                }
                line = Console.ReadLine();
            }

            // Масимална сума (Labda Expression)
            long max = data.Values.Max(x => x.Values.Sum());

            // Печат
            foreach(var dataSet in data)
            {
                // Сума на елементите в множеството (Labda Expression)
                long sum = dataSet.Value.Sum(x => x.Value);
                if (sum == max)
                {
                    Console.WriteLine("Data Set: {0}, Total Size: {1}", dataSet.Key, sum);
                    foreach (var dataKey in dataSet.Value) Console.WriteLine("$.{0}", dataKey.Key);
                }
            }            
        }
    }
}
