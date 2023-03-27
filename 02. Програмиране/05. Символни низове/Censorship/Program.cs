namespace Censorship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(' ');
            string text = Console.ReadLine();

            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord, new string('*', banWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}