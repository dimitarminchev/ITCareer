using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1025
{
    class Program
    {
        // Append To Report File
        static public void AppendToReport(string line)
        {
            using (StreamWriter writer = new StreamWriter("report.txt", true))
            {
                Console.WriteLine(line);
                writer.WriteLine(line);
            }
        }

        // Directory Listing
        static void Main(string[] args)
        {
            var dir = Environment.CurrentDirectory;
            Console.WriteLine(Environment.CurrentDirectory);
            DirectoryInfo dirinfo = new DirectoryInfo($"{dir}\\..\\..\\..\\");
            List<DirectoryInfo> allDirectories = dirinfo.GetDirectories().ToList();
            allDirectories.Add(dirinfo);
            List<FileInfo> files = new List<FileInfo>();
            for (int i = 0; i < allDirectories.Count; i++)
            {
                files.AddRange(allDirectories[i].GetFiles());
            }

            files = files.OrderBy(file => file.Extension).ThenBy(file => file.Length).ToList();
            string ext = null;
            foreach (FileInfo file in files)
            {
                if (file.Extension != ext)
                {
                    AppendToReport($"{file.Extension}");
                    ext = file.Extension;
                }
                AppendToReport($"--{file.Name} - {file.Length / 1024}kb");
            }
        }
    }
}
