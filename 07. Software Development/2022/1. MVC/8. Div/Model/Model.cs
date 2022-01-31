namespace _8._Div.Model
{
    internal class Model
    {
        private List<int> numbers;
        public List<int> Numbers
        {
            get { return numbers; }
            set
            {
                if (value.Count(x => x < 1 && x > 1000) == 0) numbers = value;
                else throw new Exception("Incorrrect number value");
            }
        }
        private double p1, p2, p3, n;

        public Model(List<int> numbers)
        {
            Numbers = numbers;
            p1 = 0;
            p2 = 0;
            p3 = 0;
            n = numbers.Count;
        }

        public string Calculate()
        {
            p1 = (double)numbers.Count(x => x % 2 == 0) / n * 100;
            p2 = (double)numbers.Count(x => x % 3 == 0) / n * 100;
            p3 = (double)numbers.Count(x => x % 4 == 0) / n * 100;
            return $"{Math.Round(p1, 2):f2}%\n{Math.Round(p2, 2):f2}%\n{Math.Round(p3, 2):f2}%\n";
        }
    }
}
