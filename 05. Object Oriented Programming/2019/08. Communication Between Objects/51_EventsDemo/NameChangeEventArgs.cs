using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_EventsDemo
{
    class NameChangeEventArgs : EventArgs
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public NameChangeEventArgs(string n)
        {
            name = n;
        }
    }
}
