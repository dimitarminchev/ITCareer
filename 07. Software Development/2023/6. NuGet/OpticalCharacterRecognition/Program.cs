using Tesseract;

namespace OpticalCharacterRecognition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File Path
            string filePath = AppContext.BaseDirectory;
            string fileName = filePath + "tessdata\\test.png";

            // Process Optical Character Recognition (OCR) ...
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