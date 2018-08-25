using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        /*  Problem 2. Метод Insert 
            Напишете програма, която чете от конзолата възходяща последователност от цели числа на 
            един ред, разделени с интервал и на втори ред число, което се вмъква на такава позиция, 
            че новополучения масив отново да е възходящо подреден. Изведете: Новополучения масив и 
            Двата масива – този, преди вмъкването и другия – след вмъкването.
         */
        static void Main(string[] args)
        {
            // O(N)
            List<int> startNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> finalNumbers = new List<int>();
            int numberToInsert = int.Parse(Console.ReadLine());

            // O(N^2)
            for (int i = 0; i < startNumbers.Count; i++)
            {
                if(startNumbers[i] == numberToInsert)
                {
                    finalNumbers = startNumbers;
                    startNumbers.Insert(i, numberToInsert); 
                }                   
            }

            // 2 * O(N)
            Console.WriteLine(String.Join(" ", finalNumbers));
            Console.WriteLine(String.Join(" ", startNumbers));

            // Total: O(N) + O(N^2) + 2*O(N) = O(N^2)
        }
    }
}
