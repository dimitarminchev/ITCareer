namespace WordsRegister
{
    internal class Program
    {
        static bool Upper(string word)
        {
            foreach (var character in word)
            {
                if (Char.IsLower(character))
                {
                    return false;
                }
            }
            return true;
        }

        static bool Lower(string word)
        {
            foreach (var character in word)
            {
                if (Char.IsUpper(character))
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();

            List<string> LowerCase = new List<string>();
            List<string> MixedCase = new List<string>();
            List<string> UpperCase = new List<string>();

            foreach (var word in words)
            {
                if (Lower(word)) LowerCase.Add(word);
                else if (Upper(word)) UpperCase.Add(word);
                else MixedCase.Add(word);
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", LowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", MixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", UpperCase));
        }
    }
}