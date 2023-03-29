namespace HeroFight.Entities.Weapons
{
    public class MagicWand : Weapon
    {
        public MagicWand(string name, int strength, int agility, int intelligence) :
            base(name, strength, agility, intelligence * 5) // 400%
        {
           // nope
        }
    }
}