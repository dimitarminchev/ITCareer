namespace PhoenixGrid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (message != "ReadMe")
            {
                bool IsAPalindrome = true;

                for (int i = 3; i <= message.Length - 1; i += 4)
                {
                    if (message[i] != '.')
                    {
                        IsAPalindrome = false;
                    }
                }

                if (message.Contains(' ') || message.Contains('_') || message.Contains('\t'))
                {
                    IsAPalindrome = false;
                }

                for (int i = 0; i <= message.Length / 2; i++)
                {
                    if (message[i] != message[message.Length - 1 - i])
                    {
                        IsAPalindrome = false;
                    }
                }

                if (IsAPalindrome == true)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

                message = Console.ReadLine();
            }
        }
    }
}