namespace NumbersEnding7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int k = 0; k < 1000; k++)
            {
                if (k % 10 == 7)
                {
                    Console.Write(k + " ");
                }
            }
        }
    }
}