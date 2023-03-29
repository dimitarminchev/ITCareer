namespace WordsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            using (StreamReader words = new StreamReader("words.txt"))
            {
                using (StreamReader text = new StreamReader("text.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("output.txt"))
                    {
                        var line = text.ReadToEnd().ToLower().Split(' ', '?', ',', '.', '-', '!').ToArray();
                        var search = words.ReadLine();

                        while (search != null)
                        {
                            dict.Add(search, line.Count(x => x == search));
                            search = words.ReadLine();
                        }
                        dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                        
                        foreach (var item in dict)
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }

                    } 
                } 
            }
            using (StreamReader reader = new StreamReader("output.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}