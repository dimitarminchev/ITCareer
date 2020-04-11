using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace _04.Tesseract
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = Environment.CurrentDirectory;
            string file = String.Concat(dir, "\\test.png");

            using (var engine = new TesseractEngine(@"tessdata", "eng"))
            {
                using (var pic = Pix.LoadFromFile(file))
                {
                    using (var page = engine.Process(pic))
                    {
                        string text = page.GetText();
                        Console.WriteLine(text);
                    }
                }
            }

        }
    }
}
