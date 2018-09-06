using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _483
{
    public class Rebel : IBuyer
    {
        public int food { get; private set; }

        public string name { get; private set; }

        public int age { get; private set; }

        public string group { get; private set; }

        public Rebel(string name, int age, string group)
        {
            this.name = name;
            this.age = age;
            this.group = group;
            this.food = 0;
        }

        public void BuyFood()
        {
            food += 5;
        }
    }
}
