using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        /* Разтеглив Масив */
        static void Main(string[] args)
        {
            ArrayList<string> list = new ArrayList<string>();

            Console.WriteLine("Length = {0}",list.Length);
            Console.WriteLine("Capacity = {0}", list.Capacity);

            list[0] = "Иванчо";
            list[1] = "Марийка";
        }
    }
}
