namespace Palindrom
{
    internal class Program
    {
        static bool Palindrom(string word)
        {
            string reversed = new string(word.Reverse().ToArray());
            if (word.CompareTo(reversed) == 0) return true;
            else return false;
        }

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(Palindrom(word));
        }
    }
}