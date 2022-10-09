namespace _104_BinaryFileCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1. Source file
            using (FileStream source = new FileStream("file.png", FileMode.Open))
            {
                // Step 2. Destination file
                using (FileStream destination = new FileStream("newfile.png", FileMode.Create))
                {
                    byte[] bytes = new byte[4096]; // 4 KB
                    while (true)
                    {
                        int data = source.Read(bytes, 0, bytes.Length);
                        if (data == 0) break; // Exit
                        destination.Write(bytes, 0, bytes.Count());
                    }
                } // destination.Dispose() // CleanUp
            } // source.Dispose() // CleanUp
        }
    }
}