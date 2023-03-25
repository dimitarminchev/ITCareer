namespace WholeNumberSign
{
    internal class Program
    {
        static void NumberCheck(int num)
        {
            if (num < 0) Console.WriteLine("The number {0} is negative.", num);
            if (num > 0) Console.WriteLine("The number {0} is positive.", num);
            if (num == 0) Console.WriteLine("The number 0 is zero.");
        }

        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            NumberCheck(num);
        }
    }
}