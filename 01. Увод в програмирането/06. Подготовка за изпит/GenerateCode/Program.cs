namespace GenerateCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long passCode = long.Parse(Console.ReadLine());
            int codesWanted = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        for (char l = 'a'; l <= 'z'; l++)
                        {
                            for (char m = 'a'; m <= 'z'; m++)
                            {
                                for (int n = 0; n <= 9; n++)
                                {
                                    if (i + j + k + l + m + n == passCode)
                                    {
                                        Console.WriteLine("" + i + j + k + l + m + n + " ");
                                        count++;
                                    }
                                    if (count == codesWanted)
                                    {
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}