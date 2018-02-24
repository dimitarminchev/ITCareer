using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    // 04. CODE: Phoenix Oscar Romeo November (Result: 100/100)
    class Program
    {
        static void Main(string[] args)
        {
            // Речник
            var dict = new Dictionary<String, List<String>>();

            // Обработка на входа
            string line = Console.ReadLine();
            while (line != "Blaze it!")
            {
                var Parts = line.Split('>');
                var Creature = Parts[0].Trim('-').Trim(' '); 
                var SquadMate = Parts[1].Trim(' ');
                // Условия
                if (Creature != SquadMate)
                {
                    if (!dict.ContainsKey(Creature)) dict.Add(Creature, new List<String>() { SquadMate });
                    else if(!dict[Creature].Contains(SquadMate)) dict[Creature].Add(SquadMate);
                }
                // Следващ ред
                line = Console.ReadLine();
            }

            // Премахваме дублираните
            var nope = new Dictionary<String, List<String>>(); 
            foreach (var creature in dict)
            {
                var list = new List<String>();
                foreach (var mate in creature.Value)
                {
                    if (dict.ContainsKey(mate))
                        if (dict[mate].Contains(creature.Key))
                            continue;
                    list.Add(mate);
                }
                nope.Add(creature.Key, list);
            }

            // Сортиране 
            var sorted = nope.OrderByDescending(x => x.Value.Count);

            // Отпечатване на резултата
            foreach (var item in sorted)
            Console.WriteLine("{0} : {1}", item.Key, item.Value.Count);
        }
    }
}
