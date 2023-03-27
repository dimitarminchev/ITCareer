namespace HexadecimalVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(a, 16));
        }
    }
}