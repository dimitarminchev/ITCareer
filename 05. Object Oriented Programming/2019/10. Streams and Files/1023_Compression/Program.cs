using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1023_Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("SourceFile: ");
            var source = Console.ReadLine();
            Console.Write("Parts: ");
            int n = int.Parse(Console.ReadLine());

            Slice(source, n);
            Console.WriteLine("Sliced");
            Assemble();
            Console.WriteLine("Assembled");
        }
        public static void Slice(string sourceFile, int parts)
        {
            using (FileStream read = new FileStream(sourceFile, FileMode.Open))
            {
                int FileLength = (int)read.Length /*/ 1024*/;
                int sizeOfFile = FileLength / parts;
                for (int i = 0; i < parts; i++)
                {
                    string name = $"Part - {i}";
                    using (FileStream write = new FileStream(name, FileMode.Create))
                    {
                        using (GZipStream gz = new GZipStream(write, CompressionMode.Compress, false))
                        {
                            byte[] bytes = new byte[sizeOfFile];
                            int data = read.Read(bytes, 0, bytes.Length);
                            gz.Write(bytes, 0, bytes.Length);
                            //write.Write(bytes, 0, bytes.Count());
                        }
                    }
                }
            }
        }
        public static void Assemble()
        {
            string [] files = Directory.GetFiles(Directory.GetCurrentDirectory().ToString(), "Part*");
            using (FileStream write = new FileStream($"assembled", FileMode.Create))
            {
                foreach (var item in files)
                {
                    using (FileStream read = new FileStream(item, FileMode.Open))
                    {
                        byte[] bytes = new byte[4096];
                        using (GZipStream decompressionStream = new GZipStream(read, CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(write);
                        }
                    }
                }
            }
        }
    }
}
