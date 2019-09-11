using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _481
{
    class Citizen : Data
    {
        private int age;
        public Citizen(string id, string name, int age) : base(id, name)
        {
            this.age = age;
        }
    }
}
