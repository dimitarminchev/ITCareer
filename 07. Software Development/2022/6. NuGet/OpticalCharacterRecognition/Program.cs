using System;
using System.Text;
using Tesseract;

namespace OpticalCharacterRecognition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Unicode encoding
            Console.OutputEncoding = Encoding.UTF8;

            // Load image to recognize
            string filePath = AppContext.BaseDirectory;
            string fileName = filePath + "tessdata\\picture.png";

            // Process Optical Character Recognition (OCR) ...
            using (var engine = new TesseractEngine(@"tessdata", "bul"))
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

            // Pause
            var key = Console.ReadKey();
        }
    }
}
