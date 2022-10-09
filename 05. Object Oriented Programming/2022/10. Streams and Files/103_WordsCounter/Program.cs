using static System.Net.Mime.MediaTypeNames;

namespace _103_WordsCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            // Step 1. words.txt
            using (StreamReader words = new StreamReader("words.txt"))
            {
                // Step 2. test.txt
                using (StreamReader text = new StreamReader("text.txt"))
                {
                    // Step 3. output.txt
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

                    } // writer.Dispose(); // CleanUp
                } // text.Dispose(); // CleanUp
            } // words.Dispose(); // CleanUp

            // Step 4. Print the result file 'output.txt'
            using (StreamReader reader = new StreamReader("output.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());
            }

        }
    }
}