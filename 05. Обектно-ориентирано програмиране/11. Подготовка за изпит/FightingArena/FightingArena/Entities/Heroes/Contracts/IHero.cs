namespace HeroFight.Entities.Heroes.Contracts
{
    using HeroFight.Entities.Weapons;

    public interface IHero
    {
        string Name { get; }

        int Level { get; }

        int Experience { get; }

        Weapon Weapon { get; }

        double Power { get; }
    }
}