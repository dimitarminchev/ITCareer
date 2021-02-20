namespace _05_Substring
{
    class Program
    {
        public static void Main()
        {
            // Вход
            string text = System.Console.ReadLine();
            int jump = int.Parse(System.Console.ReadLine());

            const char Search = 'p'; // fix: Българско (p)
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int endIndex = jump + 1;
                    if (i + endIndex >= text.Length)
                    {
                        endIndex = text.Length - i;
                    }

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
