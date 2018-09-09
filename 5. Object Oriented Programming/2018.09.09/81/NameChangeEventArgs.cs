using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81
{
    public class NameChangeEventArgs : EventArgs
    {
        public string name { private set; get; }

        public NameChangeEventArgs(string name)
        {
            this.name = name;
        }
    }
}
