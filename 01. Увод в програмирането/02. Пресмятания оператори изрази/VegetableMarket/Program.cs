namespace VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var VegetablesKgPrice = double.Parse(Console.ReadLine());
            var FruitsKgPrice = double.Parse(Console.ReadLine());
            var VegetablesKg = int.Parse(Console.ReadLine());
            var FruitsKg = int.Parse(Console.ReadLine());

            var Vegetables = (VegetablesKgPrice * VegetablesKg);
            var Fruits = (FruitsKgPrice * FruitsKg);
            var WholePrice = (Vegetables + Fruits);

            Console.WriteLine(WholePrice / 1.94);
        }
    }
}