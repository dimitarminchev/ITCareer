namespace BarracksWars.CommandsStrikeBack
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string[] data, string commandName);
    }
}