namespace Factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fak = 1;
            var j = 1;
            do
            {
                fak = fak * j;
                j++;
            }
            while (j <= n);
            Console.WriteLine(fak);
        }
    }
}