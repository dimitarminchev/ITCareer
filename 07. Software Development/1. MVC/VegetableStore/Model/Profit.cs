using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableStore.Model
{
    class Profit
    {
        protected double vegetablePrice;
        protected double fruitPrice;
        protected int vegetableKilos;
        protected int fruitKilos;

        public double VegetablePrice
        {
            get { return vegetablePrice; }
            set { vegetablePrice = value; }
        }

        public double FruitPrice
        {
            get { return fruitPrice; }
            set { fruitPrice = value; }
        }

        public int VegetableKilos
        {
            get { return vegetableKilos; }
            set { vegetableKilos = value; }
        }

        public int FruitKilos
        {
            get { return fruitKilos; }
            set { fruitKilos = value; }
        }

        public Profit(double vegetablePrice, double fruitPrice, int vegetableKilos, int fruitKilos)
        {
            this.vegetablePrice = vegetablePrice;
            this.fruitPrice = fruitPrice;
            this.vegetableKilos = vegetableKilos;
            this.fruitKilos = fruitKilos;
        }

        public double CalculateProfit()
        {
            double profit = (this.vegetablePrice * this.vegetableKilos + this.fruitPrice * this.fruitKilos) / 1.94;
            return profit;
        }
    }
}
