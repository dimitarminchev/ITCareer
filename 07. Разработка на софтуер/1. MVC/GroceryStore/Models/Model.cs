namespace GroceryStore.Models
{
    public class Model
    {
        private double priceOfVegetables;

        public double PriceOfVegetables
        {
            get { return priceOfVegetables; }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Must be positive numver");
                }
                priceOfVegetables = value;
            }
        }

        private double priceOfFruit;

        public double PriceOfFruit
        {
            get { return priceOfFruit; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Must be positive numver");
                }
                priceOfFruit = value;
            }
        }

        private int kilosVegetables;

        public int KilosVegetables
        {
            get { return kilosVegetables; }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Must be positive numver");
                }
                kilosVegetables = value; 
            }
        }

        private int kilosFruits;

        public int KilosFruits
        {
            get { return kilosFruits; }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Must be positive numver");
                }
                kilosFruits = value; 
            }
        }

        public Model(double priceOfVegetables, double priceOfFruit, int kilosVegetables, int kilosFruits)
        {
            this.priceOfFruit = priceOfFruit;
            this.priceOfVegetables = priceOfVegetables;
            this.kilosVegetables = kilosVegetables;
            this.kilosFruits = kilosFruits;
        }

        public Model() : this(0, 0, 0, 0)
        {
            // nope
        }

        public double CalculateTotal()
        {
            return ((priceOfVegetables * kilosVegetables) + (priceOfFruit * kilosFruits)) / 1.94;
        }
    }
}
