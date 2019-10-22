namespace CryptoMiningSystem.Entities.Components.Contracts
{
    public interface IComponent
    {
        string Model { get; }

        decimal Price { get; }

        int Generation { get; }

        int LifeWorkingHours { get; }
    }
}