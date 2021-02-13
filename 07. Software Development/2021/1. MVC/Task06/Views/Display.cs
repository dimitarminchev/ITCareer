using System;

namespace Task06.Views
{
    public class Display
    {
        public int V { get; set; }
        public int P1 { get; set; }
        public int P2 { get; set; }
        public double H { get; set; }
        public string Response { get; set; }

        public Display()
        {
            V = 0;
            P1 = 0;
            P2 = 0;
            H = 0;
        }

        public void Input()
        {
            Console.Write("V = ");
            V = int.Parse(Console.ReadLine());
            Console.Write("P1 = ");
            P1 = int.Parse(Console.ReadLine());
            Console.Write("P2 = ");
            P2 = int.Parse(Console.ReadLine());
            Console.Write("H = ");
            H = double.Parse(Console.ReadLine());
        }

        public void ShowResponse()
        {
            Console.WriteLine(Response);
        }
    }
}
