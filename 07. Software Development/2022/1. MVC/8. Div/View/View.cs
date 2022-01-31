namespace _8._Div.View
{
    internal class View
    {
        public int n { get; set; }

        public List<int> numbers { get; set; }

        public string Response { get; set; }

        public View()
        {
            n = 0;
            numbers = new List<int>();
        }

        public void Input()
        {
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
