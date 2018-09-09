using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handler = new Handler();
            Dispatcher dispacher = new Dispatcher();
            dispacher.NameChange += handler.OnDispatcherNameChange;

            // Input
            string line = Console.ReadLine();
            while (line != "End")
            {
                dispacher.Name = line;
                line = Console.ReadLine();
            }
        }

    }
}
