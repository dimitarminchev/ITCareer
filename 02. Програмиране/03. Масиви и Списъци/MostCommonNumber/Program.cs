namespace MostCommonNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int[] num = new int[100];
            var line = Console.ReadLine();
            var splitted = line.Split(' ');

            foreach (var item in splitted)
            {
                num[n++] = int.Parse(item);
            }

            int[] counter = new int[65535];

            for (int i = 0; i < n; i++)
            {
                counter[num[i]]++;
            }

            int max = -1000, maxi = 0;
            for (int j = 0; j < 65535; j++)
            {
                if (counter[j] > max)
                {
                    max = counter[j];
                    maxi = j;
                }
            }

            Console.WriteLine(maxi);
        }
    }
}