using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1024
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
            DirectoryInfo dirinfo = new DirectoryInfo($"{dir}\\..\\..\\..\\");
            List<FileInfo> files = dirinfo.GetFiles("*.*").ToList();
            files = files.OrderBy(file => file.Extension).ThenBy(file => file.Length).ToList();
            string ext = null;
            foreach (FileInfo file in files)
            {
                if (file.Extension != ext)
                {
                    AppendToReport($"{file.Extension}");
                    ext = file.Extension;
                }
                AppendToReport($"--{file.Name} - {file.Length/1024}kb");
            }
        }
    }
}
