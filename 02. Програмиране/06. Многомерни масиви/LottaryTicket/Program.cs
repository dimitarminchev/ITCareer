namespace LottaryTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = line[0], m = line[1];
            int[,] ticket = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < m; col++)
                {
                    ticket[row, col] = line[col];
                }
            }

            double d1 = 0, d2 = 0, d1upSum = 0, d1downSum = 0;
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    if (x == y)
                    {
                        d1 += ticket[x, y];
                    }
                    else if (x > y)
                    {
                        d1downSum += ticket[x, y];
                    }
                    else if (y > x)
                    {
                        d1upSum += ticket[x, y];
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                d2 += ticket[i, n - 1 - i];
            }

            if (d1 == d2 && d1upSum % 2 == 0 && d1downSum % 2 != 0)
            {
                double d1even = 0;
                for (int x = 0; x < n; x++)
                {
                    for (int y = 0; y < m; y++)
                    {
                        if (x == y && ticket[x, y] % 2 == 0)
                        {
                            d1even += ticket[x, y];
                        }
                    }
                }

                double extRowEven = 0;
                for (int j = 0; j < m; j++)
                {
                    if (ticket[0, j] % 2 == 0)
                    {
                        extRowEven += ticket[0, j];
                    }
                    if (ticket[n - 1, j] % 2 == 0)
                    {
                        extRowEven += ticket[n - 1, j];
                    }
                }

                double extColOdd = 0;
                for (int j = 0; j < n; j++)
                {
                    if (ticket[j, 0] % 2 != 0)
                    {
                        extColOdd += ticket[j, 0];
                    }
                    if (ticket[j, m - 1] % 2 != 0)
                    {
                        extColOdd += ticket[j, m - 1];
                    }
                }

                double profit = (d1downSum + d1even + extRowEven + extColOdd) / 4.0;
                Console.WriteLine("YES\nThe amount of money won is: {0:f2}", profit);
            }
            else Console.WriteLine("NO");
        }
    }
}