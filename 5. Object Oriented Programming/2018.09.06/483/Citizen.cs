using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _483
{
    public class Citizen : IBuyer, IBirthday
    {
        public int food { get; private set; }
        public string name { get; private set; }
        public int age { get; private set; }
        public string id { get; private set; }
        public DateTime birthday { get; private set; }

        public Citizen(string name, int age, string id, DateTime birthday)
        {
            this.food = 0;
            this.name = name;
            this.age = age;
            this.id = id;
            this.birthday = birthday;
        }

        public void BuyFood()
        {
            this.food += 10;
        }
    }
}
