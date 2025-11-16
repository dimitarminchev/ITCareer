namespace HeroFight.Entities.Weapons
{
    public class Sword : Weapon
    {
        public Sword(string name, int strength, int agility, int intelligence) :
            base(name, (strength * 4), agility, intelligence)
        {
            // Strength + 300%
        }
    }
}