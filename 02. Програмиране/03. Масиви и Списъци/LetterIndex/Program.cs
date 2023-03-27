namespace LetterIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var letters = Console.ReadLine();
            foreach (var letter in letters)
            {
                var index = (int)letter - 97;
                Console.WriteLine($"{letter} -> {index}");
            }
        }
    }
}