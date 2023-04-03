namespace PasswordGenerator.Views
{
    public class View
    {
        public int n { get; set; }
        public int l { get; set; }
        public string Response { get; set; }

        public View()
        {
            n = 0;
            l = 0;
            Response = String.Empty;
        }

        public void Input()
        {
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("l = ");
            l = int.Parse(Console.ReadLine());
        }

        public void ShowResponse()
        {
            Console.WriteLine(Response);
        }
    }
}
