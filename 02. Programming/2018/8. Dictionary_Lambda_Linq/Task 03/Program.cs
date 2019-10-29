using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
/* 3. Миньорска задача
Получавате поредица от низове, всеки на нов ред. Всеки нечетен ред на конзолата показва 
полезно изкопаемо (злато, сребро, мед и т.н.), а всеки четен - количество. 
Вашата задача е да съберете изкопаемите и да изпечатате всяко на нов ред. 
Изведете изкопаемите и техните количества във формат: {resource} -> {quantity}
Количествата ще бъдат в интервала [1 ... 2000000000]
Решение: Христо Димитров
*/
    class Program
    {
        static void Main(string[] args)
        {
            // Съдаваме речник
            var goldMiners = new Dictionary<string, int>();

            // Добавяме записи към речника
            while (true)
            {
                string key = Console.ReadLine();
                if (key == "stop") break;
                int value = int.Parse(Console.ReadLine());
                goldMiners.Add(key, value);
            }

            // Извеждаме записите от речника
            foreach (var pair in goldMiners)
            Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
        }
    }
}
