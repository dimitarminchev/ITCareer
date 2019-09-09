using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _522
{
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + Environment.NewLine + "MEEOW";
        }
    }
}
