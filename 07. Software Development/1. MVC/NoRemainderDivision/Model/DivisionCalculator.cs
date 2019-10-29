using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoRemainderDivision.Model
{
    class DivisionCalculator
    {
        private int[] numbers;

        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }
        public DivisionCalculator(int[] numbers)
        {
            this.Numbers = numbers;

        }

        public double[] CalculatePercent()
        {
            double[] percent = new double[3];
            int countDiv2 = 0, countDiv3 = 0, countDiv4 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Numbers[i] % 2 == 0)
                    countDiv2++;
                if(Numbers[i] % 3 == 0)
                    countDiv3++;
                if(Numbers[i] % 4 == 0)
                    countDiv4++;
            }
            percent[0] = (double)countDiv2 / numbers.Length * 100;
            percent[1] = (double)countDiv3 / numbers.Length * 100;
            percent[2] = (double)countDiv4 / numbers.Length * 100;

            return percent;

        }

    }
}
