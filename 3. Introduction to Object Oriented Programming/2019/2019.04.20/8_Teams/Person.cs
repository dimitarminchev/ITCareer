using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Teams
{
    class Person
    {
        // Име
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Възраст
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Заплата
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Препокриване/Пренаписване на метод
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} get {this.salary:f2} leva";
        }

        // Конструктори
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person(string firstName, string lastName, int age)
              : this(firstName, lastName)
        {
            this.age = age;
        }

        public Person(string firstName, string lastName, int age, double salary)
            : this(firstName, lastName, age)
        {
            this.salary = salary;
        }
    }
}
