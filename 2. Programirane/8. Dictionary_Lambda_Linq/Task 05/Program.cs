using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
/* 5. Брой на реалните числа
Въведете списък от реални числа и ги изведете в нарастващ ред заедно с броя на срещанията им.
Решение: Божидар Марков
*/
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(float.Parse);
            var counts = new SortedDictionary<float, int>();

            // Преброяваме срещанията на числата
            foreach (var num in nums)
                if (counts.ContainsKey(num)) counts[num]++;
                else counts[num] = 1;

            // Извеждаме резултата
            foreach (var pair in counts)
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
        }
    }
}
