using Tesseract;

namespace OpticalCharacterRecognition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = AppContext.BaseDirectory + "tessdata\\test.png";
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