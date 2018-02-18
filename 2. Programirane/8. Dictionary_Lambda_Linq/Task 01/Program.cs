using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
/* 1. Нечетни срещания
Напишете програма, която извлича от поредица от думи всички елементи, които се срещат нечетен брой пъти (без значение от големината на буквите)
- Думите са въведени на един ред разделени с интервал
- Изведете получените думи с малки бувки, по реда им на поява
Решение: Валентин Хаджиминов
*/
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');
            var counts = new Dictionary<string, int>();

            // Преброяваме срещанията на думите
            foreach (var word in words)
            if (counts.ContainsKey(word)) counts[word]++;
            else counts[word] = 1;

            // Извеждаме резултата
            var results = new List<string>();
            foreach (var pair in counts)
                if (pair.Value % 2 != 0)
                    results.Add(pair.Key);
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
