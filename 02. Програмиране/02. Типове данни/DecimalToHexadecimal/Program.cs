namespace DecimalToHexadecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            string b = Convert.ToString(a, 16).ToUpper();
            string c = Convert.ToString(a, 2).ToUpper();
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}