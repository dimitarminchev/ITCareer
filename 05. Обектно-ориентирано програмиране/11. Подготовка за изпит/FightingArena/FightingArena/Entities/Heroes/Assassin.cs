namespace HeroFight.Entities.Heroes
{
    public class Assassin : Hero
    {
        // Constructor
        public Assassin(string name) :  base(name)
        {
            base.Power = 6; // + 500%
        }
    }
}