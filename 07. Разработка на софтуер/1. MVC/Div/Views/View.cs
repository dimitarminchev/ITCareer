namespace Div.Views
{
    public class View
    {
        public List<int> numbers { get; set; }

        public string Response { get; set; }

        public View()
        {
            numbers = new List<int>();
            Response = string.Empty;
            Input();
        }

        public void Input()
        {
            int n = numbers.Count;
            while (n < 1 || n > 1000)
            {
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"n[{i + 1}] = ");
                var num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }
        }

        public void ShowResponse()
        {
            Console.WriteLine(Response);
        }
    }
}
