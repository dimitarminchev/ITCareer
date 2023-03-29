namespace FilePartition
{
    class Program
    {
        private static List<string> Slice(string sourceFile, int parts)
        {
            var files = new List<string>();
            var reversed = new string(sourceFile.Reverse().ToArray());
            string ext = new string(reversed.Substring(0, reversed.IndexOf(".")).Reverse().ToArray());
            using (FileStream read = new FileStream(sourceFile, FileMode.Open))
            {
                int FileLength = (int)read.Length;
                int sizeOfFile = FileLength / parts;
                for (int i = 0; i < parts; i++)
                {
                    var fileName = $"partition_{i}.{ext}";
                    files.Add(fileName);
                    using (FileStream write = new FileStream($"{fileName}", FileMode.Create))
                    {
                        byte[] bytes = new byte[sizeOfFile];
                        int data = read.Read(bytes, 0, bytes.Length);
                        write.Write(bytes, 0, bytes.Count());
                    }
                }
            }
            return files;
        }

        public static void Assemble(List<string> files) 
        {
            string ext = files.First().Substring(files.First().IndexOf(".") + 1);
            using (FileStream write = new FileStream($"assembled.{ext}", FileMode.Create))
            {
                foreach (var item in files)
                {
                    using (FileStream read = new FileStream(string.Format($"{item}"), FileMode.Open))
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

        static void Main(string[] args)
        {
            var files = Slice("video.mp4", 4);
            Console.WriteLine("Step 1. Slice Completed.");
            Assemble(files);
            Console.WriteLine("Step 2. Assemble Completed.");
        }
    }
}