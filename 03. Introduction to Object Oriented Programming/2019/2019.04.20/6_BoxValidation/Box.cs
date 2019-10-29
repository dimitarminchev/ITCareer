using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_BoxValidation
{
    class Box
    {
        // дължина
        private float lenght;

        public float Lenght
        {
            get { return lenght; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }
                lenght = value;
            }
        }

        // широчина 
        private float width;

        public float Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        // височина
        private float height;

        public float Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        // конструктор
        public Box(float lenght, float width, float height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        // лице на повърхнина
        public float SurfaceArea()
        {
            return 2 * this.lenght * this.width +
                   2 * this.lenght * this.height +
                   2 * this.width * this.height;
        }

        // околна повърхнина 
        public float LateralSurfaceArea()
        {
            return 2 * this.lenght * this.height +
                   2 * this.width * this.height;
        }

        // обем
        public float Volume()
        {
            return this.lenght * this.width * this.height;
        }
    }
}
