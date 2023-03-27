namespace ShortWordsSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(separators);
            var result = words.Where(w => w != "").OrderBy(w => w).Distinct();
            result = result.Where(x => x.Length > 5).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}