using System.ComponentModel.DataAnnotations;
using System.IO.Compression;

namespace _106_Compression
{
    internal class Program
    {
        /// <summary>
        /// Разделя файл на части 
        /// </summary>
        private static void Slice(string sourceFile, int parts)
        {
            using (FileStream read = new FileStream(sourceFile, FileMode.Open))
            {
                int sizeOfFile = ((int)read.Length) / parts;
                for (int i = 0; i < parts; i++)
                {
                    using (FileStream write = new FileStream($"part_{i}", FileMode.Create))
                    {
                        // Compression
                        using (GZipStream gz = new GZipStream(write, CompressionMode.Compress, false))
                        {
                            byte[] bytes = new byte[sizeOfFile];
                            int data = read.Read(bytes, 0, bytes.Length);
                            gz.Write(bytes, 0, bytes.Length);

                        } // gz.Dispose(); => CleanUp
                    } // write.Dispose() => CleanUp
                }
            } // read.Dispose() => CleanUp
        }

        /// <summary>
        /// Комбинира много файлове в един
        /// </summary>
        public static void Assemble()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory().ToString(), "part*");
            
            using (FileStream write = new FileStream($"assembled", FileMode.Create))
            {
                foreach (var item in files)
                {
                    using (FileStream read = new FileStream(item, FileMode.Open))
                    {
                        byte[] bytes = new byte[4096];
                        // Decompression
                        using (GZipStream decompression = new GZipStream(read, CompressionMode.Decompress))
                        {
                            decompression.CopyTo(write);
                        } // decompression.Dispose() => CleanUp
                    } // read.Dispose() => CleanUp
                }
            } // writer.Dispose() => CleanUp
        }

        /// <summary>
        /// Главна програма
        /// </summary>
        static void Main(string[] args)
        {
            int parts = 4;

            // Step 1. Разделя файл на части
            Slice("video.mp4", parts);
            Console.WriteLine("Step 1. Slice Completed.");

            // Step 2. Комбинира много файлове в един
            Assemble();
            Console.WriteLine("Step 2. Assemble Completed.");
        }
    }
}