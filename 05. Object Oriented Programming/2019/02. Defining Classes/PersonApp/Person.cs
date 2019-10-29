using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    public class Person
    {
        // Име
        public string name;

        // Възраст
        public int age;

        // Представяне
        public void IntroduceYourself()
        {
            Console.WriteLine("Name: {0}, Age: {1}", name, age);
        }

    }
}
