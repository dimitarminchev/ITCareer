namespace BoxClass
{
    class Box
    {
        private float lenght;

        private float width;

        private float height;

        public Box(float lenght, float width, float height)
        {
            this.lenght = lenght;
            this.width = width;
            this.height = height;
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
