namespace BarracksWars.CommandsStrikeBack
{
    public class AddCommand : Command
    {
        public AddCommand(string[] data, IRepository repo, IUnitFactory fatory) : base(data, repo, fatory)
        {
            // nope
        }

        public override string Execute()
        {
            string unitType = base.Data[1];
            IUnit unitToAdd = base.UnitFactory.CreateUnit(unitType);
            base.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}