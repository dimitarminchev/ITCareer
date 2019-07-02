using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3212
{
    class Program
    {
        // Hard Drive Folders
        private static Queue<string> folders = new Queue<string>();

        // Process Folder
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
            // root
            ProcessFolder(@"C:\");            
    
            // level 2
            while(folders.Count > 0)
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
