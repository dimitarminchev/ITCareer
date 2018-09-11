using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1021
{
    class Program
    {
        // Copy
        public static bool Copy(string _source, string _destination)
        {
            try
            {
                using (StreamReader reader = new StreamReader(new FileStream(_source, FileMode.Open)))
                using (StreamWriter writer = new StreamWriter(new FileStream(_destination, FileMode.Create)))
                {
                    writer.Write(reader.ReadToEnd());
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Main
        static void Main(string[] args)
        {
            if (Copy("LoremIpsum.txt", "LoremIpsum2.txt"))
            {
                Console.WriteLine("File Copy Successful");
            }
            else
            {
                Console.WriteLine("File Copy Error");
            }
        }
    }
}
