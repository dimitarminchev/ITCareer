using System.ComponentModel.DataAnnotations;

namespace _01_WorkingWithFiles
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var reader = new StreamReader("area51.txt");
                using (reader)
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
                // reader.Dispose();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Jobe Done!");
            }
        }
    }
}