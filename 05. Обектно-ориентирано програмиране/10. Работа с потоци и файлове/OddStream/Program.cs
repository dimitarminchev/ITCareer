namespace OddStream
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("file.txt");
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
            } 
        }
    }
}