using System;
using System.IO;

namespace _1021
{
    class Program
    {
        // File Copy 1
        public static bool Copy1(String _source, String _destination)
        {
            try
            {
                using (FileStream source = new FileStream(_source, FileMode.Open))
                using (FileStream destination = new FileStream(_destination, FileMode.Create))
                {
                    byte[] one = new byte[source.Length];
                    int readed = source.Read(one, 0, one.Length);
                    destination.Write(one, 0, one.Length);
                    source.Flush();
                    destination.Flush();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // File Copy 2
        public static bool Copy2(String _source, String _destination)
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
            if (Copy1("..\\..\\..\\text.txt", "LoremIpsum.txt"))
            {
                Console.WriteLine("File Copy Sucesefful.");
            }
            else
            {
                Console.WriteLine("File Copy Error.");
            }
        }
    }
}
