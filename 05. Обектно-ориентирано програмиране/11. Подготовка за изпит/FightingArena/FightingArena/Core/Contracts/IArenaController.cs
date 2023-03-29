namespace HeroFight.Core.Contracts
{
    using System.Collections.Generic;

    public interface IArenaController
    {
        string CreateHero(List<string> args);

        string CreateWeapon(List<string> args);

        string Fight(List<string> args);

        string HeroInfo(List<string> args);

        string CloseArena();
    }
}
