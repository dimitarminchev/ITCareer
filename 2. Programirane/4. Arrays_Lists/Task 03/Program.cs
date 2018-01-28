using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
/* 3. Индекс на буква
Напишете програма, която създава масив, съдържащ всички букви от английската азбука (a-z). Въведете дума с малки букви (lowercase) от конзолата и изведете съответния индекс на всяка буква от масива с буквите от английската азбука.
*/
    class Program
    {
        // Решение: Димитър Минчев
        static void Main(string[] args)
        {
            // Четем ред от конзолата
            var line = Console.ReadLine();

            // Отпечатваме всеки символ от прочетения ред
            foreach (var item in line)
            Console.WriteLine("{0} -> {1}", item, (int)item-97);
         
        }
    }
}
