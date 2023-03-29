namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ').ToArray();
            string[] secondLine = Console.ReadLine().Split(' ').ToArray();
            string[] thirdLine = Console.ReadLine().Split(' ').ToArray();

            Tuple<string, string> nameAddress = new Tuple<string, string>(firstLine[0] + " " + firstLine[1], firstLine[2]);
            Tuple<string, int> nameBeer = new Tuple<string, int>(secondLine[0], int.Parse(secondLine[1]));
            Tuple<int, double> intDouble = new Tuple<int, double>(int.Parse(thirdLine[0]), double.Parse(thirdLine[1]));

            Console.WriteLine(nameAddress);
            Console.WriteLine(nameBeer);
            Console.WriteLine(intDouble);
        }
    }
}