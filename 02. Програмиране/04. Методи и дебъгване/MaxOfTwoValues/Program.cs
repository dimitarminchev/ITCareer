namespace MaxOfTwoValues
{
    internal class Program
    {
        static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static char GetMax(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    {
                        int first = int.Parse(Console.ReadLine());
                        int second = int.Parse(Console.ReadLine());
                        int max = GetMax(first, second);
                        Console.WriteLine(max);
                        break;
                    }

                case "char":
                    {
                        char first = char.Parse(Console.ReadLine());
                        char second = char.Parse(Console.ReadLine());
                        char max = GetMax(first, second);
                        Console.WriteLine(max);
                        break;
                    }

                case "string":
                    {
                        string first = Console.ReadLine();
                        string second = Console.ReadLine();
                        string max = GetMax(first, second);
                        Console.WriteLine(max);
                        break;
                    }
            }
        }
    }
}