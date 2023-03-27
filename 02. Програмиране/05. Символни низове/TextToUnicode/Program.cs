namespace TextToUnicode
{
    internal class Program
    {
        static string TextToUnicode(string input)
        {
            string result = String.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                string code = "\\" + ((int)input[i]).ToString("X4");
                result = String.Concat(result, code.ToLower());
            }
            return result;
        }

        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var unicode = TextToUnicode(text);
            Console.WriteLine(unicode);
        }
    }
}