namespace _02_KingGambit
{
    /// <summary>
    /// 1. King.cs
    /// 2. FootMan.cs
    /// 3. RoyalGuard.cs
    /// 4. Attacker.cs
    /// 5. Program.cs
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. Крал
            var name = Console.ReadLine();
            King king = new King(name);

            // 2. Охранители
            List<RoyalGuard> guards = new List<RoyalGuard>();
            Console.ReadLine().Split().ToList().ForEach
            (
                x => guards.Add(new RoyalGuard(x))
            );

            // 3. Слуги
            List<FootMan> footmen = new List<FootMan>();
            Console.ReadLine().Split().ToList().ForEach
            (
                x => footmen.Add(new FootMan(x))
            );

            // Абонираме охранителите и слугите за събитието "AttackedKing"
            guards.ForEach(guard => king.AttackedKing += guard.Attack);
            footmen.ForEach(fm => king.AttackedKing += fm.Attack);

            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();
                switch (input[0])
                {
                    case "Attack": king.UnderAttack(new EventArgs()); break;
                    case "Kill":
                        if (guards.Select(x => x.Name).Contains(input[1]))
                        {
                            var guard = guards.Where(x => x.Name == input[1]).First();
                            king.AttackedKing -= guard.Attack;
                            guards.Remove(guard);
                        }
                        else
                        {
                            var fm = footmen.Where(x => x.Name == input[1]).First();
                            king.AttackedKing -= fm.Attack;
                            footmen.Remove(fm);
                        }
                        break;
                    default: return;
                }
            }
        }
    }
}