using System;
using System.Diagnostics.Metrics;

namespace LicencePlates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstPart = Console.ReadLine();
            var lastPart = Console.ReadLine();
            var platesWanted = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        for (int l = 0; l < 10; l++)
                        {

                            if (counter < platesWanted)
                            {
                                if (i + j + k + l == (i * k) - platesWanted)
                                {
                                    Console.Write(firstPart + i + j + k + l + lastPart + " ");
                                    counter++;
                                }
                            }

                        }
                    }
                }
            }
        }
    }
}