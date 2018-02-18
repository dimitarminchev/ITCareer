using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
/* 6. Подобрен телефонен указател
Добавете функционалност към указателя от предната задача да извежда всички контакти в азбучен ред, когато получи командата "ListAll".
Решение: Ангел Ангелов
*/
    class Program
    {
        static void Main(string[] args)
        {
            var book = new SortedDictionary<string, string>();
            while (true)
            {
                var line = Console.ReadLine().Split(' ');
                switch (line[0])
                {
                    // Добавяне на запис в речника
                    case "A":
                        {
                            book[line[1]] = line[2];
                            break;
                        }
                    // Търсене на запис в речника
                    case "S":
                        {
                            if (book.ContainsKey(line[1])) Console.WriteLine("{0} -> {1}", line[1], book[line[1]]);
                            else Console.WriteLine("Contact {0} does not exist.", line[1]);
                            break;
                        }
                    // Отпечатване на всички команди 
                    case "ListAll":
                        {
                            foreach (var pair in book)
                                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                            break;
                        }
                    // Изход от програмата
                    case "END": return;
                }
            }
        }
    }
}
