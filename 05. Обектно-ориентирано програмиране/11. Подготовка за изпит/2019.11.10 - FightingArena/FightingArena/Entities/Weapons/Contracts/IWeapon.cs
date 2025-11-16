namespace HeroFight.Entities.Weapons.Contracts
{
    public interface IWeapon
    {
        string Name { get; }

        int Strength { get; }

        int Agility { get; }

        int Intelligence { get; }
    }
}