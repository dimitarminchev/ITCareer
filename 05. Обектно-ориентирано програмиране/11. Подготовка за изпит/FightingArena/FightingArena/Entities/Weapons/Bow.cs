namespace HeroFight.Entities.Weapons
{
    public class Bow : Weapon
    {
        public Bow(string name, int strength, int agility, int intelligence) :
            base(name, (strength * 2), (agility * 3), intelligence)
        {
            // Strength + 100%
            // Agility  + 200%
        }
    }
}