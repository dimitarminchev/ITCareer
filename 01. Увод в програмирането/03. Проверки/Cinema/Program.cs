namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var row = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());
            var price = 0.0;
            switch (type)
            {
                case "Premiere": price = 12.00; break;
                case "Normal": price = 7.50; break;
                case "Discount": price = 5.00; break;
            }
            var total = row * col * price;
            Console.WriteLine("{0:f2} leva", total);
        }
    }
}