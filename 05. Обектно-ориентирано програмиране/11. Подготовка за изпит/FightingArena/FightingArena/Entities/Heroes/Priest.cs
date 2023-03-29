namespace HeroFight.Entities.Heroes
{
    public class Priest : Hero
    {
        // Constructor
        public Priest(string name) : base(name)
        {
            base.Power = 8; // + 700%
        }
    }
}