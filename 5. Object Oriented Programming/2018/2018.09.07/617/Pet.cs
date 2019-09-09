using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _617
{
    public class Pet
    {
        private string name;
        private int age;
        public string type;

        public void Create(string name, int age, string type)
        {
            this.name = name;
            this.age = age;
            this.type = type;
        }
    }
}
