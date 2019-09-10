using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Scale
{
    class Program
    {
        // The Scale
        static void Main(string[] args)
        {
            // Integer Scale
            var intScale = new Scale<int>(32, 41);
            Console.WriteLine(intScale.GetHavier());

            // String Scale
            var stringScale = new Scale<string>("Ivan", "Peter");
            Console.WriteLine(stringScale.GetHavier());

            // Boolean Scale
            var boolScale = new Scale<bool>(true,false);
            Console.WriteLine(boolScale.GetHavier());

            // Double Scale
            var doubleScale = new Scale<double>(2.34,3.45);
            Console.WriteLine(doubleScale.GetHavier());
        }
    }
}
