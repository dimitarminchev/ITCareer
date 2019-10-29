using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EverythingBox
{
    class Program
    {
        // Task 2. Everything Box
        static void Main(string[] args)
        {
            // 1. Integer Box
            Box<int> box1 = new Box<int>();
            box1.Add(123);
            Console.WriteLine(box1.ToString());

            // 2. String Box
            Box<string> box2 = new Box<string>();
            box2.Add("life in a box");
            Console.WriteLine(box2.ToString());

            // 3. Floating Point Number Box
            Box<double> box3 = new Box<double>();
            box3.Add(3.14);
            Console.WriteLine(box3.ToString());
        }
    }
}
