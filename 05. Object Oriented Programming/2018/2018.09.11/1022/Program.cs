using System;
using System.Collections.Generic;
using System.IO;

namespace _1022
{
    class Program
    {
        // File Slide
        public static List<string> Slice(string sourceFile, string destinationDirectory, int parts)
        {
            Console.WriteLine($"Slice File [{destinationDirectory}\\{sourceFile}] ...");
            int part = 0;
            List<string> partnames = new List<string>();
            using (FileStream source = new FileStream(sourceFile, FileMode.Open))
            {
                for (int i = 1; i <= parts; i++)
                {
                    partnames.Add($"{destinationDirectory}\\part_{part}");
                    using (FileStream destination = new FileStream($"{destinationDirectory}\\part_{part}", FileMode.Create))
                    {
                        byte[] buffer = new byte[source.Length / parts];
                        int read = source.Read(buffer, 0, buffer.Length);
                        destination.Write(buffer, 0, buffer.Length);
                        part++;
                    }
                    Console.WriteLine($"Part [{part}/{parts}]");
                }
                return partnames;
            }
        }

        // File Assemble
        public static void Assemble(List<string> files, string destinationDirectory)
        {
            Console.WriteLine($"Asemble File [{destinationDirectory}] ...");
            int parts = files.Count;
            using (FileStream source = new FileStream(destinationDirectory, FileMode.Create))
            {
                for (int part = 0; part < parts; part++)
                {
                    using (FileStream destination = new FileStream($"{files[part]}", FileMode.Open))
                    {
                        byte[] buffer = new byte[destination.Length];
                        destination.Read(buffer, 0, buffer.Length);
                        source.Write(buffer, 0, buffer.Length);
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
