namespace MaxOf2Values
{
    internal class Program
    {
        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }

        static char GetMax(char a, char b)
        {
            return a > b ? a : b;
        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) > 0) return a;
            else return b;
        }

        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    {
                        var a = int.Parse(Console.ReadLine());
                        var b = int.Parse(Console.ReadLine());
                        Console.WriteLine(GetMax(a, b));
                        break;
                    }
                case "char":
                    {
                        var a = char.Parse(Console.ReadLine());
                        var b = char.Parse(Console.ReadLine());
                        Console.WriteLine(GetMax(a, b));
                        break;
                    }
                case "string":
                    {
                        var a = Console.ReadLine();
                        var b = Console.ReadLine();
                        Console.WriteLine(GetMax(a, b));
                        break;
                    }
            }
        }
    }
}