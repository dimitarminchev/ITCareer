using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen.View
{
    class Display
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public List<string> Passwords { get; set; }

        public Display()
        {
            this.FirstNumber = 0;
            this.SecondNumber = 0;
            this.Passwords = null;
            GetValues();
        }

        private void GetValues()
        {
            this.FirstNumber = int.Parse(Console.ReadLine());
            this.SecondNumber = int.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine(string.Join(" ", Passwords));
        }
    }
}
