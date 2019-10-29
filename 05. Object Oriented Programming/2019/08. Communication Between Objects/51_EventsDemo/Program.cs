using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dp = new Dispatcher();

            string input = Console.ReadLine();

            while (input != "End")
            {
                dp.Name = input;
                input = Console.ReadLine();
            }
        }
    }
}
