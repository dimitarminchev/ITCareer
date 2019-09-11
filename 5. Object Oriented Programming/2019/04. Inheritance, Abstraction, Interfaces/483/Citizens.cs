using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _483
{
    class Citizen : Data, IBuyer
    {
        private int age;
        public string birthDate { get; }
        public int Food { get; set; }

        public Citizen(string name, int age, string  id,string birthDate) : base(id, name)
        {
            this.age = age;
            this.birthDate = birthDate;
            Food = 0;
            Name = name;
        }
        public string Name { get; set; }
        public void BuyFood()
        {
            Food += 10;
        }
    }
}
