namespace Pool.Views
{
    public class View
    {
        public int v { get; set; }

        public int p1 { get; set; }

        public int p2 { get; set; }

        public double h { get; set; }

        public string Response { get; set; }

        public View()
        {
            v = 0;
            p1 = 0;
            p2 = 0;
            h = 0;
            Input();
        }

        private void Input()
        {
            Console.Write("V = ");
            v = int.Parse(Console.ReadLine());

            Console.Write("P1 = ");
            p1 = int.Parse(Console.ReadLine());

            Console.Write("P2 = ");
            p2 = int.Parse(Console.ReadLine());

            Console.Write("H = ");
            h = double.Parse(Console.ReadLine());
        }

        public void ShowResponse()
        {
            Console.WriteLine(Response);
        }
    }
}
