namespace StringReverse
{
    internal class Program
    {
        static string StringReverse(string input)
        {
            string result = String.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result = String.Concat(result, input[i].ToString());
            }
            return result;
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(StringReverse(input));
        }
    }
}