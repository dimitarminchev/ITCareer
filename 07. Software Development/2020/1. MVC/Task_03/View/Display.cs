using System;
using System.Collections.Generic;

namespace Task_03.View
{
    public class Display
    {
        public double count { get; set; }
        public List<int> numbers { get; set; }
        public string percents { get; set; }

        public Display()
        {
            count = 0;
            numbers = new List<int>();
            percents = "";
            GetValues();
        }

        public void GetValues()
        {
            Console.WriteLine("Enter how many numbers you want: ");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers on new lines:");
            for (int i = 0; i < count; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
        }

        public void ShowResults()
        {
            Console.WriteLine(percents);
        }
    }
}
