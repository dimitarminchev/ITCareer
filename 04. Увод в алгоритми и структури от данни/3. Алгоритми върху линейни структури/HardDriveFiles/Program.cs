namespace HardDriveFiles
{
    internal class Program
    {
        private static Queue<string> folders = new Queue<string>();

        private static void ProcessFolder(string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            foreach (var dir in dirs)
            {
                folders.Enqueue(dir);
            }
        }

        public static void Main()
        {
            ProcessFolder(@"C:\");

            while (folders.Count > 0)
            {
                try
                {
                    var folder = folders.Dequeue();
                    Console.WriteLine(folder);
                    ProcessFolder(folder);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: {0}", ex.Message);
                }
            }
        }
    }
}