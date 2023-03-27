namespace DecimalNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n1 = decimal.Parse(Console.ReadLine());
            var n2 = decimal.Parse(Console.ReadLine());
            var n3 = decimal.Parse(Console.ReadLine());
            var n4 = decimal.Parse(Console.ReadLine());
            Console.WriteLine(n1 + n2 + n3 + n4);
        }
    }
}