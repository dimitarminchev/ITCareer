using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Animals
{
    // Base Class
    public class Animal
    {
        protected string name { get; set; }
        protected string favouriteFood { get; set; }

        public Animal(string name, string favFood)
        {
            this.name = name;
            this.favouriteFood = favFood;
        }

        public virtual string ExplainMyself()
        {
            return string.Format($"I am {name} and my fovourite food is {favouriteFood}");
        }

    }

    // Derivative Class
    public class Cat : Animal
    {
        public Cat(string name, string favFood) : base(name, favFood)
        {
            // nope
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + Environment.NewLine + "MEEOW";
        }
    }

    // Derivative Class
    public class Dog : Animal
    {
        public Dog(string name, string favFood) : base(name, favFood)
        {
            // nope
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + Environment.NewLine + "DJAAF";
        }
    }
}
