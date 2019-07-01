using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PersonValidation
{
    class Person
    {
        // Име
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols");
                }
                firstName = value;
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
                }
                lastName = value;
            }
        }

        // Възраст
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }
                age = value;
            }
        }

        // Заплата
        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                }
                salary = value;
            }
        }

        // Увеличаване на заплатата
        public void IncreaseSalary(double bonus)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * bonus / 100;
            }
            else
            {
                this.salary += this.salary * bonus / 200;
            }
        }

        // Препокриване/Пренаписване на метод
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} get {this.salary:f2} leva";
        }

        // Конструктори
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string firstName, string lastName, int age)
              : this(firstName, lastName)
        {
            this.Age = age;
        }

        public Person(string firstName, string lastName, int age, double salary)
            : this(firstName, lastName, age)
        {
            this.Salary = salary;
        }
    }
}
