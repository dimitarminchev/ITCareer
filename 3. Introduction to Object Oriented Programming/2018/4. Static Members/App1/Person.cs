using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Person
    {
        // Име
        private String name;
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Възраст
        private int age;
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        // Брояч
        private static int counter;
        public static int Counter
        {
            get { return Person.counter; }
        }

        // Конструктор
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            // Увеличаваме брояч на обектите от този клас
            Person.counter++;
        }
    }
}
