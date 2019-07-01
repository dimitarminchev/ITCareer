using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
/* 9. Сортиране на кратки думи
Въведете текст, извлечете неговите думи, намерете всички кратки думи (с по-малко от 5 знака) и ги изпечатайте в азбучен ред, с малки букви.
Решение: Живко Колев
*/
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
            {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(separators);
            var result = words.Where(w => w != "").OrderBy(w => w).Distinct();
            result = result.Where(x => x.Length > 5).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
