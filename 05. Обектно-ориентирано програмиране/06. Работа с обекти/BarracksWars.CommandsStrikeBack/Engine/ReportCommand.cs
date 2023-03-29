namespace BarracksWars.CommandsStrikeBack
{
    public class ReportCommand : Command
    {
        public ReportCommand(string[] data, IRepository repo, IUnitFactory fatory) : base(data, repo, fatory)
        {
            // nope
        }

        public override string Execute()
        {
            string output = base.Repository.Statistics;
            return output;
        }
    }
}