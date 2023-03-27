namespace CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter centuries:");
            int vek = int.Parse(Console.ReadLine());
            int god = vek * 100;
            int dni = (int)(god * 365.2422);
            int chas = 24 * dni;
            int min = chas * 60;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", vek, god, dni, chas, min);
        }
    }
}