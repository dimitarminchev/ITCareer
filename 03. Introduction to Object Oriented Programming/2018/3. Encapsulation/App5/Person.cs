using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Person
    {
        // Име 
        private string firstName;
        public string FirstName { get { return this.firstName; } }
        // Фамилия 
        private string lastName;
        // Възраст 
        private int age;
        public int Age
        {
            get { return this.age; }
        }
        public double Salary
        {
            get { return this.Salary; }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                }
                this.Salary = value;
            }
        }
        // Конструктор 
        public Person(string name, string family, int age)
        {
            this.firstName = name;
            this.lastName = family;
            this.age = age;
        }
        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} is {this.age} years old.";
        }
    }
} 


