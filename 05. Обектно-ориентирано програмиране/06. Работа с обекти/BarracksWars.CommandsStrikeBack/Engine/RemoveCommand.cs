namespace BarracksWars.CommandsStrikeBack
{
    public class RemoveCommand : Command
    {
        public RemoveCommand(string[] data, IRepository repo, IUnitFactory fatory) : base(data, repo, fatory)
        {
            // nope
        }

        public override string Execute()
        {
            string unitType = base.Data[1];
            // IUnit unit = UnitFactory.CreateUnit(unitType);
            string output = base.Repository.RemoveUnit(unitType);
            return output;
        }
    }
}