namespace _638.Contracts
{
    public interface IRepository
    {
        void AddUnit(IUnit unit);
        string Statistics { get; }
        string RemoveUnit(string unitType);
    }
}
