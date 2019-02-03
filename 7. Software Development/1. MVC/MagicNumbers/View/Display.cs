using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers.View
{
    class Display
    {
        public int Product { get; set; }
        public List<string> AllMagicNumbers { get; set; }

        public Display()
        {
            this.Product = 0;
            this.AllMagicNumbers = null;
            this.GetValues();
        }

        public void GetValues()
        {
            this.Product = int.Parse(Console.ReadLine());
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", this.AllMagicNumbers));
        }
    }
}
