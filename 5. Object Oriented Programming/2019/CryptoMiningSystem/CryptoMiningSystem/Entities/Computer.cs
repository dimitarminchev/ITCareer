namespace CryptoMiningSystem.Entities
{
    using Components.Processors;
    using Components.VideoCards;
    using CryptoMiningSystem.Entities.Contracts;
    using CryptoMiningSystem.Utilities;
    using System;
    using System.Text;

    public class Computer : IComputer
    {

        /// <summary>
        /// Конструктор
        /// </summary>
        public Computer(Processor processor, VideoCard videocard, int ram)
        {
            this.Processor = processor;
            this.VideoCard = videocard;
            this.Ram = ram;
        }

        // Процесор
        public Processor Processor { get; set; }

        // Видеокарта
        public VideoCard VideoCard { get; set; }

        // Памет
        public int Ram { get; private set; }

        // Интерфейс
        public decimal MinedAmountPerHour => this.VideoCard.MinedMoneyPerHour * this.Processor.MineMultiplier;

    }
}