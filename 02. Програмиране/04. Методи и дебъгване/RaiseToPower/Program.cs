namespace RaiseToPower
{
    internal class Program
    {
        static double RaiseToPower(double number, int power)
        {
            double result = 1d;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }

        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }
    }
}