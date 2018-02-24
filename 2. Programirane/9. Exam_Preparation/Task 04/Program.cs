using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    // 04. CODE: Phoenix Oscar Romeo November
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<String, List<String>>();
            string line = Console.ReadLine();
            while (line != "Blaze it!")
            {
                var Parts = line.Split('>');
                var Creature = (Parts[0].Trim('-')).Trim(' '); // Creature
                var SquadMate = Parts[1].Trim(' '); // SquadMate 

                // New Creature
                if (!dict.ContainsKey(Creature))
                {
                    var mates = new List<String>();
                    mates.Add(SquadMate);
                    dict.Add(Creature, mates);
                }
                // Existing Creature
                else 
                {
                    var mates = dict[Creature];
                    mates.Add(SquadMate);
                }

                // Next Line
                line = Console.ReadLine();
            }

/*
            // TODO: Remove Duplicates
            var noDupl = new Dictionary<String, List<String>>();
            foreach (var creature in dict)
            {
                List<String> NewMates = new List<String>();
                var exclude = dict.Keys.Where(x => x != creature.Key).ToList();
                foreach (var mate in creature.Value)
                  foreach(var item in exclude)
                        if(mate != item && !NewMates.Contains(mate))
                            NewMates.Add(mate);
                // No Duplicates
                noDupl.Add(creature.Key, NewMates);
            }
*/
            // Print
            foreach (var item in dict)
            Console.WriteLine("{0} : {1}", item.Key, item.Value.Count);
        }
    }
}
