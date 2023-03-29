namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("file.txt"))
            {
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    int lineNumber = 1;
                    string lineContent = reader.ReadLine();
                    while (lineContent != null)
                    {
                        writer.WriteLine($"Line {lineNumber}: {lineContent}");
                        lineNumber++;
                        lineContent = reader.ReadLine();
                    }

                } 
            } 
            using (StreamReader reader = new StreamReader("output.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}