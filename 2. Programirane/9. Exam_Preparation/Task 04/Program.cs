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
            var dict = new Dictionary<string, List<String>>();
            string line = Console.ReadLine();
            while (line != "Blaze it!")
            {
                var Parts = line.Split('>');
                var Creature = Parts[0].Trim(' ').Trim('-'); // Creature
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
                    if(mates.IndexOf(SquadMate) == -1)
                    mates.Add(SquadMate);
                }

                // Next
                line = Console.ReadLine();
            }

            // Print
            foreach (var item in dict)
            Console.WriteLine("{0} : {1}", item.Key, item.Value.Count);
        }
    }
}
