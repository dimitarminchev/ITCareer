using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram.Model
{
    class Histograma
    {
        private int[] numbers;
        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }


        public Histograma(int[] numbers)
        {
            this.Numbers = numbers;
        }

        public double CalculateP1()
        {
            int count = 0;
            for(int i = 0; i<this.Numbers.Count(); i++)
            {
                if (this.Numbers[i] < 200)
                    count++;
            }
            double percent = ( (double) count / this.Numbers.Count()) * 100;
            return percent;
        }

        public double CalculateP2()
        {
            int count = 0;
            for (int i = 0; i < this.Numbers.Count(); i++)
            {
                if (this.Numbers[i] >= 200 && this.Numbers[i] < 400)
                    count++;
            }
            double percent = ((double) count / this.Numbers.Count()) * 100;
            return percent;
        }

        public double CalculateP3()
        {
            int count = 0;
            for (int i = 0; i < this.Numbers.Count(); i++)
            {
                if (this.Numbers[i] >= 400 && this.Numbers[i] < 600)
                    count++;
            }
            double percent = ((double) count / this.Numbers.Count()) * 100;
            return percent;
        }

        public double CalculateP4()
        {
            int count = 0;
            for (int i = 0; i < this.Numbers.Count(); i++)
            {
                if (this.Numbers[i] >= 600 && this.Numbers[i] < 800)
                    count++;
            }
            double percent = ((double) count / this.Numbers.Count()) * 100;
            return percent;
        }

        public double CalculateP5()
        {
            int count = 0;
            for (int i = 0; i < this.Numbers.Count(); i++)
            {
                if (this.Numbers[i] >= 800)
                    count++;
            }
            double percent = ((double) count / this.Numbers.Count()) * 100;
            return percent;
        }

    }
}
