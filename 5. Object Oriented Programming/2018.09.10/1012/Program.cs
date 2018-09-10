using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("somefile.txt");
            StreamWriter writer = new StreamWriter("oderfile.txt");
            using (reader)
            {
                using (writer)
                {
                    int lineNumber = 1;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.Write("Line" + ":" + line);
                        writer.WriteLine();
                        lineNumber++;
                        line = reader.ReadLine();

                    }

                }

            }
        }
    }
}
