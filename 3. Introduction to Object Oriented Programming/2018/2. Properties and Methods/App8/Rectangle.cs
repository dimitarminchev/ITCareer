using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangle
{
    class Rectangle
    {
        // id
        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        // width
        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        // height
        private int heigh;
        public int Heigh
        {
            get { return heigh; }
            set { heigh = value; }
        }
        // horizontally
        private int horizontally;
        public int Horizontally
        {
            get { return horizontally; }
            set { horizontally = value; }
        }

        // vertically
        private int vertically;
        public int Vertically
        {
            get { return vertically; }
            set { vertically = value; }
        }
    }
}