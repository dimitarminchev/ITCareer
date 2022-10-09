namespace _01_FileReaderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("Program.cs");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return; // Stop the program
            }

            using (reader)
            {
                int lineNumber = 1;
                string lineContent = reader.ReadLine();
                while(lineContent != null)
                {
                    Console.WriteLine($"Line {lineNumber}: {lineContent}");
                    lineNumber++;
                    lineContent = reader.ReadLine();
                }
            }
            // reader.Dispose();
        }
    }
}