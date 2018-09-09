using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82
{
    class Program
    {
        static void Main(string[] args)
        {
            // king
            King king = new King(Console.ReadLine());

            // RoyalGuards
            List<RoyalGuard> royalguards = new List<RoyalGuard>();
            var RoyalGuardList = Console.ReadLine().Split().ToList();
            foreach (var guard in RoyalGuardList)
            {
                RoyalGuard royalguard = new RoyalGuard(guard);
                king.OnUnderAttack += royalguard.KingIsUnderAttack;
                royalguards.Add(royalguard);
            }

            // FootMans
            List<Footman> footmans = new List<Footman>();
            var FootMansList = Console.ReadLine().Split().ToList();
            foreach (var man in FootMansList)
            {
                Footman footman = new Footman(man);
                king.OnUnderAttack += footman.KingIsUnderAttack;
                footmans.Add(footman);
            }

            // Process Commands
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Attack":
                        {
                            king.UnderAttack(new EventArgs());
                            break;
                        }
                    case "Kill":
                        {
                            // RoyalGuards
                            var rg = royalguards.Where(a => a.Name == command[1]);
                            if (rg.Count() == 1)
                            {
                                king.OnUnderAttack -= rg.First().KingIsUnderAttack;
                                royalguards.Remove(rg.First());
                            }
                            
                            // FootMans
                            var fm = footmans.Where(a => a.Name == command[1]);
                            if (fm.Count() == 1)
                            {
                                king.OnUnderAttack -= fm.First().KingIsUnderAttack;
                                footmans.Remove(fm.First());
                            }

                            break;
                        }
                }
                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
