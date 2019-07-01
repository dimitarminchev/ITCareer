using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    // 1.2. Problem 4. Най-дълга последователност
    class Program
    {
        // O(n^2)
        static void Main(string[] args)
        {
            // O(n)
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            // O(n^2)
            int number = 0, max = 0; // 6
            for (int i = 0; i < list.Count - 1; i++)
            {
                int counter = 1;
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[i] == list[j]) counter++;
                    else break;
                }
                if (counter > max)
                {
                    number = list[i];
                    max = counter;
                }
            }

            // O(n)
            for (int i = 0; i < max; i++) result.Add(number);

            // O(n)
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
