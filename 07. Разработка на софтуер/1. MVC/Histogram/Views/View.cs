namespace Histogram.Views
{
    public class View
    {
        public double count { get; set; }
        public List<int> numbers { get; set; }
        public string percents { get; set; }

        public View()
        {
            count = 0;
            numbers = new List<int>();
            percents = String.Empty;
            Input();
        }

        public void Input()
        {
            Console.WriteLine("Enter how many numbers you want: ");
            count = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the numbers on new lines:");
            for (int i = 0; i < count; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
        }

        public void ShowPercents()
        {
            Console.WriteLine(percents);
        }
    }
}
