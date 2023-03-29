namespace RationalNumber
{
    public class RationalNumber
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private int denom;

        public int Denom
        {
            get { return denom; }
            set { denom = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", this.number, this.denom);
        }

        public RationalNumber(int numerator = 0, int denumerator = 1)
        {
            this.Number = numerator;
            this.Denom = denumerator;
        }
    }
}