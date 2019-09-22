using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1011_OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = new StreamReader("somefile.txt"))
            {
                var line1 = reader.ReadLine();
                var line2 = reader.ReadLine();
                while(line1!=null)
                {
                    Console.WriteLine(line1);
                    line1 = reader.ReadLine();
                    line2 = reader.ReadLine();
                }
            }
        }
    }
}
