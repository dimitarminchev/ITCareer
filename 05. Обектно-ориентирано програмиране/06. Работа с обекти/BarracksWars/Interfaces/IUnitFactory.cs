namespace BarracksWars
{
    public interface IUnitFactory
    {
        IUnit CreateUnit(string unitType);
    }
}