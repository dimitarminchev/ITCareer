using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _482
{
    class Citizen : Data
    {
        private int age;
        public string birthDate { get; }
        public Citizen(string name, int age, string  id,string birthDate) : base(id, name)
        {
            this.age = age;
            this.birthDate = birthDate;
        }
    }
}
