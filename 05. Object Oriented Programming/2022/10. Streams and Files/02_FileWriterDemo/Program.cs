namespace _02_FileWriterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read file 'Program.cs'
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

            // Write file 'reversed.txt'
            using (reader)
            {
                StreamWriter writer = new StreamWriter("reversed.txt");
                string lineContent = reader.ReadLine();
                while (lineContent != null)
                {
                    var reversed = new string(lineContent.Reverse().ToArray());
                    writer.WriteLine(reversed);
                    lineContent = reader.ReadLine();
                }
                writer.Close();
            }
            // reader.Dispose();

            reader.Close();

            // Read 'result.txt' and print it
            StreamReader result = new StreamReader("reversed.txt");
            using (result)
            {
                Console.WriteLine(result.ReadToEnd());
            }
            result.Close();
        }
    }
}