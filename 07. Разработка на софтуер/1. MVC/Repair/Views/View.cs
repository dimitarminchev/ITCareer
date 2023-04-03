namespace Repair.Views
{
    public class View
    {
        public int N { get; set; }
        public double W { get; set; }
        public double L { get; set; }
        public int M { get; set; }
        public int O { get; set; }
        public string Response { get; set; }

        public View()
        {
            N = 0;
            M = 0;
            L = 0;
            W = 0;
            O = 0;
            Response = string.Empty;
            Input();
        }

        public void Input()
        {
            Console.Write("N = ");
            N = int.Parse(Console.ReadLine());
            Console.Write("W = ");
            W = double.Parse(Console.ReadLine());
            Console.Write("L = ");
            L = double.Parse(Console.ReadLine());
            Console.Write("M = ");
            M = int.Parse(Console.ReadLine());
            Console.Write("O = ");
            O = int.Parse(Console.ReadLine());
        }

        public void ShowResponse()
        {
            Console.WriteLine(Response);
        }
    }
}
