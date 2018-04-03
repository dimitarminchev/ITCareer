using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    /// <summary>
    /// Човек
    /// </summary>
    class Person
    {
        // Име 
        public string Name { get; set; }

        // Възраст
        public int Age { get; set; }

        // Представяне
        public void IntroduceYourself()
        {
            Console.WriteLine("I am {0} and my age is {1}.", Name, Age);
        }

    }
}
