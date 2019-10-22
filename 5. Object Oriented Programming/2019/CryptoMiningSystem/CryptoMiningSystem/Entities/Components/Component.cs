namespace CryptoMiningSystem.Entities.Components
{
    using CryptoMiningSystem.Utilities;
    using Contracts;
    using System;
    using System.Text;

    public abstract class Component : IComponent
    {

        /// <summary>
        /// Конструктор
        /// </summary>
        protected Component(string model, int generation, decimal price)
        {
            this.Model = model;
            this.Generation = generation;
            this.Price = price;
        }

        public string Model
        {
            get { return Model; }
            private set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty!");
                }
                Model = value;
            }
        }

        public decimal Price
        {
            get { return Price; }
            private set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException("Price cannot be less or equal to 0 and more than 10000!");
                }
                Price = value;
            }
        }

        public int Generation
        {
            get { return Generation; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Generation cannot be 0 or negative!");
                }
                Generation = value;
            }
        }

        public int LifeWorkingHours { get; set; }
    }
}    
    