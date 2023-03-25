namespace UsdToBgn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD = ");
            var USD = double.Parse(Console.ReadLine());
            var BGN = USD * 1.79549;
            Console.WriteLine("BGN = {0}", BGN);
        }
    }
}