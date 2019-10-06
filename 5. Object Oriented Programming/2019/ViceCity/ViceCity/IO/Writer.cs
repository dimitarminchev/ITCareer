using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.IO.Contracts;

namespace ViceCity.IO
{
    public class Writer : IWriter
    {
        public void Write(string line)
        {
            Console.Write(line);
        }

        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
