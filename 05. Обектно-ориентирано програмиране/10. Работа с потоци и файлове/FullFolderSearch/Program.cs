namespace FullFolderSearch
{
    class Program
    {
        public static string searched = "Program.cs";
        public static string location = "C:\\Users\\mitko\\Desktop";

        static void GetInfo(DirectoryInfo dir)
        {
            DirectoryInfo[] ad = dir.GetDirectories();
            if (ad.Count() != 0)
            {
                foreach (var item in ad)
                {
                    GetInfo(item);
                }
            }
            FileInfo[] fileInfo = dir.GetFiles($"*{searched}*");
            fileInfo = fileInfo.OrderBy(x => x.Extension).ThenBy(x => x.Length).ToArray();

            using (StreamWriter writer = new StreamWriter("report.txt", true))
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
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Searching for {searched} in {location} ...");

            DirectoryInfo dir = new DirectoryInfo(location);
            GetInfo(dir);
            DirectoryInfo[] ad = dir.GetDirectories();
            foreach (var item in ad)
            {
                GetInfo(item);
            }

            using (var reader = new StreamReader("report.txt"))
            {
                Console.WriteLine("report.txt\n---\n{0}", reader.ReadToEnd());
            }
        }
    }
}