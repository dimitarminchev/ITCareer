using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Reflection Test for NonPublic Fields = 3
            //Type boxType = typeof(Box);
            //FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            //Console.WriteLine("Non Public Fields: " + fields.Count());

            float lenght = float.Parse(Console.ReadLine());
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());

            Box box = new Box(lenght, width, height);

            Console.WriteLine("Surface Area - {0:f2}", box.SurfaceArea());
            Console.WriteLine("Lateral Surface Area - {0:f2}", box.LateralSurfaceArea());
            Console.WriteLine("Volume - {0:f2}", box.Volume());
        }

    }
}
