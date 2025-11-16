using CryptoMiningSystem.Entities.Components.Processors.Contracts;

namespace CryptoMiningSystem.Entities.Components.Processors
{
    public class HighPerformanceProcessor : Processor, IProcessor
    {
        int IProcessor.MineMultiplier => 8;

        /// <summary>
        /// Контсруктор
        /// </summary>
        public HighPerformanceProcessor(string model, int generation, decimal price) : base(model, generation, price)
        {
            ;; // nope
        }
    }
}    