using System.IO;
using System.Text;

namespace _04_MemoryStreamDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "This is mega amazing super cool text witten in Sliven";
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            // Create memory stream (ms) from byte array (bytes)
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                while (true)
                {
                    // Read from the memory stream [ms]
                    int readByte = ms.ReadByte();
                    if (readByte == -1) break; // Exit
                    Console.Write((char)readByte);
                }

            } // ms.Dispose(); // CleanUp
        }
    }
}