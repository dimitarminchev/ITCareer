namespace _102_LineNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1. Reader
            using (StreamReader reader = new StreamReader("file.txt"))
            {
                // Step 2. Writer
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

                } // writer.Dispose(); // CleanUp
            } // reader.Dispose(); // CleanUp

            // Step 3. Print the result file 'output.txt'
            using (StreamReader reader = new StreamReader("output.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());
            }

        }
    }
}