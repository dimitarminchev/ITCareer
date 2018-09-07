using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _571
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            this.quantity = quantity;
        }
        public int quantity { get; protected set; }
    }

    public class Meat : Food
    {
        public Meat(int quantity) : base(quantity) { }
    }

    public class Vegetable : Food
    {
        public Vegetable(int quantity) : base(quantity){}
    }
}
