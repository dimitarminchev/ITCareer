namespace HeroFight.Entities.Heroes
{
    public class Warrior : Hero
    {
        // Constructor
        public Warrior(string name) : base(name)
        {
            base.Power = 4; // + 300%
        }
    }
}