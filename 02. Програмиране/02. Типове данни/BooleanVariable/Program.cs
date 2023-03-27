namespace BooleanVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Convert.ToBoolean(n);
            if (n == "True") Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}