using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        // Task 1.
        static void Main(string[] args)
        {            

            // Test 1. Create object instance
            Person person = new Person();
            person.name = "Ivan";
            person.age = 12;
            person.IntroduceYourself();

            // Test 2. Reflection
            Type personType = typeof(Person);
            var fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance).ToList();            
            Console.WriteLine("Public: {0}", string.Join(", ", fields));
            Console.WriteLine("Count = {0}", fields.Count);
        }
    }
}
