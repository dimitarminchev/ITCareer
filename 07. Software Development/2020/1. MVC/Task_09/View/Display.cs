using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09.View
{
    public class Display
    {
        public int magicNumber { get; set; }
        public List<string> magicNumbers { get; set; }

        public Display()
        {
            magicNumber = 0;
            magicNumbers = new List<string>();
            GetValues();
        }

        public void GetValues()
        {
            Console.WriteLine("Enter the magic number:");
            this.magicNumber = int.Parse(Console.ReadLine());
        }

        public void ShowResults()
        {
            Console.WriteLine(string.Join(" ", magicNumbers));
        }
    }
}
