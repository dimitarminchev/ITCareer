using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Box
{
    class Box
    {
        // дължина
        private float lenght;

        // широчина 
        private float width;

        // височина
        private float height;

        // конструктор
        public Box(float lenght, float width, float height)
        {
            this.lenght = lenght;
            this.width = width;
            this.height = height;
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
