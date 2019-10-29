using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._6_Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Lake lake = new Lake(a);
            Console.WriteLine(string.Join(", ", lake));
            
        }
    }
}
