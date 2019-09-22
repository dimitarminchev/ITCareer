using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1024_FolderSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string searched = Console.ReadLine();
            //string[] files = Directory.GetFiles(Directory.GetCurrentDirectory().ToString());
            DirectoryInfo d = new DirectoryInfo("../../"/*+Directory.GetCurrentDirectory()*/);
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
                    writer.WriteLine($"--{file.Name}.{file.Extension} - {file.Length/1000}kb");
                }
            }
        }
    }
}
