namespace CryptoMiningSystem.Factories
{
    using CryptoMiningSystem.Entities.Components.Processors;
    using System.Collections.Generic;

    public class ProcerssorFactory
    {
        public static Processor CreateProcessor(List<string> args)
        {
            string type = args[0];
            string model = args[1];
            int generation = int.Parse(args[2]);
            decimal price = decimal.Parse(args[3]);

            Processor processor = null;

            if (type == "Low")
            {
                processor = new LowPerformanceProcessor(model, generation, price);
            }
            else if (type == "High")
            {
                processor = new HighPerformanceProcessor(model, generation, price);
            }

            return processor;
        }
    }
}