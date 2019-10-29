using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MaxEqualNumbers
{
    class Program
    {
        // 10. Максимална поредица еднакви числа
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int seq = 1, maxSeq = 1, mostCommonNumber = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1]) seq++;
                else seq = 1;
                if (seq > maxSeq)
                {
                    maxSeq = seq;
                    mostCommonNumber = numbers[i];
                }
            }
            for (int i = 0; i < maxSeq; i++)
                Console.Write(mostCommonNumber + " ");
        }
    }
}
