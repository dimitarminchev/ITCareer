namespace _101_OddStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("file.txt");

            // v1
            using (reader)
            {
                int lineNumber = 0;
                string lineContent = reader.ReadLine();
                while (lineContent != null) 
                {
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine(lineContent);
                    }
                    lineNumber++;
                    lineContent = reader.ReadLine();
                }

            } // reader.Dispose(); // CleanUp

            //// v2
            //try
            //{
            //    int lineNumber = 0;
            //    while (true)
            //    {
            //        string lineContent = reader.ReadLine();
            //        if (lineNumber % 2 == 1)
            //        {
            //            Console.WriteLine(lineContent);
            //        }
            //        lineNumber++;
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Error: {e.Message}");
            //}
            //finally
            //{
            //    reader.Close(); // CleanUp
            //}
        }
    }
}