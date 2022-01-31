namespace _3._Histogram.Model
{
    internal class Model
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


        public Model(double count, List<int> numbers)
        {
            this.count = count;
            this.numbers = numbers;
            this.percents = "";
        }

        public Model() : this(0, new List<int>())
        {
            // nope
        }

        public string FindPercentages()
        {
            var p1 = numbers.Where(x => x < 200).ToList();
            var p2 = numbers.Where(x => x < 400 && x >= 200).ToList();
            var p3 = numbers.Where(x => x < 600 && x >= 400).ToList();
            var p4 = numbers.Where(x => x < 800 && x >= 600).ToList();
            var p5 = numbers.Where(x => x >= 800).ToList();

            percents = $"{(p1.Count / this.count) * 100:f2}%" + Environment.NewLine +
                       $"{(p2.Count / this.count) * 100:f2}%" + Environment.NewLine +
                       $"{(p3.Count / this.count) * 100:f2}%" + Environment.NewLine +
                       $"{(p4.Count / this.count) * 100:f2}%" + Environment.NewLine +
                       $"{(p5.Count / this.count) * 100:f2}%" + Environment.NewLine;

            return percents;
        }
    }
}
