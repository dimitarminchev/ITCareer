namespace _638.Contracts
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string[] data, string commandName);
    }
}
