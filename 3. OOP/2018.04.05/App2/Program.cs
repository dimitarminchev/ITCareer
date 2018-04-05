using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            float l = float.Parse(Console.ReadLine());
            float w = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());

            Box Mother = new Box(l, h, w);
            Console.WriteLine("Surface Area – {0:f2}", Mother.SurfaceArea());
            Console.WriteLine("Lateral Surface Area – {0:f2}", Mother.LateralSurfaceArea());
            Console.WriteLine("Volume – {0:f2}", Mother.Volume());
        }
    }
}
