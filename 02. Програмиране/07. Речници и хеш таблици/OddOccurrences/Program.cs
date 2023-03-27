namespace OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ');
            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            var results = new List<string>();
            foreach (var pair in counts)
            {
                if (pair.Value % 2 != 0)
                {
                    results.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}