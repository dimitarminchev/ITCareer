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
        // TODO: Fix The Output
        static void Main(string[] args)
        {
            var dir = Environment.CurrentDirectory;
            DirectoryInfo d = new DirectoryInfo($"{dir}\\..\\..\\..\\");
            FileInfo[] Files = d.GetFiles("*.*"); 
            foreach (FileInfo file in Files)
            {
                Console.WriteLine("Name: {0}, Size: {1} KB, Ext: {2}",
                                  file.Name, file.Length / 1024, file.Extension);
            }
        }
    }
}
