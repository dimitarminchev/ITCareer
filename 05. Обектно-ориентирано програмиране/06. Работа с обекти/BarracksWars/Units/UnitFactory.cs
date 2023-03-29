namespace BarracksWars
{
    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            switch (unitType)
            {
                case "SwordsMan": return new Swordsman();
                case "Archer": return new Archer();
                case "Pikeman": return new Pikeman();
                case "Gunner": return new Gunner();
                case "Horseman": return new Horseman();
                default: return new Swordsman();
            }
        }
    }
}