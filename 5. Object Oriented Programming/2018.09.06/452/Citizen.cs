using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _452
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public string Birthdate { get; private set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }
    }
}
