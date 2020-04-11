using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_03.Models
{
    public class NumbersCalculate
    {
        private double count;

        public double Count
        {
            get { return count; }
            set { count = value; }
        }

        private List<int> numbers;

        public List<int> Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }

        private string percents;

        public string Percents
        {
            get { return percents; }
            set { percents = value; }
        }

        public NumbersCalculate(double count, List<int> numbers)
        {
            this.count = count;
            this.numbers = numbers;
            this.percents = "";
        }

        public NumbersCalculate() : this(0, new List<int>())
        {

        }

        public string FindPercentages()
        {
            var two = numbers.Where(x => x < 200).ToList();
            var twoToFour = numbers.Where(x => x < 400 && x >= 200).ToList();
            var fourToSix = numbers.Where(x => x < 600 && x >= 400).ToList();
            var sixToEight = numbers.Where(x => x < 800 && x >= 600).ToList();
            var eightToTen = numbers.Where(x => x >= 800).ToList();
            percents = $"{(two.Count / this.count) * 100:f2}%" + Environment.NewLine + $"{(twoToFour.Count / this.count) * 100:f2}%" + Environment.NewLine +
                $"{(fourToSix.Count / this.count) * 100:f2}%" + Environment.NewLine + $"{(sixToEight.Count / this.count) * 100:f2}%" + Environment.NewLine +
                 $"{(eightToTen.Count / this.count) * 100:f2}%" + Environment.NewLine;
            return percents;
        }

    }
}
