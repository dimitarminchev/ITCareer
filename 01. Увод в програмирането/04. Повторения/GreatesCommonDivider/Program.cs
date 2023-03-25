namespace GreatesCommonDivider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                var old = b;
                b = a % b;
                a = old;
            }
            Console.WriteLine("GCD = {0}", a);
        }
    }
}