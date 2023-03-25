namespace NumbersPowerOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            while (n > -1)
            {
                Console.WriteLine(num);
                num *= 2;
                n--;
            }
        }
    }
}