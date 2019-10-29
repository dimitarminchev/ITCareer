using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81
{
    public class Handler
    {
        public virtual void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine("Dispatcher's name changed to {0}", args.name);
        }
    }
}
