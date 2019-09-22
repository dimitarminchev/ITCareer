using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1012_LinesNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            using (StreamReader reader = new StreamReader("somefile.txt"))
            {
                using (StreamWriter writer = new StreamWriter("otherfile.txt"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine($"Line {count}: {line}");
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
