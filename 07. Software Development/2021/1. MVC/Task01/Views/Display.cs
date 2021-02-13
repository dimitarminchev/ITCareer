using System;

namespace Task01.Views
{
    public class Display
    {

        public string time { get; set; }
        public int kilometers { get; set; }
        public double totalPrice { get; set; }

        public Display()
        {
            time = "";
            kilometers = 0;
            totalPrice = 0;
            GetValues();
        }

        public void GetValues()
        {
            Console.WriteLine("Enter the kilometers you will travel: ");
            kilometers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the phase of the day you will travel (day/night)");
            time = Console.ReadLine();
        }

        public void ShowCheapestWayToTravel()
        {
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
