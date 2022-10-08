namespace _05_KingsGambit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. King
            King king = new King(System.Console.ReadLine());
            king.AttackedKing += king.Attack;

            // 2. Guard
            List<RoyalGuard> guards = new List<RoyalGuard>();
            System.Console.ReadLine().Split().ToList().ForEach(guard => guards.Add(new RoyalGuard(guard)));

            // 3. Footman
            List<FootMan> footmen = new List<FootMan>();
            System.Console.ReadLine().Split().ToList().ForEach(fm => footmen.Add(new FootMan(fm)));

            // 4. Subscripe for Notifications
            guards.ForEach(guard => king.AttackedKing += guard.Attack);
            footmen.ForEach(fm => king.AttackedKing += fm.Attack);

            // Input
            while (true)
            {
                var input = System.Console.ReadLine().Split().ToArray();
                switch (input[0])
                {
                    case "Attack":
                        king.UnderAttack(new EventArgs());
                        break;
                    case "Kill":
                        if (guards.Select(x => x.Name).Contains(input[1]))
                        {
                            var guard = guards.Where(x => x.Name == input[1]).FirstOrDefault();
                            if (guard == null) break;
                            // Unsubscripe for Notifications
                            king.AttackedKing -= guard.Attack;
                            guards.Remove(guard);
                        }
                        else
                        {
                            var fm = footmen.Where(x => x.Name == input[1]).FirstOrDefault();
                            if (fm == null) break;
                            // Unsubscripe for Notifications
                            king.AttackedKing -= fm.Attack;
                            footmen.Remove(fm);
                        }
                        break;
                    default:
                        return;
                }
            }
        }
    }
}