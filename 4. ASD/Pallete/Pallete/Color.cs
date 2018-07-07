using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSkeleton
{
    class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public Color(int red=0, int green=0, int blue=0)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }

        public override string ToString()
        {
            return $"({Red}, {Green}, {Blue})";
        }

        public int CalculatePoints()
        {
            return Red + Green + Blue / 3;
        }
    }

}
