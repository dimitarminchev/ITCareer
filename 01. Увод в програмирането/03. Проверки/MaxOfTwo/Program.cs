namespace MaxOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Greater number: " + a);
            }
            else
            {
                Console.WriteLine("Greater number: " + b);
            }
        }
    }
}