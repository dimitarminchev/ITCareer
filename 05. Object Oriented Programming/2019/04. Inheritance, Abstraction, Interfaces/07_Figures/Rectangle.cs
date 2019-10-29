using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Figures
{
    public class Rectangle : IDrawable
    {
        private int Width;
        private int Height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void Draw()
        {
            DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Height - 1; ++i)
                DrawLine(this.Width, '*', ' ');
            DrawLine(this.Width, '*', '*');
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
                Console.Write(mid);
            Console.WriteLine(end);
        }

    }
}
