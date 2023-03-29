namespace FolderSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string searched = "Program.cs";
            Console.WriteLine("Searching for {0}", searched);

            DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] fileInfo = d.GetFiles($"*{searched}*");
            fileInfo = fileInfo.OrderBy(x => x.Extension).ThenBy(x => x.Length).ToArray();

            using (StreamWriter writer = new StreamWriter("report.txt"))
            {
                string lastExt = string.Empty;
                foreach (FileInfo file in fileInfo)
                {
                    if (lastExt != file.Extension)
                    {
                        lastExt = file.Extension;
                        writer.WriteLine($".{lastExt}");
                    }
                    writer.WriteLine($"--{file.Name}.{file.Extension} - {file.Length / 1000}kb");
                }
            }

            using (var reader = new StreamReader("report.txt"))
            {
                Console.WriteLine("report.txt\n---\n{0}", reader.ReadToEnd());
            } 
        }
    }
}