using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WorkingWithFiles
{
    class Program 
    {
        // Demo 1. Working with files
        static void Main(string[] args)
        {
            // area51.txt
            Console.Write("Enter filename to read: ");
            string fileName = Console.ReadLine();

            try
            {
                StreamReader reader = new StreamReader(fileName);
                using (reader)
                {
                    int lineNumber = 1;
                    string lineText = reader.ReadLine();
                    while (lineText != null)
                    {
                        Console.WriteLine("{0}: {1}", lineNumber, lineText);
                        lineNumber++;
                        lineText = reader.ReadLine();
                    }
                }
                // Dispose will be executed for reader
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}\nStackTrace: {1}", ex.Message, ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
    
        }
    }
}
