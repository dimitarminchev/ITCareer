using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableStore.View
{
    class Display
    {
        public double VegetablePrice { get; set; }
        public double FruitPrice { get; set; }
        public int VegetableKilos { get; set; }
        public int FruitKilos { get; set; }
        public double FinalProfit { get; set; }

        public Display()
        {
            this.VegetablePrice = 0;
            this.FruitPrice = 0;
            this.VegetableKilos = 0;
            this.FruitKilos = 0;
            this.FinalProfit = 0;
            GetValues();
        }

        private void GetValues()
        {
            this.VegetablePrice = double.Parse(Console.ReadLine());
            this.FruitPrice = double.Parse(Console.ReadLine());
            this.VegetableKilos = int.Parse(Console.ReadLine());
            this.FruitKilos = int.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("{0}", this.FinalProfit);
        }
    }
}
