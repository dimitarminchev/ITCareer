using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    /// <summary>
    /// Човек
    /// </summary>
    class Person
    {
        // Име
        private string firstName;
        public string FirstName { get { return this.firstName; }}

        // Фамилия
        private string lastName;

        // Възраст
        private int age;
        public int Age { get { return this.age; } }

        // Заплата
        private double salary;
        public double Salary { get { return this.salary; } }

        // Увеличаване на заплатата
        public void IncreaseSalary(double bonus)
        {
            double multiplyer = 1.0 + (bonus / 100);
            this.salary *= multiplyer;
        }

        // Конструктор
        public Person(string name, string family, int age, double salary)
        {
            this.firstName = name;
            this.lastName = family;
            this.age = age;
            this.salary = salary;
        }

        // Пренаписахме ToString
        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
        }
    }
}
