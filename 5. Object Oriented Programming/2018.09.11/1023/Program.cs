using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1023
{
    class Program
    {
        // File Slide + Compress (.gz)
        public static List<string> Slice(string sourceFile, string destinationDirectory, int parts)
        {
            Console.WriteLine($"Slice File [{destinationDirectory}\\{sourceFile}] ...");
            int part = 0;
            List<string> partnames = new List<string>();
            using (FileStream source = new FileStream(sourceFile, FileMode.Open))
            {
                for (int i = 1; i <= parts; i++)
                {
                    partnames.Add($"{destinationDirectory}\\part_{part}.gz");
                    using (FileStream destination = new FileStream($"{destinationDirectory}\\part_{part}.gz", FileMode.Create))
                    using (GZipStream compress = new GZipStream(destination, CompressionMode.Compress))
                    {
                        byte[] buffer = new byte[source.Length / parts];
                        int read = source.Read(buffer, 0, buffer.Length);
                        compress.Write(buffer, 0, buffer.Length);
                        part++;
                    }
                    Console.WriteLine($"Part [{part}/{parts}]");
                }
                return partnames;
            }
        }

        // File Assemble + Decompress (.gz)
        public static void Assemble(List<string> files, string destinationDirectory)
        {
            Console.WriteLine($"Asemble File [{destinationDirectory}] ...");
            int parts = files.Count;
            using (FileStream destination = new FileStream(destinationDirectory, FileMode.Create))
            {
                for (int part = 0; part < parts; part++)
                {
                    using (FileStream source = new FileStream($"{files[part]}", FileMode.Open))
                    using (GZipStream decompress = new GZipStream(source, CompressionMode.Decompress))
                    {
                        byte[] buffer = new byte[source.Length];
                        decompress.Read(buffer, 0, buffer.Length);
                        destination.Write(buffer, 0, buffer.Length);
                    }
                    Console.WriteLine($"Part [{part}/{parts}]");
                }
            }
        }

        // Main
        static void Main(string[] args)
        {
            var dir = Environment.CurrentDirectory;
            var names = Slice("..\\..\\..\\video.mp4", dir, 5);
            Assemble(names, $"{dir}\\SurfaceBook2.mp4");
        }
    }
}
