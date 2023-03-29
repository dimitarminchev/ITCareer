namespace BinaryFileCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream source = new FileStream("file.png", FileMode.Open))
            {
                using (FileStream destination = new FileStream("newfile.png", FileMode.Create))
                {
                    byte[] bytes = new byte[4096]; 
                    while (true)
                    {
                        int data = source.Read(bytes, 0, bytes.Length);
                        if (data == 0) break; 
                        destination.Write(bytes, 0, bytes.Count());
                    }
                } 
            } 
        }
    }
}