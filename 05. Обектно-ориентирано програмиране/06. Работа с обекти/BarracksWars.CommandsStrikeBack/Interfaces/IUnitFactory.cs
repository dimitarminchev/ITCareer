namespace BarracksWars.CommandsStrikeBack
{
    public interface IUnitFactory
    {
        IUnit CreateUnit(string unitType);
    }
}