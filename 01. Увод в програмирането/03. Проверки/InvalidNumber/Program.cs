namespace InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            if (a < 100 || a > 200 || a != 0)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}