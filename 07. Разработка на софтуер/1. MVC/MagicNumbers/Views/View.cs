namespace MagicNumbers.Views
{
    public class View
    {
        public int magicNumber { get; set; }

        public List<string> magicNumbers { get; set; }

        public View()
        {
            magicNumber = 0;
            magicNumbers = new List<string>();
            GetValues();
        }

        public void GetValues()
        {
            Console.WriteLine("Enter the magic number:");
            this.magicNumber = int.Parse(Console.ReadLine());
        }

        public void ShowResults()
        {
            Console.WriteLine(string.Join(" ", magicNumbers));
        }
    }
}
