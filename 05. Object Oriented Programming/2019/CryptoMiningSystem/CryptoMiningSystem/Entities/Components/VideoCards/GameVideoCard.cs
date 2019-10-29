using CryptoMiningSystem.Entities.Components.VideoCards.Contracts;
using CryptoMiningSystem.Utilities;
using System;

namespace CryptoMiningSystem.Entities.Components.VideoCards
{
    public class GameVideoCard : VideoCard, IVideoCard
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public GameVideoCard(string model, int generation, int ram, decimal price) : base(model, generation, ram, price)
        {
            ;; // nope
        }
    }
}