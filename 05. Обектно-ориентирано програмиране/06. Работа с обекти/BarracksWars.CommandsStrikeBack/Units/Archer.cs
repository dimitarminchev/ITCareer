namespace BarracksWars.CommandsStrikeBack
{
    public class Archer : Unit
    {
        private const int DefaultHealth = 25;

        private const int DefaultDamage = 7;

        public Archer() : base(DefaultHealth, DefaultDamage)
        {
            // nope
        }
    }
}