using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _482
{
    public class Pet : IBirthday
    {
        public DateTime birthday { get; private set; }
        public string name { get; set; }

        public Pet(string name, DateTime birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }
    }
}
