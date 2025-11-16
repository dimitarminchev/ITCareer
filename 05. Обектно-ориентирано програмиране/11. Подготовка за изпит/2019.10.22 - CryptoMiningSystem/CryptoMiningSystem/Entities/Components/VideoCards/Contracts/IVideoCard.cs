namespace CryptoMiningSystem.Entities.Components.VideoCards.Contracts
{
    public interface IVideoCard
    {
        decimal MinedMoneyPerHour { get; }

        int Ram { get; }
    }
}