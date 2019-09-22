using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1022_FilePartition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Slice");
            Console.Write("SourceFile: ");
            var source = Console.ReadLine();
            Console.Write("DestinationDerictory: ");
            var destination = Console.ReadLine();
            Console.Write("Parts: ");
            int n = int.Parse(Console.ReadLine());
            Slice(source, destination, n);
            Console.WriteLine("Sliced\n");
            Console.WriteLine("Assemble");
            Console.Write("Files: ");
            var files = Console.ReadLine().Split().ToList();
            Console.Write("DestinationDerictory: ");
            destination = Console.ReadLine();
            Assemble(files, destination);
            Console.WriteLine("Assembled");
        }
        public static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            string ext = sourceFile.Substring(sourceFile.IndexOf("." + 1));
            using (FileStream read = new FileStream(sourceFile, FileMode.Open))
            {
                int FileLength = (int)read.Length /*/ 1024*/;
                int sizeOfFile = FileLength / parts;
                for (int i = 0; i < parts; i++)
                {
                    using (FileStream write = new FileStream($"{destinationDirectory}/Part -{i}.{ext}", FileMode.Create))
                    {
                        byte[] bytes = new byte[sizeOfFile];
                        int data = read.Read(bytes, 0, bytes.Length);
                        write.Write(bytes, 0, bytes.Count());
                    }
                }
            }
        }
        public static void Assemble(List<string> files, string destinationDirectory)
        {
            string ext = files.First().Substring(files.First().IndexOf(".") + 1);
            using (FileStream write = new FileStream($"assembled.{ext}", FileMode.Create))
            {
                foreach (var item in files)
                {
                    using (FileStream read = new FileStream(item, FileMode.Open))
                    {
                        byte[] bytes = new byte[4096];
                        while (true)
                        {
                            int data = read.Read(bytes, 0, bytes.Length);
                            if (data == 0) break;
                            write.Write(bytes, 0, bytes.Count());
                        }
                    }
                }
            }
        }
    }
}
