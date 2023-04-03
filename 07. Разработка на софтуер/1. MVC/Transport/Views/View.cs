namespace Transport.Views
{
    public class View
    {
        public string time { get; set; }

        public int kilometers { get; set; }

        public double totalPrice { get; set; }

        public View()
        {
            time = "";
            kilometers = 0;
            totalPrice = 0;
            GetValues();
        }

        public void GetValues()
        {
            Console.WriteLine("Enter the kilometers you will travel: ");
            kilometers = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the phase of the day you will travel (day/night)");
            time = Console.ReadLine();
        }

        public void ShowCheapestWayToTravel()
        {
            Console.WriteLine($"Total price = {totalPrice:f2}");
        }
    }
}
