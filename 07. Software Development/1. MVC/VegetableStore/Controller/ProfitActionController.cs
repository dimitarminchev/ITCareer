using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableStore.Model;
using VegetableStore.View;

namespace VegetableStore.Controller
{
    class ProfitActionController
    {
        Profit profit;
        Display display;

        public ProfitActionController()
        {
            this.display = new Display();
            this.profit = new Profit(this.display.VegetablePrice, this.display.FruitPrice,
                this.display.VegetableKilos, this.display.FruitKilos);
            this.display.FinalProfit = this.profit.CalculateProfit();
            this.display.Print();
        }
    }
}
