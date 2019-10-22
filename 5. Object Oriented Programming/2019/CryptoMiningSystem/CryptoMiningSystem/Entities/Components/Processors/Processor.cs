namespace CryptoMiningSystem.Entities.Components.Processors
{
    using CryptoMiningSystem.Entities.Components;
    using CryptoMiningSystem.Utilities;
    using Contracts;
    using System;

    public abstract class Processor : Component, IProcessor
    {

        /// <summary>
        /// Конструктор
        /// </summary>
        protected Processor(string model, int generation, decimal price) : base(model, generation, price)
        {
            ;; // nope
        }

        /// <summary>
        /// множител на придобитите пари
        /// </summary>
        public virtual int MineMultiplier 
        {
            get { return MineMultiplier; }
            set
            {
                if (value > 9)
                {
                    throw new ArgumentException("{processorType} generation cannot be more than 9!");
                }
                MineMultiplier = value;
            }
        }
    }
}    