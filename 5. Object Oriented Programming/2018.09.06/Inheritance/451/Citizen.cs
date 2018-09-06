using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _451
{
    public class Citizen : IPerson
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
