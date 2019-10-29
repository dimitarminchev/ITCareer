using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoRemainderDivision.View
{
    class Display
    {
        public int [] Numbers { get; set; }
        public double[] Percent { get; set; }

        public Display()
        {
            Numbers = null;
            Percent = null;
            GetValues();
        }
        private void GetValues ()
        {
            int n = int.Parse(Console.ReadLine());
            Numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Print()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{Percent[i]:f2}%");
            }
        }
    }
}
