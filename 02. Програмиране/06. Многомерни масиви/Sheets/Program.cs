namespace Sheets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][,] document = new int[n][,];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                document[i] = new int[line[0], line[1]];
                for (int j = 0; j < line[0]; j++)
                {
                    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int q = 0; q < line[1]; q++)
                    {
                        document[i][j, q] = input[q];
                    }
                }
            }
            double globalAvg = 0, localAvg = 0;
            int max = 0, min = 0;
            for (int i = 0; i < n; i++)
            {
                localAvg = 0;
                max = min = document[i][0, 0];
                for (int j = 0; j < document[i].GetLength(0); j++)
                {
                    for (int q = 0; q < document[i].GetLength(1); q++)
                    {
                        localAvg += document[i][j, q];
                        if (max < document[i][j, q]) max = document[i][j, q];
                        if (min > document[i][j, q]) min = document[i][j, q];
                    }
                }
                localAvg = localAvg / (document[i].GetLength(0) * document[i].GetLength(1));
                Console.WriteLine("{0} {1} {2}", min, max, Math.Round(localAvg, 2));
                globalAvg += localAvg;
            }
            globalAvg /= n;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < document[i].GetLength(0); j++)
                {
                    for (int q = 0; q < document[i].GetLength(1); q++)
                    {
                        if (document[i][j, q] > globalAvg) count++;
                    }
                }
                Console.Write("{0} ", count);
            }
            Console.WriteLine();
        }
    }
}