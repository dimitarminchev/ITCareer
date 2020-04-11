using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05.Models
{
    public class Model
    {
        private double priceOfVegetables;

        public double PriceOfVegetables
        {
            get { return priceOfVegetables; }
            set { priceOfVegetables = value; }
        }
        private double priceOfFruit;

        public double PriceOfFruit
        {
            get { return priceOfFruit; }
            set { priceOfFruit = value; }
        }

        private int kilosVegetables;

        public int KilosVegetables
        {
            get { return kilosVegetables; }
            set { kilosVegetables = value; }
        }

        private int kilosFruits;

        public int KilosFruits
        {
            get { return kilosFruits; }
            set { kilosFruits = value; }
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

        }

        public double Calculate()
        {
            return ((priceOfVegetables * kilosVegetables) + (priceOfFruit * kilosFruits)) / 1.94;
        }
    }
}
