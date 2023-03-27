namespace BoxDataValidation
{
    class Box
    {
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

        public Box(float lenght, float width, float height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public float SurfaceArea()
        {
            return 2 * this.lenght * this.width +
                   2 * this.lenght * this.height +
                   2 * this.width * this.height;
        }

        public float LateralSurfaceArea()
        {
            return 2 * this.lenght * this.height +
                   2 * this.width * this.height;
        }

        public float Volume()
        {
            return this.lenght * this.width * this.height;
        }
    }
}
