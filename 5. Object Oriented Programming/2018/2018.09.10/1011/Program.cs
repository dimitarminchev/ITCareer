using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10._1.Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("text.txt");
            using (reader)
            {
                int counter = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine("{1}", counter,
                            string.Join("", line));
                    }
                    counter++;
                    line = reader.ReadLine();
                }
                reader.Close();
            }
        }
    }
}
