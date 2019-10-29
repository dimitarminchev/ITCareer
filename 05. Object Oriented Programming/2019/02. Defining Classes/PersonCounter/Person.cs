using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCounter
{
    public class Person 
    {
        // Име
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Възраст
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Конструктор
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Person.count++;
        }

        // Брой създадени обекти 
        private static int count = 0;

        public static int Count
        {  
            // Статично свойство
            get { return count; }
        }

    }
}
