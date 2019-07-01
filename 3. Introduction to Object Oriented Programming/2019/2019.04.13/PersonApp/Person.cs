using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        // Свойство Име
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Свойство Възраст
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Метод Представи се!
        public void IntroduceYourself()
        {
            Console.WriteLine("Greetings! I am {0} and I am {1} years old.", name, age);
            Console.WriteLine("Здравейте! Аз съм {0} и съм на {1} години.", name, age);
        }


    }
}
