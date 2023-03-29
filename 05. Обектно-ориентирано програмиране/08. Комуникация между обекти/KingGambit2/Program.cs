namespace KingGambit2
{
    class Program
    {
        static void Main(string[] args)
        {
            King king = new King(Console.ReadLine());
            king.AttackedKing += king.Attack;

            List<RoyalGuard> guards = new List<RoyalGuard>();
            Console.ReadLine().Split().ToList().
                ForEach(guard => guards.Add(new RoyalGuard(guard)));

            List<Footman> footmen = new List<Footman>();
            Console.ReadLine().Split().ToList(). 
                ForEach(fm => footmen.Add(new Footman(fm)));
            guards.ForEach(guard =>king.AttackedKing += guard.Attack);
            footmen.ForEach(fm => king.AttackedKing += fm.Attack);
            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();
                switch (input[0])
                {
                    case "Attack":
                        king.UnderAttack(new EventArgs());
                        break;
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
                    default:
                        return;
                }
            }
        }
    }
}
