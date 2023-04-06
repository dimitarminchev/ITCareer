namespace Bankomat
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 1000 && n < 1)
            {
                n = int.Parse(Console.ReadLine());
            }
            int number = 0;
            if (n > 0)
            {
                number += n / 100;
                n -= 100 * (n / 100);
            }
            if (n > 0)
            {
                number += n / 50;
                n -= 50 * (n / 50);
            }
            if (n > 0)
            {
                number += n / 20;
                n -= 20 * (n / 20);
            }
            if (n > 0)
            {
                number += n / 10;
                n -= 10 * (n / 10);
            }
            if (n > 0)
            {
                number += n / 5;
                n -= 5 * (n / 5);
            }
            if (n > 0)
            {
                number += n / 2;
                n -= 2 * (n / 2);
            }
            if (n > 0)
            {
                number += n / 1;
                n -= 1 * (n / 1);
            }
            Console.WriteLine(number);
        }
    }
}