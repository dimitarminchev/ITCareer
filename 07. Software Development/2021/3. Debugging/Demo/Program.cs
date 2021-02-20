using System;

namespace Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Коректен начин да парснем число
                // while (true)
                {
                    var fourtyTwo = int.Parse("42");
                    Console.WriteLine(fourtyTwo);
                }

                // Некоректен начин да парснем число
                var thirtyTwo = int.Parse("thirty two");
                Console.WriteLine(thirtyTwo);

                // Опит за хвърляне на изключение
                throw new Exception("Exception test.");
            }
            catch (Exception ex)
            {
                Console.WriteNegative(ex.Message);
            }
            finally
            {
                System.Console.WriteLine("The End");
            }
        }
    }
}
