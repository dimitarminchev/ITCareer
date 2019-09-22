using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MemoryStreamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Проблем ли има с кирилицата?
            string text = "This mega amaizing multi app is written in Sliven.";
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            using (var memoryStream = new MemoryStream(bytes))
            {
                while (true)
                {
                    int readByte = memoryStream.ReadByte();
                    if (readByte == -1) break;
                    Console.Write((char)readByte);
                }
            }
 
        }
    }
}
