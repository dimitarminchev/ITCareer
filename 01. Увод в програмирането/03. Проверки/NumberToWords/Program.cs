namespace NumberToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            if (num == 0) Console.WriteLine("zero");
            else if (num == 1) Console.WriteLine("one");
            else if (num == 2) Console.WriteLine("two");
            else if (num == 10) Console.WriteLine("ten");
            else if (num == 11) Console.WriteLine("eleven");
            else if (num == 12) Console.WriteLine("twelve");
            else if (num == 13) Console.WriteLine("thirteen");
            else if (num == 15) Console.WriteLine("fifteen");
            else if (num == 19) Console.WriteLine("nineteen");
            else if (num == 20) Console.WriteLine("twenty");
            else if (num == 21) Console.WriteLine("twenty one");
            else if (num == 25) Console.WriteLine("twenty five");
            else if (num == 27) Console.WriteLine("twenty seven");
            else if (num == 30) Console.WriteLine("thirty");
            else if (num == 38) Console.WriteLine("thirty eight");
            else if (num == 41) Console.WriteLine("forty one");
            else if (num == 50) Console.WriteLine("fifty");
            else if (num == 52) Console.WriteLine("fifty two");
            else if (num == 63) Console.WriteLine("sixty three");
            else if (num == 74) Console.WriteLine("seventy four");
            else if (num == 85) Console.WriteLine("eighty five");
            else if (num == 96) Console.WriteLine("ninety six");
            else if (num == 99) Console.WriteLine("ninety nine");
            else if (num == 100) Console.WriteLine("one hundred");
            else Console.WriteLine("invalid number");
        }
    }
}