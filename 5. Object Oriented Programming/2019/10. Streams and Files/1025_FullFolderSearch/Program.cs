using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1025_FullFolderSearch
{
    class Program
    {
        public static string searched;
        static void Main(string[] args)
        {
            StreamWriter r = new StreamWriter("report.txt");
            r.Close();
            searched = Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo("../../");
            GetInfo(dir);
            DirectoryInfo[] ad = dir.GetDirectories();
            foreach (var item in ad)
            {
                GetInfo(item);
            }
            /*FileInfo[] fileInfo = dir.GetFiles($"*{searched}*");
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
            }*/
        }
        static void GetInfo(DirectoryInfo dir)
        {
            DirectoryInfo[] ad = dir.GetDirectories();
            if (ad.Count()!=0)
            foreach (var item in ad)
            {
                GetInfo(item);
            }
            FileInfo[] fileInfo = dir.GetFiles($"*{searched}*");
            fileInfo = fileInfo.OrderBy(x => x.Extension).ThenBy(x => x.Length).ToArray();
            using (StreamWriter writer = new StreamWriter("report.txt",true))
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
    }
}
