using System;
using System.Linq;

namespace Task_09
{
    /// <summary>
    /// Task 09. Raindrops (Result: 100/100)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfRegions = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());
            uint[] regionInformation = new uint[1];
            decimal sumregionalcoefficient = 0;
            for (int i = 0; i < amountOfRegions; i++)
            {
                regionInformation = Console.ReadLine().Split(' ').Select(uint.Parse).ToArray();
                uint raindropsCount = regionInformation[0];
                uint squareMeters = regionInformation[1];
                decimal regionalCoefficient = (decimal)raindropsCount / squareMeters;
                sumregionalcoefficient = sumregionalcoefficient + regionalCoefficient;
            }
            if (density > sumregionalcoefficient)  Console.WriteLine("{0:f3}", sumregionalcoefficient);
            else if (density == 0) Console.WriteLine("{0:f3}", sumregionalcoefficient);
            else
            {
                decimal output = sumregionalcoefficient / density;
                Console.WriteLine("{0:f3}", output);
            }
        }
    }
}
