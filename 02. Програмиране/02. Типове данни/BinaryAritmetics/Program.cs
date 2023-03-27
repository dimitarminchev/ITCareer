namespace BinaryAritmetics
{
    internal class Program
    {
        static string dec2bin(int number)
        {
            string binary = String.Empty;
            while (number > 0)
            {
                int reminder = number % 2;
                number /= 2;
                binary += reminder;
            }
            char[] reverse = binary.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"12+15={dec2bin(12)}+{dec2bin(15)}={12 + 15}");
            Console.WriteLine($"9+15={dec2bin(9)}+{dec2bin(15)}={9 + 15}");
            Console.WriteLine($"25-10={dec2bin(25)}-{dec2bin(10)}={25 - 10}");
            Console.WriteLine($"45-17={dec2bin(45)}-{dec2bin(17)}={45 - 17}");
            Console.WriteLine($"13*5={dec2bin(13)}*{dec2bin(5)}={13 * 5}");
            Console.WriteLine($"17*3={dec2bin(17)}*{dec2bin(3)}={17 * 3}");
            Console.WriteLine($"36/4={dec2bin(36)}/{dec2bin(4)}={36 / 4}");
            Console.WriteLine($"81/9={dec2bin(81)}/{dec2bin(9)}={81 / 9}");
        }
    }
}