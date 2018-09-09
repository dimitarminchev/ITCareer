using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81
{
    // delegate
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs e);

    public class Dispatcher
    {
        // property
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        // event
        public event NameChangeEventHandler NameChange;

        // event handler
        public void OnNameChange(NameChangeEventArgs args)
        {
            NameChange(this, args);
        }
    }
}
