namespace WordsArrangement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            List<string> result = new List<string>();
            var minimum = words.First();
            for (int m = 0; m < words.Count; m++)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    if (words[i].CompareTo(minimum) < 0)
                    {
                        minimum = words[i];
                    }
                }
                result.Add(minimum);
                words.Remove(minimum);
                minimum = words.First();
            }
            result.Add(words.First());

            Console.WriteLine(String.Join(" ", result));
        }
    }
}