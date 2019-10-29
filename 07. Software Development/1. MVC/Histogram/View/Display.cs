using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram.View
{
    class Display
    {
        public int[] numbers { get; set; }
        public double p1 { get; set; }
        public double p2 { get; set; }
        public double p3 { get; set; }
        public double p4 { get; set; }
        public double p5 { get; set; }

        public Display()
        {
            numbers = null;
            p1 = 0;
            p2 = 0;
            p3 = 0;
            p4 = 0;
            p5 = 0;
            GetValues();
        }

        private void GetValues()
        {
            int n = int.Parse(Console.ReadLine());
            numbers = new int[n];
            for(int i = 0; i< n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        public void PrintValues()
        {
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
