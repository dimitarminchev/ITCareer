using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Person
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

    }
}
