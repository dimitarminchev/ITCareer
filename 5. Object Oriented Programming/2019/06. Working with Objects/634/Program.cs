using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _634
{
    class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.CollectGettersAndSetters("_634.Hacker");
            Console.WriteLine(result);
        }
    }
}
