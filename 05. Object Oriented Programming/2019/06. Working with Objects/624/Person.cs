using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
