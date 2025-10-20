namespace Task1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static List<string> dictionary = new List<string>();

        public static void Main(string[] args)
        {
            for (char a = 'a'; a <= 'z'; a++)
            {
                for (char b = 'a'; b <= 'z'; b++)
                {
                    if (a != b)
                    {
                        dictionary.Add(string.Format($"{a}{b}"));
                    }
                }
            }

            string letters = Console.ReadLine();

            if (dictionary.Contains(letters))
            {
                Console.WriteLine(dictionary.IndexOf(letters) + 1);
            }
            else
            {
                Console.WriteLine("No FuFu");
            }
        }
    }
}
