using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    class Person
    {
        private string firstName;
        public string FirstName { get { return this.firstName; } }
        private string lastName;
        private int age;
        public int Age { get { return this.age; } }
        public Person(string name, string family, int age)
        {
            this.firstName = name;
            this.lastName = family;
            this.age = age;
        }
    }
}
