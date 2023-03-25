namespace Garage
{
    internal class Program
    {
        private static String repeatStr(String str, int count)
        {
            String result = "";
            for (int i = 0; i < count; i++)
            {
                result += str;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 2;

            Console.WriteLine(repeatStr("|", width));
            Console.WriteLine(repeatStr("+", width));

            int sideSpaceCount = width / 2;

            Console.WriteLine(repeatStr("|", sideSpaceCount - 3) + "GARAGE"
                             + repeatStr("|", sideSpaceCount - 3));

            for (int i = 0; i < n - 2; i++)
            {
                if (i >= (n - 2) - 2)
                {
                    Console.WriteLine("|"
                            + repeatStr("/", n - 3) + "|    |"
                            + repeatStr("\\", n - 3) + "|");
                }
                else
                {
                    Console.WriteLine(repeatStr("|", width));
                }
            }

            Console.WriteLine(repeatStr(" ", n - 2) + "/////");
        }
    }
}