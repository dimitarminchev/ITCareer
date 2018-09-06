using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _481
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> citizensAndRobots = new List<IIdentifiable>();
            string[] line = Console.ReadLine().Split().ToArray();
            while(line[0]!="End")
            {
                if(line.Length == 2)
                {
                    citizensAndRobots.Add(new Robot(line[0], line[1]));
                }
                else citizensAndRobots.Add(new Citizen(line[0] , int.Parse(line[1]), line[2]));
                line = Console.ReadLine().Split().ToArray();
            }

            string fakeEnding = Console.ReadLine();

            foreach(var item in citizensAndRobots)
            {
                char[] lastSymbols = new char[fakeEnding.Length];
                for(int i=0;i<lastSymbols.Length;i++)
                {
                    lastSymbols[i] = item.id[item.id.Length - fakeEnding.Length + i]; 
                }
                if (fakeEnding == new string(lastSymbols)) Console.WriteLine(item.id);
            }
        }
    }
}
