using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    class Child
    {
        private string name;
        private string birthday;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public override string ToString()
        {
            return $"{name} {birthday}";
        }
    }
}
