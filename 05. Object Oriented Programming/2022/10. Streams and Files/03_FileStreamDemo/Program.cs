using System.Collections;
using System.Security.Cryptography;
using System.Text;

namespace _03_FileStreamDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Text
            string text = "Това е много хубава програма, която написахме в Сливен";

            // Save text to file 'log.txt'
            var fileStream = new FileStream("log.txt", FileMode.Create);
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                fileStream.Write(bytes, 0, bytes.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                fileStream.Close();
            }

            //// v2
            //using (fileStream)
            //{
            //    byte[] bytes = Encoding.UTF8.GetBytes(text);
            //    fileStream.Write(bytes, 0, bytes.Length);
            //} // fileStream.Dispose();

            //// TODO Read the file and print it
            //byte[] byteArray = File.ReadAllBytes("log.txt");
            //string result = System.Text.Encoding.UTF8.GetString(byteArray);
            //Console.WriteLine(result);

        }
    }
}