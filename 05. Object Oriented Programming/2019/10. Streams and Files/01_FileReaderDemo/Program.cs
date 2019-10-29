using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FileReaderDemo
{
    class Program
    {
        // Demo 1. File Reader
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\Program.cs");
            using (reader)
            {
                int lineNumber = 1;
                var lineContents = reader.ReadLine();
                while (lineContents != null)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, lineContents );
                    lineNumber++;
                    lineContents = reader.ReadLine();
                }

            } // reader.Dispose();
        }
    }
}
