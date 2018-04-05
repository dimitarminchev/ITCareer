using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Box
    {
        // дължина
        private float lenght;
        public float Lenght
        {
            get { return this.lenght; }
            set { this.lenght = value; }
        }

        // широчина
        private float width;
        public float Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        // височина
        private float height;
        public float Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        // Конструктор
        public Box(float l, float h, float w)
        {
            this.height = h;
            this.lenght = l;
            this.width = w;
        }

        // Площ
        public float SurfaceArea()
        {
            float l = this.lenght;
            float h = this.height;
            float w = this.width;
            return 2 * (l * w + l * h + w * h);
        }

        // Околната повърхнина 
        public float LateralSurfaceArea()
        {
            float l = this.lenght;
            float h = this.height;
            float w = this.width;
            return 2 * (l * h + w * h);
        }

        // Обем
        public float Volume()
        {
            return this.lenght * this.height * this.width;
        }

    }
}
