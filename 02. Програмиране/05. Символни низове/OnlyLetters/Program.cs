namespace OnlyLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string last = "", result = "";
            for (int i = line.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(line[i]))
                {
                    if (last != "") result += last;
                    else result += line[i].ToString();
                }
                else
                {
                    last = line[i].ToString();
                    result += line[i].ToString();
                }
            }
            Console.WriteLine(new string(result.Reverse().ToArray()));
        }
    }
}