using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _625
{
    class Person
    {

        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }

        public override bool Equals(object obj)
        {
            Person p = obj as Person;

            return Name == p.Name && Age == p.Age;
        }

        public override int GetHashCode()
        {
            char[] NameArray = Name.ToCharArray();
            int result = 0;
            for(int i=0;i<NameArray.Count();i++)
            {
                result += (int)NameArray[i];
            }
            result += Age * 3;
            result /= 2;
            return result;
        }
    }
}
