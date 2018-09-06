using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _522
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + Environment.NewLine + "WOOF";
        }
    }

}
