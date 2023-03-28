namespace ArrayMod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool moreThanOne = false;
            int maxCount = 0;
            int number = -1;
            foreach (var item in list)
            {
                int counter = list.Count(c => c == item);
                if (counter >= maxCount && number != item)
                {
                    if (counter == maxCount && !moreThanOne)
                    {
                        moreThanOne = true;
                    }
                    else
                    {
                        maxCount = counter;
                        number = item;
                    }
                }
            }
            double mod = 0;
            if (moreThanOne)
            {
                mod = (double)list.Where(x => list.Count(c => c == x) == maxCount).ToList().Distinct().Sum() / maxCount;
            }
            else
            {
                mod = number;
            }
            Console.WriteLine(mod);
        }
    }
}