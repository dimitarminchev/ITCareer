using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_AnimalFarm
{
    abstract class Food
    {
        public int quantity { get; }
        public Food(int quantity)
        {
            this.quantity = quantity;
        }
    }
}
