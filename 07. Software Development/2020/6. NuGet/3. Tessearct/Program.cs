using System;
using Tesseract;

namespace _3.Tessearct
{
    class Program
    {
        /// <summary>
        /// Оптично разпознаване на символи
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Optical Character Recognition in Progress ...");
            Console.WriteLine(new string('-',50));
            string fileName = "test.png";
            using (var engine = new TesseractEngine(@"tessdata", "eng"))
            {
                using (var image = Pix.LoadFromFile(fileName))
                {
                    using (var page = engine.Process(image))
                    {
                        string text = page.GetText();
                        Console.WriteLine(text);
                    }
                }
            }
        }
    }
}
