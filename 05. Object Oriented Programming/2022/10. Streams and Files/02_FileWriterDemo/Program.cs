namespace _02_FileWriterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Short Version
            //using (var reader = new StreamReader("Program.cs"))
            //{
            //    using (var writer = new StreamWriter("reversed.txt"))
            //    {
            //        string line = reader.ReadLine();
            //        while (line != null)
            //        {
            //            for (int i = line.Length - 1; i >= 0; i--)
            //            {
            //                writer.Write(line[i]);
            //            }
            //            writer.WriteLine();
            //            line = reader.ReadLine();
            //        }
            //    }
            //}


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