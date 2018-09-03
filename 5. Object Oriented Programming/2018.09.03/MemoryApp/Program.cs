using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals list = new Animals();
            list.Add(new Animal("Крокодил", 70));
            list.Add(new Animal("Костенурка", 200));
            list.Add(new Animal("Овца", 12));
            list.Add(new Animal("Пепелянка", 7));

            list.Dispose();
            list.Dispose();

            // Console.WriteLine("Animals Count = {0}", list.animals.Count);
        }
    }
}
