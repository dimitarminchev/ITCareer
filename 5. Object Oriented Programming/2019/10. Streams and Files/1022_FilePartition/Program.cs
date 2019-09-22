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
            var source = "../../video.mp4";
            var destination = "../../";
            int parts = 3;

            Console.WriteLine("Source: {0}",source);            
            Console.WriteLine("Destination: {0}", destination);            
            Console.WriteLine("Parts: {0}", parts);
            
            // Slice
            var files = Slice(source, destination, parts);
            Console.WriteLine("Sliced!\n");

           
            // Assemble
            Assemble(files, destination);
            Console.WriteLine("Assembled!");
        }

        /// <summary>
        /// Slice
        /// </summary>
        /// <param name="sourceFile"></param>
        /// <param name="destinationDirectory"></param>
        /// <param name="parts"></param>
        /// <returns></returns>
        public static List<string> Slice(string sourceFile, string destinationDirectory, int parts)
        {
            var files = new List<string>();

            var reversed = new string(sourceFile.Reverse().ToArray());
            string ext = new string( reversed.Substring(0, reversed.IndexOf(".")).Reverse().ToArray());

            using (FileStream read = new FileStream(sourceFile, FileMode.Open))
            {
                int FileLength = (int)read.Length /*/ 1024*/;
                int sizeOfFile = FileLength / parts;
                for (int i = 0; i < parts; i++)
                {
                    var fileName = $"partition_{i}.{ext}";
                    files.Add(fileName);
                    using (FileStream write = new FileStream($"{destinationDirectory}/{fileName}", FileMode.Create))
                    {
                        byte[] bytes = new byte[sizeOfFile];
                        int data = read.Read(bytes, 0, bytes.Length);
                        write.Write(bytes, 0, bytes.Count());
                    }
                }
            }
            return files;
        }

        /// <summary>
        /// Assemble
        /// </summary>
        /// <param name="files"></param>
        /// <param name="destinationDirectory"></param>
        public static void Assemble(List<string> files, string destinationDirectory)
        {
            string ext = files.First().Substring(files.First().IndexOf(".") + 1);
            using (FileStream write = new FileStream($"{destinationDirectory}/assembled.{ext}", FileMode.Create))
            {
                foreach (var item in files)
                {
                    using (FileStream read = new FileStream(string.Format($"{destinationDirectory}/{item}"), FileMode.Open))
                    {
                        byte[] bytes = new byte[4096];
                        while (true)
                        {
                            int bytesRead = read.Read(bytes, 0, bytes.Length);
                            if (bytesRead == 0) break;
                            write.Write(bytes, 0, bytesRead);
                        }
                    }
                }
            }
        }
    }
}
