using CryptoMiningSystem.Entities.Components.Processors.Contracts;

namespace CryptoMiningSystem.Entities.Components.Processors
{
    public class LowPerformanceProcessor : Processor, IProcessor
    {
        int IProcessor.MineMultiplier => 2;

        /// <summary>
        /// Контсруктор
        /// </summary>
        public LowPerformanceProcessor(string model, int generation, decimal price) : base(model, generation, price)
        {
            ;; // nope
        }
    }
}