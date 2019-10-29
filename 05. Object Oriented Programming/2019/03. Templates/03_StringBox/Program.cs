using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StringBox
{
    class Program
    {
        // Task 3. String Box
        static void Main(string[] args)
        {
            Box<string> stringBox = new Box<string>();

            // input
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                stringBox.Add( Console.ReadLine() );
                n--;
            }

            // output
            stringBox.Print();
        }
    }
}
