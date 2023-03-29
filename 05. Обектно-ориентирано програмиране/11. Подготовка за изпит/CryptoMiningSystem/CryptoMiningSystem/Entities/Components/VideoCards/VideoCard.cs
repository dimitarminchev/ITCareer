namespace CryptoMiningSystem.Entities.Components.VideoCards
{
    using CryptoMiningSystem.Entities.Components;
    using CryptoMiningSystem.Utilities;
    using Contracts;
    using System;

    public abstract class VideoCard : Component, IVideoCard
    {

        /// <summary>
        /// Конструктор
        /// </summary>
        protected VideoCard(string model, int generation, int ram, decimal price) : base(model, generation, price)
        {
            this.Ram = ram;
        }

        public decimal MinedMoneyPerHour
        {
            get { return MinedMoneyPerHour; }
            set
            {
                if (value < 0 || value > 32)
                {
                    throw new ArgumentException("{videoCardType} ram cannot less or equal to 0 and more than 32!");
                }
                MinedMoneyPerHour = value;
            }
        }

        /// <summary>
        /// Памет
        /// </summary>
        public int Ram
        {
            get { return Ram; }
            private set
            {
                if (value < 0 || value > 32)
                {
                    throw new ArgumentException("{videoCardType} ram cannot less or equal to 0 and more than 32!");
                }
                Ram = value;

            }
        }
    }
}    