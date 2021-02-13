using System;

namespace Task10.Models
{
    public class Tiles
    {
        public int n;
        public int N
        {
            get { return n; }
            set
            {
                if (value > 0 && value < 101) n = value;
                else throw new Exception("Incorrrect n value");
            }
        }
        public double w;
        public double W
        {
            get { return w; }
            set
            {
                if (value >= 0.1 && value <= 10.00) w = value;
                else throw new Exception("Incorrrect w value");
            }
        }
        public double l;
        public double L
        {
            get { return l; }
            set
            {
                if (value >= 0.1 && value <= 10.00) l = value;
                else throw new Exception("Incorrrect l value");
            }
        }
        public double m;
        public double M
        {
            get { return m; }
            set
            {
                if (value > 0 && value < 11) m = value;
                else throw new Exception("Incorrrect m value");
            }
        }
        public double o;
        public double O
        {
            get { return o; }
            set
            {
                if (value > 0 && value < 11) o = value;
                else throw new Exception("Incorrrect o value");
            }
        }
        public Tiles(int N, double W, double L, int M, int O)
        {
            this.N = N;
            this.W = W;
            this.L = L;
            this.M = M;
            this.O = O;
        }

        public string Calculate()
        {
            double area = n * n;
            area -= m * o;
            double tilesCount = area / (w * l);
            double time = tilesCount * 0.2;
            return $"{tilesCount}\n{time}";
        }
    }
}
