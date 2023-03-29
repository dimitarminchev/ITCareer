using System.IO.Compression;

namespace Compression
{
    class Program
    {
        private static void Slice(string sourceFile, int parts)
        {
            using (FileStream read = new FileStream(sourceFile, FileMode.Open))
            {
                int sizeOfFile = ((int)read.Length) / parts;
                for (int i = 0; i < parts; i++)
                {
                    using (FileStream write = new FileStream($"part_{i}", FileMode.Create))
                    {
                        using (GZipStream gz = new GZipStream(write, CompressionMode.Compress, false))
                        {
                            byte[] bytes = new byte[sizeOfFile];
                            int data = read.Read(bytes, 0, bytes.Length);
                            gz.Write(bytes, 0, bytes.Length);

                        } 
                    } 
                }
            } 
        }

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
                        using (GZipStream decompression = new GZipStream(read, CompressionMode.Decompress))
                        {
                            decompression.CopyTo(write);
                        } 
                    } 
                }
            } 
        }

        static void Main(string[] args)
        {
            int parts = 4;
            Slice("video.mp4", parts);
            Console.WriteLine("Step 1. Slice Completed.");
            Assemble();
            Console.WriteLine("Step 2. Assemble Completed.");
        }
    }
}