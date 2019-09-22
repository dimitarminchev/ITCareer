using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1021_BinaryFileCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream read = new FileStream("file.png", FileMode.Open))
            {
                using (FileStream write = new FileStream("newfile.png", FileMode.Create))
                {
                    byte[] bytes = new byte[4096];
                    while(true)
                    {
                        int data = read.Read(bytes, 0, bytes.Length);
                        if (data == 0) break;
                        write.Write(bytes, 0, bytes.Count());
                    }
                }
            }
        }
    }
}
