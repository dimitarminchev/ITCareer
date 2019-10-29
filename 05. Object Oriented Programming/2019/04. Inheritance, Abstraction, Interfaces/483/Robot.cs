using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _483
{
    class Robot : Data,INameAndBirthDate
    {

        public Robot(string id,string name,string b,int age) : base(id, name)
        {
            //nope
            this.Age = age;
            this.BirthDate = b;
        }
        public string BirthDate { get; set; }
        public int Age { get; set; }

        public string Name => throw new NotImplementedException();
    }
}
