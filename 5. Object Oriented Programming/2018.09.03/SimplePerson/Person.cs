using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePerson
{
    // Човечето
    public class Person
    {
        // Поле: Име
        private string name;
        // реализираме свойство на полето name
        public String Name
        { 
            get { return name; }
            set { name = value; }
        }

        // Поле: Възраст
        private int age;
        // реализираме свойство на полето age
        public int Age
        { 
            get { return age; }
            set { age = value; }
        }

        // Най-неввероятния начин да се представиш
        public void IntroduceYourself()
        {
            Console.WriteLine("Здравейте! Аз съм {0} и съм на {1} години.", name, age);
        }
    }

}
