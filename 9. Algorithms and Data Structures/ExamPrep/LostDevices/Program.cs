using System;
using System.Collections.Generic;
using System.Linq;

namespace LostDevices
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pigeons = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToList();
            List<int> mail = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToList();
            List<int> positionDifferences = new List<int>();
            for(int i = 0; i< pigeons.Count; i++)
            {
                positionDifferences.Add(Math.Abs(pigeons[i] - mail[i]));
            }
            Console.WriteLine("Job done in {0} hours", positionDifferences.Max());
        }
    }
}
