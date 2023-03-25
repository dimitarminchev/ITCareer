namespace LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (var letter = 'a'; letter <= 'z'; letter++)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();
        }
    }
}