using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
/* 2. Телефонен указател
Напишете програма, която получава информация от конзолата за хора и техните телефонни номера. Всеки запис трябва да има само едно име и телефон (и двете се пазят в низ). 
На всеки ред ще получите някоя от следните команди:
- A {име} {телефон} = добавя записа към телефонния указател. В случай че се добавя име, което вече съществува в указателя трябва да смените съществуващия номер с новия.
- S {име} = търси се човек с такива име и се извежда резултат във формат "{име} -> {номер}". В случай на несъществуващ контакт, изведете "Contact {име} does not exist.".
- END = спира получаването на команди.
Решение: Павел Недков
*/
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, string>();
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
                    // Изход от програмата
                    case "END":  return;
                }
            }
        }
    }
}
