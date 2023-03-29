namespace Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ').ToArray();
            string[] secondLine = Console.ReadLine().Split(' ').ToArray();
            string[] thirdLine = Console.ReadLine().Split(' ').ToArray();

            bool isDrunk = secondLine[2] == "drunk" ? true : false;
            Threeuple<string, string, string> nameAddressTown = new Threeuple<string, string, string>
                (firstLine[0] + " " + firstLine[1], firstLine[2], firstLine[3]);

            Threeuple<string, int, bool> nameBeerDrunk = new Threeuple<string, int, bool>
                (secondLine[0], int.Parse(secondLine[1]), isDrunk);

            Threeuple<string, double, string> nameBalanceBank = new Threeuple<string, double, string>
                (thirdLine[0], double.Parse(thirdLine[1]), thirdLine[2]);

            Console.WriteLine(nameAddressTown);
            Console.WriteLine(nameBeerDrunk);
            Console.WriteLine(nameBalanceBank);
        }
    }
}