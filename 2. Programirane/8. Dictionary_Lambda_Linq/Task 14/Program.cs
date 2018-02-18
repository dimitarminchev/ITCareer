using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
/* 14. Поправка на email-и
Напишете програма, в която получавате последователност от низове, всеки на нов ред, докато срещнете команда “stop”. Първия низ е името на човека. На втори ред, ще получите имейл. Вашата задача е да съберете техните имена и имейли, след което трябва да премахнете имейлите, чиито домейни завършват с "us" или "uk" (без значение от големината на буквите). Извеждайте в следния формат: {name} – > {email}
Решение: Петко Люцканов
*/
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();
                if (commands[0] == "stop") break;
                string emails = Console.ReadLine();
                string names = (string.Join(" ", commands));
                if (emails.Contains("bg") && commands[0] != "stop")
                Console.WriteLine("{0} -> {1}", names, emails);
            }
        }
    }
}
