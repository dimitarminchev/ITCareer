using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonalNumberApp
{
    public class RationalNumber
    {
        // Числител
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        // Знаменател
        private int denom;

        public int Denom
        {
            get { return denom; }
            set { denom = value; }
        }

        // Предефиниране на метод
        public override string ToString()
        {
            return string.Format("{0}/{1}", this.number, this.denom);
        }

        // Най-големия общ делител
        private int BigestDivider(int numerator, int denumerator)
        {
            return denumerator == 0 ? numerator : BigestDivider(denumerator, numerator % denumerator);
        }

        // Конструктор
        public RationalNumber(int numerator = 0, int denumerator = 1)
        {
            int gcd = BigestDivider(numerator, denumerator);
            this.Number = numerator / gcd;
            this.Denom = denumerator / gcd;
        }
    }
}
