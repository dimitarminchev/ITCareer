using System;
using System.Linq;

class Program
{
    private static int FindFuel(int[] cities)
    {
        int n = cities.Length;
        int[] fuel = new int[n];
        fuel[n - 1] = cities[n - 1];

        for (int i = n - 2; i >= 0; i--)
        {
            fuel[i] = cities[i] + Math.Min(fuel[i + 1], i + 2 < n ? fuel[i + 2] : 0);
        }

        return Math.Min(fuel[0], fuel[1]);
    }

    public static void Main()
    {
        int[] cities = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(FindFuel(cities));
    }
}