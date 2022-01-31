namespace _6._Pool.View
{
    internal class View
    {
        public int V { get; set; }
        public int P1 { get; set; }
        public int P2 { get; set; }
        public double H { get; set; }
        public string Response { get; set; }

        public View()
        {
            this.V = 0;
            this.P1 = 0;
            this.P2 = 0;
            this.H = 0;
        }

        public void Input()
        {
            Console.Write("V = ");
            V = int.Parse(Console.ReadLine());
            Console.Write("P1 = ");
            P1 = int.Parse(Console.ReadLine());
            Console.Write("P2 = ");
            P2 = int.Parse(Console.ReadLine());
            Console.Write("H = ");
            H = double.Parse(Console.ReadLine());
        }

        public void ShowResponse()
        {
            Console.WriteLine(Response);
        }
    }
}
