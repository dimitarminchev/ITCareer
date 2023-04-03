namespace Repair.Models
{
    public class Model
    {
        private int n;
        public int N
        {
            get { return n; }
            set
            {
                if (value > 0 && value < 101)
                {
                    n = value;
                }
                else
                {
                    throw new Exception("Incorrrect value");
                }
            }
        }

        private double w;
        public double W
        {
            get { return w; }
            set
            {
                if (value >= 0.1 && value <= 10.00)
                {
                    w = value;
                }
                else
                {
                    throw new Exception("Incorrrect value");
                }
            }
        }

        private double l;
        public double L
        {
            get { return l; }
            set
            {
                if (value >= 0.1 && value <= 10.00)
                {
                    l = value;
                }
                else
                {
                    throw new Exception("Incorrrect value");
                }
            }
        }

        private double m;
        public double M
        {
            get { return m; }
            set
            {
                if (value > 0 && value < 11)
                {
                    m = value;
                }
                else
                {
                    throw new Exception("Incorrrect value");
                }
            }
        }

        private double o;
        public double O
        {
            get { return o; }
            set
            {
                if (value > 0 && value < 11)
                {
                    o = value;
                }
                else
                {
                    throw new Exception("Incorrrect value");
                }
            }
        }

        public Model(int N, double W, double L, int M, int O)
        {
            this.N = N;
            this.W = W;
            this.L = L;
            this.M = M;
            this.O = O;
        }

        public Model() : this(0, 0, 0, 0, 0)
        {
            // Empty
        }

        public string CalculateResponse()
        {
            double area = n * n;
            area -= m * o;
            double tilesCount = area / (w * l);
            double time = tilesCount * 0.2;
            return $"{tilesCount}\n{time}";
        }
    }
}
