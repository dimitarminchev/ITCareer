using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRational
{
    public class RacionalNumber
    {
        // Числител
        private int numerator;
        public int Numerator
        {
            get { return this.numerator;  }
            set { this.numerator = value; }
        }

        // Знаменател
        private int denumerator;
        public int Denumerator
        {
            get { return this.denumerator; }
            set { this.denumerator = value; }
        }

        // Печат
        public override string ToString()
        {
            return String.Format("{0}/{1}", this.numerator, this.denumerator);
        }

        // Най-големия общ делител 
        public int BigestDivider(int numerator, int denumerator)
        {
            return denumerator == 0 ? numerator : BigestDivider(denumerator, numerator % denumerator);
        }

        // Конструктор
        public RacionalNumber(int numerator = 0, int denumerator = 1)
        {
            int gcd = BigestDivider(numerator, denumerator);
            this.numerator = numerator/gcd;
            this.denumerator = denumerator / gcd;
        }
    }
}
