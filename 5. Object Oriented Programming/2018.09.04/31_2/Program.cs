using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(123123);

            Console.WriteLine(box.ToString());

            Box<string> box2 = new Box<string>();
            box2.Add("life in a box");

            Console.WriteLine(box2.ToString());
        }
    }
}
