namespace Pool.Models
{
    public class Model
    {
        private int v;

        public int V
        {
            get { return v; }
            set
            {
                if (value >= 1 && value <= 10000)
                {
                    v = value;
                }
                else
                {
                    throw new Exception("Incorrrect value");
                }
            }
        }
        
        private int p1;

        public int P1
        {
            get { return p1; }
            set
            {
                if (value >= 1 && value <= 5000)
                {
                    p1 = value;
                }
                else
                {
                    throw new Exception("Incorrrect value");
                }
            }
        }
        
        private int p2;

        public int P2
        {
            get { return p2; }
            set
            {
                if (value >= 1 && value <= 5000)
                {
                    p2 = value;
                }
                else
                {
                    throw new Exception("Incorrrect value");
                }
            }
        }
        
        public double h;
        public double H
        {
            get { return h; }
            set
            {
                if (value >= 1 && value <= 24)
                {
                    h = value;
                }
                else 
                {
                    throw new Exception("Incorrrect h value");
                }
            }
        }

        public Model(int v, int p1, int p2, double h)
        {
            V = v;
            P1 = p1;
            P2 = p2;
            H = h;
        }

        public string CalculateResponse()
        {
            string result = String.Empty;
            double pipe1 = p1 * h;
            double pipe2 = p2 * h;

            var filled = pipe1 + pipe2;

            if (filled <= v)
            {
                result = $"The pool is {(int)(filled / v * 100)} % full.Pipe 1: {(int)(pipe1 / filled * 100)}%. Pipe 2: {(int)(pipe2 / filled * 100)}%.";
            }
            else
            {
                result = $"For {h} hours the pool overflows with {filled - v} liters.";
            }

            return result;
        }
    }
}
