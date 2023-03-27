namespace HexadecimalAritmetics
{
    internal class Program
    {
        static string dec2hex(int number)
        {
            string hex = String.Empty;
            while (number > 0)
            {
                int reminder = number % 16;
                number /= 16;
                if (reminder < 10) hex += reminder.ToString();
                else hex += (char)(reminder + 55);
            }
            char[] reverse = hex.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"12+15={dec2hex(12)}+{dec2hex(15)}={12 + 15}");
            Console.WriteLine($"9+15={dec2hex(9)}+{dec2hex(15)}={9 + 15}");
            Console.WriteLine($"25-10={dec2hex(25)}-{dec2hex(10)}={25 - 10}");
            Console.WriteLine($"45-17={dec2hex(45)}-{dec2hex(17)}={45 - 17}");
            Console.WriteLine($"13*5={dec2hex(13)}*{dec2hex(5)}={13 * 5}");
            Console.WriteLine($"17*3={dec2hex(17)}*{dec2hex(3)}={17 * 3}");
            Console.WriteLine($"36/4={dec2hex(36)}/{dec2hex(4)}={36 / 4}");
            Console.WriteLine($"81/9={dec2hex(81)}/{dec2hex(9)}={81 / 9}");
        }
    }
}