using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var volunteers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var hats = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            volunteers.Sort();
            hats.Sort();
            int counter = 0;
            int volcount = 0;
            int hatcount = 0;
            while (volcount < volunteers.Count && hatcount < hats.Count)
            {
                if (hats[hatcount] >= volunteers[volcount])
                {
                    counter++;
                    volcount++;
                    hatcount++;
                }
                else
                {
                    hatcount++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
