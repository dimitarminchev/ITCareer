namespace CryptoMiningSystem.Entities.Contracts
{
    public interface IUser
    {
        string Name { get; }

        int Stars{ get; }

        decimal Money { get; }

        Computer Computer { get; }
    }
}