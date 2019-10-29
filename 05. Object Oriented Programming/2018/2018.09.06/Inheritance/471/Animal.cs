using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _471
{
    public abstract class Animal : IMakeTrick, IMakeNoise
    {
        public string Name { get;private set; }
        public int Age { get;private set; }

        public Animal(string Name,int Age)
        {
            this.Age = Age;
            this.Name = Name;
        }

        public virtual string MakeNoise()
        {
            return $"My name is {this.Name}. I am {this.Age} old."; 
        }

        public virtual string MakeTrick()
        {
            return $"Look at my trick!";
        }
    }
}
